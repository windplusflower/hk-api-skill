using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084A RID: 2122
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPBattlefieldXBoxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030C2 RID: 12482 RVA: 0x0011CEF8 File Offset: 0x0011B0F8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Battlefield XBox One Controller";
			base.DeviceNotes = "PDP Battlefield XBox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 356
				}
			};
		}
	}
}
