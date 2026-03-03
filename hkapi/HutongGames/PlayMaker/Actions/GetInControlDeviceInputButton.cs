using System;
using InControl;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC1 RID: 2753
	[ActionCategory("InControl")]
	[Tooltip("Gets the pressed state of the specified InControl Button for a given Device and stores it in a Bool Variable.")]
	public class GetInControlDeviceInputButton : FsmStateAction
	{
		// Token: 0x06003B36 RID: 15158 RVA: 0x00155FC4 File Offset: 0x001541C4
		public override void Reset()
		{
			this.deviceIndex = null;
			this.axis = InputControlType.Action1;
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00155FE4 File Offset: 0x001541E4
		public override void OnEnter()
		{
			if (this.deviceIndex.Value == -1)
			{
				this._inputDevice = InputManager.ActiveDevice;
			}
			else
			{
				this._inputDevice = InputManager.Devices[this.deviceIndex.Value];
			}
			this.DoGetButton();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x0015603B File Offset: 0x0015423B
		public override void OnUpdate()
		{
			this.DoGetButton();
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00156043 File Offset: 0x00154243
		private void DoGetButton()
		{
			this.storeResult.Value = this._inputDevice.GetControl(this.axis).IsPressed;
		}

		// Token: 0x04003E8C RID: 16012
		[Tooltip("The index of the device.")]
		public FsmInt deviceIndex;

		// Token: 0x04003E8D RID: 16013
		public InputControlType axis;

		// Token: 0x04003E8E RID: 16014
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x04003E8F RID: 16015
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04003E90 RID: 16016
		private InputDevice _inputDevice;
	}
}
