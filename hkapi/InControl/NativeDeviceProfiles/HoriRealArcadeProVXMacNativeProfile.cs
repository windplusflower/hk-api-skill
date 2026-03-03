using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000811 RID: 2065
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProVXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003050 RID: 12368 RVA: 0x0011B128 File Offset: 0x00119328
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro VX";
			base.DeviceNotes = "Hori Real Arcade Pro VX on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 27
				}
			};
		}
	}
}
