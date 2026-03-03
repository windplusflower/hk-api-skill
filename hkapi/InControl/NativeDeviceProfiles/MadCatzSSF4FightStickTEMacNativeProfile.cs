using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083C RID: 2108
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSSF4FightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030A6 RID: 12454 RVA: 0x0011C400 File Offset: 0x0011A600
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz SSF4 Fight Stick TE";
			base.DeviceNotes = "Mad Catz SSF4 Fight Stick TE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 63288
				}
			};
		}
	}
}
