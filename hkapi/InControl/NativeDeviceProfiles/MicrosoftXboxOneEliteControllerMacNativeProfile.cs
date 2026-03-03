using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000846 RID: 2118
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXboxOneEliteControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030BA RID: 12474 RVA: 0x0011CA98 File Offset: 0x0011AC98
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Microsoft Xbox One Elite Controller";
			base.DeviceNotes = "Microsoft Xbox One Elite Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 739
				}
			};
		}
	}
}
