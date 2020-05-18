/*
		This file is part of TweakScale /L
		© 2018-2020 LisiasT
		© 2015-2018 pellinor
		© 2014 Gaius Godspeed and Biotronic

		TweakScale /L is double licensed, as follows:

		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

		And you are allowed to choose the License that better suit your needs.

		TweakScale /L is distributed in the hope that it will be useful,
		but WITHOUT ANY WARRANTY; without even the implied warranty of
		MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

		You should have received a copy of the SKL Standard License 1.0
		along with TweakScale /L. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

		You should have received a copy of the GNU General Public License 2.0
		along with TweakScale /L If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
//using ModuleWheels;

using TweakScale.Annotations;

namespace TweakScale
{    
	public class TweakScale : PartModule, IPartCostModifier, IPartMassModifier
    {
        /// <summary>
        /// The selected scale. Different from currentScale only for destination single update, where currentScale is set to match this.
        /// </summary>
        [KSPField(isPersistant = false, guiActiveEditor = true, guiName = "#TweakScale_GUI_Scale", guiFormat = "0.000", guiUnits = "m")]//Scale
        [UI_ScaleEdit(scene = UI_Scene.Editor)]
// ReSharper disable once InconsistentNaming
        public float tweakScale = -1;

        /// <summary>
        /// Index into scale values array.
        /// </summary>
        [KSPField(isPersistant = false, guiActiveEditor = true, guiName = "#TweakScale_GUI_Scale")]//Scale
        [UI_ChooseOption(scene = UI_Scene.Editor)]
// ReSharper disable once InconsistentNaming
        public int tweakName = 0;

        /// <summary>
        /// The scale to which the part currently is scaled.
        /// </summary>
        [KSPField(isPersistant = true)]
// ReSharper disable once InconsistentNaming
        public float currentScale = -1;

        /// <summary>
        /// The default scale, i.e. the number by which to divide tweakScale and currentScale to get the relative size difference from when the part is used without TweakScale.
        /// </summary>
        [KSPField(isPersistant = true)]
// ReSharper disable once InconsistentNaming
        public float defaultScale = -1;

        /// <summary>
        /// Whether the part should be freely scalable or limited to destination list of allowed values.
        /// </summary>
        [KSPField(isPersistant = false)]
// ReSharper disable once InconsistentNaming
        public bool isFreeScale = false;

        /// <summary>
        /// The scale exponentValue array. If isFreeScale is false, the part may only be one of these scales.
        /// </summary>
        protected float[] ScaleFactors = { 0.625f, 1.25f, 2.5f, 3.75f, 5f };
        
        /// <summary>
        /// The node scale array. If node scales are defined the nodes will be resized to these values.
        ///</summary>
        protected int[] ScaleNodes = { };

        /// <summary>
        /// The unmodified prefab part. From this, default values are found.
        /// </summary>
        private Part _prefabPart;

        /// <summary>
        /// Cached scale vector, we need this because the game regularly reverts the scaling of the IVA overlay
        /// </summary>
        private Vector3 _savedIvaScale;

        /// <summary>
        /// The exponentValue by which the part is scaled by default. When destination part uses MODEL { scale = ... }, this will be different from (1,1,1).
        /// </summary>
        [KSPField(isPersistant = true)]
// ReSharper disable once InconsistentNaming
        public Vector3 defaultTransformScale = new Vector3(0f, 0f, 0f);

        private bool _firstUpdateWithParent = true; // This appears to be unnecessary...
        private bool _firstUpdate = true;
        private bool is_duplicate = false;
        public bool ignoreResourcesForCost = false;
        public bool scaleMass = true;

        /// <summary>
        /// Updaters for different PartModules.
        /// </summary>
        private IRescalable[] _updaters = new IRescalable[0];

        /// <summary>
        /// Cost of unscaled, empty part.
        /// </summary>
        [KSPField(isPersistant = true)]
        public float DryCost;

        /// <summary>
        /// Original Crew Capacity
        /// </summary>
        [KSPField(isPersistant = true)]
        public int OriginalCrewCapacity;

        /// <summary>
        /// scaled mass
        /// </summary>
        [KSPField(isPersistant = false)]
        public float MassScale = 1;

        private Hotkeyable _chainingEnabled;

        /// <summary>
        /// The ScaleType for this part.
        /// </summary>
        public ScaleType ScaleType { get; private set; }

        public bool IsScaled => (Math.Abs(currentScale / defaultScale - 1f) > 1e-5f);
        private bool IsChanged => currentScale != (isFreeScale ? tweakScale : ScaleFactors [tweakName]);

        private bool IsKSP19WithVariants = false;

        /// <summary>
        /// The current scaling factor.
        /// </summary>
        public ScalingFactor ScalingFactor => new ScalingFactor(tweakScale / defaultScale, tweakScale / currentScale, isFreeScale ? -1 : tweakName);

        protected virtual void SetupPrefab()
        {
            Log.dbg("SetupPrefab for {0}", this.part.name);
			ConfigNode PartNode = GameDatabase.Instance.GetConfigs("PART").FirstOrDefault(c => c.name.Replace('_', '.') == part.name).config;
			ConfigNode ModuleNode = PartNode.GetNodes("MODULE").FirstOrDefault(n => n.GetValue("name") == moduleName);

            ScaleType = new ScaleType(ModuleNode);
            SetupFromConfig(ScaleType);
            tweakScale = currentScale = defaultScale;

            tfInterface = Type.GetType("TestFlightCore.TestFlightInterface, TestFlightCore", false);
        }

        /// <summary>
        /// Sets up values from ScaleType, creates updaters, and sets up initial values.
        /// </summary>
        protected virtual void Setup()
        {
            Log.dbg("Setup for {0}", this.part.name);
            _prefabPart = part.partInfo.partPrefab;
            _updaters = TweakScaleUpdater.CreateUpdaters(part).ToArray();

            this.SetupCrewManifest();

            ScaleType = (_prefabPart.Modules["TweakScale"] as TweakScale).ScaleType;
            SetupFromConfig(ScaleType);

            this.HandleChildrenScaling(); // Wrongplace?

            if (!isFreeScale && ScaleFactors.Length != 0)
            {
                tweakName = Tools.ClosestIndex(tweakScale, ScaleFactors);
                tweakScale = ScaleFactors[tweakName];
            }
        }

        protected void RescaleIfNeededAndUpdate()
        {
            if (IsScaled)   this.RescaleAndUpdate();
            else            this.RecalculateDryCost();
        }

        protected void RescaleAndUpdate()
        {
            ScalePart (false, true);
            try {
                CallUpdaters();
            } catch (Exception exception) {
                Log.error("Exception on Rescale: {0}", exception);
            }
            this.NotifyListeners();
        }


        public void RecalculateDryCost()
        {
            this.DryCost = (float)(part.partInfo.cost - _prefabPart.Resources.Cast<PartResource> ().Aggregate (0.0, (a, b) => a + b.maxAmount * b.info.unitCost));
            this.ignoreResourcesForCost |= part.Modules.Contains ("FSfuelSwitch");

            if (this.DryCost < 0) {
                this.DryCost = 0;
                Log.error("RecalculateDryCost: negative dryCost: part={0}, DryCost={1}", this.name, this.DryCost);
            }
        }

        /// <summary>
        /// Loads settings from <paramref name="scaleType"/>.
        /// </summary>
        /// <param name="scaleType">The settings to use.</param>
        private void SetupFromConfig(ScaleType scaleType)
        {
            Log.dbg("SetupFromConfig for {0}", this.part.name);
            if (ScaleType == null) Log.error("Scaletype==null! part={0}", part.name);

            isFreeScale = scaleType.IsFreeScale;
            if (defaultScale == -1)
                defaultScale = scaleType.DefaultScale;

            if (currentScale == -1)
                currentScale = defaultScale;
            else if (defaultScale != scaleType.DefaultScale)
            {
                Log.warn("defaultScale has changed for part {0}: keeping relative scale.", part.name);
                currentScale *= scaleType.DefaultScale / defaultScale;
                defaultScale = scaleType.DefaultScale;
            }

            if (tweakScale == -1)
                tweakScale = currentScale;
            Fields["tweakScale"].guiActiveEditor = false;
            Fields["tweakName"].guiActiveEditor = false;
            ScaleFactors = scaleType.ScaleFactors;
            if (ScaleFactors.Length <= 0)
                return;

            if (isFreeScale)
            {
                Fields["tweakScale"].guiActiveEditor = true;
				UI_ScaleEdit range = (UI_ScaleEdit)Fields["tweakScale"].uiControlEditor;
                range.intervals = scaleType.ScaleFactors;
                range.incrementSlide = scaleType.IncrementSlide;
                range.unit = scaleType.Suffix;
                range.sigFigs = 3;
                Fields["tweakScale"].guiUnits = scaleType.Suffix;
            }
            else
            {
                Fields["tweakName"].guiActiveEditor = scaleType.ScaleFactors.Length > 1;
				UI_ChooseOption options = (UI_ChooseOption)Fields["tweakName"].uiControlEditor;
                ScaleNodes = scaleType.ScaleNodes;
                options.options = scaleType.ScaleNames;
            }
        }

# region Event Handlers
        [UsedImplicitly]
        public override void OnLoad(ConfigNode node)
        {
            Log.dbg("OnLoad {0} {1}", part.name, null != node );

            base.OnLoad(node);

            if (part.partInfo == null)
            {
                // Loading of the prefab from the part config
                _prefabPart = part;
                SetupPrefab();
            }
            else
            {
                // Loading of the part from a saved craft
                tweakScale = currentScale;
                if (HighLogic.LoadedSceneIsEditor || IsScaled)
                { 
                    this.Setup();
                    this.RescaleIfNeededAndUpdate();
                }
                else
                    enabled = false;
            }

            this.IsKSP19WithVariants = KSPe.Util.KSP.Version.Current >= KSPe.Util.KSP.Version.FindByVersion(1,9,0) && this.part.Modules.Contains("ModulePartVariants");
        }

        [UsedImplicitly]
        public override void OnSave(ConfigNode node)
        {
            Log.dbg("OnSave {0}", part.name);

            if (this.is_duplicate)
            {   // Hack to prevent duplicated entries (and duplicated modules) persisting on the craft file
                node.SetValue("name", "TweakScaleRogueDuplicate", 
                    "Programatically tainted due duplicity or any other reason that disabled this instance. Only the first instance above should exist. This section will be eventually deleted once the craft is loaded and saved by a bug free KSP installment. You can safely ignore this section.",
                    false);
            }

            base.OnSave (node);
        }

        [UsedImplicitly]
        public override void OnAwake ()
        {
            Log.dbg("OnAwake {0}", part.name);

            base.OnAwake ();
            if (HighLogic.LoadedSceneIsEditor) this.Setup();
        }

        [UsedImplicitly]
        public override void OnStart(StartState state)
        {
            Log.dbg("OnStart {0}", part.name);

            base.OnStart(state);

            if (HighLogic.LoadedSceneIsEditor)
            {
                if (part.parent != null)
                {
                    _firstUpdateWithParent = false;
                }

                if (_prefabPart.CrewCapacity > 0)
                {
                    GameEvents.onEditorShipModified.Add(OnEditorShipModified);
                }

                _chainingEnabled = HotkeyManager.Instance.AddHotkey(
                    "Scale chaining", new[] {KeyCode.LeftShift}, new[] {KeyCode.LeftControl, KeyCode.K}, false
                    );
            }

            // scale IVA overlay
            if (HighLogic.LoadedSceneIsFlight && enabled && (part.internalModel != null))
            {
                _savedIvaScale = part.internalModel.transform.localScale * ScalingFactor.absolute.linear;
                part.internalModel.transform.localScale = _savedIvaScale;
                part.internalModel.transform.hasChanged = true;
            }
        }

        /// <summary>
        /// Scale has changed!
        /// </summary>
        private void OnTweakScaleChanged()
        {
            Log.dbg("OnTweakScaleChanged {0}", part.name);

            if (!isFreeScale)
            {
                tweakScale = ScaleFactors[tweakName];
            }

            if ((_chainingEnabled != null) && _chainingEnabled.State)
            {
                HandleChildrenScaling();
            }

            ScalePart(true, false);
            ScaleDragCubes(false);
            MarkWindowDirty();
            CallUpdaters();

            currentScale = tweakScale;

            this.UpdateCrewManifest();

            this.NotifyListeners();
        }

        [UsedImplicitly]
        private void OnEditorShipModified(ShipConstruct ship)
        {
            Log.dbg("OnEditorShipModified {0}", part.name);

            this.UpdateCrewManifest();
        }

        [UsedImplicitly]
        public void Update()
        {
            Log.dbgOnce("Update {0} {1:X}", part.name, part.GetInstanceID());

            if (_firstUpdate)
            {
                _firstUpdate = false;
                if (this.FailsIntegrity())
                    return;

                if (this.IsScaled)
                {
                    ScaleDragCubes(true);
                    if (HighLogic.LoadedSceneIsEditor)                  // cloned parts and loaded crafts seem to need this (otherwise the node positions revert)
                        this.ScalePart(this.IsKSP19WithVariants, true); // This was originally shoved on Update() for KSP 1.2 on commit 09d7744
                                                                        // Originally the moveParts was false, but on KSP 1.9, parts with Variants need it to be true.
                }
            }

            if (HighLogic.LoadedSceneIsEditor)
            {
                if (this.currentScale >= 0f)
                {
                    if (this.IsChanged) // user has changed the scale tweakable
                    {
                        // If the user has changed the scale of the part before attaching it, we want to keep that scale.
                        _firstUpdateWithParent = false;
                        this.OnTweakScaleChanged();
                    }
                }
            }
            else
            {
                // flight scene frequently nukes our OnStart resize some time later
                if ((part.internalModel != null) && (part.internalModel.transform.localScale != _savedIvaScale))
                {
                    part.internalModel.transform.localScale = _savedIvaScale;
                    part.internalModel.transform.hasChanged = true;
                }
            }

            if (_firstUpdateWithParent && part.HasParent())
            {
                _firstUpdateWithParent = false;
            }

            this.CallUpdateables();
        }

#endregion

        private void CallUpdaters()
        {
            // two passes, to depend less on the order of this list
            {
                int len = _updaters.Length;
                for (int i = 0; i < len; i++) {
                    // first apply the exponents
                    IRescalable updater = _updaters [i];
                    if (updater is TSGenericUpdater) {
                        float oldMass = part.mass;
                        try {
                            updater.OnRescale (ScalingFactor);
                        } catch (Exception e) {
                            Log.error("Exception on rescale while TSGenericUpdater: {0}", e);
                        } finally {
                            part.mass = oldMass; // make sure we leave this in a clean state
                        }
                    }
                }
            }

            // Why this code was here? We already registered is on the EditorOnChange. Perhaps for older KSP?
            //if (_prefabPart.CrewCapacity > 0 && HighLogic.LoadedSceneIsEditor)
            //    UpdateCrewManifest();

            if (part.Modules.Contains("ModuleDataTransmitter"))
                UpdateAntennaPowerDisplay();

            // MFT support
            UpdateMftModule();

            // TF support
            updateTestFlight();

            // send scaling part message
            // Note: I really think this should be issued only on the final steps (Lisias).
            // TODO: Move this to the NotifyListeners and check for colateral effects on older KPs (<= 1.3.1)
            this.NotifyPartScaleChanged();

            {
                int len = _updaters.Length;
                for (int i = 0; i < len; i++) {
                    IRescalable updater = _updaters [i];
                    // then call other updaters (emitters, other mods)
                    if (updater is TSGenericUpdater)
                        continue;

                    try {
                        updater.OnRescale (ScalingFactor);
                    } catch (Exception e) {
                        Log.error("Exception on rescale while ¬TSGenericUpdater: {0}", e);
                    }
                }
            }
        }

        private void CallUpdateables()
        {
            int len = _updaters.Length;
            for (int i = 0; i < len; i++)
            {
                if (_updaters[i] is IUpdateable)
                    (_updaters[i] as IUpdateable).OnUpdate();
            }
        }

        private void NotifyListeners()
        {
            // Problem: We don't have the slightest idea if the OnPartScaleChanged was already handled or not.
            // If it didn't, this event may induce Recall to cache the part's resource before he could finish his business.
            // So whoever has received that event, he will need to handle OnPartResourceChanged too after, even by us doing it here.

            // send Resource Changed message to KSP Recall if needed
            if (0 != this.part.Resources.Count) this.NotifyPartResourcesChanged ();

            // send AttachNodes Changed message to KSP Recall if needed
            if (0 != this.part.attachNodes.Count) this.NotifyPartAttachmentNodesChanged ();

            this.NotifyPartSurfaceAttachmentChanged(); // This is not working on KSP 1.9, apparently Editor overwrites us before we send the event here!
        }

        private void SetupCrewManifest()
        {
            // Restores the original Crew Capacity, as the Pregab is mangled.
            this.part.CrewCapacity = this.OriginalCrewCapacity;

            VesselCrewManifest vcm = ShipConstruction.ShipManifest;
            if (vcm == null) { return; }
            PartCrewManifest pcm = vcm.GetPartCrewManifest(part.craftID);
            if (pcm == null) { return; }

            if (pcm.partCrew.Length != this.part.CrewCapacity)
                this.SetCrewManifestSize(pcm, this.part.CrewCapacity);
        }

        //only run the following block in the editor; it updates the crew-assignment GUI
        private void UpdateCrewManifest()
        {
            Log.dbg("UpdateCrewManifest {0}", part.craftID);

#if !CREW_SCALE_UP
            // Small safety guard.
            if (part.CrewCapacity >= _prefabPart.CrewCapacity) { return; }
#endif

            try // Preventing this thing triggering an eternal loop on the event handling!
            {
                VesselCrewManifest vcm = ShipConstruction.ShipManifest;
                if (vcm == null) { return; }
                PartCrewManifest pcm = vcm.GetPartCrewManifest(part.craftID);
                if (pcm == null) { return; }

                int len = pcm.partCrew.Length;
                //int newLen = Math.Min(part.CrewCapacity, _prefabPart.CrewCapacity);
                int newLen = part.CrewCapacity;
                if (len == newLen) { return; }

                Log.dbg("UpdateCrewManifest current {0}; new {1}", len, newLen);

                this.part.CrewCapacity  = newLen;
#if CREW_SCALE_UP
    #if PREFAB_SCALE_HACK
                // Workaround to try to force KSP to accept bigger crew manifests at editting time, as apparently it only respects the prefab's value, bluntly ignoring the part's data!
                this._prefabPart.CrewCapacity = Math.Max(this._prefabPart.CrewCapacity, this.part.CrewCapacity);
    #endif
#else
                this.part.CrewCapacity = Math.Min(this.part.CrewCapacity, this._prefabPart.CrewCapacity);
#endif
                if (EditorLogic.fetch.editorScreen == EditorScreen.Crew)
                    EditorLogic.fetch.SelectPanelParts();

                this.SetCrewManifestSize(pcm, newLen);

                ShipConstruction.ShipManifest.SetPartManifest(part.craftID, pcm);
            }
            catch (Exception e)
            {
                Log.error(e, this);
            }
        }

        private void SetCrewManifestSize (PartCrewManifest pcm, int crewCapacity)
        {
            //if (!pcm.AllSeatsEmpty())
            //    for (int i = 0; i < len; i++)
            //        pcm.RemoveCrewFromSeat(i);

            string[] newpartCrew = new string[crewCapacity];
            {
                for (int i = 0; i < newpartCrew.Length; ++i)
                    newpartCrew[i] = string.Empty;

                int SIZE = Math.Min(pcm.partCrew.Length, newpartCrew.Length);
                for (int i = 0; i < SIZE; ++i)
                    newpartCrew[i] = pcm.partCrew[i];
            }
            pcm.partCrew = newpartCrew;
        }

        private void UpdateMftModule()
        {
            try
            {
                if (_prefabPart.Modules.Contains("ModuleFuelTanks"))
                {
                    scaleMass = false;
					PartModule m = _prefabPart.Modules["ModuleFuelTanks"];
                    FieldInfo fieldInfo = m.GetType().GetField("totalVolume", BindingFlags.Public | BindingFlags.Instance);
                    if (fieldInfo != null)
                    {
                        double oldVol = (double)fieldInfo.GetValue(m) * 0.001d;
						BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
                        data.Set<string>("volName", "Tankage");
                        data.Set<double>("newTotalVolume", oldVol * ScalingFactor.absolute.cubic);
                        part.SendEvent("OnPartVolumeChanged", data, 0);
                    }
                    else Log.warn("MFT interaction failed (fieldinfo=null)");
                }
            }
            catch (Exception e)
            {
                Log.warn("Exception during MFT interaction" + e.ToString());
            }
        }

        public static Type tfInterface = null;
        private void updateTestFlight()
        {
            if (null == tfInterface) return;
            BindingFlags tBindingFlags = BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static;
            string _name = "scale";
            string value = ScalingFactor.absolute.linear.ToString();
            string owner = "TweakScale";

            bool valueAdded = (bool)tfInterface.InvokeMember("AddInteropValue", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, new System.Object[] { part, _name, value, owner });
            Log.dbg("TF: valueAdded={0}, value={1}", valueAdded, value);
        }

        private void UpdateAntennaPowerDisplay()
        {
			ModuleDataTransmitter m = part.Modules["ModuleDataTransmitter"] as ModuleDataTransmitter;
            double p = m.antennaPower / 1000;
            Char suffix = 'k';
            if (p >= 1000)
            {
                p /= 1000f;
                suffix = 'M';
                if (p >= 1000)
                {
                    p /= 1000;
                    suffix = 'G';
                }
            }
            p = Math.Round(p, 2);
            string str = p.ToString() + suffix;
            if (m.antennaCombinable) { str += " (Combinable)"; }
            m.powerText = str;
        }

        /// <summary>
        /// Updates properties that change linearly with scale.
        /// </summary>
        /// <param name="moveParts">Whether or not to move attached parts.</param>
        /// <param name="absolute">Whether to use absolute or relative scaling.</param>
        private void ScalePart(bool moveParts, bool absolute)
        {
            this.ScalePartTransform();
            this.MoveAttachmentNodes(moveParts, absolute);
            this.MoveModulePartVariants();

            this.MovePartSurfaceAttachment(moveParts, absolute);
            if (moveParts) this.MoveParts();
        }

        private void MoveModulePartVariants()
        {
            try {
                // support for ModulePartVariants (the stock texture switch module)
                if (_prefabPart.Modules.Contains ("ModulePartVariants")) {
                    ModulePartVariants pm = _prefabPart.Modules ["ModulePartVariants"] as ModulePartVariants;
                    ModulePartVariants m = part.Modules ["ModulePartVariants"] as ModulePartVariants;

                    int n = pm.variantList.Count;
                    for (int i = 0; i < n; i++) {
                        PartVariant v = m.variantList [i];
                        PartVariant pv = pm.variantList [i];
                        for (int j = 0; j < v.AttachNodes.Count; j++) {
                            // the module contains attachNodes, so we need to scale those
                            MoveNode(v.AttachNodes[j], pv.AttachNodes[j], false, true);
                        }
                    }
                }
            } catch (Exception e) {
                Log.warn("Exception during ModulePartVariants interaction" + e.ToString ());
            }
        }

        private void MoveAttachmentNodes(bool moveParts, bool absolute)
        {
            int len = part.attachNodes.Count;
            for (int i = 0; i < len; i++) {
                AttachNode node = part.attachNodes [i];
                AttachNode [] nodesWithSameId = part.attachNodes
                    .Where (a => a.id == node.id)
                    .ToArray ();
                int idIdx = Array.FindIndex (nodesWithSameId, a => a == node);
                AttachNode [] baseNodesWithSameId = _prefabPart.attachNodes
                    .Where (a => a.id == node.id)
                    .ToArray ();
                if (idIdx < baseNodesWithSameId.Length) {
                    AttachNode baseNode = baseNodesWithSameId [idIdx];

                    MoveNode (node, baseNode, moveParts, absolute);
                } else {
                    Log.warn("Error scaling part. Node {0} does not have counterpart in base part.", node.id);
                }
            }
        }

        private void MovePartSurfaceAttachment (bool moveParts, bool absolute)
        {
            MoveNode(part.srfAttachNode, _prefabPart.srfAttachNode, moveParts, absolute);
        }

        private void MoveParts()
        {
            int numChilds = part.children.Count;
            for (int i = 0; i < numChilds; i++) {
                Part child = part.children [i];
                if (child.srfAttachNode == null || child.srfAttachNode.attachedPart != part)
                    continue;

                Vector3 attachedPosition = child.transform.localPosition + child.transform.localRotation * child.srfAttachNode.position;
                Vector3 targetPosition = attachedPosition * ScalingFactor.relative.linear;
                child.transform.Translate (targetPosition - attachedPosition, part.transform);
            }
        }

        private void ScalePartTransform()
        {
            part.rescaleFactor = _prefabPart.rescaleFactor * ScalingFactor.absolute.linear;

			Transform trafo = part.partTransform.Find("model");
            if (trafo != null)
            {
                if (defaultTransformScale.x == 0.0f)
                {
                    defaultTransformScale = trafo.localScale;
                }

                // check for flipped signs
                if (defaultTransformScale.x * trafo.localScale.x < 0)
                {
                    defaultTransformScale.x *= -1;
                }
                if (defaultTransformScale.y * trafo.localScale.y < 0)
                {
                    defaultTransformScale.y *= -1;
                }
                if (defaultTransformScale.z * trafo.localScale.z < 0)
                {
                    defaultTransformScale.z *= -1;
                }

                trafo.localScale = ScalingFactor.absolute.linear * defaultTransformScale;
                trafo.hasChanged = true;
                part.partTransform.hasChanged = true;
            }
        }

        /// <summary>
        /// Change the size of <paramref name="node"/> to reflect the new size of the part it's attached to.
        /// </summary>
        /// <param name="node">The node to resize.</param>
        /// <param name="baseNode">The same node, as found on the prefab part.</param>
        private void ScaleAttachNode(AttachNode node, AttachNode baseNode)
        {
            if (isFreeScale || ScaleNodes == null || ScaleNodes.Length == 0)
            {
                float tmpBaseNodeSize = baseNode.size;
                if (tmpBaseNodeSize == 0)
                {
                    tmpBaseNodeSize = 0.5f;
                }
                node.size = (int)(tmpBaseNodeSize * tweakScale / defaultScale + 0.49);
            }
            else
            {
                node.size = baseNode.size + (1 * ScaleNodes[tweakName]);
            }
            if (node.size < 0)
            {
                node.size = 0;
            }
        }

        private void ScaleDragCubes(bool absolute)
        {
            ScalingFactor.FactorSet factor = absolute 
                ? ScalingFactor.absolute 
                : ScalingFactor.relative
        ;
            if (factor.linear == 1)
                return;

            int len = part.DragCubes.Cubes.Count;
            for (int ic = 0; ic < len; ic++)
            {
                DragCube dragCube = part.DragCubes.Cubes[ic];
                dragCube.Size *= factor.linear;
                for (int i = 0; i < dragCube.Area.Length; i++)
                    dragCube.Area[i] *= factor.quadratic;

                for (int i = 0; i < dragCube.Depth.Length; i++)
                    dragCube.Depth[i] *= factor.linear;
            }
            part.DragCubes.ForceUpdate(true, true);
        }

        /// <summary>
        /// Moves <paramref name="node"/> to reflect the new scale. If <paramref name="movePart"/> is true, also moves attached parts.
        /// </summary>
        /// <param name="node">The node to move.</param>
        /// <param name="baseNode">The same node, as found on the prefab part.</param>
        /// <param name="movePart">Whether or not to move attached parts.</param>
        /// <param name="absolute">Whether to use absolute or relative scaling.</param>
        private void MoveNode(AttachNode node, AttachNode baseNode, bool movePart, bool absolute)
        {
            if (baseNode == null)
            {
                baseNode = node;
                absolute = false;
            }

			Vector3 oldPosition = node.position;

            node.position = absolute 
                ? baseNode.position * ScalingFactor.absolute.linear 
                : node.position * ScalingFactor.relative.linear
            ;

            Vector3 deltaPos = node.position - oldPosition;

            if (movePart && node.attachedPart != null)
            {
                if (node.attachedPart == part.parent)
                {
                    part.transform.Translate(-deltaPos, part.transform);
                }
                else
                {
					Vector3 offset = node.attachedPart.attPos * (ScalingFactor.relative.linear - 1);
                    node.attachedPart.transform.Translate(deltaPos + offset, part.transform);
                    node.attachedPart.attPos *= ScalingFactor.relative.linear;
                }
            }
            ScaleAttachNode(node, baseNode);
        }

        /// <summary>
        /// Propagate relative scaling factor to children.
        /// </summary>
        private void HandleChildrenScaling()
        {
            int len = part.children.Count;
            for (int i=0; i< len; i++)
            {
				Part child = part.children[i];
				TweakScale b = child.GetComponent<TweakScale>();
                if (b == null)
                    continue;

                float factor = ScalingFactor.relative.linear;
                if (Math.Abs(factor - 1) <= 1e-4f)
                    continue;

                b.tweakScale *= factor;
                if (!b.isFreeScale && (b.ScaleFactors.Length > 0))
                {
                    b.tweakName = Tools.ClosestIndex(b.tweakScale, b.ScaleFactors);
                }
                b.OnTweakScaleChanged();
            }
        }

        /// <summary>
        /// Disable TweakScale module if something is wrong.
        /// </summary>
        /// <returns>True if something is wrong, false otherwise.</returns>
        private bool FailsIntegrity()
        {
            if (this != part.Modules.GetModules<TweakScale>().First())
            {
                enabled = false; // disable TweakScale module
                this.is_duplicate = true; // Flags this as not persistent
                Log.warn("Duplicate TweakScale module on part [{0}] {1}", part.partInfo.name, part.partInfo.title);
                Fields["tweakScale"].guiActiveEditor = false;
                Fields["tweakName"].guiActiveEditor = false;
                return true;
            }
            if (ScaleFactors.Length == 0)
            {
                enabled = false; // disable TweakScale module
                Log.warn("{0}({1}) has no valid scale factors. This is probably caused by an invalid TweakScale configuration for the part.", part.name, part.partInfo.title);
                Log.dbg(this.ToString());
                Log.dbg(ScaleType.ToString());
                return true;
            }
            return false;
        }


        # region Public Interface

        /// <summary>
        /// Marks the right-click window as dirty (i.e. tells it to update).
        /// </summary>
        private void MarkWindowDirty() // redraw the right-click window with the updated stats
        {
            foreach (UIPartActionWindow win in FindObjectsOfType<UIPartActionWindow>().Where(win => win.part == part))
            {
                // This causes the slider to be non-responsive - i.e. after you click once, you must click again, not drag the slider.
                win.displayDirty = true;
            }
        }

        public float GetModuleCost(float defaultCost, ModifierStagingSituation situation)
        {
            if (IsScaled)
                if (ignoreResourcesForCost)
                  return (DryCost - part.partInfo.cost);
                else
                  return (float)(DryCost - part.partInfo.cost + part.Resources.Cast<PartResource>().Aggregate(0.0, (a, b) => a + b.maxAmount * b.info.unitCost));
            else
              return 0;
        }

        public ModifierChangeWhen GetModuleCostChangeWhen()
        {
            return ModifierChangeWhen.FIXED;
        }

        public float GetModuleMass(float defaultMass, ModifierStagingSituation situation)
        {
            if (IsScaled && scaleMass)
              return _prefabPart.mass * (MassScale - 1f);
            else
              return 0;
        }

        public ModifierChangeWhen GetModuleMassChangeWhen()
        {
            return ModifierChangeWhen.FIXED;
        }

        //
        // These are meant for use with an unloaded part (so you only have the persistent data
        // but the part is not alive). In this case get currentScale/defaultScale and call
        // this method on the prefab part.
        //

        public double MassFactor => this.getMassFactor((double)(this.currentScale / this.defaultScale));
        public double getMassFactor(double rescaleFactor)
        {
            double exponent = ScaleExponents.getMassExponent(this.ScaleType.Exponents);
            return Math.Pow(rescaleFactor, exponent);
        }

        public double DryCostFactor => this.getDryCostFactor((double)(this.currentScale / this.defaultScale));
        public double getDryCostFactor(double rescaleFactor)
        {
            double exponent = ScaleExponents.getDryCostExponent(ScaleType.Exponents);
            return Math.Pow(rescaleFactor, exponent);
        }

        public double VolumeFactor => this.getVolumeFactor((double)(this.currentScale / this.defaultScale));
        public double getVolumeFactor(double rescaleFactor)
        {
            return Math.Pow(rescaleFactor, 3);
        }

        #endregion


        # region Event Senders

        private void NotifyPartScaleChanged ()
        {
            BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
            data.Set<float>("factorAbsolute", ScalingFactor.absolute.linear);
            data.Set<float>("factorRelative", ScalingFactor.relative.linear);
            part.SendEvent("OnPartScaleChanged", data, 0);
        }

        private void NotifyPartAttachmentNodesChanged()
        {
            BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
            data.Set<int>("InstanceID", this.part.GetInstanceID());
            data.Set<Type>("issuer", this.GetType());
            part.SendEvent("NotifyPartAttachmentNodesChanged", data, 0);
        }

        private void NotifyPartSurfaceAttachmentChanged()
        {
            BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
            data.Set<int>("InstanceID", this.part.GetInstanceID ());
            data.Set<Type>("issuer", this.GetType ());
            data.Set<AttachNode>("srfAttachNode", this.part.srfAttachNode);
            part.SendEvent("OnPartSurfaceAttachmentChanged", data, 0);
        }

        private void NotifyPartResourcesChanged ()
        {
            BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
            data.Set<int>("InstanceID", this.part.GetInstanceID ());
            data.Set<Type>("issuer", this.GetType ());
            part.SendEvent("OnPartResourcesChanged", data, 0);
        }

        #endregion


        public override string ToString()
        {
            string result = string.Format("TweakScale:{0} {{", this.name);
            result += "; isFreeScale = " + isFreeScale;
            result += "; " + ScaleFactors.Length  + " scaleFactors = ";
            foreach (float s in ScaleFactors)
                result += s + "  ";
            result += "; tweakScale = "   + tweakScale;
            result += "; currentScale = " + currentScale;
            result += "; defaultScale = " + defaultScale;
            result += "; scaleNodes = " + ScaleNodes;
            //result += "; minValue = " + MinValue;
            //result += "; maxValue = " + MaxValue;
            return result + "}";
        }


#if DEBUG        
        [KSPEvent(guiActive = false, active = true)]
        internal void OnPartScaleChanged(BaseEventDetails data)
        {
            float factorAbsolute = data.Get<float>("factorAbsolute");
            float factorRelative = data.Get<float>("factorRelative");
            Log.dbg("PartMessage: OnPartScaleChanged:"
                + "\npart=" + part.name
                + "\nfactorRelative=" + factorRelative.ToString()
                + "\nfactorAbsolute=" + factorAbsolute.ToString());

        }

        [KSPEvent(guiActive = true, guiActiveEditor = true, guiName = "Debug")]
        internal void debugOutput()
        {
            AvailablePart ap = part.partInfo;
            Log.dbg("prefabCost={0}, dryCost={1}, prefabDryCost={2}", ap.cost, DryCost, (_prefabPart.Modules["TweakScale"] as TweakScale).DryCost);
            Log.dbg("kisVolOvr={0}", part.Modules["ModuleKISItem"].Fields["volumeOverride"].GetValue(part.Modules["ModuleKISItem"]));
            Log.dbg("ResourceCost={0}", (part.Resources.Cast<PartResource>().Aggregate(0.0, (a, b) => a + b.maxAmount * b.info.unitCost) ));

            {
                TweakScale ts = part.partInfo.partPrefab.Modules ["TweakScale"] as TweakScale;
                Log.dbg("massFactor={0}", ts.MassFactor);
                Log.dbg("costFactor={0}", ts.DryCostFactor);
                Log.dbg("volFactor={0}", ts.VolumeFactor);
            }

            Collider x = part.collider;
            Log.dbg("C: {0}, enabled={1}", x.name, x.enabled);
            if (part.Modules.Contains("ModuleRCSFX")) {
                Log.dbg("RCS power={0}", (part.Modules["ModuleRCSFX"] as ModuleRCSFX).thrusterPower);
            }
            if (part.Modules.Contains("ModuleEnginesFX"))
            {
                Log.dbg("Engine thrust={0}", (part.Modules["ModuleEnginesFX"] as ModuleEnginesFX).maxThrust);
            }
        }
#endif

    }
}
