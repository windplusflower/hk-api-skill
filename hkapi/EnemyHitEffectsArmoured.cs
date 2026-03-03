using System;
using UnityEngine;

// Token: 0x0200018A RID: 394
public class EnemyHitEffectsArmoured : MonoBehaviour, IHitEffectReciever
{
	// Token: 0x060008DB RID: 2267 RVA: 0x00030A85 File Offset: 0x0002EC85
	protected void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00030A94 File Offset: 0x0002EC94
	public void RecieveHitEffect(float attackDirection)
	{
		if (this.didFireThisFrame)
		{
			return;
		}
		this.enemyDamage.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.spriteFlash)
		{
			this.spriteFlash.flashArmoured();
		}
		GameObject gameObject = this.dustHit ? this.dustHit.Spawn(base.transform.position + this.effectOrigin) : null;
		if (gameObject)
		{
			gameObject.transform.SetPositionZ(-0.01f);
		}
		switch (DirectionUtils.GetCardinalDirection(attackDirection))
		{
		case 0:
			if (gameObject)
			{
				gameObject.transform.eulerAngles = new Vector3(180f, 90f, 270f);
			}
			if (this.armourHit)
			{
				FSMUtility.SendEventToGameObject(this.armourHit, "ARMOUR HIT R", false);
			}
			break;
		case 1:
			if (gameObject)
			{
				gameObject.transform.eulerAngles = new Vector3(270f, 90f, 270f);
			}
			if (this.armourHit)
			{
				FSMUtility.SendEventToGameObject(this.armourHit, "ARMOUR HIT U", false);
			}
			break;
		case 2:
			if (gameObject)
			{
				gameObject.transform.eulerAngles = new Vector3(0f, 90f, 270f);
			}
			if (this.armourHit)
			{
				FSMUtility.SendEventToGameObject(this.armourHit, "ARMOUR HIT L", false);
			}
			break;
		case 3:
			if (gameObject)
			{
				gameObject.transform.eulerAngles = new Vector3(-72.5f, -180f, -180f);
			}
			if (this.armourHit)
			{
				FSMUtility.SendEventToGameObject(this.armourHit, "ARMOUR HIT D", false);
			}
			break;
		}
		this.didFireThisFrame = true;
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00030C77 File Offset: 0x0002EE77
	protected void Update()
	{
		this.didFireThisFrame = false;
	}

	// Token: 0x040009D5 RID: 2517
	public Vector3 effectOrigin;

	// Token: 0x040009D6 RID: 2518
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040009D7 RID: 2519
	public AudioEvent enemyDamage;

	// Token: 0x040009D8 RID: 2520
	[Space]
	public GameObject dustHit;

	// Token: 0x040009D9 RID: 2521
	public GameObject armourHit;

	// Token: 0x040009DA RID: 2522
	private SpriteFlash spriteFlash;

	// Token: 0x040009DB RID: 2523
	private bool didFireThisFrame;
}
