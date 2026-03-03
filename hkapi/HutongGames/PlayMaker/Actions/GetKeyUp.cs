using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF4 RID: 3060
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when a Key is released.")]
	public class GetKeyUp : FsmStateAction
	{
		// Token: 0x0600405A RID: 16474 RVA: 0x0016A0C5 File Offset: 0x001682C5
		public override void Reset()
		{
			this.sendEvent = null;
			this.key = KeyCode.None;
			this.storeResult = null;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0016A0DC File Offset: 0x001682DC
		public override void OnUpdate()
		{
			bool keyUp = Input.GetKeyUp(this.key);
			if (keyUp)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = keyUp;
		}

		// Token: 0x040044BD RID: 17597
		[RequiredField]
		public KeyCode key;

		// Token: 0x040044BE RID: 17598
		public FsmEvent sendEvent;

		// Token: 0x040044BF RID: 17599
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
	}
}
