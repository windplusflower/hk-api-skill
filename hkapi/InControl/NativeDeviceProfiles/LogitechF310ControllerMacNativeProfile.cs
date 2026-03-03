using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081C RID: 2076
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF310ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0011B5CC File Offset: 0x001197CC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech F310 Controller";
			base.DeviceNotes = "Logitech F310 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49693
				},
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49686
				}
			};
		}
	}
}
