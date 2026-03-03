using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

// Token: 0x0200049D RID: 1181
public class MenuStyles : MonoBehaviour
{
	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0007E635 File Offset: 0x0007C835
	public int CurrentStyle
	{
		get
		{
			return this.currentSettings.styleIndex;
		}
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x0007E642 File Offset: 0x0007C842
	private void Awake()
	{
		MenuStyles.Instance = this;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x0007E64C File Offset: 0x0007C84C
	private void Start()
	{
		this.currentSettings = this.StyleDefault;
		foreach (MenuStyles.StyleSettingsPlatform styleSettingsPlatform in this.StylePlatforms)
		{
			if (Application.platform == styleSettingsPlatform.platform)
			{
				this.currentSettings = styleSettingsPlatform.settings;
				break;
			}
		}
		this.LoadStyle(true, false);
		if (Platform.Current.AreAchievementsFetched)
		{
			this.UnlockFromAchievements();
			return;
		}
		Platform.AchievementsFetched += this.UnlockFromAchievements;
		this.subscribed = true;
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x0007E6D0 File Offset: 0x0007C8D0
	public void LoadStyle(bool force, bool fade)
	{
		bool flag = false;
		if (Platform.Current.SharedData.HasKey("lastVersion") && Platform.Current.SharedData.GetString("lastVersion", "0.0.0.0") == this.currentSettings.autoChangeVersion)
		{
			int @int = Platform.Current.EncryptedSharedData.GetInt("menuStyle", this.currentSettings.styleIndex);
			if (this.currentSettings.styleIndex != @int)
			{
				this.currentSettings.styleIndex = @int;
				flag = true;
			}
		}
		string key = "unlockedMenuStyle";
		if (Platform.Current.SharedData.HasKey(key))
		{
			string @string = Platform.Current.SharedData.GetString(key, "");
			Platform.Current.SharedData.DeleteKey(key);
			int i = 0;
			while (i < this.styles.Length)
			{
				if (this.styles[i].unlockKey == @string && this.styles[i].IsAvailable)
				{
					int num = i;
					if (this.currentSettings.styleIndex != num)
					{
						this.currentSettings.styleIndex = num;
						flag = true;
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}
		if (flag || force)
		{
			this.SetStyle(this.currentSettings.styleIndex, fade, true);
		}
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x0007E816 File Offset: 0x0007CA16
	private void OnDestroy()
	{
		if (this.subscribed)
		{
			Platform.AchievementsFetched -= this.UnlockFromAchievements;
		}
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x0007E834 File Offset: 0x0007CA34
	public void SetStyle(int index, bool fade, bool save = true)
	{
		if (index < 0 || index >= this.styles.Length)
		{
			Debug.LogError("Menu Style \"" + index.ToString() + "\" is out of bounds.");
			return;
		}
		if (this.fadeRoutine != null)
		{
			base.StopCoroutine(this.fadeRoutine);
		}
		this.fadeRoutine = base.StartCoroutine(this.SwitchStyle(index, fade, this.currentSettings.styleIndex));
		this.currentSettings.styleIndex = index;
		if (save)
		{
			Platform.Current.SharedData.SetString("lastVersion", this.currentSettings.autoChangeVersion);
			Platform.Current.EncryptedSharedData.SetInt("menuStyle", this.currentSettings.styleIndex);
			Platform.Current.SharedData.Save();
			Platform.Current.EncryptedSharedData.Save();
		}
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x0007E90A File Offset: 0x0007CB0A
	private IEnumerator SwitchStyle(int index, bool fade, int oldIndex)
	{
		yield return null;
		if (this.styles[index].musicSnapshot)
		{
			GameManager.instance.AudioManager.ApplyMusicSnapshot(this.styles[index].musicSnapshot, 0f, fade ? (this.fadeTime * 2f) : 0f);
		}
		AudioSource[] componentsInChildren = this.styles[oldIndex].styleObject.GetComponentsInChildren<AudioSource>();
		this.styles[oldIndex].SetInitialAudioVolumes(componentsInChildren);
		yield return this.StartCoroutine(this.Fade(oldIndex, MenuStyles.FadeType.Down, fade, componentsInChildren));
		this.UpdateTitle();
		for (int i = 0; i < this.styles.Length; i++)
		{
			this.styles[i].styleObject.SetActive(index == i);
		}
		GameCameras instance = GameCameras.instance;
		if (instance && instance.colorCorrectionCurves)
		{
			MenuStyles.MenuStyle.CameraCurves cameraColorCorrection = this.styles[index].cameraColorCorrection;
			instance.colorCorrectionCurves.saturation = cameraColorCorrection.saturation;
			instance.colorCorrectionCurves.redChannel = cameraColorCorrection.redChannel;
			instance.colorCorrectionCurves.greenChannel = cameraColorCorrection.greenChannel;
			instance.colorCorrectionCurves.blueChannel = cameraColorCorrection.blueChannel;
		}
		componentsInChildren = this.styles[index].styleObject.GetComponentsInChildren<AudioSource>();
		this.styles[index].SetInitialAudioVolumes(componentsInChildren);
		yield return this.StartCoroutine(this.Fade(index, MenuStyles.FadeType.Up, fade, componentsInChildren));
		this.fadeRoutine = null;
		yield break;
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x0007E92E File Offset: 0x0007CB2E
	private IEnumerator Fade(int styleIndex, MenuStyles.FadeType fadeType, bool fade, AudioSource[] audioSources)
	{
		float toAlpha = (float)((fadeType == MenuStyles.FadeType.Down) ? 1 : 0);
		if (this.blackSolid)
		{
			Color color = this.blackSolid.color;
			float startAlpha = color.a;
			if (fade)
			{
				for (float elapsed = 0f; elapsed < this.fadeTime; elapsed += Time.deltaTime)
				{
					float t = elapsed / this.fadeTime;
					color.a = Mathf.Lerp(startAlpha, toAlpha, t);
					this.blackSolid.color = color;
					for (int i = 0; i < audioSources.Length; i++)
					{
						float num = this.styles[styleIndex].initialAudioVolumes[i];
						if (fadeType == MenuStyles.FadeType.Down)
						{
							audioSources[i].volume = Mathf.Lerp(num, 0f, t);
						}
						else
						{
							audioSources[i].volume = Mathf.Lerp(0f, num, t);
						}
					}
					yield return null;
				}
				for (int j = 0; j < audioSources.Length; j++)
				{
					float volume = this.styles[styleIndex].initialAudioVolumes[j];
					if (fadeType == MenuStyles.FadeType.Down)
					{
						audioSources[j].volume = 0f;
					}
					else
					{
						audioSources[j].volume = volume;
					}
				}
			}
			color.a = toAlpha;
			this.blackSolid.color = color;
			color = default(Color);
		}
		yield break;
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0007E95C File Offset: 0x0007CB5C
	public void StopAudio()
	{
		AudioSource[] componentsInChildren = this.styles[this.currentSettings.styleIndex].styleObject.GetComponentsInChildren<AudioSource>();
		base.StartCoroutine(this.FadeOutAudio(componentsInChildren));
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x0007E994 File Offset: 0x0007CB94
	private IEnumerator FadeOutAudio(AudioSource[] audioSources)
	{
		for (float elapsed = 0f; elapsed <= this.fadeTime; elapsed += Time.deltaTime)
		{
			for (int i = 0; i < audioSources.Length; i++)
			{
				audioSources[i].volume = Mathf.Lerp(0f, 1f, elapsed / this.fadeTime);
			}
			yield return null;
		}
		for (int i = 0; i < audioSources.Length; i++)
		{
			audioSources[i].volume = 0f;
		}
		yield break;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x0007E9AC File Offset: 0x0007CBAC
	public void UnlockFromAchievements()
	{
		foreach (MenuStyles.MenuStyle menuStyle in this.styles)
		{
			if (!menuStyle.IsAvailable && menuStyle.achievementKeys.Length != 0)
			{
				foreach (string text in menuStyle.achievementKeys)
				{
					if (Platform.Current.IsAchievementUnlocked(text).GetValueOrDefault())
					{
						menuStyle.enabled = true;
						Platform.Current.EncryptedSharedData.SetInt(menuStyle.unlockKey, 1);
						Debug.Log("Unlocked menu style: " + menuStyle.displayName + " with achievement: " + text);
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001A61 RID: 6753 RVA: 0x0007EA5D File Offset: 0x0007CC5D
	public void UpdateTitle()
	{
		if (this.title)
		{
			this.title.SetTitle(this.styles[this.CurrentStyle].titleIndex);
		}
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x0007EA89 File Offset: 0x0007CC89
	public MenuStyles()
	{
		this.fadeTime = 0.25f;
		base..ctor();
	}

	// Token: 0x04001FAC RID: 8108
	public static MenuStyles Instance;

	// Token: 0x04001FAD RID: 8109
	public MenuStyles.MenuStyle[] styles;

	// Token: 0x04001FAE RID: 8110
	[Space]
	public MenuStyles.StyleSettings StyleDefault;

	// Token: 0x04001FAF RID: 8111
	public MenuStyles.StyleSettingsPlatform[] StylePlatforms;

	// Token: 0x04001FB0 RID: 8112
	private MenuStyles.StyleSettings currentSettings;

	// Token: 0x04001FB1 RID: 8113
	[Space]
	public SpriteRenderer blackSolid;

	// Token: 0x04001FB2 RID: 8114
	public float fadeTime;

	// Token: 0x04001FB3 RID: 8115
	private Coroutine fadeRoutine;

	// Token: 0x04001FB4 RID: 8116
	public MenuStyleTitle title;

	// Token: 0x04001FB5 RID: 8117
	private bool subscribed;

	// Token: 0x0200049E RID: 1182
	[Serializable]
	public class MenuStyle
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0007EA9C File Offset: 0x0007CC9C
		public bool IsAvailable
		{
			get
			{
				if (this.unlockKey == "" || (GameManager.instance && GameManager.instance.gameConfig.unlockAllMenuStyles))
				{
					return this.enabled;
				}
				return this.enabled && Platform.Current.EncryptedSharedData.GetInt(this.unlockKey, 0) == 1;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0007EB04 File Offset: 0x0007CD04
		public void SetInitialAudioVolumes(AudioSource[] sources)
		{
			if (this.initialAudioVolumes != null && this.initialAudioVolumes.Length != 0)
			{
				return;
			}
			this.initialAudioVolumes = new float[sources.Length];
			for (int i = 0; i < this.initialAudioVolumes.Length; i++)
			{
				this.initialAudioVolumes[i] = sources[i].volume;
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0007EB54 File Offset: 0x0007CD54
		public MenuStyle()
		{
			this.enabled = true;
			this.displayName = "Untitled Style";
			this.titleIndex = -1;
			this.unlockKey = "";
			base..ctor();
		}

		// Token: 0x04001FB6 RID: 8118
		public bool enabled;

		// Token: 0x04001FB7 RID: 8119
		public string displayName;

		// Token: 0x04001FB8 RID: 8120
		public GameObject styleObject;

		// Token: 0x04001FB9 RID: 8121
		public MenuStyles.MenuStyle.CameraCurves cameraColorCorrection;

		// Token: 0x04001FBA RID: 8122
		[FormerlySerializedAs("snapshot")]
		public AudioMixerSnapshot musicSnapshot;

		// Token: 0x04001FBB RID: 8123
		public int titleIndex;

		// Token: 0x04001FBC RID: 8124
		public string unlockKey;

		// Token: 0x04001FBD RID: 8125
		public string[] achievementKeys;

		// Token: 0x04001FBE RID: 8126
		[HideInInspector]
		public float[] initialAudioVolumes;

		// Token: 0x0200049F RID: 1183
		[Serializable]
		public class CameraCurves
		{
			// Token: 0x06001A66 RID: 6758 RVA: 0x0007EB80 File Offset: 0x0007CD80
			public CameraCurves()
			{
				this.saturation = 1f;
				this.redChannel = new AnimationCurve(new Keyframe[]
				{
					new Keyframe(0f, 0f),
					new Keyframe(1f, 1f)
				});
				this.greenChannel = new AnimationCurve(new Keyframe[]
				{
					new Keyframe(0f, 0f),
					new Keyframe(1f, 1f)
				});
				this.blueChannel = new AnimationCurve(new Keyframe[]
				{
					new Keyframe(0f, 0f),
					new Keyframe(1f, 1f)
				});
				base..ctor();
			}

			// Token: 0x04001FBF RID: 8127
			[Range(0f, 5f)]
			public float saturation;

			// Token: 0x04001FC0 RID: 8128
			public AnimationCurve redChannel;

			// Token: 0x04001FC1 RID: 8129
			public AnimationCurve greenChannel;

			// Token: 0x04001FC2 RID: 8130
			public AnimationCurve blueChannel;
		}
	}

	// Token: 0x020004A0 RID: 1184
	[Serializable]
	public struct StyleSettings
	{
		// Token: 0x04001FC3 RID: 8131
		public int styleIndex;

		// Token: 0x04001FC4 RID: 8132
		public string autoChangeVersion;
	}

	// Token: 0x020004A1 RID: 1185
	[Serializable]
	public struct StyleSettingsPlatform
	{
		// Token: 0x04001FC5 RID: 8133
		public RuntimePlatform platform;

		// Token: 0x04001FC6 RID: 8134
		public MenuStyles.StyleSettings settings;
	}

	// Token: 0x020004A2 RID: 1186
	private enum FadeType
	{
		// Token: 0x04001FC8 RID: 8136
		Up,
		// Token: 0x04001FC9 RID: 8137
		Down
	}
}
