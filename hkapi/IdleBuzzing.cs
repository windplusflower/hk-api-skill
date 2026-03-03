using System;
using UnityEngine;

// Token: 0x020003D2 RID: 978
[RequireComponent(typeof(Rigidbody2D))]
public class IdleBuzzing : MonoBehaviour
{
	// Token: 0x06001671 RID: 5745 RVA: 0x0006A310 File Offset: 0x00068510
	protected void Reset()
	{
		this.waitMin = 0.75f;
		this.waitMax = 1f;
		this.speedMax = 1.75f;
		this.accelerationMax = 15f;
		this.roamingRange = 1f;
		this.dampener = 1.125f;
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0006A35F File Offset: 0x0006855F
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x0006A36D File Offset: 0x0006856D
	protected void Start()
	{
		this.start2D = this.body.position;
		this.acceleration2D = Vector2.zero;
		this.Buzz(0f);
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x0006A398 File Offset: 0x00068598
	protected void FixedUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.Buzz(deltaTime);
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0006A3B4 File Offset: 0x000685B4
	private void Buzz(float deltaTime)
	{
		Vector2 position = this.body.position;
		Vector2 velocity = this.body.velocity;
		bool flag;
		if (this.waitTimer <= 0f)
		{
			flag = true;
			this.waitTimer = UnityEngine.Random.Range(this.waitMin, this.waitMax);
		}
		else
		{
			this.waitTimer -= deltaTime;
			flag = false;
		}
		for (int i = 0; i < 2; i++)
		{
			float num = velocity[i];
			float num2 = this.start2D[i];
			float num3 = position[i] - num2;
			float num4 = this.acceleration2D[i];
			if (flag)
			{
				if (Mathf.Abs(num3) > this.roamingRange)
				{
					num4 = -Mathf.Sign(num3) * this.accelerationMax;
				}
				else
				{
					num4 = UnityEngine.Random.Range(-this.accelerationMax, this.accelerationMax);
				}
				num4 /= 2000f;
			}
			else if (Mathf.Abs(num3) > this.roamingRange && num3 > 0f == num > 0f)
			{
				num4 = this.accelerationMax * -Mathf.Sign(num3) / 2000f;
				num /= this.dampener;
				this.waitTimer = UnityEngine.Random.Range(this.waitMin, this.waitMax);
			}
			num += num4;
			num = Mathf.Clamp(num, -this.speedMax, this.speedMax);
			velocity[i] = num;
			this.acceleration2D[i] = num4;
		}
		this.body.velocity = velocity;
	}

	// Token: 0x04001AFB RID: 6907
	private Rigidbody2D body;

	// Token: 0x04001AFC RID: 6908
	[SerializeField]
	private float waitMin;

	// Token: 0x04001AFD RID: 6909
	[SerializeField]
	private float waitMax;

	// Token: 0x04001AFE RID: 6910
	[SerializeField]
	private float speedMax;

	// Token: 0x04001AFF RID: 6911
	[SerializeField]
	private float accelerationMax;

	// Token: 0x04001B00 RID: 6912
	[SerializeField]
	private float roamingRange;

	// Token: 0x04001B01 RID: 6913
	[SerializeField]
	private float dampener;

	// Token: 0x04001B02 RID: 6914
	private Vector2 start2D;

	// Token: 0x04001B03 RID: 6915
	private Vector2 acceleration2D;

	// Token: 0x04001B04 RID: 6916
	private float waitTimer;

	// Token: 0x04001B05 RID: 6917
	private const float InspectorAccelerationConstant = 2000f;
}
