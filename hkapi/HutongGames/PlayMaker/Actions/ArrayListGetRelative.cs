using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200091C RID: 2332
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Gets an item from a PlayMaker ArrayList Proxy component using a base index and a relative increment. This allows you to move to next or previous items granuraly")]
	public class ArrayListGetRelative : ArrayListActions
	{
		// Token: 0x0600339A RID: 13210 RVA: 0x0013658C File Offset: 0x0013478C
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.baseIndex = null;
			this.increment = null;
			this.result = null;
			this.resultIndex = null;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x001365B8 File Offset: 0x001347B8
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.GetItemAtIncrement();
			}
			base.Finish();
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x001365EC File Offset: 0x001347EC
		public void GetItemAtIncrement()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (this.baseIndex.Value + this.increment.Value >= 0)
			{
				this.resultIndex.Value = (this.baseIndex.Value + this.increment.Value) % this.proxy.arrayList.Count;
			}
			else
			{
				this.resultIndex.Value = this.proxy.arrayList.Count - Mathf.Abs(this.baseIndex.Value + this.increment.Value) % this.proxy.arrayList.Count;
			}
			object value = this.proxy.arrayList[this.resultIndex.Value];
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.result, value);
		}

		// Token: 0x04003521 RID: 13601
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003522 RID: 13602
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003523 RID: 13603
		[Tooltip("The index base to compute the item to get")]
		public FsmInt baseIndex;

		// Token: 0x04003524 RID: 13604
		[Tooltip("The incremental value from the base index to get the value from. Overshooting the range will loop back on the list.")]
		public FsmInt increment;

		// Token: 0x04003525 RID: 13605
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmVar result;

		// Token: 0x04003526 RID: 13606
		[Tooltip("The index of the result")]
		[UIHint(UIHint.Variable)]
		public FsmInt resultIndex;
	}
}
