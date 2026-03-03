using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000705 RID: 1797
	public class PS4SimpleInputDevice : InputDevice, VibrationManager.IVibrationMixerProvider
	{
		// Token: 0x06002C5A RID: 11354 RVA: 0x000EF9FC File Offset: 0x000EDBFC
		public PS4SimpleInputDevice() : base("DUALSHOCK®4")
		{
			base.Meta = "PS4 DUALSHOCK®4";
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
			base.AddControl(InputControlType.Action1, "Cross");
			base.AddControl(InputControlType.Action2, "Circle");
			base.AddControl(InputControlType.Action3, "Square");
			base.AddControl(InputControlType.Action4, "Triangle");
			base.AddControl(InputControlType.LeftBumper, "Left Bumper");
			base.AddControl(InputControlType.RightBumper, "Right Bumper");
			base.AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			base.AddControl(InputControlType.RightStickButton, "Right Stick Button");
			base.AddControl(InputControlType.TouchPadButton, "Touchpad Click");
			base.AddControl(InputControlType.Options, "Options");
			this.vibrationMixer = new GamepadVibrationMixer(GamepadVibrationMixer.PlatformAdjustments.DualShock);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000EFC02 File Offset: 0x000EDE02
		public override void Update(ulong updateTick, float deltaTime)
		{
			base.Commit(updateTick, deltaTime);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000EFC0C File Offset: 0x000EDE0C
		private static int GetNativeVibrationValue(float strength)
		{
			return Mathf.Clamp(Mathf.FloorToInt(strength * 256f), 0, 255);
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x0000D742 File Offset: 0x0000B942
		public bool IsConnected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000086D3 File Offset: 0x000068D3
		VibrationMixer VibrationManager.IVibrationMixerProvider.GetVibrationMixer()
		{
			return null;
		}

		// Token: 0x040031C1 RID: 12737
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040031C2 RID: 12738
		private const float UpperDeadZone = 0.9f;

		// Token: 0x040031C3 RID: 12739
		private GamepadVibrationMixer vibrationMixer;

		// Token: 0x040031C4 RID: 12740
		private const int VibrationMotorMax = 255;

		// Token: 0x02000706 RID: 1798
		private class ButtonMap
		{
			// Token: 0x040031C5 RID: 12741
			public InputControlType ControlType;

			// Token: 0x040031C6 RID: 12742
			public string ButtonName;

			// Token: 0x040031C7 RID: 12743
			public string UnityKeyName;
		}
	}
}
