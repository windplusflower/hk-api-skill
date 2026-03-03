using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200080E RID: 2062
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProIVMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600304A RID: 12362 RVA: 0x0011AFC0 File Offset: 0x001191C0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Real Arcade Pro IV";
			base.DeviceNotes = "Hori Real Arcade Pro IV on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 140
				}
			};
		}
	}
}
