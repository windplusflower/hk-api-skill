using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000828 RID: 2088
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600307E RID: 12414 RVA: 0x0011BB14 File Offset: 0x00119D14
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Controller";
			base.DeviceNotes = "Mad Catz Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18198
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63746
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61642
				},
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 672
				}
			};
		}
	}
}
