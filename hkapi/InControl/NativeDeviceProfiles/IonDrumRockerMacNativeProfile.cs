using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000816 RID: 2070
	[Preserve]
	[NativeInputDeviceProfile]
	public class IonDrumRockerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600305A RID: 12378 RVA: 0x0011B360 File Offset: 0x00119560
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Ion Drum Rocker";
			base.DeviceNotes = "Ion Drum Rocker on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 304
				}
			};
		}
	}
}
