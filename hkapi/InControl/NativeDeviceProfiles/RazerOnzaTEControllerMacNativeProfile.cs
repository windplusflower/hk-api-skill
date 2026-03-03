using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085E RID: 2142
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerOnzaTEControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x0011DB0C File Offset: 0x0011BD0C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Onza TE Controller";
			base.DeviceNotes = "Razer Onza TE Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 64768
				},
				new InputDeviceMatcher
				{
					VendorID = 5769,
					ProductID = 64768
				}
			};
		}
	}
}
