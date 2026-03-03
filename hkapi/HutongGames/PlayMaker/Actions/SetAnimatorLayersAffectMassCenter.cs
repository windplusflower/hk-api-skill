using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000903 RID: 2307
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("If true, additionnal layers affects the mass center")]
	public class SetAnimatorLayersAffectMassCenter : FsmStateAction
	{
		// Token: 0x0600332D RID: 13101 RVA: 0x0013477E File Offset: 0x0013297E
		public override void Reset()
		{
			this.gameObject = null;
			this.affectMassCenter = null;
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00134790 File Offset: 0x00132990
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
			this.SetAffectMassCenter();
			base.Finish();
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x001347EC File Offset: 0x001329EC
		private void SetAffectMassCenter()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.layersAffectMassCenter = this.affectMassCenter.Value;
		}

		// Token: 0x04003496 RID: 13462
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003497 RID: 13463
		[Tooltip("If true, additionnal layers affects the mass center")]
		public FsmBool affectMassCenter;

		// Token: 0x04003498 RID: 13464
		private Animator _animator;
	}
}
