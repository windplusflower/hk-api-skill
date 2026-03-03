using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086D RID: 2157
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustMasterFerrari430RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003108 RID: 12552 RVA: 0x0011E2B0 File Offset: 0x0011C4B0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "ThrustMaster Ferrari 430 Racing Wheel";
			base.DeviceNotes = "ThrustMaster Ferrari 430 Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1103,
					ProductID = 46683
				}
			};
		}
	}
}
