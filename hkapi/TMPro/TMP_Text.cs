using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200061C RID: 1564
	public class TMP_Text : MaskableGraphic
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000BCDEB File Offset: 0x000BAFEB
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x000BCDF3 File Offset: 0x000BAFF3
		public string text
		{
			get
			{
				return this.m_text;
			}
			set
			{
				if (this.m_text == value)
				{
					return;
				}
				this.m_text = value;
				this.m_inputSource = TMP_Text.TextInputSources.String;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000BCE33 File Offset: 0x000BB033
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x000BCE3B File Offset: 0x000BB03B
		public bool isRightToLeftText
		{
			get
			{
				return this.m_isRightToLeft;
			}
			set
			{
				if (this.m_isRightToLeft == value)
				{
					return;
				}
				this.m_isRightToLeft = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000BCE6F File Offset: 0x000BB06F
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x000BCE77 File Offset: 0x000BB077
		public TMP_FontAsset font
		{
			get
			{
				return this.m_fontAsset;
			}
			set
			{
				if (this.m_fontAsset == value)
				{
					return;
				}
				this.m_fontAsset = value;
				this.LoadFontAsset();
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000BCEB6 File Offset: 0x000BB0B6
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x000BCEBE File Offset: 0x000BB0BE
		public virtual Material fontSharedMaterial
		{
			get
			{
				return this.m_sharedMaterial;
			}
			set
			{
				if (this.m_sharedMaterial == value)
				{
					return;
				}
				this.SetSharedMaterial(value);
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000BCEF0 File Offset: 0x000BB0F0
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x000BCEF8 File Offset: 0x000BB0F8
		public virtual Material[] fontSharedMaterials
		{
			get
			{
				return this.GetSharedMaterials();
			}
			set
			{
				this.SetSharedMaterials(value);
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000BCF1B File Offset: 0x000BB11B
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x000BCF2C File Offset: 0x000BB12C
		public Material fontMaterial
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
				this.m_sharedMaterial = value;
				this.m_padding = this.GetPaddingForMaterial();
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000BCF88 File Offset: 0x000BB188
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x000BCEF8 File Offset: 0x000BB0F8
		public virtual Material[] fontMaterials
		{
			get
			{
				return this.GetMaterials(this.m_fontSharedMaterials);
			}
			set
			{
				this.SetSharedMaterials(value);
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000BCF96 File Offset: 0x000BB196
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x000BCF9E File Offset: 0x000BB19E
		public override Color color
		{
			get
			{
				return this.m_fontColor;
			}
			set
			{
				if (this.m_fontColor == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_fontColor = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000BCFC3 File Offset: 0x000BB1C3
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x000BCFD0 File Offset: 0x000BB1D0
		public float alpha
		{
			get
			{
				return this.m_fontColor.a;
			}
			set
			{
				if (this.m_fontColor.a == value)
				{
					return;
				}
				this.m_fontColor.a = value;
				this.m_havePropertiesChanged = true;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000BCFFA File Offset: 0x000BB1FA
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x000BD002 File Offset: 0x000BB202
		public bool enableVertexGradient
		{
			get
			{
				return this.m_enableVertexGradient;
			}
			set
			{
				if (this.m_enableVertexGradient == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_enableVertexGradient = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000BD022 File Offset: 0x000BB222
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x000BD02A File Offset: 0x000BB22A
		public VertexGradient colorGradient
		{
			get
			{
				return this.m_fontColorGradient;
			}
			set
			{
				this.m_havePropertiesChanged = true;
				this.m_fontColorGradient = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000BD040 File Offset: 0x000BB240
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x000BD048 File Offset: 0x000BB248
		public TMP_ColorGradient colorGradientPreset
		{
			get
			{
				return this.m_fontColorGradientPreset;
			}
			set
			{
				this.m_havePropertiesChanged = true;
				this.m_fontColorGradientPreset = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000BD05E File Offset: 0x000BB25E
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x000BD066 File Offset: 0x000BB266
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x000BD06F File Offset: 0x000BB26F
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x000BD077 File Offset: 0x000BB277
		public bool tintAllSprites
		{
			get
			{
				return this.m_tintAllSprites;
			}
			set
			{
				if (this.m_tintAllSprites == value)
				{
					return;
				}
				this.m_tintAllSprites = value;
				this.m_havePropertiesChanged = true;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000BD097 File Offset: 0x000BB297
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x000BD09F File Offset: 0x000BB29F
		public bool overrideColorTags
		{
			get
			{
				return this.m_overrideHtmlColors;
			}
			set
			{
				if (this.m_overrideHtmlColors == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_overrideHtmlColors = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000BD0BF File Offset: 0x000BB2BF
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x000BD0F7 File Offset: 0x000BB2F7
		public Color32 faceColor
		{
			get
			{
				if (this.m_sharedMaterial == null)
				{
					return this.m_faceColor;
				}
				this.m_faceColor = this.m_sharedMaterial.GetColor(ShaderUtilities.ID_FaceColor);
				return this.m_faceColor;
			}
			set
			{
				if (this.m_faceColor.Compare(value))
				{
					return;
				}
				this.SetFaceColor(value);
				this.m_havePropertiesChanged = true;
				this.m_faceColor = value;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000BD129 File Offset: 0x000BB329
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x000BD161 File Offset: 0x000BB361
		public Color32 outlineColor
		{
			get
			{
				if (this.m_sharedMaterial == null)
				{
					return this.m_outlineColor;
				}
				this.m_outlineColor = this.m_sharedMaterial.GetColor(ShaderUtilities.ID_OutlineColor);
				return this.m_outlineColor;
			}
			set
			{
				if (this.m_outlineColor.Compare(value))
				{
					return;
				}
				this.SetOutlineColor(value);
				this.m_havePropertiesChanged = true;
				this.m_outlineColor = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000BD18D File Offset: 0x000BB38D
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x000BD1C0 File Offset: 0x000BB3C0
		public float outlineWidth
		{
			get
			{
				if (this.m_sharedMaterial == null)
				{
					return this.m_outlineWidth;
				}
				this.m_outlineWidth = this.m_sharedMaterial.GetFloat(ShaderUtilities.ID_OutlineWidth);
				return this.m_outlineWidth;
			}
			set
			{
				if (this.m_outlineWidth == value)
				{
					return;
				}
				this.SetOutlineThickness(value);
				this.m_havePropertiesChanged = true;
				this.m_outlineWidth = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000BD1E7 File Offset: 0x000BB3E7
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x000BD1F0 File Offset: 0x000BB3F0
		public float fontSize
		{
			get
			{
				return this.m_fontSize;
			}
			set
			{
				if (this.m_fontSize == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_fontSize = value;
				if (!this.m_enableAutoSizing)
				{
					this.m_fontSizeBase = this.m_fontSize;
				}
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000BD23C File Offset: 0x000BB43C
		public float fontScale
		{
			get
			{
				return this.m_fontScale;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000BD244 File Offset: 0x000BB444
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000BD24C File Offset: 0x000BB44C
		public int fontWeight
		{
			get
			{
				return this.m_fontWeight;
			}
			set
			{
				if (this.m_fontWeight == value)
				{
					return;
				}
				this.m_fontWeight = value;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000BD274 File Offset: 0x000BB474
		public float pixelsPerUnit
		{
			get
			{
				Canvas canvas = base.canvas;
				if (!canvas)
				{
					return 1f;
				}
				if (!this.font)
				{
					return canvas.scaleFactor;
				}
				if (this.m_currentFontAsset == null || this.m_currentFontAsset.fontInfo.PointSize <= 0f || this.m_fontSize <= 0f)
				{
					return 1f;
				}
				return this.m_fontSize / this.m_currentFontAsset.fontInfo.PointSize;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000BD2F9 File Offset: 0x000BB4F9
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x000BD301 File Offset: 0x000BB501
		public bool enableAutoSizing
		{
			get
			{
				return this.m_enableAutoSizing;
			}
			set
			{
				if (this.m_enableAutoSizing == value)
				{
					return;
				}
				this.m_enableAutoSizing = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000BD320 File Offset: 0x000BB520
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x000BD328 File Offset: 0x000BB528
		public float fontSizeMin
		{
			get
			{
				return this.m_fontSizeMin;
			}
			set
			{
				if (this.m_fontSizeMin == value)
				{
					return;
				}
				this.m_fontSizeMin = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x000BD347 File Offset: 0x000BB547
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x000BD34F File Offset: 0x000BB54F
		public float fontSizeMax
		{
			get
			{
				return this.m_fontSizeMax;
			}
			set
			{
				if (this.m_fontSizeMax == value)
				{
					return;
				}
				this.m_fontSizeMax = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x000BD36E File Offset: 0x000BB56E
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x000BD376 File Offset: 0x000BB576
		public FontStyles fontStyle
		{
			get
			{
				return this.m_fontStyle;
			}
			set
			{
				if (this.m_fontStyle == value)
				{
					return;
				}
				this.m_fontStyle = value;
				this.m_havePropertiesChanged = true;
				this.checkPaddingRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x000BD3A3 File Offset: 0x000BB5A3
		public bool isUsingBold
		{
			get
			{
				return this.m_isUsingBold;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000BD3AB File Offset: 0x000BB5AB
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x000BD3B3 File Offset: 0x000BB5B3
		public TextAlignmentOptions alignment
		{
			get
			{
				return this.m_textAlignment;
			}
			set
			{
				if (this.m_textAlignment == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_textAlignment = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000BD3D3 File Offset: 0x000BB5D3
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x000BD3DB File Offset: 0x000BB5DB
		public float characterSpacing
		{
			get
			{
				return this.m_characterSpacing;
			}
			set
			{
				if (this.m_characterSpacing == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_characterSpacing = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000BD408 File Offset: 0x000BB608
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x000BD410 File Offset: 0x000BB610
		public float lineSpacing
		{
			get
			{
				return this.m_lineSpacing;
			}
			set
			{
				if (this.m_lineSpacing == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_lineSpacing = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000BD43D File Offset: 0x000BB63D
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x000BD445 File Offset: 0x000BB645
		public float paragraphSpacing
		{
			get
			{
				return this.m_paragraphSpacing;
			}
			set
			{
				if (this.m_paragraphSpacing == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_paragraphSpacing = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000BD472 File Offset: 0x000BB672
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x000BD47A File Offset: 0x000BB67A
		public float characterWidthAdjustment
		{
			get
			{
				return this.m_charWidthMaxAdj;
			}
			set
			{
				if (this.m_charWidthMaxAdj == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_charWidthMaxAdj = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000BD4A7 File Offset: 0x000BB6A7
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x000BD4AF File Offset: 0x000BB6AF
		public bool enableWordWrapping
		{
			get
			{
				return this.m_enableWordWrapping;
			}
			set
			{
				if (this.m_enableWordWrapping == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.m_isCalculateSizeRequired = true;
				this.m_enableWordWrapping = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000BD4E3 File Offset: 0x000BB6E3
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x000BD4EB File Offset: 0x000BB6EB
		public float wordWrappingRatios
		{
			get
			{
				return this.m_wordWrappingRatios;
			}
			set
			{
				if (this.m_wordWrappingRatios == value)
				{
					return;
				}
				this.m_wordWrappingRatios = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000BD518 File Offset: 0x000BB718
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x000BD520 File Offset: 0x000BB720
		public bool enableAdaptiveJustification
		{
			get
			{
				return this.m_enableAdaptiveJustification;
			}
			set
			{
				if (this.m_enableAdaptiveJustification == value)
				{
					return;
				}
				this.m_enableAdaptiveJustification = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000BD54D File Offset: 0x000BB74D
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x000BD555 File Offset: 0x000BB755
		public TextOverflowModes OverflowMode
		{
			get
			{
				return this.m_overflowMode;
			}
			set
			{
				if (this.m_overflowMode == value)
				{
					return;
				}
				this.m_overflowMode = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000BD582 File Offset: 0x000BB782
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x000BD58A File Offset: 0x000BB78A
		public bool enableKerning
		{
			get
			{
				return this.m_enableKerning;
			}
			set
			{
				if (this.m_enableKerning == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_enableKerning = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000BD5B7 File Offset: 0x000BB7B7
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x000BD5BF File Offset: 0x000BB7BF
		public bool extraPadding
		{
			get
			{
				return this.m_enableExtraPadding;
			}
			set
			{
				if (this.m_enableExtraPadding == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_enableExtraPadding = value;
				this.UpdateMeshPadding();
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000BD5E5 File Offset: 0x000BB7E5
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x000BD5ED File Offset: 0x000BB7ED
		public bool richText
		{
			get
			{
				return this.m_isRichText;
			}
			set
			{
				if (this.m_isRichText == value)
				{
					return;
				}
				this.m_isRichText = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_isInputParsingRequired = true;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000BD621 File Offset: 0x000BB821
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x000BD629 File Offset: 0x000BB829
		public bool parseCtrlCharacters
		{
			get
			{
				return this.m_parseCtrlCharacters;
			}
			set
			{
				if (this.m_parseCtrlCharacters == value)
				{
					return;
				}
				this.m_parseCtrlCharacters = value;
				this.m_havePropertiesChanged = true;
				this.m_isCalculateSizeRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
				this.m_isInputParsingRequired = true;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x000BD65D File Offset: 0x000BB85D
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x000BD665 File Offset: 0x000BB865
		public bool isOverlay
		{
			get
			{
				return this.m_isOverlay;
			}
			set
			{
				if (this.m_isOverlay == value)
				{
					return;
				}
				this.m_isOverlay = value;
				this.SetShaderDepth();
				this.m_havePropertiesChanged = true;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000BD68B File Offset: 0x000BB88B
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x000BD693 File Offset: 0x000BB893
		public bool isOrthographic
		{
			get
			{
				return this.m_isOrthographic;
			}
			set
			{
				if (this.m_isOrthographic == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isOrthographic = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000BD6B3 File Offset: 0x000BB8B3
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x000BD6BB File Offset: 0x000BB8BB
		public bool enableCulling
		{
			get
			{
				return this.m_isCullingEnabled;
			}
			set
			{
				if (this.m_isCullingEnabled == value)
				{
					return;
				}
				this.m_isCullingEnabled = value;
				this.SetCulling();
				this.m_havePropertiesChanged = true;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000BD6DB File Offset: 0x000BB8DB
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x000BD6E3 File Offset: 0x000BB8E3
		public bool ignoreVisibility
		{
			get
			{
				return this.m_ignoreCulling;
			}
			set
			{
				if (this.m_ignoreCulling == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_ignoreCulling = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000BD6FD File Offset: 0x000BB8FD
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x000BD705 File Offset: 0x000BB905
		public TextureMappingOptions horizontalMapping
		{
			get
			{
				return this.m_horizontalMapping;
			}
			set
			{
				if (this.m_horizontalMapping == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_horizontalMapping = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000BD725 File Offset: 0x000BB925
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x000BD72D File Offset: 0x000BB92D
		public TextureMappingOptions verticalMapping
		{
			get
			{
				return this.m_verticalMapping;
			}
			set
			{
				if (this.m_verticalMapping == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_verticalMapping = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x000BD74D File Offset: 0x000BB94D
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x000BD755 File Offset: 0x000BB955
		public TextRenderFlags renderMode
		{
			get
			{
				return this.m_renderMode;
			}
			set
			{
				if (this.m_renderMode == value)
				{
					return;
				}
				this.m_renderMode = value;
				this.m_havePropertiesChanged = true;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000BD76F File Offset: 0x000BB96F
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x000BD777 File Offset: 0x000BB977
		public int maxVisibleCharacters
		{
			get
			{
				return this.m_maxVisibleCharacters;
			}
			set
			{
				if (this.m_maxVisibleCharacters == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_maxVisibleCharacters = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000BD797 File Offset: 0x000BB997
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x000BD79F File Offset: 0x000BB99F
		public int maxVisibleWords
		{
			get
			{
				return this.m_maxVisibleWords;
			}
			set
			{
				if (this.m_maxVisibleWords == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_maxVisibleWords = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x000BD7BF File Offset: 0x000BB9BF
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x000BD7C7 File Offset: 0x000BB9C7
		public int maxVisibleLines
		{
			get
			{
				return this.m_maxVisibleLines;
			}
			set
			{
				if (this.m_maxVisibleLines == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.m_maxVisibleLines = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000BD7EE File Offset: 0x000BB9EE
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x000BD7F6 File Offset: 0x000BB9F6
		public bool useMaxVisibleDescender
		{
			get
			{
				return this.m_useMaxVisibleDescender;
			}
			set
			{
				if (this.m_useMaxVisibleDescender == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x000BD816 File Offset: 0x000BBA16
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x000BD81E File Offset: 0x000BBA1E
		public int pageToDisplay
		{
			get
			{
				return this.m_pageToDisplay;
			}
			set
			{
				if (this.m_pageToDisplay == value)
				{
					return;
				}
				this.m_havePropertiesChanged = true;
				this.m_pageToDisplay = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x000BD83E File Offset: 0x000BBA3E
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x000BD846 File Offset: 0x000BBA46
		public virtual Vector4 margin
		{
			get
			{
				return this.m_margin;
			}
			set
			{
				if (this.m_margin == value)
				{
					return;
				}
				this.m_margin = value;
				this.ComputeMarginSize();
				this.m_havePropertiesChanged = true;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000BD871 File Offset: 0x000BBA71
		public TMP_TextInfo textInfo
		{
			get
			{
				return this.m_textInfo;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000BD879 File Offset: 0x000BBA79
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000BD881 File Offset: 0x000BBA81
		public bool havePropertiesChanged
		{
			get
			{
				return this.m_havePropertiesChanged;
			}
			set
			{
				if (this.m_havePropertiesChanged == value)
				{
					return;
				}
				this.m_havePropertiesChanged = value;
				this.m_isInputParsingRequired = true;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000BD8A1 File Offset: 0x000BBAA1
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x000BD8A9 File Offset: 0x000BBAA9
		public bool isUsingLegacyAnimationComponent
		{
			get
			{
				return this.m_isUsingLegacyAnimationComponent;
			}
			set
			{
				this.m_isUsingLegacyAnimationComponent = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000BD8B2 File Offset: 0x000BBAB2
		public new Transform transform
		{
			get
			{
				if (this.m_transform == null)
				{
					this.m_transform = base.GetComponent<Transform>();
				}
				return this.m_transform;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000BD8D4 File Offset: 0x000BBAD4
		public new RectTransform rectTransform
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x000BD8F6 File Offset: 0x000BBAF6
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x000BD8FE File Offset: 0x000BBAFE
		public virtual bool autoSizeTextContainer { get; set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x000BD907 File Offset: 0x000BBB07
		public virtual Mesh mesh
		{
			get
			{
				return this.m_mesh;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000BD90F File Offset: 0x000BBB0F
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x000BD917 File Offset: 0x000BBB17
		public bool isVolumetricText
		{
			get
			{
				return this.m_isVolumetricText;
			}
			set
			{
				if (this.m_isVolumetricText == value)
				{
					return;
				}
				this.m_havePropertiesChanged = value;
				this.m_textInfo.ResetVertexLayout(value);
				this.m_isInputParsingRequired = true;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000BD94C File Offset: 0x000BBB4C
		public Bounds bounds
		{
			get
			{
				if (this.m_mesh == null)
				{
					return default(Bounds);
				}
				return this.GetCompoundBounds();
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x000BD978 File Offset: 0x000BBB78
		public Bounds textBounds
		{
			get
			{
				if (this.m_textInfo == null)
				{
					return default(Bounds);
				}
				return this.GetTextBounds();
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000BD99D File Offset: 0x000BBB9D
		public float flexibleHeight
		{
			get
			{
				return this.m_flexibleHeight;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000BD9A5 File Offset: 0x000BBBA5
		public float flexibleWidth
		{
			get
			{
				return this.m_flexibleWidth;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000BD9AD File Offset: 0x000BBBAD
		public float minHeight
		{
			get
			{
				return this.m_minHeight;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x000BD9B5 File Offset: 0x000BBBB5
		public float minWidth
		{
			get
			{
				return this.m_minWidth;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000BD9BD File Offset: 0x000BBBBD
		public virtual float preferredWidth
		{
			get
			{
				if (!this.m_isPreferredWidthDirty)
				{
					return this.m_preferredWidth;
				}
				this.m_preferredWidth = this.GetPreferredWidth();
				return this.m_preferredWidth;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x000BD9E0 File Offset: 0x000BBBE0
		public virtual float preferredHeight
		{
			get
			{
				if (!this.m_isPreferredHeightDirty)
				{
					return this.m_preferredHeight;
				}
				this.m_preferredHeight = this.GetPreferredHeight();
				return this.m_preferredHeight;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000BDA03 File Offset: 0x000BBC03
		public virtual float renderedWidth
		{
			get
			{
				return this.GetRenderedWidth();
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x000BDA0B File Offset: 0x000BBC0B
		public virtual float renderedHeight
		{
			get
			{
				return this.GetRenderedHeight();
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000BDA13 File Offset: 0x000BBC13
		public int layoutPriority
		{
			get
			{
				return this.m_layoutPriority;
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void LoadFontAsset()
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000086D3 File Offset: 0x000068D3
		protected virtual Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetFontBaseMaterial(Material mat)
		{
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000086D3 File Offset: 0x000068D3
		protected virtual Material[] GetSharedMaterials()
		{
			return null;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetSharedMaterials(Material[] materials)
		{
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000086D3 File Offset: 0x000068D3
		protected virtual Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000BC6BB File Offset: 0x000BA8BB
		protected virtual Material CreateMaterialInstance(Material source)
		{
			Material material = new Material(source);
			material.shaderKeywords = source.shaderKeywords;
			material.name += " (Instance)";
			return material;
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000BDA1C File Offset: 0x000BBC1C
		protected void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
			if (gradient == null)
			{
				return;
			}
			this.m_fontColorGradient.bottomLeft = gradient.bottomLeft;
			this.m_fontColorGradient.bottomRight = gradient.bottomRight;
			this.m_fontColorGradient.topLeft = gradient.topLeft;
			this.m_fontColorGradient.topRight = gradient.topRight;
			this.SetVerticesDirty();
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetFaceColor(Color32 color)
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetOutlineColor(Color32 color)
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetOutlineThickness(float thickness)
		{
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetShaderDepth()
		{
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetCulling()
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0000D576 File Offset: 0x0000B776
		protected virtual float GetPaddingForMaterial()
		{
			return 0f;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0000D576 File Offset: 0x0000B776
		protected virtual float GetPaddingForMaterial(Material mat)
		{
			return 0f;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000086D3 File Offset: 0x000068D3
		protected virtual Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void ForceMeshUpdate()
		{
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void ForceMeshUpdate(bool ignoreActiveState)
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000BDA7D File Offset: 0x000BBC7D
		internal void SetTextInternal(string text)
		{
			this.m_text = text;
			this.m_renderMode = TextRenderFlags.DontRender;
			this.m_isInputParsingRequired = true;
			this.ForceMeshUpdate();
			this.m_renderMode = TextRenderFlags.Render;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void UpdateGeometry(Mesh mesh, int index)
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void UpdateVertexData()
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void SetVertices(Vector3[] vertices)
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void UpdateMeshPadding()
		{
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000BDAA5 File Offset: 0x000BBCA5
		public new void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			base.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
			this.InternalCrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000BDABD File Offset: 0x000BBCBD
		public new void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			base.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
			this.InternalCrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000BDAD4 File Offset: 0x000BBCD4
		protected void ParseInputText()
		{
			this.m_isInputParsingRequired = false;
			switch (this.m_inputSource)
			{
			case TMP_Text.TextInputSources.Text:
			case TMP_Text.TextInputSources.String:
				this.StringToCharArray(this.m_text, ref this.m_char_buffer);
				break;
			case TMP_Text.TextInputSources.SetText:
				this.SetTextArrayToCharArray(this.m_input_CharArray, ref this.m_char_buffer);
				break;
			}
			this.SetArraySizes(this.m_char_buffer);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000BDB3A File Offset: 0x000BBD3A
		public void SetText(string text)
		{
			this.m_inputSource = TMP_Text.TextInputSources.SetCharArray;
			this.StringToCharArray(text, ref this.m_char_buffer);
			this.m_isInputParsingRequired = true;
			this.m_havePropertiesChanged = true;
			this.m_isCalculateSizeRequired = true;
			this.SetVerticesDirty();
			this.SetLayoutDirty();
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000BDB71 File Offset: 0x000BBD71
		public void SetText(string text, float arg0)
		{
			this.SetText(text, arg0, 255f, 255f);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000BDB85 File Offset: 0x000BBD85
		public void SetText(string text, float arg0, float arg1)
		{
			this.SetText(text, arg0, arg1, 255f);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000BDB98 File Offset: 0x000BBD98
		public void SetText(string text, float arg0, float arg1, float arg2)
		{
			if (text == this.old_text && arg0 == this.old_arg0 && arg1 == this.old_arg1 && arg2 == this.old_arg2)
			{
				return;
			}
			this.old_text = text;
			this.old_arg1 = 255f;
			this.old_arg2 = 255f;
			int precision = 0;
			int num = 0;
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (c == '{')
				{
					if (text[i + 2] == ':')
					{
						precision = (int)(text[i + 3] - '0');
					}
					switch (text[i + 1])
					{
					case '0':
						this.old_arg0 = arg0;
						this.AddFloatToCharArray(arg0, ref num, precision);
						break;
					case '1':
						this.old_arg1 = arg1;
						this.AddFloatToCharArray(arg1, ref num, precision);
						break;
					case '2':
						this.old_arg2 = arg2;
						this.AddFloatToCharArray(arg2, ref num, precision);
						break;
					}
					if (text[i + 2] == ':')
					{
						i += 4;
					}
					else
					{
						i += 2;
					}
				}
				else
				{
					this.m_input_CharArray[num] = c;
					num++;
				}
			}
			this.m_input_CharArray[num] = '\0';
			this.m_charArray_Length = num;
			this.m_inputSource = TMP_Text.TextInputSources.SetText;
			this.m_isInputParsingRequired = true;
			this.m_havePropertiesChanged = true;
			this.m_isCalculateSizeRequired = true;
			this.SetVerticesDirty();
			this.SetLayoutDirty();
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000BDCEC File Offset: 0x000BBEEC
		public void SetText(StringBuilder text)
		{
			this.m_inputSource = TMP_Text.TextInputSources.SetCharArray;
			this.StringBuilderToIntArray(text, ref this.m_char_buffer);
			this.m_isInputParsingRequired = true;
			this.m_havePropertiesChanged = true;
			this.m_isCalculateSizeRequired = true;
			this.SetVerticesDirty();
			this.SetLayoutDirty();
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000BDD24 File Offset: 0x000BBF24
		public void SetCharArray(char[] charArray)
		{
			if (charArray == null || charArray.Length == 0)
			{
				return;
			}
			if (this.m_char_buffer.Length <= charArray.Length)
			{
				int num = Mathf.NextPowerOfTwo(charArray.Length + 1);
				this.m_char_buffer = new int[num];
			}
			int num2 = 0;
			int i = 0;
			while (i < charArray.Length)
			{
				if (charArray[i] != '\\' || i >= charArray.Length - 1)
				{
					goto IL_97;
				}
				int num3 = (int)charArray[i + 1];
				if (num3 != 110)
				{
					if (num3 != 114)
					{
						if (num3 != 116)
						{
							goto IL_97;
						}
						this.m_char_buffer[num2] = 9;
						i++;
						num2++;
					}
					else
					{
						this.m_char_buffer[num2] = 13;
						i++;
						num2++;
					}
				}
				else
				{
					this.m_char_buffer[num2] = 10;
					i++;
					num2++;
				}
				IL_A6:
				i++;
				continue;
				IL_97:
				this.m_char_buffer[num2] = (int)charArray[i];
				num2++;
				goto IL_A6;
			}
			this.m_char_buffer[num2] = 0;
			this.m_inputSource = TMP_Text.TextInputSources.SetCharArray;
			this.m_havePropertiesChanged = true;
			this.m_isInputParsingRequired = true;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000BDE04 File Offset: 0x000BC004
		protected void SetTextArrayToCharArray(char[] charArray, ref int[] charBuffer)
		{
			if (charArray == null || this.m_charArray_Length == 0)
			{
				return;
			}
			if (charBuffer.Length <= this.m_charArray_Length)
			{
				int num = (this.m_charArray_Length > 1024) ? (this.m_charArray_Length + 256) : Mathf.NextPowerOfTwo(this.m_charArray_Length + 1);
				charBuffer = new int[num];
			}
			int num2 = 0;
			for (int i = 0; i < this.m_charArray_Length; i++)
			{
				if (char.IsHighSurrogate(charArray[i]) && char.IsLowSurrogate(charArray[i + 1]))
				{
					charBuffer[num2] = char.ConvertToUtf32(charArray[i], charArray[i + 1]);
					i++;
					num2++;
				}
				else
				{
					charBuffer[num2] = (int)charArray[i];
					num2++;
				}
			}
			charBuffer[num2] = 0;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000BDEB0 File Offset: 0x000BC0B0
		protected void StringToCharArray(string text, ref int[] chars)
		{
			if (text == null)
			{
				chars[0] = 0;
				return;
			}
			if (chars == null || chars.Length <= text.Length)
			{
				int num = (text.Length > 1024) ? (text.Length + 256) : Mathf.NextPowerOfTwo(text.Length + 1);
				chars = new int[num];
			}
			int num2 = 0;
			int i = 0;
			while (i < text.Length)
			{
				if (this.m_inputSource != TMP_Text.TextInputSources.Text || text[i] != '\\' || text.Length <= i + 1)
				{
					goto IL_19E;
				}
				int num3 = (int)text[i + 1];
				if (num3 <= 92)
				{
					if (num3 != 85)
					{
						if (num3 != 92)
						{
							goto IL_19E;
						}
						if (!this.m_parseCtrlCharacters || text.Length <= i + 2)
						{
							goto IL_19E;
						}
						chars[num2] = (int)text[i + 1];
						chars[num2 + 1] = (int)text[i + 2];
						i += 2;
						num2 += 2;
					}
					else
					{
						if (text.Length <= i + 9)
						{
							goto IL_19E;
						}
						chars[num2] = this.GetUTF32(i + 2);
						i += 9;
						num2++;
					}
				}
				else if (num3 != 110)
				{
					switch (num3)
					{
					case 114:
						if (!this.m_parseCtrlCharacters)
						{
							goto IL_19E;
						}
						chars[num2] = 13;
						i++;
						num2++;
						break;
					case 115:
						goto IL_19E;
					case 116:
						if (!this.m_parseCtrlCharacters)
						{
							goto IL_19E;
						}
						chars[num2] = 9;
						i++;
						num2++;
						break;
					case 117:
						if (text.Length <= i + 5)
						{
							goto IL_19E;
						}
						chars[num2] = (int)((ushort)this.GetUTF16(i + 2));
						i += 5;
						num2++;
						break;
					default:
						goto IL_19E;
					}
				}
				else
				{
					if (!this.m_parseCtrlCharacters)
					{
						goto IL_19E;
					}
					chars[num2] = 10;
					i++;
					num2++;
				}
				IL_1EE:
				i++;
				continue;
				IL_19E:
				if (char.IsHighSurrogate(text[i]) && char.IsLowSurrogate(text[i + 1]))
				{
					chars[num2] = char.ConvertToUtf32(text[i], text[i + 1]);
					i++;
					num2++;
					goto IL_1EE;
				}
				chars[num2] = (int)text[i];
				num2++;
				goto IL_1EE;
			}
			chars[num2] = 0;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x000BE0C0 File Offset: 0x000BC2C0
		protected void StringBuilderToIntArray(StringBuilder text, ref int[] chars)
		{
			if (text == null)
			{
				chars[0] = 0;
				return;
			}
			if (chars == null || chars.Length <= text.Length)
			{
				int num = (text.Length > 1024) ? (text.Length + 256) : Mathf.NextPowerOfTwo(text.Length + 1);
				chars = new int[num];
			}
			int num2 = 0;
			int i = 0;
			while (i < text.Length)
			{
				if (!this.m_parseCtrlCharacters || text[i] != '\\' || text.Length <= i + 1)
				{
					goto IL_178;
				}
				int num3 = (int)text[i + 1];
				if (num3 <= 92)
				{
					if (num3 != 85)
					{
						if (num3 != 92)
						{
							goto IL_178;
						}
						if (text.Length <= i + 2)
						{
							goto IL_178;
						}
						chars[num2] = (int)text[i + 1];
						chars[num2 + 1] = (int)text[i + 2];
						i += 2;
						num2 += 2;
					}
					else
					{
						if (text.Length <= i + 9)
						{
							goto IL_178;
						}
						chars[num2] = this.GetUTF32(i + 2);
						i += 9;
						num2++;
					}
				}
				else if (num3 != 110)
				{
					switch (num3)
					{
					case 114:
						chars[num2] = 13;
						i++;
						num2++;
						break;
					case 115:
						goto IL_178;
					case 116:
						chars[num2] = 9;
						i++;
						num2++;
						break;
					case 117:
						if (text.Length <= i + 5)
						{
							goto IL_178;
						}
						chars[num2] = (int)((ushort)this.GetUTF16(i + 2));
						i += 5;
						num2++;
						break;
					default:
						goto IL_178;
					}
				}
				else
				{
					chars[num2] = 10;
					i++;
					num2++;
				}
				IL_1C8:
				i++;
				continue;
				IL_178:
				if (char.IsHighSurrogate(text[i]) && char.IsLowSurrogate(text[i + 1]))
				{
					chars[num2] = char.ConvertToUtf32(text[i], text[i + 1]);
					i++;
					num2++;
					goto IL_1C8;
				}
				chars[num2] = (int)text[i];
				num2++;
				goto IL_1C8;
			}
			chars[num2] = 0;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x000BE2AC File Offset: 0x000BC4AC
		protected void AddFloatToCharArray(float number, ref int index, int precision)
		{
			if (number < 0f)
			{
				char[] input_CharArray = this.m_input_CharArray;
				int num = index;
				index = num + 1;
				input_CharArray[num] = 45;
				number = -number;
			}
			number += this.k_Power[Mathf.Min(9, precision)];
			int num2 = (int)number;
			this.AddIntToCharArray(num2, ref index, precision);
			if (precision > 0)
			{
				char[] input_CharArray2 = this.m_input_CharArray;
				int num = index;
				index = num + 1;
				input_CharArray2[num] = 46;
				number -= (float)num2;
				for (int i = 0; i < precision; i++)
				{
					number *= 10f;
					int num3 = (int)number;
					char[] input_CharArray3 = this.m_input_CharArray;
					num = index;
					index = num + 1;
					input_CharArray3[num] = (ushort)(num3 + 48);
					number -= (float)num3;
				}
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000BE350 File Offset: 0x000BC550
		protected void AddIntToCharArray(int number, ref int index, int precision)
		{
			if (number < 0)
			{
				char[] input_CharArray = this.m_input_CharArray;
				int num = index;
				index = num + 1;
				input_CharArray[num] = 45;
				number = -number;
			}
			int num2 = index;
			do
			{
				this.m_input_CharArray[num2++] = (char)(number % 10 + 48);
				number /= 10;
			}
			while (number > 0);
			int num3 = num2;
			while (index + 1 < num2)
			{
				num2--;
				char c = this.m_input_CharArray[index];
				this.m_input_CharArray[index] = this.m_input_CharArray[num2];
				this.m_input_CharArray[num2] = c;
				index++;
			}
			index = num3;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0000D742 File Offset: 0x0000B942
		protected virtual int SetArraySizes(int[] chars)
		{
			return 0;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void GenerateTextMesh()
		{
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000BE3D8 File Offset: 0x000BC5D8
		public Vector2 GetPreferredValues()
		{
			if (this.m_isInputParsingRequired || this.m_isTextTruncated)
			{
				this.m_isCalculatingPreferredValues = true;
				this.ParseInputText();
			}
			float preferredWidth = this.GetPreferredWidth();
			float preferredHeight = this.GetPreferredHeight();
			return new Vector2(preferredWidth, preferredHeight);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000BE418 File Offset: 0x000BC618
		public Vector2 GetPreferredValues(float width, float height)
		{
			if (this.m_isInputParsingRequired || this.m_isTextTruncated)
			{
				this.m_isCalculatingPreferredValues = true;
				this.ParseInputText();
			}
			Vector2 margin = new Vector2(width, height);
			float preferredWidth = this.GetPreferredWidth(margin);
			float preferredHeight = this.GetPreferredHeight(margin);
			return new Vector2(preferredWidth, preferredHeight);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x000BE460 File Offset: 0x000BC660
		public Vector2 GetPreferredValues(string text)
		{
			this.m_isCalculatingPreferredValues = true;
			this.StringToCharArray(text, ref this.m_char_buffer);
			this.SetArraySizes(this.m_char_buffer);
			Vector2 margin = TMP_Text.k_LargePositiveVector2;
			float preferredWidth = this.GetPreferredWidth(margin);
			float preferredHeight = this.GetPreferredHeight(margin);
			return new Vector2(preferredWidth, preferredHeight);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		public Vector2 GetPreferredValues(string text, float width, float height)
		{
			this.m_isCalculatingPreferredValues = true;
			this.StringToCharArray(text, ref this.m_char_buffer);
			this.SetArraySizes(this.m_char_buffer);
			Vector2 margin = new Vector2(width, height);
			float preferredWidth = this.GetPreferredWidth(margin);
			float preferredHeight = this.GetPreferredHeight(margin);
			return new Vector2(preferredWidth, preferredHeight);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000BE4F8 File Offset: 0x000BC6F8
		protected float GetPreferredWidth()
		{
			float defaultFontSize = this.m_enableAutoSizing ? this.m_fontSizeMax : this.m_fontSize;
			Vector2 marginSize = TMP_Text.k_LargePositiveVector2;
			if (this.m_isInputParsingRequired || this.m_isTextTruncated)
			{
				this.m_isCalculatingPreferredValues = true;
				this.ParseInputText();
			}
			float x = this.CalculatePreferredValues(defaultFontSize, marginSize).x;
			this.m_isPreferredWidthDirty = false;
			return x;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000BE554 File Offset: 0x000BC754
		protected float GetPreferredWidth(Vector2 margin)
		{
			float defaultFontSize = this.m_enableAutoSizing ? this.m_fontSizeMax : this.m_fontSize;
			return this.CalculatePreferredValues(defaultFontSize, margin).x;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000BE588 File Offset: 0x000BC788
		protected float GetPreferredHeight()
		{
			float defaultFontSize = this.m_enableAutoSizing ? this.m_fontSizeMax : this.m_fontSize;
			Vector2 marginSize = new Vector2((this.m_marginWidth != 0f) ? this.m_marginWidth : TMP_Text.k_LargePositiveFloat, TMP_Text.k_LargePositiveFloat);
			if (this.m_isInputParsingRequired || this.m_isTextTruncated)
			{
				this.m_isCalculatingPreferredValues = true;
				this.ParseInputText();
			}
			float y = this.CalculatePreferredValues(defaultFontSize, marginSize).y;
			this.m_isPreferredHeightDirty = false;
			return y;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000BE604 File Offset: 0x000BC804
		protected float GetPreferredHeight(Vector2 margin)
		{
			float defaultFontSize = this.m_enableAutoSizing ? this.m_fontSizeMax : this.m_fontSize;
			return this.CalculatePreferredValues(defaultFontSize, margin).y;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000BE638 File Offset: 0x000BC838
		public Vector2 GetRenderedValues()
		{
			return this.GetTextBounds().size;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000BE658 File Offset: 0x000BC858
		protected float GetRenderedWidth()
		{
			return this.GetRenderedValues().x;
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000BE665 File Offset: 0x000BC865
		protected float GetRenderedHeight()
		{
			return this.GetRenderedValues().y;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000BE674 File Offset: 0x000BC874
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize)
		{
			if (this.m_fontAsset == null || this.m_fontAsset.characterDictionary == null)
			{
				Debug.LogWarning("Can't Generate Mesh! No Font Asset has been assigned to Object ID: " + base.GetInstanceID().ToString());
				return Vector2.zero;
			}
			if (this.m_char_buffer == null || this.m_char_buffer.Length == 0 || this.m_char_buffer[0] == 0)
			{
				return Vector2.zero;
			}
			this.m_currentFontAsset = this.m_fontAsset;
			this.m_currentMaterial = this.m_sharedMaterial;
			this.m_currentMaterialIndex = 0;
			this.m_materialReferenceStack.SetDefault(new MaterialReference(0, this.m_currentFontAsset, null, this.m_currentMaterial, this.m_padding));
			int totalCharacterCount = this.m_totalCharacterCount;
			if (this.m_internalCharacterInfo == null || totalCharacterCount > this.m_internalCharacterInfo.Length)
			{
				this.m_internalCharacterInfo = new TMP_CharacterInfo[(totalCharacterCount > 1024) ? (totalCharacterCount + 256) : Mathf.NextPowerOfTwo(totalCharacterCount)];
			}
			this.m_fontScale = defaultFontSize / this.m_currentFontAsset.fontInfo.PointSize * (this.m_isOrthographic ? 1f : 0.1f);
			this.m_fontScaleMultiplier = 1f;
			float num = defaultFontSize / this.m_fontAsset.fontInfo.PointSize * this.m_fontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
			float num2 = this.m_fontScale;
			this.m_currentFontSize = defaultFontSize;
			this.m_sizeStack.SetDefault(this.m_currentFontSize);
			this.m_style = this.m_fontStyle;
			this.m_baselineOffset = 0f;
			this.m_styleStack.Clear();
			this.m_lineOffset = 0f;
			this.m_lineHeight = 0f;
			float num3 = this.m_currentFontAsset.fontInfo.LineHeight - (this.m_currentFontAsset.fontInfo.Ascender - this.m_currentFontAsset.fontInfo.Descender);
			this.m_cSpacing = 0f;
			this.m_monoSpacing = 0f;
			this.m_xAdvance = 0f;
			float a = 0f;
			this.tag_LineIndent = 0f;
			this.tag_Indent = 0f;
			this.m_indentStack.SetDefault(0f);
			this.tag_NoParsing = false;
			this.m_characterCount = 0;
			this.m_firstCharacterOfLine = 0;
			this.m_maxLineAscender = TMP_Text.k_LargeNegativeFloat;
			this.m_maxLineDescender = TMP_Text.k_LargePositiveFloat;
			this.m_lineNumber = 0;
			float x = marginSize.x;
			this.m_marginLeft = 0f;
			this.m_marginRight = 0f;
			this.m_width = -1f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			this.m_maxAscender = 0f;
			this.m_maxDescender = 0f;
			bool flag = true;
			bool flag2 = false;
			WordWrapState wordWrapState = default(WordWrapState);
			this.SaveWordWrappingState(ref wordWrapState, 0, 0);
			WordWrapState wordWrapState2 = default(WordWrapState);
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			while (this.m_char_buffer[num9] != 0)
			{
				int num10 = this.m_char_buffer[num9];
				this.m_textElementType = TMP_TextElementType.Character;
				this.m_currentMaterialIndex = this.m_textInfo.characterInfo[this.m_characterCount].materialReferenceIndex;
				this.m_currentFontAsset = this.m_materialReferences[this.m_currentMaterialIndex].fontAsset;
				int currentMaterialIndex = this.m_currentMaterialIndex;
				if (!this.m_isRichText || num10 != 60)
				{
					goto IL_37A;
				}
				this.m_isParsingText = true;
				if (!this.ValidateHtmlTag(this.m_char_buffer, num9 + 1, out num8))
				{
					goto IL_37A;
				}
				num9 = num8;
				if (this.m_textElementType != TMP_TextElementType.Character)
				{
					goto IL_37A;
				}
				IL_104B:
				num9++;
				continue;
				IL_37A:
				this.m_isParsingText = false;
				bool isUsingAlternateTypeface = this.m_textInfo.characterInfo[this.m_characterCount].isUsingAlternateTypeface;
				float num11 = 1f;
				if (this.m_textElementType == TMP_TextElementType.Character)
				{
					if ((this.m_style & FontStyles.UpperCase) == FontStyles.UpperCase)
					{
						if (char.IsLower((char)num10))
						{
							num10 = (int)char.ToUpper((char)num10);
						}
					}
					else if ((this.m_style & FontStyles.LowerCase) == FontStyles.LowerCase)
					{
						if (char.IsUpper((char)num10))
						{
							num10 = (int)char.ToLower((char)num10);
						}
					}
					else if (((this.m_fontStyle & FontStyles.SmallCaps) == FontStyles.SmallCaps || (this.m_style & FontStyles.SmallCaps) == FontStyles.SmallCaps) && char.IsLower((char)num10))
					{
						num11 = 0.8f;
						num10 = (int)char.ToUpper((char)num10);
					}
				}
				if (this.m_textElementType == TMP_TextElementType.Sprite)
				{
					TMP_Sprite tmp_Sprite = this.m_currentSpriteAsset.spriteInfoList[this.m_spriteIndex];
					if (tmp_Sprite == null)
					{
						goto IL_104B;
					}
					num10 = 57344 + this.m_spriteIndex;
					this.m_currentFontAsset = this.m_fontAsset;
					float num12 = this.m_currentFontSize / this.m_fontAsset.fontInfo.PointSize * this.m_fontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
					num2 = this.m_fontAsset.fontInfo.Ascender / tmp_Sprite.height * tmp_Sprite.scale * num12;
					this.m_cached_TextElement = tmp_Sprite;
					this.m_internalCharacterInfo[this.m_characterCount].elementType = TMP_TextElementType.Sprite;
					this.m_currentMaterialIndex = currentMaterialIndex;
				}
				else if (this.m_textElementType == TMP_TextElementType.Character)
				{
					this.m_cached_TextElement = this.m_textInfo.characterInfo[this.m_characterCount].textElement;
					if (this.m_cached_TextElement == null)
					{
						goto IL_104B;
					}
					this.m_currentMaterialIndex = this.m_textInfo.characterInfo[this.m_characterCount].materialReferenceIndex;
					this.m_fontScale = this.m_currentFontSize * num11 / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
					num2 = this.m_fontScale * this.m_fontScaleMultiplier * this.m_cached_TextElement.scale;
					this.m_internalCharacterInfo[this.m_characterCount].elementType = TMP_TextElementType.Character;
				}
				float num13 = num2;
				if (num10 == 173)
				{
					num2 = 0f;
				}
				this.m_internalCharacterInfo[this.m_characterCount].character = (char)num10;
				if (this.m_enableKerning && this.m_characterCount >= 1)
				{
					int character = (int)this.m_internalCharacterInfo[this.m_characterCount - 1].character;
					KerningPairKey kerningPairKey = new KerningPairKey(character, num10);
					KerningPair kerningPair;
					this.m_currentFontAsset.kerningDictionary.TryGetValue(kerningPairKey.key, out kerningPair);
					if (kerningPair != null)
					{
						this.m_xAdvance += kerningPair.XadvanceOffset * num2;
					}
				}
				float num14 = 0f;
				if (this.m_monoSpacing != 0f)
				{
					num14 = this.m_monoSpacing / 2f - (this.m_cached_TextElement.width / 2f + this.m_cached_TextElement.xOffset) * num2;
					this.m_xAdvance += num14;
				}
				float num15;
				if (this.m_textElementType == TMP_TextElementType.Character && !isUsingAlternateTypeface && ((this.m_style & FontStyles.Bold) == FontStyles.Bold || (this.m_fontStyle & FontStyles.Bold) == FontStyles.Bold))
				{
					num15 = 1f + this.m_currentFontAsset.boldSpacing * 0.01f;
				}
				else
				{
					num15 = 1f;
				}
				this.m_internalCharacterInfo[this.m_characterCount].baseLine = 0f - this.m_lineOffset + this.m_baselineOffset;
				float num16 = this.m_currentFontAsset.fontInfo.Ascender * ((this.m_textElementType == TMP_TextElementType.Character) ? num2 : this.m_internalCharacterInfo[this.m_characterCount].scale) + this.m_baselineOffset;
				this.m_internalCharacterInfo[this.m_characterCount].ascender = num16 - this.m_lineOffset;
				this.m_maxLineAscender = ((num16 > this.m_maxLineAscender) ? num16 : this.m_maxLineAscender);
				float num17 = this.m_currentFontAsset.fontInfo.Descender * ((this.m_textElementType == TMP_TextElementType.Character) ? num2 : this.m_internalCharacterInfo[this.m_characterCount].scale) + this.m_baselineOffset;
				float num18 = this.m_internalCharacterInfo[this.m_characterCount].descender = num17 - this.m_lineOffset;
				this.m_maxLineDescender = ((num17 < this.m_maxLineDescender) ? num17 : this.m_maxLineDescender);
				if ((this.m_style & FontStyles.Subscript) == FontStyles.Subscript || (this.m_style & FontStyles.Superscript) == FontStyles.Superscript)
				{
					float num19 = (num16 - this.m_baselineOffset) / this.m_currentFontAsset.fontInfo.SubSize;
					num16 = this.m_maxLineAscender;
					this.m_maxLineAscender = ((num19 > this.m_maxLineAscender) ? num19 : this.m_maxLineAscender);
					float num20 = (num17 - this.m_baselineOffset) / this.m_currentFontAsset.fontInfo.SubSize;
					num17 = this.m_maxLineDescender;
					this.m_maxLineDescender = ((num20 < this.m_maxLineDescender) ? num20 : this.m_maxLineDescender);
				}
				if (this.m_lineNumber == 0)
				{
					this.m_maxAscender = ((this.m_maxAscender > num16) ? this.m_maxAscender : num16);
				}
				if (num10 == 9 || !char.IsWhiteSpace((char)num10) || this.m_textElementType == TMP_TextElementType.Sprite)
				{
					float num21 = (this.m_width != -1f) ? Mathf.Min(x + 0.0001f - this.m_marginLeft - this.m_marginRight, this.m_width) : (x + 0.0001f - this.m_marginLeft - this.m_marginRight);
					num6 = this.m_xAdvance + this.m_cached_TextElement.xAdvance * ((num10 != 173) ? num2 : num13);
					if (num6 > num21 && this.enableWordWrapping && this.m_characterCount != this.m_firstCharacterOfLine)
					{
						if (num7 == wordWrapState2.previous_WordBreak || flag)
						{
							if (!this.m_isCharacterWrappingEnabled)
							{
								this.m_isCharacterWrappingEnabled = true;
							}
							else
							{
								flag2 = true;
							}
						}
						num9 = this.RestoreWordWrappingState(ref wordWrapState2);
						num7 = num9;
						if (this.m_char_buffer[num9] == 173)
						{
							this.m_isTextTruncated = true;
							this.m_char_buffer[num9] = 45;
							this.CalculatePreferredValues(defaultFontSize, marginSize);
							return Vector2.zero;
						}
						if (this.m_lineNumber > 0 && !TMP_Math.Approximately(this.m_maxLineAscender, this.m_startOfLineAscender) && this.m_lineHeight == 0f)
						{
							float num22 = this.m_maxLineAscender - this.m_startOfLineAscender;
							this.m_lineOffset += num22;
							wordWrapState2.lineOffset = this.m_lineOffset;
							wordWrapState2.previousLineAscender = this.m_maxLineAscender;
						}
						float num23 = this.m_maxLineAscender - this.m_lineOffset;
						float num24 = this.m_maxLineDescender - this.m_lineOffset;
						this.m_maxDescender = ((this.m_maxDescender < num24) ? this.m_maxDescender : num24);
						this.m_firstCharacterOfLine = this.m_characterCount;
						num4 += this.m_xAdvance;
						if (this.m_enableWordWrapping)
						{
							num5 = this.m_maxAscender - this.m_maxDescender;
						}
						else
						{
							num5 = Mathf.Max(num5, num23 - num24);
						}
						this.SaveWordWrappingState(ref wordWrapState, num9, this.m_characterCount - 1);
						this.m_lineNumber++;
						if (this.m_lineHeight == 0f)
						{
							float num25 = this.m_internalCharacterInfo[this.m_characterCount].ascender - this.m_internalCharacterInfo[this.m_characterCount].baseLine;
							float num26 = 0f - this.m_maxLineDescender + num25 + (num3 + this.m_lineSpacing + this.m_lineSpacingDelta) * num;
							this.m_lineOffset += num26;
							this.m_startOfLineAscender = num25;
						}
						else
						{
							this.m_lineOffset += this.m_lineHeight + this.m_lineSpacing * num;
						}
						this.m_maxLineAscender = TMP_Text.k_LargeNegativeFloat;
						this.m_maxLineDescender = TMP_Text.k_LargePositiveFloat;
						this.m_xAdvance = 0f + this.tag_Indent;
						goto IL_104B;
					}
				}
				if (this.m_lineNumber > 0 && !TMP_Math.Approximately(this.m_maxLineAscender, this.m_startOfLineAscender) && this.m_lineHeight == 0f && !this.m_isNewPage)
				{
					float num27 = this.m_maxLineAscender - this.m_startOfLineAscender;
					num18 -= num27;
					this.m_lineOffset += num27;
					this.m_startOfLineAscender += num27;
					wordWrapState2.lineOffset = this.m_lineOffset;
					wordWrapState2.previousLineAscender = this.m_startOfLineAscender;
				}
				if (num10 == 9)
				{
					float num28 = this.m_currentFontAsset.fontInfo.TabWidth * num2;
					float num29 = Mathf.Ceil(this.m_xAdvance / num28) * num28;
					this.m_xAdvance = ((num29 > this.m_xAdvance) ? num29 : (this.m_xAdvance + num28));
				}
				else if (this.m_monoSpacing != 0f)
				{
					this.m_xAdvance += this.m_monoSpacing - num14 + (this.m_characterSpacing + this.m_currentFontAsset.normalSpacingOffset) * num2 + this.m_cSpacing;
				}
				else
				{
					this.m_xAdvance += (this.m_cached_TextElement.xAdvance * num15 + this.m_characterSpacing + this.m_currentFontAsset.normalSpacingOffset) * num2 + this.m_cSpacing;
				}
				if (num10 == 13)
				{
					a = Mathf.Max(a, num4 + this.m_xAdvance);
					num4 = 0f;
					this.m_xAdvance = 0f + this.tag_Indent;
				}
				if (num10 == 10 || this.m_characterCount == totalCharacterCount - 1)
				{
					if (this.m_lineNumber > 0 && !TMP_Math.Approximately(this.m_maxLineAscender, this.m_startOfLineAscender) && this.m_lineHeight == 0f)
					{
						float num30 = this.m_maxLineAscender - this.m_startOfLineAscender;
						num18 -= num30;
						this.m_lineOffset += num30;
					}
					float num31 = this.m_maxLineDescender - this.m_lineOffset;
					this.m_maxDescender = ((this.m_maxDescender < num31) ? this.m_maxDescender : num31);
					this.m_firstCharacterOfLine = this.m_characterCount + 1;
					if (num10 == 10 && this.m_characterCount != totalCharacterCount - 1)
					{
						a = Mathf.Max(a, num4 + num6);
						num4 = 0f;
					}
					else
					{
						num4 = Mathf.Max(a, num4 + num6);
					}
					num5 = this.m_maxAscender - this.m_maxDescender;
					if (num10 == 10)
					{
						this.SaveWordWrappingState(ref wordWrapState, num9, this.m_characterCount);
						this.SaveWordWrappingState(ref wordWrapState2, num9, this.m_characterCount);
						this.m_lineNumber++;
						if (this.m_lineHeight == 0f)
						{
							float num26 = 0f - this.m_maxLineDescender + num16 + (num3 + this.m_lineSpacing + this.m_paragraphSpacing + this.m_lineSpacingDelta) * num;
							this.m_lineOffset += num26;
						}
						else
						{
							this.m_lineOffset += this.m_lineHeight + (this.m_lineSpacing + this.m_paragraphSpacing) * num;
						}
						this.m_maxLineAscender = TMP_Text.k_LargeNegativeFloat;
						this.m_maxLineDescender = TMP_Text.k_LargePositiveFloat;
						this.m_startOfLineAscender = num16;
						this.m_xAdvance = 0f + this.tag_LineIndent + this.tag_Indent;
					}
				}
				if (this.m_enableWordWrapping || this.m_overflowMode == TextOverflowModes.Truncate || this.m_overflowMode == TextOverflowModes.Ellipsis)
				{
					if ((char.IsWhiteSpace((char)num10) || num10 == 45 || num10 == 173) && !this.m_isNonBreakingSpace && num10 != 160 && num10 != 8209 && num10 != 8239 && num10 != 8288)
					{
						this.SaveWordWrappingState(ref wordWrapState2, num9, this.m_characterCount);
						this.m_isCharacterWrappingEnabled = false;
						flag = false;
					}
					else if (((num10 > 4352 && num10 < 4607) || (num10 > 11904 && num10 < 40959) || (num10 > 43360 && num10 < 43391) || (num10 > 44032 && num10 < 55295) || (num10 > 63744 && num10 < 64255) || (num10 > 65072 && num10 < 65103) || (num10 > 65280 && num10 < 65519)) && !this.m_isNonBreakingSpace)
					{
						if (flag || flag2 || (!TMP_Settings.linebreakingRules.leadingCharacters.ContainsKey(num10) && this.m_characterCount < totalCharacterCount - 1 && !TMP_Settings.linebreakingRules.followingCharacters.ContainsKey((int)this.m_internalCharacterInfo[this.m_characterCount + 1].character)))
						{
							this.SaveWordWrappingState(ref wordWrapState2, num9, this.m_characterCount);
							this.m_isCharacterWrappingEnabled = false;
							flag = false;
						}
					}
					else if (flag || this.m_isCharacterWrappingEnabled || flag2)
					{
						this.SaveWordWrappingState(ref wordWrapState2, num9, this.m_characterCount);
					}
				}
				this.m_characterCount++;
				goto IL_104B;
			}
			this.m_isCharacterWrappingEnabled = false;
			num4 += ((this.m_margin.x > 0f) ? this.m_margin.x : 0f);
			num4 += ((this.m_margin.z > 0f) ? this.m_margin.z : 0f);
			num5 += ((this.m_margin.y > 0f) ? this.m_margin.y : 0f);
			num5 += ((this.m_margin.w > 0f) ? this.m_margin.w : 0f);
			num4 = (float)((int)(num4 * 100f + 1f)) / 100f;
			num5 = (float)((int)(num5 * 100f + 1f)) / 100f;
			return new Vector2(num4, num5);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000BF7C4 File Offset: 0x000BD9C4
		protected virtual Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000BF7DC File Offset: 0x000BD9DC
		protected Bounds GetTextBounds()
		{
			if (this.m_textInfo == null)
			{
				return default(Bounds);
			}
			Extents extents = new Extents(TMP_Text.k_LargePositiveVector2, TMP_Text.k_LargeNegativeVector2);
			for (int i = 0; i < this.m_textInfo.characterCount; i++)
			{
				if (this.m_textInfo.characterInfo[i].isVisible)
				{
					extents.min.x = Mathf.Min(extents.min.x, this.m_textInfo.characterInfo[i].bottomLeft.x);
					extents.min.y = Mathf.Min(extents.min.y, this.m_textInfo.characterInfo[i].descender);
					extents.max.x = Mathf.Max(extents.max.x, this.m_textInfo.characterInfo[i].xAdvance);
					extents.max.y = Mathf.Max(extents.max.y, this.m_textInfo.characterInfo[i].ascender);
				}
			}
			Vector2 v;
			v.x = extents.max.x - extents.min.x;
			v.y = extents.max.y - extents.min.y;
			return new Bounds((extents.min + extents.max) / 2f, v);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000BF978 File Offset: 0x000BDB78
		protected void ResizeLineExtents(int size)
		{
			size = ((size > 1024) ? (size + 256) : Mathf.NextPowerOfTwo(size + 1));
			TMP_LineInfo[] array = new TMP_LineInfo[size];
			for (int i = 0; i < size; i++)
			{
				if (i < this.m_textInfo.lineInfo.Length)
				{
					array[i] = this.m_textInfo.lineInfo[i];
				}
				else
				{
					array[i].lineExtents.min = TMP_Text.k_LargePositiveVector2;
					array[i].lineExtents.max = TMP_Text.k_LargeNegativeVector2;
					array[i].ascender = TMP_Text.k_LargeNegativeFloat;
					array[i].descender = TMP_Text.k_LargePositiveFloat;
				}
			}
			this.m_textInfo.lineInfo = array;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000086D3 File Offset: 0x000068D3
		public virtual TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void ComputeMarginSize()
		{
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x000BFA40 File Offset: 0x000BDC40
		protected int GetArraySizes(int[] chars)
		{
			int num = 0;
			this.m_totalCharacterCount = 0;
			this.m_isUsingBold = false;
			this.m_isParsingText = false;
			int num2 = 0;
			while (chars[num2] != 0)
			{
				int num3 = chars[num2];
				if (this.m_isRichText && num3 == 60 && this.ValidateHtmlTag(chars, num2 + 1, out num))
				{
					num2 = num;
					if ((this.m_style & FontStyles.Bold) == FontStyles.Bold)
					{
						this.m_isUsingBold = true;
					}
				}
				else
				{
					char.IsWhiteSpace((char)num3);
					this.m_totalCharacterCount++;
				}
				num2++;
			}
			return this.m_totalCharacterCount;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x000BFAC4 File Offset: 0x000BDCC4
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
			state.currentFontAsset = this.m_currentFontAsset;
			state.currentSpriteAsset = this.m_currentSpriteAsset;
			state.currentMaterial = this.m_currentMaterial;
			state.currentMaterialIndex = this.m_currentMaterialIndex;
			state.previous_WordBreak = index;
			state.total_CharacterCount = count;
			state.visible_CharacterCount = this.m_lineVisibleCharacterCount;
			state.visible_LinkCount = this.m_textInfo.linkCount;
			state.firstCharacterIndex = this.m_firstCharacterOfLine;
			state.firstVisibleCharacterIndex = this.m_firstVisibleCharacterOfLine;
			state.lastVisibleCharIndex = this.m_lastVisibleCharacterOfLine;
			state.fontStyle = this.m_style;
			state.fontScale = this.m_fontScale;
			state.fontScaleMultiplier = this.m_fontScaleMultiplier;
			state.currentFontSize = this.m_currentFontSize;
			state.xAdvance = this.m_xAdvance;
			state.maxCapHeight = this.m_maxCapHeight;
			state.maxAscender = this.m_maxAscender;
			state.maxDescender = this.m_maxDescender;
			state.maxLineAscender = this.m_maxLineAscender;
			state.maxLineDescender = this.m_maxLineDescender;
			state.previousLineAscender = this.m_startOfLineAscender;
			state.preferredWidth = this.m_preferredWidth;
			state.preferredHeight = this.m_preferredHeight;
			state.meshExtents = this.m_meshExtents;
			state.lineNumber = this.m_lineNumber;
			state.lineOffset = this.m_lineOffset;
			state.baselineOffset = this.m_baselineOffset;
			state.vertexColor = this.m_htmlColor;
			state.tagNoParsing = this.tag_NoParsing;
			state.colorStack = this.m_colorStack;
			state.sizeStack = this.m_sizeStack;
			state.fontWeightStack = this.m_fontWeightStack;
			state.styleStack = this.m_styleStack;
			state.actionStack = this.m_actionStack;
			state.materialReferenceStack = this.m_materialReferenceStack;
			if (this.m_lineNumber < this.m_textInfo.lineInfo.Length)
			{
				state.lineInfo = this.m_textInfo.lineInfo[this.m_lineNumber];
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000BFCB0 File Offset: 0x000BDEB0
		protected int RestoreWordWrappingState(ref WordWrapState state)
		{
			int previous_WordBreak = state.previous_WordBreak;
			this.m_currentFontAsset = state.currentFontAsset;
			this.m_currentSpriteAsset = state.currentSpriteAsset;
			this.m_currentMaterial = state.currentMaterial;
			this.m_currentMaterialIndex = state.currentMaterialIndex;
			this.m_characterCount = state.total_CharacterCount + 1;
			this.m_lineVisibleCharacterCount = state.visible_CharacterCount;
			this.m_textInfo.linkCount = state.visible_LinkCount;
			this.m_firstCharacterOfLine = state.firstCharacterIndex;
			this.m_firstVisibleCharacterOfLine = state.firstVisibleCharacterIndex;
			this.m_lastVisibleCharacterOfLine = state.lastVisibleCharIndex;
			this.m_style = state.fontStyle;
			this.m_fontScale = state.fontScale;
			this.m_fontScaleMultiplier = state.fontScaleMultiplier;
			this.m_currentFontSize = state.currentFontSize;
			this.m_xAdvance = state.xAdvance;
			this.m_maxCapHeight = state.maxCapHeight;
			this.m_maxAscender = state.maxAscender;
			this.m_maxDescender = state.maxDescender;
			this.m_maxLineAscender = state.maxLineAscender;
			this.m_maxLineDescender = state.maxLineDescender;
			this.m_startOfLineAscender = state.previousLineAscender;
			this.m_preferredWidth = state.preferredWidth;
			this.m_preferredHeight = state.preferredHeight;
			this.m_meshExtents = state.meshExtents;
			this.m_lineNumber = state.lineNumber;
			this.m_lineOffset = state.lineOffset;
			this.m_baselineOffset = state.baselineOffset;
			this.m_htmlColor = state.vertexColor;
			this.tag_NoParsing = state.tagNoParsing;
			this.m_colorStack = state.colorStack;
			this.m_sizeStack = state.sizeStack;
			this.m_fontWeightStack = state.fontWeightStack;
			this.m_styleStack = state.styleStack;
			this.m_actionStack = state.actionStack;
			this.m_materialReferenceStack = state.materialReferenceStack;
			if (this.m_lineNumber < this.m_textInfo.lineInfo.Length)
			{
				this.m_textInfo.lineInfo[this.m_lineNumber] = state.lineInfo;
			}
			return previous_WordBreak;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000BFEA0 File Offset: 0x000BE0A0
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.position = this.m_textInfo.characterInfo[this.m_characterCount].bottomLeft;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.position = this.m_textInfo.characterInfo[this.m_characterCount].topLeft;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.position = this.m_textInfo.characterInfo[this.m_characterCount].topRight;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.position = this.m_textInfo.characterInfo[this.m_characterCount].bottomRight;
			vertexColor.a = ((this.m_fontColor32.a < vertexColor.a) ? this.m_fontColor32.a : vertexColor.a);
			if (!this.m_enableVertexGradient)
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = vertexColor;
			}
			else if (!this.m_overrideHtmlColors && !this.m_htmlColor.CompareRGB(this.m_fontColor32))
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = vertexColor;
			}
			else if (this.m_fontColorGradientPreset != null)
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = this.m_fontColorGradientPreset.bottomLeft * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = this.m_fontColorGradientPreset.topLeft * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = this.m_fontColorGradientPreset.topRight * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = this.m_fontColorGradientPreset.bottomRight * vertexColor;
			}
			else
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = this.m_fontColorGradient.bottomLeft * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = this.m_fontColorGradient.topLeft * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = this.m_fontColorGradient.topRight * vertexColor;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = this.m_fontColorGradient.bottomRight * vertexColor;
			}
			if (!this.m_isSDFShader)
			{
				style_padding = 0f;
			}
			FaceInfo fontInfo = this.m_currentFontAsset.fontInfo;
			Vector2 vector;
			vector.x = (this.m_cached_TextElement.x - padding - style_padding) / fontInfo.AtlasWidth;
			vector.y = 1f - (this.m_cached_TextElement.y + padding + style_padding + this.m_cached_TextElement.height) / fontInfo.AtlasHeight;
			Vector2 vector2;
			vector2.x = vector.x;
			vector2.y = 1f - (this.m_cached_TextElement.y - padding - style_padding) / fontInfo.AtlasHeight;
			Vector2 vector3;
			vector3.x = (this.m_cached_TextElement.x + padding + style_padding + this.m_cached_TextElement.width) / fontInfo.AtlasWidth;
			vector3.y = vector2.y;
			Vector2 uv;
			uv.x = vector3.x;
			uv.y = vector.y;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.uv = vector;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.uv = vector2;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.uv = vector3;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.uv = uv;
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000C0460 File Offset: 0x000BE660
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.position = this.m_textInfo.characterInfo[this.m_characterCount].bottomLeft;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.position = this.m_textInfo.characterInfo[this.m_characterCount].topLeft;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.position = this.m_textInfo.characterInfo[this.m_characterCount].topRight;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.position = this.m_textInfo.characterInfo[this.m_characterCount].bottomRight;
			if (this.m_tintAllSprites)
			{
				this.m_tintSprite = true;
			}
			Color32 color = this.m_tintSprite ? this.m_spriteColor.Multiply(vertexColor) : this.m_spriteColor;
			color.a = ((color.a < this.m_fontColor32.a) ? (color.a = ((color.a < vertexColor.a) ? color.a : vertexColor.a)) : this.m_fontColor32.a);
			if (!this.m_enableVertexGradient)
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = color;
			}
			else if (!this.m_overrideHtmlColors && !this.m_htmlColor.CompareRGB(this.m_fontColor32))
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = color;
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = color;
			}
			else if (this.m_fontColorGradientPreset != null)
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradientPreset.bottomLeft) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradientPreset.topLeft) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradientPreset.topRight) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradientPreset.bottomRight) : color);
			}
			else
			{
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradient.bottomLeft) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradient.topLeft) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradient.topRight) : color);
				this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.color = (this.m_tintSprite ? color.Multiply(this.m_fontColorGradient.bottomRight) : color);
			}
			Vector2 vector = new Vector2(this.m_cached_TextElement.x / (float)this.m_currentSpriteAsset.spriteSheet.width, this.m_cached_TextElement.y / (float)this.m_currentSpriteAsset.spriteSheet.height);
			Vector2 vector2 = new Vector2(vector.x, (this.m_cached_TextElement.y + this.m_cached_TextElement.height) / (float)this.m_currentSpriteAsset.spriteSheet.height);
			Vector2 vector3 = new Vector2((this.m_cached_TextElement.x + this.m_cached_TextElement.width) / (float)this.m_currentSpriteAsset.spriteSheet.width, vector2.y);
			Vector2 uv = new Vector2(vector3.x, vector.y);
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BL.uv = vector;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TL.uv = vector2;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_TR.uv = vector3;
			this.m_textInfo.characterInfo[this.m_characterCount].vertex_BR.uv = uv;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000C0A78 File Offset: 0x000BEC78
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
			int materialReferenceIndex = this.m_textInfo.characterInfo[i].materialReferenceIndex;
			index_X4 = this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount;
			TMP_CharacterInfo[] characterInfo = this.m_textInfo.characterInfo;
			this.m_textInfo.characterInfo[i].vertexIndex = index_X4;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[index_X4] = characterInfo[i].vertex_BL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[1 + index_X4] = characterInfo[i].vertex_TL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[2 + index_X4] = characterInfo[i].vertex_TR.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[3 + index_X4] = characterInfo[i].vertex_BR.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[index_X4] = characterInfo[i].vertex_BL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[1 + index_X4] = characterInfo[i].vertex_TL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[2 + index_X4] = characterInfo[i].vertex_TR.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[3 + index_X4] = characterInfo[i].vertex_BR.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[index_X4] = characterInfo[i].vertex_BL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[1 + index_X4] = characterInfo[i].vertex_TL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[2 + index_X4] = characterInfo[i].vertex_TR.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[3 + index_X4] = characterInfo[i].vertex_BR.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[index_X4] = characterInfo[i].vertex_BL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[1 + index_X4] = characterInfo[i].vertex_TL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[2 + index_X4] = characterInfo[i].vertex_TR.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[3 + index_X4] = characterInfo[i].vertex_BR.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount = index_X4 + 4;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000C0DDC File Offset: 0x000BEFDC
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
			int materialReferenceIndex = this.m_textInfo.characterInfo[i].materialReferenceIndex;
			index_X4 = this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount;
			TMP_CharacterInfo[] characterInfo = this.m_textInfo.characterInfo;
			this.m_textInfo.characterInfo[i].vertexIndex = index_X4;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[index_X4] = characterInfo[i].vertex_BL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[1 + index_X4] = characterInfo[i].vertex_TL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[2 + index_X4] = characterInfo[i].vertex_TR.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[3 + index_X4] = characterInfo[i].vertex_BR.position;
			if (isVolumetric)
			{
				Vector3 b = new Vector3(0f, 0f, this.m_fontSize * this.m_fontScale);
				this.m_textInfo.meshInfo[materialReferenceIndex].vertices[4 + index_X4] = characterInfo[i].vertex_BL.position + b;
				this.m_textInfo.meshInfo[materialReferenceIndex].vertices[5 + index_X4] = characterInfo[i].vertex_TL.position + b;
				this.m_textInfo.meshInfo[materialReferenceIndex].vertices[6 + index_X4] = characterInfo[i].vertex_TR.position + b;
				this.m_textInfo.meshInfo[materialReferenceIndex].vertices[7 + index_X4] = characterInfo[i].vertex_BR.position + b;
			}
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[index_X4] = characterInfo[i].vertex_BL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[1 + index_X4] = characterInfo[i].vertex_TL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[2 + index_X4] = characterInfo[i].vertex_TR.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[3 + index_X4] = characterInfo[i].vertex_BR.uv;
			if (isVolumetric)
			{
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[4 + index_X4] = characterInfo[i].vertex_BL.uv;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[5 + index_X4] = characterInfo[i].vertex_TL.uv;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[6 + index_X4] = characterInfo[i].vertex_TR.uv;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[7 + index_X4] = characterInfo[i].vertex_BR.uv;
			}
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[index_X4] = characterInfo[i].vertex_BL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[1 + index_X4] = characterInfo[i].vertex_TL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[2 + index_X4] = characterInfo[i].vertex_TR.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[3 + index_X4] = characterInfo[i].vertex_BR.uv2;
			if (isVolumetric)
			{
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[4 + index_X4] = characterInfo[i].vertex_BL.uv2;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[5 + index_X4] = characterInfo[i].vertex_TL.uv2;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[6 + index_X4] = characterInfo[i].vertex_TR.uv2;
				this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[7 + index_X4] = characterInfo[i].vertex_BR.uv2;
			}
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[index_X4] = characterInfo[i].vertex_BL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[1 + index_X4] = characterInfo[i].vertex_TL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[2 + index_X4] = characterInfo[i].vertex_TR.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[3 + index_X4] = characterInfo[i].vertex_BR.color;
			if (isVolumetric)
			{
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, 128, byte.MaxValue);
				this.m_textInfo.meshInfo[materialReferenceIndex].colors32[4 + index_X4] = color;
				this.m_textInfo.meshInfo[materialReferenceIndex].colors32[5 + index_X4] = color;
				this.m_textInfo.meshInfo[materialReferenceIndex].colors32[6 + index_X4] = color;
				this.m_textInfo.meshInfo[materialReferenceIndex].colors32[7 + index_X4] = color;
			}
			this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount = index_X4 + ((!isVolumetric) ? 4 : 8);
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000C1460 File Offset: 0x000BF660
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
			int materialReferenceIndex = this.m_textInfo.characterInfo[i].materialReferenceIndex;
			index_X4 = this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount;
			TMP_CharacterInfo[] characterInfo = this.m_textInfo.characterInfo;
			this.m_textInfo.characterInfo[i].vertexIndex = index_X4;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[index_X4] = characterInfo[i].vertex_BL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[1 + index_X4] = characterInfo[i].vertex_TL.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[2 + index_X4] = characterInfo[i].vertex_TR.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertices[3 + index_X4] = characterInfo[i].vertex_BR.position;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[index_X4] = characterInfo[i].vertex_BL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[1 + index_X4] = characterInfo[i].vertex_TL.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[2 + index_X4] = characterInfo[i].vertex_TR.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs0[3 + index_X4] = characterInfo[i].vertex_BR.uv;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[index_X4] = characterInfo[i].vertex_BL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[1 + index_X4] = characterInfo[i].vertex_TL.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[2 + index_X4] = characterInfo[i].vertex_TR.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].uvs2[3 + index_X4] = characterInfo[i].vertex_BR.uv2;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[index_X4] = characterInfo[i].vertex_BL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[1 + index_X4] = characterInfo[i].vertex_TL.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[2 + index_X4] = characterInfo[i].vertex_TR.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].colors32[3 + index_X4] = characterInfo[i].vertex_BR.color;
			this.m_textInfo.meshInfo[materialReferenceIndex].vertexCount = index_X4 + 4;
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000C17C4 File Offset: 0x000BF9C4
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
			if (this.m_cached_Underline_GlyphInfo == null)
			{
				if (!TMP_Settings.warningsDisabled)
				{
					Debug.LogWarning("Unable to add underline since the Font Asset doesn't contain the underline character.", this);
				}
				return;
			}
			int num = index + 12;
			if (num > this.m_textInfo.meshInfo[0].vertices.Length)
			{
				this.m_textInfo.meshInfo[0].ResizeMeshInfo(num / 4);
			}
			start.y = Mathf.Min(start.y, end.y);
			end.y = Mathf.Min(start.y, end.y);
			float num2 = this.m_cached_Underline_GlyphInfo.width / 2f * maxScale;
			if (end.x - start.x < this.m_cached_Underline_GlyphInfo.width * maxScale)
			{
				num2 = (end.x - start.x) / 2f;
			}
			float num3 = this.m_padding * startScale / maxScale;
			float num4 = this.m_padding * endScale / maxScale;
			float height = this.m_cached_Underline_GlyphInfo.height;
			Vector3[] vertices = this.m_textInfo.meshInfo[0].vertices;
			vertices[index] = start + new Vector3(0f, 0f - (height + this.m_padding) * maxScale, 0f);
			vertices[index + 1] = start + new Vector3(0f, this.m_padding * maxScale, 0f);
			vertices[index + 2] = vertices[index + 1] + new Vector3(num2, 0f, 0f);
			vertices[index + 3] = vertices[index] + new Vector3(num2, 0f, 0f);
			vertices[index + 4] = vertices[index + 3];
			vertices[index + 5] = vertices[index + 2];
			vertices[index + 6] = end + new Vector3(-num2, this.m_padding * maxScale, 0f);
			vertices[index + 7] = end + new Vector3(-num2, -(height + this.m_padding) * maxScale, 0f);
			vertices[index + 8] = vertices[index + 7];
			vertices[index + 9] = vertices[index + 6];
			vertices[index + 10] = end + new Vector3(0f, this.m_padding * maxScale, 0f);
			vertices[index + 11] = end + new Vector3(0f, -(height + this.m_padding) * maxScale, 0f);
			Vector2[] uvs = this.m_textInfo.meshInfo[0].uvs0;
			Vector2 vector = new Vector2((this.m_cached_Underline_GlyphInfo.x - num3) / this.m_fontAsset.fontInfo.AtlasWidth, 1f - (this.m_cached_Underline_GlyphInfo.y + this.m_padding + this.m_cached_Underline_GlyphInfo.height) / this.m_fontAsset.fontInfo.AtlasHeight);
			Vector2 vector2 = new Vector2(vector.x, 1f - (this.m_cached_Underline_GlyphInfo.y - this.m_padding) / this.m_fontAsset.fontInfo.AtlasHeight);
			Vector2 vector3 = new Vector2((this.m_cached_Underline_GlyphInfo.x - num3 + this.m_cached_Underline_GlyphInfo.width / 2f) / this.m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector4 = new Vector2(vector3.x, vector.y);
			Vector2 vector5 = new Vector2((this.m_cached_Underline_GlyphInfo.x + num4 + this.m_cached_Underline_GlyphInfo.width / 2f) / this.m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector6 = new Vector2(vector5.x, vector.y);
			Vector2 vector7 = new Vector2((this.m_cached_Underline_GlyphInfo.x + num4 + this.m_cached_Underline_GlyphInfo.width) / this.m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector8 = new Vector2(vector7.x, vector.y);
			uvs[index] = vector;
			uvs[1 + index] = vector2;
			uvs[2 + index] = vector3;
			uvs[3 + index] = vector4;
			uvs[4 + index] = new Vector2(vector3.x - vector3.x * 0.001f, vector.y);
			uvs[5 + index] = new Vector2(vector3.x - vector3.x * 0.001f, vector2.y);
			uvs[6 + index] = new Vector2(vector3.x + vector3.x * 0.001f, vector2.y);
			uvs[7 + index] = new Vector2(vector3.x + vector3.x * 0.001f, vector.y);
			uvs[8 + index] = vector6;
			uvs[9 + index] = vector5;
			uvs[10 + index] = vector7;
			uvs[11 + index] = vector8;
			float x = (vertices[index + 2].x - start.x) / (end.x - start.x);
			float scale = Mathf.Abs(sdfScale);
			Vector2[] uvs2 = this.m_textInfo.meshInfo[0].uvs2;
			uvs2[index] = this.PackUV(0f, 0f, scale);
			uvs2[1 + index] = this.PackUV(0f, 1f, scale);
			uvs2[2 + index] = this.PackUV(x, 1f, scale);
			uvs2[3 + index] = this.PackUV(x, 0f, scale);
			float x2 = (vertices[index + 4].x - start.x) / (end.x - start.x);
			x = (vertices[index + 6].x - start.x) / (end.x - start.x);
			uvs2[4 + index] = this.PackUV(x2, 0f, scale);
			uvs2[5 + index] = this.PackUV(x2, 1f, scale);
			uvs2[6 + index] = this.PackUV(x, 1f, scale);
			uvs2[7 + index] = this.PackUV(x, 0f, scale);
			x2 = (vertices[index + 8].x - start.x) / (end.x - start.x);
			x = (vertices[index + 6].x - start.x) / (end.x - start.x);
			uvs2[8 + index] = this.PackUV(x2, 0f, scale);
			uvs2[9 + index] = this.PackUV(x2, 1f, scale);
			uvs2[10 + index] = this.PackUV(1f, 1f, scale);
			uvs2[11 + index] = this.PackUV(1f, 0f, scale);
			Color32[] colors = this.m_textInfo.meshInfo[0].colors32;
			colors[index] = underlineColor;
			colors[1 + index] = underlineColor;
			colors[2 + index] = underlineColor;
			colors[3 + index] = underlineColor;
			colors[4 + index] = underlineColor;
			colors[5 + index] = underlineColor;
			colors[6 + index] = underlineColor;
			colors[7 + index] = underlineColor;
			colors[8 + index] = underlineColor;
			colors[9 + index] = underlineColor;
			colors[10 + index] = underlineColor;
			colors[11 + index] = underlineColor;
			index += 12;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000C1FFD File Offset: 0x000C01FD
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
			fontAsset.characterDictionary.TryGetValue(95, out this.m_cached_Underline_GlyphInfo);
			fontAsset.characterDictionary.TryGetValue(8230, out this.m_cached_Ellipsis_GlyphInfo);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000C202C File Offset: 0x000C022C
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			bool flag = (this.m_style & FontStyles.Italic) == FontStyles.Italic || (this.m_fontStyle & FontStyles.Italic) == FontStyles.Italic;
			int num = fontWeight / 100;
			TMP_FontAsset result;
			if (flag)
			{
				result = this.m_currentFontAsset.fontWeights[num].italicTypeface;
			}
			else
			{
				result = this.m_currentFontAsset.fontWeights[num].regularTypeface;
			}
			return result;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void SetActiveSubMeshes(bool state)
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000C208C File Offset: 0x000C028C
		protected Vector2 PackUV(float x, float y, float scale)
		{
			Vector2 vector;
			vector.x = Mathf.Floor(x * 511f);
			vector.y = Mathf.Floor(y * 511f);
			vector.x = vector.x * 4096f + vector.y;
			vector.y = scale;
			return vector;
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000C20E4 File Offset: 0x000C02E4
		protected float PackUV(float x, float y)
		{
			float num = (float)Math.Floor((double)(x * 511f));
			double num2 = Math.Floor((double)(y * 511f));
			return (float)((double)num * 4096.0 + num2);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000C211C File Offset: 0x000C031C
		protected int HexToInt(char hex)
		{
			switch (hex)
			{
			case '0':
				return 0;
			case '1':
				return 1;
			case '2':
				return 2;
			case '3':
				return 3;
			case '4':
				return 4;
			case '5':
				return 5;
			case '6':
				return 6;
			case '7':
				return 7;
			case '8':
				return 8;
			case '9':
				return 9;
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				break;
			case 'A':
				return 10;
			case 'B':
				return 11;
			case 'C':
				return 12;
			case 'D':
				return 13;
			case 'E':
				return 14;
			case 'F':
				return 15;
			default:
				switch (hex)
				{
				case 'a':
					return 10;
				case 'b':
					return 11;
				case 'c':
					return 12;
				case 'd':
					return 13;
				case 'e':
					return 14;
				case 'f':
					return 15;
				}
				break;
			}
			return 15;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000C21EC File Offset: 0x000C03EC
		protected int GetUTF16(int i)
		{
			return this.HexToInt(this.m_text[i]) * 4096 + this.HexToInt(this.m_text[i + 1]) * 256 + this.HexToInt(this.m_text[i + 2]) * 16 + this.HexToInt(this.m_text[i + 3]);
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000C225C File Offset: 0x000C045C
		protected int GetUTF32(int i)
		{
			return 0 + this.HexToInt(this.m_text[i]) * 268435456 + this.HexToInt(this.m_text[i + 1]) * 16777216 + this.HexToInt(this.m_text[i + 2]) * 1048576 + this.HexToInt(this.m_text[i + 3]) * 65536 + this.HexToInt(this.m_text[i + 4]) * 4096 + this.HexToInt(this.m_text[i + 5]) * 256 + this.HexToInt(this.m_text[i + 6]) * 16 + this.HexToInt(this.m_text[i + 7]);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000C2338 File Offset: 0x000C0538
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			if (tagCount == 7)
			{
				byte r = (byte)(this.HexToInt(hexChars[1]) * 16 + this.HexToInt(hexChars[2]));
				byte g = (byte)(this.HexToInt(hexChars[3]) * 16 + this.HexToInt(hexChars[4]));
				byte b = (byte)(this.HexToInt(hexChars[5]) * 16 + this.HexToInt(hexChars[6]));
				return new Color32(r, g, b, byte.MaxValue);
			}
			if (tagCount == 9)
			{
				byte r2 = (byte)(this.HexToInt(hexChars[1]) * 16 + this.HexToInt(hexChars[2]));
				byte g2 = (byte)(this.HexToInt(hexChars[3]) * 16 + this.HexToInt(hexChars[4]));
				byte b2 = (byte)(this.HexToInt(hexChars[5]) * 16 + this.HexToInt(hexChars[6]));
				byte a = (byte)(this.HexToInt(hexChars[7]) * 16 + this.HexToInt(hexChars[8]));
				return new Color32(r2, g2, b2, a);
			}
			if (tagCount == 13)
			{
				byte r3 = (byte)(this.HexToInt(hexChars[7]) * 16 + this.HexToInt(hexChars[8]));
				byte g3 = (byte)(this.HexToInt(hexChars[9]) * 16 + this.HexToInt(hexChars[10]));
				byte b3 = (byte)(this.HexToInt(hexChars[11]) * 16 + this.HexToInt(hexChars[12]));
				return new Color32(r3, g3, b3, byte.MaxValue);
			}
			if (tagCount == 15)
			{
				byte r4 = (byte)(this.HexToInt(hexChars[7]) * 16 + this.HexToInt(hexChars[8]));
				byte g4 = (byte)(this.HexToInt(hexChars[9]) * 16 + this.HexToInt(hexChars[10]));
				byte b4 = (byte)(this.HexToInt(hexChars[11]) * 16 + this.HexToInt(hexChars[12]));
				byte a2 = (byte)(this.HexToInt(hexChars[13]) * 16 + this.HexToInt(hexChars[14]));
				return new Color32(r4, g4, b4, a2);
			}
			return new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000C2500 File Offset: 0x000C0700
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			if (length == 7)
			{
				byte r = (byte)(this.HexToInt(hexChars[startIndex + 1]) * 16 + this.HexToInt(hexChars[startIndex + 2]));
				byte g = (byte)(this.HexToInt(hexChars[startIndex + 3]) * 16 + this.HexToInt(hexChars[startIndex + 4]));
				byte b = (byte)(this.HexToInt(hexChars[startIndex + 5]) * 16 + this.HexToInt(hexChars[startIndex + 6]));
				return new Color32(r, g, b, byte.MaxValue);
			}
			if (length == 9)
			{
				byte r2 = (byte)(this.HexToInt(hexChars[startIndex + 1]) * 16 + this.HexToInt(hexChars[startIndex + 2]));
				byte g2 = (byte)(this.HexToInt(hexChars[startIndex + 3]) * 16 + this.HexToInt(hexChars[startIndex + 4]));
				byte b2 = (byte)(this.HexToInt(hexChars[startIndex + 5]) * 16 + this.HexToInt(hexChars[startIndex + 6]));
				byte a = (byte)(this.HexToInt(hexChars[startIndex + 7]) * 16 + this.HexToInt(hexChars[startIndex + 8]));
				return new Color32(r2, g2, b2, a);
			}
			return new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000C260C File Offset: 0x000C080C
		protected float ConvertToFloat(char[] chars, int startIndex, int length, int decimalPointIndex)
		{
			if (startIndex == 0)
			{
				return -9999f;
			}
			int num = startIndex + length - 1;
			float num2 = 0f;
			float num3 = 1f;
			decimalPointIndex = ((decimalPointIndex > 0) ? decimalPointIndex : (num + 1));
			if (chars[startIndex] == '-')
			{
				startIndex++;
				num3 = -1f;
			}
			if (chars[startIndex] == '+' || chars[startIndex] == '%')
			{
				startIndex++;
			}
			for (int i = startIndex; i < num + 1; i++)
			{
				if (!char.IsDigit(chars[i]) && chars[i] != '.')
				{
					return -9999f;
				}
				switch (decimalPointIndex - i)
				{
				case -3:
					num2 += (float)(chars[i] - '0') * 0.001f;
					break;
				case -2:
					num2 += (float)(chars[i] - '0') * 0.01f;
					break;
				case -1:
					num2 += (float)(chars[i] - '0') * 0.1f;
					break;
				case 1:
					num2 += (float)(chars[i] - '0');
					break;
				case 2:
					num2 += (float)((chars[i] - '0') * '\n');
					break;
				case 3:
					num2 += (float)((chars[i] - '0') * 'd');
					break;
				case 4:
					num2 += (float)((chars[i] - '0') * 'Ϩ');
					break;
				}
			}
			return num2 * num3;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000C2740 File Offset: 0x000C0940
		protected bool ValidateHtmlTag(int[] chars, int startIndex, out int endIndex)
		{
			int num = 0;
			byte b = 0;
			TagUnits tagUnits = TagUnits.Pixels;
			TagType tagType = TagType.None;
			int num2 = 0;
			this.m_xmlAttribute[num2].nameHashCode = 0;
			this.m_xmlAttribute[num2].valueType = TagType.None;
			this.m_xmlAttribute[num2].valueHashCode = 0;
			this.m_xmlAttribute[num2].valueStartIndex = 0;
			this.m_xmlAttribute[num2].valueLength = 0;
			this.m_xmlAttribute[num2].valueDecimalIndex = 0;
			endIndex = startIndex;
			bool flag = false;
			bool flag2 = false;
			int num3 = startIndex;
			while (num3 < chars.Length && chars[num3] != 0 && num < this.m_htmlTag.Length && chars[num3] != 60)
			{
				if (chars[num3] == 62)
				{
					flag2 = true;
					endIndex = num3;
					this.m_htmlTag[num] = '\0';
					break;
				}
				this.m_htmlTag[num] = (char)chars[num3];
				num++;
				if (b == 1)
				{
					if (tagType == TagType.None)
					{
						if (chars[num3] == 43 || chars[num3] == 45 || char.IsDigit((char)chars[num3]))
						{
							tagType = TagType.NumericalValue;
							this.m_xmlAttribute[num2].valueType = TagType.NumericalValue;
							this.m_xmlAttribute[num2].valueStartIndex = num - 1;
							XML_TagAttribute[] xmlAttribute = this.m_xmlAttribute;
							int num4 = num2;
							xmlAttribute[num4].valueLength = xmlAttribute[num4].valueLength + 1;
						}
						else if (chars[num3] == 35)
						{
							tagType = TagType.ColorValue;
							this.m_xmlAttribute[num2].valueType = TagType.ColorValue;
							this.m_xmlAttribute[num2].valueStartIndex = num - 1;
							XML_TagAttribute[] xmlAttribute2 = this.m_xmlAttribute;
							int num5 = num2;
							xmlAttribute2[num5].valueLength = xmlAttribute2[num5].valueLength + 1;
						}
						else if (chars[num3] == 34)
						{
							tagType = TagType.StringValue;
							this.m_xmlAttribute[num2].valueType = TagType.StringValue;
							this.m_xmlAttribute[num2].valueStartIndex = num;
						}
						else
						{
							tagType = TagType.StringValue;
							this.m_xmlAttribute[num2].valueType = TagType.StringValue;
							this.m_xmlAttribute[num2].valueStartIndex = num - 1;
							this.m_xmlAttribute[num2].valueHashCode = ((this.m_xmlAttribute[num2].valueHashCode << 5) + this.m_xmlAttribute[num2].valueHashCode ^ chars[num3]);
							XML_TagAttribute[] xmlAttribute3 = this.m_xmlAttribute;
							int num6 = num2;
							xmlAttribute3[num6].valueLength = xmlAttribute3[num6].valueLength + 1;
						}
					}
					else if (tagType == TagType.NumericalValue)
					{
						if (chars[num3] == 46)
						{
							this.m_xmlAttribute[num2].valueDecimalIndex = num - 1;
						}
						if (chars[num3] == 112 || chars[num3] == 101 || chars[num3] == 37 || chars[num3] == 32)
						{
							b = 2;
							tagType = TagType.None;
							num2++;
							this.m_xmlAttribute[num2].nameHashCode = 0;
							this.m_xmlAttribute[num2].valueType = TagType.None;
							this.m_xmlAttribute[num2].valueHashCode = 0;
							this.m_xmlAttribute[num2].valueStartIndex = 0;
							this.m_xmlAttribute[num2].valueLength = 0;
							this.m_xmlAttribute[num2].valueDecimalIndex = 0;
							if (chars[num3] == 101)
							{
								tagUnits = TagUnits.FontUnits;
							}
							else if (chars[num3] == 37)
							{
								tagUnits = TagUnits.Percentage;
							}
						}
						else if (b != 2)
						{
							XML_TagAttribute[] xmlAttribute4 = this.m_xmlAttribute;
							int num7 = num2;
							xmlAttribute4[num7].valueLength = xmlAttribute4[num7].valueLength + 1;
						}
					}
					else if (tagType == TagType.ColorValue)
					{
						if (chars[num3] != 32)
						{
							XML_TagAttribute[] xmlAttribute5 = this.m_xmlAttribute;
							int num8 = num2;
							xmlAttribute5[num8].valueLength = xmlAttribute5[num8].valueLength + 1;
						}
						else
						{
							b = 2;
							tagType = TagType.None;
							num2++;
							this.m_xmlAttribute[num2].nameHashCode = 0;
							this.m_xmlAttribute[num2].valueType = TagType.None;
							this.m_xmlAttribute[num2].valueHashCode = 0;
							this.m_xmlAttribute[num2].valueStartIndex = 0;
							this.m_xmlAttribute[num2].valueLength = 0;
							this.m_xmlAttribute[num2].valueDecimalIndex = 0;
						}
					}
					else if (tagType == TagType.StringValue)
					{
						if (chars[num3] != 34)
						{
							this.m_xmlAttribute[num2].valueHashCode = ((this.m_xmlAttribute[num2].valueHashCode << 5) + this.m_xmlAttribute[num2].valueHashCode ^ chars[num3]);
							XML_TagAttribute[] xmlAttribute6 = this.m_xmlAttribute;
							int num9 = num2;
							xmlAttribute6[num9].valueLength = xmlAttribute6[num9].valueLength + 1;
						}
						else
						{
							b = 2;
							tagType = TagType.None;
							num2++;
							this.m_xmlAttribute[num2].nameHashCode = 0;
							this.m_xmlAttribute[num2].valueType = TagType.None;
							this.m_xmlAttribute[num2].valueHashCode = 0;
							this.m_xmlAttribute[num2].valueStartIndex = 0;
							this.m_xmlAttribute[num2].valueLength = 0;
							this.m_xmlAttribute[num2].valueDecimalIndex = 0;
						}
					}
				}
				if (chars[num3] == 61)
				{
					b = 1;
				}
				if (b == 0 && chars[num3] == 32)
				{
					if (flag)
					{
						return false;
					}
					flag = true;
					b = 2;
					tagType = TagType.None;
					num2++;
					this.m_xmlAttribute[num2].nameHashCode = 0;
					this.m_xmlAttribute[num2].valueType = TagType.None;
					this.m_xmlAttribute[num2].valueHashCode = 0;
					this.m_xmlAttribute[num2].valueStartIndex = 0;
					this.m_xmlAttribute[num2].valueLength = 0;
					this.m_xmlAttribute[num2].valueDecimalIndex = 0;
				}
				if (b == 0)
				{
					this.m_xmlAttribute[num2].nameHashCode = (this.m_xmlAttribute[num2].nameHashCode << 3) - this.m_xmlAttribute[num2].nameHashCode + chars[num3];
				}
				if (b == 2 && chars[num3] == 32)
				{
					b = 0;
				}
				num3++;
			}
			if (!flag2)
			{
				return false;
			}
			if (this.tag_NoParsing && this.m_xmlAttribute[0].nameHashCode != 53822163 && this.m_xmlAttribute[0].nameHashCode != 49429939)
			{
				return false;
			}
			if (this.m_xmlAttribute[0].nameHashCode == 53822163 || this.m_xmlAttribute[0].nameHashCode == 49429939)
			{
				this.tag_NoParsing = false;
				return true;
			}
			if (this.m_htmlTag[0] == '#' && num == 7)
			{
				this.m_htmlColor = this.HexCharsToColor(this.m_htmlTag, num);
				this.m_colorStack.Add(this.m_htmlColor);
				return true;
			}
			if (this.m_htmlTag[0] == '#' && num == 9)
			{
				this.m_htmlColor = this.HexCharsToColor(this.m_htmlTag, num);
				this.m_colorStack.Add(this.m_htmlColor);
				return true;
			}
			int nameHashCode = this.m_xmlAttribute[0].nameHashCode;
			float num10;
			int valueHashCode3;
			if (nameHashCode > 230446)
			{
				if (nameHashCode <= 6971027)
				{
					if (nameHashCode > 1112618)
					{
						if (nameHashCode <= 1750458)
						{
							if (nameHashCode <= 1441524)
							{
								if (nameHashCode <= 1286342)
								{
									if (nameHashCode == 1117479)
									{
										goto IL_22FF;
									}
									if (nameHashCode != 1286342)
									{
										return false;
									}
									goto IL_32B4;
								}
								else if (nameHashCode != 1356515)
								{
									if (nameHashCode != 1441524)
									{
										return false;
									}
									goto IL_27C2;
								}
							}
							else if (nameHashCode <= 1524585)
							{
								if (nameHashCode == 1482398)
								{
									goto IL_2EC9;
								}
								if (nameHashCode != 1524585)
								{
									return false;
								}
								goto IL_26EE;
							}
							else
							{
								if (nameHashCode == 1619421)
								{
									goto IL_299C;
								}
								if (nameHashCode != 1750458)
								{
									return false;
								}
								return false;
							}
						}
						else if (nameHashCode <= 2109854)
						{
							if (nameHashCode <= 1983971)
							{
								if (nameHashCode == 1913798)
								{
									goto IL_32B4;
								}
								if (nameHashCode != 1983971)
								{
									return false;
								}
							}
							else
							{
								if (nameHashCode == 2068980)
								{
									goto IL_27C2;
								}
								if (nameHashCode != 2109854)
								{
									return false;
								}
								goto IL_2EC9;
							}
						}
						else if (nameHashCode <= 2246877)
						{
							if (nameHashCode == 2152041)
							{
								goto IL_26EE;
							}
							if (nameHashCode != 2246877)
							{
								return false;
							}
							goto IL_299C;
						}
						else
						{
							if (nameHashCode == 6815845)
							{
								goto IL_3304;
							}
							if (nameHashCode == 6886018)
							{
								goto IL_26E1;
							}
							if (nameHashCode != 6971027)
							{
								return false;
							}
							goto IL_28A4;
						}
						num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
						if (num10 == -9999f || num10 == 0f)
						{
							return false;
						}
						switch (tagUnits)
						{
						case TagUnits.Pixels:
							this.m_cSpacing = num10;
							break;
						case TagUnits.FontUnits:
							this.m_cSpacing = num10;
							this.m_cSpacing *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
							break;
						case TagUnits.Percentage:
							return false;
						}
						return true;
						IL_26EE:
						num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
						if (num10 == -9999f || num10 == 0f)
						{
							return false;
						}
						switch (tagUnits)
						{
						case TagUnits.Pixels:
							this.m_monoSpacing = num10;
							break;
						case TagUnits.FontUnits:
							this.m_monoSpacing = num10;
							this.m_monoSpacing *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
							break;
						case TagUnits.Percentage:
							return false;
						}
						return true;
						IL_27C2:
						num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
						if (num10 == -9999f || num10 == 0f)
						{
							return false;
						}
						switch (tagUnits)
						{
						case TagUnits.Pixels:
							this.tag_Indent = num10;
							break;
						case TagUnits.FontUnits:
							this.tag_Indent = num10;
							this.tag_Indent *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
							break;
						case TagUnits.Percentage:
							this.tag_Indent = this.m_marginWidth * num10 / 100f;
							break;
						}
						this.m_indentStack.Add(this.tag_Indent);
						this.m_xAdvance = this.tag_Indent;
						return true;
						IL_299C:
						int valueHashCode = this.m_xmlAttribute[0].valueHashCode;
						TMP_SpriteAsset tmp_SpriteAsset;
						if (this.m_xmlAttribute[0].valueType == TagType.None || this.m_xmlAttribute[0].valueType == TagType.NumericalValue)
						{
							if (this.m_defaultSpriteAsset == null)
							{
								if (TMP_Settings.defaultSpriteAsset != null)
								{
									this.m_defaultSpriteAsset = TMP_Settings.defaultSpriteAsset;
								}
								else
								{
									this.m_defaultSpriteAsset = Resources.Load<TMP_SpriteAsset>("Sprite Assets/Default Sprite Asset");
								}
							}
							this.m_currentSpriteAsset = this.m_defaultSpriteAsset;
							if (this.m_currentSpriteAsset == null)
							{
								return false;
							}
						}
						else if (MaterialReferenceManager.TryGetSpriteAsset(valueHashCode, out tmp_SpriteAsset))
						{
							this.m_currentSpriteAsset = tmp_SpriteAsset;
						}
						else
						{
							if (tmp_SpriteAsset == null)
							{
								tmp_SpriteAsset = Resources.Load<TMP_SpriteAsset>(TMP_Settings.defaultSpriteAssetPath + new string(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength));
							}
							if (tmp_SpriteAsset == null)
							{
								return false;
							}
							MaterialReferenceManager.AddSpriteAsset(valueHashCode, tmp_SpriteAsset);
							this.m_currentSpriteAsset = tmp_SpriteAsset;
						}
						if (this.m_xmlAttribute[0].valueType == TagType.NumericalValue)
						{
							int num11 = (int)this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
							if (num11 == -9999)
							{
								return false;
							}
							if (num11 > this.m_currentSpriteAsset.spriteInfoList.Count - 1)
							{
								return false;
							}
							this.m_spriteIndex = num11;
						}
						else if (this.m_xmlAttribute[1].nameHashCode == 43347 || this.m_xmlAttribute[1].nameHashCode == 30547)
						{
							int spriteIndex = this.m_currentSpriteAsset.GetSpriteIndex(this.m_xmlAttribute[1].valueHashCode);
							if (spriteIndex == -1)
							{
								return false;
							}
							this.m_spriteIndex = spriteIndex;
						}
						else
						{
							if (this.m_xmlAttribute[1].nameHashCode != 295562 && this.m_xmlAttribute[1].nameHashCode != 205930)
							{
								return false;
							}
							int num12 = (int)this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[1].valueStartIndex, this.m_xmlAttribute[1].valueLength, this.m_xmlAttribute[1].valueDecimalIndex);
							if (num12 == -9999)
							{
								return false;
							}
							if (num12 > this.m_currentSpriteAsset.spriteInfoList.Count - 1)
							{
								return false;
							}
							this.m_spriteIndex = num12;
						}
						this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentSpriteAsset.material, this.m_currentSpriteAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
						this.m_spriteColor = TMP_Text.s_colorWhite;
						this.m_tintSprite = false;
						if (this.m_xmlAttribute[1].nameHashCode == 45819 || this.m_xmlAttribute[1].nameHashCode == 33019)
						{
							this.m_tintSprite = (this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[1].valueStartIndex, this.m_xmlAttribute[1].valueLength, this.m_xmlAttribute[1].valueDecimalIndex) != 0f);
						}
						else if (this.m_xmlAttribute[2].nameHashCode == 45819 || this.m_xmlAttribute[2].nameHashCode == 33019)
						{
							this.m_tintSprite = (this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[2].valueStartIndex, this.m_xmlAttribute[2].valueLength, this.m_xmlAttribute[2].valueDecimalIndex) != 0f);
						}
						if (this.m_xmlAttribute[1].nameHashCode == 281955 || this.m_xmlAttribute[1].nameHashCode == 192323)
						{
							this.m_spriteColor = this.HexCharsToColor(this.m_htmlTag, this.m_xmlAttribute[1].valueStartIndex, this.m_xmlAttribute[1].valueLength);
						}
						else if (this.m_xmlAttribute[2].nameHashCode == 281955 || this.m_xmlAttribute[2].nameHashCode == 192323)
						{
							this.m_spriteColor = this.HexCharsToColor(this.m_htmlTag, this.m_xmlAttribute[2].valueStartIndex, this.m_xmlAttribute[2].valueLength);
						}
						this.m_xmlAttribute[1].nameHashCode = 0;
						this.m_xmlAttribute[2].nameHashCode = 0;
						this.m_textElementType = TMP_TextElementType.Sprite;
						return true;
						IL_2EC9:
						num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
						if (num10 == -9999f || num10 == 0f)
						{
							return false;
						}
						this.m_marginLeft = num10;
						switch (tagUnits)
						{
						case TagUnits.FontUnits:
							this.m_marginLeft *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
							break;
						case TagUnits.Percentage:
							this.m_marginLeft = (this.m_marginWidth - ((this.m_width != -1f) ? this.m_width : 0f)) * this.m_marginLeft / 100f;
							break;
						}
						this.m_marginLeft = ((this.m_marginLeft >= 0f) ? this.m_marginLeft : 0f);
						this.m_marginRight = this.m_marginLeft;
						return true;
						IL_32B4:
						int valueHashCode2 = this.m_xmlAttribute[0].valueHashCode;
						if (this.m_isParsingText)
						{
							this.m_actionStack.Add(valueHashCode2);
							Debug.Log("Action ID: [" + valueHashCode2.ToString() + "] First character index: " + this.m_characterCount.ToString());
						}
						return true;
					}
					TMP_Style style;
					if (nameHashCode > 322689)
					{
						if (nameHashCode <= 1022986)
						{
							if (nameHashCode <= 976214)
							{
								if (nameHashCode == 327550)
								{
									goto IL_2273;
								}
								if (nameHashCode != 976214)
								{
									return false;
								}
							}
							else
							{
								if (nameHashCode == 982252)
								{
									goto IL_27AF;
								}
								if (nameHashCode != 1022986)
								{
									return false;
								}
								goto IL_237B;
							}
						}
						else if (nameHashCode <= 1065846)
						{
							if (nameHashCode == 1027847)
							{
								goto IL_22FF;
							}
							if (nameHashCode != 1065846)
							{
								return false;
							}
						}
						else
						{
							if (nameHashCode == 1071884)
							{
								goto IL_27AF;
							}
							if (nameHashCode != 1112618)
							{
								return false;
							}
							goto IL_237B;
						}
						this.m_lineJustification = this.m_textAlignment;
						return true;
						IL_237B:
						style = TMP_StyleSheet.GetStyle(this.m_xmlAttribute[0].valueHashCode);
						if (style == null)
						{
							style = TMP_StyleSheet.GetStyle(this.m_styleStack.CurrentItem());
							this.m_styleStack.Remove();
						}
						if (style == null)
						{
							return false;
						}
						for (int i = 0; i < style.styleClosingTagArray.Length; i++)
						{
							if (style.styleClosingTagArray[i] == 60)
							{
								this.ValidateHtmlTag(style.styleClosingTagArray, i + 1, out i);
							}
						}
						return true;
						IL_27AF:
						this.m_htmlColor = this.m_colorStack.Remove();
						return true;
					}
					if (nameHashCode <= 276254)
					{
						if (nameHashCode <= 237918)
						{
							if (nameHashCode != 233057)
							{
								if (nameHashCode != 237918)
								{
									return false;
								}
								goto IL_2273;
							}
						}
						else
						{
							if (nameHashCode == 275917)
							{
								goto IL_21FB;
							}
							if (nameHashCode != 276254)
							{
								return false;
							}
							goto IL_2020;
						}
					}
					else if (nameHashCode <= 281955)
					{
						if (nameHashCode == 280416)
						{
							return false;
						}
						if (nameHashCode != 281955)
						{
							return false;
						}
						goto IL_23F7;
					}
					else
					{
						if (nameHashCode == 320078)
						{
							goto IL_1F6C;
						}
						if (nameHashCode != 322689)
						{
							return false;
						}
					}
					style = TMP_StyleSheet.GetStyle(this.m_xmlAttribute[0].valueHashCode);
					if (style == null)
					{
						return false;
					}
					this.m_styleStack.Add(style.hashCode);
					for (int j = 0; j < style.styleOpeningTagArray.Length; j++)
					{
						if (style.styleOpeningTagArray[j] == 60 && !this.ValidateHtmlTag(style.styleOpeningTagArray, j + 1, out j))
						{
							return false;
						}
					}
					return true;
					IL_2273:
					num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
					if (num10 == -9999f || num10 == 0f)
					{
						return false;
					}
					switch (tagUnits)
					{
					case TagUnits.Pixels:
						this.m_width = num10;
						break;
					case TagUnits.FontUnits:
						return false;
					case TagUnits.Percentage:
						this.m_width = this.m_marginWidth * num10 / 100f;
						break;
					}
					return true;
					IL_22FF:
					this.m_width = -1f;
					return true;
				}
				if (nameHashCode > 54741026)
				{
					if (nameHashCode <= 566686826)
					{
						if (nameHashCode <= 374360934)
						{
							if (nameHashCode <= 103415287)
							{
								if (nameHashCode != 72669687 && nameHashCode != 103415287)
								{
									return false;
								}
								valueHashCode3 = this.m_xmlAttribute[0].valueHashCode;
								if (valueHashCode3 != 764638571 && valueHashCode3 != 523367755)
								{
									Material material;
									if (MaterialReferenceManager.TryGetMaterial(valueHashCode3, out material))
									{
										if (this.m_currentFontAsset.atlas.GetInstanceID() != material.GetTexture(ShaderUtilities.ID_MainTex).GetInstanceID())
										{
											return false;
										}
										this.m_currentMaterial = material;
										this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentMaterial, this.m_currentFontAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
										this.m_materialReferenceStack.Add(this.m_materialReferences[this.m_currentMaterialIndex]);
									}
									else
									{
										material = Resources.Load<Material>(TMP_Settings.defaultFontAssetPath + new string(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength));
										if (material == null)
										{
											return false;
										}
										if (this.m_currentFontAsset.atlas.GetInstanceID() != material.GetTexture(ShaderUtilities.ID_MainTex).GetInstanceID())
										{
											return false;
										}
										MaterialReferenceManager.AddFontMaterial(valueHashCode3, material);
										this.m_currentMaterial = material;
										this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentMaterial, this.m_currentFontAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
										this.m_materialReferenceStack.Add(this.m_materialReferences[this.m_currentMaterialIndex]);
									}
									return true;
								}
								if (this.m_currentFontAsset.atlas.GetInstanceID() != this.m_currentMaterial.GetTexture(ShaderUtilities.ID_MainTex).GetInstanceID())
								{
									return false;
								}
								this.m_currentMaterial = this.m_materialReferences[0].material;
								this.m_currentMaterialIndex = 0;
								this.m_materialReferenceStack.Add(this.m_materialReferences[0]);
								return true;
							}
							else
							{
								if (nameHashCode != 343615334 && nameHashCode != 374360934)
								{
									return false;
								}
								if (this.m_currentMaterial.GetTexture(ShaderUtilities.ID_MainTex).GetInstanceID() != this.m_materialReferenceStack.PreviousItem().material.GetTexture(ShaderUtilities.ID_MainTex).GetInstanceID())
								{
									return false;
								}
								MaterialReference materialReference = this.m_materialReferenceStack.Remove();
								this.m_currentMaterial = materialReference.material;
								this.m_currentMaterialIndex = materialReference.index;
								return true;
							}
						}
						else if (nameHashCode <= 514803617)
						{
							if (nameHashCode == 457225591)
							{
								goto IL_1537;
							}
							if (nameHashCode != 514803617)
							{
								return false;
							}
						}
						else
						{
							if (nameHashCode == 551025096)
							{
								goto IL_2EA7;
							}
							if (nameHashCode != 566686826)
							{
								return false;
							}
							goto IL_2E85;
						}
					}
					else if (nameHashCode <= 1100728678)
					{
						if (nameHashCode <= 766244328)
						{
							if (nameHashCode != 730022849)
							{
								if (nameHashCode != 766244328)
								{
									return false;
								}
								goto IL_2EA7;
							}
						}
						else
						{
							if (nameHashCode == 781906058)
							{
								goto IL_2E85;
							}
							if (nameHashCode != 1100728678)
							{
								return false;
							}
							goto IL_2FE7;
						}
					}
					else if (nameHashCode <= 1109386397)
					{
						if (nameHashCode == 1109349752)
						{
							goto IL_31DB;
						}
						if (nameHashCode != 1109386397)
						{
							return false;
						}
						goto IL_28B7;
					}
					else
					{
						if (nameHashCode == 1897350193)
						{
							goto IL_329E;
						}
						if (nameHashCode == 1897386838)
						{
							goto IL_298F;
						}
						if (nameHashCode != 2012149182)
						{
							return false;
						}
						goto IL_139E;
					}
					this.m_style |= FontStyles.LowerCase;
					return true;
					IL_2EA7:
					this.m_style |= FontStyles.SmallCaps;
					return true;
				}
				if (nameHashCode <= 9133802)
				{
					if (nameHashCode <= 7513474)
					{
						if (nameHashCode <= 7054088)
						{
							if (nameHashCode == 7011901)
							{
								goto IL_2FCF;
							}
							if (nameHashCode != 7054088)
							{
								return false;
							}
						}
						else
						{
							if (nameHashCode == 7443301)
							{
								goto IL_3304;
							}
							if (nameHashCode != 7513474)
							{
								return false;
							}
							goto IL_26E1;
						}
					}
					else if (nameHashCode <= 7639357)
					{
						if (nameHashCode == 7598483)
						{
							goto IL_28A4;
						}
						if (nameHashCode != 7639357)
						{
							return false;
						}
						goto IL_2FCF;
					}
					else if (nameHashCode != 7681544)
					{
						if (nameHashCode != 9133802)
						{
							return false;
						}
						goto IL_2E85;
					}
					this.m_monoSpacing = 0f;
					return true;
					IL_2FCF:
					this.m_marginLeft = 0f;
					this.m_marginRight = 0f;
					return true;
				}
				if (nameHashCode <= 15115642)
				{
					if (nameHashCode <= 11642281)
					{
						if (nameHashCode != 10723418)
						{
							if (nameHashCode != 11642281)
							{
								return false;
							}
							goto IL_1621;
						}
					}
					else
					{
						if (nameHashCode == 13526026)
						{
							goto IL_2E85;
						}
						if (nameHashCode != 15115642)
						{
							return false;
						}
					}
					this.tag_NoParsing = true;
					return true;
				}
				if (nameHashCode > 47840323)
				{
					if (nameHashCode != 50348802)
					{
						if (nameHashCode == 52232547)
						{
							goto IL_2E96;
						}
						if (nameHashCode != 54741026)
						{
							return false;
						}
					}
					this.m_baselineOffset = 0f;
					return true;
				}
				if (nameHashCode != 16034505)
				{
					if (nameHashCode != 47840323)
					{
						return false;
					}
					goto IL_2E96;
				}
				IL_1621:
				num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
				if (num10 == -9999f || num10 == 0f)
				{
					return false;
				}
				switch (tagUnits)
				{
				case TagUnits.Pixels:
					this.m_baselineOffset = num10;
					return true;
				case TagUnits.FontUnits:
					this.m_baselineOffset = num10 * this.m_fontScale * this.m_fontAsset.fontInfo.Ascender;
					return true;
				case TagUnits.Percentage:
					return false;
				default:
					return false;
				}
				IL_2E85:
				this.m_style |= FontStyles.UpperCase;
				return true;
				IL_26E1:
				this.m_cSpacing = 0f;
				return true;
				IL_28A4:
				this.tag_Indent = this.m_indentStack.Remove();
				return true;
				IL_3304:
				if (this.m_isParsingText)
				{
					Debug.Log("Action ID: [" + this.m_actionStack.CurrentItem().ToString() + "] Last character index: " + (this.m_characterCount - 1).ToString());
				}
				this.m_actionStack.Remove();
				return true;
			}
			if (nameHashCode <= 4556)
			{
				if (nameHashCode > 66)
				{
					if (nameHashCode <= 395)
					{
						if (nameHashCode <= 98)
						{
							if (nameHashCode <= 83)
							{
								if (nameHashCode != 73)
								{
									if (nameHashCode != 83)
									{
										return false;
									}
									goto IL_1111;
								}
							}
							else
							{
								if (nameHashCode == 85)
								{
									goto IL_1140;
								}
								if (nameHashCode != 98)
								{
									return false;
								}
								goto IL_1098;
							}
						}
						else if (nameHashCode <= 115)
						{
							if (nameHashCode != 105)
							{
								if (nameHashCode != 115)
								{
									return false;
								}
								goto IL_1111;
							}
						}
						else
						{
							if (nameHashCode == 117)
							{
								goto IL_1140;
							}
							if (nameHashCode != 395)
							{
								return false;
							}
							goto IL_10C3;
						}
						this.m_style |= FontStyles.Italic;
						return true;
						IL_1111:
						this.m_style |= FontStyles.Strikethrough;
						return true;
						IL_1140:
						this.m_style |= FontStyles.Underline;
						return true;
					}
					if (nameHashCode <= 426)
					{
						if (nameHashCode <= 412)
						{
							if (nameHashCode != 402)
							{
								if (nameHashCode != 412)
								{
									return false;
								}
								goto IL_1122;
							}
						}
						else
						{
							if (nameHashCode == 414)
							{
								goto IL_1150;
							}
							if (nameHashCode != 426)
							{
								return false;
							}
							return true;
						}
					}
					else if (nameHashCode <= 434)
					{
						if (nameHashCode == 427)
						{
							goto IL_10C3;
						}
						if (nameHashCode != 434)
						{
							return false;
						}
					}
					else
					{
						if (nameHashCode == 444)
						{
							goto IL_1122;
						}
						if (nameHashCode == 446)
						{
							goto IL_1150;
						}
						if (nameHashCode != 4556)
						{
							return false;
						}
						goto IL_1566;
					}
					this.m_style &= (FontStyles)(-3);
					return true;
					IL_1122:
					if ((this.m_fontStyle & FontStyles.Strikethrough) != FontStyles.Strikethrough)
					{
						this.m_style &= (FontStyles)(-65);
					}
					return true;
					IL_1150:
					if ((this.m_fontStyle & FontStyles.Underline) != FontStyles.Underline)
					{
						this.m_style &= (FontStyles)(-5);
					}
					return true;
					IL_10C3:
					if ((this.m_fontStyle & FontStyles.Bold) != FontStyles.Bold)
					{
						this.m_style &= (FontStyles)(-2);
						this.m_fontWeightInternal = this.m_fontWeightStack.Remove();
					}
					return true;
				}
				if (nameHashCode <= -1616441709)
				{
					if (nameHashCode <= -1831660941)
					{
						if (nameHashCode <= -1883544150)
						{
							if (nameHashCode == -1885698441)
							{
								goto IL_1537;
							}
							if (nameHashCode != -1883544150)
							{
								return false;
							}
						}
						else
						{
							if (nameHashCode == -1847322671)
							{
								goto IL_2EB8;
							}
							if (nameHashCode != -1831660941)
							{
								return false;
							}
							goto IL_2E96;
						}
					}
					else if (nameHashCode <= -1668324918)
					{
						if (nameHashCode == -1690034531)
						{
							goto IL_30E1;
						}
						if (nameHashCode != -1668324918)
						{
							return false;
						}
					}
					else
					{
						if (nameHashCode == -1632103439)
						{
							goto IL_2EB8;
						}
						if (nameHashCode != -1616441709)
						{
							return false;
						}
						goto IL_2E96;
					}
					this.m_style &= (FontStyles)(-9);
					return true;
					IL_2EB8:
					this.m_style &= (FontStyles)(-33);
					return true;
				}
				if (nameHashCode <= -842656867)
				{
					if (nameHashCode <= -855002522)
					{
						if (nameHashCode != -884817987)
						{
							if (nameHashCode != -855002522)
							{
								return false;
							}
							goto IL_2FE7;
						}
					}
					else
					{
						if (nameHashCode == -842693512)
						{
							goto IL_31DB;
						}
						if (nameHashCode != -842656867)
						{
							return false;
						}
						goto IL_28B7;
					}
				}
				else if (nameHashCode <= -445537194)
				{
					if (nameHashCode == -445573839)
					{
						goto IL_329E;
					}
					if (nameHashCode != -445537194)
					{
						return false;
					}
					goto IL_298F;
				}
				else
				{
					if (nameHashCode == -330774850)
					{
						goto IL_139E;
					}
					if (nameHashCode != 66)
					{
						return false;
					}
					goto IL_1098;
				}
				IL_30E1:
				num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
				if (num10 == -9999f || num10 == 0f)
				{
					return false;
				}
				this.m_marginRight = num10;
				switch (tagUnits)
				{
				case TagUnits.FontUnits:
					this.m_marginRight *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
					break;
				case TagUnits.Percentage:
					this.m_marginRight = (this.m_marginWidth - ((this.m_width != -1f) ? this.m_width : 0f)) * this.m_marginRight / 100f;
					break;
				}
				this.m_marginRight = ((this.m_marginRight >= 0f) ? this.m_marginRight : 0f);
				return true;
				IL_1098:
				this.m_style |= FontStyles.Bold;
				this.m_fontWeightInternal = 700;
				this.m_fontWeightStack.Add(700);
				return true;
			}
			if (nameHashCode <= 32745)
			{
				if (nameHashCode <= 20863)
				{
					if (nameHashCode <= 6552)
					{
						if (nameHashCode <= 4742)
						{
							if (nameHashCode != 4728)
							{
								if (nameHashCode != 4742)
								{
									return false;
								}
								goto IL_1285;
							}
						}
						else
						{
							if (nameHashCode == 6380)
							{
								goto IL_1566;
							}
							if (nameHashCode != 6552)
							{
								return false;
							}
						}
						this.m_fontScaleMultiplier = ((this.m_currentFontAsset.fontInfo.SubSize > 0f) ? this.m_currentFontAsset.fontInfo.SubSize : 1f);
						this.m_baselineOffset = this.m_currentFontAsset.fontInfo.SubscriptOffset * this.m_fontScale * this.m_fontScaleMultiplier;
						this.m_style |= FontStyles.Subscript;
						return true;
					}
					if (nameHashCode <= 20677)
					{
						if (nameHashCode != 6566)
						{
							if (nameHashCode != 20677)
							{
								return false;
							}
							goto IL_1618;
						}
					}
					else
					{
						if (nameHashCode == 20849)
						{
							goto IL_11D8;
						}
						if (nameHashCode != 20863)
						{
							return false;
						}
						goto IL_12F1;
					}
					IL_1285:
					this.m_fontScaleMultiplier = ((this.m_currentFontAsset.fontInfo.SubSize > 0f) ? this.m_currentFontAsset.fontInfo.SubSize : 1f);
					this.m_baselineOffset = this.m_currentFontAsset.fontInfo.SuperscriptOffset * this.m_fontScale * this.m_fontScaleMultiplier;
					this.m_style |= FontStyles.Superscript;
					return true;
				}
				if (nameHashCode <= 28511)
				{
					if (nameHashCode <= 22673)
					{
						if (nameHashCode == 22501)
						{
							goto IL_1618;
						}
						if (nameHashCode != 22673)
						{
							return false;
						}
					}
					else
					{
						if (nameHashCode == 22687)
						{
							goto IL_12F1;
						}
						if (nameHashCode != 28511)
						{
							return false;
						}
						goto IL_19F1;
					}
				}
				else if (nameHashCode <= 31169)
				{
					if (nameHashCode == 30266)
					{
						goto IL_2068;
					}
					if (nameHashCode != 31169)
					{
						return false;
					}
					goto IL_170B;
				}
				else
				{
					if (nameHashCode == 31191)
					{
						goto IL_16C7;
					}
					if (nameHashCode != 32745)
					{
						return false;
					}
					goto IL_171D;
				}
				IL_11D8:
				if ((this.m_style & FontStyles.Subscript) == FontStyles.Subscript)
				{
					if ((this.m_style & FontStyles.Superscript) == FontStyles.Superscript)
					{
						this.m_fontScaleMultiplier = ((this.m_currentFontAsset.fontInfo.SubSize > 0f) ? this.m_currentFontAsset.fontInfo.SubSize : 1f);
						this.m_baselineOffset = this.m_currentFontAsset.fontInfo.SuperscriptOffset * this.m_fontScale * this.m_fontScaleMultiplier;
					}
					else
					{
						this.m_baselineOffset = 0f;
						this.m_fontScaleMultiplier = 1f;
					}
					this.m_style &= (FontStyles)(-257);
				}
				return true;
				IL_12F1:
				if ((this.m_style & FontStyles.Superscript) == FontStyles.Superscript)
				{
					if ((this.m_style & FontStyles.Subscript) == FontStyles.Subscript)
					{
						this.m_fontScaleMultiplier = ((this.m_currentFontAsset.fontInfo.SubSize > 0f) ? this.m_currentFontAsset.fontInfo.SubSize : 1f);
						this.m_baselineOffset = this.m_currentFontAsset.fontInfo.SubscriptOffset * this.m_fontScale * this.m_fontScaleMultiplier;
					}
					else
					{
						this.m_baselineOffset = 0f;
						this.m_fontScaleMultiplier = 1f;
					}
					this.m_style &= (FontStyles)(-129);
				}
				return true;
				IL_1618:
				this.m_isIgnoringAlignment = false;
				return true;
			}
			if (nameHashCode > 144016)
			{
				if (nameHashCode <= 156816)
				{
					if (nameHashCode <= 154158)
					{
						if (nameHashCode != 145592)
						{
							if (nameHashCode != 154158)
							{
								return false;
							}
							goto IL_1CD0;
						}
					}
					else
					{
						if (nameHashCode == 155913)
						{
							goto IL_2197;
						}
						if (nameHashCode != 156816)
						{
							return false;
						}
						goto IL_1714;
					}
				}
				else if (nameHashCode <= 186285)
				{
					if (nameHashCode != 158392)
					{
						if (nameHashCode != 186285)
						{
							return false;
						}
						goto IL_21FB;
					}
				}
				else
				{
					if (nameHashCode == 186622)
					{
						goto IL_2020;
					}
					if (nameHashCode == 192323)
					{
						goto IL_23F7;
					}
					if (nameHashCode != 230446)
					{
						return false;
					}
					goto IL_1F6C;
				}
				this.m_currentFontSize = this.m_sizeStack.Remove();
				this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
				return true;
			}
			if (nameHashCode <= 43991)
			{
				if (nameHashCode <= 43066)
				{
					if (nameHashCode == 41311)
					{
						goto IL_19F1;
					}
					if (nameHashCode != 43066)
					{
						return false;
					}
					goto IL_2068;
				}
				else
				{
					if (nameHashCode == 43969)
					{
						goto IL_170B;
					}
					if (nameHashCode != 43991)
					{
						return false;
					}
					goto IL_16C7;
				}
			}
			else if (nameHashCode <= 141358)
			{
				if (nameHashCode == 45545)
				{
					goto IL_171D;
				}
				if (nameHashCode != 141358)
				{
					return false;
				}
				goto IL_1CD0;
			}
			else
			{
				if (nameHashCode == 143113)
				{
					goto IL_2197;
				}
				if (nameHashCode != 144016)
				{
					return false;
				}
			}
			IL_1714:
			this.m_isNonBreakingSpace = false;
			return true;
			IL_1CD0:
			MaterialReference materialReference2 = this.m_materialReferenceStack.Remove();
			this.m_currentFontAsset = materialReference2.fontAsset;
			this.m_currentMaterial = materialReference2.material;
			this.m_currentMaterialIndex = materialReference2.index;
			this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
			return true;
			IL_2197:
			if (this.m_isParsingText)
			{
				this.m_textInfo.linkInfo[this.m_textInfo.linkCount].linkTextLength = this.m_characterCount - this.m_textInfo.linkInfo[this.m_textInfo.linkCount].linkTextfirstCharacterIndex;
				this.m_textInfo.linkCount++;
			}
			return true;
			IL_16C7:
			if (this.m_overflowMode == TextOverflowModes.Page)
			{
				this.m_xAdvance = 0f + this.tag_LineIndent + this.tag_Indent;
				this.m_lineOffset = 0f;
				this.m_pageNumber++;
				this.m_isNewPage = true;
			}
			return true;
			IL_170B:
			this.m_isNonBreakingSpace = true;
			return true;
			IL_171D:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			switch (tagUnits)
			{
			case TagUnits.Pixels:
				if (this.m_htmlTag[5] == '+')
				{
					this.m_currentFontSize = this.m_fontSize + num10;
					this.m_sizeStack.Add(this.m_currentFontSize);
					this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
					return true;
				}
				if (this.m_htmlTag[5] == '-')
				{
					this.m_currentFontSize = this.m_fontSize + num10;
					this.m_sizeStack.Add(this.m_currentFontSize);
					this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
					return true;
				}
				this.m_currentFontSize = num10;
				this.m_sizeStack.Add(this.m_currentFontSize);
				this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
				return true;
			case TagUnits.FontUnits:
				this.m_currentFontSize = this.m_fontSize * num10;
				this.m_sizeStack.Add(this.m_currentFontSize);
				this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
				return true;
			case TagUnits.Percentage:
				this.m_currentFontSize = this.m_fontSize * num10 / 100f;
				this.m_sizeStack.Add(this.m_currentFontSize);
				this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
				return true;
			default:
				return false;
			}
			IL_19F1:
			int valueHashCode4 = this.m_xmlAttribute[0].valueHashCode;
			int nameHashCode2 = this.m_xmlAttribute[1].nameHashCode;
			valueHashCode3 = this.m_xmlAttribute[1].valueHashCode;
			if (valueHashCode4 == 764638571 || valueHashCode4 == 523367755)
			{
				this.m_currentFontAsset = this.m_materialReferences[0].fontAsset;
				this.m_currentMaterial = this.m_materialReferences[0].material;
				this.m_currentMaterialIndex = 0;
				this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
				this.m_materialReferenceStack.Add(this.m_materialReferences[0]);
				return true;
			}
			TMP_FontAsset tmp_FontAsset;
			if (!MaterialReferenceManager.TryGetFontAsset(valueHashCode4, out tmp_FontAsset))
			{
				tmp_FontAsset = Resources.Load<TMP_FontAsset>(TMP_Settings.defaultFontAssetPath + new string(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength));
				if (tmp_FontAsset == null)
				{
					return false;
				}
				MaterialReferenceManager.AddFontAsset(tmp_FontAsset);
			}
			if (nameHashCode2 == 0 && valueHashCode3 == 0)
			{
				this.m_currentMaterial = tmp_FontAsset.material;
				this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentMaterial, tmp_FontAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
				this.m_materialReferenceStack.Add(this.m_materialReferences[this.m_currentMaterialIndex]);
			}
			else
			{
				if (nameHashCode2 != 103415287 && nameHashCode2 != 72669687)
				{
					return false;
				}
				Material material;
				if (MaterialReferenceManager.TryGetMaterial(valueHashCode3, out material))
				{
					this.m_currentMaterial = material;
					this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentMaterial, tmp_FontAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
					this.m_materialReferenceStack.Add(this.m_materialReferences[this.m_currentMaterialIndex]);
				}
				else
				{
					material = Resources.Load<Material>(TMP_Settings.defaultFontAssetPath + new string(this.m_htmlTag, this.m_xmlAttribute[1].valueStartIndex, this.m_xmlAttribute[1].valueLength));
					if (material == null)
					{
						return false;
					}
					MaterialReferenceManager.AddFontMaterial(valueHashCode3, material);
					this.m_currentMaterial = material;
					this.m_currentMaterialIndex = MaterialReference.AddMaterialReference(this.m_currentMaterial, tmp_FontAsset, this.m_materialReferences, this.m_materialReferenceIndexLookup);
					this.m_materialReferenceStack.Add(this.m_materialReferences[this.m_currentMaterialIndex]);
				}
			}
			this.m_currentFontAsset = tmp_FontAsset;
			this.m_fontScale = this.m_currentFontSize / this.m_currentFontAsset.fontInfo.PointSize * this.m_currentFontAsset.fontInfo.Scale * (this.m_isOrthographic ? 1f : 0.1f);
			return true;
			IL_2068:
			if (this.m_isParsingText)
			{
				int linkCount = this.m_textInfo.linkCount;
				if (linkCount + 1 > this.m_textInfo.linkInfo.Length)
				{
					TMP_TextInfo.Resize<TMP_LinkInfo>(ref this.m_textInfo.linkInfo, linkCount + 1);
				}
				this.m_textInfo.linkInfo[linkCount].textComponent = this;
				this.m_textInfo.linkInfo[linkCount].hashCode = this.m_xmlAttribute[0].valueHashCode;
				this.m_textInfo.linkInfo[linkCount].linkTextfirstCharacterIndex = this.m_characterCount;
				this.m_textInfo.linkInfo[linkCount].linkIdFirstCharacterIndex = startIndex + this.m_xmlAttribute[0].valueStartIndex;
				this.m_textInfo.linkInfo[linkCount].linkIdLength = this.m_xmlAttribute[0].valueLength;
				this.m_textInfo.linkInfo[linkCount].SetLinkID(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength);
			}
			return true;
			IL_1566:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f)
			{
				return false;
			}
			switch (tagUnits)
			{
			case TagUnits.Pixels:
				this.m_xAdvance = num10;
				return true;
			case TagUnits.FontUnits:
				this.m_xAdvance = num10 * this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
				return true;
			case TagUnits.Percentage:
				this.m_xAdvance = this.m_marginWidth * num10 / 100f;
				return true;
			default:
				return false;
			}
			IL_139E:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			if ((this.m_fontStyle & FontStyles.Bold) == FontStyles.Bold)
			{
				return true;
			}
			this.m_style &= (FontStyles)(-2);
			int num13 = (int)num10;
			if (num13 <= 400)
			{
				if (num13 <= 200)
				{
					if (num13 != 100)
					{
						if (num13 == 200)
						{
							this.m_fontWeightInternal = 200;
						}
					}
					else
					{
						this.m_fontWeightInternal = 100;
					}
				}
				else if (num13 != 300)
				{
					if (num13 == 400)
					{
						this.m_fontWeightInternal = 400;
					}
				}
				else
				{
					this.m_fontWeightInternal = 300;
				}
			}
			else if (num13 <= 600)
			{
				if (num13 != 500)
				{
					if (num13 == 600)
					{
						this.m_fontWeightInternal = 600;
					}
				}
				else
				{
					this.m_fontWeightInternal = 500;
				}
			}
			else if (num13 != 700)
			{
				if (num13 != 800)
				{
					if (num13 == 900)
					{
						this.m_fontWeightInternal = 900;
					}
				}
				else
				{
					this.m_fontWeightInternal = 800;
				}
			}
			else
			{
				this.m_fontWeightInternal = 700;
				this.m_style |= FontStyles.Bold;
			}
			this.m_fontWeightStack.Add(this.m_fontWeightInternal);
			return true;
			IL_1537:
			this.m_fontWeightInternal = this.m_fontWeightStack.Remove();
			if (this.m_fontWeightInternal == 400)
			{
				this.m_style &= (FontStyles)(-2);
			}
			return true;
			IL_1F6C:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			switch (tagUnits)
			{
			case TagUnits.Pixels:
				this.m_xAdvance += num10;
				return true;
			case TagUnits.FontUnits:
				this.m_xAdvance += num10 * this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
				return true;
			case TagUnits.Percentage:
				return false;
			default:
				return false;
			}
			IL_2020:
			if (this.m_xmlAttribute[0].valueLength != 3)
			{
				return false;
			}
			this.m_htmlColor.a = (byte)(this.HexToInt(this.m_htmlTag[7]) * 16 + this.HexToInt(this.m_htmlTag[8]));
			return true;
			IL_21FB:
			num13 = this.m_xmlAttribute[0].valueHashCode;
			if (num13 <= -458210101)
			{
				if (num13 == -523808257)
				{
					this.m_lineJustification = TextAlignmentOptions.Justified;
					return true;
				}
				if (num13 == -458210101)
				{
					this.m_lineJustification = TextAlignmentOptions.Center;
					return true;
				}
			}
			else
			{
				if (num13 == 3774683)
				{
					this.m_lineJustification = TextAlignmentOptions.Left;
					return true;
				}
				if (num13 == 136703040)
				{
					this.m_lineJustification = TextAlignmentOptions.Right;
					return true;
				}
			}
			return false;
			IL_23F7:
			if (this.m_htmlTag[6] == '#' && num == 13)
			{
				this.m_htmlColor = this.HexCharsToColor(this.m_htmlTag, num);
				this.m_colorStack.Add(this.m_htmlColor);
				return true;
			}
			if (this.m_htmlTag[6] == '#' && num == 15)
			{
				this.m_htmlColor = this.HexCharsToColor(this.m_htmlTag, num);
				this.m_colorStack.Add(this.m_htmlColor);
				return true;
			}
			num13 = this.m_xmlAttribute[0].valueHashCode;
			if (num13 <= 26556144)
			{
				if (num13 <= 125395)
				{
					if (num13 == -36881330)
					{
						this.m_htmlColor = new Color32(160, 32, 240, byte.MaxValue);
						this.m_colorStack.Add(this.m_htmlColor);
						return true;
					}
					if (num13 == 125395)
					{
						this.m_htmlColor = Color.red;
						this.m_colorStack.Add(this.m_htmlColor);
						return true;
					}
				}
				else
				{
					if (num13 == 3573310)
					{
						this.m_htmlColor = Color.blue;
						this.m_colorStack.Add(this.m_htmlColor);
						return true;
					}
					if (num13 == 26556144)
					{
						this.m_htmlColor = new Color32(byte.MaxValue, 128, 0, byte.MaxValue);
						this.m_colorStack.Add(this.m_htmlColor);
						return true;
					}
				}
			}
			else if (num13 <= 121463835)
			{
				if (num13 == 117905991)
				{
					this.m_htmlColor = Color.black;
					this.m_colorStack.Add(this.m_htmlColor);
					return true;
				}
				if (num13 == 121463835)
				{
					this.m_htmlColor = Color.green;
					this.m_colorStack.Add(this.m_htmlColor);
					return true;
				}
			}
			else
			{
				if (num13 == 140357351)
				{
					this.m_htmlColor = Color.white;
					this.m_colorStack.Add(this.m_htmlColor);
					return true;
				}
				if (num13 == 554054276)
				{
					this.m_htmlColor = Color.yellow;
					this.m_colorStack.Add(this.m_htmlColor);
					return true;
				}
			}
			return false;
			IL_28B7:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			switch (tagUnits)
			{
			case TagUnits.Pixels:
				this.tag_LineIndent = num10;
				break;
			case TagUnits.FontUnits:
				this.tag_LineIndent = num10;
				this.tag_LineIndent *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
				break;
			case TagUnits.Percentage:
				this.tag_LineIndent = this.m_marginWidth * num10 / 100f;
				break;
			}
			this.m_xAdvance += this.tag_LineIndent;
			return true;
			IL_298F:
			this.tag_LineIndent = 0f;
			return true;
			IL_2E96:
			this.m_style &= (FontStyles)(-17);
			return true;
			IL_2FE7:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			this.m_marginLeft = num10;
			switch (tagUnits)
			{
			case TagUnits.FontUnits:
				this.m_marginLeft *= this.m_fontScale * this.m_fontAsset.fontInfo.TabWidth / (float)this.m_fontAsset.tabSize;
				break;
			case TagUnits.Percentage:
				this.m_marginLeft = (this.m_marginWidth - ((this.m_width != -1f) ? this.m_width : 0f)) * this.m_marginLeft / 100f;
				break;
			}
			this.m_marginLeft = ((this.m_marginLeft >= 0f) ? this.m_marginLeft : 0f);
			return true;
			IL_31DB:
			num10 = this.ConvertToFloat(this.m_htmlTag, this.m_xmlAttribute[0].valueStartIndex, this.m_xmlAttribute[0].valueLength, this.m_xmlAttribute[0].valueDecimalIndex);
			if (num10 == -9999f || num10 == 0f)
			{
				return false;
			}
			this.m_lineHeight = num10;
			switch (tagUnits)
			{
			case TagUnits.FontUnits:
				this.m_lineHeight *= this.m_fontAsset.fontInfo.LineHeight * this.m_fontScale;
				break;
			case TagUnits.Percentage:
				this.m_lineHeight = this.m_fontAsset.fontInfo.LineHeight * this.m_lineHeight / 100f * this.m_fontScale;
				break;
			}
			return true;
			IL_329E:
			this.m_lineHeight = 0f;
			return true;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000C5AA4 File Offset: 0x000C3CA4
		public TMP_Text()
		{
			this.m_materialReferences = new MaterialReference[32];
			this.m_materialReferenceIndexLookup = new Dictionary<int, int>();
			this.m_materialReferenceStack = new TMP_XmlTagStack<MaterialReference>(new MaterialReference[16]);
			this.m_fontColor32 = Color.white;
			this.m_fontColor = Color.white;
			this.m_fontColorGradient = new VertexGradient(Color.white);
			this.m_faceColor = Color.white;
			this.m_outlineColor = Color.black;
			this.m_fontSize = 36f;
			this.m_fontSizeBase = 36f;
			this.m_sizeStack = new TMP_XmlTagStack<float>(new float[16]);
			this.m_fontWeight = 400;
			this.m_fontWeightStack = new TMP_XmlTagStack<int>(new int[16]);
			this.m_textContainerLocalCorners = new Vector3[4];
			this.m_wordWrappingRatios = 0.4f;
			this.m_adaptiveJustificationThreshold = 10f;
			this.m_isRichText = true;
			this.m_parseCtrlCharacters = true;
			this.m_ignoreCulling = true;
			this.m_renderMode = TextRenderFlags.Render;
			this.m_maxVisibleCharacters = 99999;
			this.m_maxVisibleWords = 99999;
			this.m_maxVisibleLines = 99999;
			this.m_useMaxVisibleDescender = true;
			this.m_pageToDisplay = 1;
			this.m_margin = new Vector4(0f, 0f, 0f, 0f);
			this.m_width = -1f;
			this.m_flexibleHeight = -1f;
			this.m_flexibleWidth = -1f;
			this.m_htmlTag = new char[128];
			this.m_xmlAttribute = new XML_TagAttribute[8];
			this.m_indentStack = new TMP_XmlTagStack<float>(new float[16]);
			this.m_input_CharArray = new char[256];
			this.m_htmlColor = new Color(255f, 255f, 255f, 128f);
			this.m_colorStack = new TMP_XmlTagStack<Color32>(new Color32[16]);
			this.m_styleStack = new TMP_XmlTagStack<int>(new int[16]);
			this.m_actionStack = new TMP_XmlTagStack<int>(new int[16]);
			this.k_Power = new float[]
			{
				0.5f,
				0.05f,
				0.005f,
				0.0005f,
				5E-05f,
				5E-06f,
				5E-07f,
				5E-08f,
				5E-09f,
				5E-10f
			};
			base..ctor();
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000C5CD4 File Offset: 0x000C3ED4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Text()
		{
			TMP_Text.s_colorWhite = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			TMP_Text.k_LargePositiveVector2 = new Vector2(2.1474836E+09f, 2.1474836E+09f);
			TMP_Text.k_LargeNegativeVector2 = new Vector2(-2.1474836E+09f, -2.1474836E+09f);
			TMP_Text.k_LargePositiveFloat = 32768f;
			TMP_Text.k_LargeNegativeFloat = -32768f;
			TMP_Text.k_LargePositiveInt = int.MaxValue;
			TMP_Text.k_LargeNegativeInt = -2147483647;
		}

		// Token: 0x04002910 RID: 10512
		[SerializeField]
		protected string m_text;

		// Token: 0x04002911 RID: 10513
		[SerializeField]
		protected bool m_isRightToLeft;

		// Token: 0x04002912 RID: 10514
		[SerializeField]
		protected TMP_FontAsset m_fontAsset;

		// Token: 0x04002913 RID: 10515
		protected TMP_FontAsset m_currentFontAsset;

		// Token: 0x04002914 RID: 10516
		protected bool m_isSDFShader;

		// Token: 0x04002915 RID: 10517
		[SerializeField]
		protected Material m_sharedMaterial;

		// Token: 0x04002916 RID: 10518
		protected Material m_currentMaterial;

		// Token: 0x04002917 RID: 10519
		protected MaterialReference[] m_materialReferences;

		// Token: 0x04002918 RID: 10520
		protected Dictionary<int, int> m_materialReferenceIndexLookup;

		// Token: 0x04002919 RID: 10521
		protected TMP_XmlTagStack<MaterialReference> m_materialReferenceStack;

		// Token: 0x0400291A RID: 10522
		protected int m_currentMaterialIndex;

		// Token: 0x0400291B RID: 10523
		[SerializeField]
		protected Material[] m_fontSharedMaterials;

		// Token: 0x0400291C RID: 10524
		[SerializeField]
		protected Material m_fontMaterial;

		// Token: 0x0400291D RID: 10525
		[SerializeField]
		protected Material[] m_fontMaterials;

		// Token: 0x0400291E RID: 10526
		protected bool m_isMaterialDirty;

		// Token: 0x0400291F RID: 10527
		[FormerlySerializedAs("m_fontColor")]
		[SerializeField]
		protected Color32 m_fontColor32;

		// Token: 0x04002920 RID: 10528
		[SerializeField]
		protected Color m_fontColor;

		// Token: 0x04002921 RID: 10529
		protected static Color32 s_colorWhite;

		// Token: 0x04002922 RID: 10530
		[SerializeField]
		protected bool m_enableVertexGradient;

		// Token: 0x04002923 RID: 10531
		[SerializeField]
		protected VertexGradient m_fontColorGradient;

		// Token: 0x04002924 RID: 10532
		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset;

		// Token: 0x04002925 RID: 10533
		protected TMP_SpriteAsset m_spriteAsset;

		// Token: 0x04002926 RID: 10534
		[SerializeField]
		protected bool m_tintAllSprites;

		// Token: 0x04002927 RID: 10535
		protected bool m_tintSprite;

		// Token: 0x04002928 RID: 10536
		protected Color32 m_spriteColor;

		// Token: 0x04002929 RID: 10537
		[SerializeField]
		protected bool m_overrideHtmlColors;

		// Token: 0x0400292A RID: 10538
		[SerializeField]
		protected Color32 m_faceColor;

		// Token: 0x0400292B RID: 10539
		[SerializeField]
		protected Color32 m_outlineColor;

		// Token: 0x0400292C RID: 10540
		protected float m_outlineWidth;

		// Token: 0x0400292D RID: 10541
		[SerializeField]
		protected float m_fontSize;

		// Token: 0x0400292E RID: 10542
		protected float m_currentFontSize;

		// Token: 0x0400292F RID: 10543
		[SerializeField]
		protected float m_fontSizeBase;

		// Token: 0x04002930 RID: 10544
		protected TMP_XmlTagStack<float> m_sizeStack;

		// Token: 0x04002931 RID: 10545
		[SerializeField]
		protected int m_fontWeight;

		// Token: 0x04002932 RID: 10546
		protected int m_fontWeightInternal;

		// Token: 0x04002933 RID: 10547
		protected TMP_XmlTagStack<int> m_fontWeightStack;

		// Token: 0x04002934 RID: 10548
		[SerializeField]
		protected bool m_enableAutoSizing;

		// Token: 0x04002935 RID: 10549
		protected float m_maxFontSize;

		// Token: 0x04002936 RID: 10550
		protected float m_minFontSize;

		// Token: 0x04002937 RID: 10551
		[SerializeField]
		protected float m_fontSizeMin;

		// Token: 0x04002938 RID: 10552
		[SerializeField]
		protected float m_fontSizeMax;

		// Token: 0x04002939 RID: 10553
		[SerializeField]
		protected FontStyles m_fontStyle;

		// Token: 0x0400293A RID: 10554
		protected FontStyles m_style;

		// Token: 0x0400293B RID: 10555
		protected bool m_isUsingBold;

		// Token: 0x0400293C RID: 10556
		[SerializeField]
		[FormerlySerializedAs("m_lineJustification")]
		protected TextAlignmentOptions m_textAlignment;

		// Token: 0x0400293D RID: 10557
		protected TextAlignmentOptions m_lineJustification;

		// Token: 0x0400293E RID: 10558
		protected Vector3[] m_textContainerLocalCorners;

		// Token: 0x0400293F RID: 10559
		[SerializeField]
		protected float m_characterSpacing;

		// Token: 0x04002940 RID: 10560
		protected float m_cSpacing;

		// Token: 0x04002941 RID: 10561
		protected float m_monoSpacing;

		// Token: 0x04002942 RID: 10562
		[SerializeField]
		protected float m_lineSpacing;

		// Token: 0x04002943 RID: 10563
		protected float m_lineSpacingDelta;

		// Token: 0x04002944 RID: 10564
		protected float m_lineHeight;

		// Token: 0x04002945 RID: 10565
		[SerializeField]
		protected float m_lineSpacingMax;

		// Token: 0x04002946 RID: 10566
		[SerializeField]
		protected float m_paragraphSpacing;

		// Token: 0x04002947 RID: 10567
		[SerializeField]
		protected float m_charWidthMaxAdj;

		// Token: 0x04002948 RID: 10568
		protected float m_charWidthAdjDelta;

		// Token: 0x04002949 RID: 10569
		[SerializeField]
		protected bool m_enableWordWrapping;

		// Token: 0x0400294A RID: 10570
		protected bool m_isCharacterWrappingEnabled;

		// Token: 0x0400294B RID: 10571
		protected bool m_isNonBreakingSpace;

		// Token: 0x0400294C RID: 10572
		protected bool m_isIgnoringAlignment;

		// Token: 0x0400294D RID: 10573
		[SerializeField]
		protected float m_wordWrappingRatios;

		// Token: 0x0400294E RID: 10574
		[SerializeField]
		protected bool m_enableAdaptiveJustification;

		// Token: 0x0400294F RID: 10575
		protected float m_adaptiveJustificationThreshold;

		// Token: 0x04002950 RID: 10576
		[SerializeField]
		protected TextOverflowModes m_overflowMode;

		// Token: 0x04002951 RID: 10577
		protected bool m_isTextTruncated;

		// Token: 0x04002952 RID: 10578
		[SerializeField]
		protected bool m_enableKerning;

		// Token: 0x04002953 RID: 10579
		[SerializeField]
		protected bool m_enableExtraPadding;

		// Token: 0x04002954 RID: 10580
		[SerializeField]
		protected bool checkPaddingRequired;

		// Token: 0x04002955 RID: 10581
		[SerializeField]
		protected bool m_isRichText;

		// Token: 0x04002956 RID: 10582
		[SerializeField]
		protected bool m_parseCtrlCharacters;

		// Token: 0x04002957 RID: 10583
		protected bool m_isOverlay;

		// Token: 0x04002958 RID: 10584
		[SerializeField]
		protected bool m_isOrthographic;

		// Token: 0x04002959 RID: 10585
		[SerializeField]
		protected bool m_isCullingEnabled;

		// Token: 0x0400295A RID: 10586
		[SerializeField]
		protected bool m_ignoreCulling;

		// Token: 0x0400295B RID: 10587
		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping;

		// Token: 0x0400295C RID: 10588
		[SerializeField]
		protected TextureMappingOptions m_verticalMapping;

		// Token: 0x0400295D RID: 10589
		protected TextRenderFlags m_renderMode;

		// Token: 0x0400295E RID: 10590
		protected int m_maxVisibleCharacters;

		// Token: 0x0400295F RID: 10591
		protected int m_maxVisibleWords;

		// Token: 0x04002960 RID: 10592
		protected int m_maxVisibleLines;

		// Token: 0x04002961 RID: 10593
		[SerializeField]
		protected bool m_useMaxVisibleDescender;

		// Token: 0x04002962 RID: 10594
		[SerializeField]
		protected int m_pageToDisplay;

		// Token: 0x04002963 RID: 10595
		protected bool m_isNewPage;

		// Token: 0x04002964 RID: 10596
		[SerializeField]
		protected Vector4 m_margin;

		// Token: 0x04002965 RID: 10597
		protected float m_marginLeft;

		// Token: 0x04002966 RID: 10598
		protected float m_marginRight;

		// Token: 0x04002967 RID: 10599
		protected float m_marginWidth;

		// Token: 0x04002968 RID: 10600
		protected float m_marginHeight;

		// Token: 0x04002969 RID: 10601
		protected float m_width;

		// Token: 0x0400296A RID: 10602
		[SerializeField]
		protected TMP_TextInfo m_textInfo;

		// Token: 0x0400296B RID: 10603
		[SerializeField]
		protected bool m_havePropertiesChanged;

		// Token: 0x0400296C RID: 10604
		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent;

		// Token: 0x0400296D RID: 10605
		protected Transform m_transform;

		// Token: 0x0400296E RID: 10606
		protected RectTransform m_rectTransform;

		// Token: 0x04002970 RID: 10608
		protected Mesh m_mesh;

		// Token: 0x04002971 RID: 10609
		[SerializeField]
		protected bool m_isVolumetricText;

		// Token: 0x04002972 RID: 10610
		protected float m_flexibleHeight;

		// Token: 0x04002973 RID: 10611
		protected float m_flexibleWidth;

		// Token: 0x04002974 RID: 10612
		protected float m_minHeight;

		// Token: 0x04002975 RID: 10613
		protected float m_minWidth;

		// Token: 0x04002976 RID: 10614
		protected float m_preferredWidth;

		// Token: 0x04002977 RID: 10615
		protected float m_renderedWidth;

		// Token: 0x04002978 RID: 10616
		protected bool m_isPreferredWidthDirty;

		// Token: 0x04002979 RID: 10617
		protected float m_preferredHeight;

		// Token: 0x0400297A RID: 10618
		protected float m_renderedHeight;

		// Token: 0x0400297B RID: 10619
		protected bool m_isPreferredHeightDirty;

		// Token: 0x0400297C RID: 10620
		protected bool m_isCalculatingPreferredValues;

		// Token: 0x0400297D RID: 10621
		protected int m_layoutPriority;

		// Token: 0x0400297E RID: 10622
		protected bool m_isCalculateSizeRequired;

		// Token: 0x0400297F RID: 10623
		protected bool m_isLayoutDirty;

		// Token: 0x04002980 RID: 10624
		protected bool m_verticesAlreadyDirty;

		// Token: 0x04002981 RID: 10625
		protected bool m_layoutAlreadyDirty;

		// Token: 0x04002982 RID: 10626
		protected bool m_isAwake;

		// Token: 0x04002983 RID: 10627
		[SerializeField]
		protected bool m_isInputParsingRequired;

		// Token: 0x04002984 RID: 10628
		[SerializeField]
		protected TMP_Text.TextInputSources m_inputSource;

		// Token: 0x04002985 RID: 10629
		protected string old_text;

		// Token: 0x04002986 RID: 10630
		protected float old_arg0;

		// Token: 0x04002987 RID: 10631
		protected float old_arg1;

		// Token: 0x04002988 RID: 10632
		protected float old_arg2;

		// Token: 0x04002989 RID: 10633
		protected float m_fontScale;

		// Token: 0x0400298A RID: 10634
		protected float m_fontScaleMultiplier;

		// Token: 0x0400298B RID: 10635
		protected char[] m_htmlTag;

		// Token: 0x0400298C RID: 10636
		protected XML_TagAttribute[] m_xmlAttribute;

		// Token: 0x0400298D RID: 10637
		protected float tag_LineIndent;

		// Token: 0x0400298E RID: 10638
		protected float tag_Indent;

		// Token: 0x0400298F RID: 10639
		protected TMP_XmlTagStack<float> m_indentStack;

		// Token: 0x04002990 RID: 10640
		protected bool tag_NoParsing;

		// Token: 0x04002991 RID: 10641
		protected bool m_isParsingText;

		// Token: 0x04002992 RID: 10642
		protected int[] m_char_buffer;

		// Token: 0x04002993 RID: 10643
		private TMP_CharacterInfo[] m_internalCharacterInfo;

		// Token: 0x04002994 RID: 10644
		protected char[] m_input_CharArray;

		// Token: 0x04002995 RID: 10645
		private int m_charArray_Length;

		// Token: 0x04002996 RID: 10646
		protected int m_totalCharacterCount;

		// Token: 0x04002997 RID: 10647
		protected int m_characterCount;

		// Token: 0x04002998 RID: 10648
		protected int m_firstCharacterOfLine;

		// Token: 0x04002999 RID: 10649
		protected int m_firstVisibleCharacterOfLine;

		// Token: 0x0400299A RID: 10650
		protected int m_lastCharacterOfLine;

		// Token: 0x0400299B RID: 10651
		protected int m_lastVisibleCharacterOfLine;

		// Token: 0x0400299C RID: 10652
		protected int m_lineNumber;

		// Token: 0x0400299D RID: 10653
		protected int m_lineVisibleCharacterCount;

		// Token: 0x0400299E RID: 10654
		protected int m_pageNumber;

		// Token: 0x0400299F RID: 10655
		protected float m_maxAscender;

		// Token: 0x040029A0 RID: 10656
		protected float m_maxCapHeight;

		// Token: 0x040029A1 RID: 10657
		protected float m_maxDescender;

		// Token: 0x040029A2 RID: 10658
		protected float m_maxLineAscender;

		// Token: 0x040029A3 RID: 10659
		protected float m_maxLineDescender;

		// Token: 0x040029A4 RID: 10660
		protected float m_startOfLineAscender;

		// Token: 0x040029A5 RID: 10661
		protected float m_lineOffset;

		// Token: 0x040029A6 RID: 10662
		protected Extents m_meshExtents;

		// Token: 0x040029A7 RID: 10663
		protected Color32 m_htmlColor;

		// Token: 0x040029A8 RID: 10664
		protected TMP_XmlTagStack<Color32> m_colorStack;

		// Token: 0x040029A9 RID: 10665
		protected float m_tabSpacing;

		// Token: 0x040029AA RID: 10666
		protected float m_spacing;

		// Token: 0x040029AB RID: 10667
		protected TMP_XmlTagStack<int> m_styleStack;

		// Token: 0x040029AC RID: 10668
		protected TMP_XmlTagStack<int> m_actionStack;

		// Token: 0x040029AD RID: 10669
		protected float m_padding;

		// Token: 0x040029AE RID: 10670
		protected float m_baselineOffset;

		// Token: 0x040029AF RID: 10671
		protected float m_xAdvance;

		// Token: 0x040029B0 RID: 10672
		protected TMP_TextElementType m_textElementType;

		// Token: 0x040029B1 RID: 10673
		protected TMP_TextElement m_cached_TextElement;

		// Token: 0x040029B2 RID: 10674
		protected TMP_Glyph m_cached_Underline_GlyphInfo;

		// Token: 0x040029B3 RID: 10675
		protected TMP_Glyph m_cached_Ellipsis_GlyphInfo;

		// Token: 0x040029B4 RID: 10676
		protected TMP_SpriteAsset m_defaultSpriteAsset;

		// Token: 0x040029B5 RID: 10677
		protected TMP_SpriteAsset m_currentSpriteAsset;

		// Token: 0x040029B6 RID: 10678
		protected int m_spriteCount;

		// Token: 0x040029B7 RID: 10679
		protected int m_spriteIndex;

		// Token: 0x040029B8 RID: 10680
		protected InlineGraphicManager m_inlineGraphics;

		// Token: 0x040029B9 RID: 10681
		protected bool m_ignoreActiveState;

		// Token: 0x040029BA RID: 10682
		private readonly float[] k_Power;

		// Token: 0x040029BB RID: 10683
		protected static Vector2 k_LargePositiveVector2;

		// Token: 0x040029BC RID: 10684
		protected static Vector2 k_LargeNegativeVector2;

		// Token: 0x040029BD RID: 10685
		protected static float k_LargePositiveFloat;

		// Token: 0x040029BE RID: 10686
		protected static float k_LargeNegativeFloat;

		// Token: 0x040029BF RID: 10687
		protected static int k_LargePositiveInt;

		// Token: 0x040029C0 RID: 10688
		protected static int k_LargeNegativeInt;

		// Token: 0x0200061D RID: 1565
		protected enum TextInputSources
		{
			// Token: 0x040029C2 RID: 10690
			Text,
			// Token: 0x040029C3 RID: 10691
			SetText,
			// Token: 0x040029C4 RID: 10692
			SetCharArray,
			// Token: 0x040029C5 RID: 10693
			String
		}
	}
}
