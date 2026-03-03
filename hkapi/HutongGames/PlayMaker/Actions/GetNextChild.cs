using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C02 RID: 3074
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Each time this action is called it gets the next child of a GameObject. This lets you quickly loop through all the children of an object to perform actions on them. NOTE: To find a specific child use Find Child.")]
	public class GetNextChild : FsmStateAction
	{
		// Token: 0x06004095 RID: 16533 RVA: 0x0016A7CA File Offset: 0x001689CA
		public override void Reset()
		{
			this.gameObject = null;
			this.storeNextChild = null;
			this.loopEvent = null;
			this.finishedEvent = null;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0016A7E8 File Offset: 0x001689E8
		public override void OnEnter()
		{
			this.DoGetNextChild(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0016A808 File Offset: 0x00168A08
		private void DoGetNextChild(GameObject parent)
		{
			if (parent == null)
			{
				return;
			}
			if (this.go != parent)
			{
				this.go = parent;
				this.nextChildIndex = 0;
			}
			if (this.nextChildIndex >= this.go.transform.childCount)
			{
				this.nextChildIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.storeNextChild.Value = parent.transform.GetChild(this.nextChildIndex).gameObject;
			if (this.nextChildIndex >= this.go.transform.childCount)
			{
				this.nextChildIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.nextChildIndex++;
			if (this.loopEvent != null)
			{
				base.Fsm.Event(this.loopEvent);
			}
		}

		// Token: 0x040044E8 RID: 17640
		[RequiredField]
		[Tooltip("The parent GameObject. Note, if GameObject changes, this action will reset and start again at the first child.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044E9 RID: 17641
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the next child in a GameObject variable.")]
		public FsmGameObject storeNextChild;

		// Token: 0x040044EA RID: 17642
		[Tooltip("Event to send to get the next child.")]
		public FsmEvent loopEvent;

		// Token: 0x040044EB RID: 17643
		[Tooltip("Event to send when there are no more children.")]
		public FsmEvent finishedEvent;

		// Token: 0x040044EC RID: 17644
		private GameObject go;

		// Token: 0x040044ED RID: 17645
		private int nextChildIndex;
	}
}
