using System;
using System.IO;

namespace InControl
{
	// Token: 0x020006BD RID: 1725
	public abstract class BindingSource : IEquatable<BindingSource>
	{
		// Token: 0x060028CA RID: 10442
		public abstract float GetValue(InputDevice inputDevice);

		// Token: 0x060028CB RID: 10443
		public abstract bool GetState(InputDevice inputDevice);

		// Token: 0x060028CC RID: 10444
		public abstract bool Equals(BindingSource other);

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060028CD RID: 10445
		public abstract string Name { get; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060028CE RID: 10446
		public abstract string DeviceName { get; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060028CF RID: 10447
		public abstract InputDeviceClass DeviceClass { get; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060028D0 RID: 10448
		public abstract InputDeviceStyle DeviceStyle { get; }

		// Token: 0x060028D1 RID: 10449 RVA: 0x000E4E55 File Offset: 0x000E3055
		public static bool operator ==(BindingSource a, BindingSource b)
		{
			return a == b || (a != null && b != null && a.BindingSourceType == b.BindingSourceType && a.Equals(b));
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000E4E7C File Offset: 0x000E307C
		public static bool operator !=(BindingSource a, BindingSource b)
		{
			return !(a == b);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000E4E88 File Offset: 0x000E3088
		public override bool Equals(object obj)
		{
			return this.Equals((BindingSource)obj);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000E4E96 File Offset: 0x000E3096
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060028D5 RID: 10453
		public abstract BindingSourceType BindingSourceType { get; }

		// Token: 0x060028D6 RID: 10454
		public abstract void Save(BinaryWriter writer);

		// Token: 0x060028D7 RID: 10455
		public abstract void Load(BinaryReader reader, ushort dataFormatVersion);

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000E4E9E File Offset: 0x000E309E
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x000E4EA6 File Offset: 0x000E30A6
		internal PlayerAction BoundTo { get; set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x0004E56C File Offset: 0x0004C76C
		internal virtual bool IsValid
		{
			get
			{
				return true;
			}
		}
	}
}
