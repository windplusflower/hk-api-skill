using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080A RID: 2058
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProEXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003042 RID: 12354 RVA: 0x0011AE28 File Offset: 0x00119028
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro EX";
			base.DeviceNotes = "Hori Real Arcade Pro EX on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62724
				}
			};
		}
	}
}
