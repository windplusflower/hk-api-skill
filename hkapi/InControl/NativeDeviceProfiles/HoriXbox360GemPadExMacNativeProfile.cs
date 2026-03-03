using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000813 RID: 2067
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriXbox360GemPadExMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0011B228 File Offset: 0x00119428
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Xbox 360 Gem Pad Ex";
			base.DeviceNotes = "Hori Xbox 360 Gem Pad Ex on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21773
				}
			};
		}
	}
}
