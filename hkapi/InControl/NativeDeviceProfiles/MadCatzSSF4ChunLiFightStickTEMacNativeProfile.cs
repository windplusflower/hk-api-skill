using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083B RID: 2107
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSSF4ChunLiFightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030A4 RID: 12452 RVA: 0x0011C398 File Offset: 0x0011A598
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz SSF4 Chun-Li Fight Stick TE";
			base.DeviceNotes = "Mad Catz SSF4 Chun-Li Fight Stick TE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61501
				}
			};
		}
	}
}
