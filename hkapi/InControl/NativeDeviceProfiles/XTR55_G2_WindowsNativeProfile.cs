using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020008AA RID: 2218
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR55_G2_WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06003182 RID: 12674 RVA: 0x0012B8A0 File Offset: 0x00129AA0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "SAILI Simulator XTR5.5 G2 FMS Controller";
			base.DeviceNotes = "SAILI Simulator XTR5.5 G2 FMS Controller on Windows";
			base.DeviceClass = InputDeviceClass.Controller;
			base.IncludePlatforms = new string[]
			{
				"Windows"
			};
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 2971,
					ProductID = 16402,
					NameLiteral = "SAILI Simulator --- XTR5.5+G2+FMS Controller"
				}
			};
		}
	}
}
