using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A47 RID: 2631
	[ActionCategory("GameObject")]
	[Tooltip("Set Mesh Renderer of object's children to active or inactive. Can only be one Mesh Renderer on each object. ")]
	public class SetMeshRendererChildren : FsmStateAction
	{
		// Token: 0x060038FE RID: 14590 RVA: 0x0014CDDF File Offset: 0x0014AFDF
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0014CDF4 File Offset: 0x0014AFF4
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					foreach (object obj in ownerDefaultTarget.transform)
					{
						MeshRenderer component = ((Transform)obj).GetComponent<MeshRenderer>();
						if (component != null)
						{
							component.enabled = this.active.Value;
						}
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003B9B RID: 15259
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B9C RID: 15260
		public FsmBool active;
	}
}
