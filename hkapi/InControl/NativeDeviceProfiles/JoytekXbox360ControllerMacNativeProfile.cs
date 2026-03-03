using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000817 RID: 2071
	[Preserve]
	[NativeInputDeviceProfile]
	public class JoytekXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600305C RID: 12380 RVA: 0x0011B3C8 File Offset: 0x001195C8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Joytek Xbox 360 Controller";
			base.DeviceNotes = "Joytek Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5678,
					ProductID = 48879
				}
			};
		}
	}
}
