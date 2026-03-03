using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200060F RID: 1551
	[ExecuteInEditMode]
	public class TMP_SubMeshUI : MaskableGraphic, ITextElement, IClippable, IMaskable, IMaterialModifier
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000BC7C4 File Offset: 0x000BA9C4
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x000BC7CC File Offset: 0x000BA9CC
		public TMP_FontAsset fontAsset
		{
			get
			{
				return this.m_fontAsset;
			}
			set
			{
				this.m_fontAsset = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000BC7D5 File Offset: 0x000BA9D5
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x000BC7DD File Offset: 0x000BA9DD
		public TMP_SpriteAsset spriteAsset
		{
			get
			{
				return this.m_spriteAsset;
			}
			set
			{
				this.m_spriteAsset = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000BC7E6 File Offset: 0x000BA9E6
		public override Texture mainTexture
		{
			get
			{
				if (this.sharedMaterial != null)
				{
					return this.sharedMaterial.mainTexture;
				}
				return null;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000BC803 File Offset: 0x000BAA03
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000BC814 File Offset: 0x000BAA14
		public override Material material
		{
			get
			{
				return this.GetMaterial(this.m_sharedMaterial);
			}
			set
			{
				if (this.m_sharedMaterial != null && this.m_sharedMaterial.GetInstanceID() == value.GetInstanceID())
				{
					return;
				}
				this.m_material = value;
				this.m_sharedMaterial = value;
				this.m_padding = this.GetPaddingForMaterial();
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000BC86B File Offset: 0x000BAA6B
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000BC873 File Offset: 0x000BAA73
		public Material sharedMaterial
		{
			get
			{
				return this.m_sharedMaterial;
			}
			set
			{
				this.SetSharedMaterial(value);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000BC87C File Offset: 0x000BAA7C
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x000BC884 File Offset: 0x000BAA84
		public Material fallbackMaterial
		{
			get
			{
				return this.m_fallbackMaterial;
			}
			set
			{
				if (this.m_fallbackMaterial == value)
				{
					return;
				}
				if (this.m_fallbackMaterial != null && this.m_fallbackMaterial != value)
				{
					TMP_MaterialManager.ReleaseFallbackMaterial(this.m_fallbackMaterial);
				}
				this.m_fallbackMaterial = value;
				TMP_MaterialManager.AddFallbackMaterialReference(this.m_fallbackMaterial);
				this.SetSharedMaterial(this.m_fallbackMaterial);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x000BC8E5 File Offset: 0x000BAAE5
		// (set) Token: 0x060024C6 RID: 9414 RVA: 0x000BC8ED File Offset: 0x000BAAED
		public Material fallbackSourceMaterial
		{
			get
			{
				return this.m_fallbackSourceMaterial;
			}
			set
			{
				this.m_fallbackSourceMaterial = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x000BC8F6 File Offset: 0x000BAAF6
		public override Material materialForRendering
		{
			get
			{
				if (this.m_sharedMaterial == null)
				{
					return null;
				}
				return this.GetModifiedMaterial(this.m_sharedMaterial);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000BC914 File Offset: 0x000BAB14
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x000BC91C File Offset: 0x000BAB1C
		public bool isDefaultMaterial
		{
			get
			{
				return this.m_isDefaultMaterial;
			}
			set
			{
				this.m_isDefaultMaterial = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000BC925 File Offset: 0x000BAB25
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x000BC92D File Offset: 0x000BAB2D
		public float padding
		{
			get
			{
				return this.m_padding;
			}
			set
			{
				this.m_padding = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000BC936 File Offset: 0x000BAB36
		public new CanvasRenderer canvasRenderer
		{
			get
			{
				if (this.m_canvasRenderer == null)
				{
					this.m_canvasRenderer = base.GetComponent<CanvasRenderer>();
				}
				return this.m_canvasRenderer;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x000BC958 File Offset: 0x000BAB58
		// (set) Token: 0x060024CE RID: 9422 RVA: 0x000BC986 File Offset: 0x000BAB86
		public Mesh mesh
		{
			get
			{
				if (this.m_mesh == null)
				{
					this.m_mesh = new Mesh();
					this.m_mesh.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.m_mesh;
			}
			set
			{
				this.m_mesh = value;
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000BC990 File Offset: 0x000BAB90
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			GameObject gameObject = new GameObject("TMP UI SubObject [" + materialReference.material.name + "]");
			gameObject.transform.SetParent(textComponent.transform, false);
			gameObject.layer = textComponent.gameObject.layer;
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.anchorMin = Vector2.zero;
			rectTransform.anchorMax = Vector2.one;
			rectTransform.sizeDelta = Vector2.zero;
			rectTransform.pivot = textComponent.rectTransform.pivot;
			TMP_SubMeshUI tmp_SubMeshUI = gameObject.AddComponent<TMP_SubMeshUI>();
			tmp_SubMeshUI.m_canvasRenderer = tmp_SubMeshUI.canvasRenderer;
			tmp_SubMeshUI.m_TextComponent = textComponent;
			tmp_SubMeshUI.m_materialReferenceIndex = materialReference.index;
			tmp_SubMeshUI.m_fontAsset = materialReference.fontAsset;
			tmp_SubMeshUI.m_spriteAsset = materialReference.spriteAsset;
			tmp_SubMeshUI.m_isDefaultMaterial = materialReference.isDefaultMaterial;
			tmp_SubMeshUI.SetSharedMaterial(materialReference.material);
			return tmp_SubMeshUI;
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000BCA6A File Offset: 0x000BAC6A
		protected override void OnEnable()
		{
			if (!this.m_isRegisteredForEvents)
			{
				this.m_isRegisteredForEvents = true;
			}
			this.m_ShouldRecalculateStencil = true;
			this.RecalculateClipping();
			this.RecalculateMasking();
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000BCA90 File Offset: 0x000BAC90
		protected override void OnDisable()
		{
			TMP_UpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_MaskMaterial != null)
			{
				TMP_MaterialManager.ReleaseStencilMaterial(this.m_MaskMaterial);
				this.m_MaskMaterial = null;
			}
			if (this.m_fallbackMaterial != null)
			{
				TMP_MaterialManager.ReleaseFallbackMaterial(this.m_fallbackMaterial);
				this.m_fallbackMaterial = null;
			}
			base.OnDisable();
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000BCAEC File Offset: 0x000BACEC
		protected override void OnDestroy()
		{
			if (this.m_mesh != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_mesh);
			}
			if (this.m_MaskMaterial != null)
			{
				TMP_MaterialManager.ReleaseStencilMaterial(this.m_MaskMaterial);
			}
			if (this.m_fallbackMaterial != null)
			{
				TMP_MaterialManager.ReleaseFallbackMaterial(this.m_fallbackMaterial);
				this.m_fallbackMaterial = null;
			}
			this.m_isRegisteredForEvents = false;
			this.RecalculateClipping();
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000BCB58 File Offset: 0x000BAD58
		protected override void OnTransformParentChanged()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.m_ShouldRecalculateStencil = true;
			this.RecalculateClipping();
			this.RecalculateMasking();
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000BCB78 File Offset: 0x000BAD78
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			Material material = baseMaterial;
			if (this.m_ShouldRecalculateStencil)
			{
				this.m_StencilValue = TMP_MaterialManager.GetStencilID(base.gameObject);
				this.m_ShouldRecalculateStencil = false;
			}
			if (this.m_StencilValue > 0)
			{
				material = TMP_MaterialManager.GetStencilMaterial(baseMaterial, this.m_StencilValue);
				if (this.m_MaskMaterial != null)
				{
					TMP_MaterialManager.ReleaseStencilMaterial(this.m_MaskMaterial);
				}
				this.m_MaskMaterial = material;
			}
			return material;
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000BCBDE File Offset: 0x000BADDE
		public float GetPaddingForMaterial()
		{
			return ShaderUtilities.GetPadding(this.m_sharedMaterial, this.m_TextComponent.extraPadding, this.m_TextComponent.isUsingBold);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000BCC01 File Offset: 0x000BAE01
		public float GetPaddingForMaterial(Material mat)
		{
			return ShaderUtilities.GetPadding(mat, this.m_TextComponent.extraPadding, this.m_TextComponent.isUsingBold);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000BCC1F File Offset: 0x000BAE1F
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
			this.m_padding = ShaderUtilities.GetPadding(this.m_sharedMaterial, isExtraPadding, isUsingBold);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00003603 File Offset: 0x00001803
		public override void SetAllDirty()
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000BCC34 File Offset: 0x000BAE34
		public override void SetVerticesDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.havePropertiesChanged = true;
				this.m_TextComponent.SetVerticesDirty();
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00003603 File Offset: 0x00001803
		public override void SetLayoutDirty()
		{
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000BCC64 File Offset: 0x000BAE64
		public override void SetMaterialDirty()
		{
			this.m_materialDirty = true;
			this.UpdateMaterial();
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000BCC73 File Offset: 0x000BAE73
		public void SetPivotDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			base.rectTransform.pivot = this.m_TextComponent.rectTransform.pivot;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00003603 File Offset: 0x00001803
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000BCC99 File Offset: 0x000BAE99
		public override void Rebuild(CanvasUpdate update)
		{
			if (update == CanvasUpdate.PreRender)
			{
				if (!this.m_materialDirty)
				{
					return;
				}
				this.UpdateMaterial();
				this.m_materialDirty = false;
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000BCCB5 File Offset: 0x000BAEB5
		public void RefreshMaterial()
		{
			this.UpdateMaterial();
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000BCCC0 File Offset: 0x000BAEC0
		protected override void UpdateMaterial()
		{
			if (this.m_canvasRenderer == null)
			{
				this.m_canvasRenderer = this.canvasRenderer;
			}
			this.m_canvasRenderer.materialCount = 1;
			this.m_canvasRenderer.SetMaterial(this.materialForRendering, 0);
			this.m_canvasRenderer.SetTexture(this.mainTexture);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000BCD16 File Offset: 0x000BAF16
		public override void RecalculateClipping()
		{
			base.RecalculateClipping();
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000BCD1E File Offset: 0x000BAF1E
		public override void RecalculateMasking()
		{
			this.m_ShouldRecalculateStencil = true;
			this.SetMaterialDirty();
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000BC86B File Offset: 0x000BAA6B
		private Material GetMaterial()
		{
			return this.m_sharedMaterial;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000BCD30 File Offset: 0x000BAF30
		private Material GetMaterial(Material mat)
		{
			if (this.m_material == null || this.m_material.GetInstanceID() != mat.GetInstanceID())
			{
				this.m_material = this.CreateMaterialInstance(mat);
			}
			this.m_sharedMaterial = this.m_material;
			this.m_padding = this.GetPaddingForMaterial();
			this.SetVerticesDirty();
			this.SetMaterialDirty();
			return this.m_sharedMaterial;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000BC6BB File Offset: 0x000BA8BB
		private Material CreateMaterialInstance(Material source)
		{
			Material material = new Material(source);
			material.shaderKeywords = source.shaderKeywords;
			material.name += " (Instance)";
			return material;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x000BCD95 File Offset: 0x000BAF95
		private Material GetSharedMaterial()
		{
			if (this.m_canvasRenderer == null)
			{
				this.m_canvasRenderer = base.GetComponent<CanvasRenderer>();
			}
			return this.m_canvasRenderer.GetMaterial();
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000BCDBC File Offset: 0x000BAFBC
		private void SetSharedMaterial(Material mat)
		{
			this.m_sharedMaterial = mat;
			this.m_Material = this.m_sharedMaterial;
			this.m_padding = this.GetPaddingForMaterial();
			this.SetMaterialDirty();
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000BCDE3 File Offset: 0x000BAFE3
		int ITextElement.GetInstanceID()
		{
			return base.GetInstanceID();
		}

		// Token: 0x040028B2 RID: 10418
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		// Token: 0x040028B3 RID: 10419
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		// Token: 0x040028B4 RID: 10420
		[SerializeField]
		private Material m_material;

		// Token: 0x040028B5 RID: 10421
		[SerializeField]
		private Material m_sharedMaterial;

		// Token: 0x040028B6 RID: 10422
		private Material m_fallbackMaterial;

		// Token: 0x040028B7 RID: 10423
		private Material m_fallbackSourceMaterial;

		// Token: 0x040028B8 RID: 10424
		[SerializeField]
		private bool m_isDefaultMaterial;

		// Token: 0x040028B9 RID: 10425
		[SerializeField]
		private float m_padding;

		// Token: 0x040028BA RID: 10426
		[SerializeField]
		private CanvasRenderer m_canvasRenderer;

		// Token: 0x040028BB RID: 10427
		private Mesh m_mesh;

		// Token: 0x040028BC RID: 10428
		[SerializeField]
		private TextMeshProUGUI m_TextComponent;

		// Token: 0x040028BD RID: 10429
		[NonSerialized]
		private bool m_isRegisteredForEvents;

		// Token: 0x040028BE RID: 10430
		private bool m_materialDirty;

		// Token: 0x040028BF RID: 10431
		[SerializeField]
		private int m_materialReferenceIndex;
	}
}
