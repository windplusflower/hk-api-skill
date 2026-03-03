using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000832 RID: 2098
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMLGFightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003092 RID: 12434 RVA: 0x0011BFF0 File Offset: 0x0011A1F0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz MLG Fight Stick TE";
			base.DeviceNotes = "Mad Catz MLG Fight Stick TE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61502
				}
			};
		}
	}
}
