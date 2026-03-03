using System;
using UnityEngine;

// Token: 0x02000548 RID: 1352
public static class tk2dTextGeomGen
{
	// Token: 0x06001D79 RID: 7545 RVA: 0x000922E9 File Offset: 0x000904E9
	public static tk2dTextGeomGen.GeomData Data(tk2dTextMeshData textMeshData, tk2dFontData fontData, string formattedText)
	{
		tk2dTextGeomGen.tmpData.textMeshData = textMeshData;
		tk2dTextGeomGen.tmpData.fontInst = fontData;
		tk2dTextGeomGen.tmpData.formattedText = formattedText;
		return tk2dTextGeomGen.tmpData;
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x00092314 File Offset: 0x00090514
	public static Vector2 GetMeshDimensionsForString(string str, tk2dTextGeomGen.GeomData geomData)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		tk2dFontData fontInst = geomData.fontInst;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		bool flag = false;
		int num4 = 0;
		int num5 = 0;
		while (num5 < str.Length && num4 < textMeshData.maxChars)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				int num6 = (int)str[num5];
				if (num6 == 10)
				{
					num = Mathf.Max(num2, num);
					num2 = 0f;
					num3 -= (fontInst.lineHeight + textMeshData.lineSpacing) * textMeshData.scale.y;
				}
				else
				{
					if (textMeshData.inlineStyling && num6 == 94 && num5 + 1 < str.Length)
					{
						if (str[num5 + 1] != '^')
						{
							int num7 = 0;
							char c = str[num5 + 1];
							if (c <= 'G')
							{
								if (c != 'C')
								{
									if (c == 'G')
									{
										num7 = 17;
									}
								}
								else
								{
									num7 = 9;
								}
							}
							else if (c != 'c')
							{
								if (c == 'g')
								{
									num7 = 9;
								}
							}
							else
							{
								num7 = 5;
							}
							num5 += num7;
							goto IL_1EA;
						}
						flag = true;
					}
					bool flag2 = num6 == 94;
					tk2dFontChar tk2dFontChar;
					if (fontInst.useDictionary)
					{
						if (!fontInst.charDict.ContainsKey(num6))
						{
							num6 = 0;
						}
						tk2dFontChar = fontInst.charDict[num6];
					}
					else
					{
						if (num6 >= fontInst.chars.Length)
						{
							num6 = 0;
						}
						tk2dFontChar = fontInst.chars[num6];
					}
					if (flag2)
					{
					}
					num2 += (tk2dFontChar.advance + textMeshData.spacing) * textMeshData.scale.x;
					if (textMeshData.kerning && num5 < str.Length - 1)
					{
						foreach (tk2dFontKerning tk2dFontKerning in fontInst.kerning)
						{
							if (tk2dFontKerning.c0 == (int)str[num5] && tk2dFontKerning.c1 == (int)str[num5 + 1])
							{
								num2 += tk2dFontKerning.amount * textMeshData.scale.x;
								break;
							}
						}
					}
					num4++;
				}
			}
			IL_1EA:
			num5++;
		}
		num = Mathf.Max(num2, num);
		num3 -= (fontInst.lineHeight + textMeshData.lineSpacing) * textMeshData.scale.y;
		return new Vector2(num, num3);
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x00092558 File Offset: 0x00090758
	public static float GetYAnchorForHeight(float textHeight, tk2dTextGeomGen.GeomData geomData)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		tk2dFontData fontInst = geomData.fontInst;
		int num = (int)(textMeshData.anchor / TextAnchor.MiddleLeft);
		float num2 = (fontInst.lineHeight + textMeshData.lineSpacing) * textMeshData.scale.y;
		switch (num)
		{
		case 0:
			return -num2;
		case 1:
		{
			float num3 = -textHeight / 2f - num2;
			if (fontInst.version >= 2)
			{
				float num4 = fontInst.texelSize.y * textMeshData.scale.y;
				return Mathf.Floor(num3 / num4) * num4;
			}
			return num3;
		}
		case 2:
			return -textHeight - num2;
		default:
			return -num2;
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000925F4 File Offset: 0x000907F4
	public static float GetXAnchorForWidth(float lineWidth, tk2dTextGeomGen.GeomData geomData)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		tk2dFontData fontInst = geomData.fontInst;
		switch (textMeshData.anchor % TextAnchor.MiddleLeft)
		{
		case TextAnchor.UpperLeft:
			return 0f;
		case TextAnchor.UpperCenter:
		{
			float num = -lineWidth / 2f;
			if (fontInst.version >= 2)
			{
				float num2 = fontInst.texelSize.x * textMeshData.scale.x;
				return Mathf.Floor(num / num2) * num2;
			}
			return num;
		}
		case TextAnchor.UpperRight:
			return -lineWidth;
		default:
			return 0f;
		}
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x00092674 File Offset: 0x00090874
	private static void PostAlignTextData(Vector3[] pos, int offset, int targetStart, int targetEnd, float offsetX)
	{
		for (int i = targetStart * 4; i < targetEnd * 4; i++)
		{
			Vector3 vector = pos[offset + i];
			vector.x += offsetX;
			pos[offset + i] = vector;
		}
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x000926B4 File Offset: 0x000908B4
	private static int GetFullHexColorComponent(int c1, int c2)
	{
		int num = 0;
		if (c1 >= 48 && c1 <= 57)
		{
			num += (c1 - 48) * 16;
		}
		else if (c1 >= 97 && c1 <= 102)
		{
			num += (10 + c1 - 97) * 16;
		}
		else
		{
			if (c1 < 65 || c1 > 70)
			{
				return -1;
			}
			num += (10 + c1 - 65) * 16;
		}
		if (c2 >= 48 && c2 <= 57)
		{
			num += c2 - 48;
		}
		else if (c2 >= 97 && c2 <= 102)
		{
			num += 10 + c2 - 97;
		}
		else
		{
			if (c2 < 65 || c2 > 70)
			{
				return -1;
			}
			num += 10 + c2 - 65;
		}
		return num;
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x0009274F File Offset: 0x0009094F
	private static int GetCompactHexColorComponent(int c)
	{
		if (c >= 48 && c <= 57)
		{
			return (c - 48) * 17;
		}
		if (c >= 97 && c <= 102)
		{
			return (10 + c - 97) * 17;
		}
		if (c >= 65 && c <= 70)
		{
			return (10 + c - 65) * 17;
		}
		return -1;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x00092790 File Offset: 0x00090990
	private static int GetStyleHexColor(string str, bool fullHex, ref Color32 color)
	{
		int num;
		int num2;
		int num3;
		int num4;
		if (fullHex)
		{
			if (str.Length < 8)
			{
				return 1;
			}
			num = tk2dTextGeomGen.GetFullHexColorComponent((int)str[0], (int)str[1]);
			num2 = tk2dTextGeomGen.GetFullHexColorComponent((int)str[2], (int)str[3]);
			num3 = tk2dTextGeomGen.GetFullHexColorComponent((int)str[4], (int)str[5]);
			num4 = tk2dTextGeomGen.GetFullHexColorComponent((int)str[6], (int)str[7]);
		}
		else
		{
			if (str.Length < 4)
			{
				return 1;
			}
			num = tk2dTextGeomGen.GetCompactHexColorComponent((int)str[0]);
			num2 = tk2dTextGeomGen.GetCompactHexColorComponent((int)str[1]);
			num3 = tk2dTextGeomGen.GetCompactHexColorComponent((int)str[2]);
			num4 = tk2dTextGeomGen.GetCompactHexColorComponent((int)str[3]);
		}
		if (num == -1 || num2 == -1 || num3 == -1 || num4 == -1)
		{
			return 1;
		}
		color = new Color32((byte)num, (byte)num2, (byte)num3, (byte)num4);
		return 0;
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x00092864 File Offset: 0x00090A64
	private static int SetColorsFromStyleCommand(string args, bool twoColors, bool fullHex)
	{
		int num = (twoColors ? 2 : 1) * (fullHex ? 8 : 4);
		bool flag = false;
		if (args.Length >= num)
		{
			if (tk2dTextGeomGen.GetStyleHexColor(args, fullHex, ref tk2dTextGeomGen.meshTopColor) != 0)
			{
				flag = true;
			}
			if (twoColors)
			{
				if (tk2dTextGeomGen.GetStyleHexColor(args.Substring(fullHex ? 8 : 4), fullHex, ref tk2dTextGeomGen.meshBottomColor) != 0)
				{
					flag = true;
				}
			}
			else
			{
				tk2dTextGeomGen.meshBottomColor = tk2dTextGeomGen.meshTopColor;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			tk2dTextGeomGen.meshTopColor = (tk2dTextGeomGen.meshBottomColor = tk2dTextGeomGen.errorColor);
		}
		return num;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000928DF File Offset: 0x00090ADF
	private static void SetGradientTexUFromStyleCommand(int arg)
	{
		tk2dTextGeomGen.meshGradientTexU = (float)(arg - 48) / (float)((tk2dTextGeomGen.curGradientCount > 0) ? tk2dTextGeomGen.curGradientCount : 1);
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x00092900 File Offset: 0x00090B00
	private static int HandleStyleCommand(string cmd)
	{
		if (cmd.Length == 0)
		{
			return 0;
		}
		int num = (int)cmd[0];
		string args = cmd.Substring(1);
		int result = 0;
		if (num <= 71)
		{
			if (num != 67)
			{
				if (num == 71)
				{
					result = 1 + tk2dTextGeomGen.SetColorsFromStyleCommand(args, true, true);
				}
			}
			else
			{
				result = 1 + tk2dTextGeomGen.SetColorsFromStyleCommand(args, false, true);
			}
		}
		else if (num != 99)
		{
			if (num == 103)
			{
				result = 1 + tk2dTextGeomGen.SetColorsFromStyleCommand(args, true, false);
			}
		}
		else
		{
			result = 1 + tk2dTextGeomGen.SetColorsFromStyleCommand(args, false, false);
		}
		if (num >= 48 && num <= 57)
		{
			tk2dTextGeomGen.SetGradientTexUFromStyleCommand(num);
			result = 1;
		}
		return result;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x0009298C File Offset: 0x00090B8C
	public static void GetTextMeshGeomDesc(out int numVertices, out int numIndices, tk2dTextGeomGen.GeomData geomData)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		numVertices = textMeshData.maxChars * 4;
		numIndices = textMeshData.maxChars * 6;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000929B4 File Offset: 0x00090BB4
	public static int SetTextMeshGeom(Vector3[] pos, Vector2[] uv, Vector2[] uv2, Color32[] color, int offset, tk2dTextGeomGen.GeomData geomData)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		tk2dFontData fontInst = geomData.fontInst;
		string formattedText = geomData.formattedText;
		tk2dTextGeomGen.meshTopColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		tk2dTextGeomGen.meshBottomColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		tk2dTextGeomGen.meshGradientTexU = (float)textMeshData.textureGradient / (float)((fontInst.gradientCount > 0) ? fontInst.gradientCount : 1);
		tk2dTextGeomGen.curGradientCount = fontInst.gradientCount;
		float yanchorForHeight = tk2dTextGeomGen.GetYAnchorForHeight(tk2dTextGeomGen.GetMeshDimensionsForString(geomData.formattedText, geomData).y, geomData);
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		while (num5 < formattedText.Length && num3 < textMeshData.maxChars)
		{
			int num6 = (int)formattedText[num5];
			bool flag = num6 == 94;
			tk2dFontChar tk2dFontChar;
			if (fontInst.useDictionary)
			{
				if (!fontInst.charDict.ContainsKey(num6))
				{
					num6 = 0;
				}
				tk2dFontChar = fontInst.charDict[num6];
			}
			else
			{
				if (num6 >= fontInst.chars.Length)
				{
					num6 = 0;
				}
				tk2dFontChar = fontInst.chars[num6];
			}
			if (flag)
			{
				num6 = 94;
			}
			if (num6 == 10)
			{
				float lineWidth = num;
				int targetEnd = num3;
				if (num4 != num3)
				{
					float xanchorForWidth = tk2dTextGeomGen.GetXAnchorForWidth(lineWidth, geomData);
					tk2dTextGeomGen.PostAlignTextData(pos, offset, num4, targetEnd, xanchorForWidth);
				}
				num4 = num3;
				num = 0f;
				num2 -= (fontInst.lineHeight + textMeshData.lineSpacing) * textMeshData.scale.y;
			}
			else
			{
				if (textMeshData.inlineStyling && num6 == 94)
				{
					if (num5 + 1 >= formattedText.Length || formattedText[num5 + 1] != '^')
					{
						num5 += tk2dTextGeomGen.HandleStyleCommand(formattedText.Substring(num5 + 1));
						goto IL_673;
					}
					num5++;
				}
				pos[offset + num3 * 4] = new Vector3(num + tk2dFontChar.p0.x * textMeshData.scale.x, yanchorForHeight + num2 + tk2dFontChar.p0.y * textMeshData.scale.y, 0f);
				pos[offset + num3 * 4 + 1] = new Vector3(num + tk2dFontChar.p1.x * textMeshData.scale.x, yanchorForHeight + num2 + tk2dFontChar.p0.y * textMeshData.scale.y, 0f);
				pos[offset + num3 * 4 + 2] = new Vector3(num + tk2dFontChar.p0.x * textMeshData.scale.x, yanchorForHeight + num2 + tk2dFontChar.p1.y * textMeshData.scale.y, 0f);
				pos[offset + num3 * 4 + 3] = new Vector3(num + tk2dFontChar.p1.x * textMeshData.scale.x, yanchorForHeight + num2 + tk2dFontChar.p1.y * textMeshData.scale.y, 0f);
				if (tk2dFontChar.flipped)
				{
					uv[offset + num3 * 4] = new Vector2(tk2dFontChar.uv1.x, tk2dFontChar.uv1.y);
					uv[offset + num3 * 4 + 1] = new Vector2(tk2dFontChar.uv1.x, tk2dFontChar.uv0.y);
					uv[offset + num3 * 4 + 2] = new Vector2(tk2dFontChar.uv0.x, tk2dFontChar.uv1.y);
					uv[offset + num3 * 4 + 3] = new Vector2(tk2dFontChar.uv0.x, tk2dFontChar.uv0.y);
				}
				else
				{
					uv[offset + num3 * 4] = new Vector2(tk2dFontChar.uv0.x, tk2dFontChar.uv0.y);
					uv[offset + num3 * 4 + 1] = new Vector2(tk2dFontChar.uv1.x, tk2dFontChar.uv0.y);
					uv[offset + num3 * 4 + 2] = new Vector2(tk2dFontChar.uv0.x, tk2dFontChar.uv1.y);
					uv[offset + num3 * 4 + 3] = new Vector2(tk2dFontChar.uv1.x, tk2dFontChar.uv1.y);
				}
				if (fontInst.textureGradients)
				{
					uv2[offset + num3 * 4] = tk2dFontChar.gradientUv[0] + new Vector2(tk2dTextGeomGen.meshGradientTexU, 0f);
					uv2[offset + num3 * 4 + 1] = tk2dFontChar.gradientUv[1] + new Vector2(tk2dTextGeomGen.meshGradientTexU, 0f);
					uv2[offset + num3 * 4 + 2] = tk2dFontChar.gradientUv[2] + new Vector2(tk2dTextGeomGen.meshGradientTexU, 0f);
					uv2[offset + num3 * 4 + 3] = tk2dFontChar.gradientUv[3] + new Vector2(tk2dTextGeomGen.meshGradientTexU, 0f);
				}
				if (fontInst.isPacked)
				{
					Color32 color2 = tk2dTextGeomGen.channelSelectColors[tk2dFontChar.channel];
					color[offset + num3 * 4] = color2;
					color[offset + num3 * 4 + 1] = color2;
					color[offset + num3 * 4 + 2] = color2;
					color[offset + num3 * 4 + 3] = color2;
				}
				else
				{
					color[offset + num3 * 4] = tk2dTextGeomGen.meshTopColor;
					color[offset + num3 * 4 + 1] = tk2dTextGeomGen.meshTopColor;
					color[offset + num3 * 4 + 2] = tk2dTextGeomGen.meshBottomColor;
					color[offset + num3 * 4 + 3] = tk2dTextGeomGen.meshBottomColor;
				}
				num += (tk2dFontChar.advance + textMeshData.spacing) * textMeshData.scale.x;
				if (textMeshData.kerning && num5 < formattedText.Length - 1)
				{
					foreach (tk2dFontKerning tk2dFontKerning in fontInst.kerning)
					{
						if (tk2dFontKerning.c0 == (int)formattedText[num5] && tk2dFontKerning.c1 == (int)formattedText[num5 + 1])
						{
							num += tk2dFontKerning.amount * textMeshData.scale.x;
							break;
						}
					}
				}
				num3++;
			}
			IL_673:
			num5++;
		}
		if (num4 != num3)
		{
			float lineWidth2 = num;
			int targetEnd2 = num3;
			float xanchorForWidth2 = tk2dTextGeomGen.GetXAnchorForWidth(lineWidth2, geomData);
			tk2dTextGeomGen.PostAlignTextData(pos, offset, num4, targetEnd2, xanchorForWidth2);
		}
		for (int j = num3; j < textMeshData.maxChars; j++)
		{
			pos[offset + j * 4] = (pos[offset + j * 4 + 1] = (pos[offset + j * 4 + 2] = (pos[offset + j * 4 + 3] = Vector3.zero)));
			uv[offset + j * 4] = (uv[offset + j * 4 + 1] = (uv[offset + j * 4 + 2] = (uv[offset + j * 4 + 3] = Vector2.zero)));
			if (fontInst.textureGradients)
			{
				uv2[offset + j * 4] = (uv2[offset + j * 4 + 1] = (uv2[offset + j * 4 + 2] = (uv2[offset + j * 4 + 3] = Vector2.zero)));
			}
			if (!fontInst.isPacked)
			{
				color[offset + j * 4] = (color[offset + j * 4 + 1] = tk2dTextGeomGen.meshTopColor);
				color[offset + j * 4 + 2] = (color[offset + j * 4 + 3] = tk2dTextGeomGen.meshBottomColor);
			}
			else
			{
				color[offset + j * 4] = (color[offset + j * 4 + 1] = (color[offset + j * 4 + 2] = (color[offset + j * 4 + 3] = Color.clear)));
			}
		}
		return num3;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00093230 File Offset: 0x00091430
	public static void SetTextMeshIndices(int[] indices, int offset, int vStart, tk2dTextGeomGen.GeomData geomData, int target)
	{
		tk2dTextMeshData textMeshData = geomData.textMeshData;
		for (int i = 0; i < textMeshData.maxChars; i++)
		{
			indices[offset + i * 6] = vStart + i * 4;
			indices[offset + i * 6 + 1] = vStart + i * 4 + 1;
			indices[offset + i * 6 + 2] = vStart + i * 4 + 3;
			indices[offset + i * 6 + 3] = vStart + i * 4 + 2;
			indices[offset + i * 6 + 4] = vStart + i * 4;
			indices[offset + i * 6 + 5] = vStart + i * 4 + 3;
		}
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x000932B0 File Offset: 0x000914B0
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dTextGeomGen()
	{
		tk2dTextGeomGen.tmpData = new tk2dTextGeomGen.GeomData();
		tk2dTextGeomGen.channelSelectColors = new Color32[]
		{
			new Color32(0, 0, byte.MaxValue, 0),
			new Color(0f, 255f, 0f, 0f),
			new Color(255f, 0f, 0f, 0f),
			new Color(0f, 0f, 0f, 255f)
		};
		tk2dTextGeomGen.meshTopColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		tk2dTextGeomGen.meshBottomColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		tk2dTextGeomGen.meshGradientTexU = 0f;
		tk2dTextGeomGen.curGradientCount = 1;
		tk2dTextGeomGen.errorColor = new Color32(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue);
	}

	// Token: 0x04002338 RID: 9016
	private static tk2dTextGeomGen.GeomData tmpData;

	// Token: 0x04002339 RID: 9017
	private static readonly Color32[] channelSelectColors;

	// Token: 0x0400233A RID: 9018
	private static Color32 meshTopColor;

	// Token: 0x0400233B RID: 9019
	private static Color32 meshBottomColor;

	// Token: 0x0400233C RID: 9020
	private static float meshGradientTexU;

	// Token: 0x0400233D RID: 9021
	private static int curGradientCount;

	// Token: 0x0400233E RID: 9022
	private static Color32 errorColor;

	// Token: 0x02000549 RID: 1353
	public class GeomData
	{
		// Token: 0x06001D88 RID: 7560 RVA: 0x000933BB File Offset: 0x000915BB
		public GeomData()
		{
			this.formattedText = "";
			base..ctor();
		}

		// Token: 0x0400233F RID: 9023
		internal tk2dTextMeshData textMeshData;

		// Token: 0x04002340 RID: 9024
		internal tk2dFontData fontInst;

		// Token: 0x04002341 RID: 9025
		internal string formattedText;
	}
}
