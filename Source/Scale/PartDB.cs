﻿/*
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
using TweakScale.Annotations;
using UnityEngine;

namespace TweakScale
{
	public class PartDB
	{
		protected TweakScale ts;
		protected readonly bool IsOnKSP19 = KSPe.Util.KSP.Version.Current >= KSPe.Util.KSP.Version.FindByVersion(1,9,0);
		public readonly Part part;

		/// <summary>
		/// The node scale array. If node scales are defined the nodes will be resized to these values.
		///</summary>
		protected readonly int[] ScaleNodes = { };

		/// <summary>
		/// The unmodified prefab part. From this, default values are found.
		/// </summary>
		public readonly Part prefab;

		protected PartDB(Part prefab, Part part, ScaleType scaleType, TweakScale ts)
		{
			this.prefab = prefab;
			this.part = part;
			this.ScaleNodes = scaleType.ScaleNodes;
			this.ts = ts;
			this.ignoreResourcesForCost = this.prefab.Modules.Contains("FSfuelSwitch");
			if (HighLogic.LoadedSceneIsEditor) this.OnEditorIn();
			GameEvents.onGameSceneSwitchRequested.Add(this.OnGameSceneSwitchRequested);
		}
		internal static PartDB Create(Part prefab, Part part, ScaleType scaleType, TweakScale ts = null)
		{
			bool hasVariants = prefab.Modules.Contains("ModulePartVariants");
			return null == ts
				? new PartDB(prefab, part, scaleType, ts)
				: hasVariants ? (PartDB)new PartVariantScaler(prefab, part, scaleType, ts) : (PartDB)new PartScaler(prefab, part, scaleType, ts);
		}

		internal virtual double CalculateDryCost()
		{
			double dryCost = (this.part.partInfo.cost - this.prefab.Resources.Cast<PartResource> ().Aggregate (0.0, (a, b) => a + b.maxAmount * b.info.unitCost));

			if (dryCost < 0) {
				dryCost = 0;
				Log.error ("RecalculateDryCostWithoutVariant: negative dryCost: part={0}, DryCost={1}", this.part.name, dryCost);
			}
			return dryCost;
		}


		public bool HasCrew
		{
			get
			{
				return this.prefab.CrewCapacity > 0;
			}
		}

		public float RescaleFactor => this.part.rescaleFactor / this.prefab.rescaleFactor;

		// Firespitter FS support
		private bool ignoreResourcesForCost = false;

		public float ModuleCost
		{
			get
			{
				return this.ignoreResourcesForCost
					? (float)this.CalculateDryCost() - this.part.partInfo.cost
					: (float)(this.CalculateDryCost() - part.partInfo.cost + part.Resources.Cast<PartResource>().Aggregate(0.0, (a, b) => a + b.maxAmount * b.info.unitCost));
			}
		}

		internal virtual void Update(ScalingFactor scalingFactor) { }

		internal void FirstUpdate()
		{
			this.ScaleDragCubes(true);
			if (HighLogic.LoadedSceneIsEditor)						// cloned parts and loaded crafts seem to need this (otherwise the node positions revert)
				if (this.IsOnKSP19) this.FirstScalePartKSP19();		// This is needed by (surprisingly!) KSP 1.9
				else this.ScalePart(false, true);					// This was originally shoved on Update() for KSP 1.2 on commit 09d7744
		}

		internal void Scale()
		{
			this.ScalePart(true, false);
			this.ScaleDragCubes(false);
		}

		internal void Rescale()
		{
			this.ScalePart(false, true);
			//this.ScaleDragCubes(true); // I'm unsure if I should enable this. FIXME: TEST, TEST, TEST!
		}

		private void OnGameSceneSwitchRequested(GameEvents.FromToAction<GameScenes, GameScenes> action)
		{
			if (GameScenes.EDITOR == action.to) this.OnEditorIn();
			if (GameScenes.EDITOR == action.from) this.OnEditorOut();
		}

		internal virtual PartDB Destroy () {
			Log.dbg("{0}.Destroy {1} ", this.GetType().Name, this.ts.InstanceID);
			GameEvents.onGameSceneSwitchRequested.Remove(this.OnGameSceneSwitchRequested);
			return null;
		}

		//
		// None of these makes any sense for Prefab!
		//
		protected virtual void FirstScalePartKSP19() { }
		protected virtual void ScalePartTransform() { }
		protected virtual void ScaleDragCubes(bool absolute) { }
		protected virtual void MovePartSurfaceAttachment (bool moveParts, bool absolute) { }
		protected virtual void MoveAttachmentNodes(bool moveParts, bool absolute) { }
		protected virtual void OnEditorIn() { }
		protected virtual void OnEditorOut() { }

		/// <summary>
		/// Updates properties that change linearly with scale.
		/// </summary>
		/// <param name="moveParts">Whether or not to move attached parts.</param>
		/// <param name="absolute">Whether to use absolute or relative scaling.</param>
		private void ScalePart(bool moveParts, bool absolute)
		{
			this.ScalePartTransform();
			this.MovePartSurfaceAttachment(moveParts, absolute);
			this.MoveAttachmentNodes(moveParts, absolute);
		}
	}

	internal class PartScaler : PartDB
	{
		internal PartScaler(Part prefab, Part part, ScaleType scaleType, TweakScale ts) : base(prefab, part, scaleType, ts) { }

		protected override void FirstScalePartKSP19()
		{
			this.ScalePartTransform();
			this.MovePartSurfaceAttachment(false, true);
			this.MoveAttachmentNodes(false, true);
		}

		/// <summary>
		/// Moves <paramref name="node"/> to reflect the new scale. If <paramref name="movePart"/> is true, also moves attached parts.
		/// </summary>
		/// <param name="node">The node to move.</param>
		/// <param name="baseNode">The same node, as found on the prefab part.</param>
		/// <param name="movePart">Whether or not to move attached parts.</param>
		/// <param name="absolute">Whether to use absolute or relative scaling.</param>
		protected void MoveNode(AttachNode node, AttachNode baseNode, bool movePart, bool absolute)
		{
			if (baseNode == null)
			{
				baseNode = node;
				absolute = false;
			}

			Vector3 oldPosition = node.position;

			node.position = absolute
				? baseNode.position * this.ts.ScalingFactor.absolute.linear
				: node.position * this.ts.ScalingFactor.relative.linear
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
					Vector3 offset = node.attachedPart.attPos * (this.ts.ScalingFactor.relative.linear - 1);
					node.attachedPart.transform.Translate(deltaPos + offset, part.transform);
					node.attachedPart.attPos *= this.ts.ScalingFactor.relative.linear;
				}
			}
			ScaleAttachNode(node, baseNode);
		}

		/// <summary>
		/// Change the size of <paramref name="node"/> to reflect the new size of the part it's attached to.
		/// </summary>
		/// <param name="node">The node to resize.</param>
		/// <param name="baseNode">The same node, as found on the prefab part.</param>
		protected void ScaleAttachNode(AttachNode node, AttachNode baseNode)
		{
			if (this.ts.isFreeScale || this.ScaleNodes == null || this.ScaleNodes.Length == 0)
			{
				float tmpBaseNodeSize = baseNode.size;
				if (tmpBaseNodeSize == 0)
				{
					tmpBaseNodeSize = 0.5f;
				}
				node.size = (int)(tmpBaseNodeSize * this.ts.tweakScale / this.ts.defaultScale + 0.49);
			}
			else
			{
				node.size = baseNode.size + (1 * this.ScaleNodes[this.ts.tweakName]);
			}

			if (node.size < 0)
			{
				node.size = 0;
			}
		}

		protected override void MoveAttachmentNodes(bool moveParts, bool absolute)
		{
			int len = part.attachNodes.Count;
			for (int i = 0; i < len; i++) {
				AttachNode node = part.attachNodes [i];
				AttachNode [] nodesWithSameId = part.attachNodes
					.Where (a => a.id == node.id)
					.ToArray ();
				int idIdx = Array.FindIndex (nodesWithSameId, a => a == node);
				AttachNode [] baseNodesWithSameId = this.prefab.attachNodes
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

		protected override void MovePartSurfaceAttachment (bool moveParts, bool absolute)
		{
			MoveNode(part.srfAttachNode, this.prefab.srfAttachNode, moveParts, absolute);
		}

		protected override void ScalePartTransform()
		{
			part.rescaleFactor = this.prefab.rescaleFactor * this.ts.ScalingFactor.absolute.linear;

			Transform trafo = part.partTransform.Find("model");
			if (trafo != null)
			{
				if (this.ts.defaultTransformScale.x == 0.0f)
				{
					this.ts.defaultTransformScale = trafo.localScale;
				}

				// check for flipped signs
				if (this.ts.defaultTransformScale.x * trafo.localScale.x < 0)
				{
					this.ts.defaultTransformScale.x *= -1;
				}
				if (this.ts.defaultTransformScale.y * trafo.localScale.y < 0)
				{
					this.ts.defaultTransformScale.y *= -1;
				}
				if (this.ts.defaultTransformScale.z * trafo.localScale.z < 0)
				{
					this.ts.defaultTransformScale.z *= -1;
				}

				trafo.localScale = this.ts.ScalingFactor.absolute.linear * this.ts.defaultTransformScale;
				trafo.hasChanged = true;
				part.partTransform.hasChanged = true;
			}
		}

		protected override void ScaleDragCubes(bool absolute)
		{
			ScalingFactor.FactorSet factor = absolute
				? this.ts.ScalingFactor.absolute
				: this.ts.ScalingFactor.relative
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

		protected override void OnEditorIn() { Log.dbg("{0}:{1} OnEditorIn", this.GetType().Name, this.ts.InstanceID); }
		protected override void OnEditorOut() { Log.dbg("{0}:{1} OnEditorOut", this.GetType().Name, this.ts.InstanceID); }
	}

	internal class PartVariantScaler : PartScaler
	{
		private PartVariant currentVariant;
		private bool isOnEditorVariantApplied = false;

		internal PartVariantScaler(Part prefab, Part part, ScaleType scaleType, TweakScale ts) : base(prefab, part, scaleType, ts)
		{
			this.currentVariant = null;
		}

		internal void SetVariant (PartVariant partVariant)
		{
			this.currentVariant = partVariant;
		}

		internal override void Update(ScalingFactor scalingFactor)
		{
			base.FirstUpdate();

			foreach (PartVariant p in this.part.variants.variantList)
			{
				p.Cost = this.prefab.variants.variantList[this.prefab.variants.GetVariantIndex(p.Name)].Cost * scalingFactor.absolute.cubic;
				p.Mass = this.prefab.variants.variantList[this.prefab.variants.GetVariantIndex(p.Name)].Mass * scalingFactor.absolute.cubic;
			}
			this.UpdateNodesFromVariant(true, true);
			this.MoveSurfaceAttachedParts();
		}

		internal override PartDB Destroy ()
		{
			if (this.isOnEditorVariantApplied) GameEvents.onEditorVariantApplied.Remove(OnEditorVariantApplied);
			this.isOnEditorVariantApplied = false;
			return base.Destroy();
		}

		protected override void FirstScalePartKSP19()
		{
			this.ScalePartTransform();
			this.MovePartSurfaceAttachment(true, true);
			this.MoveAttachmentNodes(false, true);
		}

		internal override double CalculateDryCost()
		{
			double dryCost = part.baseVariant.Cost + base.CalculateDryCost();
			dryCost += null != this.currentVariant ? this.currentVariant.Cost : 0;

			if (dryCost < 0) {
				dryCost = 0;
				Log.error ("RecalculateDryCostWithVariant: negative dryCost: part={0}, DryCost={1}", this.part.name, dryCost);
			}
			return dryCost;
		}

		protected override void OnEditorIn ()
		{
			base.OnEditorIn ();
			GameEvents.onEditorVariantApplied.Add(OnEditorVariantApplied);
			this.isOnEditorVariantApplied = true;
		}

		protected override void OnEditorOut ()
		{
			base.OnEditorOut ();

			// This thing is being called twice on each event, and I failed to undestand why.
			// Perhaps I'm doing something stupid, but did figured out what yet.
			if (this.isOnEditorVariantApplied) GameEvents.onEditorVariantApplied.Remove(OnEditorVariantApplied);
			this.isOnEditorVariantApplied = false;
		}

		[UsedImplicitly]
		private void OnEditorVariantApplied(Part part, PartVariant partVariant)
		{
			if (!this.ts.enabled) return;
			if (part != this.part) return;
			if (null == partVariant || partVariant != this.currentVariant) return;

			Log.dbg("OnEditorVariantApplied {0} {1}", this.ts.InstanceID, partVariant.Name);
			this.SetVariant(partVariant);
			this.UpdateNodesFromVariant(true, true);
			this.MoveSurfaceAttachedParts();
			this.ts.RescaleIfNeededAndUpdate();
		}

		private void UpdateNodesFromVariant(bool movePart, bool absolute)
		{
			try {
				// support for ModulePartVariants (the stock texture switch module)
				ModulePartVariants pm = this.prefab.Modules["ModulePartVariants"] as ModulePartVariants;
				ModulePartVariants m = this.part.Modules["ModulePartVariants"] as ModulePartVariants;

				int n = pm.variantList.Count;
				for (int i = 0; i < n; i++)
				{
					PartVariant v = m.variantList[i];
					PartVariant pv = pm.variantList[i];
					for (int j = 0; j < v.AttachNodes.Count; j++)
					{
						// the module contains attachNodes, so we need to scale those
						this.MoveNode(v.AttachNodes[j], pv.AttachNodes[j], movePart, absolute);
					}
				}
			} catch (Exception e) {
				Log.warn("Exception during ModulePartVariants interaction" + e.ToString ());
			}
		}

		private void MoveSurfaceAttachedParts()
		{
			int numChilds = this.part.children.Count;
			for (int i = 0; i < numChilds; i++)
			{
				Part child = this.part.children [i];
				if (child.srfAttachNode == null || child.srfAttachNode.attachedPart != part)
					continue;

				Vector3 attachedPosition = child.transform.localPosition + child.transform.localRotation * child.srfAttachNode.position;
				Vector3 targetPosition = attachedPosition * this.ts.ScalingFactor.relative.linear;
				child.transform.Translate (targetPosition - attachedPosition, this.part.transform);
			}
		}
	}

}