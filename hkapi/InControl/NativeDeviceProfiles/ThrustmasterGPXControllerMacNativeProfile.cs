using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000870 RID: 2160
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterGPXControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600310E RID: 12558 RVA: 0x0011E41C File Offset: 0x0011C61C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Thrustmaster GPX Controller";
			base.DeviceNotes = "Thrustmaster GPX Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1103,
					ProductID = 45862
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 23298
				}
			};
		}
	}
}
