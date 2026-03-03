using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B84 RID: 2948
	[ActionCategory(ActionCategory.StateMachine)]
	[Note("Stop this FSM. If this FSM was launched by a Run FSM action, it will trigger a Finish event in that state.")]
	[Tooltip("Stop this FSM. If this FSM was launched by a Run FSM action, it will trigger a Finish event in that state.")]
	public class FinishFSM : FsmStateAction
	{
		// Token: 0x06003EA4 RID: 16036 RVA: 0x00164E62 File Offset: 0x00163062
		public override void OnEnter()
		{
			base.Fsm.Stop();
		}
	}
}
