using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083A RID: 2106
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSF4FightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030A2 RID: 12450 RVA: 0x0011C330 File Offset: 0x0011A530
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz SF4 Fight Stick TE";
			base.DeviceNotes = "Mad Catz SF4 Fight Stick TE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18232
				}
			};
		}
	}
}
