using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000851 RID: 2129
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPXboxOneArcadeStickMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030D0 RID: 12496 RVA: 0x0011D1D0 File Offset: 0x0011B3D0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Xbox One Arcade Stick";
			base.DeviceNotes = "PDP Xbox One Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 348
				}
			};
		}
	}
}
