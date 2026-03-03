using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020007E2 RID: 2018
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR55_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002FF2 RID: 12274 RVA: 0x001185D4 File Offset: 0x001167D4
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
					NameLiteral = "SAILI Simulator --- XTR5.5+G2+FMS Controller"
				}
			};
		}
	}
}
