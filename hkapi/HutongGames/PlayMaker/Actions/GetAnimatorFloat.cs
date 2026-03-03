using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E2 RID: 2274
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of a float parameter")]
	public class GetAnimatorFloat : FsmStateActionAnimatorBase
	{
		// Token: 0x06003293 RID: 12947 RVA: 0x00132903 File Offset: 0x00130B03
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.result = null;
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00132920 File Offset: 0x00130B20
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

		// Token: 0x06003295 RID: 12949 RVA: 0x0013299A File Offset: 0x00130B9A
		public override void OnActionUpdate()
		{
			this.GetParameter();
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x001329A2 File Offset: 0x00130BA2
		private void GetParameter()
		{
			if (this._animator != null)
			{
				this.result.Value = this._animator.GetFloat(this._paramID);
			}
		}

		// Token: 0x040033F5 RID: 13301
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033F6 RID: 13302
		[RequiredField]
		[UIHint(UIHint.AnimatorFloat)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x040033F7 RID: 13303
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float value of the animator parameter")]
		public FsmFloat result;

		// Token: 0x040033F8 RID: 13304
		private Animator _animator;

		// Token: 0x040033F9 RID: 13305
		private int _paramID;
	}
}
