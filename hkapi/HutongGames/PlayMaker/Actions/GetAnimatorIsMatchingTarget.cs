using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008EA RID: 2282
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns true if automatic matching is active. Can also send events")]
	public class GetAnimatorIsMatchingTarget : FsmStateActionAnimatorBase
	{
		// Token: 0x060032B5 RID: 12981 RVA: 0x00132FAA File Offset: 0x001311AA
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.isMatchingActive = null;
			this.matchingActivatedEvent = null;
			this.matchingDeactivedEvent = null;
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00132FD0 File Offset: 0x001311D0
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
			this.DoCheckIsMatchingActive();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00133034 File Offset: 0x00131234
		public override void OnActionUpdate()
		{
			this.DoCheckIsMatchingActive();
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0013303C File Offset: 0x0013123C
		private void DoCheckIsMatchingActive()
		{
			if (this._animator == null)
			{
				return;
			}
			bool isMatchingTarget = this._animator.isMatchingTarget;
			this.isMatchingActive.Value = isMatchingTarget;
			if (isMatchingTarget)
			{
				base.Fsm.Event(this.matchingActivatedEvent);
				return;
			}
			base.Fsm.Event(this.matchingDeactivedEvent);
		}

		// Token: 0x0400341A RID: 13338
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400341B RID: 13339
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if automatic matching is active")]
		public FsmBool isMatchingActive;

		// Token: 0x0400341C RID: 13340
		[Tooltip("Event send if automatic matching is active")]
		public FsmEvent matchingActivatedEvent;

		// Token: 0x0400341D RID: 13341
		[Tooltip("Event send if automatic matching is not active")]
		public FsmEvent matchingDeactivedEvent;

		// Token: 0x0400341E RID: 13342
		private Animator _animator;
	}
}
