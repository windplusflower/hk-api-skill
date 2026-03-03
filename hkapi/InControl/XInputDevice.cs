using System;
using XInputDotNetPure;

namespace InControl
{
	// Token: 0x02000736 RID: 1846
	public class XInputDevice : InputDevice
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000F6021 File Offset: 0x000F4221
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x000F6029 File Offset: 0x000F4229
		public int DeviceIndex { get; private set; }

		// Token: 0x06002E5D RID: 11869 RVA: 0x000F6034 File Offset: 0x000F4234
		public XInputDevice(int deviceIndex, XInputDeviceManager owner) : base("XInput Controller")
		{
			this.owner = owner;
			this.DeviceIndex = deviceIndex;
			base.SortOrder = deviceIndex;
			base.Meta = "XInput Device #" + deviceIndex.ToString();
			base.DeviceClass = InputDeviceClass.Controller;
			base.DeviceStyle = InputDeviceStyle.XboxOne;
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
			base.AddControl(InputControlType.Action1, "A");
			base.AddControl(InputControlType.Action2, "B");
			base.AddControl(InputControlType.Action3, "X");
			base.AddControl(InputControlType.Action4, "Y");
			base.AddControl(InputControlType.LeftBumper, "Left Bumper");
			base.AddControl(InputControlType.RightBumper, "Right Bumper");
			base.AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			base.AddControl(InputControlType.RightStickButton, "Right Stick Button");
			base.AddControl(InputControlType.View, "View");
			base.AddControl(InputControlType.Menu, "Menu");
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000F625C File Offset: 0x000F445C
		public override void Update(ulong updateTick, float deltaTime)
		{
			this.GetState();
			base.UpdateLeftStickWithValue(this.state.ThumbSticks.Left.Vector, updateTick, deltaTime);
			base.UpdateRightStickWithValue(this.state.ThumbSticks.Right.Vector, updateTick, deltaTime);
			base.UpdateWithValue(InputControlType.LeftTrigger, this.state.Triggers.Left, updateTick, deltaTime);
			base.UpdateWithValue(InputControlType.RightTrigger, this.state.Triggers.Right, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.DPadUp, this.state.DPad.Up == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.DPadDown, this.state.DPad.Down == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.DPadLeft, this.state.DPad.Left == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.DPadRight, this.state.DPad.Right == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.Action1, this.state.Buttons.A == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.Action2, this.state.Buttons.B == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.Action3, this.state.Buttons.X == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.Action4, this.state.Buttons.Y == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.LeftBumper, this.state.Buttons.LeftShoulder == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.RightBumper, this.state.Buttons.RightShoulder == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.LeftStickButton, this.state.Buttons.LeftStick == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.RightStickButton, this.state.Buttons.RightStick == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.View, this.state.Buttons.Start == ButtonState.Pressed, updateTick, deltaTime);
			base.UpdateWithState(InputControlType.Menu, this.state.Buttons.Back == ButtonState.Pressed, updateTick, deltaTime);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000F64B8 File Offset: 0x000F46B8
		public override void Vibrate(float leftMotor, float rightMotor)
		{
			GamePad.SetVibration((PlayerIndex)this.DeviceIndex, leftMotor, rightMotor);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000F64C7 File Offset: 0x000F46C7
		internal void GetState()
		{
			this.state = this.owner.GetState(this.DeviceIndex);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x000F64E0 File Offset: 0x000F46E0
		public bool IsConnected
		{
			get
			{
				return this.state.IsConnected;
			}
		}

		// Token: 0x040032E4 RID: 13028
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040032E5 RID: 13029
		private const float UpperDeadZone = 0.9f;

		// Token: 0x040032E6 RID: 13030
		private readonly XInputDeviceManager owner;

		// Token: 0x040032E7 RID: 13031
		private GamePadState state;
	}
}
