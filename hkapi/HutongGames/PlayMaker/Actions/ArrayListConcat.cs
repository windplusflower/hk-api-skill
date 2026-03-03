using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090F RID: 2319
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Concat joins two or more arrayList proxy components. if a target is specified, the method use the target store the concatenation, else the ")]
	public class ArrayListConcat : ArrayListActions
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x0013531C File Offset: 0x0013351C
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.arrayListGameObjectTargets = null;
			this.referenceTargets = null;
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0013533A File Offset: 0x0013353A
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListConcat(this.proxy.arrayList);
			}
			base.Finish();
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00135378 File Offset: 0x00133578
		public void DoArrayListConcat(ArrayList source)
		{
			if (!base.isProxyValid())
			{
				return;
			}
			for (int i = 0; i < this.arrayListGameObjectTargets.Length; i++)
			{
				if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.arrayListGameObjectTargets[i]), this.referenceTargets[i].Value) && base.isProxyValid())
				{
					foreach (object value in this.proxy.arrayList)
					{
						source.Add(value);
						Debug.Log("count " + source.Count.ToString());
					}
				}
			}
		}

		// Token: 0x040034CC RID: 13516
		[ActionSection("Storage")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034CD RID: 13517
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to store the concatenation ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040034CE RID: 13518
		[ActionSection("ArrayLists to concatenate")]
		[CompoundArray("ArrayLists", "ArrayList GameObject", "Reference")]
		[RequiredField]
		[Tooltip("The GameObject with the PlayMaker ArrayList Proxy component to copy to")]
		[ObjectType(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault[] arrayListGameObjectTargets;

		// Token: 0x040034CF RID: 13519
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to copy to ( necessary if several component coexists on the same GameObject")]
		public FsmString[] referenceTargets;
	}
}
