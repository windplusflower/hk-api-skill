using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x020005D0 RID: 1488
	public class InlineGraphic : MaskableGraphic
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000B3C39 File Offset: 0x000B1E39
		public override Texture mainTexture
		{
			get
			{
				if (this.texture == null)
				{
					return Graphic.s_WhiteTexture;
				}
				return this.texture;
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x000B3C55 File Offset: 0x000B1E55
		protected override void Awake()
		{
			this.m_manager = base.GetComponentInParent<InlineGraphicManager>();
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000B3C64 File Offset: 0x000B1E64
		protected override void OnEnable()
		{
			if (this.m_RectTransform == null)
			{
				this.m_RectTransform = base.gameObject.GetComponent<RectTransform>();
			}
			if (this.m_manager != null && this.m_manager.spriteAsset != null)
			{
				this.texture = this.m_manager.spriteAsset.spriteSheet;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000B3CC7 File Offset: 0x000B1EC7
		protected override void OnDisable()
		{
			base.OnDisable();
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00003603 File Offset: 0x00001803
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		protected override void OnRectTransformDimensionsChange()
		{
			if (this.m_RectTransform == null)
			{
				this.m_RectTransform = base.gameObject.GetComponent<RectTransform>();
			}
			if (this.m_ParentRectTransform == null)
			{
				this.m_ParentRectTransform = this.m_RectTransform.parent.GetComponent<RectTransform>();
			}
			if (this.m_RectTransform.pivot != this.m_ParentRectTransform.pivot)
			{
				this.m_RectTransform.pivot = this.m_ParentRectTransform.pivot;
			}
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000B3D53 File Offset: 0x000B1F53
		public new void UpdateMaterial()
		{
			base.UpdateMaterial();
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00003603 File Offset: 0x00001803
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x04002762 RID: 10082
		public Texture texture;

		// Token: 0x04002763 RID: 10083
		private InlineGraphicManager m_manager;

		// Token: 0x04002764 RID: 10084
		private RectTransform m_RectTransform;

		// Token: 0x04002765 RID: 10085
		private RectTransform m_ParentRectTransform;
	}
}
