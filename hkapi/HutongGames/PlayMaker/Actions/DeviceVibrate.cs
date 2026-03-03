using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B71 RID: 2929
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Causes the device to vibrate for half a second.")]
	public class DeviceVibrate : FsmStateAction
	{
		// Token: 0x06003E53 RID: 15955 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}
	}
}
