using System;
using UnityEngine;

// Token: 0x020003EB RID: 1003
public class SpatterHoney : MonoBehaviour
{
	// Token: 0x060016D5 RID: 5845 RVA: 0x0006C1AA File Offset: 0x0006A3AA
	private void Start()
	{
		this.scaleModifier = UnityEngine.Random.Range(this.scaleModifierMin, this.scaleModifierMax);
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x0006C1C3 File Offset: 0x0006A3C3
	private void OnEnable()
	{
		this.rb2d.isKinematic = false;
		this.circleCollider.enabled = true;
		this.idleTimer = 0f;
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x0006C1E8 File Offset: 0x0006A3E8
	private void Update()
	{
		this.FaceAngle();
		this.ProjectileSquash();
		this.idleTimer += Time.deltaTime;
		if (this.idleTimer > 3f)
		{
			this.Impact();
		}
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0006C21B File Offset: 0x0006A41B
	private void Impact()
	{
		if (this.idleTimer > 0.1f)
		{
			base.gameObject.Recycle();
		}
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0006C238 File Offset: 0x0006A438
	private void FaceAngle()
	{
		Vector2 velocity = this.rb2d.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x0006C284 File Offset: 0x0006A484
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

	// Token: 0x060016DB RID: 5851 RVA: 0x0006C333 File Offset: 0x0006A533
	private void OnCollisionEnter2D(Collision2D collision)
	{
		this.Impact();
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x0006C33B File Offset: 0x0006A53B
	public SpatterHoney()
	{
		this.stretchFactor = 1.4f;
		this.stretchMinX = 0.7f;
		this.stretchMaxY = 1.75f;
		this.scaleModifierMin = 0.7f;
		this.scaleModifierMax = 1.3f;
		base..ctor();
	}

	// Token: 0x04001B82 RID: 7042
	public Rigidbody2D rb2d;

	// Token: 0x04001B83 RID: 7043
	public CircleCollider2D circleCollider;

	// Token: 0x04001B84 RID: 7044
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001B85 RID: 7045
	private float stretchFactor;

	// Token: 0x04001B86 RID: 7046
	private float stretchMinX;

	// Token: 0x04001B87 RID: 7047
	private float stretchMaxY;

	// Token: 0x04001B88 RID: 7048
	private float scaleModifier;

	// Token: 0x04001B89 RID: 7049
	public float scaleModifierMin;

	// Token: 0x04001B8A RID: 7050
	public float scaleModifierMax;

	// Token: 0x04001B8B RID: 7051
	private float state;

	// Token: 0x04001B8C RID: 7052
	private float idleTimer;
}
