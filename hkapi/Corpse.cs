using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200015B RID: 347
public class Corpse : MonoBehaviour
{
	// Token: 0x0600080F RID: 2063 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
	private void Awake()
	{
		this.meshRenderer = base.GetComponent<MeshRenderer>();
		this.sprite = base.GetComponent<tk2dSprite>();
		this.spriteAnimator = base.GetComponent<tk2dSpriteAnimator>();
		this.spriteFlash = base.GetComponent<SpriteFlash>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.bodyCollider = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0002D3F5 File Offset: 0x0002B5F5
	public void Setup(bool noSteam, bool spellBurn)
	{
		this.noSteam = noSteam;
		this.spellBurn = spellBurn;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0002D408 File Offset: 0x0002B608
	protected virtual void Start()
	{
		this.startAudio.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.resetRotation)
		{
			base.transform.SetRotation2D(0f);
		}
		if (this.noSteam && this.corpseSteam != null)
		{
			this.corpseSteam.gameObject.SetActive(false);
		}
		if (this.spellBurn)
		{
			if (this.sprite != null)
			{
				this.sprite.color = new Color(0.19607843f, 0.19607843f, 0.19607843f, 1f);
			}
			if (this.corpseFlame != null)
			{
				this.corpseFlame.Play();
			}
		}
		if (this.massless)
		{
			this.state = Corpse.States.DeathAnimation;
		}
		else
		{
			this.state = Corpse.States.InAir;
			if (this.spriteAnimator != null)
			{
				tk2dSpriteAnimationClip clipByName = this.spriteAnimator.GetClipByName("Death Air");
				if (clipByName != null)
				{
					this.spriteAnimator.Play(clipByName);
				}
			}
		}
		if (this.instantChunker && !this.breaker)
		{
			this.Land();
		}
		if (GameManager.instance.GetCurrentMapZone() == "COLOSSEUM")
		{
			base.StartCoroutine(this.DropThroughFloor());
		}
		base.StartCoroutine(this.DisableFlame());
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0002D550 File Offset: 0x0002B750
	protected void Update()
	{
		if (this.state == Corpse.States.DeathAnimation)
		{
			if (this.spriteAnimator == null || !this.spriteAnimator.Playing)
			{
				this.Complete(true, true);
				return;
			}
		}
		else if (this.state == Corpse.States.InAir)
		{
			this.bouncedThisFrame = false;
			if (base.transform.position.y < -10f)
			{
				this.Complete(true, true);
				return;
			}
		}
		else if (this.state == Corpse.States.PendingLandEffects)
		{
			this.landEffectsDelayRemaining -= Time.deltaTime;
			if (this.landEffectsDelayRemaining <= 0f)
			{
				this.Complete(false, false);
			}
		}
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0002D5EC File Offset: 0x0002B7EC
	private void Complete(bool detachChildren, bool destroyMe)
	{
		this.state = Corpse.States.Complete;
		base.enabled = false;
		if (this.corpseSteam != null)
		{
			this.corpseSteam.Stop();
		}
		if (this.corpseFlame != null)
		{
			this.corpseFlame.Stop();
		}
		if (detachChildren)
		{
			base.transform.DetachChildren();
		}
		if (destroyMe)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0002D655 File Offset: 0x0002B855
	protected void OnCollisionEnter2D(Collision2D collision)
	{
		this.OnCollision(collision);
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0002D655 File Offset: 0x0002B855
	protected void OnCollisionStay2D(Collision2D collision)
	{
		this.OnCollision(collision);
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0002D660 File Offset: 0x0002B860
	private void OnCollision(Collision2D collision)
	{
		if (this.state == Corpse.States.InAir)
		{
			Sweep sweep = new Sweep(this.bodyCollider, 3, 3, 0.1f);
			float num;
			if (sweep.Check(base.transform.position, 0.08f, 256, out num))
			{
				this.Land();
			}
		}
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0002D6B8 File Offset: 0x0002B8B8
	private void Land()
	{
		if (this.breaker)
		{
			if (this.bouncedThisFrame)
			{
				return;
			}
			this.bounceCount++;
			this.bouncedThisFrame = true;
			if (this.bounceCount >= this.smashBounces)
			{
				this.Smash();
				return;
			}
		}
		else
		{
			if (this.spriteAnimator != null && !this.hitAcid)
			{
				tk2dSpriteAnimationClip clipByName = this.spriteAnimator.GetClipByName("Death Land");
				if (clipByName != null)
				{
					this.spriteAnimator.Play(clipByName);
				}
			}
			this.landEffectsDelayRemaining = 1f;
			if (this.landEffects != null)
			{
				this.landEffects.SetActive(true);
			}
			this.state = Corpse.States.PendingLandEffects;
			if (!this.hitAcid)
			{
				this.LandEffects();
			}
		}
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00003603 File Offset: 0x00001803
	protected virtual void LandEffects()
	{
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0002D774 File Offset: 0x0002B974
	protected virtual void Smash()
	{
		if (!this.hitAcid)
		{
			GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 6, 8, 10f, 20f, 75f, 105f, null);
		}
		this.splatAudioClipTable.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.corpseFlame != null)
		{
			this.corpseFlame.Stop();
		}
		if (this.corpseSteam != null)
		{
			this.corpseSteam.Stop();
		}
		if (this.spriteAnimator != null)
		{
			this.spriteAnimator.Play("Death Land");
		}
		this.body.velocity = Vector2.zero;
		this.state = Corpse.States.DeathAnimation;
		if (this.bigBreaker)
		{
			if (!this.hitAcid)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 30, 30, 20f, 30f, 80f, 100f, null);
			}
			GameCameras instance = GameCameras.instance;
			if (instance)
			{
				instance.cameraShakeFSM.SendEvent("EnemyKillShake");
			}
		}
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
	public void Acid()
	{
		this.hitAcid = true;
		if (this.corpseFlame)
		{
			this.corpseFlame.Stop();
		}
		if (this.corpseSteam)
		{
			this.corpseSteam.Stop();
		}
		this.Land();
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0002D8E3 File Offset: 0x0002BAE3
	private IEnumerator DropThroughFloor()
	{
		yield return new WaitForSeconds(UnityEngine.Random.Range(3f, 6f));
		Collider2D[] componentsInChildren = this.GetComponentsInChildren<Collider2D>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].enabled = false;
		}
		if (this.body)
		{
			this.body.isKinematic = false;
		}
		yield return new WaitForSeconds(1f);
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0002D8F2 File Offset: 0x0002BAF2
	private IEnumerator DisableFlame()
	{
		yield return new WaitForSeconds(5f);
		if (this.corpseFlame)
		{
			this.corpseFlame.Stop();
		}
		yield break;
	}

	// Token: 0x040008F6 RID: 2294
	protected MeshRenderer meshRenderer;

	// Token: 0x040008F7 RID: 2295
	protected tk2dSprite sprite;

	// Token: 0x040008F8 RID: 2296
	protected tk2dSpriteAnimator spriteAnimator;

	// Token: 0x040008F9 RID: 2297
	protected SpriteFlash spriteFlash;

	// Token: 0x040008FA RID: 2298
	protected Rigidbody2D body;

	// Token: 0x040008FB RID: 2299
	protected Collider2D bodyCollider;

	// Token: 0x040008FC RID: 2300
	[SerializeField]
	protected ParticleSystem corpseFlame;

	// Token: 0x040008FD RID: 2301
	[SerializeField]
	protected ParticleSystem corpseSteam;

	// Token: 0x040008FE RID: 2302
	[SerializeField]
	protected GameObject landEffects;

	// Token: 0x040008FF RID: 2303
	[SerializeField]
	protected AudioSource audioPlayerPrefab;

	// Token: 0x04000900 RID: 2304
	[SerializeField]
	protected GameObject deathWaveInfectedPrefab;

	// Token: 0x04000901 RID: 2305
	[SerializeField]
	protected GameObject spatterOrangePrefab;

	// Token: 0x04000902 RID: 2306
	[SerializeField]
	protected RandomAudioClipTable splatAudioClipTable;

	// Token: 0x04000903 RID: 2307
	[SerializeField]
	private int smashBounces;

	// Token: 0x04000904 RID: 2308
	[SerializeField]
	private bool breaker;

	// Token: 0x04000905 RID: 2309
	[SerializeField]
	private bool bigBreaker;

	// Token: 0x04000906 RID: 2310
	[SerializeField]
	private bool chunker;

	// Token: 0x04000907 RID: 2311
	[SerializeField]
	private bool deathStun;

	// Token: 0x04000908 RID: 2312
	[SerializeField]
	private bool fungusExplode;

	// Token: 0x04000909 RID: 2313
	[SerializeField]
	private bool goopExplode;

	// Token: 0x0400090A RID: 2314
	[SerializeField]
	private bool hatcher;

	// Token: 0x0400090B RID: 2315
	[SerializeField]
	private bool instantChunker;

	// Token: 0x0400090C RID: 2316
	[SerializeField]
	private bool massless;

	// Token: 0x0400090D RID: 2317
	[SerializeField]
	private bool resetRotation;

	// Token: 0x0400090E RID: 2318
	[SerializeField]
	private AudioEvent startAudio;

	// Token: 0x0400090F RID: 2319
	[SerializeField]
	private bool spineBurst;

	// Token: 0x04000910 RID: 2320
	[SerializeField]
	private bool zomHive;

	// Token: 0x04000911 RID: 2321
	private bool noSteam;

	// Token: 0x04000912 RID: 2322
	protected bool spellBurn;

	// Token: 0x04000913 RID: 2323
	protected bool hitAcid;

	// Token: 0x04000914 RID: 2324
	private Corpse.States state;

	// Token: 0x04000915 RID: 2325
	private bool bouncedThisFrame;

	// Token: 0x04000916 RID: 2326
	private int bounceCount;

	// Token: 0x04000917 RID: 2327
	private float landEffectsDelayRemaining;

	// Token: 0x0200015C RID: 348
	private enum States
	{
		// Token: 0x04000919 RID: 2329
		NotStarted,
		// Token: 0x0400091A RID: 2330
		InAir,
		// Token: 0x0400091B RID: 2331
		DeathAnimation,
		// Token: 0x0400091C RID: 2332
		Complete,
		// Token: 0x0400091D RID: 2333
		PendingLandEffects
	}
}
