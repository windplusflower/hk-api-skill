using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D5 RID: 2517
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Gets a named color value from a game object's material.")]
	public class GetMaterialColor : FsmStateAction
	{
		// Token: 0x06003705 RID: 14085 RVA: 0x001441B2 File Offset: 0x001423B2
		public override void Reset()
		{
			this.gameObject = null;
			this.materialIndex = 0;
			this.material = null;
			this.namedColor = "_Color";
			this.color = null;
			this.fail = null;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x001441EC File Offset: 0x001423EC
		public override void OnEnter()
		{
			this.DoGetMaterialColor();
			base.Finish();
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x001441FC File Offset: 0x001423FC
		private void DoGetMaterialColor()
		{
			if (this.color.IsNone)
			{
				return;
			}
			string text = this.namedColor.Value;
			if (text == "")
			{
				text = "_Color";
			}
			if (this.material.Value != null)
			{
				if (!this.material.Value.HasProperty(text))
				{
					base.Fsm.Event(this.fail);
					return;
				}
				this.color.Value = this.material.Value.GetColor(text);
				return;
			}
			else
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget == null)
				{
					return;
				}
				if (ownerDefaultTarget.GetComponent<Renderer>() == null)
				{
					base.LogError("Missing Renderer!");
					return;
				}
				if (ownerDefaultTarget.GetComponent<Renderer>().material == null)
				{
					base.LogError("Missing Material!");
					return;
				}
				if (this.materialIndex.Value != 0)
				{
					if (ownerDefaultTarget.GetComponent<Renderer>().materials.Length > this.materialIndex.Value)
					{
						Material[] materials = ownerDefaultTarget.GetComponent<Renderer>().materials;
						if (!materials[this.materialIndex.Value].HasProperty(text))
						{
							base.Fsm.Event(this.fail);
							return;
						}
						this.color.Value = materials[this.materialIndex.Value].GetColor(text);
					}
					return;
				}
				if (!ownerDefaultTarget.GetComponent<Renderer>().material.HasProperty(text))
				{
					base.Fsm.Event(this.fail);
					return;
				}
				this.color.Value = ownerDefaultTarget.GetComponent<Renderer>().material.GetColor(text);
				return;
			}
		}

		// Token: 0x0400391C RID: 14620
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400391D RID: 14621
		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		// Token: 0x0400391E RID: 14622
		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		// Token: 0x0400391F RID: 14623
		[UIHint(UIHint.NamedColor)]
		[Tooltip("The named color parameter in the shader.")]
		public FsmString namedColor;

		// Token: 0x04003920 RID: 14624
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the parameter value.")]
		public FsmColor color;

		// Token: 0x04003921 RID: 14625
		public FsmEvent fail;
	}
}
