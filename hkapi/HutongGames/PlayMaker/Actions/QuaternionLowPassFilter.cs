using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C66 RID: 3174
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Use a low pass filter to reduce the influence of sudden changes in a quaternion Variable.")]
	public class QuaternionLowPassFilter : QuaternionBaseAction
	{
		// Token: 0x0600425F RID: 16991 RVA: 0x0016FA7C File Offset: 0x0016DC7C
		public override void Reset()
		{
			this.quaternionVariable = null;
			this.filteringFactor = 0.1f;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0016FAA4 File Offset: 0x0016DCA4
		public override void OnEnter()
		{
			this.filteredQuaternion = new Quaternion(this.quaternionVariable.Value.x, this.quaternionVariable.Value.y, this.quaternionVariable.Value.z, this.quaternionVariable.Value.w);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0016FB0A File Offset: 0x0016DD0A
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatLowPassFilter();
			}
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0016FB1A File Offset: 0x0016DD1A
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatLowPassFilter();
			}
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0016FB2B File Offset: 0x0016DD2B
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatLowPassFilter();
			}
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0016FB3C File Offset: 0x0016DD3C
		private void DoQuatLowPassFilter()
		{
			this.filteredQuaternion.x = this.quaternionVariable.Value.x * this.filteringFactor.Value + this.filteredQuaternion.x * (1f - this.filteringFactor.Value);
			this.filteredQuaternion.y = this.quaternionVariable.Value.y * this.filteringFactor.Value + this.filteredQuaternion.y * (1f - this.filteringFactor.Value);
			this.filteredQuaternion.z = this.quaternionVariable.Value.z * this.filteringFactor.Value + this.filteredQuaternion.z * (1f - this.filteringFactor.Value);
			this.filteredQuaternion.w = this.quaternionVariable.Value.w * this.filteringFactor.Value + this.filteredQuaternion.w * (1f - this.filteringFactor.Value);
			this.quaternionVariable.Value = new Quaternion(this.filteredQuaternion.x, this.filteredQuaternion.y, this.filteredQuaternion.z, this.filteredQuaternion.w);
		}

		// Token: 0x040046AF RID: 18095
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("quaternion Variable to filter. Should generally come from some constantly updated input")]
		public FsmQuaternion quaternionVariable;

		// Token: 0x040046B0 RID: 18096
		[Tooltip("Determines how much influence new changes have. E.g., 0.1 keeps 10 percent of the unfiltered quaternion and 90 percent of the previously filtered value.")]
		public FsmFloat filteringFactor;

		// Token: 0x040046B1 RID: 18097
		private Quaternion filteredQuaternion;
	}
}
