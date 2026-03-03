using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000819 RID: 2073
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechChillStreamControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003060 RID: 12384 RVA: 0x0011B494 File Offset: 0x00119694
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech Chill Stream Controller";
			base.DeviceNotes = "Logitech Chill Stream Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49730
				}
			};
		}
	}
}
