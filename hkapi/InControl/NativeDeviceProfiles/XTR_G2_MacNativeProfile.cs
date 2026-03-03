using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200088B RID: 2187
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06003144 RID: 12612 RVA: 0x00123290 File Offset: 0x00121490
		public override void Define()
		{
			base.Define();
			base.DeviceName = "KMODEL Simulator XTR G2 FMS Controller";
			base.DeviceNotes = "KMODEL Simulator XTR G2 FMS Controller on OS X";
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
					NameLiteral = "KMODEL Simulator - XTR+G2+FMS Controller"
				}
			};
		}
	}
}
