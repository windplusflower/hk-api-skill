using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000269 RID: 617
public class BossStatueTrophyPlaque : MonoBehaviour
{
	// Token: 0x06000CF8 RID: 3320 RVA: 0x00041798 File Offset: 0x0003F998
	public void SetDisplay(BossStatueTrophyPlaque.DisplayType type)
	{
		this.SetDisplayObject(type);
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x000417A4 File Offset: 0x0003F9A4
	public void DoTierCompleteEffect(BossStatueTrophyPlaque.DisplayType type)
	{
		if (type >= BossStatueTrophyPlaque.DisplayType.Tier1)
		{
			GameObject gameObject = this.tierCompleteEffectPrefabs[(int)type];
			if (gameObject)
			{
				this.spawnedCompleteEffect = UnityEngine.Object.Instantiate<GameObject>(gameObject, this.tierCompleteEffectPoint.position, gameObject.transform.rotation);
				this.spawnedCompleteEffect.SetActive(false);
				base.StartCoroutine(this.TierCompleteEffectDelayed());
			}
		}
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00041801 File Offset: 0x0003FA01
	private IEnumerator TierCompleteEffectDelayed()
	{
		yield return new WaitForSeconds(this.tierCompleteEffectDelay);
		this.spawnedCompleteEffect.SetActive(true);
		yield break;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00041810 File Offset: 0x0003FA10
	private void SetDisplayObject(BossStatueTrophyPlaque.DisplayType type)
	{
		GameObject[] array = this.displayObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
		if (type >= BossStatueTrophyPlaque.DisplayType.Tier1)
		{
			this.displayObjects[(int)type].SetActive(true);
		}
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00041850 File Offset: 0x0003FA50
	public static BossStatueTrophyPlaque.DisplayType GetDisplayType(BossStatue.Completion completion)
	{
		BossStatueTrophyPlaque.DisplayType result = BossStatueTrophyPlaque.DisplayType.None;
		if (completion.completedTier3)
		{
			result = BossStatueTrophyPlaque.DisplayType.Tier3;
		}
		else if (completion.completedTier2)
		{
			result = BossStatueTrophyPlaque.DisplayType.Tier2;
		}
		else if (completion.completedTier1)
		{
			result = BossStatueTrophyPlaque.DisplayType.Tier1;
		}
		return result;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00041882 File Offset: 0x0003FA82
	public BossStatueTrophyPlaque()
	{
		this.tierCompleteEffectDelay = 1f;
		base..ctor();
	}

	// Token: 0x04000DE3 RID: 3555
	[ArrayForEnum(typeof(BossStatueTrophyPlaque.DisplayType))]
	public GameObject[] displayObjects;

	// Token: 0x04000DE4 RID: 3556
	[Space]
	public Transform tierCompleteEffectPoint;

	// Token: 0x04000DE5 RID: 3557
	public float tierCompleteEffectDelay;

	// Token: 0x04000DE6 RID: 3558
	[ArrayForEnum(typeof(BossStatueTrophyPlaque.DisplayType))]
	public GameObject[] tierCompleteEffectPrefabs;

	// Token: 0x04000DE7 RID: 3559
	private GameObject spawnedCompleteEffect;

	// Token: 0x0200026A RID: 618
	public enum DisplayType
	{
		// Token: 0x04000DE9 RID: 3561
		None = -1,
		// Token: 0x04000DEA RID: 3562
		Tier1,
		// Token: 0x04000DEB RID: 3563
		Tier2,
		// Token: 0x04000DEC RID: 3564
		Tier3
	}
}
