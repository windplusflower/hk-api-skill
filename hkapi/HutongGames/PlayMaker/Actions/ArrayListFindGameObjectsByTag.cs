using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000944 RID: 2372
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Store all active GameObjects with a specific tag. Tags must be declared in the tag manager before using them")]
	public class ArrayListFindGameObjectsByTag : ArrayListActions
	{
		// Token: 0x0600343B RID: 13371 RVA: 0x00138614 File Offset: 0x00136814
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.tag = null;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x0013862B File Offset: 0x0013682B
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.FindGOByTag();
			}
			base.Finish();
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00138660 File Offset: 0x00136860
		public void FindGOByTag()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Clear();
			GameObject[] c = GameObject.FindGameObjectsWithTag(this.tag.Value);
			this.proxy.arrayList.InsertRange(0, c);
		}

		// Token: 0x040035D7 RID: 13783
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035D8 RID: 13784
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035D9 RID: 13785
		[Tooltip("the tag")]
		public FsmString tag;
	}
}
