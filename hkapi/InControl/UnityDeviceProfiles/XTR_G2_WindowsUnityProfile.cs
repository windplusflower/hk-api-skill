using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020007E3 RID: 2019
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x00118640 File Offset: 0x00116840
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
					NameLiteral = "KMODEL Simulator - XTR+G2+FMS Controller"
				}
			};
		}
	}
}
