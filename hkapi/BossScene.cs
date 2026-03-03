using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200021F RID: 543
[CreateAssetMenu(fileName = "New Boss Scene", menuName = "Hollow Knight/Boss Scene")]
public class BossScene : ScriptableObject
{
	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003D132 File Offset: 0x0003B332
	public Sprite DisplayIcon
	{
		get
		{
			return this.displayIcon;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003D13A File Offset: 0x0003B33A
	public bool ForceAssetUnload
	{
		get
		{
			return this.forceAssetUnload;
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003D142 File Offset: 0x0003B342
	public string Tier1Scene
	{
		get
		{
			if (!this.tier1Scene)
			{
				return this.sceneName;
			}
			return this.tier1Scene.sceneName;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0003D163 File Offset: 0x0003B363
	public string Tier2Scene
	{
		get
		{
			if (!this.tier2Scene)
			{
				return this.sceneName;
			}
			return this.tier2Scene.sceneName;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0003D184 File Offset: 0x0003B384
	public string Tier3Scene
	{
		get
		{
			if (!this.tier3Scene)
			{
				return this.sceneName;
			}
			return this.tier3Scene.sceneName;
		}
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0003D1A5 File Offset: 0x0003B3A5
	public bool IsUnlocked(BossSceneCheckSource source)
	{
		return (source == BossSceneCheckSource.Sequence && this.baseBoss && this.baseBoss.IsUnlocked(source)) || this.IsUnlockedSelf(source);
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
	public bool IsUnlockedSelf(BossSceneCheckSource source)
	{
		if (GameManager.instance.playerData.GetVariable<List<string>>("unlockedBossScenes").Contains(base.name))
		{
			return true;
		}
		if (this.bossTests != null && this.bossTests.Length != 0)
		{
			BossScene.BossTest[] array = this.bossTests;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].IsUnlocked())
				{
					return true;
				}
			}
		}
		else if (!this.requireUnlock || source != BossSceneCheckSource.Statue)
		{
			return true;
		}
		return false;
	}

	// Token: 0x04000C91 RID: 3217
	[Tooltip("The name of the scene to load.")]
	public string sceneName;

	// Token: 0x04000C92 RID: 3218
	[Tooltip("Tests that need to succeed in order for this boss the be considered \"unlocked\". (for old save files - new saves will set each boss scene unlocked by name)")]
	public BossScene.BossTest[] bossTests;

	// Token: 0x04000C93 RID: 3219
	[Header("Sequence Only")]
	public BossScene baseBoss;

	// Token: 0x04000C94 RID: 3220
	public bool substituteBoss;

	// Token: 0x04000C95 RID: 3221
	[SerializeField]
	private Sprite displayIcon;

	// Token: 0x04000C96 RID: 3222
	[Tooltip("If this is checked this scene will not count toward overall sequence unlock, but will still only be loaded if it's unlocked.")]
	public bool isHidden;

	// Token: 0x04000C97 RID: 3223
	[SerializeField]
	private bool forceAssetUnload;

	// Token: 0x04000C98 RID: 3224
	[Header("Boss Statue Only")]
	public bool requireUnlock;

	// Token: 0x04000C99 RID: 3225
	[SerializeField]
	private BossScene tier1Scene;

	// Token: 0x04000C9A RID: 3226
	[SerializeField]
	private BossScene tier2Scene;

	// Token: 0x04000C9B RID: 3227
	[SerializeField]
	private BossScene tier3Scene;

	// Token: 0x02000220 RID: 544
	[Serializable]
	public class BossTest
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0003D244 File Offset: 0x0003B444
		public bool IsUnlocked()
		{
			bool flag = true;
			if (!string.IsNullOrEmpty(this.persistentBool.id) && !string.IsNullOrEmpty(this.persistentBool.sceneName))
			{
				PersistentBoolData persistentBoolData = SceneData.instance.FindMyState(this.persistentBool);
				if (persistentBoolData == null || !persistentBoolData.activated)
				{
					flag = false;
				}
			}
			if (flag)
			{
				foreach (BossScene.BossTest.BoolTest boolTest in this.boolTests)
				{
					if (GameManager.instance.GetPlayerDataBool(boolTest.playerDataBool) != boolTest.value)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				foreach (BossScene.BossTest.IntTest intTest in this.intTests)
				{
					int playerDataInt = GameManager.instance.GetPlayerDataInt(intTest.playerDataInt);
					if (playerDataInt > -9999)
					{
						bool flag2 = false;
						switch (intTest.comparison)
						{
						case BossScene.BossTest.IntTest.Comparison.Equal:
							flag2 = (playerDataInt == intTest.value);
							break;
						case BossScene.BossTest.IntTest.Comparison.NotEqual:
							flag2 = (playerDataInt != intTest.value);
							break;
						case BossScene.BossTest.IntTest.Comparison.MoreThan:
							flag2 = (playerDataInt > intTest.value);
							break;
						case BossScene.BossTest.IntTest.Comparison.LessThan:
							flag2 = (playerDataInt < intTest.value);
							break;
						}
						if (!flag2)
						{
							flag = false;
							break;
						}
					}
				}
			}
			if (flag && this.sharedData != null)
			{
				BossScene.BossTest.SharedDataTest[] array3 = this.sharedData;
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] == BossScene.BossTest.SharedDataTest.GGUnlock && GameManager.instance.GetStatusRecordInt("RecBossRushMode") == 1)
					{
						flag = false;
					}
				}
			}
			return flag;
		}

		// Token: 0x04000C9C RID: 3228
		public PersistentBoolData persistentBool;

		// Token: 0x04000C9D RID: 3229
		public BossScene.BossTest.BoolTest[] boolTests;

		// Token: 0x04000C9E RID: 3230
		public BossScene.BossTest.IntTest[] intTests;

		// Token: 0x04000C9F RID: 3231
		public BossScene.BossTest.SharedDataTest[] sharedData;

		// Token: 0x02000221 RID: 545
		[Serializable]
		public struct BoolTest
		{
			// Token: 0x04000CA0 RID: 3232
			public string playerDataBool;

			// Token: 0x04000CA1 RID: 3233
			public bool value;
		}

		// Token: 0x02000222 RID: 546
		[Serializable]
		public struct IntTest
		{
			// Token: 0x04000CA2 RID: 3234
			public string playerDataInt;

			// Token: 0x04000CA3 RID: 3235
			public int value;

			// Token: 0x04000CA4 RID: 3236
			public BossScene.BossTest.IntTest.Comparison comparison;

			// Token: 0x02000223 RID: 547
			public enum Comparison
			{
				// Token: 0x04000CA6 RID: 3238
				Equal,
				// Token: 0x04000CA7 RID: 3239
				NotEqual,
				// Token: 0x04000CA8 RID: 3240
				MoreThan,
				// Token: 0x04000CA9 RID: 3241
				LessThan
			}
		}

		// Token: 0x02000224 RID: 548
		public enum SharedDataTest
		{
			// Token: 0x04000CAB RID: 3243
			GGUnlock
		}
	}
}
