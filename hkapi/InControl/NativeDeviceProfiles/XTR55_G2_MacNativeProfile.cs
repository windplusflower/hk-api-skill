using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200088A RID: 2186
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR55_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06003142 RID: 12610 RVA: 0x00123200 File Offset: 0x00121400
		public override void Define()
		{
			base.Define();
			base.DeviceName = "SAILI Simulator XTR5.5 G2 FMS Controller";
			base.DeviceNotes = "SAILI Simulator XTR5.5 G2 FMS Controller on OS X";
			base.DeviceClass = InputDeviceClass.Controller;
			base.IncludePlatforms = new string[]
			{
				"OS X"
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
