using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082B RID: 2091
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003084 RID: 12420 RVA: 0x0011BD18 File Offset: 0x00119F18
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz FightPad";
			base.DeviceNotes = "Mad Catz FightPad on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61486
				}
			};
		}
	}
}
