using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000495 RID: 1173
public class MenuSetting : MonoBehaviour
{
	// Token: 0x06001A3C RID: 6716 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
	private void Start()
	{
		this.gm = GameManager.instance;
		this.gs = this.gm.gameSettings;
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0007DED2 File Offset: 0x0007C0D2
	public void RefreshValueFromGameSettings(bool alsoApplySetting = false)
	{
		if (this.settingType != MenuSetting.MenuSettingType.CustomSetting || this.customRefreshSetting == null)
		{
			this.orig_RefreshValueFromGameSettings(alsoApplySetting);
			return;
		}
		MenuSetting.RefreshSetting customRefreshSetting = this.customRefreshSetting;
		if (customRefreshSetting == null)
		{
			return;
		}
		customRefreshSetting(this, alsoApplySetting);
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0007DF00 File Offset: 0x0007C100
	public void UpdateSetting(int settingIndex)
	{
		if (this.settingType != MenuSetting.MenuSettingType.CustomSetting || this.customApplySetting == null)
		{
			this.orig_UpdateSetting(settingIndex);
			return;
		}
		MenuSetting.ApplySetting customApplySetting = this.customApplySetting;
		if (customApplySetting == null)
		{
			return;
		}
		customApplySetting(this, settingIndex);
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0007DF2E File Offset: 0x0007C12E
	// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0007DF36 File Offset: 0x0007C136
	public MenuSetting.ApplySetting customApplySetting { get; set; }

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0007DF3F File Offset: 0x0007C13F
	// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0007DF47 File Offset: 0x0007C147
	public MenuSetting.RefreshSetting customRefreshSetting { get; set; }

	// Token: 0x06001A44 RID: 6724 RVA: 0x0007DF50 File Offset: 0x0007C150
	public void orig_UpdateSetting(int settingIndex)
	{
		if (this.verboseMode)
		{
			Debug.Log(this.settingType.ToString() + " " + settingIndex.ToString());
		}
		if (this.gs == null)
		{
			this.gs = GameManager.instance.gameSettings;
		}
		if (this.settingType == MenuSetting.MenuSettingType.GameBackerCredits)
		{
			if (settingIndex == 0)
			{
				this.gs.backerCredits = 0;
			}
			else
			{
				this.gs.backerCredits = 1;
			}
			this.gm.MatchBackerCreditsSetting();
		}
		else if (this.settingType == MenuSetting.MenuSettingType.NativeAchievements)
		{
			if (settingIndex == 0)
			{
				this.gs.showNativeAchievementPopups = 0;
			}
			else
			{
				this.gs.showNativeAchievementPopups = 1;
			}
		}
		if (this.settingType == MenuSetting.MenuSettingType.FullScreen)
		{
			this.gs.fullScreen = settingIndex;
			if (settingIndex == 0)
			{
				Screen.fullScreenMode = FullScreenMode.Windowed;
				return;
			}
			if (settingIndex != 2)
			{
				Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
				return;
			}
			Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
			return;
		}
		else if (this.settingType == MenuSetting.MenuSettingType.VSync)
		{
			if (settingIndex == 0)
			{
				this.gs.vSync = 0;
				QualitySettings.vSyncCount = 0;
				return;
			}
			this.gs.vSync = 1;
			QualitySettings.vSyncCount = 1;
			Application.targetFrameRate = -1;
			UIManager.instance.DisableFrameCapSetting();
			return;
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ParticleLevel)
		{
			if (settingIndex == 0)
			{
				this.gs.particleEffectsLevel = 0;
				this.gm.RefreshParticleSystems();
				return;
			}
			this.gs.particleEffectsLevel = 1;
			this.gm.RefreshParticleSystems();
			return;
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ShaderQuality)
		{
			if (settingIndex == 0)
			{
				this.gs.shaderQuality = ShaderQualities.Low;
				return;
			}
			if (settingIndex == 1)
			{
				this.gs.shaderQuality = ShaderQualities.Medium;
				return;
			}
			this.gs.shaderQuality = ShaderQualities.High;
			return;
		}
		else
		{
			if (this.settingType == MenuSetting.MenuSettingType.NativeInput)
			{
				GameSettings gameSettings = GameManager.instance.gameSettings;
				gameSettings.isNativeInput = (settingIndex != 0);
				NativeInputModuleManager.IsUsed = gameSettings.isNativeInput;
				return;
			}
			if (this.settingType == MenuSetting.MenuSettingType.ControllerRumble)
			{
				bool flag = settingIndex == 0;
				VibrationManager.IsMuted = flag;
				this.gs.vibrationMuted = flag;
				return;
			}
			if (this.settingType == MenuSetting.MenuSettingType.FrameCap)
			{
				this.gs.frameCapOn = (settingIndex == 1);
				if (settingIndex == 0)
				{
					Application.targetFrameRate = -1;
					return;
				}
				UIManager.instance.DisableVsyncSetting();
				Application.targetFrameRate = Platform.Current.SharedData.GetInt("VidTFR", 400);
			}
			return;
		}
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x0007E184 File Offset: 0x0007C384
	public void orig_RefreshValueFromGameSettings(bool alsoApplySetting = false)
	{
		if (this.gs == null)
		{
			this.gs = GameManager.instance.gameSettings;
		}
		if (this.settingType == MenuSetting.MenuSettingType.FullScreen)
		{
			this.optionList.SetOptionTo(this.gs.fullScreen);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.VSync)
		{
			this.optionList.SetOptionTo(this.gs.vSync);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ParticleLevel)
		{
			this.optionList.SetOptionTo(this.gs.particleEffectsLevel);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ShaderQuality)
		{
			this.optionList.SetOptionTo((int)this.gs.shaderQuality);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.GameBackerCredits)
		{
			this.optionList.SetOptionTo(this.gs.backerCredits);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.NativeAchievements)
		{
			this.optionList.SetOptionTo(this.gs.showNativeAchievementPopups);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ParticleLevel)
		{
			this.optionList.SetOptionTo(this.gs.particleEffectsLevel);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.NativeInput)
		{
			this.optionList.SetOptionTo(this.gs.isNativeInput ? 1 : 0);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.ControllerRumble)
		{
			this.optionList.SetOptionTo(this.gs.vibrationMuted ? 0 : 1);
		}
		else if (this.settingType == MenuSetting.MenuSettingType.FrameCap)
		{
			this.optionList.SetOptionTo(this.gs.frameCapOn ? 1 : 0);
		}
		if (alsoApplySetting)
		{
			this.UpdateSetting(this.optionList.selectedOptionIndex);
		}
	}

	// Token: 0x04001F88 RID: 8072
	public MenuSetting.MenuSettingType settingType;

	// Token: 0x04001F89 RID: 8073
	public MenuOptionHorizontal optionList;

	// Token: 0x04001F8A RID: 8074
	private GameManager gm;

	// Token: 0x04001F8B RID: 8075
	private GameSettings gs;

	// Token: 0x04001F8C RID: 8076
	private bool verboseMode;

	// Token: 0x02000496 RID: 1174
	public enum MenuSettingType
	{
		// Token: 0x04001F90 RID: 8080
		Resolution = 10,
		// Token: 0x04001F91 RID: 8081
		FullScreen,
		// Token: 0x04001F92 RID: 8082
		VSync,
		// Token: 0x04001F93 RID: 8083
		MonitorSelect = 14,
		// Token: 0x04001F94 RID: 8084
		FrameCap,
		// Token: 0x04001F95 RID: 8085
		ParticleLevel,
		// Token: 0x04001F96 RID: 8086
		ShaderQuality,
		// Token: 0x04001F97 RID: 8087
		GameLanguage = 33,
		// Token: 0x04001F98 RID: 8088
		GameBackerCredits,
		// Token: 0x04001F99 RID: 8089
		NativeAchievements,
		// Token: 0x04001F9A RID: 8090
		NativeInput,
		// Token: 0x04001F9B RID: 8091
		ControllerRumble,
		// Token: 0x04001F9C RID: 8092
		CustomSetting
	}

	// Token: 0x02000497 RID: 1175
	// (Invoke) Token: 0x06001A47 RID: 6727
	public delegate void ApplySetting(MenuSetting self, int settingIndex);

	// Token: 0x02000498 RID: 1176
	// (Invoke) Token: 0x06001A4B RID: 6731
	public delegate void RefreshSetting(MenuSetting self, bool alsoApplySetting);
}
