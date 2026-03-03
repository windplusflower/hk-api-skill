using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000129 RID: 297
[RequireComponent(typeof(ColorCorrectionCurves))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Dynamic Color Correction (Curves, Saturation)")]
public class ColorCurvesManager : MonoBehaviour
{
	// Token: 0x060006DE RID: 1758 RVA: 0x000276DA File Offset: 0x000258DA
	public void SetFactor(float factor)
	{
		this.Factor = factor;
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000276E3 File Offset: 0x000258E3
	public void SetSaturationA(float saturationA)
	{
		this.SaturationA = saturationA;
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x000276EC File Offset: 0x000258EC
	public void SetSaturationB(float saturationB)
	{
		this.SaturationB = saturationB;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000276F5 File Offset: 0x000258F5
	private void Start()
	{
		this.LastFactor = this.Factor;
		this.LastSaturationA = this.SaturationA;
		this.LastSaturationB = this.SaturationB;
		this.CurvesScript = base.GetComponent<ColorCorrectionCurves>();
		this.PairCurvesKeyframes();
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0002772D File Offset: 0x0002592D
	private void Update()
	{
		this.UpdateScript();
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00027738 File Offset: 0x00025938
	private void UpdateScript()
	{
		if (!this.PairedListsInitiated())
		{
			this.PairCurvesKeyframes();
		}
		if (this.ChangesInEditor)
		{
			this.PairCurvesKeyframes();
			this.UpdateScriptParameters();
			this.CurvesScript.UpdateParameters();
			this.ChangesInEditor = false;
			return;
		}
		if (this.Factor != this.LastFactor || this.SaturationA != this.LastSaturationA || this.SaturationB != this.LastSaturationB)
		{
			this.UpdateScriptParameters();
			this.CurvesScript.UpdateParameters();
			this.LastFactor = this.Factor;
			this.LastSaturationA = this.SaturationA;
			this.LastSaturationB = this.SaturationB;
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000277D9 File Offset: 0x000259D9
	private void EditorHasChanged()
	{
		this.ChangesInEditor = true;
		this.UpdateScript();
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000277E8 File Offset: 0x000259E8
	public static List<Keyframe[]> PairKeyframes(AnimationCurve curveA, AnimationCurve curveB)
	{
		if (curveA.length == curveB.length)
		{
			return ColorCurvesManager.SimplePairKeyframes(curveA, curveB);
		}
		List<Keyframe[]> list = new List<Keyframe[]>();
		List<Keyframe> list2 = new List<Keyframe>();
		List<Keyframe> list3 = new List<Keyframe>();
		list2.AddRange(curveA.keys);
		list3.AddRange(curveB.keys);
		int i = 0;
		while (i < list2.Count)
		{
			Keyframe aKeyframe = list2[i];
			int num = list3.FindIndex((Keyframe bKeyframe) => Mathf.Abs(aKeyframe.time - bKeyframe.time) < 0.01f);
			if (num >= 0)
			{
				Keyframe[] item = new Keyframe[]
				{
					list2[i],
					list3[num]
				};
				list.Add(item);
				list2.RemoveAt(i);
				list3.RemoveAt(num);
			}
			else
			{
				i++;
			}
		}
		foreach (Keyframe keyframe in list2)
		{
			Keyframe keyframe2 = ColorCurvesManager.CreatePair(keyframe, curveB);
			list.Add(new Keyframe[]
			{
				keyframe,
				keyframe2
			});
		}
		foreach (Keyframe keyframe3 in list3)
		{
			Keyframe keyframe4 = ColorCurvesManager.CreatePair(keyframe3, curveA);
			list.Add(new Keyframe[]
			{
				keyframe4,
				keyframe3
			});
		}
		return list;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0002797C File Offset: 0x00025B7C
	private static List<Keyframe[]> SimplePairKeyframes(AnimationCurve curveA, AnimationCurve curveB)
	{
		List<Keyframe[]> list = new List<Keyframe[]>();
		if (curveA.length != curveB.length)
		{
			throw new UnityException("Simple Pair cannot work with curves with different number of Keyframes.");
		}
		for (int i = 0; i < curveA.length; i++)
		{
			list.Add(new Keyframe[]
			{
				curveA.keys[i],
				curveB.keys[i]
			});
		}
		return list;
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x000279EC File Offset: 0x00025BEC
	private static Keyframe CreatePair(Keyframe kf, AnimationCurve curve)
	{
		Keyframe result = default(Keyframe);
		result.time = kf.time;
		result.value = curve.Evaluate(kf.time);
		if (kf.time >= 0.0012f)
		{
			float num = kf.time - 0.0012f;
			result.inTangent = (curve.Evaluate(num) - curve.Evaluate(kf.time)) / (num - kf.time);
		}
		if (kf.time + 0.0012f <= 1f)
		{
			float num2 = kf.time + 0.0012f;
			result.outTangent = (curve.Evaluate(num2) - curve.Evaluate(kf.time)) / (num2 - kf.time);
		}
		return result;
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00027AB0 File Offset: 0x00025CB0
	public static AnimationCurve CreateCurveFromKeyframes(IList<Keyframe[]> keyframePairs, float factor)
	{
		Keyframe[] array = new Keyframe[keyframePairs.Count];
		for (int i = 0; i < keyframePairs.Count; i++)
		{
			Keyframe[] array2 = keyframePairs[i];
			array[i] = ColorCurvesManager.AverageKeyframe(array2[0], array2[1], factor);
		}
		return new AnimationCurve(array);
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00027B04 File Offset: 0x00025D04
	public static Keyframe AverageKeyframe(Keyframe a, Keyframe b, float factor)
	{
		return new Keyframe
		{
			time = a.time * (1f - factor) + b.time * factor,
			value = a.value * (1f - factor) + b.value * factor,
			inTangent = a.inTangent * (1f - factor) + b.inTangent * factor,
			outTangent = a.outTangent * (1f - factor) + b.outTangent * factor
		};
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00027B9C File Offset: 0x00025D9C
	private void PairCurvesKeyframes()
	{
		this.RedPairedKeyframes = ColorCurvesManager.PairKeyframes(this.RedA, this.RedB);
		this.GreenPairedKeyframes = ColorCurvesManager.PairKeyframes(this.GreenA, this.GreenB);
		this.BluePairedKeyframes = ColorCurvesManager.PairKeyframes(this.BlueA, this.BlueB);
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00027BF0 File Offset: 0x00025DF0
	private void UpdateScriptParameters()
	{
		this.Factor = Mathf.Clamp01(this.Factor);
		this.SaturationA = Mathf.Clamp(this.SaturationA, 0f, 5f);
		this.SaturationB = Mathf.Clamp(this.SaturationB, 0f, 5f);
		this.CurvesScript.saturation = Mathf.Lerp(this.SaturationA, this.SaturationB, this.Factor);
		this.CurvesScript.redChannel = ColorCurvesManager.CreateCurveFromKeyframes(this.RedPairedKeyframes, this.Factor);
		this.CurvesScript.greenChannel = ColorCurvesManager.CreateCurveFromKeyframes(this.GreenPairedKeyframes, this.Factor);
		this.CurvesScript.blueChannel = ColorCurvesManager.CreateCurveFromKeyframes(this.BluePairedKeyframes, this.Factor);
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00027CBA File Offset: 0x00025EBA
	private bool PairedListsInitiated()
	{
		return this.RedPairedKeyframes != null && this.GreenPairedKeyframes != null && this.BluePairedKeyframes != null && this.DepthRedPairedKeyframes != null && this.DepthGreenPairedKeyframes != null && this.DepthBluePairedKeyframes != null;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00027CF0 File Offset: 0x00025EF0
	public ColorCurvesManager()
	{
		this.SaturationA = 1f;
		this.RedA = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.GreenA = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.BlueA = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.AmbientColorA = Color.white;
		this.AmbientIntensityA = 1f;
		this.HeroLightColorA = Color.white;
		this.SaturationB = 1f;
		this.RedB = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.GreenB = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.BlueB = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.AmbientColorB = Color.white;
		this.AmbientIntensityB = 1f;
		this.HeroLightColorB = Color.white;
		this.ChangesInEditor = true;
		base..ctor();
	}

	// Token: 0x0400076C RID: 1900
	public float Factor;

	// Token: 0x0400076D RID: 1901
	public float SaturationA;

	// Token: 0x0400076E RID: 1902
	public AnimationCurve RedA;

	// Token: 0x0400076F RID: 1903
	public AnimationCurve GreenA;

	// Token: 0x04000770 RID: 1904
	public AnimationCurve BlueA;

	// Token: 0x04000771 RID: 1905
	public Color AmbientColorA;

	// Token: 0x04000772 RID: 1906
	public float AmbientIntensityA;

	// Token: 0x04000773 RID: 1907
	public Color HeroLightColorA;

	// Token: 0x04000774 RID: 1908
	public float SaturationB;

	// Token: 0x04000775 RID: 1909
	public AnimationCurve RedB;

	// Token: 0x04000776 RID: 1910
	public AnimationCurve GreenB;

	// Token: 0x04000777 RID: 1911
	public AnimationCurve BlueB;

	// Token: 0x04000778 RID: 1912
	public Color AmbientColorB;

	// Token: 0x04000779 RID: 1913
	public float AmbientIntensityB;

	// Token: 0x0400077A RID: 1914
	public Color HeroLightColorB;

	// Token: 0x0400077B RID: 1915
	private List<Keyframe[]> RedPairedKeyframes;

	// Token: 0x0400077C RID: 1916
	private List<Keyframe[]> GreenPairedKeyframes;

	// Token: 0x0400077D RID: 1917
	private List<Keyframe[]> BluePairedKeyframes;

	// Token: 0x0400077E RID: 1918
	private List<Keyframe[]> DepthRedPairedKeyframes;

	// Token: 0x0400077F RID: 1919
	private List<Keyframe[]> DepthGreenPairedKeyframes;

	// Token: 0x04000780 RID: 1920
	private List<Keyframe[]> DepthBluePairedKeyframes;

	// Token: 0x04000781 RID: 1921
	private List<Keyframe[]> ZCurvePairedKeyframes;

	// Token: 0x04000782 RID: 1922
	private ColorCorrectionCurves CurvesScript;

	// Token: 0x04000783 RID: 1923
	private const float PAIRING_DISTANCE = 0.01f;

	// Token: 0x04000784 RID: 1924
	private const float TANGENT_DISTANCE = 0.0012f;

	// Token: 0x04000785 RID: 1925
	private bool ChangesInEditor;

	// Token: 0x04000786 RID: 1926
	private float LastFactor;

	// Token: 0x04000787 RID: 1927
	private float LastSaturationA;

	// Token: 0x04000788 RID: 1928
	private float LastSaturationB;
}
