using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086F RID: 2159
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterFerrari458RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600310C RID: 12556 RVA: 0x0011E380 File Offset: 0x0011C580
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Thrustmaster Ferrari 458 Racing Wheel";
			base.DeviceNotes = "Thrustmaster Ferrari 458 Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 23296
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 23299
				}
			};
		}
	}
}
