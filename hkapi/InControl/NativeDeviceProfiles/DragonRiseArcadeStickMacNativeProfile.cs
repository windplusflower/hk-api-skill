using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F1 RID: 2033
	[Preserve]
	[NativeInputDeviceProfile]
	public class DragonRiseArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003010 RID: 12304 RVA: 0x0011A154 File Offset: 0x00118354
		public override void Define()
		{
			base.Define();
			base.DeviceName = "DragonRise Arcade Stick";
			base.DeviceNotes = "DragonRise Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 121,
					ProductID = 6268
				}
			};
		}
	}
}
