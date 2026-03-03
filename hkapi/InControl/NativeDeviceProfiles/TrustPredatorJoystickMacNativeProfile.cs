using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000873 RID: 2163
	[Preserve]
	[NativeInputDeviceProfile]
	public class TrustPredatorJoystickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003114 RID: 12564 RVA: 0x0011E588 File Offset: 0x0011C788
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Trust Predator Joystick";
			base.DeviceNotes = "Trust Predator Joystick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 2064,
					ProductID = 3
				}
			};
		}
	}
}
