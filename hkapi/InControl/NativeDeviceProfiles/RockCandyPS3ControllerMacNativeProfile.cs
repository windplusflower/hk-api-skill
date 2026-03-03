using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000868 RID: 2152
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyPS3ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030FE RID: 12542 RVA: 0x0011DFAC File Offset: 0x0011C1AC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Rock Candy PS3 Controller";
			base.DeviceNotes = "Rock Candy PS3 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 286
				}
			};
		}
	}
}
