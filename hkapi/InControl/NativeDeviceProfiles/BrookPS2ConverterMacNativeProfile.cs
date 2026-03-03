using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F0 RID: 2032
	[Preserve]
	[NativeInputDeviceProfile]
	public class BrookPS2ConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600300E RID: 12302 RVA: 0x0011A0EC File Offset: 0x001182EC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Brook PS2 Converter";
			base.DeviceNotes = "Brook PS2 Converter on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3090,
					ProductID = 2289
				}
			};
		}
	}
}
