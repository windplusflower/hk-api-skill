using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007ED RID: 2029
	[Preserve]
	[NativeInputDeviceProfile]
	public class BatarangControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003008 RID: 12296 RVA: 0x00119FB4 File Offset: 0x001181B4
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Batarang Controller";
			base.DeviceNotes = "Batarang Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5604,
					ProductID = 16144
				}
			};
		}
	}
}
