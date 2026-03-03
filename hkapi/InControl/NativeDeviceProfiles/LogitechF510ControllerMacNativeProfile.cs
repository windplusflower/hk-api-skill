using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081D RID: 2077
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF510ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003068 RID: 12392 RVA: 0x0011B668 File Offset: 0x00119868
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech F510 Controller";
			base.DeviceNotes = "Logitech F510 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49694
				}
			};
		}
	}
}
