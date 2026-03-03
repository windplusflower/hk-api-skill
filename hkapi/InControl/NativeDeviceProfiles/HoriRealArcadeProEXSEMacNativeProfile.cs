using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080C RID: 2060
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProEXSEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003046 RID: 12358 RVA: 0x0011AEF8 File Offset: 0x001190F8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro EX SE";
			base.DeviceNotes = "Hori Real Arcade Pro EX SE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 22
				}
			};
		}
	}
}
