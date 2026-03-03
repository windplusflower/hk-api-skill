using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020007A1 RID: 1953
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002F70 RID: 12144 RVA: 0x00109634 File Offset: 0x00107834
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
					NameLiteral = "FeiYing Model KMODEL Simulator - XTR+G2+FMS Controller"
				}
			};
		}
	}
}
