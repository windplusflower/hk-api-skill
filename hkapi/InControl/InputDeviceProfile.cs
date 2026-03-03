using System;
using System.Collections.Generic;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006ED RID: 1773
	[Preserve]
	[Serializable]
	public class InputDeviceProfile
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000EAEF2 File Offset: 0x000E90F2
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000EAEFA File Offset: 0x000E90FA
		public InputDeviceProfileType ProfileType
		{
			get
			{
				return this.profileType;
			}
			protected set
			{
				this.profileType = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000EAF03 File Offset: 0x000E9103
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000EAF0B File Offset: 0x000E910B
		public string DeviceName
		{
			get
			{
				return this.deviceName;
			}
			protected set
			{
				this.deviceName = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000EAF14 File Offset: 0x000E9114
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000EAF1C File Offset: 0x000E911C
		public string DeviceNotes
		{
			get
			{
				return this.deviceNotes;
			}
			protected set
			{
				this.deviceNotes = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000EAF25 File Offset: 0x000E9125
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000EAF2D File Offset: 0x000E912D
		public InputDeviceClass DeviceClass
		{
			get
			{
				return this.deviceClass;
			}
			protected set
			{
				this.deviceClass = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000EAF36 File Offset: 0x000E9136
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000EAF3E File Offset: 0x000E913E
		public InputDeviceStyle DeviceStyle
		{
			get
			{
				return this.deviceStyle;
			}
			protected set
			{
				this.deviceStyle = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000EAF47 File Offset: 0x000E9147
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x000EAF4F File Offset: 0x000E914F
		public float Sensitivity
		{
			get
			{
				return this.sensitivity;
			}
			protected set
			{
				this.sensitivity = Mathf.Clamp01(value);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000EAF5D File Offset: 0x000E915D
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x000EAF65 File Offset: 0x000E9165
		public float LowerDeadZone
		{
			get
			{
				return this.lowerDeadZone;
			}
			protected set
			{
				this.lowerDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000EAF73 File Offset: 0x000E9173
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x000EAF7B File Offset: 0x000E917B
		public float UpperDeadZone
		{
			get
			{
				return this.upperDeadZone;
			}
			protected set
			{
				this.upperDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000EAF89 File Offset: 0x000E9189
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x000EAF91 File Offset: 0x000E9191
		public InputControlMapping[] AnalogMappings
		{
			get
			{
				return this.analogMappings;
			}
			protected set
			{
				this.analogMappings = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000EAF9A File Offset: 0x000E919A
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x000EAFA2 File Offset: 0x000E91A2
		public InputControlMapping[] ButtonMappings
		{
			get
			{
				return this.buttonMappings;
			}
			protected set
			{
				this.buttonMappings = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000EAFAB File Offset: 0x000E91AB
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x000EAFB3 File Offset: 0x000E91B3
		public string[] IncludePlatforms
		{
			get
			{
				return this.includePlatforms;
			}
			protected set
			{
				this.includePlatforms = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000EAFBC File Offset: 0x000E91BC
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000EAFC4 File Offset: 0x000E91C4
		public string[] ExcludePlatforms
		{
			get
			{
				return this.excludePlatforms;
			}
			protected set
			{
				this.excludePlatforms = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000EAFCD File Offset: 0x000E91CD
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x000EAFD5 File Offset: 0x000E91D5
		public int MinSystemBuildNumber
		{
			get
			{
				return this.minSystemBuildNumber;
			}
			protected set
			{
				this.minSystemBuildNumber = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000EAFDE File Offset: 0x000E91DE
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x000EAFE6 File Offset: 0x000E91E6
		public int MaxSystemBuildNumber
		{
			get
			{
				return this.maxSystemBuildNumber;
			}
			protected set
			{
				this.maxSystemBuildNumber = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000EAFEF File Offset: 0x000E91EF
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000EAFF7 File Offset: 0x000E91F7
		public VersionInfo MinUnityVersion
		{
			get
			{
				return this.minUnityVersion;
			}
			protected set
			{
				this.minUnityVersion = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000EB000 File Offset: 0x000E9200
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000EB008 File Offset: 0x000E9208
		public VersionInfo MaxUnityVersion
		{
			get
			{
				return this.maxUnityVersion;
			}
			protected set
			{
				this.maxUnityVersion = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000EB011 File Offset: 0x000E9211
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x000EB019 File Offset: 0x000E9219
		public InputDeviceMatcher[] Matchers
		{
			get
			{
				return this.matchers;
			}
			protected set
			{
				this.matchers = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000EB022 File Offset: 0x000E9222
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x000EB02A File Offset: 0x000E922A
		public InputDeviceMatcher[] LastResortMatchers
		{
			get
			{
				return this.lastResortMatchers;
			}
			protected set
			{
				this.lastResortMatchers = value;
			}
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000EB033 File Offset: 0x000E9233
		public static InputDeviceProfile CreateInstanceOfType(Type type)
		{
			InputDeviceProfile inputDeviceProfile = (InputDeviceProfile)Activator.CreateInstance(type);
			inputDeviceProfile.Define();
			return inputDeviceProfile;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000EB048 File Offset: 0x000E9248
		public static InputDeviceProfile CreateInstanceOfType(string typeName)
		{
			Type type = Type.GetType(typeName);
			if (type == null)
			{
				Logger.LogWarning("Cannot find type: " + typeName + "(is the IL2CPP stripping level too high?)");
				return null;
			}
			return InputDeviceProfile.CreateInstanceOfType(type);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000EB084 File Offset: 0x000E9284
		public virtual void Define()
		{
			this.profileType = ((base.GetType().GetCustomAttributes(typeof(NativeInputDeviceProfileAttribute), false).Length != 0) ? InputDeviceProfileType.Native : InputDeviceProfileType.Unity);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000EB0B9 File Offset: 0x000E92B9
		public bool Matches(InputDeviceInfo deviceInfo)
		{
			return this.Matches(deviceInfo, this.Matchers);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000EB0C8 File Offset: 0x000E92C8
		public bool LastResortMatches(InputDeviceInfo deviceInfo)
		{
			return this.Matches(deviceInfo, this.LastResortMatchers);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000EB0D8 File Offset: 0x000E92D8
		public bool Matches(InputDeviceInfo deviceInfo, InputDeviceMatcher[] matchers)
		{
			if (matchers != null)
			{
				int num = matchers.Length;
				for (int i = 0; i < num; i++)
				{
					if (matchers[i].Matches(deviceInfo))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000EB10C File Offset: 0x000E930C
		public bool IsSupportedOnThisPlatform
		{
			get
			{
				VersionInfo a = VersionInfo.UnityVersion();
				if (a < this.MinUnityVersion || a > this.MaxUnityVersion)
				{
					return false;
				}
				int systemBuildNumber = Utility.GetSystemBuildNumber();
				if (this.MaxSystemBuildNumber > 0 && systemBuildNumber > this.MaxSystemBuildNumber)
				{
					return false;
				}
				if (this.MinSystemBuildNumber > 0 && systemBuildNumber < this.MinSystemBuildNumber)
				{
					return false;
				}
				if (this.ExcludePlatforms != null)
				{
					int num = this.ExcludePlatforms.Length;
					for (int i = 0; i < num; i++)
					{
						if (InputManager.Platform.Contains(this.ExcludePlatforms[i].ToUpper()))
						{
							return false;
						}
					}
				}
				if (this.IncludePlatforms == null || this.IncludePlatforms.Length == 0)
				{
					return true;
				}
				if (this.IncludePlatforms != null)
				{
					int num2 = this.IncludePlatforms.Length;
					for (int j = 0; j < num2; j++)
					{
						if (InputManager.Platform.Contains(this.IncludePlatforms[j].ToUpper()))
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000EB1F6 File Offset: 0x000E93F6
		public static void Hide(Type type)
		{
			InputDeviceProfile.hiddenProfiles.Add(type);
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000EB204 File Offset: 0x000E9404
		public bool IsHidden
		{
			get
			{
				return InputDeviceProfile.hiddenProfiles.Contains(base.GetType());
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000EB216 File Offset: 0x000E9416
		public bool IsNotHidden
		{
			get
			{
				return !this.IsHidden;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000EB221 File Offset: 0x000E9421
		public int AnalogCount
		{
			get
			{
				return this.AnalogMappings.Length;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000EB22B File Offset: 0x000E942B
		public int ButtonCount
		{
			get
			{
				return this.ButtonMappings.Length;
			}
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000EB235 File Offset: 0x000E9435
		protected static InputControlSource Button(int index)
		{
			return new InputControlSource(InputControlSourceType.Button, index);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000EB23E File Offset: 0x000E943E
		protected static InputControlSource Analog(int index)
		{
			return new InputControlSource(InputControlSourceType.Analog, index);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000EB247 File Offset: 0x000E9447
		protected static InputControlMapping LeftStickLeftMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Left",
				Target = InputControlType.LeftStickLeft,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000EB27A File Offset: 0x000E947A
		protected static InputControlMapping LeftStickRightMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Right",
				Target = InputControlType.LeftStickRight,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000EB2AD File Offset: 0x000E94AD
		protected static InputControlMapping LeftStickUpMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Up",
				Target = InputControlType.LeftStickUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000EB2E0 File Offset: 0x000E94E0
		protected static InputControlMapping LeftStickDownMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Down",
				Target = InputControlType.LeftStickDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000EB313 File Offset: 0x000E9513
		protected static InputControlMapping LeftStickUpMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Up",
				Target = InputControlType.LeftStickUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000EB346 File Offset: 0x000E9546
		protected static InputControlMapping LeftStickDownMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Stick Down",
				Target = InputControlType.LeftStickDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000EB379 File Offset: 0x000E9579
		protected static InputControlMapping RightStickLeftMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Left",
				Target = InputControlType.RightStickLeft,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000EB3AC File Offset: 0x000E95AC
		protected static InputControlMapping RightStickRightMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Right",
				Target = InputControlType.RightStickRight,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000EB3E0 File Offset: 0x000E95E0
		protected static InputControlMapping RightStickUpMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Up",
				Target = InputControlType.RightStickUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000EB413 File Offset: 0x000E9613
		protected static InputControlMapping RightStickDownMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Down",
				Target = InputControlType.RightStickDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000EB446 File Offset: 0x000E9646
		protected static InputControlMapping RightStickUpMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Up",
				Target = InputControlType.RightStickUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000EB479 File Offset: 0x000E9679
		protected static InputControlMapping RightStickDownMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Stick Down",
				Target = InputControlType.RightStickDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000EB4AC File Offset: 0x000E96AC
		protected static InputControlMapping LeftTriggerMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Left Trigger",
				Target = InputControlType.LeftTrigger,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.MinusOneToOne,
				TargetRange = InputRangeType.ZeroToOne,
				IgnoreInitialZeroValue = true
			};
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000EB4E7 File Offset: 0x000E96E7
		protected static InputControlMapping RightTriggerMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "Right Trigger",
				Target = InputControlType.RightTrigger,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.MinusOneToOne,
				TargetRange = InputRangeType.ZeroToOne,
				IgnoreInitialZeroValue = true
			};
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000EB522 File Offset: 0x000E9722
		protected static InputControlMapping DPadLeftMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Left",
				Target = InputControlType.DPadLeft,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000EB556 File Offset: 0x000E9756
		protected static InputControlMapping DPadRightMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Right",
				Target = InputControlType.DPadRight,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000EB58A File Offset: 0x000E978A
		protected static InputControlMapping DPadUpMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Up",
				Target = InputControlType.DPadUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000EB5BE File Offset: 0x000E97BE
		protected static InputControlMapping DPadDownMapping(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Down",
				Target = InputControlType.DPadDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000EB5F2 File Offset: 0x000E97F2
		protected static InputControlMapping DPadUpMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Up",
				Target = InputControlType.DPadUp,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000EB626 File Offset: 0x000E9826
		protected static InputControlMapping DPadDownMapping2(int analog)
		{
			return new InputControlMapping
			{
				Name = "DPad Down",
				Target = InputControlType.DPadDown,
				Source = InputDeviceProfile.Analog(analog),
				SourceRange = InputRangeType.ZeroToMinusOne,
				TargetRange = InputRangeType.ZeroToOne
			};
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000EB65C File Offset: 0x000E985C
		public InputDeviceProfile()
		{
			this.deviceName = "";
			this.deviceNotes = "";
			this.sensitivity = 1f;
			this.lowerDeadZone = 0.2f;
			this.upperDeadZone = 0.9f;
			this.includePlatforms = new string[0];
			this.excludePlatforms = new string[0];
			this.minUnityVersion = VersionInfo.Min;
			this.maxUnityVersion = VersionInfo.Max;
			this.matchers = new InputDeviceMatcher[0];
			this.lastResortMatchers = new InputDeviceMatcher[0];
			this.analogMappings = new InputControlMapping[0];
			this.buttonMappings = new InputControlMapping[0];
			base..ctor();
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000EB704 File Offset: 0x000E9904
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceProfile()
		{
			InputDeviceProfile.hiddenProfiles = new HashSet<Type>();
			InputDeviceProfile.MenuKey = new InputControlSource(KeyCode.Menu);
			InputDeviceProfile.EscapeKey = new InputControlSource(KeyCode.Escape);
		}

		// Token: 0x04003111 RID: 12561
		private static readonly HashSet<Type> hiddenProfiles;

		// Token: 0x04003112 RID: 12562
		[SerializeField]
		private InputDeviceProfileType profileType;

		// Token: 0x04003113 RID: 12563
		[SerializeField]
		private string deviceName;

		// Token: 0x04003114 RID: 12564
		[SerializeField]
		[TextArea]
		private string deviceNotes;

		// Token: 0x04003115 RID: 12565
		[SerializeField]
		private InputDeviceClass deviceClass;

		// Token: 0x04003116 RID: 12566
		[SerializeField]
		private InputDeviceStyle deviceStyle;

		// Token: 0x04003117 RID: 12567
		[SerializeField]
		private float sensitivity;

		// Token: 0x04003118 RID: 12568
		[SerializeField]
		private float lowerDeadZone;

		// Token: 0x04003119 RID: 12569
		[SerializeField]
		private float upperDeadZone;

		// Token: 0x0400311A RID: 12570
		[SerializeField]
		private string[] includePlatforms;

		// Token: 0x0400311B RID: 12571
		[SerializeField]
		private string[] excludePlatforms;

		// Token: 0x0400311C RID: 12572
		[SerializeField]
		private int minSystemBuildNumber;

		// Token: 0x0400311D RID: 12573
		[SerializeField]
		private int maxSystemBuildNumber;

		// Token: 0x0400311E RID: 12574
		[SerializeField]
		private VersionInfo minUnityVersion;

		// Token: 0x0400311F RID: 12575
		[SerializeField]
		private VersionInfo maxUnityVersion;

		// Token: 0x04003120 RID: 12576
		[SerializeField]
		private InputDeviceMatcher[] matchers;

		// Token: 0x04003121 RID: 12577
		[SerializeField]
		private InputDeviceMatcher[] lastResortMatchers;

		// Token: 0x04003122 RID: 12578
		[SerializeField]
		private InputControlMapping[] analogMappings;

		// Token: 0x04003123 RID: 12579
		[SerializeField]
		private InputControlMapping[] buttonMappings;

		// Token: 0x04003124 RID: 12580
		protected static readonly InputControlSource MenuKey;

		// Token: 0x04003125 RID: 12581
		protected static readonly InputControlSource EscapeKey;
	}
}
