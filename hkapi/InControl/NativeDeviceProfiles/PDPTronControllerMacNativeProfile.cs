using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084E RID: 2126
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPTronControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030CA RID: 12490 RVA: 0x0011D098 File Offset: 0x0011B298
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Tron Controller";
			base.DeviceNotes = "PDP Tron Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63747
				}
			};
		}
	}
}
