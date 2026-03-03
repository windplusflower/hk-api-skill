using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000808 RID: 2056
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriPadUltimateMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600303E RID: 12350 RVA: 0x0011AD58 File Offset: 0x00118F58
		public override void Define()
		{
			base.Define();
			base.DeviceName = "HoriPad Ultimate";
			base.DeviceNotes = "HoriPad Ultimate on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 144
				}
			};
		}
	}
}
