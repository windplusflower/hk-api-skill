using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000926 RID: 2342
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Swap two items at a specified indexes of a PlayMaker ArrayList Proxy component")]
	public class ArrayListSwapItems : ArrayListActions
	{
		// Token: 0x060033C3 RID: 13251 RVA: 0x00136CB7 File Offset: 0x00134EB7
		public override void Reset()
		{
			this.gameObject = null;
			this.failureEvent = null;
			this.reference = null;
			this.index1 = null;
			this.index2 = null;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00136CDC File Offset: 0x00134EDC
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doArrayListSwap();
			}
			base.Finish();
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00136D10 File Offset: 0x00134F10
		public void doArrayListSwap()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			try
			{
				object value = this.proxy.arrayList[this.index2.Value];
				this.proxy.arrayList[this.index2.Value] = this.proxy.arrayList[this.index1.Value];
				this.proxy.arrayList[this.index1.Value] = value;
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
			}
		}

		// Token: 0x04003546 RID: 13638
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003547 RID: 13639
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003548 RID: 13640
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The first index to swap")]
		public FsmInt index1;

		// Token: 0x04003549 RID: 13641
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The second index to swap")]
		public FsmInt index2;

		// Token: 0x0400354A RID: 13642
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the removeAt throw errors")]
		public FsmEvent failureEvent;
	}
}
