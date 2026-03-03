using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000869 RID: 2153
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003100 RID: 12544 RVA: 0x0011E014 File Offset: 0x0011C214
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Candy Xbox 360 Controller";
			base.DeviceNotes = "Rock Candy Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 543
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 64254
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 338
				}
			};
		}
	}
}
