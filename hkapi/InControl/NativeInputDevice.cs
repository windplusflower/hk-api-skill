using System;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006FC RID: 1788
	public class NativeInputDevice : InputDevice
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x000EE111 File Offset: 0x000EC311
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x000EE119 File Offset: 0x000EC319
		public uint Handle { get; private set; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000EE122 File Offset: 0x000EC322
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x000EE12A File Offset: 0x000EC32A
		public InputDeviceInfo Info { get; private set; }

		// Token: 0x06002C28 RID: 11304 RVA: 0x000EE133 File Offset: 0x000EC333
		internal NativeInputDevice()
		{
			this.glyphName = new StringBuilder(256);
			base..ctor();
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000EE14C File Offset: 0x000EC34C
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo, InputDeviceProfile deviceProfile)
		{
			this.Handle = deviceHandle;
			this.Info = deviceInfo;
			this.profile = deviceProfile;
			base.SortOrder = (int)(1000U + this.Handle);
			this.numUnknownButtons = Math.Min((int)this.Info.numButtons, 20);
			this.numUnknownAnalogs = Math.Min((int)this.Info.numAnalogs, 20);
			this.buttons = new short[this.Info.numButtons];
			this.analogs = new short[this.Info.numAnalogs];
			base.AnalogSnapshot = null;
			this.controlSourceByTarget = new InputControlSource[521];
			base.ClearInputState();
			base.ClearControls();
			if (this.IsKnown)
			{
				base.Name = (this.profile.DeviceName ?? this.Info.name);
				base.Name = base.Name.Replace("{NAME}", this.Info.name).Trim();
				base.Meta = (this.profile.DeviceNotes ?? this.Info.name);
				base.DeviceClass = this.profile.DeviceClass;
				base.DeviceStyle = this.profile.DeviceStyle;
				int analogCount = this.profile.AnalogCount;
				for (int i = 0; i < analogCount; i++)
				{
					InputControlMapping inputControlMapping = this.profile.AnalogMappings[i];
					InputControl inputControl = base.AddControl(inputControlMapping.Target, inputControlMapping.Name);
					inputControl.Sensitivity = Mathf.Min(this.profile.Sensitivity, inputControlMapping.Sensitivity);
					inputControl.LowerDeadZone = Mathf.Max(this.profile.LowerDeadZone, inputControlMapping.LowerDeadZone);
					inputControl.UpperDeadZone = Mathf.Min(this.profile.UpperDeadZone, inputControlMapping.UpperDeadZone);
					inputControl.Raw = inputControlMapping.Raw;
					inputControl.Passive = inputControlMapping.Passive;
					this.controlSourceByTarget[(int)inputControlMapping.Target] = inputControlMapping.Source;
				}
				int buttonCount = this.profile.ButtonCount;
				for (int j = 0; j < buttonCount; j++)
				{
					InputControlMapping inputControlMapping2 = this.profile.ButtonMappings[j];
					base.AddControl(inputControlMapping2.Target, inputControlMapping2.Name).Passive = inputControlMapping2.Passive;
					this.controlSourceByTarget[(int)inputControlMapping2.Target] = inputControlMapping2.Source;
				}
			}
			else
			{
				base.Name = "Unknown Device";
				base.Meta = this.Info.name;
				for (int k = 0; k < this.NumUnknownButtons; k++)
				{
					base.AddControl(InputControlType.Button0 + k, "Button " + k.ToString());
				}
				for (int l = 0; l < this.NumUnknownAnalogs; l++)
				{
					base.AddControl(InputControlType.Analog0 + l, "Analog " + l.ToString(), 0.2f, 0.9f);
				}
			}
			this.skipUpdateFrames = 1;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000EE453 File Offset: 0x000EC653
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			this.Initialize(deviceHandle, deviceInfo, this.profile);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000EE464 File Offset: 0x000EC664
		public override void Update(ulong updateTick, float deltaTime)
		{
			if (this.skipUpdateFrames > 0)
			{
				this.skipUpdateFrames--;
				return;
			}
			IntPtr source;
			if (Native.GetDeviceState(this.Handle, out source))
			{
				Marshal.Copy(source, this.buttons, 0, this.buttons.Length);
				source = new IntPtr(source.ToInt64() + (long)(this.buttons.Length * 2));
				Marshal.Copy(source, this.analogs, 0, this.analogs.Length);
			}
			if (this.IsKnown)
			{
				int analogCount = this.profile.AnalogCount;
				for (int i = 0; i < analogCount; i++)
				{
					InputControlMapping inputControlMapping = this.profile.AnalogMappings[i];
					float value = inputControlMapping.Source.GetValue(this);
					InputControl control = base.GetControl(inputControlMapping.Target);
					if (!inputControlMapping.IgnoreInitialZeroValue || !control.IsOnZeroTick || !Utility.IsZero(value))
					{
						float value2 = inputControlMapping.ApplyToValue(value);
						control.UpdateWithValue(value2, updateTick, deltaTime);
					}
				}
				int buttonCount = this.profile.ButtonCount;
				for (int j = 0; j < buttonCount; j++)
				{
					InputControlMapping inputControlMapping2 = this.profile.ButtonMappings[j];
					bool state = inputControlMapping2.Source.GetState(this);
					base.UpdateWithState(inputControlMapping2.Target, state, updateTick, deltaTime);
				}
				return;
			}
			for (int k = 0; k < this.NumUnknownButtons; k++)
			{
				base.UpdateWithState(InputControlType.Button0 + k, this.ReadRawButtonState(k), updateTick, deltaTime);
			}
			for (int l = 0; l < this.NumUnknownAnalogs; l++)
			{
				base.UpdateWithValue(InputControlType.Analog0 + l, this.ReadRawAnalogValue(l), updateTick, deltaTime);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000EE60D File Offset: 0x000EC80D
		public override bool ReadRawButtonState(int index)
		{
			return index < this.buttons.Length && this.buttons[index] > -32767;
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000EE62B File Offset: 0x000EC82B
		public override float ReadRawAnalogValue(int index)
		{
			if (index < this.analogs.Length)
			{
				return (float)this.analogs[index] / 32767f;
			}
			return 0f;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000EE64D File Offset: 0x000EC84D
		private static byte FloatToByte(float value)
		{
			return (byte)(Mathf.Clamp01(value) * 255f);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000EE65C File Offset: 0x000EC85C
		public override void Vibrate(float leftMotor, float rightMotor)
		{
			Native.SetHapticState(this.Handle, NativeInputDevice.FloatToByte(leftMotor), NativeInputDevice.FloatToByte(rightMotor));
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000EE675 File Offset: 0x000EC875
		public override void SetLightColor(float red, float green, float blue)
		{
			Native.SetLightColor(this.Handle, NativeInputDevice.FloatToByte(red), NativeInputDevice.FloatToByte(green), NativeInputDevice.FloatToByte(blue));
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000EE694 File Offset: 0x000EC894
		public override void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
			Native.SetLightFlash(this.Handle, NativeInputDevice.FloatToByte(flashOnDuration), NativeInputDevice.FloatToByte(flashOffDuration));
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000EE6B0 File Offset: 0x000EC8B0
		public string GetAppleGlyphNameForControl(InputControlType controlType)
		{
			if (InputManager.NativeInputEnableMFi && this.Info.vendorID == 65535)
			{
				InputControlSource inputControlSource = this.controlSourceByTarget[(int)controlType];
				if (inputControlSource.SourceType != InputControlSourceType.None)
				{
					InputControlSourceType sourceType = inputControlSource.SourceType;
					IntPtr zero;
					uint num;
					if (sourceType != InputControlSourceType.Button)
					{
						if (sourceType != InputControlSourceType.Analog)
						{
							zero = IntPtr.Zero;
							num = 0U;
						}
						else
						{
							num = Native.GetAnalogGlyphName(this.Handle, (uint)inputControlSource.Index, out zero);
						}
					}
					else
					{
						num = Native.GetButtonGlyphName(this.Handle, (uint)inputControlSource.Index, out zero);
					}
					if (num > 0U)
					{
						this.glyphName.Clear();
						int num2 = 0;
						while ((long)num2 < (long)((ulong)num))
						{
							this.glyphName.Append((char)Marshal.ReadByte(zero, num2));
							num2++;
						}
						return this.glyphName.ToString();
					}
				}
			}
			return "";
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000EE784 File Offset: 0x000EC984
		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			return this.Info.HasSameVendorID(deviceInfo);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000EE7A0 File Offset: 0x000EC9A0
		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			return this.Info.HasSameProductID(deviceInfo);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000EE7BC File Offset: 0x000EC9BC
		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			return this.Info.HasSameVersionNumber(deviceInfo);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000EE7D8 File Offset: 0x000EC9D8
		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			return this.Info.HasSameLocation(deviceInfo);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000EE7F4 File Offset: 0x000EC9F4
		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			return this.Info.HasSameSerialNumber(deviceInfo);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000EE810 File Offset: 0x000ECA10
		public override bool IsSupportedOnThisPlatform
		{
			get
			{
				return this.profile == null || this.profile.IsSupportedOnThisPlatform;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000EE827 File Offset: 0x000ECA27
		public override bool IsKnown
		{
			get
			{
				return this.profile != null;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000EE832 File Offset: 0x000ECA32
		public override int NumUnknownButtons
		{
			get
			{
				return this.numUnknownButtons;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x000EE83A File Offset: 0x000ECA3A
		public override int NumUnknownAnalogs
		{
			get
			{
				return this.numUnknownAnalogs;
			}
		}

		// Token: 0x040031A0 RID: 12704
		private const int maxUnknownButtons = 20;

		// Token: 0x040031A1 RID: 12705
		private const int maxUnknownAnalogs = 20;

		// Token: 0x040031A4 RID: 12708
		private short[] buttons;

		// Token: 0x040031A5 RID: 12709
		private short[] analogs;

		// Token: 0x040031A6 RID: 12710
		private InputDeviceProfile profile;

		// Token: 0x040031A7 RID: 12711
		private int skipUpdateFrames;

		// Token: 0x040031A8 RID: 12712
		private int numUnknownButtons;

		// Token: 0x040031A9 RID: 12713
		private int numUnknownAnalogs;

		// Token: 0x040031AA RID: 12714
		private InputControlSource[] controlSourceByTarget;

		// Token: 0x040031AB RID: 12715
		private readonly StringBuilder glyphName;

		// Token: 0x040031AC RID: 12716
		private const string defaultGlyphName = "";
	}
}
