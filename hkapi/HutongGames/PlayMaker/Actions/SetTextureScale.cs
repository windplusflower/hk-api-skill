using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE7 RID: 3303
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the Scale of a named texture in a Game Object's Material. Useful for special effects.")]
	public class SetTextureScale : ComponentAction<Renderer>
	{
		// Token: 0x060044A9 RID: 17577 RVA: 0x00176750 File Offset: 0x00174950
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.namedTexture = "_MainTex";
			this.scaleX = 1f;
			this.scaleY = 1f;
			this.everyFrame = false;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x001767A7 File Offset: 0x001749A7
		public override void OnEnter()
		{
			this.DoSetTextureScale();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x001767BD File Offset: 0x001749BD
		public override void OnUpdate()
		{
			this.DoSetTextureScale();
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x001767C8 File Offset: 0x001749C8
		private void DoSetTextureScale()
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
				base.renderer.material.SetTextureScale(this.namedTexture.Value, new Vector2(this.scaleX.Value, this.scaleY.Value));
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value].SetTextureScale(this.namedTexture.Value, new Vector2(this.scaleX.Value, this.scaleY.Value));
				base.renderer.materials = materials;
			}
		}

		// Token: 0x040048EB RID: 18667
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048EC RID: 18668
		public FsmInt materialIndex;

		// Token: 0x040048ED RID: 18669
		[UIHint(UIHint.NamedColor)]
		public FsmString namedTexture;

		// Token: 0x040048EE RID: 18670
		[RequiredField]
		public FsmFloat scaleX;

		// Token: 0x040048EF RID: 18671
		[RequiredField]
		public FsmFloat scaleY;

		// Token: 0x040048F0 RID: 18672
		public bool everyFrame;
	}
}
