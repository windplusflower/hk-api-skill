using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF3 RID: 3059
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when a Key is pressed.")]
	public class GetKeyDown : FsmStateAction
	{
		// Token: 0x06004057 RID: 16471 RVA: 0x0016A073 File Offset: 0x00168273
		public override void Reset()
		{
			this.sendEvent = null;
			this.key = KeyCode.None;
			this.storeResult = null;
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0016A08C File Offset: 0x0016828C
		public override void OnUpdate()
		{
			bool keyDown = Input.GetKeyDown(this.key);
			if (keyDown)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = keyDown;
		}

		// Token: 0x040044BA RID: 17594
		[RequiredField]
		public KeyCode key;

		// Token: 0x040044BB RID: 17595
		public FsmEvent sendEvent;

		// Token: 0x040044BC RID: 17596
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
	}
}
