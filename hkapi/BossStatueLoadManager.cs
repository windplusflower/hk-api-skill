using System;
using UnityEngine;

// Token: 0x02000267 RID: 615
public class BossStatueLoadManager : MonoBehaviour
{
	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x000415B0 File Offset: 0x0003F7B0
	public static bool ShouldUnload
	{
		get
		{
			return !(BossStatueLoadManager.currentBossScene == null) && !(BossStatueLoadManager.previousBossScene == null) && BossStatueLoadManager.activeCount > 0 && BossStatueLoadManager.currentBossScene != BossStatueLoadManager.previousBossScene;
		}
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x000415E8 File Offset: 0x0003F7E8
	private void OnEnable()
	{
		BossStatueLoadManager.activeCount++;
		TransitionPoint component = base.GetComponent<TransitionPoint>();
		if (component)
		{
			component.OnBeforeTransition += BossStatueLoadManager.Clear;
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00041624 File Offset: 0x0003F824
	private void OnDisable()
	{
		TransitionPoint component = base.GetComponent<TransitionPoint>();
		if (component)
		{
			component.OnBeforeTransition -= BossStatueLoadManager.Clear;
		}
		BossStatueLoadManager.activeCount--;
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0004165E File Offset: 0x0003F85E
	public static void Clear()
	{
		BossStatueLoadManager.currentBossScene = null;
		BossStatueLoadManager.previousBossScene = null;
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x0004166C File Offset: 0x0003F86C
	public static void RecordBossScene(BossScene bossScene)
	{
		BossStatueLoadManager.previousBossScene = BossStatueLoadManager.currentBossScene;
		BossStatueLoadManager.currentBossScene = bossScene;
		Debug.Log(string.Format("Recorded statue boss scene. Current: {0}, Previous: {1}", BossStatueLoadManager.currentBossScene ? BossStatueLoadManager.currentBossScene.name : "null", BossStatueLoadManager.previousBossScene ? BossStatueLoadManager.previousBossScene.name : "null"));
	}

	// Token: 0x04000DDF RID: 3551
	private static BossScene currentBossScene;

	// Token: 0x04000DE0 RID: 3552
	private static BossScene previousBossScene;

	// Token: 0x04000DE1 RID: 3553
	private static int activeCount;
}
