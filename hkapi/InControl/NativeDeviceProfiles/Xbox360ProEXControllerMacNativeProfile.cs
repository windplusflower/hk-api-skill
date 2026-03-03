using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000875 RID: 2165
	[Preserve]
	[NativeInputDeviceProfile]
	public class Xbox360ProEXControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003118 RID: 12568 RVA: 0x0011E654 File Offset: 0x0011C854
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Xbox 360 Pro EX Controller";
			base.DeviceNotes = "Xbox 360 Pro EX Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 8406,
					ProductID = 10271
				}
			};
		}
	}
}
