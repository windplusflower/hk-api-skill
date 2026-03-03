using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E9 RID: 2281
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns true if the specified layer is in a transition. Can also send events")]
	public class GetAnimatorIsLayerInTransition : FsmStateActionAnimatorBase
	{
		// Token: 0x060032B0 RID: 12976 RVA: 0x00132EA7 File Offset: 0x001310A7
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.isInTransition = null;
			this.isInTransitionEvent = null;
			this.isNotInTransitionEvent = null;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00132ECC File Offset: 0x001310CC
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
			this.DoCheckIsInTransition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00132F30 File Offset: 0x00131130
		public override void OnActionUpdate()
		{
			this.DoCheckIsInTransition();
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00132F38 File Offset: 0x00131138
		private void DoCheckIsInTransition()
		{
			if (this._animator == null)
			{
				return;
			}
			bool flag = this._animator.IsInTransition(this.layerIndex.Value);
			if (!this.isInTransition.IsNone)
			{
				this.isInTransition.Value = flag;
			}
			if (flag)
			{
				base.Fsm.Event(this.isInTransitionEvent);
				return;
			}
			base.Fsm.Event(this.isNotInTransitionEvent);
		}

		// Token: 0x04003414 RID: 13332
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003415 RID: 13333
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x04003416 RID: 13334
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if automatic matching is active")]
		public FsmBool isInTransition;

		// Token: 0x04003417 RID: 13335
		[Tooltip("Event send if automatic matching is active")]
		public FsmEvent isInTransitionEvent;

		// Token: 0x04003418 RID: 13336
		[Tooltip("Event send if automatic matching is not active")]
		public FsmEvent isNotInTransitionEvent;

		// Token: 0x04003419 RID: 13337
		private Animator _animator;
	}
}
