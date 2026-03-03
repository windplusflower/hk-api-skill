using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B45 RID: 2885
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Interpolate through an array of Colors over a specified amount of Time.")]
	public class ColorInterpolate : FsmStateAction
	{
		// Token: 0x06003DA7 RID: 15783 RVA: 0x001621C0 File Offset: 0x001603C0
		public override void Reset()
		{
			this.colors = new FsmColor[3];
			this.time = 1f;
			this.storeColor = null;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x001621F4 File Offset: 0x001603F4
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			if (this.colors.Length < 2)
			{
				if (this.colors.Length == 1)
				{
					this.storeColor.Value = this.colors[0].Value;
				}
				base.Finish();
				return;
			}
			this.storeColor.Value = this.colors[0].Value;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00162264 File Offset: 0x00160464
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
			if (this.currentTime > this.time.Value)
			{
				base.Finish();
				this.storeColor.Value = this.colors[this.colors.Length - 1].Value;
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
				return;
			}
			float num = (float)(this.colors.Length - 1) * this.currentTime / this.time.Value;
			Color value;
			if (num.Equals(0f))
			{
				value = this.colors[0].Value;
			}
			else if (num.Equals((float)(this.colors.Length - 1)))
			{
				value = this.colors[this.colors.Length - 1].Value;
			}
			else
			{
				Color value2 = this.colors[Mathf.FloorToInt(num)].Value;
				Color value3 = this.colors[Mathf.CeilToInt(num)].Value;
				num -= Mathf.Floor(num);
				value = Color.Lerp(value2, value3, num);
			}
			this.storeColor.Value = value;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x0016239F File Offset: 0x0016059F
		public override string ErrorCheck()
		{
			if (this.colors.Length >= 2)
			{
				return null;
			}
			return "Define at least 2 colors to make a gradient.";
		}

		// Token: 0x040041C1 RID: 16833
		[RequiredField]
		[Tooltip("Array of colors to interpolate through.")]
		public FsmColor[] colors;

		// Token: 0x040041C2 RID: 16834
		[RequiredField]
		[Tooltip("Interpolation time.")]
		public FsmFloat time;

		// Token: 0x040041C3 RID: 16835
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the interpolated color in a Color variable.")]
		public FsmColor storeColor;

		// Token: 0x040041C4 RID: 16836
		[Tooltip("Event to send when the interpolation finishes.")]
		public FsmEvent finishEvent;

		// Token: 0x040041C5 RID: 16837
		[Tooltip("Ignore TimeScale")]
		public bool realTime;

		// Token: 0x040041C6 RID: 16838
		private float startTime;

		// Token: 0x040041C7 RID: 16839
		private float currentTime;
	}
}
