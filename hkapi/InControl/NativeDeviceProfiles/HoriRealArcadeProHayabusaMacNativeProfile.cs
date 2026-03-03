using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080D RID: 2061
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003048 RID: 12360 RVA: 0x0011AF5C File Offset: 0x0011915C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro Hayabusa";
			base.DeviceNotes = "Hori Real Arcade Pro Hayabusa on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 99
				}
			};
		}
	}
}
