using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200091E RID: 2334
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Remove item at a specified index of a PlayMaker ArrayList Proxy component")]
	public class ArrayListRemoveAt : ArrayListActions
	{
		// Token: 0x060033A2 RID: 13218 RVA: 0x0013677B File Offset: 0x0013497B
		public override void Reset()
		{
			this.gameObject = null;
			this.failureEvent = null;
			this.reference = null;
			this.index = null;
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00136799 File Offset: 0x00134999
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doArrayListRemoveAt();
			}
			base.Finish();
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x001367CC File Offset: 0x001349CC
		public void doArrayListRemoveAt()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			try
			{
				this.proxy.arrayList.RemoveAt(this.index.Value);
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
			}
		}

		// Token: 0x0400352B RID: 13611
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400352C RID: 13612
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400352D RID: 13613
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The index to remove at")]
		public FsmInt index;

		// Token: 0x0400352E RID: 13614
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the removeAt throw errors")]
		public FsmEvent failureEvent;
	}
}
