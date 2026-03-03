using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000953 RID: 2387
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Set mesh vertex positions based on vector3 found in an arrayList")]
	public class ArrayListSetVertexPositions : ArrayListActions
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00139998 File Offset: 0x00137B98
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.mesh = null;
			this.everyFrame = false;
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x001399B8 File Offset: 0x00137BB8
		public override void OnEnter()
		{
			GameObject value = this.mesh.Value;
			if (value == null)
			{
				base.Finish();
				return;
			}
			MeshFilter component = value.GetComponent<MeshFilter>();
			if (component == null)
			{
				base.Finish();
				return;
			}
			this._mesh = component.mesh;
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.SetVertexPositions();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00139A3C File Offset: 0x00137C3C
		public override void OnUpdate()
		{
			this.SetVertexPositions();
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00139A44 File Offset: 0x00137C44
		public void SetVertexPositions()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this._vertices = new Vector3[this.proxy.arrayList.Count];
			int num = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				Vector3 vector = (Vector3)obj;
				this._vertices[num] = vector;
				num++;
			}
			this._mesh.vertices = this._vertices;
		}

		// Token: 0x04003632 RID: 13874
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003633 RID: 13875
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003634 RID: 13876
		[ActionSection("Target")]
		[Tooltip("The GameObject to set the mesh vertex positions to")]
		[CheckForComponent(typeof(MeshFilter))]
		public FsmGameObject mesh;

		// Token: 0x04003635 RID: 13877
		public bool everyFrame;

		// Token: 0x04003636 RID: 13878
		private Mesh _mesh;

		// Token: 0x04003637 RID: 13879
		private Vector3[] _vertices;
	}
}
