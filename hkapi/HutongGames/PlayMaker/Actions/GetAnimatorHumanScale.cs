using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E4 RID: 2276
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the scale of the current Avatar for a humanoid rig, (1 by default if the rig is generic).\n The scale is relative to Unity's Default Avatar")]
	public class GetAnimatorHumanScale : FsmStateAction
	{
		// Token: 0x0600329D RID: 12957 RVA: 0x00132A7F File Offset: 0x00130C7F
		public override void Reset()
		{
			this.gameObject = null;
			this.humanScale = null;
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x00132A90 File Offset: 0x00130C90
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
			this.DoGetHumanScale();
			base.Finish();
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00132AEC File Offset: 0x00130CEC
		private void DoGetHumanScale()
		{
			if (this._animator == null)
			{
				return;
			}
			this.humanScale.Value = this._animator.humanScale;
		}

		// Token: 0x040033FD RID: 13309
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033FE RID: 13310
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("the scale of the current Avatar")]
		public FsmFloat humanScale;

		// Token: 0x040033FF RID: 13311
		private Animator _animator;
	}
}
