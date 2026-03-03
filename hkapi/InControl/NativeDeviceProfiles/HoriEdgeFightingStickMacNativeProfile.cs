using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000800 RID: 2048
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriEdgeFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600302E RID: 12334 RVA: 0x0011A95C File Offset: 0x00118B5C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Edge Fighting Stick";
			base.DeviceNotes = "Hori Edge Fighting Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 109
				}
			};
		}
	}
}
