using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082E RID: 2094
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzGhostReconFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600308A RID: 12426 RVA: 0x0011BE50 File Offset: 0x0011A050
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Ghost Recon Fighting Stick";
			base.DeviceNotes = "Mad Catz Ghost Recon Fighting Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61473
				}
			};
		}
	}
}
