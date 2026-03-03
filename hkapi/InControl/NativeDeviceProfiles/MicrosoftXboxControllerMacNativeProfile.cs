using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000844 RID: 2116
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXboxControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x0011C868 File Offset: 0x0011AA68
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Microsoft Xbox Controller";
			base.DeviceNotes = "Microsoft Xbox Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = ushort.MaxValue,
					ProductID = ushort.MaxValue
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 649
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 648
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 645
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 514
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 647
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 648
				}
			};
		}
	}
}
