using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CFE RID: 3326
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends events based on Touch Phases. Optionally filter by a fingerID.")]
	public class TouchEvent : FsmStateAction
	{
		// Token: 0x0600450D RID: 17677 RVA: 0x0017806E File Offset: 0x0017626E
		public override void Reset()
		{
			this.fingerId = new FsmInt
			{
				UseVariable = true
			};
			this.storeFingerId = null;
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x0017808C File Offset: 0x0017628C
		public override void OnUpdate()
		{
			if (Input.touchCount > 0)
			{
				foreach (Touch touch in Input.touches)
				{
					if ((this.fingerId.IsNone || touch.fingerId == this.fingerId.Value) && touch.phase == this.touchPhase)
					{
						this.storeFingerId.Value = touch.fingerId;
						base.Fsm.Event(this.sendEvent);
					}
				}
			}
		}

		// Token: 0x0400496A RID: 18794
		public FsmInt fingerId;

		// Token: 0x0400496B RID: 18795
		public TouchPhase touchPhase;

		// Token: 0x0400496C RID: 18796
		public FsmEvent sendEvent;

		// Token: 0x0400496D RID: 18797
		[UIHint(UIHint.Variable)]
		public FsmInt storeFingerId;
	}
}
