using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;

// Token: 0x02000314 RID: 788
[ActionCategory("Hollow Knight")]
public class CheckCanDreamWarpInScene : FSMUtility.CheckFsmStateAction
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x0600113B RID: 4411 RVA: 0x00050F70 File Offset: 0x0004F170
	public override bool IsTrue
	{
		get
		{
			string sceneNameString = GameManager.instance.GetSceneNameString();
			return !this.sceneCheckFunctions.ContainsKey(sceneNameString) || this.sceneCheckFunctions[sceneNameString]();
		}
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00050FAC File Offset: 0x0004F1AC
	public CheckCanDreamWarpInScene()
	{
		Dictionary<string, Func<bool>> dictionary = new Dictionary<string, Func<bool>>();
		dictionary.Add("GG_Atrium", CheckCanDreamWarpInScene.bossRushCheck);
		dictionary.Add("GG_Atrium_Roof", CheckCanDreamWarpInScene.bossRushCheck);
		dictionary.Add("GG_Workshop", CheckCanDreamWarpInScene.bossRushCheck);
		dictionary.Add("GG_Blue_Room", CheckCanDreamWarpInScene.bossRushCheck);
		dictionary.Add("GG_Land_of_Storms", () => false);
		dictionary.Add("GG_Unlock_Wastes", () => false);
		this.sceneCheckFunctions = dictionary;
		base..ctor();
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x0005105E File Offset: 0x0004F25E
	// Note: this type is marked as 'beforefieldinit'.
	static CheckCanDreamWarpInScene()
	{
		CheckCanDreamWarpInScene.bossRushCheck = (() => !GameManager.instance.playerData.GetBool("bossRushMode"));
	}

	// Token: 0x040010F1 RID: 4337
	private static Func<bool> bossRushCheck;

	// Token: 0x040010F2 RID: 4338
	private Dictionary<string, Func<bool>> sceneCheckFunctions;
}
