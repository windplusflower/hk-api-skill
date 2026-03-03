using System;
using UnityEngine;

// Token: 0x02000121 RID: 289
public class DropCrystal : MonoBehaviour
{
	// Token: 0x060006B3 RID: 1715 RVA: 0x0002703C File Offset: 0x0002523C
	private void Start()
	{
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, UnityEngine.Random.Range(-0.01f, 0.01f));
		float num = UnityEngine.Random.Range(0.4f, 1f);
		base.transform.localScale = new Vector3(num, num, num);
		this.startPos = base.transform.position;
		this.rb = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000270C8 File Offset: 0x000252C8
	public void OnEnable()
	{
		this.onConveyor = false;
		base.transform.localEulerAngles = new Vector3(0f, 0f, UnityEngine.Random.Range(0f, 360f));
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000270FC File Offset: 0x000252FC
	private void FixedUpdate()
	{
		if (this.stepCounter >= 10)
		{
			Vector2 a = new Vector2(base.transform.position.x, base.transform.position.y);
			this.velocity = a - this.lastPos;
			this.lastPos = a;
			this.speed = this.rb.velocity.magnitude;
			if (base.transform.position.y < 4f)
			{
				base.transform.position = this.startPos;
				this.rb.velocity = new Vector2(0f, 0f);
			}
			this.stepCounter = 0;
			return;
		}
		this.stepCounter++;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000271C8 File Offset: 0x000253C8
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (this.speed > this.speedThreshold)
		{
			Vector3 inNormal = col.GetSafeContact().Normal;
			Vector3 normalized = Vector3.Reflect(this.velocity.normalized, inNormal).normalized;
			this.rb.velocity = new Vector2(normalized.x, normalized.y) * (this.speed * (this.bounceFactor * UnityEngine.Random.Range(0.8f, 1.2f)));
		}
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00027254 File Offset: 0x00025454
	private void LateUpdate()
	{
		if (this.onConveyor && this.xSpeed != 0f)
		{
			base.transform.position = new Vector3(base.transform.position.x + this.xSpeed * Time.deltaTime, base.transform.position.y, base.transform.position.z);
		}
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x000272C3 File Offset: 0x000254C3
	public void StartConveyorMove(float c_xSpeed, float c_ySpeed)
	{
		this.onConveyor = true;
		this.xSpeed = c_xSpeed;
		this.ySpeed = c_ySpeed;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x000272DA File Offset: 0x000254DA
	public void StopConveyorMove()
	{
		this.onConveyor = false;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000272E3 File Offset: 0x000254E3
	public DropCrystal()
	{
		this.speedThreshold = 1f;
		this.bouncing = true;
		base..ctor();
	}

	// Token: 0x04000749 RID: 1865
	public float bounceFactor;

	// Token: 0x0400074A RID: 1866
	public float speedThreshold;

	// Token: 0x0400074B RID: 1867
	private float speed;

	// Token: 0x0400074C RID: 1868
	private float animTimer;

	// Token: 0x0400074D RID: 1869
	private Vector2 velocity;

	// Token: 0x0400074E RID: 1870
	private Vector2 lastPos;

	// Token: 0x0400074F RID: 1871
	private Rigidbody2D rb;

	// Token: 0x04000750 RID: 1872
	private int chooser;

	// Token: 0x04000751 RID: 1873
	private bool bouncing;

	// Token: 0x04000752 RID: 1874
	private int stepCounter;

	// Token: 0x04000753 RID: 1875
	private float xSpeed;

	// Token: 0x04000754 RID: 1876
	private float ySpeed;

	// Token: 0x04000755 RID: 1877
	private bool onConveyor;

	// Token: 0x04000756 RID: 1878
	private Vector3 startPos;
}
