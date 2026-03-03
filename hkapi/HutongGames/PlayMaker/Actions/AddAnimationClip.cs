using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AEF RID: 2799
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Adds a named Animation Clip to a Game Object. Optionally trims the Animation.")]
	public class AddAnimationClip : FsmStateAction
	{
		// Token: 0x06003C18 RID: 15384 RVA: 0x00159F1C File Offset: 0x0015811C
		public override void Reset()
		{
			this.gameObject = null;
			this.animationClip = null;
			this.animationName = "";
			this.firstFrame = 0;
			this.lastFrame = 0;
			this.addLoopFrame = false;
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00159F6B File Offset: 0x0015816B
		public override void OnEnter()
		{
			this.DoAddAnimationClip();
			base.Finish();
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00159F7C File Offset: 0x0015817C
		private void DoAddAnimationClip()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			AnimationClip animationClip = this.animationClip.Value as AnimationClip;
			if (animationClip == null)
			{
				return;
			}
			Animation component = ownerDefaultTarget.GetComponent<Animation>();
			if (this.firstFrame.Value == 0 && this.lastFrame.Value == 0)
			{
				component.AddClip(animationClip, this.animationName.Value);
				return;
			}
			component.AddClip(animationClip, this.animationName.Value, this.firstFrame.Value, this.lastFrame.Value, this.addLoopFrame.Value);
		}

		// Token: 0x04003FBE RID: 16318
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject to add the Animation Clip to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FBF RID: 16319
		[RequiredField]
		[ObjectType(typeof(AnimationClip))]
		[Tooltip("The animation clip to add. NOTE: Make sure the clip is compatible with the object's hierarchy.")]
		public FsmObject animationClip;

		// Token: 0x04003FC0 RID: 16320
		[RequiredField]
		[Tooltip("Name the animation. Used by other actions to reference this animation.")]
		public FsmString animationName;

		// Token: 0x04003FC1 RID: 16321
		[Tooltip("Optionally trim the animation by specifying a first and last frame.")]
		public FsmInt firstFrame;

		// Token: 0x04003FC2 RID: 16322
		[Tooltip("Optionally trim the animation by specifying a first and last frame.")]
		public FsmInt lastFrame;

		// Token: 0x04003FC3 RID: 16323
		[Tooltip("Add an extra looping frame that matches the first frame.")]
		public FsmBool addLoopFrame;
	}
}
