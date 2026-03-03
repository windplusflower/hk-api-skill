using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000951 RID: 2385
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Store mesh vertex positions into an arrayList")]
	public class ArrayListGetVertexPositions : ArrayListActions
	{
		// Token: 0x0600347E RID: 13438 RVA: 0x00139799 File Offset: 0x00137999
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.mesh = null;
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x001397B0 File Offset: 0x001379B0
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.getVertexPositions();
			}
			base.Finish();
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x001397E4 File Offset: 0x001379E4
		public void getVertexPositions()
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
			this.proxy.arrayList.InsertRange(0, component.mesh.vertices);
		}

		// Token: 0x04003629 RID: 13865
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400362A RID: 13866
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400362B RID: 13867
		[ActionSection("Source")]
		[Tooltip("the GameObject to get the mesh from")]
		[CheckForComponent(typeof(MeshFilter))]
		public FsmGameObject mesh;
	}
}
