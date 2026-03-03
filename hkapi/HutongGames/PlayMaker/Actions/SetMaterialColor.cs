using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD1 RID: 3281
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named color value in a game object's material.")]
	public class SetMaterialColor : ComponentAction<Renderer>
	{
		// Token: 0x06004443 RID: 17475 RVA: 0x001752A4 File Offset: 0x001734A4
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.material = null;
			this.namedColor = "_Color";
			this.color = Color.black;
			this.everyFrame = false;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001752F2 File Offset: 0x001734F2
		public override void OnEnter()
		{
			this.namedColorId = SetMaterialColor.GetNameId(this.namedColor);
			this.DoSetMaterialColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x0017531C File Offset: 0x0017351C
		private static int GetNameId(FsmString fsmStr)
		{
			string text = fsmStr.Value;
			if (string.IsNullOrEmpty(text))
			{
				text = "_Color";
			}
			return Shader.PropertyToID(text);
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00175344 File Offset: 0x00173544
		public override void OnUpdate()
		{
			this.DoSetMaterialColor();
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x0017534C File Offset: 0x0017354C
		private void DoSetMaterialColor()
		{
			if (this.color.IsNone)
			{
				return;
			}
			if (this.material.Value != null)
			{
				this.material.Value.SetColor(this.namedColorId, this.color.Value);
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
				base.renderer.material.SetColor(this.namedColorId, this.color.Value);
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value].SetColor(this.namedColorId, this.color.Value);
				base.renderer.materials = materials;
			}
		}

		// Token: 0x0400488A RID: 18570
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400488B RID: 18571
		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		// Token: 0x0400488C RID: 18572
		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		// Token: 0x0400488D RID: 18573
		[UIHint(UIHint.NamedColor)]
		[Tooltip("A named color parameter in the shader.")]
		public FsmString namedColor;

		// Token: 0x0400488E RID: 18574
		[RequiredField]
		[Tooltip("Set the parameter value.")]
		public FsmColor color;

		// Token: 0x0400488F RID: 18575
		[Tooltip("Repeat every frame. Useful if the value is animated.")]
		public bool everyFrame;

		// Token: 0x04004890 RID: 18576
		private int namedColorId;
	}
}
