using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000856 RID: 2134
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerAMiniProExControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030DA RID: 12506 RVA: 0x0011D700 File Offset: 0x0011B900
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PowerA Mini Pro Ex Controller";
			base.DeviceNotes = "PowerA Mini Pro Ex Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5604,
					ProductID = 16128
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21274
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21248
				}
			};
		}
	}
}
