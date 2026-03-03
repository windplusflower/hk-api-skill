using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000821 RID: 2081
	[Preserve]
	[NativeInputDeviceProfile]
	public class MKKlassikFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003070 RID: 12400 RVA: 0x0011B808 File Offset: 0x00119A08
		public override void Define()
		{
			base.Define();
			base.DeviceName = "MK Klassik Fight Stick";
			base.DeviceNotes = "MK Klassik Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4779,
					ProductID = 771
				}
			};
		}
	}
}
