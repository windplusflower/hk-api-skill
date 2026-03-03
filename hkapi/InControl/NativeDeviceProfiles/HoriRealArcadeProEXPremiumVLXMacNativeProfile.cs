using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080B RID: 2059
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProEXPremiumVLXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x0011AE90 File Offset: 0x00119090
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro EX Premium VLX";
			base.DeviceNotes = "Hori Real Arcade Pro EX Premium VLX on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62726
				}
			};
		}
	}
}
