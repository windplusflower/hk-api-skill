using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B0D RID: 2829
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when the user hits any Key or Mouse Button.")]
	public class AnyKey : FsmStateAction
	{
		// Token: 0x06003CBE RID: 15550 RVA: 0x0015ECB7 File Offset: 0x0015CEB7
		public override void Reset()
		{
			this.sendEvent = null;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x0015ECC0 File Offset: 0x0015CEC0
		public override void OnUpdate()
		{
			if (Input.anyKeyDown)
			{
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x040040CC RID: 16588
		[RequiredField]
		[Tooltip("Event to send when any Key or Mouse Button is pressed.")]
		public FsmEvent sendEvent;
	}
}
