using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E6 RID: 2278
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of an int parameter")]
	public class GetAnimatorInt : FsmStateActionAnimatorBase
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00132CF8 File Offset: 0x00130EF8
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.result = null;
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00132D18 File Offset: 0x00130F18
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
			this.GetParameter();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00132D92 File Offset: 0x00130F92
		public override void OnActionUpdate()
		{
			this.GetParameter();
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00132D9A File Offset: 0x00130F9A
		private void GetParameter()
		{
			if (this._animator != null)
			{
				this.result.Value = this._animator.GetInteger(this._paramID);
			}
		}

		// Token: 0x0400340A RID: 13322
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400340B RID: 13323
		[RequiredField]
		[UIHint(UIHint.AnimatorInt)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x0400340C RID: 13324
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The int value of the animator parameter")]
		public FsmInt result;

		// Token: 0x0400340D RID: 13325
		private Animator _animator;

		// Token: 0x0400340E RID: 13326
		private int _paramID;
	}
}
