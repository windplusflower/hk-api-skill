using System;
using System.Collections;
using UnityEngine;

// Token: 0x020001CE RID: 462
public class SpellFluke : MonoBehaviour
{
	// Token: 0x06000A2B RID: 2603 RVA: 0x00037AE1 File Offset: 0x00035CE1
	private void Awake()
	{
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		this.meshRenderer = base.GetComponent<MeshRenderer>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.spriteFlash = base.GetComponent<SpriteFlash>();
		this.objectBounce = base.GetComponent<ObjectBounce>();
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00037B1F File Offset: 0x00035D1F
	private void Start()
	{
		this.damager.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
		{
			this.DoDamage(collider.gameObject, 2, true);
		};
		if (this.objectBounce)
		{
			this.objectBounce.OnBounce += delegate()
			{
				if (this.hasBursted)
				{
					return;
				}
				this.hasBounced = true;
				if (this.body)
				{
					Vector2 velocity = this.body.velocity;
					velocity.x = UnityEngine.Random.Range(-5f, 5f);
					velocity.y = Mathf.Clamp(velocity.y, UnityEngine.Random.Range(7.3f, 15f), UnityEngine.Random.Range(20f, 25f));
					this.body.velocity = velocity;
				}
				if (this.animator)
				{
					this.animator.Play(this.flopAnim);
				}
				base.transform.SetRotationZ(0f);
			};
		}
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00037B5C File Offset: 0x00035D5C
	private void DoDamage(GameObject obj, int upwardRecursionAmount, bool burst = true)
	{
		HealthManager component = obj.GetComponent<HealthManager>();
		if (component)
		{
			if (component.IsInvincible && obj.tag != "Spell Vulnerable")
			{
				return;
			}
			if (!component.isDead)
			{
				component.hp -= this.damage;
				if (component.hp <= 0)
				{
					component.Die(new float?(0f), AttackTypes.Generic, false);
				}
			}
		}
		SpriteFlash component2 = obj.GetComponent<SpriteFlash>();
		if (component2)
		{
			component2.FlashShadowRecharge();
		}
		FSMUtility.SendEventToGameObject(obj.gameObject, "TOOK DAMAGE", false);
		upwardRecursionAmount--;
		if (upwardRecursionAmount > 0 && obj.transform.parent)
		{
			this.DoDamage(obj.transform.parent.gameObject, upwardRecursionAmount, false);
		}
		if (burst)
		{
			this.Burst();
		}
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00037C30 File Offset: 0x00035E30
	private void OnEnable()
	{
		if (this.animator)
		{
			this.animator.Play(this.airAnim);
		}
		this.lifeEndTime = Time.time + UnityEngine.Random.Range(2f, 3f);
		if (this.meshRenderer)
		{
			this.meshRenderer.enabled = true;
		}
		if (this.body)
		{
			this.body.isKinematic = false;
		}
		if (GameManager.instance.playerData.GetBool("equippedCharm_19"))
		{
			float num = UnityEngine.Random.Range(0.9f, 1.2f);
			base.transform.localScale = new Vector3(num, num, 0f);
			this.damage = 5;
		}
		else
		{
			float num2 = UnityEngine.Random.Range(0.7f, 0.9f);
			base.transform.localScale = new Vector3(num2, num2, 0f);
			this.damage = 4;
		}
		if (this.spriteFlash)
		{
			this.spriteFlash.flashArmoured();
		}
		this.hasBounced = false;
		this.hasBursted = false;
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00037D44 File Offset: 0x00035F44
	private void Update()
	{
		if (this.hasBursted)
		{
			return;
		}
		if (!this.hasBounced)
		{
			Vector2 velocity = this.body.velocity;
			float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
			base.transform.localEulerAngles = new Vector3(0f, 0f, z);
		}
		if (Time.time >= this.lifeEndTime)
		{
			this.Burst();
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00037DB4 File Offset: 0x00035FB4
	private void Burst()
	{
		if (!this.hasBursted)
		{
			base.StartCoroutine(this.BurstSequence());
		}
		this.hasBursted = true;
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00037DD2 File Offset: 0x00035FD2
	private IEnumerator BurstSequence()
	{
		if (this.meshRenderer)
		{
			this.meshRenderer.enabled = false;
		}
		if (this.body)
		{
			this.body.velocity = Vector2.zero;
			this.body.angularVelocity = 0f;
			this.body.isKinematic = true;
		}
		if (this.splatEffect)
		{
			this.splatEffect.SetActive(true);
		}
		this.splatSounds.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		yield return new WaitForSeconds(1f);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00037DE1 File Offset: 0x00035FE1
	public SpellFluke()
	{
		this.airAnim = "Air";
		this.flopAnim = "Flop";
		base..ctor();
	}

	// Token: 0x04000B3F RID: 2879
	public string airAnim;

	// Token: 0x04000B40 RID: 2880
	public string flopAnim;

	// Token: 0x04000B41 RID: 2881
	public TriggerEnterEvent damager;

	// Token: 0x04000B42 RID: 2882
	public GameObject splatEffect;

	// Token: 0x04000B43 RID: 2883
	public AudioSource audioPlayerPrefab;

	// Token: 0x04000B44 RID: 2884
	public AudioEventRandom splatSounds;

	// Token: 0x04000B45 RID: 2885
	private float lifeEndTime;

	// Token: 0x04000B46 RID: 2886
	private int damage;

	// Token: 0x04000B47 RID: 2887
	private bool hasBounced;

	// Token: 0x04000B48 RID: 2888
	private bool hasBursted;

	// Token: 0x04000B49 RID: 2889
	private tk2dSpriteAnimator animator;

	// Token: 0x04000B4A RID: 2890
	private MeshRenderer meshRenderer;

	// Token: 0x04000B4B RID: 2891
	private Rigidbody2D body;

	// Token: 0x04000B4C RID: 2892
	private SpriteFlash spriteFlash;

	// Token: 0x04000B4D RID: 2893
	private ObjectBounce objectBounce;
}
