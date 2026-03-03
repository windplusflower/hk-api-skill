using System;
using System.Runtime.InteropServices;

namespace InControl
{
	// Token: 0x020006E9 RID: 1769
	public struct InputDeviceInfo
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x000EACD9 File Offset: 0x000E8ED9
		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			return this.vendorID == deviceInfo.vendorID;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000EACE9 File Offset: 0x000E8EE9
		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			return this.productID == deviceInfo.productID;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000EACF9 File Offset: 0x000E8EF9
		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			return this.versionNumber == deviceInfo.versionNumber;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000EAD09 File Offset: 0x000E8F09
		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			return !string.IsNullOrEmpty(this.location) && this.location == deviceInfo.location;
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000EAD2B File Offset: 0x000E8F2B
		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			return !string.IsNullOrEmpty(this.serialNumber) && this.serialNumber == deviceInfo.serialNumber;
		}

		// Token: 0x040030FF RID: 12543
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string name;

		// Token: 0x04003100 RID: 12544
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string location;

		// Token: 0x04003101 RID: 12545
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string serialNumber;

		// Token: 0x04003102 RID: 12546
		public ushort vendorID;

		// Token: 0x04003103 RID: 12547
		public ushort productID;

		// Token: 0x04003104 RID: 12548
		public uint versionNumber;

		// Token: 0x04003105 RID: 12549
		public InputDeviceDriverType driverType;

		// Token: 0x04003106 RID: 12550
		public InputDeviceTransportType transportType;

		// Token: 0x04003107 RID: 12551
		public uint numButtons;

		// Token: 0x04003108 RID: 12552
		public uint numAnalogs;
	}
}
