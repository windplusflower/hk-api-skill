using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C26 RID: 3110
	[ActionCategory("Mesh")]
	[Tooltip("Gets the position of a vertex in a GameObject's mesh. Hint: Use GetVertexCount to get the number of vertices in a mesh.")]
	public class GetVertexPosition : FsmStateAction
	{
		// Token: 0x06004130 RID: 16688 RVA: 0x0016BE1A File Offset: 0x0016A01A
		public override void Reset()
		{
			this.gameObject = null;
			this.space = Space.World;
			this.storePosition = null;
			this.everyFrame = false;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x0016BE38 File Offset: 0x0016A038
		public override void OnEnter()
		{
			this.DoGetVertexPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x0016BE4E File Offset: 0x0016A04E
		public override void OnUpdate()
		{
			this.DoGetVertexPosition();
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x0016BE58 File Offset: 0x0016A058
		private void DoGetVertexPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				MeshFilter component = ownerDefaultTarget.GetComponent<MeshFilter>();
				if (component == null)
				{
					base.LogError("Missing MeshFilter!");
					return;
				}
				Space space = this.space;
				if (space == Space.World)
				{
					Vector3 position = component.mesh.vertices[this.vertexIndex.Value];
					this.storePosition.Value = ownerDefaultTarget.transform.TransformPoint(position);
					return;
				}
				if (space != Space.Self)
				{
					return;
				}
				this.storePosition.Value = component.mesh.vertices[this.vertexIndex.Value];
			}
		}

		// Token: 0x04004574 RID: 17780
		[RequiredField]
		[CheckForComponent(typeof(MeshFilter))]
		[Tooltip("The GameObject to check.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004575 RID: 17781
		[RequiredField]
		[Tooltip("The index of the vertex.")]
		public FsmInt vertexIndex;

		// Token: 0x04004576 RID: 17782
		[Tooltip("Coordinate system to use.")]
		public Space space;

		// Token: 0x04004577 RID: 17783
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the vertex position in a variable.")]
		public FsmVector3 storePosition;

		// Token: 0x04004578 RID: 17784
		[Tooltip("Repeat every frame. Useful if the mesh is animated.")]
		public bool everyFrame;
	}
}
