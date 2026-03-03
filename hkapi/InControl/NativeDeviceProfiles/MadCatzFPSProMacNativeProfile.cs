using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000829 RID: 2089
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFPSProMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003080 RID: 12416 RVA: 0x0011BC14 File Offset: 0x00119E14
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz FPS Pro";
			base.DeviceNotes = "Mad Catz FPS Pro on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61479
				}
			};
		}
	}
}
