using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8E RID: 2958
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Interpolates between 2 Float values over a specified Time.")]
	public class FloatInterpolate : FsmStateAction
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x00165456 File Offset: 0x00163656
		public override void Reset()
		{
			this.mode = InterpolationType.Linear;
			this.fromFloat = null;
			this.toFloat = null;
			this.time = 1f;
			this.storeResult = null;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00165492 File Offset: 0x00163692
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			if (this.storeResult == null)
			{
				base.Finish();
				return;
			}
			this.storeResult.Value = this.fromFloat.Value;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x001654D0 File Offset: 0x001636D0
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
			float num = this.currentTime / this.time.Value;
			InterpolationType interpolationType = this.mode;
			if (interpolationType != InterpolationType.Linear)
			{
				if (interpolationType == InterpolationType.EaseInOut)
				{
					this.storeResult.Value = Mathf.SmoothStep(this.fromFloat.Value, this.toFloat.Value, num);
				}
			}
			else
			{
				this.storeResult.Value = Mathf.Lerp(this.fromFloat.Value, this.toFloat.Value, num);
			}
			if (num > 1f)
			{
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
				base.Finish();
			}
		}

		// Token: 0x040042DB RID: 17115
		[Tooltip("Interpolation mode: Linear or EaseInOut.")]
		public InterpolationType mode;

		// Token: 0x040042DC RID: 17116
		[RequiredField]
		[Tooltip("Interpolate from this value.")]
		public FsmFloat fromFloat;

		// Token: 0x040042DD RID: 17117
		[RequiredField]
		[Tooltip("Interpolate to this value.")]
		public FsmFloat toFloat;

		// Token: 0x040042DE RID: 17118
		[RequiredField]
		[Tooltip("Interpolate over this amount of time in seconds.")]
		public FsmFloat time;

		// Token: 0x040042DF RID: 17119
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current value in a float variable.")]
		public FsmFloat storeResult;

		// Token: 0x040042E0 RID: 17120
		[Tooltip("Event to send when the interpolation is finished.")]
		public FsmEvent finishEvent;

		// Token: 0x040042E1 RID: 17121
		[Tooltip("Ignore TimeScale. Useful if the game is paused (Time scaled to 0).")]
		public bool realTime;

		// Token: 0x040042E2 RID: 17122
		private float startTime;

		// Token: 0x040042E3 RID: 17123
		private float currentTime;
	}
}
