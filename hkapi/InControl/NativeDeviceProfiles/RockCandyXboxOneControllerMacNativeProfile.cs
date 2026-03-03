using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086A RID: 2154
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06003102 RID: 12546 RVA: 0x0011E0E0 File Offset: 0x0011C2E0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Candy Xbox One Controller";
			base.DeviceNotes = "Rock Candy Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 326
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 582
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 838
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 719
				}
			};
		}
	}
}
