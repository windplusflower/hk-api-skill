using System;
using UnityEngine;

// Token: 0x0200040C RID: 1036
public class SpellGetOrb : MonoBehaviour
{
	// Token: 0x06001774 RID: 6004 RVA: 0x0006EBF4 File Offset: 0x0006CDF4
	private void Start()
	{
		base.transform.position = new Vector3(base.transform.position.x + UnityEngine.Random.Range(-0.1f, 0.1f), base.transform.position.y + UnityEngine.Random.Range(-0.2f, 0.2f), UnityEngine.Random.Range(-6f, 6f));
		this.idleTime = UnityEngine.Random.Range(2.5f, 4.5f);
		float num = UnityEngine.Random.Range(0.3f, 0.7f);
		base.transform.localScale = new Vector3(num, num);
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x0006EC98 File Offset: 0x0006CE98
	private void OnEnable()
	{
		if (this.trackToHero)
		{
			GameManager instance = GameManager.instance;
			this.hero = instance.hero_ctrl.gameObject;
			if (this.hero == null)
			{
				this.hero = GameObject.FindWithTag("Player");
			}
		}
		this.startPosition = base.transform.position;
		float num = UnityEngine.Random.Range(3f, 20f);
		float num2 = UnityEngine.Random.Range(0f, 360f);
		float x = num * Mathf.Cos(num2 * 0.017453292f) * 1.25f;
		float y = num * Mathf.Sin(num2 * 0.017453292f);
		this.rb2d.velocity = new Vector2(x, y);
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x0006ED48 File Offset: 0x0006CF48
	private void Update()
	{
		if (this.state == 0)
		{
			if (this.timer < this.idleTime)
			{
				this.timer += Time.deltaTime;
				return;
			}
			this.rb2d.velocity = new Vector3(0f, 0f, 0f);
			this.trailObject.SetActive(true);
			this.zoomPosition = base.transform.position;
			this.state = 1;
			this.ptIdle.Stop();
			this.ptZoom.Play();
			if (this.hero != null && this.trackToHero)
			{
				this.startPosition = new Vector3(this.hero.transform.position.x, this.hero.transform.position.y - 0.5f, this.hero.transform.position.z);
				return;
			}
		}
		else if (this.state == 1)
		{
			this.trailRenderer.startWidth = base.transform.localScale.x;
			base.transform.position = Vector3.Lerp(this.zoomPosition, this.startPosition, this.lerpTimer);
			this.lerpTimer += Time.deltaTime * this.accel;
			this.accel += Time.deltaTime * this.accelMultiplier;
			if (this.lerpTimer >= 1f)
			{
				this.Collect();
			}
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x0006EEE0 File Offset: 0x0006D0E0
	private void FaceAngle()
	{
		Vector2 velocity = this.rb2d.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x0006EF2C File Offset: 0x0006D12C
	private void ProjectileSquash()
	{
		float num = 1f - this.rb2d.velocity.magnitude * this.stretchFactor * 0.01f;
		float num2 = 1f + this.rb2d.velocity.magnitude * this.stretchFactor * 0.01f;
		if (num2 < this.stretchMinX)
		{
			num2 = this.stretchMinX;
		}
		if (num > this.stretchMaxY)
		{
			num = this.stretchMaxY;
		}
		num *= this.scaleModifier;
		num2 *= this.scaleModifier;
		base.transform.localScale = new Vector3(num2, num, base.transform.localScale.z);
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x0006EFDC File Offset: 0x0006D1DC
	private void Collect()
	{
		this.state = 2;
		this.rb2d.velocity = new Vector3(0f, 0f, 0f);
		this.spriteRenderer.enabled = false;
		this.trailObject.SetActive(false);
		this.orbGetObject.SetActive(true);
		this.ptZoom.Stop();
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x0006F043 File Offset: 0x0006D243
	public SpellGetOrb()
	{
		this.accel = 0.5f;
		this.accelMultiplier = 12f;
		this.stretchFactor = 2f;
		this.stretchMinX = 0.5f;
		this.stretchMaxY = 2f;
		base..ctor();
	}

	// Token: 0x04001C30 RID: 7216
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001C31 RID: 7217
	public Rigidbody2D rb2d;

	// Token: 0x04001C32 RID: 7218
	public GameObject trailObject;

	// Token: 0x04001C33 RID: 7219
	public TrailRenderer trailRenderer;

	// Token: 0x04001C34 RID: 7220
	public GameObject orbGetObject;

	// Token: 0x04001C35 RID: 7221
	public ParticleSystem ptIdle;

	// Token: 0x04001C36 RID: 7222
	public ParticleSystem ptZoom;

	// Token: 0x04001C37 RID: 7223
	public bool trackToHero;

	// Token: 0x04001C38 RID: 7224
	private float accel;

	// Token: 0x04001C39 RID: 7225
	private float accelMultiplier;

	// Token: 0x04001C3A RID: 7226
	private float stretchFactor;

	// Token: 0x04001C3B RID: 7227
	private float stretchMinX;

	// Token: 0x04001C3C RID: 7228
	private float stretchMaxY;

	// Token: 0x04001C3D RID: 7229
	private float scaleModifier;

	// Token: 0x04001C3E RID: 7230
	private float timer;

	// Token: 0x04001C3F RID: 7231
	private float idleTime;

	// Token: 0x04001C40 RID: 7232
	private float lerpTimer;

	// Token: 0x04001C41 RID: 7233
	private Vector3 startPosition;

	// Token: 0x04001C42 RID: 7234
	private Vector3 zoomPosition;

	// Token: 0x04001C43 RID: 7235
	private GameObject hero;

	// Token: 0x04001C44 RID: 7236
	private int state;
}
