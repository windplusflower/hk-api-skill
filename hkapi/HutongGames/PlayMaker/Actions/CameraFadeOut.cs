using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B42 RID: 2882
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Fade to a fullscreen Color. NOTE: Uses OnGUI so requires a PlayMakerGUI component in the scene.")]
	public class CameraFadeOut : FsmStateAction
	{
		// Token: 0x06003D8F RID: 15759 RVA: 0x00161B12 File Offset: 0x0015FD12
		public override void Reset()
		{
			this.color = Color.black;
			this.time = 1f;
			this.finishEvent = null;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00161B3B File Offset: 0x0015FD3B
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			this.colorLerp = Color.clear;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00161B60 File Offset: 0x0015FD60
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
			this.colorLerp = Color.Lerp(Color.clear, this.color.Value, this.currentTime / this.time.Value);
			if (this.currentTime > this.time.Value && this.finishEvent != null)
			{
				base.Fsm.Event(this.finishEvent);
			}
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00161BF4 File Offset: 0x0015FDF4
		public override void OnGUI()
		{
			Color color = GUI.color;
			GUI.color = this.colorLerp;
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), ActionHelpers.WhiteTexture);
			GUI.color = color;
		}

		// Token: 0x040041B0 RID: 16816
		[RequiredField]
		[Tooltip("Color to fade to. E.g., Fade to black.")]
		public FsmColor color;

		// Token: 0x040041B1 RID: 16817
		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Fade out time in seconds.")]
		public FsmFloat time;

		// Token: 0x040041B2 RID: 16818
		[Tooltip("Event to send when finished.")]
		public FsmEvent finishEvent;

		// Token: 0x040041B3 RID: 16819
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x040041B4 RID: 16820
		private float startTime;

		// Token: 0x040041B5 RID: 16821
		private float currentTime;

		// Token: 0x040041B6 RID: 16822
		private Color colorLerp;
	}
}
