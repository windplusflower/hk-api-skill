using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081E RID: 2078
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF710ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600306A RID: 12394 RVA: 0x0011B6D0 File Offset: 0x001198D0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech F710 Controller";
			base.DeviceNotes = "Logitech F710 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49695
				}
			};
		}
	}
}
