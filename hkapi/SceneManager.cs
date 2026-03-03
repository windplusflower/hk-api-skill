using System;
using System.Collections.Generic;
using GlobalEnums;
using Modding;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Token: 0x02000318 RID: 792
[Serializable]
public class SceneManager : MonoBehaviour
{
	// Token: 0x06001164 RID: 4452 RVA: 0x000513CC File Offset: 0x0004F5CC
	private void Start()
	{
		try
		{
			this.orig_Start();
		}
		catch (NullReferenceException obj) when (!ModLoader.LoadState.HasFlag(ModLoader.ModLoadState.Preloaded))
		{
		}
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x00051420 File Offset: 0x0004F620
	public static void SetLighting(Color ambientLightColor, float ambientLightIntensity)
	{
		float num = Mathf.Lerp(1f, ambientLightIntensity, global::SceneManager.AmbientIntesityMix);
		RenderSettings.ambientLight = new Color(ambientLightColor.r * num, ambientLightColor.g * num, ambientLightColor.b * num, 1f);
		RenderSettings.ambientIntensity = 1f;
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x00051470 File Offset: 0x0004F670
	private void Update()
	{
		if (this.gameplayScene && !this.heroInfoSent && this.heroCtrl != null && (this.heroCtrl.heroLight == null || this.heroCtrl.heroLight.material == null))
		{
			this.heroCtrl.SetDarkness(this.darknessLevel);
			this.heroInfoSent = true;
		}
		this.orig_Update();
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x000514E4 File Offset: 0x0004F6E4
	public int GetDarknessLevel()
	{
		return this.darknessLevel;
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x000514EC File Offset: 0x0004F6EC
	public void SetWindy(bool setting)
	{
		this.isWindy = setting;
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x000514F5 File Offset: 0x0004F6F5
	public float AdjustSaturation(float originalSaturation)
	{
		if (this.ignorePlatformSaturationModifiers)
		{
			return originalSaturation;
		}
		return global::SceneManager.AdjustSaturationForPlatform(originalSaturation, new MapZone?(this.mapZone));
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00051514 File Offset: 0x0004F714
	public static float AdjustSaturationForPlatform(float originalSaturation, MapZone? mapZone = null)
	{
		if (Application.platform == RuntimePlatform.Switch)
		{
			if (mapZone != null)
			{
				MapZone? mapZone2 = mapZone;
				MapZone mapZone3 = MapZone.GODS_GLORY;
				if (mapZone2.GetValueOrDefault() == mapZone3 & mapZone2 != null)
				{
					return originalSaturation + 0.1466f;
				}
			}
			return originalSaturation + 0.17f;
		}
		return originalSaturation + 0.1466f;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00051564 File Offset: 0x0004F764
	private void PrintDebugInfo()
	{
		string text = "SM Setting Curves to ";
		text += "R: (";
		foreach (Keyframe keyframe in this.redChannel.keys)
		{
			text = text + keyframe.value.ToString() + ", ";
		}
		text += ") G: (";
		foreach (Keyframe keyframe2 in this.greenChannel.keys)
		{
			text = text + keyframe2.value.ToString() + ", ";
		}
		text += " ) B: (";
		foreach (Keyframe keyframe3 in this.blueChannel.keys)
		{
			text = text + keyframe3.value.ToString() + ", ";
		}
		text = text + ") S: " + this.saturation.ToString();
		Debug.Log(text);
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00051674 File Offset: 0x0004F874
	private void DrawBlackBorders()
	{
		List<GameObject> list = new List<GameObject>();
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.borderPrefab);
		gameObject.transform.SetPosition2D(this.gm.sceneWidth + 10f, this.gm.sceneHeight / 2f);
		gameObject.transform.localScale = new Vector2(20f, this.gm.sceneHeight + 40f);
		list.Add(gameObject);
		gameObject = UnityEngine.Object.Instantiate<GameObject>(this.borderPrefab);
		gameObject.transform.SetPosition2D(-10f, this.gm.sceneHeight / 2f);
		gameObject.transform.localScale = new Vector2(20f, this.gm.sceneHeight + 40f);
		list.Add(gameObject);
		gameObject = UnityEngine.Object.Instantiate<GameObject>(this.borderPrefab);
		gameObject.transform.SetPosition2D(this.gm.sceneWidth / 2f, this.gm.sceneHeight + 10f);
		gameObject.transform.localScale = new Vector2(40f + this.gm.sceneWidth, 20f);
		list.Add(gameObject);
		gameObject = UnityEngine.Object.Instantiate<GameObject>(this.borderPrefab);
		gameObject.transform.SetPosition2D(this.gm.sceneWidth / 2f, -10f);
		gameObject.transform.localScale = new Vector2(40f + this.gm.sceneWidth, 20f);
		list.Add(gameObject);
		ModHooks.OnDrawBlackBorders(list);
		foreach (GameObject go in list)
		{
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go, base.gameObject.scene);
		}
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00051868 File Offset: 0x0004FA68
	private void AddSceneMapped()
	{
		if (!this.pd.GetVariable<List<string>>("scenesVisited").Contains(this.gm.GetSceneNameString()) && !this.manualMapTrigger && this.mapZone != MapZone.WHITE_PALACE && this.mapZone != MapZone.GODS_GLORY)
		{
			this.pd.GetVariable<List<string>>("scenesVisited").Add(this.gm.GetSceneNameString());
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x000518D4 File Offset: 0x0004FAD4
	public void UpdateSceneSettings(SceneManagerSettings sms)
	{
		this.mapZone = sms.mapZone;
		this.defaultColor = new Color(sms.defaultColor.r, sms.defaultColor.g, sms.defaultColor.b, sms.defaultColor.a);
		this.defaultIntensity = sms.defaultIntensity;
		this.saturation = sms.saturation;
		this.redChannel = new AnimationCurve(sms.redChannel.keys.Clone() as Keyframe[]);
		this.greenChannel = new AnimationCurve(sms.greenChannel.keys.Clone() as Keyframe[]);
		this.blueChannel = new AnimationCurve(sms.blueChannel.keys.Clone() as Keyframe[]);
		this.heroLightColor = new Color(sms.heroLightColor.r, sms.heroLightColor.g, sms.heroLightColor.b, sms.heroLightColor.a);
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x000519D3 File Offset: 0x0004FBD3
	// Note: this type is marked as 'beforefieldinit'.
	static SceneManager()
	{
		global::SceneManager.AmbientIntesityMix = 0.5f;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x000519E0 File Offset: 0x0004FBE0
	private void orig_Update()
	{
		if (this.isGameplayScene)
		{
			if (this.enviroTimer < 0.25f)
			{
				this.enviroTimer += Time.deltaTime;
			}
			else if (!this.enviroSent && this.heroCtrl != null)
			{
				this.heroCtrl.checkEnvironment();
				this.enviroSent = true;
			}
			if (!this.heroInfoSent && this.heroCtrl != null)
			{
				this.heroCtrl.heroLight.material.SetColor("_Color", Color.white);
				this.heroCtrl.SetDarkness(this.darknessLevel);
				this.heroInfoSent = true;
			}
			if (!this.setSaturation)
			{
				if (this.AdjustSaturation(this.saturation) != this.gc.colorCorrectionCurves.saturation)
				{
					this.gc.colorCorrectionCurves.saturation = this.AdjustSaturation(this.saturation);
				}
				this.setSaturation = true;
			}
		}
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00051AD8 File Offset: 0x0004FCD8
	private void orig_Start()
	{
		this.gm = GameManager.instance;
		this.gc = GameCameras.instance;
		this.pd = PlayerData.instance;
		if (this.gm.IsGameplayScene())
		{
			this.isGameplayScene = true;
			this.heroCtrl = HeroController.instance;
		}
		else
		{
			this.isGameplayScene = false;
		}
		this.gc.colorCorrectionCurves.saturation = this.AdjustSaturation(this.saturation);
		this.gc.colorCorrectionCurves.redChannel = this.redChannel;
		this.gc.colorCorrectionCurves.greenChannel = this.greenChannel;
		this.gc.colorCorrectionCurves.blueChannel = this.blueChannel;
		this.gc.colorCorrectionCurves.UpdateParameters();
		this.gc.sceneColorManager.SaturationA = this.AdjustSaturation(this.saturation);
		this.gc.sceneColorManager.RedA = this.redChannel;
		this.gc.sceneColorManager.GreenA = this.greenChannel;
		this.gc.sceneColorManager.BlueA = this.blueChannel;
		global::SceneManager.SetLighting(this.defaultColor, this.defaultIntensity);
		this.gc.sceneColorManager.AmbientColorA = this.defaultColor;
		this.gc.sceneColorManager.AmbientIntensityA = this.defaultIntensity;
		if (this.isGameplayScene)
		{
			if (this.heroCtrl != null)
			{
				this.heroCtrl.heroLight.color = this.heroLightColor;
			}
			this.gc.sceneColorManager.HeroLightColorA = this.heroLightColor;
		}
		this.pd.SetIntSwappedArgs(this.environmentType, "environmentType");
		this.pd.SetIntSwappedArgs(this.environmentType, "environmentTypeDefault");
		if (GameManager.instance)
		{
			GameManager.EnterSceneEvent temp = null;
			temp = delegate()
			{
				this.AddSceneMapped();
				GameManager.instance.OnFinishedEnteringScene -= temp;
			};
			GameManager.instance.OnFinishedEnteringScene += temp;
		}
		else
		{
			this.AddSceneMapped();
		}
		if (this.atmosCue != null)
		{
			this.gm.AudioManager.ApplyAtmosCue(this.atmosCue, this.transitionTime);
		}
		MusicCue x = this.musicCue;
		if (this.gm.playerData.GetBool("crossroadsInfected") && this.infectedMusicCue != null)
		{
			x = this.infectedMusicCue;
		}
		if (x != null)
		{
			this.gm.AudioManager.ApplyMusicCue(x, this.musicDelayTime, this.musicTransitionTime, false);
		}
		if (this.musicSnapshot != null)
		{
			this.gm.AudioManager.ApplyMusicSnapshot(this.musicSnapshot, this.musicDelayTime, this.musicTransitionTime);
		}
		if (this.enviroSnapshot != null)
		{
			this.enviroSnapshot.TransitionTo(this.transitionTime);
		}
		if (this.actorSnapshot != null)
		{
			this.actorSnapshot.TransitionTo(this.transitionTime);
		}
		if (this.shadeSnapshot != null)
		{
			this.shadeSnapshot.TransitionTo(this.transitionTime);
		}
		if (this.sceneType == SceneType.GAMEPLAY)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Vignette");
			if (gameObject)
			{
				PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(gameObject, "Darkness Control");
				if (playMakerFSM)
				{
					FSMUtility.SetInt(playMakerFSM, "Darkness Level", this.darknessLevel);
				}
				if (!this.noLantern)
				{
					FSMUtility.LocateFSM(gameObject, "Darkness Control").SendEvent("RESET");
				}
				else
				{
					FSMUtility.LocateFSM(gameObject, "Darkness Control").SendEvent("SCENE RESET NO LANTERN");
					if (this.heroCtrl != null)
					{
						this.heroCtrl.wieldingLantern = false;
					}
				}
			}
		}
		if (this.isGameplayScene)
		{
			this.DrawBlackBorders();
		}
		if (this.pd.GetBool("soulLimited") && this.isGameplayScene && this.pd.GetString("shadeScene") == base.gameObject.scene.name)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.hollowShadeObject, new Vector3(this.pd.GetFloat("shadePositionX"), this.pd.GetFloat("shadePositionY"), 0.006f), Quaternion.identity);
			gameObject2.transform.SetParent(base.transform, true);
			gameObject2.transform.SetParent(null);
		}
		if (this.isGameplayScene && this.pd.GetString("dreamGateScene") == base.gameObject.scene.name)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.dreamgateObject, new Vector3(this.pd.GetFloat("dreamGateX"), this.pd.GetFloat("dreamGateY") - 1.429361f, -0.002f), Quaternion.identity);
			gameObject3.transform.SetParent(base.transform, true);
			gameObject3.transform.SetParent(null);
		}
	}

	// Token: 0x04001103 RID: 4355
	[Space(6f)]
	[Tooltip("This denotes the type of this scene, mainly if it is a gameplay scene or not.")]
	public SceneType sceneType;

	// Token: 0x04001104 RID: 4356
	[Header("Gameplay Scene Settings")]
	[Tooltip("The area of the map this scene belongs to.")]
	[Space(6f)]
	public MapZone mapZone;

	// Token: 0x04001105 RID: 4357
	[Tooltip("Determines if this area is currently windy.")]
	public bool isWindy;

	// Token: 0x04001106 RID: 4358
	[Tooltip("Determines if this level experiences tremors.")]
	public bool isTremorZone;

	// Token: 0x04001107 RID: 4359
	[Tooltip("Set environment type on scene entry. 0 = Dust, 1 = Grass, 2 = Bone, 3 = Spa, 4 = Metal, 5 = No Effect, 6 = Wet")]
	public int environmentType;

	// Token: 0x04001108 RID: 4360
	public int darknessLevel;

	// Token: 0x04001109 RID: 4361
	public bool noLantern;

	// Token: 0x0400110A RID: 4362
	[Header("Camera Color Correction Curves")]
	[Range(0f, 5f)]
	public float saturation;

	// Token: 0x0400110B RID: 4363
	public bool ignorePlatformSaturationModifiers;

	// Token: 0x0400110C RID: 4364
	public AnimationCurve redChannel;

	// Token: 0x0400110D RID: 4365
	public AnimationCurve greenChannel;

	// Token: 0x0400110E RID: 4366
	public AnimationCurve blueChannel;

	// Token: 0x0400110F RID: 4367
	[Header("Ambient Light")]
	[Tooltip("The default ambient light colour for this scene.")]
	[Space(6f)]
	public Color defaultColor;

	// Token: 0x04001110 RID: 4368
	[Tooltip("The intensity of the ambient light in this scene.")]
	[Range(0f, 1f)]
	public float defaultIntensity;

	// Token: 0x04001111 RID: 4369
	[Header("Hero Light")]
	[Tooltip("Color of the hero's light gradient (not point lights)")]
	[Space(6f)]
	public Color heroLightColor;

	// Token: 0x04001112 RID: 4370
	[Header("Scene Particles")]
	public bool noParticles;

	// Token: 0x04001113 RID: 4371
	public MapZone overrideParticlesWith;

	// Token: 0x04001114 RID: 4372
	[Header("Audio Snapshots")]
	[Space(6f)]
	[SerializeField]
	private AtmosCue atmosCue;

	// Token: 0x04001115 RID: 4373
	[SerializeField]
	private MusicCue musicCue;

	// Token: 0x04001116 RID: 4374
	[SerializeField]
	private MusicCue infectedMusicCue;

	// Token: 0x04001117 RID: 4375
	[SerializeField]
	private AudioMixerSnapshot musicSnapshot;

	// Token: 0x04001118 RID: 4376
	[SerializeField]
	private float musicDelayTime;

	// Token: 0x04001119 RID: 4377
	[SerializeField]
	private float musicTransitionTime;

	// Token: 0x0400111A RID: 4378
	public AudioMixerSnapshot atmosSnapshot;

	// Token: 0x0400111B RID: 4379
	public AudioMixerSnapshot enviroSnapshot;

	// Token: 0x0400111C RID: 4380
	public AudioMixerSnapshot actorSnapshot;

	// Token: 0x0400111D RID: 4381
	public AudioMixerSnapshot shadeSnapshot;

	// Token: 0x0400111E RID: 4382
	public float transitionTime;

	// Token: 0x0400111F RID: 4383
	[Header("Scene Border")]
	[Space(6f)]
	public GameObject borderPrefab;

	// Token: 0x04001120 RID: 4384
	[Header("Mapping")]
	[Space(6f)]
	public bool manualMapTrigger;

	// Token: 0x04001121 RID: 4385
	[Header("Object Spawns")]
	[Space(6f)]
	public GameObject hollowShadeObject;

	// Token: 0x04001122 RID: 4386
	public GameObject dreamgateObject;

	// Token: 0x04001123 RID: 4387
	private GameManager gm;

	// Token: 0x04001124 RID: 4388
	private GameCameras gc;

	// Token: 0x04001125 RID: 4389
	private HeroController heroCtrl;

	// Token: 0x04001126 RID: 4390
	private PlayerData pd;

	// Token: 0x04001127 RID: 4391
	private float enviroTimer;

	// Token: 0x04001128 RID: 4392
	private bool enviroSent;

	// Token: 0x04001129 RID: 4393
	private bool heroInfoSent;

	// Token: 0x0400112A RID: 4394
	private bool setSaturation;

	// Token: 0x0400112B RID: 4395
	private bool isGameplayScene;

	// Token: 0x0400112C RID: 4396
	public static float AmbientIntesityMix;

	// Token: 0x0400112D RID: 4397
	private const float SwitchConstant = 0.17f;

	// Token: 0x0400112E RID: 4398
	private const float SwitchConstantGG = 0.1466f;

	// Token: 0x0400112F RID: 4399
	private const float RegularConstant = 0.1466f;

	// Token: 0x04001130 RID: 4400
	private bool gameplayScene;
}
