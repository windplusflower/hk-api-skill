using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000837 RID: 2103
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzProControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600309C RID: 12444 RVA: 0x0011C1F8 File Offset: 0x0011A3F8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Pro Controller";
			base.DeviceNotes = "Mad Catz Pro Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18214
				}
			};
		}
	}
}
