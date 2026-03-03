using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006EC RID: 1772
	[Serializable]
	public struct InputDeviceMatcher
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000EAD68 File Offset: 0x000E8F68
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x000EAD70 File Offset: 0x000E8F70
		public OptionalUInt16 VendorID
		{
			get
			{
				return this.vendorID;
			}
			set
			{
				this.vendorID = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000EAD79 File Offset: 0x000E8F79
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x000EAD81 File Offset: 0x000E8F81
		public OptionalUInt16 ProductID
		{
			get
			{
				return this.productID;
			}
			set
			{
				this.productID = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000EAD8A File Offset: 0x000E8F8A
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x000EAD92 File Offset: 0x000E8F92
		public OptionalUInt32 VersionNumber
		{
			get
			{
				return this.versionNumber;
			}
			set
			{
				this.versionNumber = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000EAD9B File Offset: 0x000E8F9B
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x000EADA3 File Offset: 0x000E8FA3
		public OptionalInputDeviceDriverType DriverType
		{
			get
			{
				return this.driverType;
			}
			set
			{
				this.driverType = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000EADAC File Offset: 0x000E8FAC
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x000EADB4 File Offset: 0x000E8FB4
		public OptionalInputDeviceTransportType TransportType
		{
			get
			{
				return this.transportType;
			}
			set
			{
				this.transportType = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000EADBD File Offset: 0x000E8FBD
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x000EADC5 File Offset: 0x000E8FC5
		public string NameLiteral
		{
			get
			{
				return this.nameLiteral;
			}
			set
			{
				this.nameLiteral = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000EADCE File Offset: 0x000E8FCE
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x000EADD6 File Offset: 0x000E8FD6
		public string NamePattern
		{
			get
			{
				return this.namePattern;
			}
			set
			{
				this.namePattern = value;
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000EADE0 File Offset: 0x000E8FE0
		internal bool Matches(InputDeviceInfo deviceInfo)
		{
			return (!this.VendorID.HasValue || this.VendorID.Value == deviceInfo.vendorID) && (!this.ProductID.HasValue || this.ProductID.Value == deviceInfo.productID) && (!this.VersionNumber.HasValue || this.VersionNumber.Value == deviceInfo.versionNumber) && (!this.DriverType.HasValue || this.DriverType.Value == deviceInfo.driverType) && (!this.TransportType.HasValue || this.TransportType.Value == deviceInfo.transportType) && (this.NameLiteral == null || string.Equals(deviceInfo.name, this.NameLiteral, StringComparison.OrdinalIgnoreCase)) && (this.NamePattern == null || Regex.IsMatch(deviceInfo.name, this.NamePattern, RegexOptions.IgnoreCase));
		}

		// Token: 0x0400310A RID: 12554
		[SerializeField]
		[Hexadecimal]
		private OptionalUInt16 vendorID;

		// Token: 0x0400310B RID: 12555
		[SerializeField]
		private OptionalUInt16 productID;

		// Token: 0x0400310C RID: 12556
		[SerializeField]
		[Hexadecimal]
		private OptionalUInt32 versionNumber;

		// Token: 0x0400310D RID: 12557
		[SerializeField]
		private OptionalInputDeviceDriverType driverType;

		// Token: 0x0400310E RID: 12558
		[SerializeField]
		private OptionalInputDeviceTransportType transportType;

		// Token: 0x0400310F RID: 12559
		[SerializeField]
		private string nameLiteral;

		// Token: 0x04003110 RID: 12560
		[SerializeField]
		private string namePattern;
	}
}
