using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F2 RID: 2290
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the pivot weight and/or position. The pivot is the most stable point between the avatar's left and right foot.\n For a weight value of 0, the left foot is the most stable point For a value of 1, the right foot is the most stable point")]
	public class GetAnimatorPivot : FsmStateActionAnimatorBase
	{
		// Token: 0x060032D9 RID: 13017 RVA: 0x00133710 File Offset: 0x00131910
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.pivotWeight = null;
			this.pivotPosition = null;
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00133730 File Offset: 0x00131930
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
			this.DoCheckPivot();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00133794 File Offset: 0x00131994
		public override void OnActionUpdate()
		{
			this.DoCheckPivot();
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0013379C File Offset: 0x0013199C
		private void DoCheckPivot()
		{
			if (this._animator == null)
			{
				return;
			}
			if (!this.pivotWeight.IsNone)
			{
				this.pivotWeight.Value = this._animator.pivotWeight;
			}
			if (!this.pivotPosition.IsNone)
			{
				this.pivotPosition.Value = this._animator.pivotPosition;
			}
		}

		// Token: 0x04003444 RID: 13380
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003445 RID: 13381
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The pivot is the most stable point between the avatar's left and right foot.\n For a value of 0, the left foot is the most stable point For a value of 1, the right foot is the most stable point")]
		public FsmFloat pivotWeight;

		// Token: 0x04003446 RID: 13382
		[UIHint(UIHint.Variable)]
		[Tooltip("The pivot is the most stable point between the avatar's left and right foot.\n For a value of 0, the left foot is the most stable point For a value of 1, the right foot is the most stable point")]
		public FsmVector3 pivotPosition;

		// Token: 0x04003447 RID: 13383
		private Animator _animator;
	}
}
