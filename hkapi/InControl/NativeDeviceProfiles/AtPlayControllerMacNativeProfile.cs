using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007EB RID: 2027
	[Preserve]
	[NativeInputDeviceProfile]
	public class AtPlayControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003004 RID: 12292 RVA: 0x00119E80 File Offset: 0x00118080
		public override void Define()
		{
			base.Define();
			base.DeviceName = "At Play Controller";
			base.DeviceNotes = "At Play Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 64250
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 64251
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 690
				}
			};
		}
	}
}
