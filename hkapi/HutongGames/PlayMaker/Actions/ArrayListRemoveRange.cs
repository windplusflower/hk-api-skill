using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200091F RID: 2335
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Remove the specified range of elements from a PlayMaker ArrayList Proxy component")]
	public class ArrayListRemoveRange : ArrayListActions
	{
		// Token: 0x060033A6 RID: 13222 RVA: 0x00136830 File Offset: 0x00134A30
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.index = null;
			this.count = null;
			this.failureEvent = null;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00136855 File Offset: 0x00134A55
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doArrayListRemoveRange();
			}
			base.Finish();
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00136888 File Offset: 0x00134A88
		public void doArrayListRemoveRange()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			try
			{
				this.proxy.arrayList.RemoveRange(this.index.Value, this.count.Value);
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
			}
		}

		// Token: 0x0400352F RID: 13615
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003530 RID: 13616
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003531 RID: 13617
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The zero-based index of the first element of the range of elements to remove. This value is between 0 and the array.count minus count (inclusive)")]
		public FsmInt index;

		// Token: 0x04003532 RID: 13618
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The number of elements to remove. This value is between 0 and the difference between the array.count minus the index ( inclusive )")]
		public FsmInt count;

		// Token: 0x04003533 RID: 13619
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the removeRange throw errors")]
		public FsmEvent failureEvent;
	}
}
