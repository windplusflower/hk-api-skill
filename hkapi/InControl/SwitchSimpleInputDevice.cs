using System;

namespace InControl
{
	// Token: 0x02000708 RID: 1800
	public class SwitchSimpleInputDevice : InputDevice, VibrationManager.IVibrationMixerProvider
	{
		// Token: 0x06002C65 RID: 11365 RVA: 0x000EFCF0 File Offset: 0x000EDEF0
		public SwitchSimpleInputDevice() : base("Switch")
		{
			base.Meta = "JoyCon/Pro Controller";
			base.AddControl(InputControlType.LeftStickLeft, "Left Stick Left", 0.2f, 0.9f);
			base.AddControl(InputControlType.LeftStickRight, "Left Stick Right", 0.2f, 0.9f);
			base.AddControl(InputControlType.LeftStickUp, "Left Stick Up", 0.2f, 0.9f);
			base.AddControl(InputControlType.LeftStickDown, "Left Stick Down", 0.2f, 0.9f);
			base.AddControl(InputControlType.RightStickLeft, "Right Stick Left", 0.2f, 0.9f);
			base.AddControl(InputControlType.RightStickRight, "Right Stick Right", 0.2f, 0.9f);
			base.AddControl(InputControlType.RightStickUp, "Right Stick Up", 0.2f, 0.9f);
			base.AddControl(InputControlType.RightStickDown, "Right Stick Down", 0.2f, 0.9f);
			base.AddControl(InputControlType.LeftTrigger, "Left Trigger", 0.2f, 0.9f);
			base.AddControl(InputControlType.RightTrigger, "Right Trigger", 0.2f, 0.9f);
			base.AddControl(InputControlType.DPadUp, "DPad Up", 0.2f, 0.9f);
			base.AddControl(InputControlType.DPadDown, "DPad Down", 0.2f, 0.9f);
			base.AddControl(InputControlType.DPadLeft, "DPad Left", 0.2f, 0.9f);
			base.AddControl(InputControlType.DPadRight, "DPad Right", 0.2f, 0.9f);
			base.AddControl(InputControlType.Action1, "B");
			base.AddControl(InputControlType.Action2, "A");
			base.AddControl(InputControlType.Action3, "Y");
			base.AddControl(InputControlType.Action4, "X");
			base.AddControl(InputControlType.LeftBumper, "Left Bumper");
			base.AddControl(InputControlType.RightBumper, "Right Bumper");
			base.AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			base.AddControl(InputControlType.RightStickButton, "Right Stick Button");
			base.AddControl(InputControlType.Select, "Minus");
			base.AddControl(InputControlType.Start, "Plus");
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000EFC02 File Offset: 0x000EDE02
		public override void Update(ulong updateTick, float deltaTime)
		{
			base.Commit(updateTick, deltaTime);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0000D742 File Offset: 0x0000B942
		public bool IsConnected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000086D3 File Offset: 0x000068D3
		VibrationMixer VibrationManager.IVibrationMixerProvider.GetVibrationMixer()
		{
			return null;
		}

		// Token: 0x040031CA RID: 12746
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040031CB RID: 12747
		private const float UpperDeadZone = 0.9f;

		// Token: 0x040031CC RID: 12748
		private const float AnalogStickNormalize = 3.051851E-05f;
	}
}
