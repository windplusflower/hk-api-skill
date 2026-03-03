using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000818 RID: 2072
	[Preserve]
	[NativeInputDeviceProfile]
	public class KonamiDancePadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x0011B430 File Offset: 0x00119630
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Konami Dance Pad";
			base.DeviceNotes = "Konami Dance Pad on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4779,
					ProductID = 4
				}
			};
		}
	}
}
