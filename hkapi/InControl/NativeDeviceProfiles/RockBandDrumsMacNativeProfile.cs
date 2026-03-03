using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000865 RID: 2149
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockBandDrumsMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x0011DE7C File Offset: 0x0011C07C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Band Drums";
			base.DeviceNotes = "Rock Band Drums on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 3
				}
			};
		}
	}
}
