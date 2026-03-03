using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD0 RID: 3280
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the material on a game object.")]
	public class SetMaterial : ComponentAction<Renderer>
	{
		// Token: 0x0600443F RID: 17471 RVA: 0x001751E2 File Offset: 0x001733E2
		public override void Reset()
		{
			this.gameObject = null;
			this.material = null;
			this.materialIndex = 0;
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001751FE File Offset: 0x001733FE
		public override void OnEnter()
		{
			this.DoSetMaterial();
			base.Finish();
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0017520C File Offset: 0x0017340C
		private void DoSetMaterial()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			if (this.materialIndex.Value == 0)
			{
				base.renderer.material = this.material.Value;
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value] = this.material.Value;
				base.renderer.materials = materials;
			}
		}

		// Token: 0x04004887 RID: 18567
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004888 RID: 18568
		public FsmInt materialIndex;

		// Token: 0x04004889 RID: 18569
		[RequiredField]
		public FsmMaterial material;
	}
}
