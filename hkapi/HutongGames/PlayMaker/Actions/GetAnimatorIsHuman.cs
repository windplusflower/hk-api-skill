using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E8 RID: 2280
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns true if the current rig is humanoid, false if it is generic. Can also sends events")]
	public class GetAnimatorIsHuman : FsmStateAction
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x00132DC6 File Offset: 0x00130FC6
		public override void Reset()
		{
			this.gameObject = null;
			this.isHuman = null;
			this.isHumanEvent = null;
			this.isGenericEvent = null;
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00132DE4 File Offset: 0x00130FE4
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
			this.DoCheckIsHuman();
			base.Finish();
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00132E40 File Offset: 0x00131040
		private void DoCheckIsHuman()
		{
			if (this._animator == null)
			{
				return;
			}
			bool flag = this._animator.isHuman;
			if (!this.isHuman.IsNone)
			{
				this.isHuman.Value = flag;
			}
			if (flag)
			{
				base.Fsm.Event(this.isHumanEvent);
				return;
			}
			base.Fsm.Event(this.isGenericEvent);
		}

		// Token: 0x0400340F RID: 13327
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003410 RID: 13328
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if the current rig is humanoid, False if it is generic")]
		public FsmBool isHuman;

		// Token: 0x04003411 RID: 13329
		[Tooltip("Event send if rig is humanoid")]
		public FsmEvent isHumanEvent;

		// Token: 0x04003412 RID: 13330
		[Tooltip("Event send if rig is generic")]
		public FsmEvent isGenericEvent;

		// Token: 0x04003413 RID: 13331
		private Animator _animator;
	}
}
