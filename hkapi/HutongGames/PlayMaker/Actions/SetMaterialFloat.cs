using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD2 RID: 3282
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named float in a game object's material.")]
	public class SetMaterialFloat : ComponentAction<Renderer>
	{
		// Token: 0x06004449 RID: 17481 RVA: 0x0017545C File Offset: 0x0017365C
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.material = null;
			this.namedFloat = "";
			this.floatValue = 0f;
			this.everyFrame = false;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x001754AA File Offset: 0x001736AA
		public override void OnEnter()
		{
			this.DoSetMaterialFloat();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x001754C0 File Offset: 0x001736C0
		public override void OnUpdate()
		{
			this.DoSetMaterialFloat();
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x001754C8 File Offset: 0x001736C8
		private void DoSetMaterialFloat()
		{
			if (this.material.Value != null)
			{
				this.material.Value.SetFloat(this.namedFloat.Value, this.floatValue.Value);
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
				base.renderer.material.SetFloat(this.namedFloat.Value, this.floatValue.Value);
				return;
			}
			if (base.renderer.materials.Length > this.materialIndex.Value)
			{
				Material[] materials = base.renderer.materials;
				materials[this.materialIndex.Value].SetFloat(this.namedFloat.Value, this.floatValue.Value);
				base.renderer.materials = materials;
			}
		}

		// Token: 0x04004891 RID: 18577
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004892 RID: 18578
		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		// Token: 0x04004893 RID: 18579
		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		// Token: 0x04004894 RID: 18580
		[RequiredField]
		[Tooltip("A named float parameter in the shader.")]
		public FsmString namedFloat;

		// Token: 0x04004895 RID: 18581
		[RequiredField]
		[Tooltip("Set the parameter value.")]
		public FsmFloat floatValue;

		// Token: 0x04004896 RID: 18582
		[Tooltip("Repeat every frame. Useful if the value is animated.")]
		public bool everyFrame;
	}
}
