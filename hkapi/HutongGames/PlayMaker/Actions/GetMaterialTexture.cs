using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BFB RID: 3067
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Get a texture from a material on a GameObject")]
	public class GetMaterialTexture : ComponentAction<Renderer>
	{
		// Token: 0x06004074 RID: 16500 RVA: 0x0016A3E2 File Offset: 0x001685E2
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.namedTexture = "_MainTex";
			this.storedTexture = null;
			this.getFromSharedMaterial = false;
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x0016A415 File Offset: 0x00168615
		public override void OnEnter()
		{
			this.DoGetMaterialTexture();
			base.Finish();
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0016A424 File Offset: 0x00168624
		private void DoGetMaterialTexture()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			string text = this.namedTexture.Value;
			if (text == "")
			{
				text = "_MainTex";
			}
			if (this.materialIndex.Value == 0 && !this.getFromSharedMaterial)
			{
				this.storedTexture.Value = base.renderer.material.GetTexture(text);
				return;
			}
			if (this.materialIndex.Value == 0 && this.getFromSharedMaterial)
			{
				this.storedTexture.Value = base.renderer.sharedMaterial.GetTexture(text);
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value && !this.getFromSharedMaterial)
			{
				Material[] materials = base.renderer.materials;
				this.storedTexture.Value = base.renderer.materials[this.materialIndex.Value].GetTexture(text);
				base.renderer.materials = materials;
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value && this.getFromSharedMaterial)
			{
				Material[] sharedMaterials = base.renderer.sharedMaterials;
				this.storedTexture.Value = base.renderer.sharedMaterials[this.materialIndex.Value].GetTexture(text);
				base.renderer.materials = sharedMaterials;
			}
		}

		// Token: 0x040044D2 RID: 17618
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject the Material is applied to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044D3 RID: 17619
		[Tooltip("The index of the Material in the Materials array.")]
		public FsmInt materialIndex;

		// Token: 0x040044D4 RID: 17620
		[UIHint(UIHint.NamedTexture)]
		[Tooltip("The texture to get. See Unity Shader docs for names.")]
		public FsmString namedTexture;

		// Token: 0x040044D5 RID: 17621
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Title("StoreTexture")]
		[Tooltip("Store the texture in a variable.")]
		public FsmTexture storedTexture;

		// Token: 0x040044D6 RID: 17622
		[Tooltip("Get the shared version of the texture.")]
		public bool getFromSharedMaterial;
	}
}
