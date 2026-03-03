using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000810 RID: 2064
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProVKaiFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600304E RID: 12366 RVA: 0x0011B090 File Offset: 0x00119290
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro V Kai Fighting Stick";
			base.DeviceNotes = "Hori Real Arcade Pro V Kai Fighting Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21774
				},
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 120
				}
			};
		}
	}
}
