using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F9 RID: 2041
	[Preserve]
	[NativeInputDeviceProfile]
	public class HarmonixGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003020 RID: 12320 RVA: 0x0011A564 File Offset: 0x00118764
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Harmonix Guitar";
			base.DeviceNotes = "Harmonix Guitar on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 5432
				}
			};
		}
	}
}
