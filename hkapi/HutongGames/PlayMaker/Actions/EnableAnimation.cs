using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B78 RID: 2936
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Enables/Disables an Animation on a GameObject.\nAnimation time is paused while disabled. Animation must also have a non zero weight to play.")]
	public class EnableAnimation : BaseAnimationAction
	{
		// Token: 0x06003E68 RID: 15976 RVA: 0x00164235 File Offset: 0x00162435
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.enable = true;
			this.resetOnExit = false;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0016425D File Offset: 0x0016245D
		public override void OnEnter()
		{
			this.DoEnableAnimation(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0016427C File Offset: 0x0016247C
		private void DoEnableAnimation(GameObject go)
		{
			if (base.UpdateCache(go))
			{
				this.anim = base.animation[this.animName.Value];
				if (this.anim != null)
				{
					this.anim.enabled = this.enable.Value;
				}
			}
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x001642D2 File Offset: 0x001624D2
		public override void OnExit()
		{
			if (this.resetOnExit.Value && this.anim != null)
			{
				this.anim.enabled = !this.enable.Value;
			}
		}

		// Token: 0x0400427A RID: 17018
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject playing the animation.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400427B RID: 17019
		[RequiredField]
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation to enable/disable.")]
		public FsmString animName;

		// Token: 0x0400427C RID: 17020
		[RequiredField]
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enable;

		// Token: 0x0400427D RID: 17021
		[Tooltip("Reset the initial enabled state when exiting the state.")]
		public FsmBool resetOnExit;

		// Token: 0x0400427E RID: 17022
		private AnimationState anim;
	}
}
