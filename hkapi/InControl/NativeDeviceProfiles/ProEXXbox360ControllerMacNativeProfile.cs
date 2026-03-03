using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000859 RID: 2137
	[Preserve]
	[NativeInputDeviceProfile]
	public class ProEXXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030E0 RID: 12512 RVA: 0x0011D89C File Offset: 0x0011BA9C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Pro EX Xbox 360 Controller";
			base.DeviceNotes = "Pro EX Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21258
				}
			};
		}
	}
}
