using System;
using UnityEngine;

// Token: 0x02000531 RID: 1329
public class WorldInfo : ScriptableObject
{
	// Token: 0x06001D25 RID: 7461 RVA: 0x000877B2 File Offset: 0x000859B2
	public static bool NameLooksLikeGameplayScene(string sceneName)
	{
		return Array.IndexOf<string>(WorldInfo.NonGameplaySceneName, sceneName) == -1 && !sceneName.EndsWith("_boss_defeated", StringComparison.InvariantCultureIgnoreCase) && !sceneName.EndsWith("_boss", StringComparison.InvariantCultureIgnoreCase) && !sceneName.EndsWith("_preload", StringComparison.InvariantCultureIgnoreCase);
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x000877F4 File Offset: 0x000859F4
	public WorldInfo.SceneInfo GetSceneInfo(string sceneName)
	{
		for (int i = 0; i < this.Scenes.Length; i++)
		{
			WorldInfo.SceneInfo sceneInfo = this.Scenes[i];
			if (sceneInfo.SceneName.Equals(sceneName, StringComparison.InvariantCultureIgnoreCase))
			{
				return sceneInfo;
			}
		}
		return null;
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x00087830 File Offset: 0x00085A30
	// Note: this type is marked as 'beforefieldinit'.
	static WorldInfo()
	{
		WorldInfo.NonGameplaySceneName = new string[]
		{
			"Pre_Menu_Intro",
			"Menu_Title",
			"BetaEnd",
			"Knight_Pickup",
			"Opening_Sequence",
			"Prologue_Excerpt",
			"Intro_Cutscene_Prologue",
			"Intro_Cutscene",
			"Cinematic_Stag_travel",
			"Cinematic_Ending_A",
			"Cinematic_Ending_B",
			"Cinematic_Ending_C",
			"End_Credits",
			"Cinematic_MrMushroom",
			"Menu_Credits",
			"End_Game_Completion",
			"PermaDeath",
			"PermaDeath_Unlock",
			"Cinematic_Ending_D",
			"Cinematic_Ending_E"
		};
	}

	// Token: 0x04002292 RID: 8850
	public WorldInfo.SceneInfo[] Scenes;

	// Token: 0x04002293 RID: 8851
	private static string[] NonGameplaySceneName;

	// Token: 0x02000532 RID: 1330
	[Serializable]
	public class SceneInfo
	{
		// Token: 0x04002294 RID: 8852
		public string SceneName;

		// Token: 0x04002295 RID: 8853
		public WorldInfo.TransitionInfo[] Transitions;

		// Token: 0x04002296 RID: 8854
		public int ZoneTags;
	}

	// Token: 0x02000533 RID: 1331
	[Serializable]
	public struct TransitionInfo
	{
		// Token: 0x04002297 RID: 8855
		public string DoorName;

		// Token: 0x04002298 RID: 8856
		public string DestinationSceneName;

		// Token: 0x04002299 RID: 8857
		public string DestinationDoorName;
	}

	// Token: 0x02000534 RID: 1332
	[Flags]
	public enum ZoneTags
	{
		// Token: 0x0400229B RID: 8859
		None = 0,
		// Token: 0x0400229C RID: 8860
		Room = 1,
		// Token: 0x0400229D RID: 8861
		Crossroads = 2,
		// Token: 0x0400229E RID: 8862
		Ruins = 4,
		// Token: 0x0400229F RID: 8863
		Fungus1 = 8,
		// Token: 0x040022A0 RID: 8864
		Fungus2 = 16,
		// Token: 0x040022A1 RID: 8865
		Fungus3 = 32,
		// Token: 0x040022A2 RID: 8866
		Cliffs = 64,
		// Token: 0x040022A3 RID: 8867
		RestingGrounds = 128,
		// Token: 0x040022A4 RID: 8868
		Mines = 256,
		// Token: 0x040022A5 RID: 8869
		Deepnest = 512,
		// Token: 0x040022A6 RID: 8870
		Deepnest_East = 1024,
		// Token: 0x040022A7 RID: 8871
		Abyss = 2048,
		// Token: 0x040022A8 RID: 8872
		Waterways = 4096,
		// Token: 0x040022A9 RID: 8873
		White_Palace = 8192,
		// Token: 0x040022AA RID: 8874
		Hive = 16384,
		// Token: 0x040022AB RID: 8875
		Grimm = 32768,
		// Token: 0x040022AC RID: 8876
		Dream = 65536,
		// Token: 0x040022AD RID: 8877
		Tutorial = 131072,
		// Token: 0x040022AE RID: 8878
		SpecialA = 262144,
		// Token: 0x040022AF RID: 8879
		SpecialB = 524288
	}
}
