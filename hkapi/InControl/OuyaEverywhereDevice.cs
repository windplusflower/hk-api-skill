using System;

namespace InControl
{
	// Token: 0x02000703 RID: 1795
	public class OuyaEverywhereDevice : InputDevice
	{
		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000EF7CF File Offset: 0x000ED9CF
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x000EF7D7 File Offset: 0x000ED9D7
		public int DeviceIndex { get; private set; }

		// Token: 0x06002C53 RID: 11347 RVA: 0x000EF7E0 File Offset: 0x000ED9E0
		public OuyaEverywhereDevice(int deviceIndex) : base("OUYA Controller")
		{
			this.DeviceIndex = deviceIndex;
			base.SortOrder = deviceIndex;
			base.Meta = "OUYA Everywhere Device #" + deviceIndex.ToString();
			base.AddControl(InputControlType.LeftStickLeft, "Left Stick Left");
			base.AddControl(InputControlType.LeftStickRight, "Left Stick Right");
			base.AddControl(InputControlType.LeftStickUp, "Left Stick Up");
			base.AddControl(InputControlType.LeftStickDown, "Left Stick Down");
			base.AddControl(InputControlType.RightStickLeft, "Right Stick Left");
			base.AddControl(InputControlType.RightStickRight, "Right Stick Right");
			base.AddControl(InputControlType.RightStickUp, "Right Stick Up");
			base.AddControl(InputControlType.RightStickDown, "Right Stick Down");
			base.AddControl(InputControlType.LeftTrigger, "Left Trigger");
			base.AddControl(InputControlType.RightTrigger, "Right Trigger");
			base.AddControl(InputControlType.DPadUp, "DPad Up");
			base.AddControl(InputControlType.DPadDown, "DPad Down");
			base.AddControl(InputControlType.DPadLeft, "DPad Left");
			base.AddControl(InputControlType.DPadRight, "DPad Right");
			base.AddControl(InputControlType.Action1, "O");
			base.AddControl(InputControlType.Action2, "A");
			base.AddControl(InputControlType.Action3, "Y");
			base.AddControl(InputControlType.Action4, "U");
			base.AddControl(InputControlType.LeftBumper, "Left Bumper");
			base.AddControl(InputControlType.RightBumper, "Right Bumper");
			base.AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			base.AddControl(InputControlType.RightStickButton, "Right Stick Button");
			base.AddControl(InputControlType.Menu, "Menu");
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00003603 File Offset: 0x00001803
		public void BeforeAttach()
		{
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00003603 File Offset: 0x00001803
		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0000D742 File Offset: 0x0000B942
		public bool IsConnected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040031BD RID: 12733
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040031BE RID: 12734
		private const float UpperDeadZone = 0.9f;
	}
}
