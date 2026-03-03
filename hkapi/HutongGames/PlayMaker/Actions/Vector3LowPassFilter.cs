using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D1A RID: 3354
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Use a low pass filter to reduce the influence of sudden changes in a Vector3 Variable. Useful when working with Get Device Acceleration to isolate gravity.")]
	public class Vector3LowPassFilter : FsmStateAction
	{
		// Token: 0x06004588 RID: 17800 RVA: 0x00179586 File Offset: 0x00177786
		public override void Reset()
		{
			this.vector3Variable = null;
			this.filteringFactor = 0.1f;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x0017959F File Offset: 0x0017779F
		public override void OnEnter()
		{
			this.filteredVector = new Vector3(this.vector3Variable.Value.x, this.vector3Variable.Value.y, this.vector3Variable.Value.z);
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x001795DC File Offset: 0x001777DC
		public override void OnUpdate()
		{
			this.filteredVector.x = this.vector3Variable.Value.x * this.filteringFactor.Value + this.filteredVector.x * (1f - this.filteringFactor.Value);
			this.filteredVector.y = this.vector3Variable.Value.y * this.filteringFactor.Value + this.filteredVector.y * (1f - this.filteringFactor.Value);
			this.filteredVector.z = this.vector3Variable.Value.z * this.filteringFactor.Value + this.filteredVector.z * (1f - this.filteringFactor.Value);
			this.vector3Variable.Value = new Vector3(this.filteredVector.x, this.filteredVector.y, this.filteredVector.z);
		}

		// Token: 0x040049EB RID: 18923
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Vector3 Variable to filter. Should generally come from some constantly updated input, e.g., acceleration.")]
		public FsmVector3 vector3Variable;

		// Token: 0x040049EC RID: 18924
		[Tooltip("Determines how much influence new changes have. E.g., 0.1 keeps 10 percent of the unfiltered vector and 90 percent of the previously filtered value.")]
		public FsmFloat filteringFactor;

		// Token: 0x040049ED RID: 18925
		private Vector3 filteredVector;
	}
}
