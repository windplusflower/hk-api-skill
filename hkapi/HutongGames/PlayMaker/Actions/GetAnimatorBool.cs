using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D8 RID: 2264
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of a bool parameter")]
	public class GetAnimatorBool : FsmStateActionAnimatorBase
	{
		// Token: 0x06003263 RID: 12899 RVA: 0x00131DE5 File Offset: 0x0012FFE5
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.parameter = null;
			this.result = null;
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00131E04 File Offset: 0x00130004
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

		// Token: 0x06003265 RID: 12901 RVA: 0x00131E7E File Offset: 0x0013007E
		public override void OnActionUpdate()
		{
			this.GetParameter();
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00131E86 File Offset: 0x00130086
		private void GetParameter()
		{
			if (this._animator != null)
			{
				this.result.Value = this._animator.GetBool(this._paramID);
			}
		}

		// Token: 0x040033B5 RID: 13237
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033B6 RID: 13238
		[RequiredField]
		[UIHint(UIHint.AnimatorBool)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		// Token: 0x040033B7 RID: 13239
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The bool value of the animator parameter")]
		public FsmBool result;

		// Token: 0x040033B8 RID: 13240
		private Animator _animator;

		// Token: 0x040033B9 RID: 13241
		private int _paramID;
	}
}
