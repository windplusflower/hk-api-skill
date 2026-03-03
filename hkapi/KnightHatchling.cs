using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001B6 RID: 438
public class KnightHatchling : MonoBehaviour
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600099F RID: 2463 RVA: 0x00034E50 File Offset: 0x00033050
	public bool IsGrounded
	{
		get
		{
			return this.groundColliders.Count > 0;
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00034E60 File Offset: 0x00033060
	// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00034E68 File Offset: 0x00033068
	public KnightHatchling.State CurrentState
	{
		get
		{
			return this.currentState;
		}
		private set
		{
			if (this.currentState != value)
			{
				this.PreviousState = this.currentState;
			}
			this.currentState = value;
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00034E86 File Offset: 0x00033086
	// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00034E8E File Offset: 0x0003308E
	public KnightHatchling.State LastFrameState { get; private set; }

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00034E97 File Offset: 0x00033097
	// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00034E9F File Offset: 0x0003309F
	public KnightHatchling.State PreviousState { get; private set; }

	// Token: 0x060009A6 RID: 2470 RVA: 0x00034EA8 File Offset: 0x000330A8
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
		this.meshRenderer = base.GetComponent<MeshRenderer>();
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.col = base.GetComponent<Collider2D>();
		this.spriteFlash = base.GetComponent<SpriteFlash>();
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00034F00 File Offset: 0x00033100
	private void Start()
	{
		if (this.enemyRange)
		{
			this.enemyRange.OnTriggerStayed += delegate(Collider2D collision, GameObject obj)
			{
				if (!this.target)
				{
					if (collision.tag == "Hatchling Magnet")
					{
						this.target = collision.gameObject;
					}
					else if (collision.tag != "Ignore Hatchling" && Physics2D.Linecast(base.transform.position, collision.transform.position, LayerMask.GetMask(new string[]
					{
						"Terrain",
						"Soft Terrain"
					})).collider == null)
					{
						this.target = collision.gameObject;
					}
				}
				if (this.CurrentState == KnightHatchling.State.Follow && this.target)
				{
					this.CurrentState = KnightHatchling.State.Attack;
				}
			};
			this.enemyRange.OnTriggerExited += delegate(Collider2D collision, GameObject obj)
			{
				if (this.CurrentState != KnightHatchling.State.Attack && this.target && this.target == collision.gameObject)
				{
					this.target = null;
				}
			};
		}
		if (this.groundRange)
		{
			this.groundRange.OnTriggerEntered += delegate(Collider2D collision, GameObject obj)
			{
				if (!this.groundColliders.Contains(collision))
				{
					this.groundColliders.Add(collision);
				}
			};
			this.groundRange.OnTriggerExited += delegate(Collider2D collision, GameObject obj)
			{
				if (this.groundColliders.Contains(collision))
				{
					this.groundColliders.Remove(collision);
				}
			};
		}
		this.startZ = UnityEngine.Random.Range(0.0041f, 0.0049f);
		this.sleepZ = UnityEngine.Random.Range(0.003f, 0.0035f);
		base.transform.SetPositionZ(this.startZ);
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00034FC0 File Offset: 0x000331C0
	private void OnEnable()
	{
		if (GameManager.instance.entryGateName == "dreamGate")
		{
			this.dreamSpawn = true;
		}
		PlayerData playerData = GameManager.instance.playerData;
		this.details = (playerData.GetBool("equippedCharm_10") ? this.dungDetails : this.normalDetails);
		if (this.audioSource)
		{
			this.audioSource.pitch = UnityEngine.Random.Range(0.85f, 1.15f);
			if (this.loopClips.Length != 0)
			{
				this.audioSource.clip = this.loopClips[UnityEngine.Random.Range(0, this.loopClips.Length)];
			}
		}
		if (playerData.GetBool("equippedCharm_6") && playerData.GetInt("health") == 1 && (!playerData.GetBool("equippedCharm_27") || playerData.GetInt("healthBlue") <= 0))
		{
			if (this.spriteFlash)
			{
				this.spriteFlash.FlashingFury();
			}
			this.details.damage = this.details.damage + 5;
		}
		if (this.dungPt)
		{
			if (this.details.dung && !this.dreamSpawn)
			{
				this.dungPt.Play();
			}
			else
			{
				this.dungPt.Stop();
			}
		}
		if (this.enemyRange)
		{
			this.enemyRange.gameObject.SetActive(false);
		}
		if (this.groundRange)
		{
			this.groundRange.gameObject.SetActive(true);
		}
		if (this.col)
		{
			this.col.enabled = false;
		}
		this.groundColliders.Clear();
		this.target = null;
		this.LastFrameState = KnightHatchling.State.None;
		this.CurrentState = KnightHatchling.State.None;
		if (this.terrainCollider)
		{
			this.terrainCollider.enabled = true;
		}
		if (this.meshRenderer)
		{
			this.meshRenderer.enabled = false;
		}
		base.StartCoroutine(this.Spawn());
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000351B2 File Offset: 0x000333B2
	private void OnDisable()
	{
		this.quickSpawn = false;
		this.dreamSpawn = false;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x000351C4 File Offset: 0x000333C4
	private void FixedUpdate()
	{
		KnightHatchling.State state = this.CurrentState;
		switch (this.CurrentState)
		{
		case KnightHatchling.State.Follow:
		{
			if (this.LastFrameState != KnightHatchling.State.Follow)
			{
				if (this.damageEnemies)
				{
					this.damageEnemies.damageDealt = 0;
				}
				if (this.col)
				{
					this.col.enabled = true;
				}
				if (this.enemyRange)
				{
					this.enemyRange.gameObject.SetActive(true);
				}
				if (this.animator)
				{
					this.animator.Play(this.details.flyAnim);
				}
				if (this.audioSource)
				{
					this.audioSource.Play();
				}
				this.body.isKinematic = false;
				this.targetRadius = UnityEngine.Random.Range(0.1f, 0.75f);
				this.offset = new Vector3(UnityEngine.Random.Range(-3.5f, 3.5f), UnityEngine.Random.Range(0.25f, 2f));
				this.awayTimer = 0f;
				base.transform.SetPositionZ(this.startZ);
			}
			float heroDistance = this.GetHeroDistance();
			float speedMax = Mathf.Clamp(heroDistance + 4f, 4f, 18f);
			this.DoFace(false, true, this.details.turnFlyAnim, true, 0.5f);
			this.DoChase(HeroController.instance.transform, 2f, speedMax, 40f, this.targetRadius, 0.9f, this.offset);
			this.DoBuzz(0.75f, 1f, 18f, 80f, 110f, new Vector2(50f, 50f));
			if (heroDistance * 1.15f > 10f)
			{
				this.awayTimer += Time.fixedDeltaTime;
				if (this.awayTimer >= 4f)
				{
					state = KnightHatchling.State.Tele;
				}
			}
			else
			{
				this.awayTimer = 0f;
			}
			break;
		}
		case KnightHatchling.State.Tele:
			if (this.LastFrameState != KnightHatchling.State.Tele)
			{
				if (this.audioSource)
				{
					this.audioSource.Stop();
				}
				if (this.animator)
				{
					this.animator.Play(this.details.teleStartAnim);
				}
				if (this.enemyRange)
				{
					this.enemyRange.gameObject.SetActive(false);
				}
				if (this.groundRange)
				{
					this.groundRange.gameObject.SetActive(false);
				}
				if (this.terrainCollider)
				{
					this.terrainCollider.enabled = false;
				}
			}
			this.DoChase(HeroController.instance.transform, 2f, 25f, 150f, 0f, 0f, new Vector2(0f, -0.5f));
			if (this.GetHeroDistance() < 1f)
			{
				state = KnightHatchling.State.None;
				base.StartCoroutine(this.TeleEnd());
			}
			break;
		case KnightHatchling.State.Attack:
			if (this.LastFrameState != KnightHatchling.State.Attack)
			{
				if (this.audioSource)
				{
					this.audioSource.Stop();
					if (this.attackChargeClip)
					{
						this.audioSource.PlayOneShot(this.attackChargeClip);
					}
				}
				if (this.animator)
				{
					this.animator.Play(this.details.attackAnim);
				}
				if (this.enemyRange)
				{
					this.enemyRange.gameObject.SetActive(false);
				}
				if (this.damageEnemies)
				{
					this.damageEnemies.damageDealt = this.details.damage;
				}
				this.attackFinishTime = Time.time + 2f;
			}
			if (Time.time > this.attackFinishTime || this.target == null)
			{
				this.target = null;
				state = KnightHatchling.State.Follow;
			}
			else
			{
				this.DoFace(false, true, this.details.turnAttackAnim, true, 0.1f);
				this.DoChaseSimple(this.target.transform, 25f, 100f, 0f, 0f);
			}
			break;
		case KnightHatchling.State.BenchRestStart:
			if (this.LastFrameState != KnightHatchling.State.BenchRestStart)
			{
				this.body.velocity = Vector2.zero;
				if (this.animator)
				{
					this.animator.Play(this.details.flyAnim);
				}
				this.benchRestWaitTime = Time.time + UnityEngine.Random.Range(2f, 5f);
			}
			if (Time.time < this.benchRestWaitTime)
			{
				this.DoBuzz(0.75f, 1f, 2f, 30f, 50f, new Vector2(1f, 1f));
				this.DoFace(false, true, this.details.turnFlyAnim, true, 0.5f);
			}
			else
			{
				state = KnightHatchling.State.BenchRestLower;
			}
			break;
		case KnightHatchling.State.BenchRestLower:
		{
			if (this.LastFrameState != KnightHatchling.State.BenchRestLower)
			{
				if (this.animator)
				{
					this.animator.Play(this.details.flyAnim);
				}
				base.transform.SetPositionZ(this.sleepZ);
				this.body.isKinematic = false;
			}
			this.body.AddForce(new Vector2(0f, -5f));
			Vector2 velocity = this.body.velocity;
			velocity.x *= 0.85f;
			this.body.velocity = velocity;
			this.DoFace(false, true, this.details.turnFlyAnim, true, 0.5f);
			if (this.IsGrounded)
			{
				state = KnightHatchling.State.BenchResting;
				if (this.details.dung)
				{
					this.dungSleepPlopSound.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
				}
				if (this.audioSource)
				{
					this.audioSource.Stop();
				}
				this.body.isKinematic = true;
				this.body.velocity = Vector2.zero;
				if (this.animator)
				{
					this.animator.Play(this.details.restStartAnim);
				}
				if (this.details.groundPoint)
				{
					RaycastHit2D raycastHit2D = Physics2D.Raycast(base.transform.position, Vector2.down, 2f, 256);
					if (raycastHit2D.collider != null)
					{
						Vector2 point = raycastHit2D.point;
						Vector2 v = this.details.groundPoint.position - point;
						v.x = 0f;
						base.transform.position -= v;
					}
				}
			}
			break;
		}
		}
		this.LastFrameState = this.CurrentState;
		this.CurrentState = state;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00035888 File Offset: 0x00033A88
	private IEnumerator Spawn()
	{
		yield return null;
		if (this.dreamSpawn)
		{
			yield return new WaitForSeconds(UnityEngine.Random.Range(1.5f, 2f));
		}
		if (this.audioSource)
		{
			this.audioSource.Play();
		}
		if (this.meshRenderer && !this.dreamSpawn)
		{
			this.meshRenderer.enabled = true;
		}
		if (!this.quickSpawn)
		{
			float finishDelay = 0f;
			if (this.animator)
			{
				tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName(this.details.hatchAnim);
				if (clipByName != null)
				{
					this.animator.Play(clipByName);
					finishDelay = clipByName.Duration;
				}
			}
			if (this.body)
			{
				float num = 45f;
				float num2 = UnityEngine.Random.Range(40f, 140f);
				Vector2 velocity = default(Vector2);
				velocity.x = num * Mathf.Cos(num2 * 0.017453292f);
				velocity.y = num * Mathf.Sin(num2 * 0.017453292f);
				this.body.velocity = velocity;
			}
			if (!this.dreamSpawn)
			{
				GlobalPrefabDefaults.Instance.SpawnBlood(HeroController.instance.transform.position + new Vector3(0.2f, -0.7f, 0f), 2, 4, 7f, 15f, 20f, 160f, new Color?(this.details.spatterColor));
				this.details.birthSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
			}
			for (float elapsed = 0f; elapsed < finishDelay; elapsed += Time.fixedDeltaTime)
			{
				if (this.body)
				{
					this.body.velocity *= 0.8f;
				}
				yield return new WaitForFixedUpdate();
			}
			if (this.dreamSpawn)
			{
				this.meshRenderer.enabled = true;
				yield return this.StartCoroutine(this.animator.PlayAnimWait("Dreamgate In"));
				if (this.dungPt && this.details.dung)
				{
					this.dungPt.Play();
				}
			}
		}
		if (GameManager.instance.playerData.GetBool("atBench"))
		{
			this.CurrentState = KnightHatchling.State.BenchRestStart;
		}
		else
		{
			this.CurrentState = KnightHatchling.State.Follow;
		}
		yield break;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00035897 File Offset: 0x00033A97
	private float GetHeroDistance()
	{
		return Vector2.Distance(base.transform.position, HeroController.instance.transform.position);
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000358C2 File Offset: 0x00033AC2
	private IEnumerator TeleEnd()
	{
		if (this.groundRange)
		{
			this.groundRange.gameObject.SetActive(true);
		}
		if (this.terrainCollider)
		{
			this.terrainCollider.enabled = true;
		}
		if (this.audioSource)
		{
			this.audioSource.Play();
		}
		if (this.animator)
		{
			tk2dSpriteAnimationClip clip = this.animator.GetClipByName(this.details.teleEndAnim);
			this.animator.Play(clip);
			for (float elapsed = 0f; elapsed < clip.Duration; elapsed += Time.fixedDeltaTime)
			{
				if (this.body)
				{
					this.body.velocity *= 0.7f;
				}
				yield return new WaitForFixedUpdate();
			}
			clip = null;
		}
		this.CurrentState = KnightHatchling.State.Follow;
		yield break;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x000358D1 File Offset: 0x00033AD1
	public void FsmHitLanded()
	{
		this.CurrentState = KnightHatchling.State.None;
		if (this.damageEnemies)
		{
			this.damageEnemies.damageDealt = 0;
		}
		base.StartCoroutine(this.Explode());
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00035900 File Offset: 0x00033B00
	private IEnumerator Explode()
	{
		yield return new WaitForFixedUpdate();
		if (this.col)
		{
			this.col.enabled = false;
		}
		this.explodeSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		this.body.velocity = Vector2.zero;
		if (this.spriteFlash)
		{
			this.spriteFlash.CancelFlash();
		}
		float seconds = 2f;
		if (this.details.dung)
		{
			if (this.dungPt)
			{
				this.dungPt.Stop();
			}
			this.dungExplodeSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
			if (this.dungExplosionPrefab)
			{
				this.dungExplosionPrefab.Spawn(this.transform.position);
			}
			if (this.meshRenderer)
			{
				this.meshRenderer.enabled = false;
			}
			GlobalPrefabDefaults.Instance.SpawnBlood(HeroController.instance.transform.position, 8, 8, 10f, 20f, 0f, 360f, new Color?(this.details.spatterColor));
		}
		else if (this.animator)
		{
			tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName("Burst");
			if (clipByName != null)
			{
				this.animator.Play(clipByName);
				seconds = clipByName.Duration;
			}
		}
		yield return new WaitForSeconds(seconds);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x0003590F File Offset: 0x00033B0F
	public void FsmCharmsEnd()
	{
		this.CurrentState = KnightHatchling.State.None;
		base.StartCoroutine(this.CharmsEnd());
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00035925 File Offset: 0x00033B25
	private IEnumerator CharmsEnd()
	{
		float finishDelay = 0f;
		if (this.animator)
		{
			tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName("Tele Start");
			if (clipByName != null)
			{
				this.animator.Play(clipByName);
				finishDelay = clipByName.Duration;
			}
		}
		for (float elapsed = 0f; elapsed < finishDelay; elapsed += Time.fixedDeltaTime)
		{
			if (this.body)
			{
				this.body.velocity *= 0.8f;
			}
			yield return new WaitForFixedUpdate();
		}
		this.meshRenderer.enabled = false;
		if (this.details.dung && this.dungPt)
		{
			this.dungPt.Stop(true, ParticleSystemStopBehavior.StopEmitting);
			while (this.dungPt.IsAlive(true))
			{
				yield return null;
			}
		}
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00035934 File Offset: 0x00033B34
	public void FsmHazardReload()
	{
		base.gameObject.Recycle();
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00035941 File Offset: 0x00033B41
	public void FsmBenchRestStart()
	{
		this.CurrentState = KnightHatchling.State.BenchRestStart;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0003594A File Offset: 0x00033B4A
	public void FsmBenchRestEnd()
	{
		if (this.CurrentState == KnightHatchling.State.BenchResting)
		{
			base.StartCoroutine(this.WakeUp());
			return;
		}
		this.CurrentState = KnightHatchling.State.Follow;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0003596A File Offset: 0x00033B6A
	private IEnumerator WakeUp()
	{
		float seconds = 0f;
		if (this.animator)
		{
			tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName(this.details.restEndAnim);
			if (clipByName != null)
			{
				this.animator.Play(clipByName);
				seconds = clipByName.Duration;
			}
		}
		yield return new WaitForSeconds(seconds);
		this.CurrentState = KnightHatchling.State.Follow;
		yield break;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00035979 File Offset: 0x00033B79
	public void FsmQuickSpawn()
	{
		this.quickSpawn = true;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00035982 File Offset: 0x00033B82
	public void FsmDreamGateOut()
	{
		this.CurrentState = KnightHatchling.State.None;
		base.StartCoroutine(this.DreamGateOut());
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00035998 File Offset: 0x00033B98
	private IEnumerator DreamGateOut()
	{
		float seconds = 0f;
		if (this.animator)
		{
			tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName("Dreamgate Out");
			if (clipByName != null)
			{
				this.animator.Play(clipByName);
				seconds = clipByName.Duration;
			}
		}
		yield return new WaitForSeconds(seconds);
		this.meshRenderer.enabled = false;
		if (this.details.dung && this.dungPt)
		{
			this.dungPt.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		yield break;
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x000359A8 File Offset: 0x00033BA8
	private void DoFace(bool spriteFacesRight, bool playNewAnimation, string newAnimationClip, bool pauseBetweenTurns, float pauseTime)
	{
		if (this.body == null)
		{
			return;
		}
		ref Vector2 velocity = this.body.velocity;
		Vector3 localScale = base.transform.localScale;
		float x = velocity.x;
		if (this.CurrentState != this.LastFrameState)
		{
			this.xScale = base.transform.localScale.x;
			this.pauseTimer = 0f;
		}
		if (this.xScale < 0f)
		{
			this.xScale *= -1f;
		}
		if (this.pauseTimer <= 0f || !pauseBetweenTurns)
		{
			if (x > 0f)
			{
				if (spriteFacesRight)
				{
					if (localScale.x != this.xScale)
					{
						this.pauseTimer = pauseTime;
						localScale.x = this.xScale;
						if (playNewAnimation)
						{
							this.animator.Play(newAnimationClip);
							this.animator.PlayFromFrame(0);
						}
					}
				}
				else if (localScale.x != -this.xScale)
				{
					this.pauseTimer = pauseTime;
					localScale.x = -this.xScale;
					if (playNewAnimation)
					{
						this.animator.Play(newAnimationClip);
						this.animator.PlayFromFrame(0);
					}
				}
			}
			else if (x <= 0f)
			{
				if (spriteFacesRight)
				{
					if (localScale.x != -this.xScale)
					{
						this.pauseTimer = pauseTime;
						localScale.x = -this.xScale;
						if (playNewAnimation)
						{
							this.animator.Play(newAnimationClip);
							this.animator.PlayFromFrame(0);
						}
					}
				}
				else if (localScale.x != this.xScale)
				{
					this.pauseTimer = pauseTime;
					localScale.x = this.xScale;
					if (playNewAnimation)
					{
						this.animator.Play(newAnimationClip);
						this.animator.PlayFromFrame(0);
					}
				}
			}
		}
		else
		{
			this.pauseTimer -= Time.deltaTime;
		}
		base.transform.localScale = new Vector3(localScale.x, base.transform.localScale.y, base.transform.localScale.z);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00035BC0 File Offset: 0x00033DC0
	private void DoChase(Transform target, float distance, float speedMax, float accelerationForce, float targetRadius, float deceleration, Vector2 offset)
	{
		if (this.body == null)
		{
			return;
		}
		float num = Mathf.Sqrt(Mathf.Pow(base.transform.position.x - (target.position.x + offset.x), 2f) + Mathf.Pow(base.transform.position.y - (target.position.y + offset.y), 2f));
		Vector2 vector = this.body.velocity;
		if (num <= distance - targetRadius || num >= distance + targetRadius)
		{
			Vector2 vector2 = new Vector2(target.position.x + offset.x - base.transform.position.x, target.position.y + offset.y - base.transform.position.y);
			vector2 = Vector2.ClampMagnitude(vector2, 1f);
			vector2 = new Vector2(vector2.x * accelerationForce, vector2.y * accelerationForce);
			if (num < distance)
			{
				vector2 = new Vector2(-vector2.x, -vector2.y);
			}
			this.body.AddForce(vector2);
			vector = Vector2.ClampMagnitude(vector, speedMax);
			this.body.velocity = vector;
			return;
		}
		vector = this.body.velocity;
		if (vector.x < 0f)
		{
			vector.x *= deceleration;
			if (vector.x > 0f)
			{
				vector.x = 0f;
			}
		}
		else if (vector.x > 0f)
		{
			vector.x *= deceleration;
			if (vector.x < 0f)
			{
				vector.x = 0f;
			}
		}
		if (vector.y < 0f)
		{
			vector.y *= deceleration;
			if (vector.y > 0f)
			{
				vector.y = 0f;
			}
		}
		else if (vector.y > 0f)
		{
			vector.y *= deceleration;
			if (vector.y < 0f)
			{
				vector.y = 0f;
			}
		}
		this.body.velocity = vector;
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00035DF4 File Offset: 0x00033FF4
	private void DoBuzz(float waitMin, float waitMax, float speedMax, float accelerationMin, float accelerationMax, Vector2 roamingRange)
	{
		if (this.body == null)
		{
			return;
		}
		float num = 1.125f;
		if (this.CurrentState != this.LastFrameState)
		{
			this.startX = base.transform.position.x;
			this.startY = base.transform.position.y;
		}
		Vector2 velocity = this.body.velocity;
		if (base.transform.position.y < this.startY - roamingRange.y)
		{
			if (velocity.y < 0f)
			{
				this.accelY = accelerationMax;
				this.accelY /= 2000f;
				velocity.y /= num;
				this.waitTime = UnityEngine.Random.Range(waitMin, waitMax);
			}
		}
		else if (base.transform.position.y > this.startY + roamingRange.y && velocity.y > 0f)
		{
			this.accelY = -accelerationMax;
			this.accelY /= 2000f;
			velocity.y /= num;
			this.waitTime = UnityEngine.Random.Range(waitMin, waitMax);
		}
		if (base.transform.position.x < this.startX - roamingRange.x)
		{
			if (velocity.x < 0f)
			{
				this.accelX = accelerationMax;
				this.accelX /= 2000f;
				velocity.x /= num;
				this.waitTime = UnityEngine.Random.Range(waitMin, waitMax);
			}
		}
		else if (base.transform.position.x > this.startX + roamingRange.x && velocity.x > 0f)
		{
			this.accelX = -accelerationMax;
			this.accelX /= 2000f;
			velocity.x /= num;
			this.waitTime = UnityEngine.Random.Range(waitMin, waitMax);
		}
		if (this.waitTime <= Mathf.Epsilon)
		{
			if (base.transform.position.y < this.startY - roamingRange.y)
			{
				this.accelY = UnityEngine.Random.Range(accelerationMin, accelerationMax);
			}
			else if (base.transform.position.y > this.startY + roamingRange.y)
			{
				this.accelY = UnityEngine.Random.Range(-accelerationMax, accelerationMin);
			}
			else
			{
				this.accelY = UnityEngine.Random.Range(-accelerationMax, accelerationMax);
			}
			if (base.transform.position.x < this.startX - roamingRange.x)
			{
				this.accelX = UnityEngine.Random.Range(accelerationMin, accelerationMax);
			}
			else if (base.transform.position.x > this.startX + roamingRange.x)
			{
				this.accelX = UnityEngine.Random.Range(-accelerationMax, accelerationMin);
			}
			else
			{
				this.accelX = UnityEngine.Random.Range(-accelerationMax, accelerationMax);
			}
			this.accelY /= 2000f;
			this.accelX /= 2000f;
			this.waitTime = UnityEngine.Random.Range(waitMin, waitMax);
		}
		if (this.waitTime > Mathf.Epsilon)
		{
			this.waitTime -= Time.deltaTime;
		}
		velocity.x += this.accelX;
		velocity.y += this.accelY;
		if (velocity.x > speedMax)
		{
			velocity.x = speedMax;
		}
		if (velocity.x < -speedMax)
		{
			velocity.x = -speedMax;
		}
		if (velocity.y > speedMax)
		{
			velocity.y = speedMax;
		}
		if (velocity.y < -speedMax)
		{
			velocity.y = -speedMax;
		}
		this.body.velocity = velocity;
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x000361B0 File Offset: 0x000343B0
	private void DoChaseSimple(Transform target, float speedMax, float accelerationForce, float offsetX, float offsetY)
	{
		if (this.body == null)
		{
			return;
		}
		Vector2 vector = new Vector2(target.position.x + offsetX - base.transform.position.x, target.position.y + offsetY - base.transform.position.y);
		vector = Vector2.ClampMagnitude(vector, 1f);
		vector = new Vector2(vector.x * accelerationForce, vector.y * accelerationForce);
		this.body.AddForce(vector);
		Vector2 vector2 = this.body.velocity;
		vector2 = Vector2.ClampMagnitude(vector2, speedMax);
		this.body.velocity = vector2;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00036260 File Offset: 0x00034460
	public KnightHatchling()
	{
		this.groundColliders = new List<Collider2D>();
		this.normalDetails = new KnightHatchling.TypeDetails
		{
			damage = 9,
			dung = false,
			attackAnim = "Attack",
			flyAnim = "Fly",
			hatchAnim = "Hatch",
			teleEndAnim = "Tele End",
			teleStartAnim = "Tele Start",
			turnAttackAnim = "TurnToAttack",
			turnFlyAnim = "TurnToFly",
			restStartAnim = "Rest Start",
			restEndAnim = "Rest End",
			spatterColor = Color.black
		};
		this.dungDetails = new KnightHatchling.TypeDetails
		{
			damage = 4,
			dung = true,
			attackAnim = "D Attack",
			flyAnim = "D Fly",
			hatchAnim = "D Hatch",
			teleEndAnim = "D Tele End",
			teleStartAnim = "D Tele Start",
			turnAttackAnim = "D TurnToAttack",
			turnFlyAnim = "D TurnToFly",
			restStartAnim = "D Rest Start",
			restEndAnim = "D Rest End",
			spatterColor = new Color(0.749f, 0.522f, 0.353f)
		};
		this.explodeSound = new AudioEvent
		{
			PitchMin = 0.85f,
			PitchMax = 1.15f,
			Volume = 1f
		};
		this.dungExplodeSound = new AudioEvent
		{
			PitchMin = 0.9f,
			PitchMax = 1.1f,
			Volume = 1f
		};
		this.dungSleepPlopSound = new AudioEventRandom
		{
			PitchMin = 0.9f,
			PitchMax = 1.1f,
			Volume = 1f
		};
		base..ctor();
	}

	// Token: 0x04000AB9 RID: 2745
	public TriggerEnterEvent enemyRange;

	// Token: 0x04000ABA RID: 2746
	public TriggerEnterEvent groundRange;

	// Token: 0x04000ABB RID: 2747
	public Collider2D terrainCollider;

	// Token: 0x04000ABC RID: 2748
	private List<Collider2D> groundColliders;

	// Token: 0x04000ABD RID: 2749
	private GameObject target;

	// Token: 0x04000ABE RID: 2750
	public KnightHatchling.TypeDetails normalDetails;

	// Token: 0x04000ABF RID: 2751
	public KnightHatchling.TypeDetails dungDetails;

	// Token: 0x04000AC0 RID: 2752
	private KnightHatchling.TypeDetails details;

	// Token: 0x04000AC1 RID: 2753
	public ParticleSystem dungPt;

	// Token: 0x04000AC2 RID: 2754
	public AudioClip[] loopClips;

	// Token: 0x04000AC3 RID: 2755
	public AudioClip attackChargeClip;

	// Token: 0x04000AC4 RID: 2756
	public AudioSource audioSourcePrefab;

	// Token: 0x04000AC5 RID: 2757
	public AudioEvent explodeSound;

	// Token: 0x04000AC6 RID: 2758
	public AudioEvent dungExplodeSound;

	// Token: 0x04000AC7 RID: 2759
	public AudioEventRandom dungSleepPlopSound;

	// Token: 0x04000AC8 RID: 2760
	public GameObject dungExplosionPrefab;

	// Token: 0x04000AC9 RID: 2761
	private KnightHatchling.State currentState;

	// Token: 0x04000ACC RID: 2764
	private float targetRadius;

	// Token: 0x04000ACD RID: 2765
	private Vector3 offset;

	// Token: 0x04000ACE RID: 2766
	private float awayTimer;

	// Token: 0x04000ACF RID: 2767
	private float attackFinishTime;

	// Token: 0x04000AD0 RID: 2768
	private float benchRestWaitTime;

	// Token: 0x04000AD1 RID: 2769
	private bool quickSpawn;

	// Token: 0x04000AD2 RID: 2770
	private bool dreamSpawn;

	// Token: 0x04000AD3 RID: 2771
	private float startZ;

	// Token: 0x04000AD4 RID: 2772
	private float sleepZ;

	// Token: 0x04000AD5 RID: 2773
	public DamageEnemies damageEnemies;

	// Token: 0x04000AD6 RID: 2774
	private AudioSource audioSource;

	// Token: 0x04000AD7 RID: 2775
	private MeshRenderer meshRenderer;

	// Token: 0x04000AD8 RID: 2776
	private tk2dSpriteAnimator animator;

	// Token: 0x04000AD9 RID: 2777
	private Rigidbody2D body;

	// Token: 0x04000ADA RID: 2778
	private Collider2D col;

	// Token: 0x04000ADB RID: 2779
	private SpriteFlash spriteFlash;

	// Token: 0x04000ADC RID: 2780
	private float pauseTimer;

	// Token: 0x04000ADD RID: 2781
	private float xScale;

	// Token: 0x04000ADE RID: 2782
	private float startX;

	// Token: 0x04000ADF RID: 2783
	private float startY;

	// Token: 0x04000AE0 RID: 2784
	private float accelY;

	// Token: 0x04000AE1 RID: 2785
	private float accelX;

	// Token: 0x04000AE2 RID: 2786
	private float waitTime;

	// Token: 0x020001B7 RID: 439
	[Serializable]
	public struct TypeDetails
	{
		// Token: 0x04000AE3 RID: 2787
		public int damage;

		// Token: 0x04000AE4 RID: 2788
		public AudioEvent birthSound;

		// Token: 0x04000AE5 RID: 2789
		public Color spatterColor;

		// Token: 0x04000AE6 RID: 2790
		public bool dung;

		// Token: 0x04000AE7 RID: 2791
		public Transform groundPoint;

		// Token: 0x04000AE8 RID: 2792
		public string attackAnim;

		// Token: 0x04000AE9 RID: 2793
		public string flyAnim;

		// Token: 0x04000AEA RID: 2794
		public string hatchAnim;

		// Token: 0x04000AEB RID: 2795
		public string teleEndAnim;

		// Token: 0x04000AEC RID: 2796
		public string teleStartAnim;

		// Token: 0x04000AED RID: 2797
		public string turnAttackAnim;

		// Token: 0x04000AEE RID: 2798
		public string turnFlyAnim;

		// Token: 0x04000AEF RID: 2799
		public string restStartAnim;

		// Token: 0x04000AF0 RID: 2800
		public string restEndAnim;
	}

	// Token: 0x020001B8 RID: 440
	public enum State
	{
		// Token: 0x04000AF2 RID: 2802
		None,
		// Token: 0x04000AF3 RID: 2803
		Follow,
		// Token: 0x04000AF4 RID: 2804
		Tele,
		// Token: 0x04000AF5 RID: 2805
		Attack,
		// Token: 0x04000AF6 RID: 2806
		BenchRestStart,
		// Token: 0x04000AF7 RID: 2807
		BenchRestLower,
		// Token: 0x04000AF8 RID: 2808
		BenchResting
	}
}
