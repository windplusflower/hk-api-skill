using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080F RID: 2063
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProVHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600304C RID: 12364 RVA: 0x0011B028 File Offset: 0x00119228
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro V Hayabusa";
			base.DeviceNotes = "Hori Real Arcade Pro V Hayabusa on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 216
				}
			};
		}
	}
}
