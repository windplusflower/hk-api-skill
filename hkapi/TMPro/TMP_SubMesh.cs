using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200060E RID: 1550
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(MeshFilter))]
	public class TMP_SubMesh : MonoBehaviour
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000BC278 File Offset: 0x000BA478
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x000BC280 File Offset: 0x000BA480
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000BC289 File Offset: 0x000BA489
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x000BC291 File Offset: 0x000BA491
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000BC29A File Offset: 0x000BA49A
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x000BC2A8 File Offset: 0x000BA4A8
		public Material material
		{
			get
			{
				return this.GetMaterial(this.m_sharedMaterial);
			}
			set
			{
				if (this.m_sharedMaterial.GetInstanceID() == value.GetInstanceID())
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000BC2F1 File Offset: 0x000BA4F1
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x000BC2F9 File Offset: 0x000BA4F9
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x000BC302 File Offset: 0x000BA502
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x000BC30C File Offset: 0x000BA50C
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000BC36D File Offset: 0x000BA56D
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x000BC375 File Offset: 0x000BA575
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000BC37E File Offset: 0x000BA57E
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x000BC386 File Offset: 0x000BA586
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000BC38F File Offset: 0x000BA58F
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000BC397 File Offset: 0x000BA597
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000BC3A0 File Offset: 0x000BA5A0
		public Renderer renderer
		{
			get
			{
				if (this.m_renderer == null)
				{
					this.m_renderer = base.GetComponent<Renderer>();
				}
				return this.m_renderer;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000BC3C2 File Offset: 0x000BA5C2
		public MeshFilter meshFilter
		{
			get
			{
				if (this.m_meshFilter == null)
				{
					this.m_meshFilter = base.GetComponent<MeshFilter>();
				}
				return this.m_meshFilter;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000BC3E4 File Offset: 0x000BA5E4
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x000BC423 File Offset: 0x000BA623
		public Mesh mesh
		{
			get
			{
				if (this.m_mesh == null)
				{
					this.m_mesh = new Mesh();
					this.m_mesh.hideFlags = HideFlags.HideAndDontSave;
					this.meshFilter.mesh = this.m_mesh;
				}
				return this.m_mesh;
			}
			set
			{
				this.m_mesh = value;
			}
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000BC42C File Offset: 0x000BA62C
		private void OnEnable()
		{
			if (!this.m_isRegisteredForEvents)
			{
				this.m_isRegisteredForEvents = true;
			}
			this.meshFilter.sharedMesh = this.mesh;
			if (this.m_sharedMaterial != null)
			{
				this.m_sharedMaterial.SetVector(ShaderUtilities.ID_ClipRect, new Vector4(-10000f, -10000f, 10000f, 10000f));
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000BC490 File Offset: 0x000BA690
		private void OnDisable()
		{
			this.m_meshFilter.sharedMesh = null;
			if (this.m_fallbackMaterial != null)
			{
				TMP_MaterialManager.ReleaseFallbackMaterial(this.m_fallbackMaterial);
				this.m_fallbackMaterial = null;
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000BC4C0 File Offset: 0x000BA6C0
		private void OnDestroy()
		{
			if (this.m_mesh != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_mesh);
			}
			if (this.m_fallbackMaterial != null)
			{
				TMP_MaterialManager.ReleaseFallbackMaterial(this.m_fallbackMaterial);
				this.m_fallbackMaterial = null;
			}
			this.m_isRegisteredForEvents = false;
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000BC510 File Offset: 0x000BA710
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
		{
			GameObject gameObject = new GameObject("TMP SubMesh [" + materialReference.material.name + "]");
			TMP_SubMesh tmp_SubMesh = gameObject.AddComponent<TMP_SubMesh>();
			gameObject.transform.SetParent(textComponent.transform, false);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			gameObject.layer = textComponent.gameObject.layer;
			tmp_SubMesh.m_meshFilter = gameObject.GetComponent<MeshFilter>();
			tmp_SubMesh.m_TextComponent = textComponent;
			tmp_SubMesh.m_fontAsset = materialReference.fontAsset;
			tmp_SubMesh.m_spriteAsset = materialReference.spriteAsset;
			tmp_SubMesh.m_isDefaultMaterial = materialReference.isDefaultMaterial;
			tmp_SubMesh.SetSharedMaterial(materialReference.material);
			tmp_SubMesh.renderer.sortingLayerID = textComponent.renderer.sortingLayerID;
			tmp_SubMesh.renderer.sortingOrder = textComponent.renderer.sortingOrder;
			LinkRendererState linkRendererState = tmp_SubMesh.gameObject.AddComponent<LinkRendererState>();
			linkRendererState.parent = textComponent.renderer;
			linkRendererState.child = tmp_SubMesh.renderer;
			return tmp_SubMesh;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000BC629 File Offset: 0x000BA829
		public void DestroySelf()
		{
			UnityEngine.Object.Destroy(base.gameObject, 1f);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000BC63C File Offset: 0x000BA83C
		private Material GetMaterial(Material mat)
		{
			if (this.m_renderer == null)
			{
				this.m_renderer = base.GetComponent<Renderer>();
			}
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

		// Token: 0x060024B1 RID: 9393 RVA: 0x000BC6BB File Offset: 0x000BA8BB
		private Material CreateMaterialInstance(Material source)
		{
			Material material = new Material(source);
			material.shaderKeywords = source.shaderKeywords;
			material.name += " (Instance)";
			return material;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000BC6E5 File Offset: 0x000BA8E5
		private Material GetSharedMaterial()
		{
			if (this.m_renderer == null)
			{
				this.m_renderer = base.GetComponent<Renderer>();
			}
			return this.m_renderer.sharedMaterial;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000BC70C File Offset: 0x000BA90C
		private void SetSharedMaterial(Material mat)
		{
			this.m_sharedMaterial = mat;
			this.m_padding = this.GetPaddingForMaterial();
			this.SetMaterialDirty();
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000BC727 File Offset: 0x000BA927
		public float GetPaddingForMaterial()
		{
			return ShaderUtilities.GetPadding(this.m_sharedMaterial, this.m_TextComponent.extraPadding, this.m_TextComponent.isUsingBold);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000BC74A File Offset: 0x000BA94A
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
			this.m_padding = ShaderUtilities.GetPadding(this.m_sharedMaterial, isExtraPadding, isUsingBold);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000BC75F File Offset: 0x000BA95F
		public void SetVerticesDirty()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.havePropertiesChanged = true;
				this.m_TextComponent.SetVerticesDirty();
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000BC78F File Offset: 0x000BA98F
		public void SetMaterialDirty()
		{
			this.UpdateMaterial();
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000BC797 File Offset: 0x000BA997
		protected void UpdateMaterial()
		{
			if (this.m_renderer == null)
			{
				this.m_renderer = this.renderer;
			}
			this.m_renderer.sharedMaterial = this.m_sharedMaterial;
		}

		// Token: 0x040028A5 RID: 10405
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		// Token: 0x040028A6 RID: 10406
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		// Token: 0x040028A7 RID: 10407
		[SerializeField]
		private Material m_material;

		// Token: 0x040028A8 RID: 10408
		[SerializeField]
		private Material m_sharedMaterial;

		// Token: 0x040028A9 RID: 10409
		private Material m_fallbackMaterial;

		// Token: 0x040028AA RID: 10410
		private Material m_fallbackSourceMaterial;

		// Token: 0x040028AB RID: 10411
		[SerializeField]
		private bool m_isDefaultMaterial;

		// Token: 0x040028AC RID: 10412
		[SerializeField]
		private float m_padding;

		// Token: 0x040028AD RID: 10413
		[SerializeField]
		private Renderer m_renderer;

		// Token: 0x040028AE RID: 10414
		[SerializeField]
		private MeshFilter m_meshFilter;

		// Token: 0x040028AF RID: 10415
		private Mesh m_mesh;

		// Token: 0x040028B0 RID: 10416
		[SerializeField]
		private TextMeshPro m_TextComponent;

		// Token: 0x040028B1 RID: 10417
		[NonSerialized]
		private bool m_isRegisteredForEvents;
	}
}
