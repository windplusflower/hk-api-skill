using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083E RID: 2110
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSoulCaliberFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x0011C4D0 File Offset: 0x0011A6D0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Soul Caliber Fight Stick";
			base.DeviceNotes = "Mad Catz Soul Caliber Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61503
				}
			};
		}
	}
}
