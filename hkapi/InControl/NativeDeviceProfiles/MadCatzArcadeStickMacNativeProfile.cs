using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000824 RID: 2084
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003076 RID: 12406 RVA: 0x0011B974 File Offset: 0x00119B74
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Arcade Stick";
			base.DeviceNotes = "Mad Catz Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18264
				}
			};
		}
	}
}
