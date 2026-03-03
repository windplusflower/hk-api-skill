using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085B RID: 2139
	[Preserve]
	[NativeInputDeviceProfile]
	public class QanbaFightStickPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030E4 RID: 12516 RVA: 0x0011D96C File Offset: 0x0011BB6C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Qanba Fight Stick Plus";
			base.DeviceNotes = "Qanba Fight Stick Plus on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 48879
				}
			};
		}
	}
}
