using System;

namespace InControl
{
	// Token: 0x020006CF RID: 1743
	public class UnknownDeviceBindingSourceListener : BindingSourceListener
	{
		// Token: 0x060029C4 RID: 10692 RVA: 0x000E7844 File Offset: 0x000E5A44
		public void Reset()
		{
			this.detectFound = UnknownDeviceControl.None;
			this.detectPhase = UnknownDeviceBindingSourceListener.DetectPhase.WaitForInitialRelease;
			this.TakeSnapshotOnUnknownDevices();
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000E7860 File Offset: 0x000E5A60
		private void TakeSnapshotOnUnknownDevices()
		{
			int count = InputManager.Devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputDevice inputDevice = InputManager.Devices[i];
				if (inputDevice.IsUnknown)
				{
					inputDevice.TakeSnapshot();
				}
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000E78A0 File Offset: 0x000E5AA0
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			if (!listenOptions.IncludeUnknownControllers || device.IsKnown)
			{
				return null;
			}
			if (this.detectPhase == UnknownDeviceBindingSourceListener.DetectPhase.WaitForControlRelease && this.detectFound && !this.IsPressed(this.detectFound, device))
			{
				BindingSource result = new UnknownDeviceBindingSource(this.detectFound);
				this.Reset();
				return result;
			}
			UnknownDeviceControl control = this.ListenForControl(listenOptions, device);
			if (control)
			{
				if (this.detectPhase == UnknownDeviceBindingSourceListener.DetectPhase.WaitForControlPress)
				{
					this.detectFound = control;
					this.detectPhase = UnknownDeviceBindingSourceListener.DetectPhase.WaitForControlRelease;
				}
			}
			else if (this.detectPhase == UnknownDeviceBindingSourceListener.DetectPhase.WaitForInitialRelease)
			{
				this.detectPhase = UnknownDeviceBindingSourceListener.DetectPhase.WaitForControlPress;
			}
			return null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000E7930 File Offset: 0x000E5B30
		private bool IsPressed(UnknownDeviceControl control, InputDevice device)
		{
			return Utility.AbsoluteIsOverThreshold(control.GetValue(device), 0.5f);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000E7944 File Offset: 0x000E5B44
		private UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			if (device.IsUnknown)
			{
				UnknownDeviceControl firstPressedButton = device.GetFirstPressedButton();
				if (firstPressedButton)
				{
					return firstPressedButton;
				}
				UnknownDeviceControl firstPressedAnalog = device.GetFirstPressedAnalog();
				if (firstPressedAnalog)
				{
					return firstPressedAnalog;
				}
			}
			return UnknownDeviceControl.None;
		}

		// Token: 0x04002FB4 RID: 12212
		private UnknownDeviceControl detectFound;

		// Token: 0x04002FB5 RID: 12213
		private UnknownDeviceBindingSourceListener.DetectPhase detectPhase;

		// Token: 0x020006D0 RID: 1744
		private enum DetectPhase
		{
			// Token: 0x04002FB7 RID: 12215
			WaitForInitialRelease,
			// Token: 0x04002FB8 RID: 12216
			WaitForControlPress,
			// Token: 0x04002FB9 RID: 12217
			WaitForControlRelease
		}
	}
}
