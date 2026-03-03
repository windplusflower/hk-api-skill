using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000911 RID: 2321
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Copy elements from one PlayMaker ArrayList Proxy component to another")]
	public class ArrayListCopyTo : ArrayListActions
	{
		// Token: 0x0600336E RID: 13166 RVA: 0x00135714 File Offset: 0x00133914
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.gameObjectTarget = null;
			this.referenceTarget = null;
			this.startIndex = new FsmInt
			{
				UseVariable = true
			};
			this.count = new FsmInt
			{
				UseVariable = true
			};
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00135761 File Offset: 0x00133961
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListCopyTo(this.proxy.arrayList);
			}
			base.Finish();
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x001357A0 File Offset: 0x001339A0
		public void DoArrayListCopyTo(ArrayList source)
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObjectTarget), this.referenceTarget.Value))
			{
				return;
			}
			if (!base.isProxyValid())
			{
				return;
			}
			int value = this.startIndex.Value;
			int num = source.Count;
			int value2 = source.Count;
			if (!this.count.IsNone)
			{
				value2 = this.count.Value;
			}
			if (value < 0 || value >= source.Count)
			{
				base.LogError("start index out of range");
				return;
			}
			if (this.count.Value < 0)
			{
				base.LogError("count can not be negative");
				return;
			}
			num = Mathf.Min(value + value2, source.Count);
			for (int i = value; i < num; i++)
			{
				this.proxy.arrayList.Add(source[i]);
			}
		}

		// Token: 0x040034D6 RID: 13526
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component to copy from")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034D7 RID: 13527
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to copy from ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040034D8 RID: 13528
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component to copy to")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObjectTarget;

		// Token: 0x040034D9 RID: 13529
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to copy to ( necessary if several component coexists on the same GameObject")]
		public FsmString referenceTarget;

		// Token: 0x040034DA RID: 13530
		[Tooltip("Optional start index to copy from the source, if not set, starts from the beginning")]
		public FsmInt startIndex;

		// Token: 0x040034DB RID: 13531
		[Tooltip("Optional amount of elements to copy, If not set, will copy all from start index.")]
		public FsmInt count;
	}
}
