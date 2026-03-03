using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084B RID: 2123
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPMarvelControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030C4 RID: 12484 RVA: 0x0011CF60 File Offset: 0x0011B160
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Marvel Controller";
			base.DeviceNotes = "PDP Marvel Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 327
				}
			};
		}
	}
}
