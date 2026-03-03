using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7C RID: 2940
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Enables/Disables the PlayMakerGUI component in the scene. Note, you need a PlayMakerGUI component in the scene to see OnGUI actions. However, OnGUI can be very expensive on mobile devices. This action lets you turn OnGUI on/off (e.g., turn it on for a menu, and off during gameplay).")]
	public class EnableGUI : FsmStateAction
	{
		// Token: 0x06003E7C RID: 15996 RVA: 0x00164639 File Offset: 0x00162839
		public override void Reset()
		{
			this.enableGUI = true;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00164647 File Offset: 0x00162847
		public override void OnEnter()
		{
			PlayMakerGUI.Instance.enabled = this.enableGUI.Value;
			base.Finish();
		}

		// Token: 0x0400428C RID: 17036
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enableGUI;
	}
}
