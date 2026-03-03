using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000950 RID: 2384
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Store a mesh vertex colors into an arrayList")]
	public class ArrayListGetVertexColors : ArrayListActions
	{
		// Token: 0x0600347A RID: 13434 RVA: 0x001396E4 File Offset: 0x001378E4
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.mesh = null;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x001396FB File Offset: 0x001378FB
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.getVertexColors();
			}
			base.Finish();
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00139730 File Offset: 0x00137930
		public void getVertexColors()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Clear();
			GameObject value = this.mesh.Value;
			if (value == null)
			{
				return;
			}
			MeshFilter component = value.GetComponent<MeshFilter>();
			if (component == null)
			{
				return;
			}
			this.proxy.arrayList.InsertRange(0, component.mesh.colors);
		}

		// Token: 0x04003626 RID: 13862
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003627 RID: 13863
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003628 RID: 13864
		[ActionSection("Source")]
		[Tooltip("the GameObject to get the mesh from")]
		[CheckForComponent(typeof(MeshFilter))]
		public FsmGameObject mesh;
	}
}
