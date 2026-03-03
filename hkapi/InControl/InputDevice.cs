using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006E5 RID: 1765
	public class InputDevice
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000E92A9 File Offset: 0x000E74A9
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x000E92B1 File Offset: 0x000E74B1
		public string Name { get; protected set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000E92BA File Offset: 0x000E74BA
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x000E92C2 File Offset: 0x000E74C2
		public string Meta { get; protected set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000E92CB File Offset: 0x000E74CB
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x000E92D3 File Offset: 0x000E74D3
		public int SortOrder { get; protected set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000E92DC File Offset: 0x000E74DC
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x000E92E4 File Offset: 0x000E74E4
		public InputDeviceClass DeviceClass { get; protected set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000E92ED File Offset: 0x000E74ED
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x000E92F5 File Offset: 0x000E74F5
		public InputDeviceStyle DeviceStyle { get; protected set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x000E92FE File Offset: 0x000E74FE
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x000E9306 File Offset: 0x000E7506
		public Guid GUID { get; private set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x000E930F File Offset: 0x000E750F
		// (set) Token: 0x06002A97 RID: 10903 RVA: 0x000E9317 File Offset: 0x000E7517
		public ulong LastInputTick { get; private set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x000E9320 File Offset: 0x000E7520
		// (set) Token: 0x06002A99 RID: 10905 RVA: 0x000E9328 File Offset: 0x000E7528
		public bool IsActive { get; private set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000E9331 File Offset: 0x000E7531
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x000E9339 File Offset: 0x000E7539
		public bool IsAttached { get; private set; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000E9342 File Offset: 0x000E7542
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x000E934A File Offset: 0x000E754A
		private protected bool RawSticks { protected get; private set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x000E9353 File Offset: 0x000E7553
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x000E935B File Offset: 0x000E755B
		public ReadOnlyCollection<InputControl> Controls { get; protected set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000E9364 File Offset: 0x000E7564
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x000E936C File Offset: 0x000E756C
		private protected InputControl[] ControlsByTarget { protected get; private set; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000E9375 File Offset: 0x000E7575
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x000E937D File Offset: 0x000E757D
		public TwoAxisInputControl LeftStick { get; private set; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x000E9386 File Offset: 0x000E7586
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x000E938E File Offset: 0x000E758E
		public TwoAxisInputControl RightStick { get; private set; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x000E9397 File Offset: 0x000E7597
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x000E939F File Offset: 0x000E759F
		public TwoAxisInputControl DPad { get; private set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x000E93A8 File Offset: 0x000E75A8
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x000E93B0 File Offset: 0x000E75B0
		public InputControlType LeftCommandControl { get; private set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000E93B9 File Offset: 0x000E75B9
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x000E93C1 File Offset: 0x000E75C1
		public InputControlType RightCommandControl { get; private set; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000E93CA File Offset: 0x000E75CA
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x000E93D2 File Offset: 0x000E75D2
		protected InputDevice.AnalogSnapshotEntry[] AnalogSnapshot { get; set; }

		// Token: 0x06002AAE RID: 10926 RVA: 0x000E93DB File Offset: 0x000E75DB
		public InputDevice() : this("")
		{
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000E93E8 File Offset: 0x000E75E8
		public InputDevice(string name) : this(name, false)
		{
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000E93F4 File Offset: 0x000E75F4
		public InputDevice(string name, bool rawSticks)
		{
			this.Name = name;
			this.RawSticks = rawSticks;
			this.Meta = "";
			this.GUID = Guid.NewGuid();
			this.LastInputTick = 0UL;
			this.SortOrder = int.MaxValue;
			this.DeviceClass = InputDeviceClass.Unknown;
			this.DeviceStyle = InputDeviceStyle.Unknown;
			this.Passive = false;
			this.ControlsByTarget = new InputControl[521];
			this.controls = new List<InputControl>(32);
			this.Controls = new ReadOnlyCollection<InputControl>(this.controls);
			this.RemoveAliasControls();
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000E9487 File Offset: 0x000E7687
		internal void OnAttached()
		{
			this.IsAttached = true;
			this.AddAliasControls();
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000E9496 File Offset: 0x000E7696
		internal void OnDetached()
		{
			this.IsAttached = false;
			this.StopVibration();
			this.RemoveAliasControls();
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000E94AC File Offset: 0x000E76AC
		private void AddAliasControls()
		{
			this.RemoveAliasControls();
			if (this.IsKnown)
			{
				this.LeftStick = new TwoAxisInputControl();
				this.RightStick = new TwoAxisInputControl();
				this.DPad = new TwoAxisInputControl();
				this.DPad.DeadZoneFunc = new DeadZoneFunc(DeadZone.Separate);
				this.AddControl(InputControlType.LeftStickX, "Left Stick X");
				this.AddControl(InputControlType.LeftStickY, "Left Stick Y");
				this.AddControl(InputControlType.RightStickX, "Right Stick X");
				this.AddControl(InputControlType.RightStickY, "Right Stick Y");
				this.AddControl(InputControlType.DPadX, "DPad X");
				this.AddControl(InputControlType.DPadY, "DPad Y");
				this.AddControl(InputControlType.Command, "Command");
				this.LeftCommandControl = this.DeviceStyle.LeftCommandControl();
				this.leftCommandSource = this.GetControl(this.LeftCommandControl);
				this.hasLeftCommandControl = !this.leftCommandSource.IsNullControl;
				if (this.hasLeftCommandControl)
				{
					this.AddControl(InputControlType.LeftCommand, this.leftCommandSource.Handle);
				}
				this.RightCommandControl = this.DeviceStyle.RightCommandControl();
				this.rightCommandSource = this.GetControl(this.RightCommandControl);
				this.hasRightCommandControl = !this.rightCommandSource.IsNullControl;
				if (this.hasRightCommandControl)
				{
					this.AddControl(InputControlType.RightCommand, this.rightCommandSource.Handle);
				}
				this.ExpireControlCache();
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000E962C File Offset: 0x000E782C
		private void RemoveAliasControls()
		{
			this.LeftStick = TwoAxisInputControl.Null;
			this.RightStick = TwoAxisInputControl.Null;
			this.DPad = TwoAxisInputControl.Null;
			this.RemoveControl(InputControlType.LeftStickX);
			this.RemoveControl(InputControlType.LeftStickY);
			this.RemoveControl(InputControlType.RightStickX);
			this.RemoveControl(InputControlType.RightStickY);
			this.RemoveControl(InputControlType.DPadX);
			this.RemoveControl(InputControlType.DPadY);
			this.RemoveControl(InputControlType.Command);
			this.RemoveControl(InputControlType.LeftCommand);
			this.RemoveControl(InputControlType.RightCommand);
			this.leftCommandSource = null;
			this.hasLeftCommandControl = false;
			this.rightCommandSource = null;
			this.hasRightCommandControl = false;
			this.ExpireControlCache();
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000E96DF File Offset: 0x000E78DF
		protected void ClearControls()
		{
			Array.Clear(this.ControlsByTarget, 0, this.ControlsByTarget.Length);
			this.controls.Clear();
			this.ExpireControlCache();
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000E9706 File Offset: 0x000E7906
		public bool HasControl(InputControlType controlType)
		{
			return this.ControlsByTarget[(int)controlType] != null;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000E9713 File Offset: 0x000E7913
		public InputControl GetControl(InputControlType controlType)
		{
			return this.ControlsByTarget[(int)controlType] ?? InputControl.Null;
		}

		// Token: 0x17000635 RID: 1589
		public InputControl this[InputControlType controlType]
		{
			get
			{
				return this.GetControl(controlType);
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000E972F File Offset: 0x000E792F
		public static InputControlType GetInputControlTypeByName(string inputControlName)
		{
			return (InputControlType)Enum.Parse(typeof(InputControlType), inputControlName);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000E9748 File Offset: 0x000E7948
		public InputControl GetControlByName(string controlName)
		{
			InputControlType inputControlTypeByName = InputDevice.GetInputControlTypeByName(controlName);
			return this.GetControl(inputControlTypeByName);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000E9764 File Offset: 0x000E7964
		public InputControl AddControl(InputControlType controlType, string handle)
		{
			InputControl inputControl = this.ControlsByTarget[(int)controlType];
			if (inputControl == null)
			{
				inputControl = new InputControl(handle, controlType);
				this.ControlsByTarget[(int)controlType] = inputControl;
				this.controls.Add(inputControl);
				this.ExpireControlCache();
			}
			return inputControl;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000E97A1 File Offset: 0x000E79A1
		public InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone)
		{
			InputControl inputControl = this.AddControl(controlType, handle);
			inputControl.LowerDeadZone = lowerDeadZone;
			inputControl.UpperDeadZone = upperDeadZone;
			return inputControl;
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000E97BC File Offset: 0x000E79BC
		private void RemoveControl(InputControlType controlType)
		{
			InputControl inputControl = this.ControlsByTarget[(int)controlType];
			if (inputControl != null)
			{
				this.ControlsByTarget[(int)controlType] = null;
				this.controls.Remove(inputControl);
				this.ExpireControlCache();
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000E97F4 File Offset: 0x000E79F4
		public void ClearInputState()
		{
			this.LeftStick.ClearInputState();
			this.RightStick.ClearInputState();
			this.DPad.ClearInputState();
			int count = this.Controls.Count;
			for (int i = 0; i < count; i++)
			{
				InputControl inputControl = this.Controls[i];
				if (inputControl != null)
				{
					inputControl.ClearInputState();
				}
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000E9850 File Offset: 0x000E7A50
		protected void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime)
		{
			this.GetControl(controlType).UpdateWithState(state, updateTick, deltaTime);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000E9863 File Offset: 0x000E7A63
		protected void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
		{
			this.GetControl(controlType).UpdateWithValue(value, updateTick, deltaTime);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000E9878 File Offset: 0x000E7A78
		public void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			this.LeftStickLeft.UpdateWithValue(Mathf.Max(0f, -value.x), updateTick, deltaTime);
			this.LeftStickRight.UpdateWithValue(Mathf.Max(0f, value.x), updateTick, deltaTime);
			if (InputManager.InvertYAxis)
			{
				this.LeftStickUp.UpdateWithValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
				this.LeftStickDown.UpdateWithValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
				return;
			}
			this.LeftStickUp.UpdateWithValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
			this.LeftStickDown.UpdateWithValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000E9944 File Offset: 0x000E7B44
		public void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			this.LeftStickLeft.UpdateWithRawValue(Mathf.Max(0f, -value.x), updateTick, deltaTime);
			this.LeftStickRight.UpdateWithRawValue(Mathf.Max(0f, value.x), updateTick, deltaTime);
			if (InputManager.InvertYAxis)
			{
				this.LeftStickUp.UpdateWithRawValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
				this.LeftStickDown.UpdateWithRawValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
				return;
			}
			this.LeftStickUp.UpdateWithRawValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
			this.LeftStickDown.UpdateWithRawValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000E9A10 File Offset: 0x000E7C10
		public void CommitLeftStick()
		{
			this.LeftStickUp.Commit();
			this.LeftStickDown.Commit();
			this.LeftStickLeft.Commit();
			this.LeftStickRight.Commit();
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000E9A40 File Offset: 0x000E7C40
		public void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			this.RightStickLeft.UpdateWithValue(Mathf.Max(0f, -value.x), updateTick, deltaTime);
			this.RightStickRight.UpdateWithValue(Mathf.Max(0f, value.x), updateTick, deltaTime);
			if (InputManager.InvertYAxis)
			{
				this.RightStickUp.UpdateWithValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
				this.RightStickDown.UpdateWithValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
				return;
			}
			this.RightStickUp.UpdateWithValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
			this.RightStickDown.UpdateWithValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000E9B0C File Offset: 0x000E7D0C
		public void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			this.RightStickLeft.UpdateWithRawValue(Mathf.Max(0f, -value.x), updateTick, deltaTime);
			this.RightStickRight.UpdateWithRawValue(Mathf.Max(0f, value.x), updateTick, deltaTime);
			if (InputManager.InvertYAxis)
			{
				this.RightStickUp.UpdateWithRawValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
				this.RightStickDown.UpdateWithRawValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
				return;
			}
			this.RightStickUp.UpdateWithRawValue(Mathf.Max(0f, value.y), updateTick, deltaTime);
			this.RightStickDown.UpdateWithRawValue(Mathf.Max(0f, -value.y), updateTick, deltaTime);
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000E9BD8 File Offset: 0x000E7DD8
		public void CommitRightStick()
		{
			this.RightStickUp.Commit();
			this.RightStickDown.Commit();
			this.RightStickLeft.Commit();
			this.RightStickRight.Commit();
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void Update(ulong updateTick, float deltaTime)
		{
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000E9C08 File Offset: 0x000E7E08
		private void ProcessLeftStick(ulong updateTick, float deltaTime)
		{
			float x = Utility.ValueFromSides(this.LeftStickLeft.NextRawValue, this.LeftStickRight.NextRawValue);
			float y = Utility.ValueFromSides(this.LeftStickDown.NextRawValue, this.LeftStickUp.NextRawValue, InputManager.InvertYAxis);
			Vector2 vector;
			if (this.RawSticks || this.LeftStickLeft.Raw || this.LeftStickRight.Raw || this.LeftStickUp.Raw || this.LeftStickDown.Raw)
			{
				vector = new Vector2(x, y);
			}
			else
			{
				float lowerDeadZone = Utility.Max(this.LeftStickLeft.LowerDeadZone, this.LeftStickRight.LowerDeadZone, this.LeftStickUp.LowerDeadZone, this.LeftStickDown.LowerDeadZone);
				float upperDeadZone = Utility.Min(this.LeftStickLeft.UpperDeadZone, this.LeftStickRight.UpperDeadZone, this.LeftStickUp.UpperDeadZone, this.LeftStickDown.UpperDeadZone);
				vector = this.LeftStick.DeadZoneFunc(x, y, lowerDeadZone, upperDeadZone);
			}
			this.LeftStick.Raw = true;
			this.LeftStick.UpdateWithAxes(vector.x, vector.y, updateTick, deltaTime);
			this.LeftStickX.Raw = true;
			this.LeftStickX.CommitWithValue(vector.x, updateTick, deltaTime);
			this.LeftStickY.Raw = true;
			this.LeftStickY.CommitWithValue(vector.y, updateTick, deltaTime);
			this.LeftStickLeft.SetValue(this.LeftStick.Left.Value, updateTick);
			this.LeftStickRight.SetValue(this.LeftStick.Right.Value, updateTick);
			this.LeftStickUp.SetValue(this.LeftStick.Up.Value, updateTick);
			this.LeftStickDown.SetValue(this.LeftStick.Down.Value, updateTick);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000E9DE8 File Offset: 0x000E7FE8
		private void ProcessRightStick(ulong updateTick, float deltaTime)
		{
			float x = Utility.ValueFromSides(this.RightStickLeft.NextRawValue, this.RightStickRight.NextRawValue);
			float y = Utility.ValueFromSides(this.RightStickDown.NextRawValue, this.RightStickUp.NextRawValue, InputManager.InvertYAxis);
			Vector2 vector;
			if (this.RawSticks || this.RightStickLeft.Raw || this.RightStickRight.Raw || this.RightStickUp.Raw || this.RightStickDown.Raw)
			{
				vector = new Vector2(x, y);
			}
			else
			{
				float lowerDeadZone = Utility.Max(this.RightStickLeft.LowerDeadZone, this.RightStickRight.LowerDeadZone, this.RightStickUp.LowerDeadZone, this.RightStickDown.LowerDeadZone);
				float upperDeadZone = Utility.Min(this.RightStickLeft.UpperDeadZone, this.RightStickRight.UpperDeadZone, this.RightStickUp.UpperDeadZone, this.RightStickDown.UpperDeadZone);
				vector = this.RightStick.DeadZoneFunc(x, y, lowerDeadZone, upperDeadZone);
			}
			this.RightStick.Raw = true;
			this.RightStick.UpdateWithAxes(vector.x, vector.y, updateTick, deltaTime);
			this.RightStickX.Raw = true;
			this.RightStickX.CommitWithValue(vector.x, updateTick, deltaTime);
			this.RightStickY.Raw = true;
			this.RightStickY.CommitWithValue(vector.y, updateTick, deltaTime);
			this.RightStickLeft.SetValue(this.RightStick.Left.Value, updateTick);
			this.RightStickRight.SetValue(this.RightStick.Right.Value, updateTick);
			this.RightStickUp.SetValue(this.RightStick.Up.Value, updateTick);
			this.RightStickDown.SetValue(this.RightStick.Down.Value, updateTick);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000E9FC8 File Offset: 0x000E81C8
		private void ProcessDPad(ulong updateTick, float deltaTime)
		{
			float x = Utility.ValueFromSides(this.DPadLeft.NextRawValue, this.DPadRight.NextRawValue);
			float y = Utility.ValueFromSides(this.DPadDown.NextRawValue, this.DPadUp.NextRawValue, InputManager.InvertYAxis);
			Vector2 vector;
			if (this.RawSticks || this.DPadLeft.Raw || this.DPadRight.Raw || this.DPadUp.Raw || this.DPadDown.Raw)
			{
				vector = new Vector2(x, y);
			}
			else
			{
				float lowerDeadZone = Utility.Max(this.DPadLeft.LowerDeadZone, this.DPadRight.LowerDeadZone, this.DPadUp.LowerDeadZone, this.DPadDown.LowerDeadZone);
				float upperDeadZone = Utility.Min(this.DPadLeft.UpperDeadZone, this.DPadRight.UpperDeadZone, this.DPadUp.UpperDeadZone, this.DPadDown.UpperDeadZone);
				vector = this.DPad.DeadZoneFunc(x, y, lowerDeadZone, upperDeadZone);
			}
			this.DPad.Raw = true;
			this.DPad.UpdateWithAxes(vector.x, vector.y, updateTick, deltaTime);
			this.DPadX.Raw = true;
			this.DPadX.CommitWithValue(vector.x, updateTick, deltaTime);
			this.DPadY.Raw = true;
			this.DPadY.CommitWithValue(vector.y, updateTick, deltaTime);
			this.DPadLeft.SetValue(this.DPad.Left.Value, updateTick);
			this.DPadRight.SetValue(this.DPad.Right.Value, updateTick);
			this.DPadUp.SetValue(this.DPad.Up.Value, updateTick);
			this.DPadDown.SetValue(this.DPad.Down.Value, updateTick);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000EA1A8 File Offset: 0x000E83A8
		public void Commit(ulong updateTick, float deltaTime)
		{
			if (this.IsKnown)
			{
				this.ProcessLeftStick(updateTick, deltaTime);
				this.ProcessRightStick(updateTick, deltaTime);
				this.ProcessDPad(updateTick, deltaTime);
			}
			int count = this.Controls.Count;
			for (int i = 0; i < count; i++)
			{
				InputControl inputControl = this.Controls[i];
				if (inputControl != null)
				{
					inputControl.Commit();
				}
			}
			if (this.IsKnown)
			{
				bool passive = true;
				bool state = false;
				for (int j = 100; j <= 116; j++)
				{
					InputControl inputControl2 = this.ControlsByTarget[j];
					if (inputControl2 != null && inputControl2.IsPressed)
					{
						state = true;
						if (!inputControl2.Passive)
						{
							passive = false;
						}
					}
				}
				this.Command.Passive = passive;
				this.Command.CommitWithState(state, updateTick, deltaTime);
				if (this.hasLeftCommandControl)
				{
					this.LeftCommand.Passive = this.leftCommandSource.Passive;
					this.LeftCommand.CommitWithState(this.leftCommandSource.IsPressed, updateTick, deltaTime);
				}
				if (this.hasRightCommandControl)
				{
					this.RightCommand.Passive = this.rightCommandSource.Passive;
					this.RightCommand.CommitWithState(this.rightCommandSource.IsPressed, updateTick, deltaTime);
				}
			}
			this.IsActive = false;
			for (int k = 0; k < count; k++)
			{
				InputControl inputControl3 = this.Controls[k];
				if (inputControl3 != null && inputControl3.HasInput && !inputControl3.Passive)
				{
					this.LastInputTick = updateTick;
					this.IsActive = true;
				}
			}
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000EA31C File Offset: 0x000E851C
		public bool LastInputAfter(InputDevice device)
		{
			return device == null || this.LastInputTick > device.LastInputTick;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000EA331 File Offset: 0x000E8531
		public void RequestActivation()
		{
			this.LastInputTick = InputManager.CurrentTick;
			this.IsActive = true;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void Vibrate(float leftMotor, float rightMotor)
		{
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000EA345 File Offset: 0x000E8545
		public void Vibrate(float intensity)
		{
			this.Vibrate(intensity, intensity);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000EA34F File Offset: 0x000E854F
		public void StopVibration()
		{
			this.Vibrate(0f);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void SetLightColor(float red, float green, float blue)
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000EA35C File Offset: 0x000E855C
		public void SetLightColor(Color color)
		{
			this.SetLightColor(color.r * color.a, color.g * color.a, color.b * color.a);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000EA38B File Offset: 0x000E858B
		public void StopLightFlash()
		{
			this.SetLightFlash(1f, 0f);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x0004E56C File Offset: 0x0004C76C
		public virtual bool IsSupportedOnThisPlatform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x0004E56C File Offset: 0x0004C76C
		public virtual bool IsKnown
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x000EA39D File Offset: 0x000E859D
		public bool IsUnknown
		{
			get
			{
				return !this.IsKnown;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x000EA3A8 File Offset: 0x000E85A8
		[Obsolete("Use InputDevice.CommandIsPressed instead.", false)]
		public bool MenuIsPressed
		{
			get
			{
				return this.IsKnown && this.Command.IsPressed;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x000EA3BF File Offset: 0x000E85BF
		[Obsolete("Use InputDevice.CommandWasPressed instead.", false)]
		public bool MenuWasPressed
		{
			get
			{
				return this.IsKnown && this.Command.WasPressed;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000EA3D6 File Offset: 0x000E85D6
		[Obsolete("Use InputDevice.CommandWasReleased instead.", false)]
		public bool MenuWasReleased
		{
			get
			{
				return this.IsKnown && this.Command.WasReleased;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000EA3A8 File Offset: 0x000E85A8
		public bool CommandIsPressed
		{
			get
			{
				return this.IsKnown && this.Command.IsPressed;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000EA3BF File Offset: 0x000E85BF
		public bool CommandWasPressed
		{
			get
			{
				return this.IsKnown && this.Command.WasPressed;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000EA3D6 File Offset: 0x000E85D6
		public bool CommandWasReleased
		{
			get
			{
				return this.IsKnown && this.Command.WasReleased;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000EA3F0 File Offset: 0x000E85F0
		public InputControl AnyButton
		{
			get
			{
				int count = this.Controls.Count;
				for (int i = 0; i < count; i++)
				{
					InputControl inputControl = this.Controls[i];
					if (inputControl != null && inputControl.IsButton && inputControl.IsPressed)
					{
						return inputControl;
					}
				}
				return InputControl.Null;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x000EA43C File Offset: 0x000E863C
		public bool AnyButtonIsPressed
		{
			get
			{
				int count = this.Controls.Count;
				for (int i = 0; i < count; i++)
				{
					InputControl inputControl = this.Controls[i];
					if (inputControl != null && inputControl.IsButton && inputControl.IsPressed)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x000EA484 File Offset: 0x000E8684
		public bool AnyButtonWasPressed
		{
			get
			{
				int count = this.Controls.Count;
				for (int i = 0; i < count; i++)
				{
					InputControl inputControl = this.Controls[i];
					if (inputControl != null && inputControl.IsButton && inputControl.WasPressed)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000EA4CC File Offset: 0x000E86CC
		public bool AnyButtonWasReleased
		{
			get
			{
				int count = this.Controls.Count;
				for (int i = 0; i < count; i++)
				{
					InputControl inputControl = this.Controls[i];
					if (inputControl != null && inputControl.IsButton && inputControl.WasReleased)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000EA514 File Offset: 0x000E8714
		public TwoAxisInputControl Direction
		{
			get
			{
				if (this.DPad.UpdateTick <= this.LeftStick.UpdateTick)
				{
					return this.LeftStick;
				}
				return this.DPad;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000EA53C File Offset: 0x000E873C
		public InputControl LeftStickUp
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickUp) == null)
				{
					result = (this.cachedLeftStickUp = this.GetControl(InputControlType.LeftStickUp));
				}
				return result;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000EA564 File Offset: 0x000E8764
		public InputControl LeftStickDown
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickDown) == null)
				{
					result = (this.cachedLeftStickDown = this.GetControl(InputControlType.LeftStickDown));
				}
				return result;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000EA58C File Offset: 0x000E878C
		public InputControl LeftStickLeft
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickLeft) == null)
				{
					result = (this.cachedLeftStickLeft = this.GetControl(InputControlType.LeftStickLeft));
				}
				return result;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000EA5B4 File Offset: 0x000E87B4
		public InputControl LeftStickRight
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickRight) == null)
				{
					result = (this.cachedLeftStickRight = this.GetControl(InputControlType.LeftStickRight));
				}
				return result;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000EA5DC File Offset: 0x000E87DC
		public InputControl RightStickUp
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickUp) == null)
				{
					result = (this.cachedRightStickUp = this.GetControl(InputControlType.RightStickUp));
				}
				return result;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000EA604 File Offset: 0x000E8804
		public InputControl RightStickDown
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickDown) == null)
				{
					result = (this.cachedRightStickDown = this.GetControl(InputControlType.RightStickDown));
				}
				return result;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x000EA62C File Offset: 0x000E882C
		public InputControl RightStickLeft
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickLeft) == null)
				{
					result = (this.cachedRightStickLeft = this.GetControl(InputControlType.RightStickLeft));
				}
				return result;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000EA654 File Offset: 0x000E8854
		public InputControl RightStickRight
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickRight) == null)
				{
					result = (this.cachedRightStickRight = this.GetControl(InputControlType.RightStickRight));
				}
				return result;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000EA67C File Offset: 0x000E887C
		public InputControl DPadUp
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadUp) == null)
				{
					result = (this.cachedDPadUp = this.GetControl(InputControlType.DPadUp));
				}
				return result;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000EA6A4 File Offset: 0x000E88A4
		public InputControl DPadDown
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadDown) == null)
				{
					result = (this.cachedDPadDown = this.GetControl(InputControlType.DPadDown));
				}
				return result;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000EA6CC File Offset: 0x000E88CC
		public InputControl DPadLeft
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadLeft) == null)
				{
					result = (this.cachedDPadLeft = this.GetControl(InputControlType.DPadLeft));
				}
				return result;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000EA6F4 File Offset: 0x000E88F4
		public InputControl DPadRight
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadRight) == null)
				{
					result = (this.cachedDPadRight = this.GetControl(InputControlType.DPadRight));
				}
				return result;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000EA71C File Offset: 0x000E891C
		public InputControl Action1
		{
			get
			{
				InputControl result;
				if ((result = this.cachedAction1) == null)
				{
					result = (this.cachedAction1 = this.GetControl(InputControlType.Action1));
				}
				return result;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000EA744 File Offset: 0x000E8944
		public InputControl Action2
		{
			get
			{
				InputControl result;
				if ((result = this.cachedAction2) == null)
				{
					result = (this.cachedAction2 = this.GetControl(InputControlType.Action2));
				}
				return result;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000EA76C File Offset: 0x000E896C
		public InputControl Action3
		{
			get
			{
				InputControl result;
				if ((result = this.cachedAction3) == null)
				{
					result = (this.cachedAction3 = this.GetControl(InputControlType.Action3));
				}
				return result;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x000EA794 File Offset: 0x000E8994
		public InputControl Action4
		{
			get
			{
				InputControl result;
				if ((result = this.cachedAction4) == null)
				{
					result = (this.cachedAction4 = this.GetControl(InputControlType.Action4));
				}
				return result;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000EA7BC File Offset: 0x000E89BC
		public InputControl LeftTrigger
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftTrigger) == null)
				{
					result = (this.cachedLeftTrigger = this.GetControl(InputControlType.LeftTrigger));
				}
				return result;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000EA7E4 File Offset: 0x000E89E4
		public InputControl RightTrigger
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightTrigger) == null)
				{
					result = (this.cachedRightTrigger = this.GetControl(InputControlType.RightTrigger));
				}
				return result;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000EA80C File Offset: 0x000E8A0C
		public InputControl LeftBumper
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftBumper) == null)
				{
					result = (this.cachedLeftBumper = this.GetControl(InputControlType.LeftBumper));
				}
				return result;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000EA834 File Offset: 0x000E8A34
		public InputControl RightBumper
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightBumper) == null)
				{
					result = (this.cachedRightBumper = this.GetControl(InputControlType.RightBumper));
				}
				return result;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000EA85C File Offset: 0x000E8A5C
		public InputControl LeftStickButton
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickButton) == null)
				{
					result = (this.cachedLeftStickButton = this.GetControl(InputControlType.LeftStickButton));
				}
				return result;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000EA884 File Offset: 0x000E8A84
		public InputControl RightStickButton
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickButton) == null)
				{
					result = (this.cachedRightStickButton = this.GetControl(InputControlType.RightStickButton));
				}
				return result;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000EA8AC File Offset: 0x000E8AAC
		public InputControl LeftStickX
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickX) == null)
				{
					result = (this.cachedLeftStickX = this.GetControl(InputControlType.LeftStickX));
				}
				return result;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000EA8D8 File Offset: 0x000E8AD8
		public InputControl LeftStickY
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftStickY) == null)
				{
					result = (this.cachedLeftStickY = this.GetControl(InputControlType.LeftStickY));
				}
				return result;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000EA904 File Offset: 0x000E8B04
		public InputControl RightStickX
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickX) == null)
				{
					result = (this.cachedRightStickX = this.GetControl(InputControlType.RightStickX));
				}
				return result;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x000EA930 File Offset: 0x000E8B30
		public InputControl RightStickY
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightStickY) == null)
				{
					result = (this.cachedRightStickY = this.GetControl(InputControlType.RightStickY));
				}
				return result;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000EA95C File Offset: 0x000E8B5C
		public InputControl DPadX
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadX) == null)
				{
					result = (this.cachedDPadX = this.GetControl(InputControlType.DPadX));
				}
				return result;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000EA988 File Offset: 0x000E8B88
		public InputControl DPadY
		{
			get
			{
				InputControl result;
				if ((result = this.cachedDPadY) == null)
				{
					result = (this.cachedDPadY = this.GetControl(InputControlType.DPadY));
				}
				return result;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000EA9B4 File Offset: 0x000E8BB4
		public InputControl Command
		{
			get
			{
				InputControl result;
				if ((result = this.cachedCommand) == null)
				{
					result = (this.cachedCommand = this.GetControl(InputControlType.Command));
				}
				return result;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x000EA9E0 File Offset: 0x000E8BE0
		public InputControl LeftCommand
		{
			get
			{
				InputControl result;
				if ((result = this.cachedLeftCommand) == null)
				{
					result = (this.cachedLeftCommand = this.GetControl(InputControlType.LeftCommand));
				}
				return result;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000EAA0C File Offset: 0x000E8C0C
		public InputControl RightCommand
		{
			get
			{
				InputControl result;
				if ((result = this.cachedRightCommand) == null)
				{
					result = (this.cachedRightCommand = this.GetControl(InputControlType.RightCommand));
				}
				return result;
			}
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000EAA38 File Offset: 0x000E8C38
		private void ExpireControlCache()
		{
			this.cachedLeftStickUp = null;
			this.cachedLeftStickDown = null;
			this.cachedLeftStickLeft = null;
			this.cachedLeftStickRight = null;
			this.cachedRightStickUp = null;
			this.cachedRightStickDown = null;
			this.cachedRightStickLeft = null;
			this.cachedRightStickRight = null;
			this.cachedDPadUp = null;
			this.cachedDPadDown = null;
			this.cachedDPadLeft = null;
			this.cachedDPadRight = null;
			this.cachedAction1 = null;
			this.cachedAction2 = null;
			this.cachedAction3 = null;
			this.cachedAction4 = null;
			this.cachedLeftTrigger = null;
			this.cachedRightTrigger = null;
			this.cachedLeftBumper = null;
			this.cachedRightBumper = null;
			this.cachedLeftStickButton = null;
			this.cachedRightStickButton = null;
			this.cachedLeftStickX = null;
			this.cachedLeftStickY = null;
			this.cachedRightStickX = null;
			this.cachedRightStickY = null;
			this.cachedDPadX = null;
			this.cachedDPadY = null;
			this.cachedCommand = null;
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x0000D742 File Offset: 0x0000B942
		public virtual int NumUnknownAnalogs
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x0000D742 File Offset: 0x0000B942
		public virtual int NumUnknownButtons
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0000D742 File Offset: 0x0000B942
		public virtual bool ReadRawButtonState(int index)
		{
			return false;
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0000D576 File Offset: 0x0000B776
		public virtual float ReadRawAnalogValue(int index)
		{
			return 0f;
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000EAB10 File Offset: 0x000E8D10
		public void TakeSnapshot()
		{
			if (this.AnalogSnapshot == null)
			{
				this.AnalogSnapshot = new InputDevice.AnalogSnapshotEntry[this.NumUnknownAnalogs];
			}
			for (int i = 0; i < this.NumUnknownAnalogs; i++)
			{
				float value = Utility.ApplySnapping(this.ReadRawAnalogValue(i), 0.5f);
				this.AnalogSnapshot[i].value = value;
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000EAB6C File Offset: 0x000E8D6C
		public UnknownDeviceControl GetFirstPressedAnalog()
		{
			if (this.AnalogSnapshot != null)
			{
				for (int i = 0; i < this.NumUnknownAnalogs; i++)
				{
					InputControlType control = InputControlType.Analog0 + i;
					float num = Utility.ApplySnapping(this.ReadRawAnalogValue(i), 0.5f);
					float num2 = num - this.AnalogSnapshot[i].value;
					this.AnalogSnapshot[i].TrackMinMaxValue(num);
					if (num2 > 0.1f)
					{
						num2 = this.AnalogSnapshot[i].maxValue - this.AnalogSnapshot[i].value;
					}
					if (num2 < -0.1f)
					{
						num2 = this.AnalogSnapshot[i].minValue - this.AnalogSnapshot[i].value;
					}
					if (num2 > 1.9f)
					{
						return new UnknownDeviceControl(control, InputRangeType.MinusOneToOne);
					}
					if (num2 < -0.9f)
					{
						return new UnknownDeviceControl(control, InputRangeType.ZeroToMinusOne);
					}
					if (num2 > 0.9f)
					{
						return new UnknownDeviceControl(control, InputRangeType.ZeroToOne);
					}
				}
			}
			return UnknownDeviceControl.None;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000EAC68 File Offset: 0x000E8E68
		public UnknownDeviceControl GetFirstPressedButton()
		{
			for (int i = 0; i < this.NumUnknownButtons; i++)
			{
				if (this.ReadRawButtonState(i))
				{
					return new UnknownDeviceControl(InputControlType.Button0 + i, InputRangeType.ZeroToOne);
				}
			}
			return UnknownDeviceControl.None;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000EACA2 File Offset: 0x000E8EA2
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevice()
		{
			InputDevice.Null = new InputDevice("None");
		}

		// Token: 0x040030B4 RID: 12468
		public static readonly InputDevice Null;

		// Token: 0x040030BF RID: 12479
		private readonly List<InputControl> controls;

		// Token: 0x040030C5 RID: 12485
		private bool hasLeftCommandControl;

		// Token: 0x040030C6 RID: 12486
		private InputControl leftCommandSource;

		// Token: 0x040030C8 RID: 12488
		private bool hasRightCommandControl;

		// Token: 0x040030C9 RID: 12489
		private InputControl rightCommandSource;

		// Token: 0x040030CB RID: 12491
		public bool Passive;

		// Token: 0x040030CD RID: 12493
		private InputControl cachedLeftStickUp;

		// Token: 0x040030CE RID: 12494
		private InputControl cachedLeftStickDown;

		// Token: 0x040030CF RID: 12495
		private InputControl cachedLeftStickLeft;

		// Token: 0x040030D0 RID: 12496
		private InputControl cachedLeftStickRight;

		// Token: 0x040030D1 RID: 12497
		private InputControl cachedRightStickUp;

		// Token: 0x040030D2 RID: 12498
		private InputControl cachedRightStickDown;

		// Token: 0x040030D3 RID: 12499
		private InputControl cachedRightStickLeft;

		// Token: 0x040030D4 RID: 12500
		private InputControl cachedRightStickRight;

		// Token: 0x040030D5 RID: 12501
		private InputControl cachedDPadUp;

		// Token: 0x040030D6 RID: 12502
		private InputControl cachedDPadDown;

		// Token: 0x040030D7 RID: 12503
		private InputControl cachedDPadLeft;

		// Token: 0x040030D8 RID: 12504
		private InputControl cachedDPadRight;

		// Token: 0x040030D9 RID: 12505
		private InputControl cachedAction1;

		// Token: 0x040030DA RID: 12506
		private InputControl cachedAction2;

		// Token: 0x040030DB RID: 12507
		private InputControl cachedAction3;

		// Token: 0x040030DC RID: 12508
		private InputControl cachedAction4;

		// Token: 0x040030DD RID: 12509
		private InputControl cachedLeftTrigger;

		// Token: 0x040030DE RID: 12510
		private InputControl cachedRightTrigger;

		// Token: 0x040030DF RID: 12511
		private InputControl cachedLeftBumper;

		// Token: 0x040030E0 RID: 12512
		private InputControl cachedRightBumper;

		// Token: 0x040030E1 RID: 12513
		private InputControl cachedLeftStickButton;

		// Token: 0x040030E2 RID: 12514
		private InputControl cachedRightStickButton;

		// Token: 0x040030E3 RID: 12515
		private InputControl cachedLeftStickX;

		// Token: 0x040030E4 RID: 12516
		private InputControl cachedLeftStickY;

		// Token: 0x040030E5 RID: 12517
		private InputControl cachedRightStickX;

		// Token: 0x040030E6 RID: 12518
		private InputControl cachedRightStickY;

		// Token: 0x040030E7 RID: 12519
		private InputControl cachedDPadX;

		// Token: 0x040030E8 RID: 12520
		private InputControl cachedDPadY;

		// Token: 0x040030E9 RID: 12521
		private InputControl cachedCommand;

		// Token: 0x040030EA RID: 12522
		private InputControl cachedLeftCommand;

		// Token: 0x040030EB RID: 12523
		private InputControl cachedRightCommand;

		// Token: 0x020006E6 RID: 1766
		protected struct AnalogSnapshotEntry
		{
			// Token: 0x06002B0B RID: 11019 RVA: 0x000EACB3 File Offset: 0x000E8EB3
			public void TrackMinMaxValue(float currentValue)
			{
				this.maxValue = Mathf.Max(this.maxValue, currentValue);
				this.minValue = Mathf.Min(this.minValue, currentValue);
			}

			// Token: 0x040030EC RID: 12524
			public float value;

			// Token: 0x040030ED RID: 12525
			public float maxValue;

			// Token: 0x040030EE RID: 12526
			public float minValue;
		}
	}
}
