using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000866 RID: 2150
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockBandGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030FA RID: 12538 RVA: 0x0011DEE0 File Offset: 0x0011C0E0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Band Guitar";
			base.DeviceNotes = "Rock Band Guitar on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 2
				}
			};
		}
	}
}
