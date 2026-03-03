using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B3D RID: 2877
	[Obsolete("This action is obsolete; use Send Event with Event Target instead.")]
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event to all FSMs in the scene or to all FSMs on a Game Object.\nNOTE: This action won't work on the very first frame of the game...")]
	public class BroadcastEvent : FsmStateAction
	{
		// Token: 0x06003D73 RID: 15731 RVA: 0x00160EF9 File Offset: 0x0015F0F9
		public override void Reset()
		{
			this.broadcastEvent = null;
			this.gameObject = null;
			this.sendToChildren = false;
			this.excludeSelf = false;
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00160F24 File Offset: 0x0015F124
		public override void OnEnter()
		{
			if (!string.IsNullOrEmpty(this.broadcastEvent.Value))
			{
				if (this.gameObject.Value != null)
				{
					base.Fsm.BroadcastEventToGameObject(this.gameObject.Value, this.broadcastEvent.Value, this.sendToChildren.Value, this.excludeSelf.Value);
				}
				else
				{
					base.Fsm.BroadcastEvent(this.broadcastEvent.Value, this.excludeSelf.Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04004186 RID: 16774
		[RequiredField]
		public FsmString broadcastEvent;

		// Token: 0x04004187 RID: 16775
		[Tooltip("Optionally specify a game object to broadcast the event to all FSMs on that game object.")]
		public FsmGameObject gameObject;

		// Token: 0x04004188 RID: 16776
		[Tooltip("Broadcast to all FSMs on the game object's children.")]
		public FsmBool sendToChildren;

		// Token: 0x04004189 RID: 16777
		public FsmBool excludeSelf;
	}
}
