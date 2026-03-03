using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090A RID: 2314
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets a trigger parameter to active. Triggers are parameters that act mostly like booleans, but get reset to inactive when they are used in a transition.")]
	public class SetAnimatorTrigger : FsmStateAction
	{
		// Token: 0x06003350 RID: 13136 RVA: 0x00134E2C File Offset: 0x0013302C
		public override void Reset()
		{
			this.gameObject = null;
			this.trigger = null;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00134E3C File Offset: 0x0013303C
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
			this.SetTrigger();
			base.Finish();
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00134E98 File Offset: 0x00133098
		private void SetTrigger()
		{
			if (this._animator != null)
			{
				this._animator.SetTrigger(this.trigger.Value);
			}
		}

		// Token: 0x040034B8 RID: 13496
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034B9 RID: 13497
		[RequiredField]
		[UIHint(UIHint.AnimatorTrigger)]
		[Tooltip("The trigger name")]
		public FsmString trigger;

		// Token: 0x040034BA RID: 13498
		private Animator _animator;
	}
}
