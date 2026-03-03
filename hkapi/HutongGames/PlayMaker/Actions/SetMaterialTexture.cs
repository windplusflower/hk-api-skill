using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD3 RID: 3283
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named texture in a game object's material.")]
	public class SetMaterialTexture : ComponentAction<Renderer>
	{
		// Token: 0x0600444E RID: 17486 RVA: 0x001755D8 File Offset: 0x001737D8
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.material = null;
			this.namedTexture = "_MainTex";
			this.texture = null;
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x0017560B File Offset: 0x0017380B
		public override void OnEnter()
		{
			this.DoSetMaterialTexture();
			base.Finish();
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x0017561C File Offset: 0x0017381C
		private void DoSetMaterialTexture()
		{
			string text = this.namedTexture.Value;
			if (text == "")
			{
				text = "_MainTex";
			}
			if (this.material.Value != null)
			{
				this.material.Value.SetTexture(text, this.texture.Value);
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
				base.renderer.material.SetTexture(text, this.texture.Value);
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value].SetTexture(text, this.texture.Value);
				base.renderer.materials = materials;
			}
		}

		// Token: 0x04004897 RID: 18583
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004898 RID: 18584
		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		// Token: 0x04004899 RID: 18585
		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		// Token: 0x0400489A RID: 18586
		[UIHint(UIHint.NamedTexture)]
		[Tooltip("A named parameter in the shader.")]
		public FsmString namedTexture;

		// Token: 0x0400489B RID: 18587
		public FsmTexture texture;
	}
}
