using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085C RID: 2140
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerAtroxArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030E6 RID: 12518 RVA: 0x0011D9D4 File Offset: 0x0011BBD4
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Atrox Arcade Stick";
			base.DeviceNotes = "Razer Atrox Arcade Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5426,
					ProductID = 2560
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 20480
				}
			};
		}
	}
}
