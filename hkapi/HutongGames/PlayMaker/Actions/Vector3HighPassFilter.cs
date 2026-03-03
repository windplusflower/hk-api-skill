using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D16 RID: 3350
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Use a high pass filter to isolate sudden changes in a Vector3 Variable. Useful when working with Get Device Acceleration to remove the constant effect of gravity.")]
	public class Vector3HighPassFilter : FsmStateAction
	{
		// Token: 0x06004577 RID: 17783 RVA: 0x001791AF File Offset: 0x001773AF
		public override void Reset()
		{
			this.vector3Variable = null;
			this.filteringFactor = 0.1f;
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x001791C8 File Offset: 0x001773C8
		public override void OnEnter()
		{
			this.filteredVector = new Vector3(this.vector3Variable.Value.x, this.vector3Variable.Value.y, this.vector3Variable.Value.z);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00179208 File Offset: 0x00177408
		public override void OnUpdate()
		{
			this.filteredVector.x = this.vector3Variable.Value.x - (this.vector3Variable.Value.x * this.filteringFactor.Value + this.filteredVector.x * (1f - this.filteringFactor.Value));
			this.filteredVector.y = this.vector3Variable.Value.y - (this.vector3Variable.Value.y * this.filteringFactor.Value + this.filteredVector.y * (1f - this.filteringFactor.Value));
			this.filteredVector.z = this.vector3Variable.Value.z - (this.vector3Variable.Value.z * this.filteringFactor.Value + this.filteredVector.z * (1f - this.filteringFactor.Value));
			this.vector3Variable.Value = new Vector3(this.filteredVector.x, this.filteredVector.y, this.filteredVector.z);
		}

		// Token: 0x040049D8 RID: 18904
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Vector3 Variable to filter. Should generally come from some constantly updated input, e.g., acceleration.")]
		public FsmVector3 vector3Variable;

		// Token: 0x040049D9 RID: 18905
		[Tooltip("Determines how much influence new changes have.")]
		public FsmFloat filteringFactor;

		// Token: 0x040049DA RID: 18906
		private Vector3 filteredVector;
	}
}
