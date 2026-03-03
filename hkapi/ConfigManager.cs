using System;
using System.IO;
using Language;
using UnityEngine;

// Token: 0x020002D3 RID: 723
public static class ConfigManager
{
	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0004A52B File Offset: 0x0004872B
	// (set) Token: 0x06000F24 RID: 3876 RVA: 0x0004A532 File Offset: 0x00048732
	public static float CameraShakeMultiplier { get; private set; }

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0004A53A File Offset: 0x0004873A
	// (set) Token: 0x06000F26 RID: 3878 RVA: 0x0004A541 File Offset: 0x00048741
	public static float ControllerRumbleMultiplier { get; private set; }

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0004A549 File Offset: 0x00048749
	private static bool IsConfigFileSupported
	{
		get
		{
			return Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.LinuxPlayer;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0004A566 File Offset: 0x00048766
	// (set) Token: 0x06000F29 RID: 3881 RVA: 0x0004A56D File Offset: 0x0004876D
	public static bool IsSavingConfig { get; private set; }

	// Token: 0x06000F2A RID: 3882 RVA: 0x0004A578 File Offset: 0x00048778
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		ConfigManager._isInit = true;
		ConfigManager.CameraShakeMultiplier = 1f;
		ConfigManager.ControllerRumbleMultiplier = 1f;
		if (!ConfigManager.IsConfigFileSupported)
		{
			return;
		}
		ConfigManager._path = Path.Combine(Application.dataPath, "Config.ini");
		try
		{
			string contents = File.Exists(ConfigManager._path) ? File.ReadAllText(ConfigManager._path) : string.Empty;
			File.WriteAllText(ConfigManager._path, contents);
		}
		catch
		{
			ConfigManager._path = Path.Combine(Application.persistentDataPath, "AppConfig.ini");
		}
		if (Platform.Current)
		{
			ConfigManager.LoadConfig();
			return;
		}
		Platform.PlatformBecameCurrent += ConfigManager.LoadConfig;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0004A630 File Offset: 0x00048830
	private static void LoadConfig()
	{
		if (!ConfigManager.IsConfigFileSupported)
		{
			return;
		}
		if (!ConfigManager._isInit)
		{
			return;
		}
		if (File.Exists(ConfigManager._path))
		{
			INIParser iniparser = new INIParser();
			iniparser.Open(ConfigManager._path);
			string text = iniparser.ReadValue("Localization", "Language", Language.CurrentLanguage().ToString()).ToUpper();
			if (ConfigManager.IsLanguageValid(text))
			{
				PlayerPrefs.SetInt("GameLangSet", 1);
				Language.SwitchLanguage(text);
			}
			else
			{
				ConfigManager.SetDefaultLanguageSetting();
			}
			string text2 = iniparser.ReadValue("VideoSettings", "FrameRateCap", 400.ToString());
			int val;
			if (int.TryParse(text2, out val))
			{
				Platform.Current.SharedData.SetInt("VidTFR", val);
			}
			else
			{
				Debug.LogError(string.Concat(new string[]
				{
					"Framerate cap (",
					text2,
					") defined in \"",
					ConfigManager._path,
					"\" is not valid!"
				}));
			}
			ConfigManager.CameraShakeMultiplier = (float)iniparser.ReadValue("Accessibility", "CameraShakeMultiplier", 1.0);
			ConfigManager.ControllerRumbleMultiplier = (float)iniparser.ReadValue("Accessibility", "ControllerRumbleMultiplier", 1.0);
			iniparser.Close();
		}
		else
		{
			ConfigManager.SetDefaultLanguageSetting();
		}
		ConfigManager.SaveConfig();
		LogoLanguage logoLanguage = UnityEngine.Object.FindObjectOfType<LogoLanguage>();
		if (logoLanguage)
		{
			logoLanguage.SetSprite();
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0004A791 File Offset: 0x00048991
	private static void SetDefaultLanguageSetting()
	{
		PlayerPrefs.SetInt("GameLangSet", 0);
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0004A7A0 File Offset: 0x000489A0
	public static void SaveConfig()
	{
		if (!ConfigManager.IsConfigFileSupported)
		{
			return;
		}
		if (!ConfigManager._isInit)
		{
			return;
		}
		ConfigManager.IsSavingConfig = true;
		string text = Language.CurrentLanguage().ToString();
		INIParser iniparser = new INIParser();
		iniparser.Open(ConfigManager._path);
		iniparser.WriteValue("Localization", "Language", text);
		iniparser.WriteValue("VideoSettings", "FrameRateCap", Platform.Current.SharedData.GetInt("VidTFR", 400));
		iniparser.WriteValue("Accessibility", "CameraShakeMultiplier", (double)ConfigManager.CameraShakeMultiplier);
		iniparser.WriteValue("Accessibility", "ControllerRumbleMultiplier", (double)ConfigManager.ControllerRumbleMultiplier);
		iniparser.Close();
		string str = File.ReadAllText(ConfigManager._path);
		string text2 = "Available Languages:\n";
		foreach (string text3 in Language.GetLanguages())
		{
			Language.SwitchLanguage(text3);
			text2 = string.Concat(new string[]
			{
				text2,
				" - ",
				text3,
				" (",
				Language.Get("LANG_" + text3, "MainMenu"),
				")\n"
			});
		}
		Language.SwitchLanguage(text);
		ConfigManager.IsSavingConfig = false;
		text2 += "\n";
		string contents = text2 + str;
		File.WriteAllText(ConfigManager._path, contents);
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0004A900 File Offset: 0x00048B00
	private static bool IsLanguageValid(string languageCode)
	{
		string[] languages = Language.GetLanguages();
		for (int i = 0; i < languages.Length; i++)
		{
			if (languages[i] == languageCode)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000FDE RID: 4062
	private static bool _isInit;

	// Token: 0x04000FDF RID: 4063
	private static string _path;
}
