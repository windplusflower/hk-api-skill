using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDB RID: 3291
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a Game Object's material randomly from an array of Materials.")]
	public class SetRandomMaterial : ComponentAction<Renderer>
	{
		// Token: 0x0600446F RID: 17519 RVA: 0x00175C14 File Offset: 0x00173E14
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.materials = new FsmMaterial[3];
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00175C35 File Offset: 0x00173E35
		public override void OnEnter()
		{
			this.DoSetRandomMaterial();
			base.Finish();
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00175C44 File Offset: 0x00173E44
		private void DoSetRandomMaterial()
		{
			if (this.materials == null)
			{
				return;
			}
			if (this.materials.Length == 0)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			if (base.renderer.material == null)
			{
				base.LogError("Missing Material!");
				return;
			}
			if (this.materialIndex.Value == 0)
			{
				base.renderer.material = this.materials[UnityEngine.Random.Range(0, this.materials.Length)].Value;
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] array = base.renderer.materials;
				array[this.materialIndex.Value] = this.materials[UnityEngine.Random.Range(0, this.materials.Length)].Value;
				base.renderer.materials = array;
			}
		}

		// Token: 0x040048B7 RID: 18615
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048B8 RID: 18616
		public FsmInt materialIndex;

		// Token: 0x040048B9 RID: 18617
		public FsmMaterial[] materials;
	}
}
