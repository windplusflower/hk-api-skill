using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F5 RID: 2037
	[Preserve]
	[NativeInputDeviceProfile]
	public class GameStopControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003018 RID: 12312 RVA: 0x0011A32C File Offset: 0x0011852C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "GameStop Controller";
			base.DeviceNotes = "GameStop Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 1025
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 769
				},
				new InputDeviceMatcher
				{
					VendorID = 4779,
					ProductID = 770
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63745
				}
			};
		}
	}
}
