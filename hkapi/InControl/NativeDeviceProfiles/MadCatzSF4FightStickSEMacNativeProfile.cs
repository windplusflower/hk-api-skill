using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000839 RID: 2105
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSF4FightStickSEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030A0 RID: 12448 RVA: 0x0011C2C8 File Offset: 0x0011A4C8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz SF4 Fight Stick SE";
			base.DeviceNotes = "Mad Catz SF4 Fight Stick SE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18200
				}
			};
		}
	}
}
