using System;
using UnityEngine;

// Token: 0x020003EC RID: 1004
public class SpatterOrange : MonoBehaviour
{
	// Token: 0x060016DD RID: 5853 RVA: 0x0006C37A File Offset: 0x0006A57A
	private void Start()
	{
		this.scaleModifier = UnityEngine.Random.Range(this.scaleModifierMin, this.scaleModifierMax);
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x0006C394 File Offset: 0x0006A594
	private void OnEnable()
	{
		this.rb2d.isKinematic = false;
		this.circleCollider.enabled = true;
		this.idleTimer = 0f;
		this.animTimer = 0f;
		this.spriteRenderer.sprite = this.sprites[0];
		this.animFrame = 1;
		this.state = 0f;
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
	private void Update()
	{
		if (this.state == 0f)
		{
			this.FaceAngle();
			this.ProjectileSquash();
			this.idleTimer += Time.deltaTime;
			if (this.idleTimer > 3f)
			{
				this.Impact();
			}
		}
		if (this.state == 1f)
		{
			this.animTimer += Time.deltaTime;
			if (this.animTimer >= 1f / this.fps)
			{
				this.animTimer = 0f;
				this.animFrame++;
				if (this.animFrame > 6)
				{
					base.gameObject.Recycle();
					return;
				}
				this.spriteRenderer.sprite = this.sprites[this.animFrame];
			}
		}
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
	private void Impact()
	{
		float num = UnityEngine.Random.Range(this.splashScaleMin, this.splashScaleMax);
		base.transform.localScale = new Vector2(num, num);
		this.circleCollider.enabled = false;
		this.rb2d.isKinematic = true;
		this.rb2d.velocity = new Vector2(0f, 0f);
		this.spriteRenderer.sprite = this.sprites[1];
		this.state = 1f;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x0006C540 File Offset: 0x0006A740
	private void FaceAngle()
	{
		Vector2 velocity = this.rb2d.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x0006C58C File Offset: 0x0006A78C
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

	// Token: 0x060016E3 RID: 5859 RVA: 0x0006C63C File Offset: 0x0006A83C
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Collision2DUtils.Collision2DSafeContact safeContact = collision.GetSafeContact();
		float x = safeContact.Normal.x;
		float y = safeContact.Normal.y;
		if (y == -1f)
		{
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 180f);
		}
		else if (y == 1f)
		{
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f);
		}
		else if (x == 1f)
		{
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 270f);
		}
		else if (x == -1f)
		{
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 90f);
		}
		else
		{
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, base.transform.localEulerAngles.z + 90f);
		}
		this.Impact();
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
	private void OnTriggerEnter2D()
	{
		base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f);
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + 0.65f, base.transform.position.z);
		this.Impact();
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0006C848 File Offset: 0x0006AA48
	public SpatterOrange()
	{
		this.stretchFactor = 1.4f;
		this.stretchMinX = 0.6f;
		this.stretchMaxY = 1.75f;
		this.scaleModifierMin = 0.7f;
		this.scaleModifierMax = 1.3f;
		this.splashScaleMin = 1.5f;
		this.splashScaleMax = 2f;
		this.fps = 30f;
		base..ctor();
	}

	// Token: 0x04001B8D RID: 7053
	public Rigidbody2D rb2d;

	// Token: 0x04001B8E RID: 7054
	public CircleCollider2D circleCollider;

	// Token: 0x04001B8F RID: 7055
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001B90 RID: 7056
	public Sprite[] sprites;

	// Token: 0x04001B91 RID: 7057
	private float stretchFactor;

	// Token: 0x04001B92 RID: 7058
	private float stretchMinX;

	// Token: 0x04001B93 RID: 7059
	private float stretchMaxY;

	// Token: 0x04001B94 RID: 7060
	private float scaleModifier;

	// Token: 0x04001B95 RID: 7061
	public float scaleModifierMin;

	// Token: 0x04001B96 RID: 7062
	public float scaleModifierMax;

	// Token: 0x04001B97 RID: 7063
	public float splashScaleMin;

	// Token: 0x04001B98 RID: 7064
	public float splashScaleMax;

	// Token: 0x04001B99 RID: 7065
	private float state;

	// Token: 0x04001B9A RID: 7066
	public float fps;

	// Token: 0x04001B9B RID: 7067
	private float idleTimer;

	// Token: 0x04001B9C RID: 7068
	private float animTimer;

	// Token: 0x04001B9D RID: 7069
	private int animFrame;
}
