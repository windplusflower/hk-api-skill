using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FC RID: 2300
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the value of a bool parameter")]
	public class SetAnimatorBool : FsmStateActionAnimatorBase
	{
		// Token: 0x0600330B RID: 13067 RVA: 0x00134055 File Offset: 0x00132255
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.Value = null;
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00134074 File Offset: 0x00132274
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

		// Token: 0x0600330D RID: 13069 RVA: 0x001340EE File Offset: 0x001322EE
		public override void OnActionUpdate()
		{
			this.SetParameter();
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x001340F6 File Offset: 0x001322F6
		private void SetParameter()
		{
			if (this._animator != null)
			{
				this._animator.SetBool(this._paramID, this.Value.Value);
			}
		}

		// Token: 0x04003471 RID: 13425
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003472 RID: 13426
		[RequiredField]
		[UIHint(UIHint.AnimatorBool)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x04003473 RID: 13427
		[Tooltip("The Bool value to assign to the animator parameter")]
		public FsmBool Value;

		// Token: 0x04003474 RID: 13428
		private Animator _animator;

		// Token: 0x04003475 RID: 13429
		private int _paramID;
	}
}
