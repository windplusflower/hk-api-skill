using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000860 RID: 2144
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerStrikeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030EE RID: 12526 RVA: 0x0011DC44 File Offset: 0x0011BE44
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Strike Controller";
			base.DeviceNotes = "Razer Strike Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5769,
					ProductID = 1
				}
			};
		}
	}
}
