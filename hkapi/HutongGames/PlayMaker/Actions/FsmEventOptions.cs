using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B98 RID: 2968
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sets how subsequent events sent in this state are handled.")]
	public class FsmEventOptions : FsmStateAction
	{
		// Token: 0x06003EFA RID: 16122 RVA: 0x00165A92 File Offset: 0x00163C92
		public override void Reset()
		{
			this.sendToFsmComponent = null;
			this.sendToGameObject = null;
			this.fsmName = "";
			this.sendToChildren = false;
			this.broadcastToAll = false;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnUpdate()
		{
		}

		// Token: 0x0400430A RID: 17162
		public PlayMakerFSM sendToFsmComponent;

		// Token: 0x0400430B RID: 17163
		public FsmGameObject sendToGameObject;

		// Token: 0x0400430C RID: 17164
		public FsmString fsmName;

		// Token: 0x0400430D RID: 17165
		public FsmBool sendToChildren;

		// Token: 0x0400430E RID: 17166
		public FsmBool broadcastToAll;
	}
}
