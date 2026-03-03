using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084D RID: 2125
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPTitanfall2XboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030C8 RID: 12488 RVA: 0x0011D030 File Offset: 0x0011B230
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Titanfall 2 Xbox One Controller";
			base.DeviceNotes = "PDP Titanfall 2 Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 357
				}
			};
		}
	}
}
