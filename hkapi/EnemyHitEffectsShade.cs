using System;
using UnityEngine;

// Token: 0x0200018D RID: 397
public class EnemyHitEffectsShade : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x060008E7 RID: 2279 RVA: 0x000312F2 File Offset: 0x0002F4F2
	private void Awake()
	{
		this.sprite = base.GetComponent<tk2dSprite>();
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00031300 File Offset: 0x0002F500
	public void RecieveHitEffect(float attackDirection)
	{
		if (this.didFireThisFrame)
		{
			return;
		}
		FSMUtility.SendEventToGameObject(base.gameObject, "DAMAGE FLASH", true);
		this.hollowShadeStartled.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		this.heroDamage.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		this.sprite.color = Color.black;
		base.SendMessage("ColorReturnNeutral");
		this.hitFlashBlack.Spawn(base.transform.position + this.effectOrigin);
		GameObject gameObject = this.hitShade.Spawn(base.transform.position + this.effectOrigin);
		float minInclusive = 1f;
		float maxInclusive = 1f;
		float minInclusive2 = 0f;
		float maxInclusive2 = 360f;
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			gameObject.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			minInclusive = 1f;
			maxInclusive = 1.75f;
			minInclusive2 = -30f;
			maxInclusive2 = 30f;
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhostDark1,
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
				Prefab = this.slashEffectGhostDark2,
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
			gameObject.transform.eulerAngles = new Vector3(-90f, 90f, 0f);
			minInclusive = 1f;
			maxInclusive = 1.75f;
			minInclusive2 = 60f;
			maxInclusive2 = 120f;
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhostDark1,
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
				Prefab = this.slashEffectGhostDark2,
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
			gameObject.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			minInclusive = -1f;
			maxInclusive = -1.75f;
			minInclusive2 = -30f;
			maxInclusive2 = 30f;
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhostDark1,
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
				Prefab = this.slashEffectGhostDark2,
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
			gameObject.transform.eulerAngles = new Vector3(-90f, 90f, 0f);
			minInclusive = 1f;
			maxInclusive = 1.75f;
			minInclusive2 = -60f;
			maxInclusive2 = -120f;
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.slashEffectGhostDark1,
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
				Prefab = this.slashEffectGhostDark2,
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
		for (int i = 0; i < 3; i++)
		{
			GameObject gameObject2 = this.slashEffectShade.Spawn(base.transform.position + this.effectOrigin);
			gameObject2.transform.SetScaleX(UnityEngine.Random.Range(minInclusive, maxInclusive));
			gameObject2.transform.SetRotation2D(UnityEngine.Random.Range(minInclusive2, maxInclusive2));
		}
		this.didFireThisFrame = true;
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0003194E File Offset: 0x0002FB4E
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x040009EB RID: 2539
	public Vector3 effectOrigin;

	// Token: 0x040009EC RID: 2540
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040009ED RID: 2541
	public AudioEvent hollowShadeStartled;

	// Token: 0x040009EE RID: 2542
	public AudioEvent heroDamage;

	// Token: 0x040009EF RID: 2543
	[Space]
	public GameObject hitFlashBlack;

	// Token: 0x040009F0 RID: 2544
	public GameObject hitShade;

	// Token: 0x040009F1 RID: 2545
	public GameObject slashEffectGhostDark1;

	// Token: 0x040009F2 RID: 2546
	public GameObject slashEffectGhostDark2;

	// Token: 0x040009F3 RID: 2547
	public GameObject slashEffectShade;

	// Token: 0x040009F4 RID: 2548
	private tk2dSprite sprite;

	// Token: 0x040009F5 RID: 2549
	private bool didFireThisFrame;
}
