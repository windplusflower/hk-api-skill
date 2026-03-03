using System;
using System.IO;

namespace InControl
{
	// Token: 0x020006C1 RID: 1729
	public class DeviceBindingSource : BindingSource
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000E4EAF File Offset: 0x000E30AF
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x000E4EB7 File Offset: 0x000E30B7
		public InputControlType Control { get; protected set; }

		// Token: 0x060028E0 RID: 10464 RVA: 0x000E4EC0 File Offset: 0x000E30C0
		internal DeviceBindingSource()
		{
			this.Control = InputControlType.None;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000E4ECF File Offset: 0x000E30CF
		public DeviceBindingSource(InputControlType control)
		{
			this.Control = control;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000E4EDE File Offset: 0x000E30DE
		public override float GetValue(InputDevice inputDevice)
		{
			if (inputDevice == null)
			{
				return 0f;
			}
			return inputDevice.GetControl(this.Control).Value;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000E4EFA File Offset: 0x000E30FA
		public override bool GetState(InputDevice inputDevice)
		{
			return inputDevice != null && inputDevice.GetControl(this.Control).State;
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000E4F14 File Offset: 0x000E3114
		public override string Name
		{
			get
			{
				if (base.BoundTo == null)
				{
					return "";
				}
				InputDevice device = base.BoundTo.Device;
				if (device.GetControl(this.Control) == InputControl.Null)
				{
					return this.Control.ToString();
				}
				return device.GetControl(this.Control).Handle;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000E4F74 File Offset: 0x000E3174
		public override string DeviceName
		{
			get
			{
				if (base.BoundTo == null)
				{
					return "";
				}
				InputDevice device = base.BoundTo.Device;
				if (device == InputDevice.Null)
				{
					return "Controller";
				}
				return device.Name;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000E4FAF File Offset: 0x000E31AF
		public override InputDeviceClass DeviceClass
		{
			get
			{
				if (base.BoundTo != null)
				{
					return base.BoundTo.Device.DeviceClass;
				}
				return InputDeviceClass.Unknown;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000E4FCB File Offset: 0x000E31CB
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
				if (base.BoundTo != null)
				{
					return base.BoundTo.Device.DeviceStyle;
				}
				return InputDeviceStyle.Unknown;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000E4FE8 File Offset: 0x000E31E8
		public override bool Equals(BindingSource other)
		{
			if (other == null)
			{
				return false;
			}
			DeviceBindingSource deviceBindingSource = other as DeviceBindingSource;
			return deviceBindingSource != null && this.Control == deviceBindingSource.Control;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000E5020 File Offset: 0x000E3220
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			DeviceBindingSource deviceBindingSource = other as DeviceBindingSource;
			return deviceBindingSource != null && this.Control == deviceBindingSource.Control;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000E5054 File Offset: 0x000E3254
		public override int GetHashCode()
		{
			return this.Control.GetHashCode();
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0004E56C File Offset: 0x0004C76C
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.DeviceBindingSource;
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000E5075 File Offset: 0x000E3275
		public override void Save(BinaryWriter writer)
		{
			writer.Write((int)this.Control);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000E5083 File Offset: 0x000E3283
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.Control = (InputControlType)reader.ReadInt32();
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000E5091 File Offset: 0x000E3291
		internal override bool IsValid
		{
			get
			{
				if (base.BoundTo == null)
				{
					Logger.LogError("Cannot query property 'IsValid' for unbound BindingSource.");
					return false;
				}
				return base.BoundTo.Device.HasControl(this.Control) || Utility.TargetIsStandard(this.Control);
			}
		}
	}
}
