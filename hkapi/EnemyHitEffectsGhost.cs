using System;
using UnityEngine;

// Token: 0x0200018C RID: 396
public class EnemyHitEffectsGhost : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x060008E3 RID: 2275 RVA: 0x00030DE3 File Offset: 0x0002EFE3
	protected void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00030DF4 File Offset: 0x0002EFF4
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
			this.spriteFlash.flashFocusHeal();
		}
		GameObject gameObject = this.ghostHitPt.Spawn(base.transform.position + this.effectOrigin);
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			gameObject.transform.SetRotation2D(-22.5f);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost1,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = -40f,
				AngleMax = 40f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost2,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = -40f,
				AngleMax = 40f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 1:
			gameObject.transform.SetRotation2D(70f);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost1,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 50f,
				AngleMax = 130f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost2,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 50f,
				AngleMax = 130f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 2:
			gameObject.transform.SetRotation2D(160f);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost1,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 140f,
				AngleMax = 220f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost2,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 140f,
				AngleMax = 220f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 3:
			gameObject.transform.SetRotation2D(-110f);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost1,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 230f,
				AngleMax = 310f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhost2,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 20f,
				SpeedMax = 35f,
				AngleMin = 230f,
				AngleMax = 310f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		}
		this.didFireThisFrame = true;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x000312E9 File Offset: 0x0002F4E9
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x040009E3 RID: 2531
	public Vector3 effectOrigin;

	// Token: 0x040009E4 RID: 2532
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040009E5 RID: 2533
	public AudioEvent enemyDamage;

	// Token: 0x040009E6 RID: 2534
	[Space]
	public GameObject ghostHitPt;

	// Token: 0x040009E7 RID: 2535
	public GameObject slashEffectGhost1;

	// Token: 0x040009E8 RID: 2536
	public GameObject slashEffectGhost2;

	// Token: 0x040009E9 RID: 2537
	private SpriteFlash spriteFlash;

	// Token: 0x040009EA RID: 2538
	private bool didFireThisFrame;
}
