using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000812 RID: 2066
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProVXSAMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003052 RID: 12370 RVA: 0x0011B18C File Offset: 0x0011938C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro VX SA";
			base.DeviceNotes = "Hori Real Arcade Pro VX SA on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62722
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21761
				}
			};
		}
	}
}
