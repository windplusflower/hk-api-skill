using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000807 RID: 2055
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriPadEXTurboControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600303C RID: 12348 RVA: 0x0011ACF4 File Offset: 0x00118EF4
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Pad EX Turbo Controller";
			base.DeviceNotes = "Hori Pad EX Turbo Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 12
				}
			};
		}
	}
}
