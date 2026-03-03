using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B99 RID: 2969
	[ActionCategory(ActionCategory.Logic)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Sends Events based on the current State of an FSM.")]
	public class FsmStateSwitch : FsmStateAction
	{
		// Token: 0x06003EFD RID: 16125 RVA: 0x00165ACA File Offset: 0x00163CCA
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = null;
			this.compareTo = new FsmString[1];
			this.sendEvent = new FsmEvent[1];
			this.everyFrame = false;
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00165AF9 File Offset: 0x00163CF9
		public override void OnEnter()
		{
			this.DoFsmStateSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00165B0F File Offset: 0x00163D0F
		public override void OnUpdate()
		{
			this.DoFsmStateSwitch();
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00165B18 File Offset: 0x00163D18
		private void DoFsmStateSwitch()
		{
			GameObject value = this.gameObject.Value;
			if (value == null)
			{
				return;
			}
			if (value != this.previousGo)
			{
				this.fsm = ActionHelpers.GetGameObjectFsm(value, this.fsmName.Value);
				this.previousGo = value;
			}
			if (this.fsm == null)
			{
				return;
			}
			string activeStateName = this.fsm.ActiveStateName;
			for (int i = 0; i < this.compareTo.Length; i++)
			{
				if (activeStateName == this.compareTo[i].Value)
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x0400430F RID: 17167
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmGameObject gameObject;

		// Token: 0x04004310 RID: 17168
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of Fsm on GameObject. Useful if there is more than one FSM on the GameObject.")]
		public FsmString fsmName;

		// Token: 0x04004311 RID: 17169
		[CompoundArray("State Switches", "Compare State", "Send Event")]
		public FsmString[] compareTo;

		// Token: 0x04004312 RID: 17170
		public FsmEvent[] sendEvent;

		// Token: 0x04004313 RID: 17171
		[Tooltip("Repeat every frame. Useful if you're waiting for a particular result.")]
		public bool everyFrame;

		// Token: 0x04004314 RID: 17172
		private GameObject previousGo;

		// Token: 0x04004315 RID: 17173
		private PlayMakerFSM fsm;
	}
}
