using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005D1 RID: 1489
	[ExecuteInEditMode]
	public class InlineGraphicManager : MonoBehaviour
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000B3D63 File Offset: 0x000B1F63
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x000B3D6B File Offset: 0x000B1F6B
		public TMP_SpriteAsset spriteAsset
		{
			get
			{
				return this.m_spriteAsset;
			}
			set
			{
				this.LoadSpriteAsset(value);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000B3D74 File Offset: 0x000B1F74
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000B3D7C File Offset: 0x000B1F7C
		public InlineGraphic inlineGraphic
		{
			get
			{
				return this.m_inlineGraphic;
			}
			set
			{
				if (this.m_inlineGraphic != value)
				{
					this.m_inlineGraphic = value;
				}
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000B3D93 File Offset: 0x000B1F93
		public CanvasRenderer canvasRenderer
		{
			get
			{
				return this.m_inlineGraphicCanvasRenderer;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000B3D9B File Offset: 0x000B1F9B
		public UIVertex[] uiVertex
		{
			get
			{
				return this.m_uiVertex;
			}
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000B3DA4 File Offset: 0x000B1FA4
		private void Awake()
		{
			if (!TMP_Settings.warningsDisabled)
			{
				Debug.LogWarning("InlineGraphicManager component is now Obsolete and has been removed from [" + base.gameObject.name + "] along with its InlineGraphic child.", this);
			}
			if (this.inlineGraphic.gameObject != null)
			{
				UnityEngine.Object.DestroyImmediate(this.inlineGraphic.gameObject);
				this.inlineGraphic = null;
			}
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000835FE File Offset: 0x000817FE
		private void OnEnable()
		{
			base.enabled = false;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00003603 File Offset: 0x00001803
		private void OnDisable()
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00003603 File Offset: 0x00001803
		private void OnDestroy()
		{
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000B3E08 File Offset: 0x000B2008
		private void LoadSpriteAsset(TMP_SpriteAsset spriteAsset)
		{
			if (spriteAsset == null)
			{
				if (TMP_Settings.defaultSpriteAsset != null)
				{
					spriteAsset = TMP_Settings.defaultSpriteAsset;
				}
				else
				{
					spriteAsset = (Resources.Load("Sprite Assets/Default Sprite Asset") as TMP_SpriteAsset);
				}
			}
			this.m_spriteAsset = spriteAsset;
			this.m_inlineGraphic.texture = this.m_spriteAsset.spriteSheet;
			if (this.m_textComponent != null && this.m_isInitialized)
			{
				this.m_textComponent.havePropertiesChanged = true;
				this.m_textComponent.SetVerticesDirty();
			}
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000B3E94 File Offset: 0x000B2094
		public void AddInlineGraphicsChild()
		{
			if (this.m_inlineGraphic != null)
			{
				return;
			}
			GameObject gameObject = new GameObject("Inline Graphic");
			this.m_inlineGraphic = gameObject.AddComponent<InlineGraphic>();
			this.m_inlineGraphicRectTransform = gameObject.GetComponent<RectTransform>();
			this.m_inlineGraphicCanvasRenderer = gameObject.GetComponent<CanvasRenderer>();
			this.m_inlineGraphicRectTransform.SetParent(base.transform, false);
			this.m_inlineGraphicRectTransform.localPosition = Vector3.zero;
			this.m_inlineGraphicRectTransform.anchoredPosition3D = Vector3.zero;
			this.m_inlineGraphicRectTransform.sizeDelta = Vector2.zero;
			this.m_inlineGraphicRectTransform.anchorMin = Vector2.zero;
			this.m_inlineGraphicRectTransform.anchorMax = Vector2.one;
			this.m_textComponent = base.GetComponent<TMP_Text>();
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000B3F50 File Offset: 0x000B2150
		public void AllocatedVertexBuffers(int size)
		{
			if (this.m_inlineGraphic == null)
			{
				this.AddInlineGraphicsChild();
				this.LoadSpriteAsset(this.m_spriteAsset);
			}
			if (this.m_uiVertex == null)
			{
				this.m_uiVertex = new UIVertex[4];
			}
			int num = size * 4;
			if (num > this.m_uiVertex.Length)
			{
				this.m_uiVertex = new UIVertex[Mathf.NextPowerOfTwo(num)];
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000B3FB1 File Offset: 0x000B21B1
		public void UpdatePivot(Vector2 pivot)
		{
			if (this.m_inlineGraphicRectTransform == null)
			{
				this.m_inlineGraphicRectTransform = this.m_inlineGraphic.GetComponent<RectTransform>();
			}
			this.m_inlineGraphicRectTransform.pivot = pivot;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000B3FDE File Offset: 0x000B21DE
		public void ClearUIVertex()
		{
			if (this.uiVertex != null && this.uiVertex.Length != 0)
			{
				Array.Clear(this.uiVertex, 0, this.uiVertex.Length);
				this.m_inlineGraphicCanvasRenderer.Clear();
			}
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000B4010 File Offset: 0x000B2210
		public void DrawSprite(UIVertex[] uiVertices, int spriteCount)
		{
			if (this.m_inlineGraphicCanvasRenderer == null)
			{
				this.m_inlineGraphicCanvasRenderer = this.m_inlineGraphic.GetComponent<CanvasRenderer>();
			}
			this.m_inlineGraphicCanvasRenderer.SetVertices(uiVertices, spriteCount * 4);
			this.m_inlineGraphic.UpdateMaterial();
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000B404C File Offset: 0x000B224C
		public TMP_Sprite GetSprite(int index)
		{
			if (this.m_spriteAsset == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return null;
			}
			if (this.m_spriteAsset.spriteInfoList == null || index > this.m_spriteAsset.spriteInfoList.Count - 1)
			{
				Debug.LogWarning("Sprite index exceeds the number of sprites in this Sprite Asset.", this);
				return null;
			}
			return this.m_spriteAsset.spriteInfoList[index];
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000B40B4 File Offset: 0x000B22B4
		public int GetSpriteIndexByHashCode(int hashCode)
		{
			if (this.m_spriteAsset == null || this.m_spriteAsset.spriteInfoList == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return -1;
			}
			return this.m_spriteAsset.spriteInfoList.FindIndex((TMP_Sprite item) => item.hashCode == hashCode);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000B4114 File Offset: 0x000B2314
		public int GetSpriteIndexByIndex(int index)
		{
			if (this.m_spriteAsset == null || this.m_spriteAsset.spriteInfoList == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return -1;
			}
			return this.m_spriteAsset.spriteInfoList.FindIndex((TMP_Sprite item) => item.id == index);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000B4172 File Offset: 0x000B2372
		public void SetUIVertex(UIVertex[] uiVertex)
		{
			this.m_uiVertex = uiVertex;
		}

		// Token: 0x04002766 RID: 10086
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		// Token: 0x04002767 RID: 10087
		[SerializeField]
		[HideInInspector]
		private InlineGraphic m_inlineGraphic;

		// Token: 0x04002768 RID: 10088
		[SerializeField]
		[HideInInspector]
		private CanvasRenderer m_inlineGraphicCanvasRenderer;

		// Token: 0x04002769 RID: 10089
		private UIVertex[] m_uiVertex;

		// Token: 0x0400276A RID: 10090
		private RectTransform m_inlineGraphicRectTransform;

		// Token: 0x0400276B RID: 10091
		private TMP_Text m_textComponent;

		// Token: 0x0400276C RID: 10092
		private bool m_isInitialized;
	}
}
