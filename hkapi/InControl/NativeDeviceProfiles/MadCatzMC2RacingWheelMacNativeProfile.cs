using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000831 RID: 2097
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMC2RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0011BF88 File Offset: 0x0011A188
		public override void Define()
		{
			base.Define();
			base.DeviceName = "MadCatz MC2 Racing Wheel";
			base.DeviceNotes = "MadCatz MC2 Racing Wheel on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61472
				}
			};
		}
	}
}
