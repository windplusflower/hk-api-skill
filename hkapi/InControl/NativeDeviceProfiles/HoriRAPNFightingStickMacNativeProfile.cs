using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000809 RID: 2057
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRAPNFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003040 RID: 12352 RVA: 0x0011ADC0 File Offset: 0x00118FC0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori RAP N Fighting Stick";
			base.DeviceNotes = "Hori RAP N Fighting Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 174
				}
			};
		}
	}
}
