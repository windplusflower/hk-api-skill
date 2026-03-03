using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6F RID: 2927
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends an Event based on the Orientation of the mobile device.")]
	public class DeviceOrientationEvent : FsmStateAction
	{
		// Token: 0x06003E4B RID: 15947 RVA: 0x00163D9B File Offset: 0x00161F9B
		public override void Reset()
		{
			this.orientation = DeviceOrientation.Portrait;
			this.sendEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00163DB2 File Offset: 0x00161FB2
		public override void OnEnter()
		{
			this.DoDetectDeviceOrientation();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00163DC8 File Offset: 0x00161FC8
		public override void OnUpdate()
		{
			this.DoDetectDeviceOrientation();
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00163DD0 File Offset: 0x00161FD0
		private void DoDetectDeviceOrientation()
		{
			if (Input.deviceOrientation == this.orientation)
			{
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0400425E RID: 16990
		[Tooltip("Note: If device is physically situated between discrete positions, as when (for example) rotated diagonally, system will report Unknown orientation.")]
		public DeviceOrientation orientation;

		// Token: 0x0400425F RID: 16991
		[Tooltip("The event to send if the device orientation matches Orientation.")]
		public FsmEvent sendEvent;

		// Token: 0x04004260 RID: 16992
		[Tooltip("Repeat every frame. Useful if you want to wait for the orientation to be true.")]
		public bool everyFrame;
	}
}
