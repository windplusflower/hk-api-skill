using System;
using UnityEngine;

// Token: 0x0200018B RID: 395
public class EnemyHitEffectsBlackKnight : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x060008DF RID: 2271 RVA: 0x00030C80 File Offset: 0x0002EE80
	protected void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00030C90 File Offset: 0x0002EE90
	public void RecieveHitEffect(float attackDirection)
	{
		if (this.didFireThisFrame)
		{
			return;
		}
		FSMUtility.SendEventToGameObject(base.gameObject, "DAMAGE FLASH", true);
		this.enemyDamage.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.spriteFlash)
		{
			this.spriteFlash.flashInfected();
		}
		this.hitFlashOrange.Spawn(base.transform.position + this.effectOrigin);
		GameObject gameObject = this.hitPuffLarge.Spawn(base.transform.position + this.effectOrigin);
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			gameObject.transform.eulerAngles = new Vector3(0f, 90f, 270f);
			break;
		case 1:
			gameObject.transform.eulerAngles = new Vector3(270f, 90f, 270f);
			break;
		case 2:
			gameObject.transform.eulerAngles = new Vector3(180f, 90f, 270f);
			break;
		case 3:
			gameObject.transform.eulerAngles = new Vector3(-72.5f, -180f, -180f);
			break;
		}
		this.didFireThisFrame = true;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00030DDA File Offset: 0x0002EFDA
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x040009DC RID: 2524
	public Vector3 effectOrigin;

	// Token: 0x040009DD RID: 2525
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040009DE RID: 2526
	public AudioEvent enemyDamage;

	// Token: 0x040009DF RID: 2527
	[Space]
	public GameObject hitFlashOrange;

	// Token: 0x040009E0 RID: 2528
	public GameObject hitPuffLarge;

	// Token: 0x040009E1 RID: 2529
	private SpriteFlash spriteFlash;

	// Token: 0x040009E2 RID: 2530
	private bool didFireThisFrame;
}
