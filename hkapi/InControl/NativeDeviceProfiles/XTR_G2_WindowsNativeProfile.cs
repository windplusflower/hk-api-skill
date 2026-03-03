using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020008AB RID: 2219
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR_G2_WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06003184 RID: 12676 RVA: 0x0012B930 File Offset: 0x00129B30
		public override void Define()
		{
			base.Define();
			base.DeviceName = "KMODEL Simulator XTR G2 FMS Controller";
			base.DeviceNotes = "KMODEL Simulator XTR G2 FMS Controller on Windows";
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
					NameLiteral = "KMODEL Simulator - XTR+G2+FMS Controller"
				}
			};
		}
	}
}
