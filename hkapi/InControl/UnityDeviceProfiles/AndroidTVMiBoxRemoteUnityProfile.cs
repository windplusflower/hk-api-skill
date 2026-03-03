using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000749 RID: 1865
	[Preserve]
	[UnityInputDeviceProfile]
	public class AndroidTVMiBoxRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002EC0 RID: 11968 RVA: 0x000FA04C File Offset: 0x000F824C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Xiaomi Remote";
			base.DeviceNotes = "Xiaomi Remote on Android TV";
			base.DeviceClass = InputDeviceClass.Remote;
			base.IncludePlatforms = new string[]
			{
				"Android"
			};
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					NameLiteral = "Xiaomi Remote"
				}
			};
			base.ButtonMappings = new InputControlMapping[]
			{
				new InputControlMapping
				{
					Name = "A",
					Target = InputControlType.Action1,
					Source = InputDeviceProfile.Button(0)
				},
				new InputControlMapping
				{
					Name = "Back",
					Target = InputControlType.Back,
					Source = InputDeviceProfile.EscapeKey
				}
			};
			base.AnalogMappings = new InputControlMapping[]
			{
				InputDeviceProfile.DPadLeftMapping(4),
				InputDeviceProfile.DPadRightMapping(4),
				InputDeviceProfile.DPadUpMapping(5),
				InputDeviceProfile.DPadDownMapping(5)
			};
		}
	}
}
