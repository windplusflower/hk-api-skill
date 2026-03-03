using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F8 RID: 2040
	[Preserve]
	[NativeInputDeviceProfile]
	public class HarmonixDrumKitMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600301E RID: 12318 RVA: 0x0011A4FC File Offset: 0x001186FC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Harmonix Drum Kit";
			base.DeviceNotes = "Harmonix Drum Kit on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 4408
				}
			};
		}
	}
}
