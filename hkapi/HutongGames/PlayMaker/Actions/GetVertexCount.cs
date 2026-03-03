using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C25 RID: 3109
	[ActionCategory("Mesh")]
	[Tooltip("Gets the number of vertices in a GameObject's mesh. Useful in conjunction with GetVertexPosition.")]
	public class GetVertexCount : FsmStateAction
	{
		// Token: 0x0600412B RID: 16683 RVA: 0x0016BD8A File Offset: 0x00169F8A
		public override void Reset()
		{
			this.gameObject = null;
			this.storeCount = null;
			this.everyFrame = false;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x0016BDA1 File Offset: 0x00169FA1
		public override void OnEnter()
		{
			this.DoGetVertexCount();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x0016BDB7 File Offset: 0x00169FB7
		public override void OnUpdate()
		{
			this.DoGetVertexCount();
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x0016BDC0 File Offset: 0x00169FC0
		private void DoGetVertexCount()
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
				this.storeCount.Value = component.mesh.vertexCount;
			}
		}

		// Token: 0x04004571 RID: 17777
		[RequiredField]
		[CheckForComponent(typeof(MeshFilter))]
		[Tooltip("The GameObject to check.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004572 RID: 17778
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the vertex count in a variable.")]
		public FsmInt storeCount;

		// Token: 0x04004573 RID: 17779
		public bool everyFrame;
	}
}
