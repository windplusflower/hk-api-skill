using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000850 RID: 2128
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x0011D168 File Offset: 0x0011B368
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Xbox 360 Controller";
			base.DeviceNotes = "PDP Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 1281
				}
			};
		}
	}
}
