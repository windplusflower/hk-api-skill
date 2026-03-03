using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099A RID: 2458
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("gets the local or gloabal bounding box measures")]
	public class Bounds : FsmStateAction
	{
		// Token: 0x060035DE RID: 13790 RVA: 0x0013DBC2 File Offset: 0x0013BDC2
		public override void Reset()
		{
			this.gameObject1 = null;
			this.everyFrame = false;
			this.global = false;
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0013DBDC File Offset: 0x0013BDDC
		public void GetEm()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject1);
			if (this.global)
			{
				this.scale.Value = ownerDefaultTarget.GetComponent<Renderer>().bounds.size;
				return;
			}
			Mesh sharedMesh = ownerDefaultTarget.GetComponent<MeshFilter>().sharedMesh;
			this.scale.Value = sharedMesh.bounds.size;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0013DC47 File Offset: 0x0013BE47
		public override void OnEnter()
		{
			this.GetEm();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0013DC5D File Offset: 0x0013BE5D
		public override void OnUpdate()
		{
			this.GetEm();
		}

		// Token: 0x04003777 RID: 14199
		[RequiredField]
		public FsmOwnerDefault gameObject1;

		// Token: 0x04003778 RID: 14200
		[Tooltip("gets the local or global bounding box scale")]
		public FsmVector3 scale;

		// Token: 0x04003779 RID: 14201
		[Tooltip("Should the scale be global? If it's rotated you probably want local axis for the scale")]
		public bool global;

		// Token: 0x0400377A RID: 14202
		public bool everyFrame;
	}
}
