using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000914 RID: 2324
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Gets an item from a PlayMaker ArrayList Proxy component")]
	public class ArrayListGet : ArrayListActions
	{
		// Token: 0x06003379 RID: 13177 RVA: 0x00135990 File Offset: 0x00133B90
		public override void Reset()
		{
			this.atIndex = null;
			this.gameObject = null;
			this.failureEvent = null;
			this.result = null;
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x001359AE File Offset: 0x00133BAE
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.GetItemAtIndex();
			}
			base.Finish();
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x001359E0 File Offset: 0x00133BE0
		public void GetItemAtIndex()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (this.result.IsNone)
			{
				base.Fsm.Event(this.failureEvent);
				return;
			}
			object value = null;
			try
			{
				value = this.proxy.arrayList[this.atIndex.Value];
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				base.Fsm.Event(this.failureEvent);
				return;
			}
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.result, value);
		}

		// Token: 0x040034E4 RID: 13540
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034E5 RID: 13541
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040034E6 RID: 13542
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The index to retrieve the item from")]
		public FsmInt atIndex;

		// Token: 0x040034E7 RID: 13543
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVar result;

		// Token: 0x040034E8 RID: 13544
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the action fails ( likely and index is out of range exception)")]
		public FsmEvent failureEvent;
	}
}
