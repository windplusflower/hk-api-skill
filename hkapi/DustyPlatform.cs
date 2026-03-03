using System;
using UnityEngine;

// Token: 0x020003BA RID: 954
public class DustyPlatform : MonoBehaviour
{
	// Token: 0x060015EB RID: 5611 RVA: 0x00067F94 File Offset: 0x00066194
	protected void Reset()
	{
		this.inset = 0.3f;
		this.dustIgnoredLayers.value = 327680;
		this.dustRateAreaFactor = 10f;
		this.dustRateConstant = 5f;
		this.streamOffset = new Vector3(0f, 0.1f, 0.01f);
		this.streamEmissionMin = 3f;
		this.streamEmissionMax = 10f;
		this.rocksChance = 0.5f;
		this.rocksDelay = 0.25f;
		this.rockCountMin = 1;
		this.rockCountMax = 3;
		this.cooldownDuration = 0.45f;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00068031 File Offset: 0x00066231
	protected void Awake()
	{
		this.bodyCollider = base.GetComponent<BoxCollider2D>();
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00068040 File Offset: 0x00066240
	protected void Update()
	{
		if (!this.isRunning)
		{
			return;
		}
		bool flag = true;
		if (this.rocksDelayTimer > 0f)
		{
			this.rocksDelayTimer -= Time.deltaTime;
			if (this.rocksDelayTimer <= 0f)
			{
				this.SpawnRocks();
			}
			else
			{
				flag = false;
			}
		}
		if (this.cooldownTimer > 0f)
		{
			this.cooldownTimer -= Time.deltaTime;
			if (this.cooldownTimer > 0f)
			{
				flag = false;
			}
		}
		if (flag)
		{
			this.isRunning = false;
		}
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x000680C8 File Offset: 0x000662C8
	protected void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.isRunning)
		{
			return;
		}
		int layer = collision.collider.gameObject.layer;
		if ((this.dustIgnoredLayers.value & 1 << layer) != 0)
		{
			return;
		}
		Vector2 vector = Vector2.zero;
		if (collision.contacts.Length != 0)
		{
			vector = collision.contacts[0].normal;
		}
		if (Mathf.Abs(vector.y - -1f) > 0.1f)
		{
			return;
		}
		this.dustFallClips.SpawnAndPlayOneShot(this.dustFallSourcePrefab, base.transform.position);
		Vector2 vector2 = this.bodyCollider.size - new Vector2(this.inset, this.inset);
		Vector3 position = base.transform.position;
		position.z = -0.1f;
		if (this.dustPrefab != null)
		{
			ParticleSystem particleSystem = this.dustPrefab.Spawn(position);
			this.SetRateOverTime(particleSystem, vector2.x * vector2.y * this.dustRateAreaFactor + this.dustRateConstant);
			particleSystem.transform.localScale = new Vector3(vector2.x, vector2.y, particleSystem.transform.localScale.z);
		}
		if (this.streamPrefab != null)
		{
			GameObject gameObject = this.streamPrefab.Spawn(position + new Vector3(0f, -this.bodyCollider.size.y * 0.5f, 0.01f) + this.streamOffset);
			gameObject.GetComponentInChildren<ParticleSystem>();
			Vector3 localScale = gameObject.transform.localScale;
			localScale.x = vector2.x;
			gameObject.transform.localScale = localScale;
		}
		if (UnityEngine.Random.value < this.rocksChance && this.rocksPrefab != null)
		{
			ParticleSystem particleSystem2 = this.rocksPrefab.Spawn(position);
			particleSystem2.transform.position = new Vector3(particleSystem2.transform.position.x, particleSystem2.transform.position.y, 0.003f);
			particleSystem2.transform.localScale = new Vector3(vector2.x, vector2.y, particleSystem2.transform.localScale.z);
		}
		this.cooldownTimer = this.cooldownDuration;
		this.isRunning = true;
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00003603 File Offset: 0x00001803
	private void SpawnRocks()
	{
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00068324 File Offset: 0x00066524
	private void SetRateOverTime(ParticleSystem ps, float rateOverTime)
	{
		ps.emission.rateOverTime = rateOverTime;
	}

	// Token: 0x04001A42 RID: 6722
	private BoxCollider2D bodyCollider;

	// Token: 0x04001A43 RID: 6723
	[SerializeField]
	private float inset;

	// Token: 0x04001A44 RID: 6724
	[SerializeField]
	private LayerMask dustIgnoredLayers;

	// Token: 0x04001A45 RID: 6725
	[SerializeField]
	private RandomAudioClipTable dustFallClips;

	// Token: 0x04001A46 RID: 6726
	[SerializeField]
	private AudioSource dustFallSourcePrefab;

	// Token: 0x04001A47 RID: 6727
	[SerializeField]
	private ParticleSystem dustPrefab;

	// Token: 0x04001A48 RID: 6728
	[SerializeField]
	private ParticleSystem rocksPrefab;

	// Token: 0x04001A49 RID: 6729
	[SerializeField]
	private float dustRateAreaFactor;

	// Token: 0x04001A4A RID: 6730
	[SerializeField]
	private float dustRateConstant;

	// Token: 0x04001A4B RID: 6731
	[SerializeField]
	private GameObject streamPrefab;

	// Token: 0x04001A4C RID: 6732
	[SerializeField]
	private Vector3 streamOffset;

	// Token: 0x04001A4D RID: 6733
	[SerializeField]
	private float streamEmissionMin;

	// Token: 0x04001A4E RID: 6734
	[SerializeField]
	private float streamEmissionMax;

	// Token: 0x04001A4F RID: 6735
	[SerializeField]
	private float rocksChance;

	// Token: 0x04001A50 RID: 6736
	[SerializeField]
	private float rocksDelay;

	// Token: 0x04001A51 RID: 6737
	[SerializeField]
	private Transform rockPrefab;

	// Token: 0x04001A52 RID: 6738
	[SerializeField]
	private int rockCountMin;

	// Token: 0x04001A53 RID: 6739
	[SerializeField]
	private int rockCountMax;

	// Token: 0x04001A54 RID: 6740
	private float rocksDelayTimer;

	// Token: 0x04001A55 RID: 6741
	[SerializeField]
	private float cooldownDuration;

	// Token: 0x04001A56 RID: 6742
	private float cooldownTimer;

	// Token: 0x04001A57 RID: 6743
	private bool isRunning;
}
