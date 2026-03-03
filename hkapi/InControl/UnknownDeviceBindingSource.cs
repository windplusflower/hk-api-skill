using System;
using System.IO;

namespace InControl
{
	// Token: 0x020006CE RID: 1742
	public class UnknownDeviceBindingSource : BindingSource
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000E75BD File Offset: 0x000E57BD
		// (set) Token: 0x060029B4 RID: 10676 RVA: 0x000E75C5 File Offset: 0x000E57C5
		public UnknownDeviceControl Control { get; protected set; }

		// Token: 0x060029B5 RID: 10677 RVA: 0x000E75CE File Offset: 0x000E57CE
		internal UnknownDeviceBindingSource()
		{
			this.Control = UnknownDeviceControl.None;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000E75E1 File Offset: 0x000E57E1
		public UnknownDeviceBindingSource(UnknownDeviceControl control)
		{
			this.Control = control;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000E75F0 File Offset: 0x000E57F0
		public override float GetValue(InputDevice device)
		{
			return this.Control.GetValue(device);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000E760C File Offset: 0x000E580C
		public override bool GetState(InputDevice device)
		{
			return device != null && Utility.IsNotZero(this.GetValue(device));
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000E7620 File Offset: 0x000E5820
		public override string Name
		{
			get
			{
				if (base.BoundTo == null)
				{
					return "";
				}
				string text = "";
				if (this.Control.SourceRange == InputRangeType.ZeroToMinusOne)
				{
					text = "Negative ";
				}
				else if (this.Control.SourceRange == InputRangeType.ZeroToOne)
				{
					text = "Positive ";
				}
				InputDevice device = base.BoundTo.Device;
				if (device == InputDevice.Null)
				{
					string str = text;
					UnknownDeviceControl control = this.Control;
					return str + control.Control.ToString();
				}
				InputControl control2 = device.GetControl(this.Control.Control);
				if (control2 == InputControl.Null)
				{
					string str2 = text;
					UnknownDeviceControl control = this.Control;
					return str2 + control.Control.ToString();
				}
				return text + control2.Handle;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000E76E8 File Offset: 0x000E58E8
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
					return "Unknown Controller";
				}
				return device.Name;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x00059F92 File Offset: 0x00058192
		public override InputDeviceClass DeviceClass
		{
			get
			{
				return InputDeviceClass.Controller;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0000D742 File Offset: 0x0000B942
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
				return InputDeviceStyle.Unknown;
			}
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000E7724 File Offset: 0x000E5924
		public override bool Equals(BindingSource other)
		{
			if (other == null)
			{
				return false;
			}
			UnknownDeviceBindingSource unknownDeviceBindingSource = other as UnknownDeviceBindingSource;
			return unknownDeviceBindingSource != null && this.Control == unknownDeviceBindingSource.Control;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000E7760 File Offset: 0x000E5960
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			UnknownDeviceBindingSource unknownDeviceBindingSource = other as UnknownDeviceBindingSource;
			return unknownDeviceBindingSource != null && this.Control == unknownDeviceBindingSource.Control;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000E7798 File Offset: 0x000E5998
		public override int GetHashCode()
		{
			return this.Control.GetHashCode();
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000977F9 File Offset: 0x000959F9
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.UnknownDeviceBindingSource;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000E77BC File Offset: 0x000E59BC
		internal override bool IsValid
		{
			get
			{
				if (base.BoundTo == null)
				{
					Logger.LogError("Cannot query property 'IsValid' for unbound BindingSource.");
					return false;
				}
				InputDevice device = base.BoundTo.Device;
				return device == InputDevice.Null || device.HasControl(this.Control.Control);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000E7804 File Offset: 0x000E5A04
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			UnknownDeviceControl control = default(UnknownDeviceControl);
			control.Load(reader);
			this.Control = control;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000E7828 File Offset: 0x000E5A28
		public override void Save(BinaryWriter writer)
		{
			this.Control.Save(writer);
		}
	}
}
