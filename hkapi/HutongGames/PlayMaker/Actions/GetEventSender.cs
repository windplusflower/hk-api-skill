using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D3 RID: 2515
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets info on the last event that caused a state change. See also Set Event Data action.")]
	public class GetEventSender : FsmStateAction
	{
		// Token: 0x060036FF RID: 14079 RVA: 0x001440F5 File Offset: 0x001422F5
		public override void Reset()
		{
			this.sentByGameObject = null;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x001440FE File Offset: 0x001422FE
		public override void OnEnter()
		{
			if (Fsm.EventData.SentByFsm != null)
			{
				this.sentByGameObject.Value = Fsm.EventData.SentByFsm.GameObject;
			}
			else
			{
				this.sentByGameObject.Value = null;
			}
			base.Finish();
		}

		// Token: 0x04003918 RID: 14616
		[UIHint(UIHint.Variable)]
		public FsmGameObject sentByGameObject;
	}
}
