using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FF RID: 2303
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the value of a float parameter")]
	public class SetAnimatorFloat : FsmStateActionAnimatorBase
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x00134253 File Offset: 0x00132453
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.dampTime = new FsmFloat
			{
				UseVariable = true
			};
			this.Value = null;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00134284 File Offset: 0x00132484
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this._paramID = Animator.StringToHash(this.parameter.Value);
			this.SetParameter();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x001342FE File Offset: 0x001324FE
		public override void OnActionUpdate()
		{
			this.SetParameter();
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00134308 File Offset: 0x00132508
		private void SetParameter()
		{
			if (this._animator == null)
			{
				return;
			}
			if (this.dampTime.Value > 0f)
			{
				this._animator.SetFloat(this._paramID, this.Value.Value, this.dampTime.Value, Time.deltaTime);
				return;
			}
			this._animator.SetFloat(this._paramID, this.Value.Value);
		}

		// Token: 0x0400347C RID: 13436
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400347D RID: 13437
		[RequiredField]
		[UIHint(UIHint.AnimatorFloat)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x0400347E RID: 13438
		[Tooltip("The float value to assign to the animator parameter")]
		public FsmFloat Value;

		// Token: 0x0400347F RID: 13439
		[Tooltip("Optional: The time allowed to parameter to reach the value. Requires everyFrame Checked on")]
		public FsmFloat dampTime;

		// Token: 0x04003480 RID: 13440
		private Animator _animator;

		// Token: 0x04003481 RID: 13441
		private int _paramID;
	}
}
