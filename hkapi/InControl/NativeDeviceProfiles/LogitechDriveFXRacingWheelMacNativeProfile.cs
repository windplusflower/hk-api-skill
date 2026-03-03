using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081B RID: 2075
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechDriveFXRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003064 RID: 12388 RVA: 0x0011B564 File Offset: 0x00119764
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech DriveFX Racing Wheel";
			base.DeviceNotes = "Logitech DriveFX Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 51875
				}
			};
		}
	}
}
