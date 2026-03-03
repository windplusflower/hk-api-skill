using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF2 RID: 3314
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Stops all playing Animations on a Game Object. Optionally, specify a single Animation to Stop.")]
	public class StopAnimation : BaseAnimationAction
	{
		// Token: 0x060044E1 RID: 17633 RVA: 0x00177806 File Offset: 0x00175A06
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00177816 File Offset: 0x00175A16
		public override void OnEnter()
		{
			this.DoStopAnimation();
			base.Finish();
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00177824 File Offset: 0x00175A24
		private void DoStopAnimation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			if (FsmString.IsNullOrEmpty(this.animName))
			{
				base.animation.Stop();
				return;
			}
			base.animation.Stop(this.animName.Value);
		}

		// Token: 0x04004933 RID: 18739
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004934 RID: 18740
		[Tooltip("Leave empty to stop all playing animations.")]
		[UIHint(UIHint.Animation)]
		public FsmString animName;
	}
}
