using System;
using UnityEngine;

// Token: 0x02000154 RID: 340
public class BrokenVesselGlob : MonoBehaviour
{
	// Token: 0x060007E8 RID: 2024 RVA: 0x0002C680 File Offset: 0x0002A880
	private void OnEnable()
	{
		base.transform.localScale = new Vector3(2f, 2f, 2f);
		this.gasParticle.Play();
		this.rb.velocity = new Vector3(this.rb.velocity.x, -17.5f);
		this.timer = 5f;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0002C6EC File Offset: 0x0002A8EC
	private void Update()
	{
		this.FaceAngle();
		this.ProjectileSquash();
		if (this.timer >= 0f)
		{
			this.timer -= Time.deltaTime;
			return;
		}
		base.gameObject.Recycle();
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0002C725 File Offset: 0x0002A925
	private void FixedUpdate()
	{
		this.rb.AddForce(this.force);
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0002C738 File Offset: 0x0002A938
	private void FaceAngle()
	{
		Vector2 velocity = this.rb.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0002C784 File Offset: 0x0002A984
	private void ProjectileSquash()
	{
		float num = 1f - this.rb.velocity.magnitude * this.stretchFactor * 0.01f;
		float num2 = 1f + this.rb.velocity.magnitude * this.stretchFactor * 0.01f;
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

	// Token: 0x060007ED RID: 2029 RVA: 0x0002C834 File Offset: 0x0002AA34
	public BrokenVesselGlob()
	{
		this.force = new Vector2(0f, 25f);
		this.stretchFactor = 2f;
		this.stretchMinX = 1f;
		this.stretchMaxY = 2f;
		this.scaleModifier = 2f;
		this.scaleModifierMin = 2f;
		this.scaleModifierMax = 2f;
		base..ctor();
	}

	// Token: 0x040008C3 RID: 2243
	public ParticleSystem gasParticle;

	// Token: 0x040008C4 RID: 2244
	public Rigidbody2D rb;

	// Token: 0x040008C5 RID: 2245
	private float timer;

	// Token: 0x040008C6 RID: 2246
	private Vector2 force;

	// Token: 0x040008C7 RID: 2247
	private float stretchFactor;

	// Token: 0x040008C8 RID: 2248
	private float stretchMinX;

	// Token: 0x040008C9 RID: 2249
	private float stretchMaxY;

	// Token: 0x040008CA RID: 2250
	private float scaleModifier;

	// Token: 0x040008CB RID: 2251
	private float scaleModifierMin;

	// Token: 0x040008CC RID: 2252
	private float scaleModifierMax;
}
