using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C8A RID: 3210
	[Obsolete("This action is obsolete; use Send Event with Event Target instead.")]
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event to another Fsm after an optional delay. Specify an Fsm Name or use the first Fsm on the object.")]
	public class SendEventToFsm : FsmStateAction
	{
		// Token: 0x06004311 RID: 17169 RVA: 0x00171EE4 File Offset: 0x001700E4
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = null;
			this.sendEvent = null;
			this.delay = null;
			this.requireReceiver = false;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00171F0C File Offset: 0x0017010C
		public override void OnEnter()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				base.Finish();
				return;
			}
			PlayMakerFSM gameObjectFsm = ActionHelpers.GetGameObjectFsm(this.go, this.fsmName.Value);
			if (gameObjectFsm == null)
			{
				if (this.requireReceiver)
				{
					base.LogError("GameObject doesn't have FsmComponent: " + this.go.name + " " + this.fsmName.Value);
				}
				return;
			}
			if ((double)this.delay.Value < 0.001)
			{
				gameObjectFsm.Fsm.Event(this.sendEvent.Value);
				base.Finish();
				return;
			}
			this.delayedEvent = gameObjectFsm.Fsm.DelayedEvent(FsmEvent.GetFsmEvent(this.sendEvent.Value), this.delay.Value);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00171FF9 File Offset: 0x001701F9
		public override void OnUpdate()
		{
			if (DelayedEvent.WasSent(this.delayedEvent))
			{
				base.Finish();
			}
		}

		// Token: 0x04004762 RID: 18274
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004763 RID: 18275
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of Fsm on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004764 RID: 18276
		[RequiredField]
		[UIHint(UIHint.FsmEvent)]
		public FsmString sendEvent;

		// Token: 0x04004765 RID: 18277
		[HasFloatSlider(0f, 10f)]
		public FsmFloat delay;

		// Token: 0x04004766 RID: 18278
		private bool requireReceiver;

		// Token: 0x04004767 RID: 18279
		private GameObject go;

		// Token: 0x04004768 RID: 18280
		private DelayedEvent delayedEvent;
	}
}
