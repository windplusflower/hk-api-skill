using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082A RID: 2090
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightPadControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003082 RID: 12418 RVA: 0x0011BC7C File Offset: 0x00119E7C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz FightPad Controller";
			base.DeviceNotes = "Mad Catz FightPad Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61480
				},
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18216
				}
			};
		}
	}
}
