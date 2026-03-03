using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000771 RID: 1905
	[Preserve]
	[UnityInputDeviceProfile]
	public class NexusPlayerRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x00100A74 File Offset: 0x000FEC74
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Nexus Player Remote";
			base.DeviceNotes = "Nexus Player Remote";
			base.DeviceClass = InputDeviceClass.Remote;
			base.IncludePlatforms = new string[]
			{
				"Android"
			};
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					NameLiteral = "Google Nexus Remote"
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
