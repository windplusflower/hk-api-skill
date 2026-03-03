using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000849 RID: 2121
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPAfterglowPrismaticControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x0011CE2C File Offset: 0x0011B02C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Afterglow Prismatic Controller";
			base.DeviceNotes = "PDP Afterglow Prismatic Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 313
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 691
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 696
				}
			};
		}
	}
}
