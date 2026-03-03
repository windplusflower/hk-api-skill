using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200081A RID: 2074
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003062 RID: 12386 RVA: 0x0011B4FC File Offset: 0x001196FC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech Controller";
			base.DeviceNotes = "Logitech Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 62209
				}
			};
		}
	}
}
