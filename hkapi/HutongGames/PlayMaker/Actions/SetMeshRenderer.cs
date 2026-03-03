using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A46 RID: 2630
	[ActionCategory("GameObject")]
	[Tooltip("Set Mesh Renderer to active or inactive. Can only be one Mesh Renderer on object. ")]
	public class SetMeshRenderer : FsmStateAction
	{
		// Token: 0x060038FB RID: 14587 RVA: 0x0014CD71 File Offset: 0x0014AF71
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0014CD88 File Offset: 0x0014AF88
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					MeshRenderer component = ownerDefaultTarget.GetComponent<MeshRenderer>();
					if (component != null)
					{
						component.enabled = this.active.Value;
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003B99 RID: 15257
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B9A RID: 15258
		public FsmBool active;
	}
}
