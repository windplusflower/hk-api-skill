using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF3 RID: 2803
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Play an animation on a subset of the hierarchy. E.g., A waving animation on the upper body.")]
	public class AddMixingTransform : BaseAnimationAction
	{
		// Token: 0x06003C2D RID: 15405 RVA: 0x0015A372 File Offset: 0x00158572
		public override void Reset()
		{
			this.gameObject = null;
			this.animationName = "";
			this.transform = "";
			this.recursive = true;
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0015A3A7 File Offset: 0x001585A7
		public override void OnEnter()
		{
			this.DoAddMixingTransform();
			base.Finish();
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0015A3B8 File Offset: 0x001585B8
		private void DoAddMixingTransform()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			AnimationState animationState = base.animation[this.animationName.Value];
			if (animationState == null)
			{
				return;
			}
			Transform mix = ownerDefaultTarget.transform.Find(this.transform.Value);
			animationState.AddMixingTransform(mix, this.recursive.Value);
		}

		// Token: 0x04003FD9 RID: 16345
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject playing the animation.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FDA RID: 16346
		[RequiredField]
		[Tooltip("The name of the animation to mix. NOTE: The animation should already be added to the Animation Component on the GameObject.")]
		public FsmString animationName;

		// Token: 0x04003FDB RID: 16347
		[RequiredField]
		[Tooltip("The mixing transform. E.g., root/upper_body/left_shoulder")]
		public FsmString transform;

		// Token: 0x04003FDC RID: 16348
		[Tooltip("If recursive is true all children of the mix transform will also be animated.")]
		public FsmBool recursive;
	}
}
