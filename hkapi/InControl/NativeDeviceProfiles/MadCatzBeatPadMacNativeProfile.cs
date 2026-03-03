using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000825 RID: 2085
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzBeatPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003078 RID: 12408 RVA: 0x0011B9DC File Offset: 0x00119BDC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Beat Pad";
			base.DeviceNotes = "Mad Catz Beat Pad on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18240
				}
			};
		}
	}
}
