using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000146 RID: 326
[RequireComponent(typeof(ColorCorrectionCurves))]
public class SceneColorManager : MonoBehaviour
{
	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600078C RID: 1932 RVA: 0x0002AC5C File Offset: 0x00028E5C
	// (set) Token: 0x0600078D RID: 1933 RVA: 0x0002AC64 File Offset: 0x00028E64
	public bool markerActive { get; private set; }

	// Token: 0x0600078E RID: 1934 RVA: 0x0002AC6D File Offset: 0x00028E6D
	public void SetFactor(float factor)
	{
		this.Factor = factor;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0002AC76 File Offset: 0x00028E76
	public void SetSaturationA(float saturationA)
	{
		this.SaturationA = saturationA;
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0002AC7F File Offset: 0x00028E7F
	public void SetSaturationB(float saturationB)
	{
		this.SaturationB = saturationB;
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x0002AC88 File Offset: 0x00028E88
	// (set) Token: 0x06000792 RID: 1938 RVA: 0x0002AC90 File Offset: 0x00028E90
	public bool startBufferActive { get; private set; }

	// Token: 0x06000793 RID: 1939 RVA: 0x0002AC9C File Offset: 0x00028E9C
	public void GameInit()
	{
		this.CurvesScript = base.GetComponent<ColorCorrectionCurves>();
		SceneColorManager.tempA = new List<Keyframe>(128);
		SceneColorManager.tempB = new List<Keyframe>(128);
		SceneColorManager.finalFramesList = new List<Keyframe>(128);
		SceneColorManager.simplePairList = new List<Keyframe[]>(128);
		this.gm = GameManager.instance;
		this.gm.UnloadingLevel += this.OnLevelUnload;
		this.UpdateSceneType();
		this.LastFactor = this.Factor;
		this.LastSaturationA = this.SaturationA;
		this.LastSaturationB = this.SaturationB;
		this.LastAmbientIntensityA = this.AmbientIntensityA;
		this.LastAmbientIntensityB = this.AmbientIntensityB;
		this.PairCurvesKeyframes();
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0002AD5C File Offset: 0x00028F5C
	public void SceneInit()
	{
		this.UpdateSceneType();
		if (!this.gameplayScene)
		{
			this.Factor = 0f;
			return;
		}
		this.startBufferActive = true;
		this.markerActive = true;
		this.UpdateScript(true);
		base.Invoke("FinishBufferPeriod", this.startBufferDuration);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0002ADA9 File Offset: 0x00028FA9
	private void Update()
	{
		if ((this.markerActive || this.startBufferActive) && (float)Time.frameCount % 1f == 0f)
		{
			this.UpdateScript(false);
		}
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0002ADD5 File Offset: 0x00028FD5
	private void OnLevelUnload()
	{
		this.Factor = 0f;
		this.markerActive = false;
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0002ADE9 File Offset: 0x00028FE9
	private void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.UnloadingLevel -= this.OnLevelUnload;
		}
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0002AE10 File Offset: 0x00029010
	public IEnumerator ForceRefresh()
	{
		this.UpdateScript(false);
		this.SetFactor(0.0002f);
		yield return new WaitForSeconds(0.1f);
		this.UpdateScript(false);
		yield break;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0002AE1F File Offset: 0x0002901F
	private void FinishBufferPeriod()
	{
		this.UpdateScript(true);
		this.startBufferActive = false;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0002AE2F File Offset: 0x0002902F
	public void MarkerActive(bool active)
	{
		if (!this.startBufferActive)
		{
			this.markerActive = active;
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0002AE40 File Offset: 0x00029040
	public void UpdateScript(bool forceUpdate = false)
	{
		if (this.CurvesScript == null)
		{
			base.GetComponent<ColorCorrectionCurves>();
		}
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
		if (forceUpdate)
		{
			this.PairCurvesKeyframes();
			this.UpdateScriptParameters();
			this.CurvesScript.UpdateParameters();
			return;
		}
		if (this.Factor != this.LastFactor || this.SaturationA != this.LastSaturationA || this.SaturationB != this.LastSaturationB || this.AmbientIntensityA != this.LastAmbientIntensityA || this.AmbientIntensityB != this.LastAmbientIntensityB)
		{
			this.UpdateScriptParameters();
			this.CurvesScript.UpdateParameters();
			this.LastFactor = this.Factor;
			this.LastSaturationA = this.SaturationA;
			this.LastSaturationB = this.SaturationB;
			this.LastAmbientIntensityA = this.AmbientIntensityA;
			this.LastAmbientIntensityB = this.AmbientIntensityB;
		}
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0002AF45 File Offset: 0x00029145
	private void EditorHasChanged()
	{
		this.ChangesInEditor = true;
		this.UpdateScript(false);
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0002AF58 File Offset: 0x00029158
	public static List<Keyframe[]> PairKeyframes(AnimationCurve curveA, AnimationCurve curveB)
	{
		if (curveA.length == curveB.length)
		{
			return SceneColorManager.SimplePairKeyframes(curveA, curveB);
		}
		List<Keyframe[]> list = new List<Keyframe[]>();
		SceneColorManager.tempA.Clear();
		SceneColorManager.tempA.AddRange(curveA.keys);
		SceneColorManager.tempB.Clear();
		SceneColorManager.tempB.AddRange(curveB.keys);
		int i = 0;
		bool flag = false;
		Keyframe aKeyframe = SceneColorManager.tempA[i];
		Predicate<Keyframe> <>9__0;
		while (i < SceneColorManager.tempA.Count)
		{
			if (flag)
			{
				aKeyframe = SceneColorManager.tempA[i];
			}
			List<Keyframe> list2 = SceneColorManager.tempB;
			Predicate<Keyframe> match;
			if ((match = <>9__0) == null)
			{
				match = (<>9__0 = ((Keyframe bKeyframe) => Mathf.Abs(aKeyframe.time - bKeyframe.time) < 0.01f));
			}
			int num = list2.FindIndex(match);
			if (num >= 0)
			{
				Keyframe[] item = new Keyframe[]
				{
					SceneColorManager.tempA[i],
					SceneColorManager.tempB[num]
				};
				list.Add(item);
				SceneColorManager.tempA.RemoveAt(i);
				SceneColorManager.tempB.RemoveAt(num);
				flag = false;
			}
			else
			{
				i++;
				flag = true;
			}
		}
		for (int j = 0; j < SceneColorManager.tempA.Count; j++)
		{
			Keyframe keyframe = SceneColorManager.CreatePair(SceneColorManager.tempA[j], curveB);
			list.Add(new Keyframe[]
			{
				SceneColorManager.tempA[j],
				keyframe
			});
		}
		for (int k = 0; k < SceneColorManager.tempB.Count; k++)
		{
			Keyframe keyframe2 = SceneColorManager.CreatePair(SceneColorManager.tempB[k], curveA);
			list.Add(new Keyframe[]
			{
				keyframe2,
				SceneColorManager.tempB[k]
			});
		}
		return list;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0002B12C File Offset: 0x0002932C
	private static List<Keyframe[]> SimplePairKeyframes(AnimationCurve curveA, AnimationCurve curveB)
	{
		if (curveA.length != curveB.length)
		{
			throw new UnityException("Simple Pair cannot work with curves with different number of Keyframes.");
		}
		List<Keyframe[]> list = new List<Keyframe[]>();
		Keyframe[] keys = curveA.keys;
		Keyframe[] keys2 = curveB.keys;
		for (int i = 0; i < curveA.length; i++)
		{
			list.Add(new Keyframe[]
			{
				keys[i],
				keys2[i]
			});
		}
		return list;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0002B1A0 File Offset: 0x000293A0
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

	// Token: 0x060007A0 RID: 1952 RVA: 0x0002B264 File Offset: 0x00029464
	public static AnimationCurve CreateCurveFromKeyframes(IList<Keyframe[]> keyframePairs, float factor)
	{
		SceneColorManager.finalFramesList.Clear();
		for (int i = 0; i < keyframePairs.Count; i++)
		{
			Keyframe[] array = keyframePairs[i];
			SceneColorManager.finalFramesList.Add(SceneColorManager.AverageKeyframe(array[0], array[1], factor));
		}
		return new AnimationCurve(SceneColorManager.finalFramesList.ToArray());
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0002B2C4 File Offset: 0x000294C4
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

	// Token: 0x060007A2 RID: 1954 RVA: 0x0002B35C File Offset: 0x0002955C
	private void PairCurvesKeyframes()
	{
		this.RedPairedKeyframes = SceneColorManager.PairKeyframes(this.RedA, this.RedB);
		this.GreenPairedKeyframes = SceneColorManager.PairKeyframes(this.GreenA, this.GreenB);
		this.BluePairedKeyframes = SceneColorManager.PairKeyframes(this.BlueA, this.BlueB);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0002B3B0 File Offset: 0x000295B0
	private void UpdateScriptParameters()
	{
		if (this.CurvesScript == null)
		{
			this.CurvesScript = base.GetComponent<ColorCorrectionCurves>();
		}
		this.Factor = Mathf.Clamp01(this.Factor);
		this.SaturationA = Mathf.Clamp(this.SaturationA, 0f, 5f);
		this.SaturationB = Mathf.Clamp(this.SaturationB, 0f, 5f);
		this.CurvesScript.saturation = Mathf.Lerp(this.SaturationA, this.SaturationB, this.Factor);
		this.CurvesScript.redChannel = SceneColorManager.CreateCurveFromKeyframes(this.RedPairedKeyframes, this.Factor);
		this.CurvesScript.greenChannel = SceneColorManager.CreateCurveFromKeyframes(this.GreenPairedKeyframes, this.Factor);
		this.CurvesScript.blueChannel = SceneColorManager.CreateCurveFromKeyframes(this.BluePairedKeyframes, this.Factor);
		SceneManager.SetLighting(Color.Lerp(this.AmbientColorA, this.AmbientColorB, this.Factor), Mathf.Lerp(this.AmbientIntensityA, this.AmbientIntensityB, this.Factor));
		if (this.gameplayScene)
		{
			if (this.hero == null)
			{
				this.hero = HeroController.instance;
			}
			this.hero.heroLight.color = Color.Lerp(this.HeroLightColorA, this.HeroLightColorB, this.Factor);
		}
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x0002B50F File Offset: 0x0002970F
	private bool PairedListsInitiated()
	{
		return this.RedPairedKeyframes != null && this.GreenPairedKeyframes != null && this.BluePairedKeyframes != null;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x0002B52C File Offset: 0x0002972C
	private void UpdateSceneType()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.gm.IsGameplayScene())
		{
			this.gameplayScene = true;
			if (this.hero == null)
			{
				this.hero = HeroController.instance;
				return;
			}
		}
		else
		{
			this.gameplayScene = false;
		}
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0002B588 File Offset: 0x00029788
	public SceneColorManager()
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
		this.startBufferDuration = 0.5f;
		base..ctor();
	}

	// Token: 0x0400085B RID: 2139
	public float Factor;

	// Token: 0x0400085C RID: 2140
	public float SaturationA;

	// Token: 0x0400085D RID: 2141
	public AnimationCurve RedA;

	// Token: 0x0400085E RID: 2142
	public AnimationCurve GreenA;

	// Token: 0x0400085F RID: 2143
	public AnimationCurve BlueA;

	// Token: 0x04000860 RID: 2144
	public Color AmbientColorA;

	// Token: 0x04000861 RID: 2145
	public float AmbientIntensityA;

	// Token: 0x04000862 RID: 2146
	public Color HeroLightColorA;

	// Token: 0x04000863 RID: 2147
	public float SaturationB;

	// Token: 0x04000864 RID: 2148
	public AnimationCurve RedB;

	// Token: 0x04000865 RID: 2149
	public AnimationCurve GreenB;

	// Token: 0x04000866 RID: 2150
	public AnimationCurve BlueB;

	// Token: 0x04000867 RID: 2151
	public Color AmbientColorB;

	// Token: 0x04000868 RID: 2152
	public float AmbientIntensityB;

	// Token: 0x04000869 RID: 2153
	public Color HeroLightColorB;

	// Token: 0x0400086A RID: 2154
	private List<Keyframe[]> RedPairedKeyframes;

	// Token: 0x0400086B RID: 2155
	private List<Keyframe[]> GreenPairedKeyframes;

	// Token: 0x0400086C RID: 2156
	private List<Keyframe[]> BluePairedKeyframes;

	// Token: 0x0400086D RID: 2157
	private ColorCorrectionCurves CurvesScript;

	// Token: 0x0400086E RID: 2158
	private const float PAIRING_DISTANCE = 0.01f;

	// Token: 0x0400086F RID: 2159
	private const float TANGENT_DISTANCE = 0.0012f;

	// Token: 0x04000870 RID: 2160
	private const float UPDATE_RATE = 1f;

	// Token: 0x04000871 RID: 2161
	private bool gameplayScene;

	// Token: 0x04000872 RID: 2162
	private HeroController hero;

	// Token: 0x04000873 RID: 2163
	private GameManager gm;

	// Token: 0x04000874 RID: 2164
	private static List<Keyframe> tempA;

	// Token: 0x04000875 RID: 2165
	private static List<Keyframe> tempB;

	// Token: 0x04000876 RID: 2166
	private static List<Keyframe> finalFramesList;

	// Token: 0x04000877 RID: 2167
	private static List<Keyframe[]> simplePairList;

	// Token: 0x04000878 RID: 2168
	private bool ChangesInEditor;

	// Token: 0x04000879 RID: 2169
	private float LastFactor;

	// Token: 0x0400087A RID: 2170
	private float LastSaturationA;

	// Token: 0x0400087B RID: 2171
	private float LastSaturationB;

	// Token: 0x0400087C RID: 2172
	private float LastAmbientIntensityA;

	// Token: 0x0400087D RID: 2173
	private float LastAmbientIntensityB;

	// Token: 0x0400087E RID: 2174
	private float startBufferDuration;
}
