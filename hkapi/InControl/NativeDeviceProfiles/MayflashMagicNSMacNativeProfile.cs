using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000840 RID: 2112
	[Preserve]
	[NativeInputDeviceProfile]
	public class MayflashMagicNSMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030AE RID: 12462 RVA: 0x0011C5A0 File Offset: 0x0011A7A0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mayflash Magic-NS";
			base.DeviceNotes = "Mayflash Magic-NS on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 121,
					ProductID = 6355
				}
			};
		}
	}
}
