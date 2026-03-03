using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000952 RID: 2386
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Set a mesh vertex colors based on colors found in an arrayList")]
	public class ArrayListSetVertexColors : ArrayListActions
	{
		// Token: 0x06003482 RID: 13442 RVA: 0x0013984D File Offset: 0x00137A4D
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.mesh = null;
			this.everyFrame = false;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x0013986C File Offset: 0x00137A6C
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
				this.SetVertexColors();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x001398F0 File Offset: 0x00137AF0
		public override void OnUpdate()
		{
			this.SetVertexColors();
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x001398F8 File Offset: 0x00137AF8
		public void SetVertexColors()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this._colors = new Color[this.proxy.arrayList.Count];
			int num = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				Color color = (Color)obj;
				this._colors[num] = color;
				num++;
			}
			this._mesh.colors = this._colors;
		}

		// Token: 0x0400362C RID: 13868
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400362D RID: 13869
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400362E RID: 13870
		[ActionSection("Target")]
		[Tooltip("The GameObject to set the mesh colors to")]
		[CheckForComponent(typeof(MeshFilter))]
		public FsmGameObject mesh;

		// Token: 0x0400362F RID: 13871
		public bool everyFrame;

		// Token: 0x04003630 RID: 13872
		private Mesh _mesh;

		// Token: 0x04003631 RID: 13873
		private Color[] _colors;
	}
}
