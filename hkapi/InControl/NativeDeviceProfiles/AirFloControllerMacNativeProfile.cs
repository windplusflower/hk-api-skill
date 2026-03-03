using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007E9 RID: 2025
	[Preserve]
	[NativeInputDeviceProfile]
	public class AirFloControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x00119DA8 File Offset: 0x00117FA8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Air Flo Controller";
			base.DeviceNotes = "Air Flo Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21251
				}
			};
		}
	}
}
