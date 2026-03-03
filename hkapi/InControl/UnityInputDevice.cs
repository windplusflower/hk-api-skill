using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000720 RID: 1824
	public class UnityInputDevice : InputDevice
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000F31DE File Offset: 0x000F13DE
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x000F31E6 File Offset: 0x000F13E6
		public int JoystickId { get; private set; }

		// Token: 0x06002D48 RID: 11592 RVA: 0x000F31EF File Offset: 0x000F13EF
		public UnityInputDevice(int joystickId, string joystickName) : this(null, joystickId, joystickName)
		{
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x000F31FC File Offset: 0x000F13FC
		public UnityInputDevice(InputDeviceProfile deviceProfile, int joystickId, string joystickName)
		{
			this.profile = deviceProfile;
			this.JoystickId = joystickId;
			if (joystickId != 0)
			{
				base.SortOrder = 100 + joystickId;
			}
			UnityInputDevice.SetupAnalogQueries();
			UnityInputDevice.SetupButtonQueries();
			base.AnalogSnapshot = null;
			if (this.IsKnown)
			{
				base.Name = this.profile.DeviceName;
				base.Meta = this.profile.DeviceNotes;
				base.DeviceClass = this.profile.DeviceClass;
				base.DeviceStyle = this.profile.DeviceStyle;
				int analogCount = this.profile.AnalogCount;
				for (int i = 0; i < analogCount; i++)
				{
					InputControlMapping inputControlMapping = this.profile.AnalogMappings[i];
					if (Utility.TargetIsAlias(inputControlMapping.Target))
					{
						Logger.LogError(string.Concat(new string[]
						{
							"Cannot map control \"",
							inputControlMapping.Name,
							"\" as InputControlType.",
							inputControlMapping.Target.ToString(),
							" in profile \"",
							deviceProfile.DeviceName,
							"\" because this target is reserved as an alias. The mapping will be ignored."
						}));
					}
					else
					{
						InputControl inputControl = base.AddControl(inputControlMapping.Target, inputControlMapping.Name);
						inputControl.Sensitivity = Mathf.Min(this.profile.Sensitivity, inputControlMapping.Sensitivity);
						inputControl.LowerDeadZone = Mathf.Max(this.profile.LowerDeadZone, inputControlMapping.LowerDeadZone);
						inputControl.UpperDeadZone = Mathf.Min(this.profile.UpperDeadZone, inputControlMapping.UpperDeadZone);
						inputControl.Raw = inputControlMapping.Raw;
						inputControl.Passive = inputControlMapping.Passive;
					}
				}
				int buttonCount = this.profile.ButtonCount;
				for (int j = 0; j < buttonCount; j++)
				{
					InputControlMapping inputControlMapping2 = this.profile.ButtonMappings[j];
					if (Utility.TargetIsAlias(inputControlMapping2.Target))
					{
						Logger.LogError(string.Concat(new string[]
						{
							"Cannot map control \"",
							inputControlMapping2.Name,
							"\" as InputControlType.",
							inputControlMapping2.Target.ToString(),
							" in profile \"",
							deviceProfile.DeviceName,
							"\" because this target is reserved as an alias. The mapping will be ignored."
						}));
					}
					else
					{
						base.AddControl(inputControlMapping2.Target, inputControlMapping2.Name).Passive = inputControlMapping2.Passive;
					}
				}
				return;
			}
			base.Name = "Unknown Device";
			base.Meta = "\"" + joystickName + "\"";
			for (int k = 0; k < this.NumUnknownButtons; k++)
			{
				base.AddControl(InputControlType.Button0 + k, "Button " + k.ToString());
			}
			for (int l = 0; l < this.NumUnknownAnalogs; l++)
			{
				base.AddControl(InputControlType.Analog0 + l, "Analog " + l.ToString(), 0.2f, 0.9f);
			}
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000F34F0 File Offset: 0x000F16F0
		public override void Update(ulong updateTick, float deltaTime)
		{
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

		// Token: 0x06002D4B RID: 11595 RVA: 0x000F362C File Offset: 0x000F182C
		private static void SetupAnalogQueries()
		{
			if (UnityInputDevice.analogQueries == null)
			{
				UnityInputDevice.analogQueries = new string[10, 20];
				for (int i = 1; i <= 10; i++)
				{
					for (int j = 0; j < 20; j++)
					{
						UnityInputDevice.analogQueries[i - 1, j] = "joystick " + i.ToString() + " analog " + j.ToString();
					}
				}
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000F3694 File Offset: 0x000F1894
		private static void SetupButtonQueries()
		{
			if (UnityInputDevice.buttonQueries == null)
			{
				UnityInputDevice.buttonQueries = new string[10, 20];
				for (int i = 1; i <= 10; i++)
				{
					for (int j = 0; j < 20; j++)
					{
						UnityInputDevice.buttonQueries[i - 1, j] = "joystick " + i.ToString() + " button " + j.ToString();
					}
				}
			}
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000F36FB File Offset: 0x000F18FB
		public override bool ReadRawButtonState(int index)
		{
			return index < 20 && Input.GetKey(UnityInputDevice.buttonQueries[this.JoystickId - 1, index]);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000F371C File Offset: 0x000F191C
		public override float ReadRawAnalogValue(int index)
		{
			if (index < 20)
			{
				return Input.GetAxisRaw(UnityInputDevice.analogQueries[this.JoystickId - 1, index]);
			}
			return 0f;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000F3741 File Offset: 0x000F1941
		public override bool IsSupportedOnThisPlatform
		{
			get
			{
				return this.profile == null || this.profile.IsSupportedOnThisPlatform;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000F3758 File Offset: 0x000F1958
		public override bool IsKnown
		{
			get
			{
				return this.profile != null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000F3763 File Offset: 0x000F1963
		public override int NumUnknownButtons
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000F3763 File Offset: 0x000F1963
		public override int NumUnknownAnalogs
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x040032B1 RID: 12977
		private static string[,] analogQueries;

		// Token: 0x040032B2 RID: 12978
		private static string[,] buttonQueries;

		// Token: 0x040032B3 RID: 12979
		public const int MaxDevices = 10;

		// Token: 0x040032B4 RID: 12980
		public const int MaxButtons = 20;

		// Token: 0x040032B5 RID: 12981
		public const int MaxAnalogs = 20;

		// Token: 0x040032B7 RID: 12983
		private readonly InputDeviceProfile profile;
	}
}
