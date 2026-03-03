using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FC RID: 2044
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriBlueSoloControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003026 RID: 12326 RVA: 0x0011A69C File Offset: 0x0011889C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Blue Solo Controller ";
			base.DeviceNotes = "Hori Blue Solo Controller\ton Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 64001
				}
			};
		}
	}
}
