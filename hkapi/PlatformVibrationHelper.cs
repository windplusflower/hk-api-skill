using System;
using InControl;
using UnityEngine;

// Token: 0x02000384 RID: 900
public class PlatformVibrationHelper
{
	// Token: 0x0600149C RID: 5276 RVA: 0x0005A2DE File Offset: 0x000584DE
	public PlatformVibrationHelper()
	{
		this.vibrationMixer = new GamepadVibrationMixer(GamepadVibrationMixer.PlatformAdjustments.None);
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x0005A2F2 File Offset: 0x000584F2
	public void Destroy()
	{
		if (this.lastVibratingInputDevice != null)
		{
			this.lastVibratingInputDevice.StopVibration();
			this.lastVibratingInputDevice = null;
		}
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x0005A310 File Offset: 0x00058510
	public void UpdateVibration()
	{
		this.vibrationMixer.Update(Time.deltaTime);
		GamepadVibrationMixer.GamepadVibrationEmission.Values currentValues = this.vibrationMixer.CurrentValues;
		InputDevice activeDevice = InputManager.ActiveDevice;
		if (this.lastVibratingInputDevice != activeDevice)
		{
			if (this.lastVibratingInputDevice != null)
			{
				this.lastVibratingInputDevice.StopVibration();
				this.lastVibratingInputDevice = null;
			}
			this.lastVibratingInputDevice = activeDevice;
			if (this.lastVibratingInputDevice != null)
			{
				this.lastVibratingInputDevice.StopVibration();
			}
			this.lastVibrationWasEmpty = false;
		}
		if (this.lastVibratingInputDevice != null)
		{
			if (!this.lastVibrationWasEmpty || !currentValues.IsNearlyZero)
			{
				this.lastVibratingInputDevice.Vibrate(currentValues.Small, currentValues.Large);
			}
			this.lastVibrationWasEmpty = currentValues.IsNearlyZero;
		}
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x0005A3C0 File Offset: 0x000585C0
	public VibrationMixer GetMixer()
	{
		return this.vibrationMixer;
	}

	// Token: 0x04001313 RID: 4883
	private GamepadVibrationMixer vibrationMixer;

	// Token: 0x04001314 RID: 4884
	private InputDevice lastVibratingInputDevice;

	// Token: 0x04001315 RID: 4885
	private bool lastVibrationWasEmpty;
}
