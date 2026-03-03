using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F2 RID: 2034
	[Preserve]
	[NativeInputDeviceProfile]
	public class EASportsControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003012 RID: 12306 RVA: 0x0011A1B8 File Offset: 0x001183B8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "EA Sports Controller";
			base.DeviceNotes = "EA Sports Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 305
				}
			};
		}
	}
}
