using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x0200019A RID: 410
public class HealthManager : MonoBehaviour, IHitResponder
{
	// Token: 0x1400000E RID: 14
	// (add) Token: 0x06000925 RID: 2341 RVA: 0x00032DD4 File Offset: 0x00030FD4
	// (remove) Token: 0x06000926 RID: 2342 RVA: 0x00032E0C File Offset: 0x0003100C
	public event HealthManager.DeathEvent OnDeath;

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000927 RID: 2343 RVA: 0x00032E41 File Offset: 0x00031041
	// (set) Token: 0x06000928 RID: 2344 RVA: 0x00032E49 File Offset: 0x00031049
	public bool IsInvincible
	{
		get
		{
			return this.invincible;
		}
		set
		{
			this.invincible = value;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000929 RID: 2345 RVA: 0x00032E52 File Offset: 0x00031052
	// (set) Token: 0x0600092A RID: 2346 RVA: 0x00032E5A File Offset: 0x0003105A
	public int InvincibleFromDirection
	{
		get
		{
			return this.invincibleFromDirection;
		}
		set
		{
			this.invincibleFromDirection = value;
		}
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00032E64 File Offset: 0x00031064
	protected void Awake()
	{
		this.boxCollider = base.GetComponent<BoxCollider2D>();
		this.recoil = base.GetComponent<Recoil>();
		this.hitEffectReceiver = base.GetComponent<IHitEffectReciever>();
		this.enemyDeathEffects = base.GetComponent<EnemyDeathEffects>();
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		this.sprite = base.GetComponent<tk2dSprite>();
		this.damageHero = base.GetComponent<DamageHero>();
		foreach (PlayMakerFSM playMakerFSM in base.gameObject.GetComponents<PlayMakerFSM>())
		{
			if (playMakerFSM.FsmName == "Stun Control" || playMakerFSM.FsmName == "Stun")
			{
				this.stunControlFSM = playMakerFSM;
				break;
			}
		}
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component != null)
		{
			component.OnGetSaveState += delegate(ref bool val)
			{
				if (GameManager.instance.GetCurrentMapZone() != "COLOSSEUM")
				{
					val = this.isDead;
				}
			};
			component.OnSetSaveState += delegate(bool val)
			{
				if (GameManager.instance.GetCurrentMapZone() != "COLOSSEUM" && val)
				{
					this.isDead = true;
					base.gameObject.SetActive(false);
				}
			};
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00032F44 File Offset: 0x00031144
	protected void OnEnable()
	{
		base.StartCoroutine("CheckPersistence");
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00032F54 File Offset: 0x00031154
	protected void Start()
	{
		this.evasionByHitRemaining = -1f;
		if (!string.IsNullOrEmpty(this.sendKilledToName))
		{
			this.sendKilledTo = GameObject.Find(this.sendKilledToName);
			if (this.sendKilledTo == null)
			{
				Debug.LogErrorFormat(this, "Failed to find GameObject '{0}' to send KILLED to.", new object[]
				{
					this.sendKilledToName
				});
			}
		}
		else if (this.sendKilledToObject != null)
		{
			this.sendKilledTo = this.sendKilledToObject;
		}
		int baseHP = this.hp;
		this.hp = this.hpScale.GetScaledHP(this.hp);
		BossSceneController.ReportHealth(this, baseHP, this.hp, false);
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00032FFA File Offset: 0x000311FA
	protected IEnumerator CheckPersistence()
	{
		HealthManager.<CheckPersistence>d__1 <CheckPersistence>d__ = new HealthManager.<CheckPersistence>d__1(0);
		<CheckPersistence>d__.<>4__this = this;
		return <CheckPersistence>d__;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00033009 File Offset: 0x00031209
	protected void Update()
	{
		this.evasionByHitRemaining -= Time.deltaTime;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00033020 File Offset: 0x00031220
	public void Hit(HitInstance hitInstance)
	{
		if (this.isDead)
		{
			return;
		}
		if (this.evasionByHitRemaining > 0f)
		{
			return;
		}
		if (hitInstance.DamageDealt <= 0)
		{
			return;
		}
		FSMUtility.SendEventToGameObject(hitInstance.Source, "DEALT DAMAGE", false);
		int cardinalDirection = DirectionUtils.GetCardinalDirection(hitInstance.GetActualDirection(base.transform));
		if (this.IsBlockingByDirection(cardinalDirection, hitInstance.AttackType))
		{
			this.Invincible(hitInstance);
			return;
		}
		this.TakeDamage(hitInstance);
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00033090 File Offset: 0x00031290
	private void Invincible(HitInstance hitInstance)
	{
		int cardinalDirection = DirectionUtils.GetCardinalDirection(hitInstance.GetActualDirection(base.transform));
		this.directionOfLastAttack = cardinalDirection;
		FSMUtility.SendEventToGameObject(base.gameObject, "BLOCKED HIT", false);
		FSMUtility.SendEventToGameObject(hitInstance.Source, "HIT LANDED", false);
		if (!(base.GetComponent<DontClinkGates>() != null))
		{
			FSMUtility.SendEventToGameObject(base.gameObject, "HIT", false);
			if (!this.preventInvincibleEffect)
			{
				if (hitInstance.AttackType == AttackTypes.Nail)
				{
					if (cardinalDirection == 0)
					{
						HeroController.instance.RecoilLeft();
					}
					else if (cardinalDirection == 2)
					{
						HeroController.instance.RecoilRight();
					}
				}
				GameManager.instance.FreezeMoment(1);
				GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
				Vector2 v;
				Vector3 eulerAngles;
				if (this.boxCollider != null)
				{
					switch (cardinalDirection)
					{
					case 0:
						v = new Vector2(base.transform.GetPositionX() + this.boxCollider.offset.x - this.boxCollider.size.x * 0.5f, hitInstance.Source.transform.GetPositionY());
						eulerAngles = new Vector3(0f, 0f, 0f);
						FSMUtility.SendEventToGameObject(base.gameObject, "BLOCKED HIT R", false);
						break;
					case 1:
						v = new Vector2(hitInstance.Source.transform.GetPositionX(), Mathf.Max(hitInstance.Source.transform.GetPositionY(), base.transform.GetPositionY() + this.boxCollider.offset.y - this.boxCollider.size.y * 0.5f));
						eulerAngles = new Vector3(0f, 0f, 90f);
						FSMUtility.SendEventToGameObject(base.gameObject, "BLOCKED HIT U", false);
						break;
					case 2:
						v = new Vector2(base.transform.GetPositionX() + this.boxCollider.offset.x + this.boxCollider.size.x * 0.5f, hitInstance.Source.transform.GetPositionY());
						eulerAngles = new Vector3(0f, 0f, 180f);
						FSMUtility.SendEventToGameObject(base.gameObject, "BLOCKED HIT L", false);
						break;
					case 3:
						v = new Vector2(hitInstance.Source.transform.GetPositionX(), Mathf.Min(hitInstance.Source.transform.GetPositionY(), base.transform.GetPositionY() + this.boxCollider.offset.y + this.boxCollider.size.y * 0.5f));
						eulerAngles = new Vector3(0f, 0f, 270f);
						FSMUtility.SendEventToGameObject(base.gameObject, "BLOCKED DOWN", false);
						break;
					default:
						v = base.transform.position;
						eulerAngles = new Vector3(0f, 0f, 0f);
						break;
					}
				}
				else
				{
					v = base.transform.position;
					eulerAngles = new Vector3(0f, 0f, 0f);
				}
				GameObject gameObject = this.blockHitPrefab.Spawn();
				gameObject.transform.position = v;
				gameObject.transform.eulerAngles = eulerAngles;
				if (this.hasAlternateInvincibleSound)
				{
					AudioSource component = base.GetComponent<AudioSource>();
					if (this.alternateInvincibleSound != null && component != null)
					{
						component.PlayOneShot(this.alternateInvincibleSound);
					}
				}
				else
				{
					this.regularInvincibleAudio.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
				}
			}
		}
		this.evasionByHitRemaining = 0.15f;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00033448 File Offset: 0x00031648
	private void TakeDamage(HitInstance hitInstance)
	{
		if (hitInstance.AttackType == AttackTypes.Acid && this.ignoreAcid)
		{
			return;
		}
		if (CheatManager.IsInstaKillEnabled)
		{
			hitInstance.DamageDealt = 9999;
		}
		int cardinalDirection = DirectionUtils.GetCardinalDirection(hitInstance.GetActualDirection(base.transform));
		this.directionOfLastAttack = cardinalDirection;
		FSMUtility.SendEventToGameObject(base.gameObject, "HIT", false);
		FSMUtility.SendEventToGameObject(hitInstance.Source, "HIT LANDED", false);
		FSMUtility.SendEventToGameObject(base.gameObject, "TOOK DAMAGE", false);
		if (this.sendHitTo != null)
		{
			FSMUtility.SendEventToGameObject(this.sendHitTo, "HIT", false);
		}
		if (this.recoil != null)
		{
			this.recoil.RecoilByDirection(cardinalDirection, hitInstance.MagnitudeMultiplier);
		}
		switch (hitInstance.AttackType)
		{
		case AttackTypes.Nail:
		case AttackTypes.NailBeam:
		{
			if (hitInstance.AttackType == AttackTypes.Nail && this.enemyType != 3 && this.enemyType != 6)
			{
				HeroController.instance.SoulGain();
			}
			Vector3 position = (hitInstance.Source.transform.position + base.transform.position) * 0.5f + this.effectOrigin;
			this.strikeNailPrefab.Spawn(position, Quaternion.identity);
			GameObject gameObject = this.slashImpactPrefab.Spawn(position, Quaternion.identity);
			switch (cardinalDirection)
			{
			case 0:
				gameObject.transform.SetRotation2D((float)UnityEngine.Random.Range(340, 380));
				gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
				break;
			case 1:
				gameObject.transform.SetRotation2D((float)UnityEngine.Random.Range(70, 110));
				gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
				break;
			case 2:
				gameObject.transform.SetRotation2D((float)UnityEngine.Random.Range(340, 380));
				gameObject.transform.localScale = new Vector3(-1.5f, 1.5f, 1f);
				break;
			case 3:
				gameObject.transform.SetRotation2D((float)UnityEngine.Random.Range(250, 290));
				gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
				break;
			}
			break;
		}
		case AttackTypes.Generic:
			this.strikeNailPrefab.Spawn(base.transform.position + this.effectOrigin, Quaternion.identity).transform.SetPositionZ(0.0031f);
			break;
		case AttackTypes.Spell:
			this.fireballHitPrefab.Spawn(base.transform.position + this.effectOrigin, Quaternion.identity).transform.SetPositionZ(0.0031f);
			break;
		case AttackTypes.SharpShadow:
			this.sharpShadowImpactPrefab.Spawn(base.transform.position + this.effectOrigin, Quaternion.identity);
			break;
		}
		if (this.hitEffectReceiver != null && hitInstance.AttackType != AttackTypes.RuinsWater)
		{
			this.hitEffectReceiver.RecieveHitEffect(hitInstance.GetActualDirection(base.transform));
		}
		int num = Mathf.RoundToInt((float)hitInstance.DamageDealt * hitInstance.Multiplier);
		if (this.damageOverride)
		{
			num = 1;
		}
		this.hp = Mathf.Max(this.hp - num, -50);
		if (this.hp > 0)
		{
			this.NonFatalHit(hitInstance.IgnoreInvulnerable);
			if (this.stunControlFSM)
			{
				this.stunControlFSM.SendEvent("STUN DAMAGE");
				return;
			}
		}
		else
		{
			this.Die(new float?(hitInstance.GetActualDirection(base.transform)), hitInstance.AttackType, hitInstance.IgnoreInvulnerable);
		}
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00033811 File Offset: 0x00031A11
	private void NonFatalHit(bool ignoreEvasion)
	{
		if (!ignoreEvasion)
		{
			if (this.hasAlternateHitAnimation)
			{
				if (this.animator != null)
				{
					this.animator.Play(this.alternateHitAnimation);
					return;
				}
			}
			else
			{
				this.evasionByHitRemaining = 0.2f;
			}
		}
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x0003384C File Offset: 0x00031A4C
	public void ApplyExtraDamage(int damageAmount)
	{
		FSMUtility.SendEventToGameObject(base.gameObject, "EXTRA DAMAGED", false);
		this.hp = Mathf.Max(this.hp - damageAmount, 0);
		if (this.hp <= 0)
		{
			this.Die(null, AttackTypes.Generic, true);
		}
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00033898 File Offset: 0x00031A98
	public void Die(float? attackDirection, AttackTypes attackType, bool ignoreEvasion)
	{
		if (this.isDead)
		{
			return;
		}
		if (this.sprite)
		{
			this.sprite.color = Color.white;
		}
		FSMUtility.SendEventToGameObject(base.gameObject, "ZERO HP", false);
		if (this.showGodfinderIcon)
		{
			GodfinderIcon.ShowIcon(this.showGodFinderDelay, this.unlockBossScene);
		}
		if (this.unlockBossScene && !GameManager.instance.playerData.GetVariable<List<string>>("unlockedBossScenes").Contains(this.unlockBossScene.name))
		{
			GameManager.instance.playerData.GetVariable<List<string>>("unlockedBossScenes").Add(this.unlockBossScene.name);
		}
		if (this.hasSpecialDeath)
		{
			this.NonFatalHit(ignoreEvasion);
			return;
		}
		this.isDead = true;
		if (this.damageHero != null)
		{
			this.damageHero.damageDealt = 0;
		}
		if (this.battleScene != null && !this.notifiedBattleScene)
		{
			PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(this.battleScene, "Battle Control");
			if (playMakerFSM != null)
			{
				FsmInt fsmInt = playMakerFSM.FsmVariables.GetFsmInt("Battle Enemies");
				if (fsmInt != null)
				{
					fsmInt.Value--;
					this.notifiedBattleScene = true;
				}
			}
		}
		if (this.deathAudioSnapshot != null)
		{
			this.deathAudioSnapshot.TransitionTo(6f);
		}
		if (this.sendKilledTo != null)
		{
			FSMUtility.SendEventToGameObject(this.sendKilledTo, "KILLED", false);
		}
		if (attackType == AttackTypes.Splatter)
		{
			GameCameras.instance.cameraShakeFSM.SendEvent("AverageShake");
			Debug.LogWarningFormat(this, "Instantiate!", Array.Empty<object>());
			UnityEngine.Object.Instantiate<GameObject>(this.corpseSplatPrefab, base.transform.position + this.effectOrigin, Quaternion.identity);
			if (this.enemyDeathEffects)
			{
				this.enemyDeathEffects.EmitSound();
			}
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (attackType != AttackTypes.RuinsWater)
		{
			float angleMin = (float)(this.megaFlingGeo ? 65 : 80);
			float angleMax = (float)(this.megaFlingGeo ? 115 : 100);
			float speedMin = (float)(this.megaFlingGeo ? 30 : 15);
			float speedMax = (float)(this.megaFlingGeo ? 45 : 30);
			int num = this.smallGeoDrops;
			int num2 = this.mediumGeoDrops;
			int num3 = this.largeGeoDrops;
			bool flag = false;
			if (GameManager.instance.playerData.GetBool("equippedCharm_24") && !GameManager.instance.playerData.GetBool("brokenCharm_24"))
			{
				num += Mathf.CeilToInt((float)num * 0.2f);
				num2 += Mathf.CeilToInt((float)num2 * 0.2f);
				num3 += Mathf.CeilToInt((float)num3 * 0.2f);
				flag = true;
			}
			GameObject[] gameObjects = FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.smallGeoPrefab,
				AmountMin = num,
				AmountMax = num,
				SpeedMin = speedMin,
				SpeedMax = speedMax,
				AngleMin = angleMin,
				AngleMax = angleMax
			}, base.transform, this.effectOrigin);
			if (flag)
			{
				this.SetGeoFlashing(gameObjects, this.smallGeoDrops);
			}
			gameObjects = FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.mediumGeoPrefab,
				AmountMin = num2,
				AmountMax = num2,
				SpeedMin = speedMin,
				SpeedMax = speedMax,
				AngleMin = angleMin,
				AngleMax = angleMax
			}, base.transform, this.effectOrigin);
			if (flag)
			{
				this.SetGeoFlashing(gameObjects, this.mediumGeoDrops);
			}
			gameObjects = FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.largeGeoPrefab,
				AmountMin = num3,
				AmountMax = num3,
				SpeedMin = speedMin,
				SpeedMax = speedMax,
				AngleMin = angleMin,
				AngleMax = angleMax
			}, base.transform, this.effectOrigin);
			if (flag)
			{
				this.SetGeoFlashing(gameObjects, this.largeGeoDrops);
			}
		}
		if (this.enemyDeathEffects != null)
		{
			if (attackType == AttackTypes.RuinsWater || attackType == AttackTypes.Acid || attackType == AttackTypes.Generic)
			{
				this.enemyDeathEffects.doKillFreeze = false;
			}
			this.enemyDeathEffects.RecieveDeathEvent(attackDirection, this.deathReset, attackType == AttackTypes.Spell, attackType == AttackTypes.RuinsWater || attackType == AttackTypes.Acid);
		}
		this.SendDeathEvent();
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00033CEF File Offset: 0x00031EEF
	public void SendDeathEvent()
	{
		if (this.OnDeath != null)
		{
			this.OnDeath();
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00033D04 File Offset: 0x00031F04
	private void SetGeoFlashing(GameObject[] gameObjects, int originalAmount)
	{
		for (int i = gameObjects.Length - 1; i >= originalAmount; i--)
		{
			GeoControl component = gameObjects[i].GetComponent<GeoControl>();
			if (component)
			{
				component.SetFlashing();
			}
		}
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00033D38 File Offset: 0x00031F38
	public bool IsBlockingByDirection(int cardinalDirection, AttackTypes attackType)
	{
		if ((attackType == AttackTypes.Spell || attackType == AttackTypes.SharpShadow) && base.gameObject.CompareTag("Spell Vulnerable"))
		{
			return false;
		}
		if (!this.invincible)
		{
			return false;
		}
		if (this.invincibleFromDirection == 0)
		{
			return true;
		}
		switch (cardinalDirection)
		{
		case 0:
		{
			int num = this.invincibleFromDirection;
			if (num <= 5)
			{
				if (num != 1 && num != 5)
				{
					return false;
				}
			}
			else if (num != 8 && num != 10)
			{
				return false;
			}
			return true;
		}
		case 1:
		{
			int num = this.invincibleFromDirection;
			return num == 2 || num - 5 <= 4;
		}
		case 2:
		{
			int num = this.invincibleFromDirection;
			if (num <= 6)
			{
				if (num != 3 && num != 6)
				{
					return false;
				}
			}
			else if (num != 9 && num != 11)
			{
				return false;
			}
			return true;
		}
		case 3:
		{
			int num = this.invincibleFromDirection;
			return num == 4 || num - 7 <= 4;
		}
		default:
			return false;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00033E00 File Offset: 0x00032000
	public void SetBattleScene(GameObject newBattleScene)
	{
		this.battleScene = newBattleScene;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00033E09 File Offset: 0x00032009
	public int GetAttackDirection()
	{
		return this.directionOfLastAttack;
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00033E11 File Offset: 0x00032011
	public void SetPreventInvincibleEffect(bool set)
	{
		this.preventInvincibleEffect = set;
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00033E1A File Offset: 0x0003201A
	public void SetGeoSmall(int amount)
	{
		this.smallGeoDrops = amount;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00033E23 File Offset: 0x00032023
	public void SetGeoMedium(int amount)
	{
		this.mediumGeoDrops = amount;
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00033E2C File Offset: 0x0003202C
	public void SetGeoLarge(int amount)
	{
		this.largeGeoDrops = amount;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00033E35 File Offset: 0x00032035
	public bool GetIsDead()
	{
		return this.isDead;
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00033E3D File Offset: 0x0003203D
	public void SetIsDead(bool set)
	{
		this.isDead = set;
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00033E46 File Offset: 0x00032046
	public void SetDamageOverride(bool set)
	{
		this.damageOverride = set;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00033E4F File Offset: 0x0003204F
	public void SetSendKilledToObject(GameObject killedObject)
	{
		if (killedObject != null)
		{
			this.sendKilledToObject = killedObject;
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00032E41 File Offset: 0x00031041
	public bool CheckInvincible()
	{
		return this.invincible;
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00033E61 File Offset: 0x00032061
	public HealthManager()
	{
		this.showGodFinderDelay = 7f;
		base..ctor();
	}

	// Token: 0x04000A37 RID: 2615
	private BoxCollider2D boxCollider;

	// Token: 0x04000A38 RID: 2616
	private Recoil recoil;

	// Token: 0x04000A39 RID: 2617
	private IHitEffectReciever hitEffectReceiver;

	// Token: 0x04000A3A RID: 2618
	private EnemyDeathEffects enemyDeathEffects;

	// Token: 0x04000A3B RID: 2619
	private tk2dSpriteAnimator animator;

	// Token: 0x04000A3C RID: 2620
	private tk2dSprite sprite;

	// Token: 0x04000A3D RID: 2621
	private DamageHero damageHero;

	// Token: 0x04000A3E RID: 2622
	[Header("Assets")]
	[SerializeField]
	private AudioSource audioPlayerPrefab;

	// Token: 0x04000A3F RID: 2623
	[SerializeField]
	private AudioEvent regularInvincibleAudio;

	// Token: 0x04000A40 RID: 2624
	[SerializeField]
	private GameObject blockHitPrefab;

	// Token: 0x04000A41 RID: 2625
	[SerializeField]
	private GameObject strikeNailPrefab;

	// Token: 0x04000A42 RID: 2626
	[SerializeField]
	private GameObject slashImpactPrefab;

	// Token: 0x04000A43 RID: 2627
	[SerializeField]
	private GameObject fireballHitPrefab;

	// Token: 0x04000A44 RID: 2628
	[SerializeField]
	private GameObject sharpShadowImpactPrefab;

	// Token: 0x04000A45 RID: 2629
	[SerializeField]
	private GameObject corpseSplatPrefab;

	// Token: 0x04000A46 RID: 2630
	[SerializeField]
	private AudioEvent enemyDeathSwordAudio;

	// Token: 0x04000A47 RID: 2631
	[SerializeField]
	private AudioEvent enemyDamageAudio;

	// Token: 0x04000A48 RID: 2632
	[SerializeField]
	private GameObject smallGeoPrefab;

	// Token: 0x04000A49 RID: 2633
	[SerializeField]
	private GameObject mediumGeoPrefab;

	// Token: 0x04000A4A RID: 2634
	[SerializeField]
	private GameObject largeGeoPrefab;

	// Token: 0x04000A4B RID: 2635
	[Header("Body")]
	[SerializeField]
	public int hp;

	// Token: 0x04000A4C RID: 2636
	[SerializeField]
	private int enemyType;

	// Token: 0x04000A4D RID: 2637
	[SerializeField]
	private Vector3 effectOrigin;

	// Token: 0x04000A4E RID: 2638
	[SerializeField]
	private bool ignoreKillAll;

	// Token: 0x04000A4F RID: 2639
	[SerializeField]
	[Space]
	[UnityEngine.Tooltip("HP is scaled if in a GG boss scene (These are absolute values, not a multiplier. Leave 0 for no scaling).")]
	private HealthManager.HPScaleGG hpScale;

	// Token: 0x04000A50 RID: 2640
	[Header("Scene")]
	[SerializeField]
	private GameObject battleScene;

	// Token: 0x04000A51 RID: 2641
	[SerializeField]
	private GameObject sendHitTo;

	// Token: 0x04000A52 RID: 2642
	[SerializeField]
	private GameObject sendKilledToObject;

	// Token: 0x04000A53 RID: 2643
	[SerializeField]
	private string sendKilledToName;

	// Token: 0x04000A54 RID: 2644
	[Header("Geo")]
	[SerializeField]
	private int smallGeoDrops;

	// Token: 0x04000A55 RID: 2645
	[SerializeField]
	private int mediumGeoDrops;

	// Token: 0x04000A56 RID: 2646
	[SerializeField]
	private int largeGeoDrops;

	// Token: 0x04000A57 RID: 2647
	[SerializeField]
	private bool megaFlingGeo;

	// Token: 0x04000A58 RID: 2648
	[Header("Hit")]
	[SerializeField]
	private bool hasAlternateHitAnimation;

	// Token: 0x04000A59 RID: 2649
	[SerializeField]
	private string alternateHitAnimation;

	// Token: 0x04000A5A RID: 2650
	[Header("Invincible")]
	[SerializeField]
	private bool invincible;

	// Token: 0x04000A5B RID: 2651
	[SerializeField]
	private int invincibleFromDirection;

	// Token: 0x04000A5C RID: 2652
	[SerializeField]
	private bool preventInvincibleEffect;

	// Token: 0x04000A5D RID: 2653
	[SerializeField]
	private bool hasAlternateInvincibleSound;

	// Token: 0x04000A5E RID: 2654
	[SerializeField]
	private AudioClip alternateInvincibleSound;

	// Token: 0x04000A5F RID: 2655
	[Header("Death")]
	[SerializeField]
	private AudioMixerSnapshot deathAudioSnapshot;

	// Token: 0x04000A60 RID: 2656
	[SerializeField]
	public bool hasSpecialDeath;

	// Token: 0x04000A61 RID: 2657
	[SerializeField]
	public bool deathReset;

	// Token: 0x04000A62 RID: 2658
	[SerializeField]
	public bool damageOverride;

	// Token: 0x04000A63 RID: 2659
	[SerializeField]
	private bool ignoreAcid;

	// Token: 0x04000A64 RID: 2660
	[Space]
	[SerializeField]
	private bool showGodfinderIcon;

	// Token: 0x04000A65 RID: 2661
	[SerializeField]
	private float showGodFinderDelay;

	// Token: 0x04000A66 RID: 2662
	[SerializeField]
	private BossScene unlockBossScene;

	// Token: 0x04000A68 RID: 2664
	[Header("Deprecated/Unusued Variables")]
	[SerializeField]
	private bool ignoreHazards;

	// Token: 0x04000A69 RID: 2665
	[SerializeField]
	private bool ignoreWater;

	// Token: 0x04000A6A RID: 2666
	[SerializeField]
	private float invulnerableTime;

	// Token: 0x04000A6B RID: 2667
	[SerializeField]
	private bool semiPersistent;

	// Token: 0x04000A6C RID: 2668
	public bool isDead;

	// Token: 0x04000A6D RID: 2669
	private GameObject sendKilledTo;

	// Token: 0x04000A6E RID: 2670
	private float evasionByHitRemaining;

	// Token: 0x04000A6F RID: 2671
	private int directionOfLastAttack;

	// Token: 0x04000A70 RID: 2672
	private PlayMakerFSM stunControlFSM;

	// Token: 0x04000A71 RID: 2673
	private bool notifiedBattleScene;

	// Token: 0x04000A72 RID: 2674
	private const string CheckPersistenceKey = "CheckPersistence";

	// Token: 0x0200019B RID: 411
	[Serializable]
	private struct HPScaleGG
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x00033EC4 File Offset: 0x000320C4
		public int GetScaledHP(int originalHP)
		{
			if (BossSceneController.IsBossScene)
			{
				switch (BossSceneController.Instance.BossLevel)
				{
				case 0:
					if (this.level1 <= 0)
					{
						return originalHP;
					}
					return this.level1;
				case 1:
					if (this.level2 <= 0)
					{
						return originalHP;
					}
					return this.level2;
				case 2:
					if (this.level3 <= 0)
					{
						return originalHP;
					}
					return this.level3;
				}
			}
			return originalHP;
		}

		// Token: 0x04000A73 RID: 2675
		public int level1;

		// Token: 0x04000A74 RID: 2676
		public int level2;

		// Token: 0x04000A75 RID: 2677
		public int level3;
	}

	// Token: 0x0200019C RID: 412
	// (Invoke) Token: 0x06000949 RID: 2377
	public delegate void DeathEvent();
}
