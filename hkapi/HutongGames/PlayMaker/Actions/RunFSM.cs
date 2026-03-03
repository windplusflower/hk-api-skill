using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7B RID: 3195
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Creates an FSM from a saved FSM Template.")]
	public class RunFSM : RunFSMAction
	{
		// Token: 0x060042BD RID: 17085 RVA: 0x00170EF4 File Offset: 0x0016F0F4
		public override void Reset()
		{
			this.fsmTemplateControl = new FsmTemplateControl();
			this.storeID = null;
			this.runFsm = null;
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00170F0F File Offset: 0x0016F10F
		public override void Awake()
		{
			if (this.fsmTemplateControl.fsmTemplate != null && Application.isPlaying)
			{
				this.runFsm = base.Fsm.CreateSubFsm(this.fsmTemplateControl);
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00170F44 File Offset: 0x0016F144
		public override void OnEnter()
		{
			if (this.runFsm == null)
			{
				base.Finish();
				return;
			}
			this.fsmTemplateControl.UpdateValues();
			this.fsmTemplateControl.ApplyOverrides(this.runFsm);
			this.runFsm.OnEnable();
			if (!this.runFsm.Started)
			{
				this.runFsm.Start();
			}
			this.storeID.Value = this.fsmTemplateControl.ID;
			this.CheckIfFinished();
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00170FBB File Offset: 0x0016F1BB
		protected override void CheckIfFinished()
		{
			if (this.runFsm == null || this.runFsm.Finished)
			{
				base.Finish();
				base.Fsm.Event(this.finishEvent);
			}
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00170FE9 File Offset: 0x0016F1E9
		public RunFSM()
		{
			this.fsmTemplateControl = new FsmTemplateControl();
			base..ctor();
		}

		// Token: 0x04004718 RID: 18200
		public FsmTemplateControl fsmTemplateControl;

		// Token: 0x04004719 RID: 18201
		[UIHint(UIHint.Variable)]
		public FsmInt storeID;

		// Token: 0x0400471A RID: 18202
		[Tooltip("Event to send when the FSM has finished (usually because it ran a Finish FSM action).")]
		public FsmEvent finishEvent;
	}
}
