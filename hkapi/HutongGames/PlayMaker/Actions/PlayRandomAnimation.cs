using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C4C RID: 3148
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Plays a Random Animation on a Game Object. You can set the relative weight of each animation to control how often they are selected.")]
	public class PlayRandomAnimation : BaseAnimationAction
	{
		// Token: 0x060041E4 RID: 16868 RVA: 0x0016E6CC File Offset: 0x0016C8CC
		public override void Reset()
		{
			this.gameObject = null;
			this.animations = new FsmString[0];
			this.weights = new FsmFloat[0];
			this.playMode = PlayMode.StopAll;
			this.blendTime = 0.3f;
			this.finishEvent = null;
			this.loopEvent = null;
			this.stopOnExit = false;
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x0016E724 File Offset: 0x0016C924
		public override void OnEnter()
		{
			this.DoPlayRandomAnimation();
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x0016E72C File Offset: 0x0016C92C
		private void DoPlayRandomAnimation()
		{
			if (this.animations.Length != 0)
			{
				int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
				if (randomWeightedIndex != -1)
				{
					this.DoPlayAnimation(this.animations[randomWeightedIndex].Value);
				}
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x0016E768 File Offset: 0x0016C968
		private void DoPlayAnimation(string animName)
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				base.Finish();
				return;
			}
			if (string.IsNullOrEmpty(animName))
			{
				base.LogWarning("Missing animName!");
				base.Finish();
				return;
			}
			this.anim = base.animation[animName];
			if (this.anim == null)
			{
				base.LogWarning("Missing animation: " + animName);
				base.Finish();
				return;
			}
			float value = this.blendTime.Value;
			if (value < 0.001f)
			{
				base.animation.Play(animName, this.playMode);
			}
			else
			{
				base.animation.CrossFade(animName, value, this.playMode);
			}
			this.prevAnimtTime = this.anim.time;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0016E838 File Offset: 0x0016CA38
		public override void OnUpdate()
		{
			if (base.Fsm.GetOwnerDefaultTarget(this.gameObject) == null || this.anim == null)
			{
				return;
			}
			if (!this.anim.enabled || (this.anim.wrapMode == WrapMode.ClampForever && this.anim.time > this.anim.length))
			{
				base.Fsm.Event(this.finishEvent);
				base.Finish();
			}
			if (this.anim.wrapMode != WrapMode.ClampForever && this.anim.time > this.anim.length && this.prevAnimtTime < this.anim.length)
			{
				base.Fsm.Event(this.loopEvent);
			}
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0016E901 File Offset: 0x0016CB01
		public override void OnExit()
		{
			if (this.stopOnExit)
			{
				this.StopAnimation();
			}
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x0016E911 File Offset: 0x0016CB11
		private void StopAnimation()
		{
			if (base.animation != null)
			{
				base.animation.Stop(this.anim.name);
			}
		}

		// Token: 0x04004654 RID: 18004
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("Game Object to play the animation on.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004655 RID: 18005
		[CompoundArray("Animations", "Animation", "Weight")]
		[UIHint(UIHint.Animation)]
		public FsmString[] animations;

		// Token: 0x04004656 RID: 18006
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04004657 RID: 18007
		[Tooltip("How to treat previously playing animations.")]
		public PlayMode playMode;

		// Token: 0x04004658 RID: 18008
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time taken to blend to this animation.")]
		public FsmFloat blendTime;

		// Token: 0x04004659 RID: 18009
		[Tooltip("Event to send when the animation is finished playing. NOTE: Not sent with Loop or PingPong wrap modes!")]
		public FsmEvent finishEvent;

		// Token: 0x0400465A RID: 18010
		[Tooltip("Event to send when the animation loops. If you want to send this event to another FSM use Set Event Target. NOTE: This event is only sent with Loop and PingPong wrap modes.")]
		public FsmEvent loopEvent;

		// Token: 0x0400465B RID: 18011
		[Tooltip("Stop playing the animation when this state is exited.")]
		public bool stopOnExit;

		// Token: 0x0400465C RID: 18012
		private AnimationState anim;

		// Token: 0x0400465D RID: 18013
		private float prevAnimtTime;
	}
}
