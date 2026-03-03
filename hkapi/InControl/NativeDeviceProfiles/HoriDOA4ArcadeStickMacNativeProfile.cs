using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FE RID: 2046
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriDOA4ArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600302A RID: 12330 RVA: 0x0011A830 File Offset: 0x00118A30
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori DOA4 Arcade Stick";
			base.DeviceNotes = "Hori DOA4 Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 10
				}
			};
		}
	}
}
