using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099E RID: 2462
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Fade from a fullscreen Color. NOTE: Uses OnGUI so requires a PlayMakerGUI component in the scene.")]
	public class CameraFadeInWithDelay : FsmStateAction
	{
		// Token: 0x060035F1 RID: 13809 RVA: 0x0013E00C File Offset: 0x0013C20C
		public override void Reset()
		{
			this.color = Color.black;
			this.time = 1f;
			this.delay = 1f;
			this.finishEvent = null;
			this.delayPassed = false;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0013E04C File Offset: 0x0013C24C
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			this.colorLerp = this.color.Value;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0013E078 File Offset: 0x0013C278
		public override void OnUpdate()
		{
			if (this.realTime)
			{
				this.currentTime = FsmTime.RealtimeSinceStartup - this.startTime;
			}
			else
			{
				this.currentTime += Time.deltaTime;
			}
			if (!this.delayPassed && this.currentTime > this.delay.Value)
			{
				this.currentTime = 0f;
				this.delayPassed = true;
			}
			if (this.delayPassed)
			{
				this.colorLerp = Color.Lerp(this.color.Value, Color.clear, this.currentTime / this.time.Value);
				if (this.currentTime > this.time.Value)
				{
					if (this.finishEvent != null)
					{
						base.Fsm.Event(this.finishEvent);
					}
					this.delayPassed = false;
					base.Finish();
				}
			}
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0013E14E File Offset: 0x0013C34E
		public override void OnGUI()
		{
			Color color = GUI.color;
			GUI.color = this.colorLerp;
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), ActionHelpers.WhiteTexture);
			GUI.color = color;
		}

		// Token: 0x04003791 RID: 14225
		[RequiredField]
		[Tooltip("Color to fade from. E.g., Fade up from black.")]
		public FsmColor color;

		// Token: 0x04003792 RID: 14226
		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Delay time in seconds before starting the fade in.")]
		public FsmFloat delay;

		// Token: 0x04003793 RID: 14227
		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Fade in time in seconds.")]
		public FsmFloat time;

		// Token: 0x04003794 RID: 14228
		[Tooltip("Event to send when finished.")]
		public FsmEvent finishEvent;

		// Token: 0x04003795 RID: 14229
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x04003796 RID: 14230
		private float startTime;

		// Token: 0x04003797 RID: 14231
		private float currentTime;

		// Token: 0x04003798 RID: 14232
		private Color colorLerp;

		// Token: 0x04003799 RID: 14233
		private bool delayPassed;
	}
}
