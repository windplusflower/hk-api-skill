using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000827 RID: 2087
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzCODControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600307C RID: 12412 RVA: 0x0011BAAC File Offset: 0x00119CAC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz COD Controller";
			base.DeviceNotes = "Mad Catz COD Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61477
				}
			};
		}
	}
}
