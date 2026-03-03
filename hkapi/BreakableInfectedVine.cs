using System;
using UnityEngine;

// Token: 0x02000397 RID: 919
public class BreakableInfectedVine : MonoBehaviour
{
	// Token: 0x06001547 RID: 5447 RVA: 0x0006525B File Offset: 0x0006345B
	private void Awake()
	{
		this.source = base.GetComponent<AudioSource>();
		this.vibration = base.GetComponent<VibrationPlayer>();
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00065278 File Offset: 0x00063478
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > 1f)
		{
			if (this.source)
			{
				this.source.enabled = false;
			}
			Collider2D component = base.GetComponent<Collider2D>();
			if (component)
			{
				component.enabled = false;
			}
			base.enabled = false;
		}
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000652E0 File Offset: 0x000634E0
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated)
		{
			return;
		}
		bool flag = false;
		if (collision.tag == "Nail Attack")
		{
			flag = true;
		}
		else if (collision.tag == "Hero Spell")
		{
			flag = true;
		}
		else if (collision.tag == "HeroBox" && HeroController.instance.cState.superDashing)
		{
			flag = true;
		}
		if (flag)
		{
			foreach (GameObject gameObject in this.blobs)
			{
				gameObject.SetActive(false);
				this.SpawnSpatters(gameObject.transform.position);
			}
			GameObject[] array = this.effects;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(true);
			}
			if (this.source)
			{
				this.source.pitch = UnityEngine.Random.Range(this.audioPitchMin, this.audioPitchMax);
				this.source.Play();
			}
			if (this.vibration)
			{
				this.vibration.Play();
			}
			this.activated = true;
		}
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x000653F4 File Offset: 0x000635F4
	private void SpawnSpatters(Vector3 position)
	{
		GlobalPrefabDefaults.Instance.SpawnBlood(position, (short)this.spatterAmount, (short)this.spatterAmount, this.spatterSpeedMin, this.spatterSpeedMax, this.spatterAngleMin, this.spatterAngleMax, null);
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x0006543C File Offset: 0x0006363C
	public BreakableInfectedVine()
	{
		this.spatterAmount = 5;
		this.spatterSpeedMin = 10f;
		this.spatterSpeedMax = 20f;
		this.spatterAngleMin = 40f;
		this.spatterAngleMax = 140f;
		this.audioPitchMin = 0.8f;
		this.audioPitchMax = 1.1f;
		base..ctor();
	}

	// Token: 0x04001965 RID: 6501
	public GameObject[] blobs;

	// Token: 0x04001966 RID: 6502
	[Space]
	public GameObject[] effects;

	// Token: 0x04001967 RID: 6503
	[Space]
	public int spatterAmount;

	// Token: 0x04001968 RID: 6504
	public float spatterSpeedMin;

	// Token: 0x04001969 RID: 6505
	public float spatterSpeedMax;

	// Token: 0x0400196A RID: 6506
	public float spatterAngleMin;

	// Token: 0x0400196B RID: 6507
	public float spatterAngleMax;

	// Token: 0x0400196C RID: 6508
	[Space]
	public float audioPitchMin;

	// Token: 0x0400196D RID: 6509
	public float audioPitchMax;

	// Token: 0x0400196E RID: 6510
	private bool activated;

	// Token: 0x0400196F RID: 6511
	private AudioSource source;

	// Token: 0x04001970 RID: 6512
	private VibrationPlayer vibration;
}
