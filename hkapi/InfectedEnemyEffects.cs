using System;
using UnityEngine;

// Token: 0x020001B4 RID: 436
public class InfectedEnemyEffects : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x06000997 RID: 2455 RVA: 0x00034AA9 File Offset: 0x00032CA9
	protected void Reset()
	{
		this.impactAudio.Reset();
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00034AB6 File Offset: 0x00032CB6
	protected void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00034AC4 File Offset: 0x00032CC4
	public void RecieveHitEffect(float attackDirection)
	{
		if (this.didFireThisFrame)
		{
			return;
		}
		if (this.spriteFlash != null)
		{
			this.spriteFlash.flashInfected();
		}
		FSMUtility.SendEventToGameObject(base.gameObject, "DAMAGE FLASH", true);
		this.impactAudio.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
		this.hitFlashOrangePrefab.Spawn(base.transform.TransformPoint(this.effectOrigin));
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			if (!this.noBlood)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 3, 4, 10f, 15f, 120f, 150f, null);
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 8, 15, 10f, 25f, 30f, 60f, null);
			}
			this.hitPuffPrefab.Spawn(base.transform.position, Quaternion.Euler(0f, 90f, 270f));
			break;
		case 1:
			if (!this.noBlood)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 8, 10, 20f, 30f, 80f, 100f, null);
			}
			this.hitPuffPrefab.Spawn(base.transform.position, Quaternion.Euler(270f, 90f, 270f));
			break;
		case 2:
			if (!this.noBlood)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 3, 4, 10f, 15f, 30f, 60f, null);
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 8, 10, 15f, 25f, 120f, 150f, null);
			}
			this.hitPuffPrefab.Spawn(base.transform.position, Quaternion.Euler(180f, 90f, 270f));
			break;
		case 3:
			if (!this.noBlood)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 4, 5, 15f, 25f, 140f, 180f, null);
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 4, 5, 15f, 25f, 360f, 400f, null);
			}
			this.hitPuffPrefab.Spawn(base.transform.position, Quaternion.Euler(-72.5f, -180f, -180f));
			break;
		}
		this.didFireThisFrame = true;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00034DFD File Offset: 0x00032FFD
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x04000AAD RID: 2733
	private SpriteFlash spriteFlash;

	// Token: 0x04000AAE RID: 2734
	[SerializeField]
	private Vector3 effectOrigin;

	// Token: 0x04000AAF RID: 2735
	[SerializeField]
	private AudioEvent impactAudio;

	// Token: 0x04000AB0 RID: 2736
	[SerializeField]
	private AudioSource audioSourcePrefab;

	// Token: 0x04000AB1 RID: 2737
	[SerializeField]
	private GameObject hitFlashOrangePrefab;

	// Token: 0x04000AB2 RID: 2738
	[SerializeField]
	private GameObject spatterOrangePrefab;

	// Token: 0x04000AB3 RID: 2739
	[SerializeField]
	private GameObject hitPuffPrefab;

	// Token: 0x04000AB4 RID: 2740
	[SerializeField]
	private bool noBlood;

	// Token: 0x04000AB5 RID: 2741
	private bool didFireThisFrame;
}
