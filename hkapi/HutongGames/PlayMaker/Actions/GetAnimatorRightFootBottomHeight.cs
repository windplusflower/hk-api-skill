using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F5 RID: 2293
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Get the right foot bottom height.")]
	public class GetAnimatorRightFootBottomHeight : FsmStateAction
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x00133956 File Offset: 0x00131B56
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.rightFootHeight = null;
			this.everyFrame = false;
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00133974 File Offset: 0x00131B74
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
			this._getRightFootBottonHeight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x001339D8 File Offset: 0x00131BD8
		public override void OnLateUpdate()
		{
			this._getRightFootBottonHeight();
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x001339E0 File Offset: 0x00131BE0
		private void _getRightFootBottonHeight()
		{
			if (this._animator != null)
			{
				this.rightFootHeight.Value = this._animator.rightFeetBottomHeight;
			}
		}

		// Token: 0x04003450 RID: 13392
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003451 RID: 13393
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The right foot bottom height.")]
		public FsmFloat rightFootHeight;

		// Token: 0x04003452 RID: 13394
		[Tooltip("Repeat every frame during LateUpdate. Useful when value is subject to change over time.")]
		public bool everyFrame;

		// Token: 0x04003453 RID: 13395
		private Animator _animator;
	}
}
