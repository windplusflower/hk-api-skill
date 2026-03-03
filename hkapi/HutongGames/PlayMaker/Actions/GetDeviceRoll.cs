using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BDA RID: 3034
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets the rotation of the device around its z axis (into the screen). For example when you steer with the iPhone in a driving game.")]
	public class GetDeviceRoll : FsmStateAction
	{
		// Token: 0x06003FE5 RID: 16357 RVA: 0x00168AF0 File Offset: 0x00166CF0
		public override void Reset()
		{
			this.baseOrientation = GetDeviceRoll.BaseOrientation.LandscapeLeft;
			this.storeAngle = null;
			this.limitAngle = new FsmFloat
			{
				UseVariable = true
			};
			this.smoothing = 5f;
			this.everyFrame = true;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00168B29 File Offset: 0x00166D29
		public override void OnEnter()
		{
			this.DoGetDeviceRoll();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00168B3F File Offset: 0x00166D3F
		public override void OnUpdate()
		{
			this.DoGetDeviceRoll();
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00168B48 File Offset: 0x00166D48
		private void DoGetDeviceRoll()
		{
			float x = Input.acceleration.x;
			float y = Input.acceleration.y;
			float num = 0f;
			switch (this.baseOrientation)
			{
			case GetDeviceRoll.BaseOrientation.Portrait:
				num = -Mathf.Atan2(x, -y);
				break;
			case GetDeviceRoll.BaseOrientation.LandscapeLeft:
				num = Mathf.Atan2(y, -x);
				break;
			case GetDeviceRoll.BaseOrientation.LandscapeRight:
				num = -Mathf.Atan2(y, x);
				break;
			}
			if (!this.limitAngle.IsNone)
			{
				num = Mathf.Clamp(57.29578f * num, -this.limitAngle.Value, this.limitAngle.Value);
			}
			if (this.smoothing.Value > 0f)
			{
				num = Mathf.LerpAngle(this.lastZAngle, num, this.smoothing.Value * Time.deltaTime);
			}
			this.lastZAngle = num;
			this.storeAngle.Value = num;
		}

		// Token: 0x04004419 RID: 17433
		[Tooltip("How the user is expected to hold the device (where angle will be zero).")]
		public GetDeviceRoll.BaseOrientation baseOrientation;

		// Token: 0x0400441A RID: 17434
		[UIHint(UIHint.Variable)]
		public FsmFloat storeAngle;

		// Token: 0x0400441B RID: 17435
		public FsmFloat limitAngle;

		// Token: 0x0400441C RID: 17436
		public FsmFloat smoothing;

		// Token: 0x0400441D RID: 17437
		public bool everyFrame;

		// Token: 0x0400441E RID: 17438
		private float lastZAngle;

		// Token: 0x02000BDB RID: 3035
		public enum BaseOrientation
		{
			// Token: 0x04004420 RID: 17440
			Portrait,
			// Token: 0x04004421 RID: 17441
			LandscapeLeft,
			// Token: 0x04004422 RID: 17442
			LandscapeRight
		}
	}
}
