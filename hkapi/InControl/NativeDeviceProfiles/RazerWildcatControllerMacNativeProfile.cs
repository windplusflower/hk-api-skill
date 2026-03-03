using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000861 RID: 2145
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerWildcatControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x0011DCA8 File Offset: 0x0011BEA8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Wildcat Controller";
			base.DeviceNotes = "Razer Wildcat Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5426,
					ProductID = 2563
				}
			};
		}
	}
}
