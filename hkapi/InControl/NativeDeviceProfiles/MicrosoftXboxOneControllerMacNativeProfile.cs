using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000845 RID: 2117
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030B8 RID: 12472 RVA: 0x0011C9FC File Offset: 0x0011ABFC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Microsoft Xbox One Controller";
			base.DeviceNotes = "Microsoft Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 721
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 733
				}
			};
		}
	}
}
