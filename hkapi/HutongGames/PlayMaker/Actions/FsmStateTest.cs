using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9A RID: 2970
	[ActionCategory(ActionCategory.Logic)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Tests if an FSM is in the specified State.")]
	public class FsmStateTest : FsmStateAction
	{
		// Token: 0x06003F02 RID: 16130 RVA: 0x00165BBE File Offset: 0x00163DBE
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = null;
			this.stateName = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x00165BF1 File Offset: 0x00163DF1
		public override void OnEnter()
		{
			this.DoFsmStateTest();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x00165C07 File Offset: 0x00163E07
		public override void OnUpdate()
		{
			this.DoFsmStateTest();
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x00165C10 File Offset: 0x00163E10
		private void DoFsmStateTest()
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
			bool value2 = false;
			if (this.fsm.ActiveStateName == this.stateName.Value)
			{
				base.Fsm.Event(this.trueEvent);
				value2 = true;
			}
			else
			{
				base.Fsm.Event(this.falseEvent);
			}
			this.storeResult.Value = value2;
		}

		// Token: 0x04004316 RID: 17174
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmGameObject gameObject;

		// Token: 0x04004317 RID: 17175
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of Fsm on Game Object. Useful if there is more than one FSM on the GameObject.")]
		public FsmString fsmName;

		// Token: 0x04004318 RID: 17176
		[RequiredField]
		[Tooltip("Check to see if the FSM is in this state.")]
		public FsmString stateName;

		// Token: 0x04004319 RID: 17177
		[Tooltip("Event to send if the FSM is in the specified state.")]
		public FsmEvent trueEvent;

		// Token: 0x0400431A RID: 17178
		[Tooltip("Event to send if the FSM is NOT in the specified state.")]
		public FsmEvent falseEvent;

		// Token: 0x0400431B RID: 17179
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of this test in a bool variable. Useful if other actions depend on this test.")]
		public FsmBool storeResult;

		// Token: 0x0400431C RID: 17180
		[Tooltip("Repeat every frame. Useful if you're waiting for a particular state.")]
		public bool everyFrame;

		// Token: 0x0400431D RID: 17181
		private GameObject previousGo;

		// Token: 0x0400431E RID: 17182
		private PlayMakerFSM fsm;
	}
}
