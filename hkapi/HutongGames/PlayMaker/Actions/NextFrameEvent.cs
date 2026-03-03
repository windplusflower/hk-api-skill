using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C43 RID: 3139
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event in the next frame. Useful if you want to loop states every frame.")]
	public class NextFrameEvent : FsmStateAction
	{
		// Token: 0x060041B7 RID: 16823 RVA: 0x0016DC25 File Offset: 0x0016BE25
		public override void Reset()
		{
			this.sendEvent = null;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnEnter()
		{
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x0016DC2E File Offset: 0x0016BE2E
		public override void OnUpdate()
		{
			base.Finish();
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x0400461D RID: 17949
		[RequiredField]
		public FsmEvent sendEvent;
	}
}
