using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000803 RID: 2051
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingEdgeArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003034 RID: 12340 RVA: 0x0011AAC0 File Offset: 0x00118CC0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fighting Edge Arcade Stick";
			base.DeviceNotes = "Hori Fighting Edge Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21763
				}
			};
		}
	}
}
