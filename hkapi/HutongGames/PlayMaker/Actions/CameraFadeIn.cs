using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B41 RID: 2881
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Fade from a fullscreen Color. NOTE: Uses OnGUI so requires a PlayMakerGUI component in the scene.")]
	public class CameraFadeIn : FsmStateAction
	{
		// Token: 0x06003D8A RID: 15754 RVA: 0x001619E8 File Offset: 0x0015FBE8
		public override void Reset()
		{
			this.color = Color.black;
			this.time = 1f;
			this.finishEvent = null;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00161A11 File Offset: 0x0015FC11
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			this.colorLerp = this.color.Value;
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00161A3C File Offset: 0x0015FC3C
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
			this.colorLerp = Color.Lerp(this.color.Value, Color.clear, this.currentTime / this.time.Value);
			if (this.currentTime > this.time.Value)
			{
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
				base.Finish();
			}
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00161AD6 File Offset: 0x0015FCD6
		public override void OnGUI()
		{
			Color color = GUI.color;
			GUI.color = this.colorLerp;
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), ActionHelpers.WhiteTexture);
			GUI.color = color;
		}

		// Token: 0x040041A9 RID: 16809
		[RequiredField]
		[Tooltip("Color to fade from. E.g., Fade up from black.")]
		public FsmColor color;

		// Token: 0x040041AA RID: 16810
		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Fade in time in seconds.")]
		public FsmFloat time;

		// Token: 0x040041AB RID: 16811
		[Tooltip("Event to send when finished.")]
		public FsmEvent finishEvent;

		// Token: 0x040041AC RID: 16812
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x040041AD RID: 16813
		private float startTime;

		// Token: 0x040041AE RID: 16814
		private float currentTime;

		// Token: 0x040041AF RID: 16815
		private Color colorLerp;
	}
}
