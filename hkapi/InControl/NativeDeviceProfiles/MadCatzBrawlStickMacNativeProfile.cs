using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000826 RID: 2086
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzBrawlStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600307A RID: 12410 RVA: 0x0011BA44 File Offset: 0x00119C44
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Brawl Stick";
			base.DeviceNotes = "Mad Catz Brawl Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61465
				}
			};
		}
	}
}
