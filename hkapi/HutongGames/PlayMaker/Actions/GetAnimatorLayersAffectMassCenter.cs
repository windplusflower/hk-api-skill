using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008EF RID: 2287
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns if additionnal layers affects the mass center")]
	public class GetAnimatorLayersAffectMassCenter : FsmStateAction
	{
		// Token: 0x060032CB RID: 13003 RVA: 0x00133375 File Offset: 0x00131575
		public override void Reset()
		{
			this.gameObject = null;
			this.affectMassCenter = null;
			this.affectMassCenterEvent = null;
			this.doNotAffectMassCenterEvent = null;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00133394 File Offset: 0x00131594
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
			this.CheckAffectMassCenter();
			base.Finish();
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x001333F0 File Offset: 0x001315F0
		private void CheckAffectMassCenter()
		{
			if (this._animator == null)
			{
				return;
			}
			bool layersAffectMassCenter = this._animator.layersAffectMassCenter;
			this.affectMassCenter.Value = layersAffectMassCenter;
			if (layersAffectMassCenter)
			{
				base.Fsm.Event(this.affectMassCenterEvent);
				return;
			}
			base.Fsm.Event(this.doNotAffectMassCenterEvent);
		}

		// Token: 0x04003430 RID: 13360
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003431 RID: 13361
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("If true, additionnal layers affects the mass center")]
		public FsmBool affectMassCenter;

		// Token: 0x04003432 RID: 13362
		[Tooltip("Event send if additionnal layers affects the mass center")]
		public FsmEvent affectMassCenterEvent;

		// Token: 0x04003433 RID: 13363
		[Tooltip("Event send if additionnal layers do no affects the mass center")]
		public FsmEvent doNotAffectMassCenterEvent;

		// Token: 0x04003434 RID: 13364
		private Animator _animator;
	}
}
