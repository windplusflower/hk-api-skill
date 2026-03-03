using System;
using UnityEngine;

// Token: 0x02000152 RID: 338
public class BigCentipede : MonoBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060007DB RID: 2011 RVA: 0x0002C21E File Offset: 0x0002A41E
	public Vector2 EntryPoint
	{
		get
		{
			return this.entryPoint;
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060007DC RID: 2012 RVA: 0x0002C226 File Offset: 0x0002A426
	public Vector2 ExitPoint
	{
		get
		{
			return this.exitPoint;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002C22E File Offset: 0x0002A42E
	public Vector2 Direction
	{
		get
		{
			return this.direction;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0002C238 File Offset: 0x0002A438
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.meshRenderer = base.GetComponent<MeshRenderer>();
		this.audioSource = base.GetComponent<AudioSource>();
		this.sections = base.GetComponentsInChildren<BigCentipedeSection>();
		if (this.audioSource)
		{
			this.audioSource.pitch = UnityEngine.Random.Range(0.8f, 1.15f);
		}
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x0002C29C File Offset: 0x0002A49C
	protected void Start()
	{
		this.direction = base.transform.right.normalized;
		this.entryDust.transform.parent = null;
		if (this.entry != null)
		{
			this.entryPoint = this.entry.transform.position;
			this.entryDust.transform.SetPosition2D(this.entry.transform.position);
		}
		else
		{
			this.entryPoint = base.transform.position - this.direction * 12f;
		}
		this.exitDust.transform.parent = null;
		if (this.exit != null)
		{
			this.exitPoint = this.exit.transform.position;
			this.exitDust.transform.SetPosition2D(this.exit.transform.position);
		}
		else
		{
			this.exitPoint = base.transform.position + this.direction * 6f;
		}
		this.UnBurrow(false);
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
	private void UnBurrow(bool changePosition)
	{
		this.entryDust.Play();
		this.isBurrowing = false;
		if (changePosition)
		{
			base.transform.SetPosition2D(this.entryPoint - this.direction * 2.6f);
		}
		this.exitDust.Stop();
		this.meshRenderer.enabled = true;
		this.audioSource.volume = 0f;
		this.fadingAudio = true;
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x0002C45E File Offset: 0x0002A65E
	private void Burrow()
	{
		this.exitDust.Play();
		this.isBurrowing = true;
		this.burrowTimer = 0f;
		this.meshRenderer.enabled = false;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0002C489 File Offset: 0x0002A689
	protected void FixedUpdate()
	{
		this.body.MovePosition(this.body.position + this.direction * this.moveSpeed * Time.fixedDeltaTime);
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0002C4C4 File Offset: 0x0002A6C4
	protected void Update()
	{
		Vector2 lhs = base.transform.position;
		if (!this.isBurrowing)
		{
			if (Vector2.Dot(lhs, this.direction) > Vector2.Dot(this.exitPoint, this.direction))
			{
				this.Burrow();
			}
		}
		else
		{
			this.burrowTimer += Time.deltaTime;
			if (this.burrowTimer > this.burrowTime)
			{
				this.UnBurrow(true);
			}
		}
		if (this.fadingAudio)
		{
			this.audioSource.volume += Time.deltaTime * 1.5f;
			if (this.audioSource.volume > 1f)
			{
				this.audioSource.volume = 1f;
				this.fadingAudio = false;
			}
		}
	}

	// Token: 0x040008AF RID: 2223
	private Rigidbody2D body;

	// Token: 0x040008B0 RID: 2224
	private MeshRenderer meshRenderer;

	// Token: 0x040008B1 RID: 2225
	private AudioSource audioSource;

	// Token: 0x040008B2 RID: 2226
	private BigCentipedeSection[] sections;

	// Token: 0x040008B3 RID: 2227
	[SerializeField]
	private ParticleSystem entryDust;

	// Token: 0x040008B4 RID: 2228
	[SerializeField]
	private ParticleSystem exitDust;

	// Token: 0x040008B5 RID: 2229
	private Vector2 entryPoint;

	// Token: 0x040008B6 RID: 2230
	private Vector2 exitPoint;

	// Token: 0x040008B7 RID: 2231
	[SerializeField]
	private float burrowTime;

	// Token: 0x040008B8 RID: 2232
	[SerializeField]
	private float moveSpeed;

	// Token: 0x040008B9 RID: 2233
	private Vector2 direction;

	// Token: 0x040008BA RID: 2234
	private bool fadingAudio;

	// Token: 0x040008BB RID: 2235
	private bool isBurrowing;

	// Token: 0x040008BC RID: 2236
	private float burrowTimer;

	// Token: 0x040008BD RID: 2237
	[SerializeField]
	private Transform entry;

	// Token: 0x040008BE RID: 2238
	[SerializeField]
	private Transform exit;
}
