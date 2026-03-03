using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003E3 RID: 995
public class ScuttlerControl : MonoBehaviour, IHitResponder
{
	// Token: 0x060016AA RID: 5802 RVA: 0x0006B2C7 File Offset: 0x000694C7
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0006B2F0 File Offset: 0x000694F0
	private void Start()
	{
		base.transform.SetScaleMatching(UnityEngine.Random.Range(1.35f, 1.5f));
		this.maxSpeed = UnityEngine.Random.Range(6f, 9f);
		this.hero = HeroController.instance.transform;
		this.activateTime = Time.time + this.activateDelay;
		Collider2D component = base.GetComponent<Collider2D>();
		if (component)
		{
			this.rayLength = component.bounds.size.x / 2f + 0.1f;
			this.rayOrigin = component.bounds.center - base.transform.position;
		}
		this.source.enabled = false;
		if (this.healthScuttler)
		{
			this.reverseRun = GameManager.instance.playerData.GetBool("equippedCharm_27");
		}
		if (!this.startRunning && !this.startIdle)
		{
			CollisionEnterEvent componentInChildren = base.GetComponentInChildren<CollisionEnterEvent>();
			if (componentInChildren)
			{
				componentInChildren.OnCollisionEnteredDirectional += delegate(CollisionEnterEvent.Direction direction, Collision2D collision)
				{
					if (!this.landed && direction == CollisionEnterEvent.Direction.Bottom)
					{
						this.landed = true;
						base.StartCoroutine(this.Land());
					}
				};
				return;
			}
		}
		else
		{
			if (this.startIdle && this.heroAlert)
			{
				this.heroAlert.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
				{
					if (!this.landed && collider.tag == "Player")
					{
						this.landed = true;
						base.StartCoroutine(this.Land());
					}
				};
				return;
			}
			if (this.startRunning)
			{
				this.runRoutine = base.StartCoroutine(this.Run());
			}
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x0006B454 File Offset: 0x00069654
	private void Update()
	{
		if (!this.alive)
		{
			return;
		}
		if (Physics2D.Raycast(base.transform.position + this.rayOrigin, new Vector2(Mathf.Sign(this.body.velocity.x), 0f), this.rayLength, 256).collider != null && this.bounceRoutine == null && this.runRoutine != null)
		{
			base.StopCoroutine(this.runRoutine);
			this.bounceRoutine = base.StartCoroutine((this.body.velocity.x > 0f) ? this.Bounce(110f, 130f) : this.Bounce(50f, 70f));
		}
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x0006B525 File Offset: 0x00069725
	private IEnumerator Land()
	{
		yield return this.StartCoroutine(this.anim.PlayAnimWait(this.landAnim));
		this.source.enabled = true;
		this.runRoutine = this.StartCoroutine(this.Run());
		yield break;
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x0006B534 File Offset: 0x00069734
	private IEnumerator Run()
	{
		this.anim.Play(this.runAnim);
		this.source.enabled = true;
		Vector3 velocity = this.body.velocity;
		for (;;)
		{
			float num = Mathf.Sign(this.hero.position.x - this.transform.position.x) * (float)(this.reverseRun ? -1 : 1);
			float currentDirection = num;
			this.transform.SetScaleX(Mathf.Abs(this.transform.localScale.x) * num);
			while (currentDirection == num)
			{
				velocity.x += this.acceleration * -num;
				velocity.x = Mathf.Clamp(velocity.x, -this.maxSpeed, this.maxSpeed);
				velocity.y = this.body.velocity.y;
				this.body.velocity = velocity;
				yield return null;
				num = Mathf.Sign(this.hero.position.x - this.transform.position.x) * (float)(this.reverseRun ? -1 : 1);
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x0006B543 File Offset: 0x00069743
	private IEnumerator Bounce(float angleMin, float angleMax)
	{
		this.source.enabled = false;
		this.bounceSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		Vector2 zero = Vector2.zero;
		float num = UnityEngine.Random.Range(angleMin, angleMax);
		zero.x = 5f * Mathf.Cos(num * 0.017453292f);
		zero.y = 5f * Mathf.Sin(num * 0.017453292f);
		this.body.velocity = zero;
		yield return new WaitForSeconds(0.5f);
		this.source.enabled = true;
		this.bounceRoutine = null;
		this.runRoutine = this.StartCoroutine(this.Run());
		yield break;
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x0006B560 File Offset: 0x00069760
	private IEnumerator Heal()
	{
		GameManager.UnloadLevel doHeal = null;
		doHeal = delegate()
		{
			EventRegister.SendEvent("ADD BLUE HEALTH");
			GameManager.instance.UnloadingLevel -= doHeal;
			doHeal = null;
		};
		GameManager.instance.UnloadingLevel += doHeal;
		if (HeroController.instance && Vector2.Distance(this.transform.position, HeroController.instance.transform.position) > 40f)
		{
			this.gameObject.SetActive(false);
		}
		yield return new WaitForSeconds(1.2f);
		if (this.screenFlash)
		{
			GameObject gameObject = this.screenFlash.Spawn();
			gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0f, 0.7f, 1f));
			PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(gameObject, "Fade Away");
			if (playMakerFSM)
			{
				FSMUtility.SetFloat(playMakerFSM, "Alpha", 0.75f);
			}
		}
		if (doHeal != null)
		{
			doHeal();
		}
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0006B570 File Offset: 0x00069770
	public void Hit(HitInstance damageInstance)
	{
		if (Time.time < this.activateTime)
		{
			return;
		}
		if (this.alive)
		{
			this.alive = false;
			if (this.runRoutine != null)
			{
				base.StopCoroutine(this.runRoutine);
			}
			if (this.bounceRoutine != null)
			{
				base.StopCoroutine(this.bounceRoutine);
			}
			if (this.corpsePrefab)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.corpsePrefab, base.transform.position, base.transform.rotation);
			}
			if (this.splatEffectChild)
			{
				this.splatEffectChild.SetActive(true);
			}
			PlayerData playerData = GameManager.instance.playerData;
			if (playerData.GetBool("hasJournal"))
			{
				if (!playerData.GetBool(this.killedPDBool))
				{
					playerData.SetBool(this.killedPDBool, true);
					if (this.journalUpdateMsgPrefab)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.journalUpdateMsgPrefab);
					}
				}
				int num = playerData.GetInt(this.killsPDBool);
				if (num > 0)
				{
					num--;
					playerData.SetInt(this.killsPDBool, num);
					if (num <= 0 && this.journalUpdateMsgPrefab)
					{
						PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(UnityEngine.Object.Instantiate<GameObject>(this.journalUpdateMsgPrefab), "Journal Msg");
						if (playMakerFSM)
						{
							FSMUtility.SetBool(playMakerFSM, "Full", true);
						}
					}
				}
				playerData.SetBool(this.newDataPDBool, true);
			}
			bool flag = false;
			if (!this.healthScuttler)
			{
				base.gameObject.SetActive(false);
				return;
			}
			if (damageInstance.AttackType == AttackTypes.Nail)
			{
				flag = true;
				if (this.strikeNailPrefab)
				{
					this.strikeNailPrefab.Spawn(base.transform.position);
				}
				if (this.slashImpactPrefab)
				{
					GameObject gameObject = this.slashImpactPrefab.Spawn(base.transform.position);
					float direction = damageInstance.Direction;
					if (direction < 45f)
					{
						gameObject.transform.SetRotation2D(UnityEngine.Random.Range(340f, 380f));
						gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
					}
					else if (direction < 135f)
					{
						gameObject.transform.SetRotation2D(UnityEngine.Random.Range(70f, 110f));
						gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
					}
					else if (direction < 225f)
					{
						gameObject.transform.SetRotation2D(UnityEngine.Random.Range(340f, 380f));
						gameObject.transform.localScale = new Vector3(-0.9f, 0.9f, 1f);
					}
					else if (direction < 360f)
					{
						gameObject.transform.SetRotation2D(UnityEngine.Random.Range(250f, 290f));
						gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
					}
				}
			}
			else if (damageInstance.AttackType == AttackTypes.Spell || damageInstance.AttackType == AttackTypes.NailBeam)
			{
				flag = true;
				if (this.fireballHitPrefab)
				{
					GameObject gameObject2 = this.fireballHitPrefab.Spawn(base.transform.position);
					gameObject2.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
					gameObject2.transform.SetPositionZ(0.0031f);
				}
			}
			else if (damageInstance.AttackType == AttackTypes.Generic)
			{
				flag = true;
			}
			this.deathSound1.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
			this.deathSound2.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
			GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
			if (gameCameras)
			{
				gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
			}
			GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 12, 18, 4f, 22f, 30f, 150f, new Color?(this.bloodColor));
			Renderer component = base.GetComponent<Renderer>();
			if (component)
			{
				component.enabled = false;
			}
			if (flag)
			{
				if (this.pool)
				{
					this.pool.transform.SetPositionZ(-0.2f);
					FlingUtils.FlingChildren(new FlingUtils.ChildrenConfig
					{
						Parent = this.pool,
						AmountMin = 8,
						AmountMax = 10,
						SpeedMin = 15f,
						SpeedMax = 20f,
						AngleMin = 30f,
						AngleMax = 150f,
						OriginVariationX = 0f,
						OriginVariationY = 0f
					}, base.transform, Vector3.zero);
				}
				base.StartCoroutine(this.Heal());
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0006BA48 File Offset: 0x00069C48
	public ScuttlerControl()
	{
		this.killedPDBool = "killedOrangeScuttler";
		this.killsPDBool = "killsOrangeScuttler";
		this.newDataPDBool = "newDataOrangeScuttler";
		this.runAnim = "Run";
		this.landAnim = "Land";
		this.acceleration = 0.3f;
		this.alive = true;
		this.activateDelay = 0.25f;
		base..ctor();
	}

	// Token: 0x04001B45 RID: 6981
	[Header("Instance Variables")]
	public bool startIdle;

	// Token: 0x04001B46 RID: 6982
	public bool startRunning;

	// Token: 0x04001B47 RID: 6983
	[Header("Other Variables")]
	public string killedPDBool;

	// Token: 0x04001B48 RID: 6984
	public string killsPDBool;

	// Token: 0x04001B49 RID: 6985
	public string newDataPDBool;

	// Token: 0x04001B4A RID: 6986
	[Space]
	public string runAnim;

	// Token: 0x04001B4B RID: 6987
	public string landAnim;

	// Token: 0x04001B4C RID: 6988
	[Space]
	public GameObject corpsePrefab;

	// Token: 0x04001B4D RID: 6989
	public GameObject splatEffectChild;

	// Token: 0x04001B4E RID: 6990
	public GameObject journalUpdateMsgPrefab;

	// Token: 0x04001B4F RID: 6991
	[Space]
	public AudioSource audioSourcePrefab;

	// Token: 0x04001B50 RID: 6992
	public AudioEvent bounceSound;

	// Token: 0x04001B51 RID: 6993
	public TriggerEnterEvent heroAlert;

	// Token: 0x04001B52 RID: 6994
	[Space]
	public bool healthScuttler;

	// Token: 0x04001B53 RID: 6995
	[Header("Health Scuttler Variables")]
	public GameObject strikeNailPrefab;

	// Token: 0x04001B54 RID: 6996
	public GameObject slashImpactPrefab;

	// Token: 0x04001B55 RID: 6997
	public GameObject fireballHitPrefab;

	// Token: 0x04001B56 RID: 6998
	public AudioEvent deathSound1;

	// Token: 0x04001B57 RID: 6999
	public AudioEvent deathSound2;

	// Token: 0x04001B58 RID: 7000
	public GameObject pool;

	// Token: 0x04001B59 RID: 7001
	public GameObject screenFlash;

	// Token: 0x04001B5A RID: 7002
	public Color bloodColor;

	// Token: 0x04001B5B RID: 7003
	private Transform hero;

	// Token: 0x04001B5C RID: 7004
	private float maxSpeed;

	// Token: 0x04001B5D RID: 7005
	private float acceleration;

	// Token: 0x04001B5E RID: 7006
	private bool landed;

	// Token: 0x04001B5F RID: 7007
	private Coroutine runRoutine;

	// Token: 0x04001B60 RID: 7008
	private Coroutine bounceRoutine;

	// Token: 0x04001B61 RID: 7009
	private float rayLength;

	// Token: 0x04001B62 RID: 7010
	private Vector2 rayOrigin;

	// Token: 0x04001B63 RID: 7011
	private tk2dSpriteAnimator anim;

	// Token: 0x04001B64 RID: 7012
	private Rigidbody2D body;

	// Token: 0x04001B65 RID: 7013
	private AudioSource source;

	// Token: 0x04001B66 RID: 7014
	private bool alive;

	// Token: 0x04001B67 RID: 7015
	private bool reverseRun;

	// Token: 0x04001B68 RID: 7016
	private float activateDelay;

	// Token: 0x04001B69 RID: 7017
	private float activateTime;
}
