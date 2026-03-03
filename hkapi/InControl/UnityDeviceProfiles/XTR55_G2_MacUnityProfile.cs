using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020007A0 RID: 1952
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR55_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002F6E RID: 12142 RVA: 0x001095C8 File Offset: 0x001077C8
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
					NameLiteral = "              SAILI Simulator --- XTR5.5+G2+FMS Controller"
				}
			};
		}
	}
}
