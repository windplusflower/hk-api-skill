using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F0 RID: 2288
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Get the left foot bottom height.")]
	public class GetAnimatorLeftFootBottomHeight : FsmStateAction
	{
		// Token: 0x060032CF RID: 13007 RVA: 0x0013344A File Offset: 0x0013164A
		public override void Reset()
		{
			this.gameObject = null;
			this.leftFootHeight = null;
			this.everyFrame = false;
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00133464 File Offset: 0x00131664
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
			this._getLeftFootBottonHeight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x001334C8 File Offset: 0x001316C8
		public override void OnLateUpdate()
		{
			this._getLeftFootBottonHeight();
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x001334D0 File Offset: 0x001316D0
		private void _getLeftFootBottonHeight()
		{
			if (this._animator != null)
			{
				this.leftFootHeight.Value = this._animator.leftFeetBottomHeight;
			}
		}

		// Token: 0x04003435 RID: 13365
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003436 RID: 13366
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("the left foot bottom height.")]
		public FsmFloat leftFootHeight;

		// Token: 0x04003437 RID: 13367
		[Tooltip("Repeat every frame. Useful when value is subject to change over time.")]
		public bool everyFrame;

		// Token: 0x04003438 RID: 13368
		private Animator _animator;
	}
}
