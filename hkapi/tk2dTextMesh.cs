using System;
using System.Text;
using tk2dRuntime;
using UnityEngine;

// Token: 0x0200054B RID: 1355
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[AddComponentMenu("2D Toolkit/Text/tk2dTextMesh")]
public class tk2dTextMesh : MonoBehaviour, ISpriteCollectionForceBuild
{
	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0009341E File Offset: 0x0009161E
	public string FormattedText
	{
		get
		{
			return this._formattedText;
		}
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x00093428 File Offset: 0x00091628
	private void UpgradeData()
	{
		if (this.data.version != 1)
		{
			this.data.font = this._font;
			this.data.text = this._text;
			this.data.color = this._color;
			this.data.color2 = this._color2;
			this.data.useGradient = this._useGradient;
			this.data.textureGradient = this._textureGradient;
			this.data.anchor = this._anchor;
			this.data.scale = this._scale;
			this.data.kerning = this._kerning;
			this.data.maxChars = this._maxChars;
			this.data.inlineStyling = this._inlineStyling;
			this.data.formatting = this._formatting;
			this.data.wordWrapWidth = this._wordWrapWidth;
			this.data.spacing = this.spacing;
			this.data.lineSpacing = this.lineSpacing;
		}
		this.data.version = 1;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x00093554 File Offset: 0x00091754
	private static int GetInlineStyleCommandLength(int cmdSymbol)
	{
		int result = 0;
		if (cmdSymbol <= 71)
		{
			if (cmdSymbol != 67)
			{
				if (cmdSymbol == 71)
				{
					result = 17;
				}
			}
			else
			{
				result = 9;
			}
		}
		else if (cmdSymbol != 99)
		{
			if (cmdSymbol == 103)
			{
				result = 9;
			}
		}
		else
		{
			result = 5;
		}
		return result;
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x00093594 File Offset: 0x00091794
	public string FormatText(string unformattedString)
	{
		string result = "";
		this.FormatText(ref result, unformattedString);
		return result;
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x000935B1 File Offset: 0x000917B1
	private void FormatText()
	{
		this.FormatText(ref this._formattedText, this.data.text);
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000935CC File Offset: 0x000917CC
	private void FormatText(ref string _targetString, string _source)
	{
		this.InitInstance();
		if (!this.formatting || this.wordWrapWidth == 0 || this._fontInst.texelSize == Vector2.zero)
		{
			_targetString = _source;
			return;
		}
		float num = this._fontInst.texelSize.x * (float)this.wordWrapWidth;
		StringBuilder stringBuilder = new StringBuilder(_source.Length);
		float num2 = 0f;
		float num3 = 0f;
		int num4 = -1;
		int num5 = -1;
		bool flag = false;
		for (int i = 0; i < _source.Length; i++)
		{
			char c = _source[i];
			bool flag2 = c == '^';
			tk2dFontChar tk2dFontChar;
			if (this._fontInst.useDictionary)
			{
				if (!this._fontInst.charDict.ContainsKey((int)c))
				{
					c = '\0';
				}
				tk2dFontChar = this._fontInst.charDict[(int)c];
			}
			else
			{
				if ((int)c >= this._fontInst.chars.Length)
				{
					c = '\0';
				}
				tk2dFontChar = this._fontInst.chars[(int)c];
			}
			if (flag2)
			{
				c = '^';
			}
			if (flag)
			{
				flag = false;
			}
			else
			{
				if (this.data.inlineStyling && c == '^' && i + 1 < _source.Length)
				{
					if (_source[i + 1] != '^')
					{
						int inlineStyleCommandLength = tk2dTextMesh.GetInlineStyleCommandLength((int)_source[i + 1]);
						int num6 = 1 + inlineStyleCommandLength;
						for (int j = 0; j < num6; j++)
						{
							if (i + j < _source.Length)
							{
								stringBuilder.Append(_source[i + j]);
							}
						}
						i += num6 - 1;
						goto IL_2AA;
					}
					flag = true;
					stringBuilder.Append('^');
				}
				if (c == '\n')
				{
					num2 = 0f;
					num3 = 0f;
					num4 = stringBuilder.Length;
					num5 = i;
				}
				else if (c == ' ')
				{
					num2 += (tk2dFontChar.advance + this.data.spacing) * this.data.scale.x;
					num3 = num2;
					num4 = stringBuilder.Length;
					num5 = i;
				}
				else if (num2 + tk2dFontChar.p1.x * this.data.scale.x > num)
				{
					if (num3 > 0f)
					{
						num3 = 0f;
						num2 = 0f;
						stringBuilder.Remove(num4 + 1, stringBuilder.Length - num4 - 1);
						stringBuilder.Append('\n');
						i = num5;
						goto IL_2AA;
					}
					stringBuilder.Append('\n');
					num2 = (tk2dFontChar.advance + this.data.spacing) * this.data.scale.x;
				}
				else
				{
					num2 += (tk2dFontChar.advance + this.data.spacing) * this.data.scale.x;
				}
				stringBuilder.Append(c);
			}
			IL_2AA:;
		}
		_targetString = stringBuilder.ToString();
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x0009389E File Offset: 0x00091A9E
	private void SetNeedUpdate(tk2dTextMesh.UpdateFlags uf)
	{
		if (this.updateFlags == tk2dTextMesh.UpdateFlags.UpdateNone)
		{
			this.updateFlags |= uf;
			tk2dUpdateManager.QueueCommit(this);
			return;
		}
		this.updateFlags |= uf;
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000938CB File Offset: 0x00091ACB
	// (set) Token: 0x06001D92 RID: 7570 RVA: 0x000938DE File Offset: 0x00091ADE
	public tk2dFontData font
	{
		get
		{
			this.UpgradeData();
			return this.data.font;
		}
		set
		{
			this.UpgradeData();
			this.data.font = value;
			this._fontInst = this.data.font.inst;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
			this.UpdateMaterial();
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00093915 File Offset: 0x00091B15
	// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00093928 File Offset: 0x00091B28
	public bool formatting
	{
		get
		{
			this.UpgradeData();
			return this.data.formatting;
		}
		set
		{
			this.UpgradeData();
			if (this.data.formatting != value)
			{
				this.data.formatting = value;
				this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
			}
		}
	}

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00093951 File Offset: 0x00091B51
	// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00093964 File Offset: 0x00091B64
	public int wordWrapWidth
	{
		get
		{
			this.UpgradeData();
			return this.data.wordWrapWidth;
		}
		set
		{
			this.UpgradeData();
			if (this.data.wordWrapWidth != value)
			{
				this.data.wordWrapWidth = value;
				this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
			}
		}
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0009398D File Offset: 0x00091B8D
	// (set) Token: 0x06001D98 RID: 7576 RVA: 0x000939A0 File Offset: 0x00091BA0
	public string text
	{
		get
		{
			this.UpgradeData();
			return this.data.text;
		}
		set
		{
			this.UpgradeData();
			this.data.text = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000939BB File Offset: 0x00091BBB
	// (set) Token: 0x06001D9A RID: 7578 RVA: 0x000939CE File Offset: 0x00091BCE
	public Color color
	{
		get
		{
			this.UpgradeData();
			return this.data.color;
		}
		set
		{
			this.UpgradeData();
			this.data.color = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateColors);
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000939E9 File Offset: 0x00091BE9
	// (set) Token: 0x06001D9C RID: 7580 RVA: 0x000939FC File Offset: 0x00091BFC
	public Color color2
	{
		get
		{
			this.UpgradeData();
			return this.data.color2;
		}
		set
		{
			this.UpgradeData();
			this.data.color2 = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateColors);
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00093A17 File Offset: 0x00091C17
	// (set) Token: 0x06001D9E RID: 7582 RVA: 0x00093A2A File Offset: 0x00091C2A
	public bool useGradient
	{
		get
		{
			this.UpgradeData();
			return this.data.useGradient;
		}
		set
		{
			this.UpgradeData();
			this.data.useGradient = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateColors);
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00093A45 File Offset: 0x00091C45
	// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00093A58 File Offset: 0x00091C58
	public TextAnchor anchor
	{
		get
		{
			this.UpgradeData();
			return this.data.anchor;
		}
		set
		{
			this.UpgradeData();
			this.data.anchor = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00093A73 File Offset: 0x00091C73
	// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00093A86 File Offset: 0x00091C86
	public Vector3 scale
	{
		get
		{
			this.UpgradeData();
			return this.data.scale;
		}
		set
		{
			this.UpgradeData();
			this.data.scale = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00093AA1 File Offset: 0x00091CA1
	// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00093AB4 File Offset: 0x00091CB4
	public bool kerning
	{
		get
		{
			this.UpgradeData();
			return this.data.kerning;
		}
		set
		{
			this.UpgradeData();
			this.data.kerning = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00093ACF File Offset: 0x00091CCF
	// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x00093AE2 File Offset: 0x00091CE2
	public int maxChars
	{
		get
		{
			this.UpgradeData();
			return this.data.maxChars;
		}
		set
		{
			this.UpgradeData();
			this.data.maxChars = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateBuffers);
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00093AFD File Offset: 0x00091CFD
	// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00093B10 File Offset: 0x00091D10
	public int textureGradient
	{
		get
		{
			this.UpgradeData();
			return this.data.textureGradient;
		}
		set
		{
			this.UpgradeData();
			this.data.textureGradient = value % this.font.gradientCount;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00093B37 File Offset: 0x00091D37
	// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00093B4A File Offset: 0x00091D4A
	public bool inlineStyling
	{
		get
		{
			this.UpgradeData();
			return this.data.inlineStyling;
		}
		set
		{
			this.UpgradeData();
			this.data.inlineStyling = value;
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00093B65 File Offset: 0x00091D65
	// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00093B78 File Offset: 0x00091D78
	public float Spacing
	{
		get
		{
			this.UpgradeData();
			return this.data.spacing;
		}
		set
		{
			this.UpgradeData();
			if (this.data.spacing != value)
			{
				this.data.spacing = value;
				this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
			}
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00093BA1 File Offset: 0x00091DA1
	// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00093BB4 File Offset: 0x00091DB4
	public float LineSpacing
	{
		get
		{
			this.UpgradeData();
			return this.data.lineSpacing;
		}
		set
		{
			this.UpgradeData();
			if (this.data.lineSpacing != value)
			{
				this.data.lineSpacing = value;
				this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateText);
			}
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00093BDD File Offset: 0x00091DDD
	// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00093BEA File Offset: 0x00091DEA
	public int SortingOrder
	{
		get
		{
			return this.CachedRenderer.sortingOrder;
		}
		set
		{
			if (this.CachedRenderer.sortingOrder != value)
			{
				this.data.renderLayer = value;
				this.CachedRenderer.sortingOrder = value;
			}
		}
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x00093C12 File Offset: 0x00091E12
	private void InitInstance()
	{
		if (this.data != null && this.data.font != null)
		{
			this._fontInst = this.data.font.inst;
			this._fontInst.InitDictionary();
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00093C50 File Offset: 0x00091E50
	private Renderer CachedRenderer
	{
		get
		{
			if (this._cachedRenderer == null)
			{
				this._cachedRenderer = base.GetComponent<Renderer>();
			}
			return this._cachedRenderer;
		}
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00093C74 File Offset: 0x00091E74
	private void Awake()
	{
		this.UpgradeData();
		if (this.data.font != null)
		{
			this._fontInst = this.data.font.inst;
		}
		this.updateFlags = tk2dTextMesh.UpdateFlags.UpdateBuffers;
		if (this.data.font != null)
		{
			this.Init();
			this.UpdateMaterial();
		}
		this.updateFlags = tk2dTextMesh.UpdateFlags.UpdateNone;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x00093CE0 File Offset: 0x00091EE0
	protected void OnDestroy()
	{
		if (this.meshFilter == null)
		{
			this.meshFilter = base.GetComponent<MeshFilter>();
		}
		if (this.meshFilter != null)
		{
			this.mesh = this.meshFilter.sharedMesh;
		}
		if (this.mesh)
		{
			UnityEngine.Object.DestroyImmediate(this.mesh, true);
			this.meshFilter.mesh = null;
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00093D4B File Offset: 0x00091F4B
	private bool useInlineStyling
	{
		get
		{
			return this.inlineStyling && this._fontInst.textureGradients;
		}
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00093D64 File Offset: 0x00091F64
	public int NumDrawnCharacters()
	{
		int num = this.NumTotalCharacters();
		if (num > this.data.maxChars)
		{
			num = this.data.maxChars;
		}
		return num;
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00093D94 File Offset: 0x00091F94
	public int NumTotalCharacters()
	{
		this.InitInstance();
		if ((this.updateFlags & (tk2dTextMesh.UpdateFlags.UpdateText | tk2dTextMesh.UpdateFlags.UpdateBuffers)) != tk2dTextMesh.UpdateFlags.UpdateNone)
		{
			this.FormatText();
		}
		int num = 0;
		for (int i = 0; i < this._formattedText.Length; i++)
		{
			int num2 = (int)this._formattedText[i];
			bool flag = num2 == 94;
			if (this._fontInst.useDictionary)
			{
				if (!this._fontInst.charDict.ContainsKey(num2))
				{
					num2 = 0;
				}
			}
			else if (num2 >= this._fontInst.chars.Length)
			{
				num2 = 0;
			}
			if (flag)
			{
				num2 = 94;
			}
			if (num2 != 10)
			{
				if (this.data.inlineStyling && num2 == 94 && i + 1 < this._formattedText.Length)
				{
					if (this._formattedText[i + 1] != '^')
					{
						i += tk2dTextMesh.GetInlineStyleCommandLength((int)this._formattedText[i + 1]);
						goto IL_C7;
					}
					i++;
				}
				num++;
			}
			IL_C7:;
		}
		return num;
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x00093E7E File Offset: 0x0009207E
	[Obsolete("Use GetEstimatedMeshBoundsForString().size instead")]
	public Vector2 GetMeshDimensionsForString(string str)
	{
		return tk2dTextGeomGen.GetMeshDimensionsForString(str, tk2dTextGeomGen.Data(this.data, this._fontInst, this._formattedText));
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x00093EA0 File Offset: 0x000920A0
	public Bounds GetEstimatedMeshBoundsForString(string str)
	{
		this.InitInstance();
		tk2dTextGeomGen.GeomData geomData = tk2dTextGeomGen.Data(this.data, this._fontInst, this._formattedText);
		Vector2 meshDimensionsForString = tk2dTextGeomGen.GetMeshDimensionsForString(this.FormatText(str), geomData);
		float yanchorForHeight = tk2dTextGeomGen.GetYAnchorForHeight(meshDimensionsForString.y, geomData);
		float xanchorForWidth = tk2dTextGeomGen.GetXAnchorForWidth(meshDimensionsForString.x, geomData);
		float num = (this._fontInst.lineHeight + this.data.lineSpacing) * this.data.scale.y;
		return new Bounds(new Vector3(xanchorForWidth + meshDimensionsForString.x * 0.5f, yanchorForHeight + meshDimensionsForString.y * 0.5f + num, 0f), Vector3.Scale(meshDimensionsForString, new Vector3(1f, -1f, 1f)));
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x00093F66 File Offset: 0x00092166
	public void Init(bool force)
	{
		if (force)
		{
			this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateBuffers);
		}
		this.Init();
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00093F78 File Offset: 0x00092178
	public void Init()
	{
		if (this._fontInst && ((this.updateFlags & tk2dTextMesh.UpdateFlags.UpdateBuffers) != tk2dTextMesh.UpdateFlags.UpdateNone || this.mesh == null))
		{
			this._fontInst.InitDictionary();
			this.FormatText();
			tk2dTextGeomGen.GeomData geomData = tk2dTextGeomGen.Data(this.data, this._fontInst, this._formattedText);
			int num;
			int num2;
			tk2dTextGeomGen.GetTextMeshGeomDesc(out num, out num2, geomData);
			this.vertices = new Vector3[num];
			this.uvs = new Vector2[num];
			this.colors = new Color32[num];
			this.untintedColors = new Color32[num];
			if (this._fontInst.textureGradients)
			{
				this.uv2 = new Vector2[num];
			}
			int[] array = new int[num2];
			int target = tk2dTextGeomGen.SetTextMeshGeom(this.vertices, this.uvs, this.uv2, this.untintedColors, 0, geomData);
			if (!this._fontInst.isPacked)
			{
				Color32 color = this.data.color;
				Color32 color2 = this.data.useGradient ? this.data.color2 : this.data.color;
				for (int i = 0; i < num; i++)
				{
					Color32 color3 = (i % 4 < 2) ? color : color2;
					byte b = this.untintedColors[i].r * color3.r / byte.MaxValue;
					byte b2 = this.untintedColors[i].g * color3.g / byte.MaxValue;
					byte b3 = this.untintedColors[i].b * color3.b / byte.MaxValue;
					byte b4 = this.untintedColors[i].a * color3.a / byte.MaxValue;
					if (this._fontInst.premultipliedAlpha)
					{
						b = b * b4 / byte.MaxValue;
						b2 = b2 * b4 / byte.MaxValue;
						b3 = b3 * b4 / byte.MaxValue;
					}
					this.colors[i] = new Color32(b, b2, b3, b4);
				}
			}
			else
			{
				this.colors = this.untintedColors;
			}
			tk2dTextGeomGen.SetTextMeshIndices(array, 0, 0, geomData, target);
			if (this.mesh == null)
			{
				if (this.meshFilter == null)
				{
					this.meshFilter = base.GetComponent<MeshFilter>();
				}
				this.mesh = new Mesh();
				this.mesh.MarkDynamic();
				this.mesh.hideFlags = HideFlags.DontSave;
				this.meshFilter.mesh = this.mesh;
			}
			else
			{
				this.mesh.Clear();
			}
			this.mesh.vertices = this.vertices;
			this.mesh.uv = this.uvs;
			if (this.font.textureGradients)
			{
				this.mesh.uv2 = this.uv2;
			}
			this.mesh.triangles = array;
			this.mesh.colors32 = this.colors;
			this.mesh.RecalculateBounds();
			this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.data.renderLayer);
			this.updateFlags = tk2dTextMesh.UpdateFlags.UpdateNone;
		}
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x000942BB File Offset: 0x000924BB
	public void Commit()
	{
		tk2dUpdateManager.FlushQueues();
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x000942C4 File Offset: 0x000924C4
	public void DoNotUse__CommitInternal()
	{
		this.InitInstance();
		if (this._fontInst == null)
		{
			return;
		}
		this._fontInst.InitDictionary();
		if ((this.updateFlags & tk2dTextMesh.UpdateFlags.UpdateBuffers) != tk2dTextMesh.UpdateFlags.UpdateNone || this.mesh == null)
		{
			this.Init();
		}
		else
		{
			if ((this.updateFlags & tk2dTextMesh.UpdateFlags.UpdateText) != tk2dTextMesh.UpdateFlags.UpdateNone)
			{
				this.FormatText();
				tk2dTextGeomGen.GeomData geomData = tk2dTextGeomGen.Data(this.data, this._fontInst, this._formattedText);
				for (int i = tk2dTextGeomGen.SetTextMeshGeom(this.vertices, this.uvs, this.uv2, this.untintedColors, 0, geomData); i < this.data.maxChars; i++)
				{
					this.vertices[i * 4] = (this.vertices[i * 4 + 1] = (this.vertices[i * 4 + 2] = (this.vertices[i * 4 + 3] = Vector3.zero)));
				}
				this.mesh.vertices = this.vertices;
				this.mesh.uv = this.uvs;
				if (this._fontInst.textureGradients)
				{
					this.mesh.uv2 = this.uv2;
				}
				if (this._fontInst.isPacked)
				{
					this.colors = this.untintedColors;
					this.mesh.colors32 = this.colors;
				}
				if (this.data.inlineStyling)
				{
					this.SetNeedUpdate(tk2dTextMesh.UpdateFlags.UpdateColors);
				}
				this.mesh.RecalculateBounds();
				this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.data.renderLayer);
			}
			if (!this.font.isPacked && (this.updateFlags & tk2dTextMesh.UpdateFlags.UpdateColors) != tk2dTextMesh.UpdateFlags.UpdateNone)
			{
				Color32 color = this.data.color;
				Color32 color2 = this.data.useGradient ? this.data.color2 : this.data.color;
				for (int j = 0; j < this.colors.Length; j++)
				{
					Color32 color3 = (j % 4 < 2) ? color : color2;
					byte b = this.untintedColors[j].r * color3.r / byte.MaxValue;
					byte b2 = this.untintedColors[j].g * color3.g / byte.MaxValue;
					byte b3 = this.untintedColors[j].b * color3.b / byte.MaxValue;
					byte b4 = this.untintedColors[j].a * color3.a / byte.MaxValue;
					if (this._fontInst.premultipliedAlpha)
					{
						b = b * b4 / byte.MaxValue;
						b2 = b2 * b4 / byte.MaxValue;
						b3 = b3 * b4 / byte.MaxValue;
					}
					this.colors[j] = new Color32(b, b2, b3, b4);
				}
				this.mesh.colors32 = this.colors;
			}
		}
		this.updateFlags = tk2dTextMesh.UpdateFlags.UpdateNone;
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x000945E8 File Offset: 0x000927E8
	public void MakePixelPerfect()
	{
		float num = 1f;
		tk2dCamera tk2dCamera = tk2dCamera.CameraForLayer(base.gameObject.layer);
		if (tk2dCamera != null)
		{
			if (this._fontInst.version < 1)
			{
				Debug.LogError("Need to rebuild font.");
			}
			float distance = base.transform.position.z - tk2dCamera.transform.position.z;
			float num2 = this._fontInst.invOrthoSize * this._fontInst.halfTargetHeight;
			num = tk2dCamera.GetSizeAtDistance(distance) * num2;
		}
		else if (Camera.main)
		{
			if (Camera.main.orthographic)
			{
				num = Camera.main.orthographicSize;
			}
			else
			{
				float zdist = base.transform.position.z - Camera.main.transform.position.z;
				num = tk2dPixelPerfectHelper.CalculateScaleForPerspectiveCamera(Camera.main.fieldOfView, zdist);
			}
			num *= this._fontInst.invOrthoSize;
		}
		this.scale = new Vector3(Mathf.Sign(this.scale.x) * num, Mathf.Sign(this.scale.y) * num, Mathf.Sign(this.scale.z) * num);
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x00094720 File Offset: 0x00092920
	public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
	{
		return !(this.data.font != null) || !(this.data.font.spriteCollection != null) || this.data.font.spriteCollection == spriteCollection;
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00094770 File Offset: 0x00092970
	private void UpdateMaterial()
	{
		if (base.GetComponent<Renderer>().sharedMaterial != this._fontInst.materialInst)
		{
			base.GetComponent<Renderer>().material = this._fontInst.materialInst;
		}
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x000947A5 File Offset: 0x000929A5
	public void ForceBuild()
	{
		if (this.data.font != null)
		{
			this._fontInst = this.data.font.inst;
			this.UpdateMaterial();
		}
		this.Init(true);
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000947E0 File Offset: 0x000929E0
	public tk2dTextMesh()
	{
		this._formattedText = "";
		this._text = "";
		this._color = Color.white;
		this._color2 = Color.white;
		this._anchor = TextAnchor.LowerLeft;
		this._scale = new Vector3(1f, 1f, 1f);
		this._maxChars = 16;
		this.data = new tk2dTextMeshData();
		this.updateFlags = tk2dTextMesh.UpdateFlags.UpdateBuffers;
		base..ctor();
	}

	// Token: 0x04002353 RID: 9043
	private tk2dFontData _fontInst;

	// Token: 0x04002354 RID: 9044
	private string _formattedText;

	// Token: 0x04002355 RID: 9045
	[SerializeField]
	private tk2dFontData _font;

	// Token: 0x04002356 RID: 9046
	[SerializeField]
	private string _text;

	// Token: 0x04002357 RID: 9047
	[SerializeField]
	private Color _color;

	// Token: 0x04002358 RID: 9048
	[SerializeField]
	private Color _color2;

	// Token: 0x04002359 RID: 9049
	[SerializeField]
	private bool _useGradient;

	// Token: 0x0400235A RID: 9050
	[SerializeField]
	private int _textureGradient;

	// Token: 0x0400235B RID: 9051
	[SerializeField]
	private TextAnchor _anchor;

	// Token: 0x0400235C RID: 9052
	[SerializeField]
	private Vector3 _scale;

	// Token: 0x0400235D RID: 9053
	[SerializeField]
	private bool _kerning;

	// Token: 0x0400235E RID: 9054
	[SerializeField]
	private int _maxChars;

	// Token: 0x0400235F RID: 9055
	[SerializeField]
	private bool _inlineStyling;

	// Token: 0x04002360 RID: 9056
	[SerializeField]
	private bool _formatting;

	// Token: 0x04002361 RID: 9057
	[SerializeField]
	private int _wordWrapWidth;

	// Token: 0x04002362 RID: 9058
	[SerializeField]
	private float spacing;

	// Token: 0x04002363 RID: 9059
	[SerializeField]
	private float lineSpacing;

	// Token: 0x04002364 RID: 9060
	[SerializeField]
	private tk2dTextMeshData data;

	// Token: 0x04002365 RID: 9061
	private Vector3[] vertices;

	// Token: 0x04002366 RID: 9062
	private Vector2[] uvs;

	// Token: 0x04002367 RID: 9063
	private Vector2[] uv2;

	// Token: 0x04002368 RID: 9064
	private Color32[] colors;

	// Token: 0x04002369 RID: 9065
	private Color32[] untintedColors;

	// Token: 0x0400236A RID: 9066
	private tk2dTextMesh.UpdateFlags updateFlags;

	// Token: 0x0400236B RID: 9067
	private Mesh mesh;

	// Token: 0x0400236C RID: 9068
	private MeshFilter meshFilter;

	// Token: 0x0400236D RID: 9069
	private Renderer _cachedRenderer;

	// Token: 0x0200054C RID: 1356
	[Flags]
	private enum UpdateFlags
	{
		// Token: 0x0400236F RID: 9071
		UpdateNone = 0,
		// Token: 0x04002370 RID: 9072
		UpdateText = 1,
		// Token: 0x04002371 RID: 9073
		UpdateColors = 2,
		// Token: 0x04002372 RID: 9074
		UpdateBuffers = 4
	}
}
