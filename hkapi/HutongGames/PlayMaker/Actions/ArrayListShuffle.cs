using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000924 RID: 2340
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Shuffle elements from an ArrayList Proxy component")]
	public class ArrayListShuffle : ArrayListActions
	{
		// Token: 0x060033BB RID: 13243 RVA: 0x00136B02 File Offset: 0x00134D02
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.startIndex = 0;
			this.shufflingRange = 0;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00136B2A File Offset: 0x00134D2A
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListShuffle(this.proxy.arrayList);
			}
			base.Finish();
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00136B68 File Offset: 0x00134D68
		public void DoArrayListShuffle(ArrayList source)
		{
			if (!base.isProxyValid())
			{
				return;
			}
			int num = 0;
			int num2 = this.proxy.arrayList.Count - 1;
			if (this.startIndex.Value > 0)
			{
				num = Mathf.Min(this.startIndex.Value, num2);
			}
			if (this.shufflingRange.Value > 0)
			{
				num2 = Mathf.Min(this.proxy.arrayList.Count - 1, num + this.shufflingRange.Value);
			}
			Debug.Log(num);
			Debug.Log(num2);
			for (int i = num2; i > num; i--)
			{
				int index = UnityEngine.Random.Range(num, i + 1);
				object value = this.proxy.arrayList[i];
				this.proxy.arrayList[i] = this.proxy.arrayList[index];
				this.proxy.arrayList[index] = value;
			}
		}

		// Token: 0x04003540 RID: 13632
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component to shuffle")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003541 RID: 13633
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to copy from ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003542 RID: 13634
		[Tooltip("Optional start Index for the shuffling. Leave it to 0 for no effect")]
		public FsmInt startIndex;

		// Token: 0x04003543 RID: 13635
		[Tooltip("Optional range for the shuffling, starting at the start index if greater than 0. Leave it to 0 for no effect, that is will shuffle the whole array")]
		public FsmInt shufflingRange;
	}
}
