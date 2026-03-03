using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C4B RID: 3147
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Plays an Animation on a Game Object. You can add named animation clips to the object in the Unity editor, or with the Add Animation Clip action.")]
	public class PlayAnimation : BaseAnimationAction
	{
		// Token: 0x060041DD RID: 16861 RVA: 0x0016E487 File Offset: 0x0016C687
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.playMode = PlayMode.StopAll;
			this.blendTime = 0.3f;
			this.finishEvent = null;
			this.loopEvent = null;
			this.stopOnExit = false;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0016E4C3 File Offset: 0x0016C6C3
		public override void OnEnter()
		{
			this.DoPlayAnimation();
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x0016E4CC File Offset: 0x0016C6CC
		private void DoPlayAnimation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				base.Finish();
				return;
			}
			if (string.IsNullOrEmpty(this.animName.Value))
			{
				base.LogWarning("Missing animName!");
				base.Finish();
				return;
			}
			this.anim = base.animation[this.animName.Value];
			if (this.anim == null)
			{
				base.LogWarning("Missing animation: " + this.animName.Value);
				base.Finish();
				return;
			}
			float value = this.blendTime.Value;
			if (value < 0.001f)
			{
				base.animation.Play(this.animName.Value, this.playMode);
			}
			else
			{
				base.animation.CrossFade(this.animName.Value, value, this.playMode);
			}
			this.prevAnimtTime = this.anim.time;
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x0016E5CC File Offset: 0x0016C7CC
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

		// Token: 0x060041E1 RID: 16865 RVA: 0x0016E695 File Offset: 0x0016C895
		public override void OnExit()
		{
			if (this.stopOnExit)
			{
				this.StopAnimation();
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x0016E6A5 File Offset: 0x0016C8A5
		private void StopAnimation()
		{
			if (base.animation != null)
			{
				base.animation.Stop(this.animName.Value);
			}
		}

		// Token: 0x0400464B RID: 17995
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("Game Object to play the animation on.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400464C RID: 17996
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation to play.")]
		public FsmString animName;

		// Token: 0x0400464D RID: 17997
		[Tooltip("How to treat previously playing animations.")]
		public PlayMode playMode;

		// Token: 0x0400464E RID: 17998
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time taken to blend to this animation.")]
		public FsmFloat blendTime;

		// Token: 0x0400464F RID: 17999
		[Tooltip("Event to send when the animation is finished playing. NOTE: Not sent with Loop or PingPong wrap modes!")]
		public FsmEvent finishEvent;

		// Token: 0x04004650 RID: 18000
		[Tooltip("Event to send when the animation loops. If you want to send this event to another FSM use Set Event Target. NOTE: This event is only sent with Loop and PingPong wrap modes.")]
		public FsmEvent loopEvent;

		// Token: 0x04004651 RID: 18001
		[Tooltip("Stop playing the animation when this state is exited.")]
		public bool stopOnExit;

		// Token: 0x04004652 RID: 18002
		private AnimationState anim;

		// Token: 0x04004653 RID: 18003
		private float prevAnimtTime;
	}
}
