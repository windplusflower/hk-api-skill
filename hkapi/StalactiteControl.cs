using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003ED RID: 1005
public class StalactiteControl : MonoBehaviour
{
	// Token: 0x060016E6 RID: 5862 RVA: 0x0006C8B3 File Offset: 0x0006AAB3
	private void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.source = base.GetComponent<AudioSource>();
		this.heroDamage = base.GetComponent<DamageHero>();
		this.damageEnemies = base.GetComponent<DamageEnemies>();
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
	private void Start()
	{
		this.trigger = base.GetComponentInChildren<TriggerEnterEvent>();
		if (this.trigger)
		{
			this.trigger.OnTriggerEntered += this.HandleTriggerEnter;
		}
		if (this.heroDamage)
		{
			this.heroDamage.damageDealt = 0;
		}
		this.body.isKinematic = true;
		if (this.damageEnemies)
		{
			this.damageEnemies.enabled = false;
		}
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x0006C964 File Offset: 0x0006AB64
	private void HandleTriggerEnter(Collider2D collider, GameObject sender)
	{
		if (collider.tag == "Player" && Physics2D.Linecast(base.transform.position, collider.transform.position, 256).collider == null)
		{
			base.StartCoroutine(this.Fall(this.fallDelay));
			this.trigger.OnTriggerEntered -= this.HandleTriggerEnter;
			sender.SetActive(false);
		}
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x0006C9EE File Offset: 0x0006ABEE
	private IEnumerator Fall(float delay)
	{
		if (this.top)
		{
			this.top.transform.SetParent(this.transform.parent);
		}
		this.transform.position += Vector3.down * this.startFallOffset;
		if (this.startFallEffect)
		{
			this.startFallEffect.SetActive(true);
			this.startFallEffect.transform.SetParent(this.transform.parent);
		}
		if (this.source && this.startFallSound)
		{
			this.source.PlayOneShot(this.startFallSound);
		}
		yield return new WaitForSeconds(delay);
		if (this.fallEffect)
		{
			this.fallEffect.SetActive(true);
			this.fallEffect.transform.SetParent(this.transform.parent);
		}
		if (this.trailEffect)
		{
			this.trailEffect.SetActive(true);
		}
		if (this.heroDamage)
		{
			this.heroDamage.damageDealt = 1;
		}
		if (this.damageEnemies)
		{
			this.damageEnemies.enabled = true;
		}
		this.body.isKinematic = false;
		this.fallen = true;
		yield break;
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x0006CA04 File Offset: 0x0006AC04
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.fallen && collision.gameObject.layer == 8)
		{
			this.body.isKinematic = true;
			if (this.trailEffect)
			{
				this.trailEffect.transform.parent = null;
			}
			this.trailEffect.GetComponent<ParticleSystem>().Stop();
			if (this.embeddedVersion)
			{
				this.embeddedVersion.SetActive(true);
				this.embeddedVersion.transform.SetParent(base.transform.parent, true);
			}
			RaycastHit2D raycastHit2D = Physics2D.Raycast(base.transform.position, Vector2.down, 10f, 256);
			foreach (GameObject gameObject in this.landEffectPrefabs)
			{
				Vector3 vector = new Vector3(raycastHit2D.point.x, raycastHit2D.point.y, gameObject.transform.position.z);
				gameObject.Spawn((raycastHit2D.collider != null) ? vector : base.transform.position);
			}
			base.gameObject.SetActive(false);
			return;
		}
		if (collision.tag == "Nail Attack")
		{
			if (!this.fallen)
			{
				base.StartCoroutine(this.Fall(0f));
			}
			if (this.heroDamage)
			{
				this.heroDamage.damageDealt = 0;
				this.heroDamage = null;
			}
			float value = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy").FsmVariables.FindFsmFloat("direction").Value;
			float num = 0f;
			if (value < 45f)
			{
				num = 45f;
			}
			else
			{
				if (value < 135f)
				{
					GameObject[] array = this.hitUpEffectPrefabs;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Spawn(base.transform.position);
					}
					this.FlingObjects();
					if (this.source && this.breakSound)
					{
						AudioSource audioSource = new GameObject("StalactiteBreakEffect").AddComponent<AudioSource>();
						audioSource.outputAudioMixerGroup = this.source.outputAudioMixerGroup;
						audioSource.loop = false;
						audioSource.playOnAwake = false;
						audioSource.rolloffMode = this.source.rolloffMode;
						audioSource.minDistance = this.source.minDistance;
						audioSource.maxDistance = this.source.maxDistance;
						audioSource.clip = this.breakSound;
						audioSource.volume = this.source.volume;
						audioSource.Play();
					}
					base.gameObject.SetActive(false);
					return;
				}
				if (value < 225f)
				{
					num = -45f;
				}
				else if (value < 360f)
				{
					num = 0f;
				}
			}
			this.body.velocity;
			Vector3 v = Quaternion.Euler(0f, 0f, num) * Vector3.down * this.hitVelocity;
			this.body.rotation = num;
			this.body.gravityScale = 0f;
			this.body.velocity = v;
			this.nailStrikePrefab.Spawn(base.transform.position);
			if (this.source && this.hitSound)
			{
				this.source.PlayOneShot(this.hitSound);
			}
		}
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x0006CD84 File Offset: 0x0006AF84
	private void FlingObjects()
	{
		int num = UnityEngine.Random.Range(this.spawnMin, this.spawnMax + 1);
		for (int i = 1; i <= num; i++)
		{
			GameObject gameObject = this.hitUpRockPrefabs.Spawn(base.transform.position, base.transform.rotation);
			Vector3 position = gameObject.transform.position;
			Vector3 position2 = gameObject.transform.position;
			Vector3 position3 = gameObject.transform.position;
			float num2 = (float)UnityEngine.Random.Range(this.speedMin, this.speedMax);
			float num3 = UnityEngine.Random.Range(0f, 360f);
			float x = num2 * Mathf.Cos(num3 * 0.017453292f);
			float y = num2 * Mathf.Sin(num3 * 0.017453292f);
			Vector2 velocity;
			velocity.x = x;
			velocity.y = y;
			Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
			if (component)
			{
				component.velocity = velocity;
			}
		}
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x0006CE68 File Offset: 0x0006B068
	public StalactiteControl()
	{
		this.startFallOffset = 0.1f;
		this.fallDelay = 0.25f;
		this.hitVelocity = 40f;
		this.spawnMin = 10;
		this.spawnMax = 12;
		this.speedMin = 15;
		this.speedMax = 20;
		base..ctor();
	}

	// Token: 0x04001B9E RID: 7070
	public GameObject top;

	// Token: 0x04001B9F RID: 7071
	[Space]
	public float startFallOffset;

	// Token: 0x04001BA0 RID: 7072
	public GameObject startFallEffect;

	// Token: 0x04001BA1 RID: 7073
	public AudioClip startFallSound;

	// Token: 0x04001BA2 RID: 7074
	public float fallDelay;

	// Token: 0x04001BA3 RID: 7075
	[Space]
	public GameObject fallEffect;

	// Token: 0x04001BA4 RID: 7076
	public GameObject trailEffect;

	// Token: 0x04001BA5 RID: 7077
	public GameObject nailStrikePrefab;

	// Token: 0x04001BA6 RID: 7078
	[Space]
	public GameObject embeddedVersion;

	// Token: 0x04001BA7 RID: 7079
	public GameObject[] landEffectPrefabs;

	// Token: 0x04001BA8 RID: 7080
	[Space]
	public float hitVelocity;

	// Token: 0x04001BA9 RID: 7081
	[Space]
	public GameObject[] hitUpEffectPrefabs;

	// Token: 0x04001BAA RID: 7082
	public AudioClip hitSound;

	// Token: 0x04001BAB RID: 7083
	public GameObject hitUpRockPrefabs;

	// Token: 0x04001BAC RID: 7084
	public int spawnMin;

	// Token: 0x04001BAD RID: 7085
	public int spawnMax;

	// Token: 0x04001BAE RID: 7086
	public int speedMin;

	// Token: 0x04001BAF RID: 7087
	public int speedMax;

	// Token: 0x04001BB0 RID: 7088
	public AudioClip breakSound;

	// Token: 0x04001BB1 RID: 7089
	private TriggerEnterEvent trigger;

	// Token: 0x04001BB2 RID: 7090
	private DamageHero heroDamage;

	// Token: 0x04001BB3 RID: 7091
	private Rigidbody2D body;

	// Token: 0x04001BB4 RID: 7092
	private AudioSource source;

	// Token: 0x04001BB5 RID: 7093
	private DamageEnemies damageEnemies;

	// Token: 0x04001BB6 RID: 7094
	private bool fallen;
}
