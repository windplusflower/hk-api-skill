using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC9 RID: 3017
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on a Game Object's Tag.")]
	public class GameObjectTagSwitch : FsmStateAction
	{
		// Token: 0x06003F9F RID: 16287 RVA: 0x00167D2C File Offset: 0x00165F2C
		public override void Reset()
		{
			this.gameObject = null;
			this.compareTo = new FsmString[1];
			this.sendEvent = new FsmEvent[1];
			this.everyFrame = false;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00167D54 File Offset: 0x00165F54
		public override void OnEnter()
		{
			this.DoTagSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00167D6A File Offset: 0x00165F6A
		public override void OnUpdate()
		{
			this.DoTagSwitch();
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00167D74 File Offset: 0x00165F74
		private void DoTagSwitch()
		{
			GameObject value = this.gameObject.Value;
			if (value == null)
			{
				return;
			}
			for (int i = 0; i < this.compareTo.Length; i++)
			{
				if (value.tag == this.compareTo[i].Value)
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x040043CB RID: 17355
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject to test.")]
		public FsmGameObject gameObject;

		// Token: 0x040043CC RID: 17356
		[CompoundArray("Tag Switches", "Compare Tag", "Send Event")]
		[UIHint(UIHint.Tag)]
		public FsmString[] compareTo;

		// Token: 0x040043CD RID: 17357
		public FsmEvent[] sendEvent;

		// Token: 0x040043CE RID: 17358
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
