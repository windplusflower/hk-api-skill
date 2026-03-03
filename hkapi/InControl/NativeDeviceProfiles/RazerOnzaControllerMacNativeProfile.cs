using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085D RID: 2141
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerOnzaControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030E8 RID: 12520 RVA: 0x0011DA70 File Offset: 0x0011BC70
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Onza Controller";
			base.DeviceNotes = "Razer Onza Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 64769
				},
				new InputDeviceMatcher
				{
					VendorID = 5769,
					ProductID = 64769
				}
			};
		}
	}
}
