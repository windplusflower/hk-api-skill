using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200094A RID: 2378
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Send event to all the GameObjects within an arrayList.")]
	public class ArrayListSendEventToGameObjects : ArrayListActions
	{
		// Token: 0x0600345A RID: 13402 RVA: 0x00138F28 File Offset: 0x00137128
		public override void Reset()
		{
			this.eventTarget = new FsmEventTarget();
			this.eventTarget.target = FsmEventTarget.EventTarget.BroadcastAll;
			this.gameObject = null;
			this.reference = null;
			this.sendEvent = null;
			this.excludeSelf = false;
			this.sendToChildren = false;
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00138F79 File Offset: 0x00137179
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoSendEvent();
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00138FAC File Offset: 0x001371AC
		private void DoSendEvent()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			foreach (object obj in this.proxy.arrayList)
			{
				GameObject go = (GameObject)obj;
				this.sendEventToGO(go);
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00139014 File Offset: 0x00137214
		private void sendEventToGO(GameObject _go)
		{
			FsmEventTarget fsmEventTarget = new FsmEventTarget();
			fsmEventTarget.excludeSelf = this.excludeSelf.Value;
			fsmEventTarget.gameObject = new FsmOwnerDefault
			{
				OwnerOption = OwnerDefaultOption.SpecifyGameObject,
				GameObject = new FsmGameObject(),
				GameObject = 
				{
					Value = _go
				}
			};
			fsmEventTarget.target = FsmEventTarget.EventTarget.GameObject;
			fsmEventTarget.sendToChildren = this.sendToChildren.Value;
			base.Fsm.Event(fsmEventTarget, this.sendEvent);
		}

		// Token: 0x04003606 RID: 13830
		[ActionSection("Set up")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003607 RID: 13831
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003608 RID: 13832
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003609 RID: 13833
		[RequiredField]
		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		public FsmEvent sendEvent;

		// Token: 0x0400360A RID: 13834
		public FsmBool excludeSelf;

		// Token: 0x0400360B RID: 13835
		public FsmBool sendToChildren;
	}
}
