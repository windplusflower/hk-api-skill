using System;
using GlobalEnums;
using InControl;
using UnityEngine;

// Token: 0x020001FB RID: 507
[Serializable]
public class GameSettings
{
	// Token: 0x06000AF0 RID: 2800 RVA: 0x0003A15D File Offset: 0x0003835D
	public GameSettings()
	{
		this.settingLog = "Loaded Setting: {0} ({1})";
		base..ctor();
		this.verboseMode = false;
		this.ResetGameOptionsSettings();
		this.ResetAudioSettings();
		this.ResetVideoSettings();
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0003A18C File Offset: 0x0003838C
	public void LoadGameOptionsSettings()
	{
		this.LoadEnum<SupportedLanguages>("GameLang", ref this.gameLanguage, SupportedLanguages.EN);
		this.LoadInt("GameBackers", ref this.backerCredits, 0);
		this.LoadInt("GameNativePopups", ref this.showNativeAchievementPopups, 0);
		this.LoadBool("NativeInput", ref this.isNativeInput, true);
		this.vibrationMuted = Platform.Current.SharedData.GetBool("RumbleMuted", false);
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0003A204 File Offset: 0x00038404
	public void SaveGameOptionsSettings()
	{
		Platform.Current.SharedData.SetInt("GameLang", (int)this.gameLanguage);
		Platform.Current.SharedData.SetInt("GameBackers", this.backerCredits);
		Platform.Current.SharedData.SetInt("GameNativePopups", this.showNativeAchievementPopups);
		Platform.Current.SharedData.SetInt("NativeInput", this.isNativeInput ? 1 : 0);
		Platform.Current.SharedData.SetBool("RumbleMuted", this.vibrationMuted);
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0003A2A8 File Offset: 0x000384A8
	public void ResetGameOptionsSettings()
	{
		this.gameLanguage = SupportedLanguages.EN;
		this.backerCredits = 0;
		this.showNativeAchievementPopups = 0;
		this.isNativeInput = true;
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0003A2C8 File Offset: 0x000384C8
	public void LoadVideoSettings()
	{
		if (this.CommandArgumentUsed("-resetres"))
		{
			Screen.SetResolution(1920, 1080, true);
		}
		this.LoadInt("VidFullscreen", ref this.fullScreen, 2);
		this.LoadInt("VidVSync", ref this.vSync, 0);
		this.LoadInt("VidDisplay", ref this.useDisplay, 0);
		this.LoadInt("VidTFR", ref this.targetFrameRate, 400);
		this.LoadBool("VidFC", ref this.frameCapOn, true);
		this.LoadInt("VidParticles", ref this.particleEffectsLevel, 1);
		this.LoadEnum<ShaderQualities>("ShaderQuality", ref this.shaderQuality, this.HasSetting("VidFullscreen") ? ShaderQualities.High : ShaderQualities.Medium);
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0003A38C File Offset: 0x0003858C
	public void SaveVideoSettings()
	{
		Platform.Current.SharedData.SetInt("VidFullscreen", this.fullScreen);
		Platform.Current.SharedData.SetInt("VidVSync", this.vSync);
		Platform.Current.SharedData.SetInt("VidDisplay", this.useDisplay);
		Platform.Current.SharedData.SetInt("VidTFR", this.targetFrameRate);
		Platform.Current.SharedData.SetBool("VidFC", this.frameCapOn);
		Platform.Current.SharedData.SetInt("VidParticles", this.particleEffectsLevel);
		Platform.Current.SharedData.SetInt("ShaderQuality", (int)this.shaderQuality);
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0003A460 File Offset: 0x00038660
	public void ResetVideoSettings()
	{
		this.fullScreen = 2;
		this.vSync = 0;
		this.useDisplay = 0;
		this.targetFrameRate = 400;
		this.frameCapOn = true;
		this.particleEffectsLevel = 1;
		this.overscanAdjusted = 0;
		this.overScanAdjustment = 0f;
		this.brightnessAdjusted = 0;
		this.brightnessAdjustment = 20f;
		this.shaderQuality = ShaderQualities.Medium;
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0003A4C6 File Offset: 0x000386C6
	public void LoadOverscanSettings()
	{
		this.LoadFloat("VidOSValue", ref this.overScanAdjustment, 0f);
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x0003A4E0 File Offset: 0x000386E0
	public void SaveOverscanSettings()
	{
		Platform.Current.SharedData.SetFloat("VidOSValue", this.overScanAdjustment);
		this.overscanAdjusted = 1;
		Platform.Current.SharedData.SetInt("VidOSSet", this.overscanAdjusted);
		if (this.verboseMode)
		{
			this.LogSavedKey("VidOSValue", this.overScanAdjustment);
		}
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0003A550 File Offset: 0x00038750
	public void ResetOverscanSettings()
	{
		this.overScanAdjustment = 0f;
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0003A55D File Offset: 0x0003875D
	public void LoadOverscanConfigured()
	{
		this.LoadInt("VidOSSet", ref this.overscanAdjusted, 0);
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0003A572 File Offset: 0x00038772
	public void LoadBrightnessSettings()
	{
		this.LoadFloat("VidBrightValue", ref this.brightnessAdjustment, 20f);
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0003A58C File Offset: 0x0003878C
	public void SaveBrightnessSettings()
	{
		Platform.Current.SharedData.SetFloat("VidBrightValue", this.brightnessAdjustment);
		this.brightnessAdjusted = 1;
		Platform.Current.SharedData.SetInt("VidBrightSet", this.brightnessAdjusted);
		if (this.verboseMode)
		{
			this.LogSavedKey("VidBrightValue", this.brightnessAdjustment);
		}
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0003A5FC File Offset: 0x000387FC
	public void ResetBrightnessSettings()
	{
		this.brightnessAdjustment = 20f;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0003A609 File Offset: 0x00038809
	public void LoadBrightnessConfigured()
	{
		this.brightnessAdjusted = Platform.Current.SharedData.GetInt("VidBrightSet", 0);
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0003A628 File Offset: 0x00038828
	public void LoadAudioSettings()
	{
		this.LoadFloat("MasterVolume", ref this.masterVolume, 10f);
		this.LoadFloat("MusicVolume", ref this.musicVolume, 10f);
		this.LoadFloat("SoundVolume", ref this.soundVolume, 10f);
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0003A67C File Offset: 0x0003887C
	public void SaveAudioSettings()
	{
		Platform.Current.SharedData.SetFloat("MasterVolume", this.masterVolume);
		Platform.Current.SharedData.SetFloat("MusicVolume", this.musicVolume);
		Platform.Current.SharedData.SetFloat("SoundVolume", this.soundVolume);
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0003A6E6 File Offset: 0x000388E6
	public void ResetAudioSettings()
	{
		this.masterVolume = 10f;
		this.musicVolume = 10f;
		this.soundVolume = 10f;
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0003A70C File Offset: 0x0003890C
	public void LoadKeyboardSettings()
	{
		this.LoadAndUpgradeKeyboardKey("KeyJump", ref this.jumpKey, Key.Z);
		this.LoadAndUpgradeKeyboardKey("KeyAttack", ref this.attackKey, Key.X);
		this.LoadAndUpgradeKeyboardKey("KeyDash", ref this.dashKey, Key.C);
		this.LoadAndUpgradeKeyboardKey("KeyCast", ref this.castKey, Key.A);
		this.LoadAndUpgradeKeyboardKey("KeySupDash", ref this.superDashKey, Key.S);
		this.LoadAndUpgradeKeyboardKey("KeyDreamnail", ref this.dreamNailKey, Key.D);
		this.LoadAndUpgradeKeyboardKey("KeyQuickMap", ref this.quickMapKey, Key.Tab);
		this.LoadAndUpgradeKeyboardKey("KeyQuickCast", ref this.quickCastKey, Key.F);
		this.LoadAndUpgradeKeyboardKey("KeyInventory", ref this.inventoryKey, Key.I);
		this.LoadAndUpgradeKeyboardKey("KeyUp", ref this.upKey, Key.UpArrow);
		this.LoadAndUpgradeKeyboardKey("KeyDown", ref this.downKey, Key.DownArrow);
		this.LoadAndUpgradeKeyboardKey("KeyLeft", ref this.leftKey, Key.LeftArrow);
		this.LoadAndUpgradeKeyboardKey("KeyRight", ref this.rightKey, Key.RightArrow);
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0003A810 File Offset: 0x00038A10
	private void LoadAndUpgradeKeyboardKey(string prefsKey, ref string setString, Key defaultKey)
	{
		string text = defaultKey.ToString();
		if (this.LoadString(prefsKey + "_V2", ref setString, text))
		{
			return;
		}
		Key key = Key.None;
		if (!this.LoadEnum<Key>(prefsKey, ref key, defaultKey))
		{
			setString = text;
			return;
		}
		switch (key)
		{
		case Key.F5:
			setString = "LeftButton";
			return;
		case Key.F6:
			setString = "RightButton";
			return;
		case Key.F7:
			setString = "MiddleButton";
			return;
		default:
			setString = key.ToString();
			return;
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0003A894 File Offset: 0x00038A94
	public void SaveKeyboardSettings()
	{
		Platform.Current.SharedData.SetString("KeyJump_V2", this.jumpKey);
		Platform.Current.SharedData.SetString("KeyAttack_V2", this.attackKey);
		Platform.Current.SharedData.SetString("KeyDash_V2", this.dashKey);
		Platform.Current.SharedData.SetString("KeyCast_V2", this.castKey);
		Platform.Current.SharedData.SetString("KeySupDash_V2", this.superDashKey);
		Platform.Current.SharedData.SetString("KeyDreamnail_V2", this.dreamNailKey);
		Platform.Current.SharedData.SetString("KeyQuickMap_V2", this.quickMapKey);
		Platform.Current.SharedData.SetString("KeyQuickCast_V2", this.quickCastKey);
		Platform.Current.SharedData.SetString("KeyInventory_V2", this.inventoryKey);
		Platform.Current.SharedData.SetString("KeyUp_V2", this.upKey);
		Platform.Current.SharedData.SetString("KeyDown_V2", this.downKey);
		Platform.Current.SharedData.SetString("KeyLeft_V2", this.leftKey);
		Platform.Current.SharedData.SetString("KeyRight_V2", this.rightKey);
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0003A9F4 File Offset: 0x00038BF4
	public bool LoadGamepadSettings(GamepadType gamepadType)
	{
		gamepadType = this.RemapGamepadTypeForSettings(gamepadType);
		if (gamepadType != GamepadType.NONE)
		{
			string key = "Controller" + gamepadType.ToString();
			string json = "";
			if (this.LoadString(key, ref json, ""))
			{
				this.controllerMapping = JsonUtility.FromJson<ControllerMapping>(json);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0003AA4C File Offset: 0x00038C4C
	public void SaveGamepadSettings(GamepadType gamepadType)
	{
		gamepadType = this.RemapGamepadTypeForSettings(gamepadType);
		string key = "Controller" + gamepadType.ToString();
		string text = JsonUtility.ToJson(this.controllerMapping);
		Platform.Current.SharedData.SetString(key, text);
		this.LogSavedKey(key, text);
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0003AAB0 File Offset: 0x00038CB0
	public void ResetGamepadSettings(GamepadType gamepadType)
	{
		gamepadType = this.RemapGamepadTypeForSettings(gamepadType);
		this.controllerMapping = new ControllerMapping();
		this.controllerMapping.gamepadType = gamepadType;
		if (this.verboseMode)
		{
			Debug.LogFormat("ResetSettings - {0}", new object[]
			{
				gamepadType
			});
		}
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0003AB00 File Offset: 0x00038D00
	private GamepadType RemapGamepadTypeForSettings(GamepadType sourceType)
	{
		GamepadType gamepadType;
		if (sourceType == GamepadType.SWITCH_PRO_CONTROLLER)
		{
			gamepadType = GamepadType.SWITCH_JOYCON_DUAL;
		}
		else
		{
			gamepadType = sourceType;
		}
		if (gamepadType != sourceType)
		{
			Debug.LogFormat("Remapped GamepadType from {0} to {1}", new object[]
			{
				sourceType.ToString(),
				gamepadType.ToString()
			});
		}
		return gamepadType;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0003AB50 File Offset: 0x00038D50
	private bool LoadInt(string key, ref int val, int def)
	{
		if (Platform.Current.SharedData.HasKey(key))
		{
			val = Platform.Current.SharedData.GetInt(key, def);
			if (this.verboseMode)
			{
				this.LogLoadedKey(key, val);
			}
			return true;
		}
		val = def;
		if (this.verboseMode)
		{
			this.LogMissingKey(key);
		}
		return false;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0003ABA8 File Offset: 0x00038DA8
	private bool HasSetting(string key)
	{
		return Platform.Current.SharedData.HasKey(key);
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0003ABBC File Offset: 0x00038DBC
	private bool LoadEnum<EnumTy>(string key, ref EnumTy val, EnumTy def)
	{
		int num = (int)((object)val);
		bool result = this.LoadInt(key, ref num, (int)((object)def));
		val = (EnumTy)((object)num);
		return result;
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0003AC00 File Offset: 0x00038E00
	private bool LoadBool(string key, ref bool val, bool def)
	{
		int num = val ? 1 : 0;
		bool result = this.LoadInt(key, ref num, def ? 1 : 0);
		val = (num > 0);
		return result;
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0003AC2C File Offset: 0x00038E2C
	private bool LoadFloat(string key, ref float val, float def)
	{
		if (Platform.Current.SharedData.HasKey(key))
		{
			val = Platform.Current.SharedData.GetFloat(key, def);
			if (this.verboseMode)
			{
				this.LogLoadedKey(key, val);
			}
			return true;
		}
		val = def;
		if (this.verboseMode)
		{
			this.LogMissingKey(key);
		}
		return false;
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0003AC84 File Offset: 0x00038E84
	private bool LoadString(string key, ref string val, string def)
	{
		if (Platform.Current.SharedData.HasKey(key))
		{
			val = Platform.Current.SharedData.GetString(key, def);
			if (this.verboseMode)
			{
				this.LogLoadedKey(key, val);
			}
			return true;
		}
		val = def;
		if (this.verboseMode)
		{
			this.LogMissingKey(key);
		}
		return false;
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0003ACDC File Offset: 0x00038EDC
	private void LogMissingKey(string key)
	{
		Debug.LogFormat("LoadSettings - {0} setting not found. Loading defaults.", new object[]
		{
			key
		});
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0003ACF2 File Offset: 0x00038EF2
	private void LogLoadedKey(string key, int value)
	{
		Debug.LogFormat("LoadSettings - {0} Loaded ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0003AD11 File Offset: 0x00038F11
	private void LogLoadedKey(string key, float value)
	{
		Debug.LogFormat("LoadSettings - {0} Loaded ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0003AD30 File Offset: 0x00038F30
	private void LogLoadedKey(string key, string value)
	{
		Debug.LogFormat("LoadSettings - {0} Loaded ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0003AD4A File Offset: 0x00038F4A
	private void LogSavedKey(string key, int value)
	{
		Debug.LogFormat("SaveSettings - {0} Saved ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0003AD69 File Offset: 0x00038F69
	private void LogSavedKey(string key, float value)
	{
		Debug.LogFormat("SaveSettings - {0} Saved ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0003AD88 File Offset: 0x00038F88
	private void LogSavedKey(string key, string value)
	{
		Debug.LogFormat("SaveSettings - {0} Saved ({1})", new object[]
		{
			key,
			value
		});
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x0003ADA4 File Offset: 0x00038FA4
	public bool CommandArgumentUsed(string arg)
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs == null)
		{
			return false;
		}
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Equals(arg))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000BFC RID: 3068
	private bool verboseMode;

	// Token: 0x04000BFD RID: 3069
	private string settingLog;

	// Token: 0x04000BFE RID: 3070
	private string[] commArgs;

	// Token: 0x04000BFF RID: 3071
	[Header("Game Settings")]
	public SupportedLanguages gameLanguage;

	// Token: 0x04000C00 RID: 3072
	public int backerCredits;

	// Token: 0x04000C01 RID: 3073
	public int showNativeAchievementPopups;

	// Token: 0x04000C02 RID: 3074
	public bool isNativeInput;

	// Token: 0x04000C03 RID: 3075
	public bool vibrationMuted;

	// Token: 0x04000C04 RID: 3076
	[Header("Audio Settings")]
	public float masterVolume;

	// Token: 0x04000C05 RID: 3077
	public float musicVolume;

	// Token: 0x04000C06 RID: 3078
	public float soundVolume;

	// Token: 0x04000C07 RID: 3079
	[Header("Video Settings")]
	public int fullScreen;

	// Token: 0x04000C08 RID: 3080
	public int vSync;

	// Token: 0x04000C09 RID: 3081
	public int useDisplay;

	// Token: 0x04000C0A RID: 3082
	public float overScanAdjustment;

	// Token: 0x04000C0B RID: 3083
	public float brightnessAdjustment;

	// Token: 0x04000C0C RID: 3084
	public int overscanAdjusted;

	// Token: 0x04000C0D RID: 3085
	public int brightnessAdjusted;

	// Token: 0x04000C0E RID: 3086
	public int targetFrameRate;

	// Token: 0x04000C0F RID: 3087
	public bool frameCapOn;

	// Token: 0x04000C10 RID: 3088
	public int particleEffectsLevel;

	// Token: 0x04000C11 RID: 3089
	public ShaderQualities shaderQuality;

	// Token: 0x04000C12 RID: 3090
	[Header("Controller Settings")]
	public ControllerMapping controllerMapping;

	// Token: 0x04000C13 RID: 3091
	[Header("Keyboard Settings")]
	public string jumpKey;

	// Token: 0x04000C14 RID: 3092
	public string attackKey;

	// Token: 0x04000C15 RID: 3093
	public string dashKey;

	// Token: 0x04000C16 RID: 3094
	public string castKey;

	// Token: 0x04000C17 RID: 3095
	public string superDashKey;

	// Token: 0x04000C18 RID: 3096
	public string dreamNailKey;

	// Token: 0x04000C19 RID: 3097
	public string quickMapKey;

	// Token: 0x04000C1A RID: 3098
	public string quickCastKey;

	// Token: 0x04000C1B RID: 3099
	public string inventoryKey;

	// Token: 0x04000C1C RID: 3100
	public string upKey;

	// Token: 0x04000C1D RID: 3101
	public string downKey;

	// Token: 0x04000C1E RID: 3102
	public string leftKey;

	// Token: 0x04000C1F RID: 3103
	public string rightKey;
}
