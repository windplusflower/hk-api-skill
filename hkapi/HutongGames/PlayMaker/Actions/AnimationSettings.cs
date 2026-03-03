using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B0A RID: 2826
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Set the Wrap Mode, Blend Mode, Layer and Speed of an Animation.\nNOTE: Settings are applied once, on entering the state, NOT continuously. To dynamically control an animation's settings, use Set Animation Speede etc.")]
	public class AnimationSettings : BaseAnimationAction
	{
		// Token: 0x06003CB3 RID: 15539 RVA: 0x0015EB02 File Offset: 0x0015CD02
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.wrapMode = WrapMode.Loop;
			this.blendMode = AnimationBlendMode.Blend;
			this.speed = 1f;
			this.layer = 0;
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x0015EB3C File Offset: 0x0015CD3C
		public override void OnEnter()
		{
			this.DoAnimationSettings();
			base.Finish();
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x0015EB4C File Offset: 0x0015CD4C
		private void DoAnimationSettings()
		{
			if (string.IsNullOrEmpty(this.animName.Value))
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			AnimationState animationState = base.animation[this.animName.Value];
			if (animationState == null)
			{
				base.LogWarning("Missing animation: " + this.animName.Value);
				return;
			}
			animationState.wrapMode = this.wrapMode;
			animationState.blendMode = this.blendMode;
			if (!this.layer.IsNone)
			{
				animationState.layer = this.layer.Value;
			}
			if (!this.speed.IsNone)
			{
				animationState.speed = this.speed.Value;
			}
		}

		// Token: 0x040040BF RID: 16575
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("A GameObject with an Animation Component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040040C0 RID: 16576
		[RequiredField]
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation.")]
		public FsmString animName;

		// Token: 0x040040C1 RID: 16577
		[Tooltip("The behavior of the animation when it wraps.")]
		public WrapMode wrapMode;

		// Token: 0x040040C2 RID: 16578
		[Tooltip("How the animation is blended with other animations on the Game Object.")]
		public AnimationBlendMode blendMode;

		// Token: 0x040040C3 RID: 16579
		[HasFloatSlider(0f, 5f)]
		[Tooltip("The speed of the animation. 1 = normal; 2 = double speed...")]
		public FsmFloat speed;

		// Token: 0x040040C4 RID: 16580
		[Tooltip("The animation layer")]
		public FsmInt layer;
	}
}
