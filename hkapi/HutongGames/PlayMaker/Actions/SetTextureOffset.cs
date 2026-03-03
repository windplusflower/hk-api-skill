using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE6 RID: 3302
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the Offset of a named texture in a Game Object's Material. Useful for scrolling texture effects.")]
	public class SetTextureOffset : ComponentAction<Renderer>
	{
		// Token: 0x060044A4 RID: 17572 RVA: 0x001765E0 File Offset: 0x001747E0
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.namedTexture = "_MainTex";
			this.offsetX = 0f;
			this.offsetY = 0f;
			this.everyFrame = false;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00176637 File Offset: 0x00174837
		public override void OnEnter()
		{
			this.DoSetTextureOffset();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0017664D File Offset: 0x0017484D
		public override void OnUpdate()
		{
			this.DoSetTextureOffset();
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00176658 File Offset: 0x00174858
		private void DoSetTextureOffset()
		{
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
				base.renderer.material.SetTextureOffset(this.namedTexture.Value, new Vector2(this.offsetX.Value, this.offsetY.Value));
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value].SetTextureOffset(this.namedTexture.Value, new Vector2(this.offsetX.Value, this.offsetY.Value));
				base.renderer.materials = materials;
			}
		}

		// Token: 0x040048E5 RID: 18661
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048E6 RID: 18662
		public FsmInt materialIndex;

		// Token: 0x040048E7 RID: 18663
		[RequiredField]
		[UIHint(UIHint.NamedColor)]
		public FsmString namedTexture;

		// Token: 0x040048E8 RID: 18664
		[RequiredField]
		public FsmFloat offsetX;

		// Token: 0x040048E9 RID: 18665
		[RequiredField]
		public FsmFloat offsetY;

		// Token: 0x040048EA RID: 18666
		public bool everyFrame;
	}
}
