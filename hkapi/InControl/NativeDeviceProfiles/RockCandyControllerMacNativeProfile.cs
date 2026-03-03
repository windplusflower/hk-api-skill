using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000867 RID: 2151
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030FC RID: 12540 RVA: 0x0011DF44 File Offset: 0x0011C144
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Candy Controller";
			base.DeviceNotes = "Rock Candy Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 287
				}
			};
		}
	}
}
