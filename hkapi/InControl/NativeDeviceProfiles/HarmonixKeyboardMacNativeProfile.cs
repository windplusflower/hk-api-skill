using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FA RID: 2042
	[Preserve]
	[NativeInputDeviceProfile]
	public class HarmonixKeyboardMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003022 RID: 12322 RVA: 0x0011A5CC File Offset: 0x001187CC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Harmonix Keyboard";
			base.DeviceNotes = "Harmonix Keyboard on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 4920
				}
			};
		}
	}
}
