using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086E RID: 2158
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600310A RID: 12554 RVA: 0x0011E318 File Offset: 0x0011C518
		public override void Define()
		{
			base.Define();
			base.DeviceName = "ThrustMaster Ferrari 458 Spider Racing Wheel";
			base.DeviceNotes = "ThrustMaster Ferrari 458 Spider Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1103,
					ProductID = 46705
				}
			};
		}
	}
}
