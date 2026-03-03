using System;
using UnityEngine;

// Token: 0x0200018E RID: 398
public class EnemyHitEffectsUninfected : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x060008EB RID: 2283 RVA: 0x00031957 File Offset: 0x0002FB57
	protected void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00031968 File Offset: 0x0002FB68
	public void RecieveHitEffect(float attackDirection)
	{
		if (this.didFireThisFrame)
		{
			return;
		}
		if (this.sendDamageFlashEvent)
		{
			FSMUtility.SendEventToGameObject(base.gameObject, "DAMAGE FLASH", true);
		}
		this.enemyDamage.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.spriteFlash)
		{
			this.spriteFlash.flashFocusHeal();
		}
		GameObject gameObject = this.uninfectedHitPt.Spawn(base.transform.position + this.effectOrigin);
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			if (gameObject)
			{
				gameObject.transform.SetRotation2D(-45f);
			}
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
				SpeedMin = 10f,
				SpeedMax = 35f,
				AngleMin = -40f,
				AngleMax = 40f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 1:
			if (gameObject)
			{
				gameObject.transform.SetRotation2D(45f);
			}
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
				SpeedMin = 10f,
				SpeedMax = 35f,
				AngleMin = 50f,
				AngleMax = 130f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 2:
			if (gameObject)
			{
				gameObject.transform.SetRotation2D(-225f);
			}
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
				SpeedMin = 10f,
				SpeedMax = 35f,
				AngleMin = 140f,
				AngleMax = 220f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, this.effectOrigin);
			break;
		case 3:
			if (gameObject)
			{
				gameObject.transform.SetRotation2D(225f);
			}
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
				SpeedMin = 10f,
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

	// Token: 0x060008ED RID: 2285 RVA: 0x00031E87 File Offset: 0x00030087
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00031E90 File Offset: 0x00030090
	public EnemyHitEffectsUninfected()
	{
		this.sendDamageFlashEvent = true;
		base..ctor();
	}

	// Token: 0x040009F6 RID: 2550
	public Vector3 effectOrigin;

	// Token: 0x040009F7 RID: 2551
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040009F8 RID: 2552
	public AudioEvent enemyDamage;

	// Token: 0x040009F9 RID: 2553
	[Space]
	public GameObject uninfectedHitPt;

	// Token: 0x040009FA RID: 2554
	public GameObject slashEffectGhost1;

	// Token: 0x040009FB RID: 2555
	public GameObject slashEffectGhost2;

	// Token: 0x040009FC RID: 2556
	private SpriteFlash spriteFlash;

	// Token: 0x040009FD RID: 2557
	[Tooltip("Disable if there are no listeners for this event, to save the expensive recursive send event.")]
	public bool sendDamageFlashEvent;

	// Token: 0x040009FE RID: 2558
	private bool didFireThisFrame;
}
