using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000965 RID: 2405
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Receive animation events and animation complete event of the current animation playing. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	public class Tk2dWatchAnimationEvents : FsmStateAction
	{
		// Token: 0x060034CD RID: 13517 RVA: 0x0013A8D8 File Offset: 0x00138AD8
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0013A90D File Offset: 0x00138B0D
		public override void Reset()
		{
			this.gameObject = null;
			this.animationTriggerEvent = null;
			this.animationCompleteEvent = null;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0013A924 File Offset: 0x00138B24
		public override void OnEnter()
		{
			this._getSprite();
			this.DoWatchAnimationWithEvents();
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0013A932 File Offset: 0x00138B32
		public override void OnUpdate()
		{
			if (!this._sprite.Playing)
			{
				base.Fsm.Event(this.animationCompleteEvent);
				base.Finish();
			}
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0013A958 File Offset: 0x00138B58
		private void DoWatchAnimationWithEvents()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component");
				return;
			}
			if (this.animationTriggerEvent != null)
			{
				this._sprite.AnimationEventTriggered = new Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip, int>(this.AnimationEventDelegate);
			}
			if (this.animationCompleteEvent != null)
			{
				this._sprite.AnimationCompleted = new Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip>(this.AnimationCompleteDelegate);
			}
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x0013A9C0 File Offset: 0x00138BC0
		private void AnimationEventDelegate(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip, int frameNum)
		{
			tk2dSpriteAnimationFrame frame = clip.GetFrame(frameNum);
			Fsm.EventData.IntData = frame.eventInt;
			Fsm.EventData.StringData = frame.eventInfo;
			Fsm.EventData.FloatData = frame.eventFloat;
			base.Fsm.Event(this.animationTriggerEvent);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0013AA18 File Offset: 0x00138C18
		private void AnimationCompleteDelegate(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip)
		{
			int intData = -1;
			tk2dSpriteAnimationClip[] array = (sprite.Library != null) ? sprite.Library.clips : null;
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == clip)
					{
						intData = i;
						break;
					}
				}
			}
			Fsm.EventData.IntData = intData;
			base.Fsm.Event(this.animationCompleteEvent);
		}

		// Token: 0x04003680 RID: 13952
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003681 RID: 13953
		[Tooltip("Trigger event defined in the clip. The event holds the following triggers infos: the eventInt, eventInfo and eventFloat properties")]
		public FsmEvent animationTriggerEvent;

		// Token: 0x04003682 RID: 13954
		[Tooltip("Animation complete event. The event holds the clipId reference")]
		public FsmEvent animationCompleteEvent;

		// Token: 0x04003683 RID: 13955
		private tk2dSpriteAnimator _sprite;
	}
}
