using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x02000647 RID: 1607
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Text Container")]
	public class TextContainer : UIBehaviour
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000DA389 File Offset: 0x000D8589
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x000DA391 File Offset: 0x000D8591
		public bool hasChanged
		{
			get
			{
				return this.m_hasChanged;
			}
			set
			{
				this.m_hasChanged = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000DA39A File Offset: 0x000D859A
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x000DA3A2 File Offset: 0x000D85A2
		public Vector2 pivot
		{
			get
			{
				return this.m_pivot;
			}
			set
			{
				if (this.m_pivot != value)
				{
					this.m_pivot = value;
					this.m_anchorPosition = this.GetAnchorPosition(this.m_pivot);
					this.m_hasChanged = true;
					this.OnContainerChanged();
				}
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000DA3D8 File Offset: 0x000D85D8
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x000DA3E0 File Offset: 0x000D85E0
		public TextContainerAnchors anchorPosition
		{
			get
			{
				return this.m_anchorPosition;
			}
			set
			{
				if (this.m_anchorPosition != value)
				{
					this.m_anchorPosition = value;
					this.m_pivot = this.GetPivot(this.m_anchorPosition);
					this.m_hasChanged = true;
					this.OnContainerChanged();
				}
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000DA411 File Offset: 0x000D8611
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x000DA419 File Offset: 0x000D8619
		public Rect rect
		{
			get
			{
				return this.m_rect;
			}
			set
			{
				if (this.m_rect != value)
				{
					this.m_rect = value;
					this.m_hasChanged = true;
					this.OnContainerChanged();
				}
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x000DA43D File Offset: 0x000D863D
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x000DA45C File Offset: 0x000D865C
		public Vector2 size
		{
			get
			{
				return new Vector2(this.m_rect.width, this.m_rect.height);
			}
			set
			{
				if (new Vector2(this.m_rect.width, this.m_rect.height) != value)
				{
					this.SetRect(value);
					this.m_hasChanged = true;
					this.m_isDefaultWidth = false;
					this.m_isDefaultHeight = false;
					this.OnContainerChanged();
				}
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x000DA4AE File Offset: 0x000D86AE
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x000DA4BB File Offset: 0x000D86BB
		public float width
		{
			get
			{
				return this.m_rect.width;
			}
			set
			{
				this.SetRect(new Vector2(value, this.m_rect.height));
				this.m_hasChanged = true;
				this.m_isDefaultWidth = false;
				this.OnContainerChanged();
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x000DA4E8 File Offset: 0x000D86E8
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x000DA4F5 File Offset: 0x000D86F5
		public float height
		{
			get
			{
				return this.m_rect.height;
			}
			set
			{
				this.SetRect(new Vector2(this.m_rect.width, value));
				this.m_hasChanged = true;
				this.m_isDefaultHeight = false;
				this.OnContainerChanged();
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000DA522 File Offset: 0x000D8722
		public bool isDefaultWidth
		{
			get
			{
				return this.m_isDefaultWidth;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000DA52A File Offset: 0x000D872A
		public bool isDefaultHeight
		{
			get
			{
				return this.m_isDefaultHeight;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000DA532 File Offset: 0x000D8732
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x000DA53A File Offset: 0x000D873A
		public bool isAutoFitting
		{
			get
			{
				return this.m_isAutoFitting;
			}
			set
			{
				this.m_isAutoFitting = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000DA543 File Offset: 0x000D8743
		public Vector3[] corners
		{
			get
			{
				return this.m_corners;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000DA54B File Offset: 0x000D874B
		public Vector3[] worldCorners
		{
			get
			{
				return this.m_worldCorners;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000DA553 File Offset: 0x000D8753
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x000DA55B File Offset: 0x000D875B
		public Vector4 margins
		{
			get
			{
				return this.m_margins;
			}
			set
			{
				if (this.m_margins != value)
				{
					this.m_margins = value;
					this.m_hasChanged = true;
					this.OnContainerChanged();
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000DA57F File Offset: 0x000D877F
		public RectTransform rectTransform
		{
			get
			{
				if (this.m_rectTransform == null)
				{
					this.m_rectTransform = base.GetComponent<RectTransform>();
				}
				return this.m_rectTransform;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000DA5A1 File Offset: 0x000D87A1
		public TextMeshPro textMeshPro
		{
			get
			{
				if (this.m_textMeshPro == null)
				{
					this.m_textMeshPro = base.GetComponent<TextMeshPro>();
				}
				return this.m_textMeshPro;
			}
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000DA5C4 File Offset: 0x000D87C4
		protected override void Awake()
		{
			this.m_rectTransform = this.rectTransform;
			if (this.m_rectTransform == null)
			{
				Vector2 pivot = this.m_pivot;
				this.m_rectTransform = base.gameObject.AddComponent<RectTransform>();
				this.m_pivot = pivot;
			}
			this.m_textMeshPro = (base.GetComponent(typeof(TextMeshPro)) as TextMeshPro);
			if (this.m_rect.width == 0f || this.m_rect.height == 0f)
			{
				if (this.m_textMeshPro != null && this.m_textMeshPro.anchor != TMP_Compatibility.AnchorPositions.None)
				{
					Debug.LogWarning("Converting from using anchor and lineLength properties to Text Container.", this);
					this.m_isDefaultHeight = true;
					int num = (int)this.m_textMeshPro.anchor;
					this.m_textMeshPro.anchor = TMP_Compatibility.AnchorPositions.None;
					if (num == 9)
					{
						switch (this.m_textMeshPro.alignment)
						{
						case TextAlignmentOptions.TopLeft:
							this.m_textMeshPro.alignment = TextAlignmentOptions.BaselineLeft;
							break;
						case TextAlignmentOptions.Top:
							this.m_textMeshPro.alignment = TextAlignmentOptions.Baseline;
							break;
						case TextAlignmentOptions.TopRight:
							this.m_textMeshPro.alignment = TextAlignmentOptions.BaselineRight;
							break;
						case TextAlignmentOptions.TopJustified:
							this.m_textMeshPro.alignment = TextAlignmentOptions.BaselineJustified;
							break;
						}
						num = 3;
					}
					this.m_anchorPosition = (TextContainerAnchors)num;
					this.m_pivot = this.GetPivot(this.m_anchorPosition);
					if (this.m_textMeshPro.lineLength == 72f)
					{
						this.m_rect.size = this.m_textMeshPro.GetPreferredValues(this.m_textMeshPro.text);
					}
					else
					{
						this.m_rect.width = this.m_textMeshPro.lineLength;
						this.m_rect.height = this.m_textMeshPro.GetPreferredValues(this.m_rect.width, float.PositiveInfinity).y;
					}
				}
				else
				{
					this.m_isDefaultWidth = true;
					this.m_isDefaultHeight = true;
					this.m_pivot = this.GetPivot(this.m_anchorPosition);
					this.m_rect.width = 20f;
					this.m_rect.height = 5f;
					this.m_rectTransform.sizeDelta = this.size;
				}
				this.m_margins = new Vector4(0f, 0f, 0f, 0f);
				this.UpdateCorners();
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000DA809 File Offset: 0x000D8A09
		protected override void OnEnable()
		{
			this.OnContainerChanged();
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00003603 File Offset: 0x00001803
		protected override void OnDisable()
		{
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000DA814 File Offset: 0x000D8A14
		private void OnContainerChanged()
		{
			this.UpdateCorners();
			if (this.m_rectTransform != null)
			{
				this.m_rectTransform.sizeDelta = this.size;
				this.m_rectTransform.hasChanged = true;
			}
			if (this.textMeshPro != null)
			{
				this.m_textMeshPro.SetVerticesDirty();
				this.m_textMeshPro.margin = this.m_margins;
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000DA87C File Offset: 0x000D8A7C
		protected override void OnRectTransformDimensionsChange()
		{
			if (this.rectTransform == null)
			{
				this.m_rectTransform = base.gameObject.AddComponent<RectTransform>();
			}
			if (this.m_rectTransform.sizeDelta != TextContainer.k_defaultSize)
			{
				this.size = this.m_rectTransform.sizeDelta;
			}
			this.pivot = this.m_rectTransform.pivot;
			this.m_hasChanged = true;
			this.OnContainerChanged();
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000DA8EE File Offset: 0x000D8AEE
		private void SetRect(Vector2 size)
		{
			this.m_rect = new Rect(this.m_rect.x, this.m_rect.y, size.x, size.y);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000DA920 File Offset: 0x000D8B20
		private void UpdateCorners()
		{
			this.m_corners[0] = new Vector3(-this.m_pivot.x * this.m_rect.width, -this.m_pivot.y * this.m_rect.height);
			this.m_corners[1] = new Vector3(-this.m_pivot.x * this.m_rect.width, (1f - this.m_pivot.y) * this.m_rect.height);
			this.m_corners[2] = new Vector3((1f - this.m_pivot.x) * this.m_rect.width, (1f - this.m_pivot.y) * this.m_rect.height);
			this.m_corners[3] = new Vector3((1f - this.m_pivot.x) * this.m_rect.width, -this.m_pivot.y * this.m_rect.height);
			if (this.m_rectTransform != null)
			{
				this.m_rectTransform.pivot = this.m_pivot;
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000DAA64 File Offset: 0x000D8C64
		private Vector2 GetPivot(TextContainerAnchors anchor)
		{
			Vector2 zero = Vector2.zero;
			switch (anchor)
			{
			case TextContainerAnchors.TopLeft:
				zero = new Vector2(0f, 1f);
				break;
			case TextContainerAnchors.Top:
				zero = new Vector2(0.5f, 1f);
				break;
			case TextContainerAnchors.TopRight:
				zero = new Vector2(1f, 1f);
				break;
			case TextContainerAnchors.Left:
				zero = new Vector2(0f, 0.5f);
				break;
			case TextContainerAnchors.Middle:
				zero = new Vector2(0.5f, 0.5f);
				break;
			case TextContainerAnchors.Right:
				zero = new Vector2(1f, 0.5f);
				break;
			case TextContainerAnchors.BottomLeft:
				zero = new Vector2(0f, 0f);
				break;
			case TextContainerAnchors.Bottom:
				zero = new Vector2(0.5f, 0f);
				break;
			case TextContainerAnchors.BottomRight:
				zero = new Vector2(1f, 0f);
				break;
			}
			return zero;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000DAB58 File Offset: 0x000D8D58
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			if (pivot == new Vector2(0f, 1f))
			{
				return TextContainerAnchors.TopLeft;
			}
			if (pivot == new Vector2(0.5f, 1f))
			{
				return TextContainerAnchors.Top;
			}
			if (pivot == new Vector2(1f, 1f))
			{
				return TextContainerAnchors.TopRight;
			}
			if (pivot == new Vector2(0f, 0.5f))
			{
				return TextContainerAnchors.Left;
			}
			if (pivot == new Vector2(0.5f, 0.5f))
			{
				return TextContainerAnchors.Middle;
			}
			if (pivot == new Vector2(1f, 0.5f))
			{
				return TextContainerAnchors.Right;
			}
			if (pivot == new Vector2(0f, 0f))
			{
				return TextContainerAnchors.BottomLeft;
			}
			if (pivot == new Vector2(0.5f, 0f))
			{
				return TextContainerAnchors.Bottom;
			}
			if (pivot == new Vector2(1f, 0f))
			{
				return TextContainerAnchors.BottomRight;
			}
			return TextContainerAnchors.Custom;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000DAC48 File Offset: 0x000D8E48
		public TextContainer()
		{
			this.m_anchorPosition = TextContainerAnchors.Middle;
			this.m_corners = new Vector3[4];
			this.m_worldCorners = new Vector3[4];
			base..ctor();
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000DAC6F File Offset: 0x000D8E6F
		// Note: this type is marked as 'beforefieldinit'.
		static TextContainer()
		{
			TextContainer.k_defaultSize = new Vector2(100f, 100f);
		}

		// Token: 0x04002B34 RID: 11060
		private bool m_hasChanged;

		// Token: 0x04002B35 RID: 11061
		[SerializeField]
		private Vector2 m_pivot;

		// Token: 0x04002B36 RID: 11062
		[SerializeField]
		private TextContainerAnchors m_anchorPosition;

		// Token: 0x04002B37 RID: 11063
		[SerializeField]
		private Rect m_rect;

		// Token: 0x04002B38 RID: 11064
		private bool m_isDefaultWidth;

		// Token: 0x04002B39 RID: 11065
		private bool m_isDefaultHeight;

		// Token: 0x04002B3A RID: 11066
		private bool m_isAutoFitting;

		// Token: 0x04002B3B RID: 11067
		private Vector3[] m_corners;

		// Token: 0x04002B3C RID: 11068
		private Vector3[] m_worldCorners;

		// Token: 0x04002B3D RID: 11069
		[SerializeField]
		private Vector4 m_margins;

		// Token: 0x04002B3E RID: 11070
		private RectTransform m_rectTransform;

		// Token: 0x04002B3F RID: 11071
		private static Vector2 k_defaultSize;

		// Token: 0x04002B40 RID: 11072
		private TextMeshPro m_textMeshPro;
	}
}
