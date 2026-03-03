using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000822 RID: 2082
	[Preserve]
	[NativeInputDeviceProfile]
	public class MLGControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0011B870 File Offset: 0x00119A70
		public override void Define()
		{
			base.Define();
			base.DeviceName = "MLG Controller";
			base.DeviceNotes = "MLG Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61475
				}
			};
		}
	}
}
