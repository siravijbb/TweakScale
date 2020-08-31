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
using TweakScale.Annotations;

namespace TweakScale
{
	public class PartDB
	{
		private readonly TweakScale ts;
		/// <summary>
        /// The unmodified prefab part. From this, default values are found.
        /// </summary>
        public readonly Part prefab;
		public readonly Part part;
		public readonly bool HasVariants;

		private PartVariant currentVariant;

		public PartDB(Part prefab, Part part, TweakScale ts)
		{
			this.ts = ts;
			this.prefab = prefab;
			this.part = part;
			this.HasVariants = this.prefab.Modules.Contains("ModulePartVariants");
			this.ignoreResourcesForCost = this.prefab.Modules.Contains("FSfuelSwitch");
			this.currentVariant = null;

			if (this.HasVariants) GameEvents.onEditorVariantApplied.Add(OnEditorVariantApplied); 
		}

		public double DryCost
		{
			get
			{
				return this.HasVariants ? this.CalculateDryCostWithVariant() : this.CalculateDryCostWithoutVariant();
			}
		}

		public bool HasCrew
		{
			get
			{
				return this.prefab.CrewCapacity > 0;
			}
		}

		public float RescaleFactor => this.part.rescaleFactor / this.prefab.rescaleFactor;

		public string InstanceID => string.Format("{0}:{1:X}", this.part.name, this.part.GetInstanceID());

		internal void SetVariant (PartVariant partVariant)
		{
			this.currentVariant = partVariant;
		}

		private double CalculateDryCostWithVariant()
		{
			double dryCost = part.baseVariant.Cost + this.CalculateDryCostWithoutVariant();
			dryCost += null != this.currentVariant ? this.currentVariant.Cost : 0;

			if (dryCost < 0) {
				dryCost = 0;
				Log.error ("RecalculateDryCostWithVariant: negative dryCost: part={0}, DryCost={1}", this.part.name, dryCost);
			}
			return dryCost;
		}

		private double CalculateDryCostWithoutVariant()
		{
			double dryCost = (part.partInfo.cost - this.prefab.Resources.Cast<PartResource> ().Aggregate (0.0, (a, b) => a + b.maxAmount * b.info.unitCost));

			if (dryCost < 0) {
				dryCost = 0;
				Log.error ("RecalculateDryCostWithoutVariant: negative dryCost: part={0}, DryCost={1}", this.part.name, dryCost);
			}
			return dryCost;
		}

		// Firespitter FS support
		private bool ignoreResourcesForCost = false;

		public float ModuleCost
		{
			get
			{
				return this.ignoreResourcesForCost
					? (float)this.DryCost - this.part.partInfo.cost
					: (float)(DryCost - part.partInfo.cost + part.Resources.Cast<PartResource>().Aggregate(0.0, (a, b) => a + b.maxAmount * b.info.unitCost));
			}
		}

		internal void Update(ScalingFactor scalingFactor)
		{
			foreach (PartVariant p in this.part.variants.variantList)
			{
				p.Cost = this.prefab.variants.variantList[this.prefab.variants.GetVariantIndex(p.Name)].Cost * scalingFactor.absolute.cubic;
				p.Mass = this.prefab.variants.variantList[this.prefab.variants.GetVariantIndex(p.Name)].Mass * scalingFactor.absolute.cubic;
			}
		}

		internal void Destroy ()
		{
			if (this.HasVariants) GameEvents.onEditorVariantApplied.Remove(OnEditorVariantApplied);
		}

		[UsedImplicitly]
		private void OnEditorVariantApplied(Part part, PartVariant partVariant)
		{
			if (!this.ts.enabled) return;

			Log.dbg("OnEditorVariantApplied {0}:{1:X} {2}", part.name, part.GetInstanceID(), partVariant?.Name);
			this.SetVariant(partVariant);
			this.ts.RecalculateDryCost();
			this.ts.RescaleIfNeededAndUpdate();
		}

	}
}
