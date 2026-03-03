using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Token: 0x02000207 RID: 519
public static class SaveDataUpgradeHandler
{
	// Token: 0x06000B47 RID: 2887 RVA: 0x0003BCBB File Offset: 0x00039EBB
	private static string CleanupVersionText(string versionText)
	{
		return Regex.Replace(versionText, "[A-Za-z ]", "");
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0003BCCD File Offset: 0x00039ECD
	private static void ClearDreamGate(SaveDataUpgradeHandler.SceneSplit sceneSplit, ref string dreamGateScene)
	{
		if (sceneSplit.SceneName == dreamGateScene)
		{
			dreamGateScene = "";
		}
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0003BCE8 File Offset: 0x00039EE8
	private static void UpdateMap(SaveDataUpgradeHandler.SceneSplit sceneSplit, ref List<string> scenesMapped)
	{
		if (scenesMapped.Contains(sceneSplit.SceneName))
		{
			foreach (string item in sceneSplit.NewSceneNames)
			{
				if (!scenesMapped.Contains(item))
				{
					scenesMapped.Add(item);
				}
			}
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003BD30 File Offset: 0x00039F30
	public static void UpgradeSaveData(ref PlayerData playerData)
	{
		if (playerData.GetString("dreamGateScene") == "Hive_05")
		{
			playerData.SetStringSwappedArgs("", "dreamGateScene");
		}
		foreach (SaveDataUpgradeHandler.SceneSplit sceneSplit in SaveDataUpgradeHandler.splitScenes)
		{
			if (sceneSplit.ShouldHandleSplit(playerData.GetString("version")))
			{
				SaveDataUpgradeHandler.ClearDreamGate(sceneSplit, ref playerData.dreamGateScene);
				SaveDataUpgradeHandler.UpdateMap(sceneSplit, ref playerData.scenesMapped);
			}
		}
		PersistentBoolData persistentBoolData = new PersistentBoolData
		{
			id = "Mawlek Body",
			sceneName = "Crossroads_09"
		};
		PersistentBoolData persistentBoolData2 = new PersistentBoolData
		{
			id = "Battle Scene",
			sceneName = "Crossroads_09"
		};
		PersistentBoolData persistentBoolData3 = SceneData.instance.FindMyState(persistentBoolData);
		if (persistentBoolData3 != null && persistentBoolData3.activated)
		{
			persistentBoolData2.activated = true;
			SceneData.instance.SaveMyState(persistentBoolData2);
		}
		if (playerData.GetBool("gotShadeCharm"))
		{
			playerData.SetIntSwappedArgs(4, "royalCharmState");
		}
		if (playerData.GetBool("colosseumGoldCompleted") && !playerData.GetVariable<List<string>>("unlockedBossScenes").Contains("God Tamer Boss Scene"))
		{
			playerData.GetVariable<List<string>>("unlockedBossScenes").Add("God Tamer Boss Scene");
		}
		bool flag = false;
		for (int j = playerData.GetVariable<List<string>>("unlockedBossScenes").Count - 1; j >= 0; j--)
		{
			if (!(playerData.GetVariable<List<string>>("unlockedBossScenes")[j] != "God Tamer Boss Scene"))
			{
				if (flag)
				{
					playerData.GetVariable<List<string>>("unlockedBossScenes").RemoveAt(j);
				}
				else
				{
					flag = true;
				}
			}
		}
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0003BECC File Offset: 0x0003A0CC
	public static void UpgradeSystemData<T>(T system)
	{
		Type typeFromHandle = typeof(T);
		if (SaveDataUpgradeHandler.systemDataUpgrades.ContainsKey(typeFromHandle))
		{
			string key = string.Format("lastSystemVersion_{0}", typeFromHandle.ToString());
			Version v = new Version(Platform.Current.SharedData.GetString(key, "0.0.0.0"));
			SaveDataUpgradeHandler.SystemDataUpgrade systemDataUpgrade = SaveDataUpgradeHandler.systemDataUpgrades[typeFromHandle];
			if (v < systemDataUpgrade.TargetVersion)
			{
				systemDataUpgrade.UpgradeAction(system);
				Platform.Current.SharedData.SetString(key, "1.5.78.11833");
			}
		}
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0003BF5C File Offset: 0x0003A15C
	// Note: this type is marked as 'beforefieldinit'.
	static SaveDataUpgradeHandler()
	{
		SaveDataUpgradeHandler.splitScenes = new SaveDataUpgradeHandler.SceneSplit[]
		{
			new SaveDataUpgradeHandler.SceneSplit("Deepnest_26", "1.3.0.0", new string[]
			{
				"Deepnest_26b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Deepnest_East_14", "1.3.0.0", new string[]
			{
				"Deepnest_East_14b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Ruins1_31", "1.3.0.1", new string[]
			{
				"Ruins1_31b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Hive_03", "1.3.0.2", new string[]
			{
				"Hive_03_c"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Ruins2_01", "1.3.0.2", new string[]
			{
				"Ruins2_01_b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Ruins2_11", "1.3.0.2", new string[]
			{
				"Ruins2_11_b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Ruins2_03", "1.3.0.3", new string[]
			{
				"Ruins2_03b"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Ruins1_05", "1.3.0.3", new string[]
			{
				"Ruins1_05c"
			}),
			new SaveDataUpgradeHandler.SceneSplit("Hive_01", "1.3.0.4", new string[]
			{
				"Hive_01_b"
			})
		};
		SaveDataUpgradeHandler.systemDataUpgrades = new Dictionary<Type, SaveDataUpgradeHandler.SystemDataUpgrade>
		{
			{
				typeof(InputHandler),
				new SaveDataUpgradeHandler.SystemDataUpgrade
				{
					TargetVersion = new Version("1.4.0.0"),
					UpgradeAction = delegate(object obj)
					{
						InputHandler inputHandler = (InputHandler)obj;
						inputHandler.ResetDefaultKeyBindings();
						inputHandler.ResetDefaultControllerButtonBindings();
						inputHandler.ResetAllControllerButtonBindings();
					}
				}
			}
		};
	}

	// Token: 0x04000C49 RID: 3145
	private static readonly SaveDataUpgradeHandler.SceneSplit[] splitScenes;

	// Token: 0x04000C4A RID: 3146
	private static readonly Dictionary<Type, SaveDataUpgradeHandler.SystemDataUpgrade> systemDataUpgrades;

	// Token: 0x02000208 RID: 520
	private class SceneSplit
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x0003C0E0 File Offset: 0x0003A2E0
		public SceneSplit(string sceneName, string version, params string[] newSceneNames)
		{
			this.SceneName = sceneName;
			this.Version = version;
			this.NewSceneNames = newSceneNames;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0003C100 File Offset: 0x0003A300
		public bool ShouldHandleSplit(string otherVersion)
		{
			otherVersion = SaveDataUpgradeHandler.CleanupVersionText(otherVersion);
			Version version = new Version(this.Version);
			Version value = new Version(otherVersion);
			return version.CompareTo(value) > 0;
		}

		// Token: 0x04000C4B RID: 3147
		public string SceneName;

		// Token: 0x04000C4C RID: 3148
		public string Version;

		// Token: 0x04000C4D RID: 3149
		public string[] NewSceneNames;
	}

	// Token: 0x02000209 RID: 521
	private struct SystemDataUpgrade
	{
		// Token: 0x04000C4E RID: 3150
		public Version TargetVersion;

		// Token: 0x04000C4F RID: 3151
		public Action<object> UpgradeAction;
	}
}
