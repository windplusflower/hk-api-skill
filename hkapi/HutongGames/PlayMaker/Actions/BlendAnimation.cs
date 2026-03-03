using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B33 RID: 2867
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Blends an Animation towards a Target Weight over a specified Time.\nOptionally sends an Event when finished.")]
	public class BlendAnimation : BaseAnimationAction
	{
		// Token: 0x06003D4A RID: 15690 RVA: 0x0016085F File Offset: 0x0015EA5F
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.targetWeight = 1f;
			this.time = 0.3f;
			this.finishEvent = null;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00160896 File Offset: 0x0015EA96
		public override void OnEnter()
		{
			this.DoBlendAnimation((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x001608C3 File Offset: 0x0015EAC3
		public override void OnUpdate()
		{
			if (DelayedEvent.WasSent(this.delayedFinishEvent))
			{
				base.Finish();
			}
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x001608D8 File Offset: 0x0015EAD8
		private void DoBlendAnimation(GameObject go)
		{
			if (go == null)
			{
				return;
			}
			Animation component = go.GetComponent<Animation>();
			if (component == null)
			{
				base.LogWarning("Missing Animation component on GameObject: " + go.name);
				base.Finish();
				return;
			}
			AnimationState animationState = component[this.animName.Value];
			if (animationState == null)
			{
				base.LogWarning("Missing animation: " + this.animName.Value);
				base.Finish();
				return;
			}
			float value = this.time.Value;
			component.Blend(this.animName.Value, this.targetWeight.Value, value);
			if (this.finishEvent != null)
			{
				this.delayedFinishEvent = base.Fsm.DelayedEvent(this.finishEvent, animationState.length);
				return;
			}
			base.Finish();
		}

		// Token: 0x04004158 RID: 16728
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject to animate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004159 RID: 16729
		[RequiredField]
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation to blend.")]
		public FsmString animName;

		// Token: 0x0400415A RID: 16730
		[RequiredField]
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Target weight to blend to.")]
		public FsmFloat targetWeight;

		// Token: 0x0400415B RID: 16731
		[RequiredField]
		[HasFloatSlider(0f, 5f)]
		[Tooltip("How long should the blend take.")]
		public FsmFloat time;

		// Token: 0x0400415C RID: 16732
		[Tooltip("Event to send when the blend has finished.")]
		public FsmEvent finishEvent;

		// Token: 0x0400415D RID: 16733
		private DelayedEvent delayedFinishEvent;
	}
}
