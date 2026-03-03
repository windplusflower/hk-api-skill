using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003F5 RID: 1013
public class VinePlatform : MonoBehaviour
{
	// Token: 0x06001712 RID: 5906 RVA: 0x0006D649 File Offset: 0x0006B849
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
		this.body = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x0006D664 File Offset: 0x0006B864
	private void Start()
	{
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component)
		{
			component.OnGetSaveState += delegate(ref bool value)
			{
				value = this.activated;
			};
			component.OnSetSaveState += delegate(bool value)
			{
				this.activated = value;
				if (this.activated)
				{
					this.platformSprite.SetActive(false);
					this.activatedSprite.SetActive(true);
					if (this.landingDetector)
					{
						this.landingDetector.gameObject.SetActive(false);
					}
					if (this.collider)
					{
						this.collider.enabled = false;
					}
				}
			};
		}
		if (this.landingDetector && !this.acidLander)
		{
			this.landingDetector.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
			{
				this.Land();
			};
		}
		if (this.enemyDetector)
		{
			this.enemyDetector.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
			{
				HealthManager component2 = collider.GetComponent<HealthManager>();
				if (component2)
				{
					component2.Die(new float?(0f), AttackTypes.Splatter, false);
				}
			};
			this.enemyDetector.gameObject.SetActive(false);
		}
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x0006D718 File Offset: 0x0006B918
	private void Update()
	{
		if (this.acidLander && !this.activated && this.collider.bounds.min.y <= this.acidTargetY)
		{
			this.Land();
		}
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x0006D75C File Offset: 0x0006B95C
	private void Land()
	{
		this.PlaySound(this.landSound);
		if (!this.acidLander)
		{
			GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
			if (gameCameras)
			{
				gameCameras.cameraShakeFSM.SendEvent("AverageShake");
			}
			foreach (ParticleSystem particleSystem in this.landParticles)
			{
				if (particleSystem.gameObject.activeInHierarchy)
				{
					particleSystem.Play();
				}
			}
			if (this.slamEffect)
			{
				this.slamEffect.SetActive(true);
			}
		}
		else
		{
			this.PlaySound(this.acidSplashSound);
			if (this.acidSplashPrefab)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.acidSplashPrefab, new Vector3(base.transform.position.x, this.collider.bounds.min.y, base.transform.position.z), Quaternion.identity);
			}
			float num = base.transform.position.y - this.collider.bounds.min.y;
			base.transform.SetPositionY(this.acidTargetY + num);
		}
		if (this.body)
		{
			this.body.isKinematic = true;
			this.body.velocity = Vector2.zero;
		}
		if (this.enemyDetector)
		{
			this.enemyDetector.gameObject.SetActive(false);
		}
		this.activated = true;
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x0006D8E0 File Offset: 0x0006BAE0
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.respondOnLand && collision.gameObject.layer == 9 && collision.collider.bounds.min.y >= this.collider.bounds.max.y)
		{
			if (this.landRoutine != null)
			{
				base.StopCoroutine(this.landRoutine);
			}
			if (this.landReturnAction != null)
			{
				this.landReturnAction();
			}
			this.landRoutine = base.StartCoroutine(this.PlayerLand());
			return;
		}
		if (!this.body.isKinematic && collision.gameObject.layer != 8 && collision.gameObject.layer != 9)
		{
			Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
		}
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x0006D9AE File Offset: 0x0006BBAE
	private void PlaySound(AudioClip clip)
	{
		if (this.audioSource && clip)
		{
			this.audioSource.PlayOneShot(clip);
		}
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0006D9D1 File Offset: 0x0006BBD1
	private IEnumerator PlayerLand()
	{
		this.PlaySound(this.playerLandSound);
		if (this.playerLandParticles)
		{
			this.playerLandParticles.Play();
		}
		if (this.platformSprite)
		{
			Vector3 initialPos = this.platformSprite.transform.position;
			this.landReturnAction = delegate()
			{
				this.platformSprite.transform.position = initialPos;
			};
			for (float elapsed = 0f; elapsed < this.playerLandAnimLength; elapsed += Time.deltaTime)
			{
				Vector3 initialPos2 = initialPos;
				initialPos2.y += this.playerLandAnimCurve.Evaluate(elapsed / this.playerLandAnimLength);
				this.platformSprite.transform.position = initialPos2;
				yield return null;
			}
		}
		if (this.landReturnAction != null)
		{
			this.landReturnAction();
		}
		this.landRoutine = null;
		yield break;
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0006D9E0 File Offset: 0x0006BBE0
	private void OnDrawGizmosSelected()
	{
		if (this.acidLander)
		{
			Vector3 position = base.transform.position;
			position.y = this.acidTargetY;
			Gizmos.DrawWireSphere(position, 0.5f);
		}
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x0006DA1C File Offset: 0x0006BC1C
	public VinePlatform()
	{
		this.playerLandAnimCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(0.5f, 1f),
			new Keyframe(1f, 0f)
		});
		this.playerLandAnimLength = 0.5f;
		this.respondOnLand = true;
		base..ctor();
	}

	// Token: 0x04001BD4 RID: 7124
	public GameObject platformSprite;

	// Token: 0x04001BD5 RID: 7125
	public GameObject activatedSprite;

	// Token: 0x04001BD6 RID: 7126
	public Collider2D collider;

	// Token: 0x04001BD7 RID: 7127
	[Space]
	public AudioClip playerLandSound;

	// Token: 0x04001BD8 RID: 7128
	public ParticleSystem playerLandParticles;

	// Token: 0x04001BD9 RID: 7129
	public AnimationCurve playerLandAnimCurve;

	// Token: 0x04001BDA RID: 7130
	public float playerLandAnimLength;

	// Token: 0x04001BDB RID: 7131
	[HideInInspector]
	public Coroutine landRoutine;

	// Token: 0x04001BDC RID: 7132
	[HideInInspector]
	public bool respondOnLand;

	// Token: 0x04001BDD RID: 7133
	private Action landReturnAction;

	// Token: 0x04001BDE RID: 7134
	[Space]
	public TriggerEnterEvent landingDetector;

	// Token: 0x04001BDF RID: 7135
	public AudioClip landSound;

	// Token: 0x04001BE0 RID: 7136
	public ParticleSystem[] landParticles;

	// Token: 0x04001BE1 RID: 7137
	public GameObject slamEffect;

	// Token: 0x04001BE2 RID: 7138
	[Space]
	public TriggerEnterEvent enemyDetector;

	// Token: 0x04001BE3 RID: 7139
	[Space]
	public bool acidLander;

	// Token: 0x04001BE4 RID: 7140
	public float acidTargetY;

	// Token: 0x04001BE5 RID: 7141
	public AudioClip acidSplashSound;

	// Token: 0x04001BE6 RID: 7142
	public GameObject acidSplashPrefab;

	// Token: 0x04001BE7 RID: 7143
	private AudioSource audioSource;

	// Token: 0x04001BE8 RID: 7144
	private Rigidbody2D body;

	// Token: 0x04001BE9 RID: 7145
	private bool activated;
}
