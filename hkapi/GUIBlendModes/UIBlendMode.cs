using System;
using UnityEngine;
using UnityEngine.UI;

namespace GUIBlendModes
{
	// Token: 0x020008B6 RID: 2230
	[AddComponentMenu("UI/Effects/Blend Mode")]
	[RequireComponent(typeof(MaskableGraphic))]
	[ExecuteInEditMode]
	public class UIBlendMode : MonoBehaviour
	{
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0012E628 File Offset: 0x0012C828
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x0012E630 File Offset: 0x0012C830
		public BlendMode BlendMode
		{
			get
			{
				return this.blendMode;
			}
			set
			{
				this.SetBlendMode(value, this.ShaderOptimization);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x0012E63F File Offset: 0x0012C83F
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x0012E647 File Offset: 0x0012C847
		public bool ShaderOptimization
		{
			get
			{
				return this.shaderOptimization;
			}
			set
			{
				this.SetBlendMode(this.BlendMode, value);
			}
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0012E656 File Offset: 0x0012C856
		private void OnEnable()
		{
			this.isDisabled = false;
			this.SetBlendMode(this.editorBlendMode, this.editorShaderOptimization);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0012E671 File Offset: 0x0012C871
		private void OnDisable()
		{
			this.isDisabled = true;
			this.SetBlendMode(BlendMode.Normal, false);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0012E684 File Offset: 0x0012C884
		public void SetBlendMode(BlendMode blendMode, bool shaderOptimization = false)
		{
			if (this.blendMode == blendMode && this.shaderOptimization == shaderOptimization)
			{
				return;
			}
			if (!this.source)
			{
				this.source = base.GetComponent<MaskableGraphic>();
			}
			this.source.material = BlendMaterials.GetMaterial(blendMode, this.source is Text, shaderOptimization);
			this.blendMode = blendMode;
			this.shaderOptimization = shaderOptimization;
			if (!this.isDisabled)
			{
				this.editorBlendMode = blendMode;
				this.editorShaderOptimization = shaderOptimization;
			}
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x0012E701 File Offset: 0x0012C901
		public void SyncEditor()
		{
			if (Application.isEditor && !this.isDisabled && (this.BlendMode != this.editorBlendMode || this.ShaderOptimization != this.editorShaderOptimization))
			{
				this.SetBlendMode(this.editorBlendMode, this.editorShaderOptimization);
			}
		}

		// Token: 0x0400332C RID: 13100
		[SerializeField]
		private BlendMode editorBlendMode;

		// Token: 0x0400332D RID: 13101
		private BlendMode blendMode;

		// Token: 0x0400332E RID: 13102
		[SerializeField]
		private bool editorShaderOptimization;

		// Token: 0x0400332F RID: 13103
		private bool shaderOptimization;

		// Token: 0x04003330 RID: 13104
		private MaskableGraphic source;

		// Token: 0x04003331 RID: 13105
		private bool isDisabled;
	}
}
