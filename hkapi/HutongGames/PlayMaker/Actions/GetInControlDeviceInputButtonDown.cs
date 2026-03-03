using System;
using InControl;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC2 RID: 2754
	[ActionCategory("InControl")]
	[Tooltip("Sends an Event when the specified Incontrol control Axis for a given Device is pressed. Optionally store the control state in a bool variable.")]
	public class GetInControlDeviceInputButtonDown : FsmStateAction
	{
		// Token: 0x06003B3B RID: 15163 RVA: 0x00156066 File Offset: 0x00154266
		public override void Reset()
		{
			this.deviceIndex = null;
			this.axis = InputControlType.Action1;
			this.sendEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00156085 File Offset: 0x00154285
		public override void OnEnter()
		{
			if (this.deviceIndex.Value == -1)
			{
				this._inputDevice = InputManager.ActiveDevice;
				return;
			}
			this._inputDevice = InputManager.Devices[this.deviceIndex.Value];
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x001560BC File Offset: 0x001542BC
		public override void OnUpdate()
		{
			this.wasPressed = this._inputDevice.GetControl(this.axis).WasPressed;
			if (this.wasPressed)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = this.wasPressed;
		}

		// Token: 0x04003E91 RID: 16017
		[Tooltip("The index of the Device.")]
		public FsmInt deviceIndex;

		// Token: 0x04003E92 RID: 16018
		public InputControlType axis;

		// Token: 0x04003E93 RID: 16019
		public FsmEvent sendEvent;

		// Token: 0x04003E94 RID: 16020
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x04003E95 RID: 16021
		private bool wasPressed;

		// Token: 0x04003E96 RID: 16022
		private InputDevice _inputDevice;
	}
}
