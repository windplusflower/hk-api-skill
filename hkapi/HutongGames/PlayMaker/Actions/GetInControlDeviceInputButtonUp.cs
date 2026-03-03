using System;
using InControl;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC3 RID: 2755
	[ActionCategory("InControl")]
	[Tooltip("Sends an Event when the specified Incontrol control Axis for a given Device is released. Optionally store the control state in a bool variable.")]
	public class GetInControlDeviceInputButtonUp : FsmStateAction
	{
		// Token: 0x06003B3F RID: 15167 RVA: 0x0015610F File Offset: 0x0015430F
		public override void Reset()
		{
			this.deviceIndex = null;
			this.axis = InputControlType.Action1;
			this.sendEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x0015612E File Offset: 0x0015432E
		public override void OnEnter()
		{
			if (this.deviceIndex.Value == -1)
			{
				this._inputDevice = InputManager.ActiveDevice;
				return;
			}
			this._inputDevice = InputManager.Devices[this.deviceIndex.Value];
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00156168 File Offset: 0x00154368
		public override void OnUpdate()
		{
			bool flag = !this._inputDevice.GetControl(this.axis).IsPressed;
			if (flag)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = flag;
		}

		// Token: 0x04003E97 RID: 16023
		[Tooltip("The index of the Device.")]
		public FsmInt deviceIndex;

		// Token: 0x04003E98 RID: 16024
		public InputControlType axis;

		// Token: 0x04003E99 RID: 16025
		public FsmEvent sendEvent;

		// Token: 0x04003E9A RID: 16026
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x04003E9B RID: 16027
		private InputDevice _inputDevice;
	}
}
