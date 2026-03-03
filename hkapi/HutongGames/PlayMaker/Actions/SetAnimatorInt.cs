using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000901 RID: 2305
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the value of a int parameter")]
	public class SetAnimatorInt : FsmStateActionAnimatorBase
	{
		// Token: 0x06003323 RID: 13091 RVA: 0x001345F4 File Offset: 0x001327F4
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.Value = null;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00134614 File Offset: 0x00132814
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

		// Token: 0x06003325 RID: 13093 RVA: 0x0013468E File Offset: 0x0013288E
		public override void OnActionUpdate()
		{
			this.SetParameter();
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00134696 File Offset: 0x00132896
		private void SetParameter()
		{
			if (this._animator != null)
			{
				this._animator.SetInteger(this._paramID, this.Value.Value);
			}
		}

		// Token: 0x0400348C RID: 13452
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400348D RID: 13453
		[RequiredField]
		[UIHint(UIHint.AnimatorInt)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x0400348E RID: 13454
		[Tooltip("The Int value to assign to the animator parameter")]
		public FsmInt Value;

		// Token: 0x0400348F RID: 13455
		private Animator _animator;

		// Token: 0x04003490 RID: 13456
		private int _paramID;
	}
}
