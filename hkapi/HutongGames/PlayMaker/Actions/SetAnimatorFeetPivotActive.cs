using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FE RID: 2302
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Activates feet pivot. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
	public class SetAnimatorFeetPivotActive : FsmStateAction
	{
		// Token: 0x06003314 RID: 13076 RVA: 0x001341BD File Offset: 0x001323BD
		public override void Reset()
		{
			this.gameObject = null;
			this.feetPivotActive = null;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x001341D0 File Offset: 0x001323D0
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
			this.DoFeetPivotActive();
			base.Finish();
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0013422C File Offset: 0x0013242C
		private void DoFeetPivotActive()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.feetPivotActive = this.feetPivotActive.Value;
		}

		// Token: 0x04003479 RID: 13433
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400347A RID: 13434
		[Tooltip("Activates feet pivot. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
		public FsmFloat feetPivotActive;

		// Token: 0x0400347B RID: 13435
		private Animator _animator;
	}
}
