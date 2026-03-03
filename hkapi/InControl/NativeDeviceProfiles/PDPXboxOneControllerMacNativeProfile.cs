using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000852 RID: 2130
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030D2 RID: 12498 RVA: 0x0011D238 File Offset: 0x0011B438
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Xbox One Controller";
			base.DeviceNotes = "PDP Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 676
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 715
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 314
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 354
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 22042
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 353
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 355
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 683
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 352
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 680
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 674
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 347
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 677
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 685
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 704
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 679
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 678
				}
			};
		}
	}
}
