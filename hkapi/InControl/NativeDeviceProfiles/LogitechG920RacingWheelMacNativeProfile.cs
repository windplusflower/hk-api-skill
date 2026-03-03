using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081F RID: 2079
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechG920RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x0011B738 File Offset: 0x00119938
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech G920 Racing Wheel";
			base.DeviceNotes = "Logitech G920 Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 49761
				}
			};
		}
	}
}
