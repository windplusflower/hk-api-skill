using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000838 RID: 2104
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSF4FightStickRound2TEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600309E RID: 12446 RVA: 0x0011C260 File Offset: 0x0011A460
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz SF4 Fight Stick Round 2 TE";
			base.DeviceNotes = "Mad Catz SF4 Fight Stick Round 2 TE on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61496
				}
			};
		}
	}
}
