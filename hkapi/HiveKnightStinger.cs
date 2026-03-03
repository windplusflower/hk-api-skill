using System;
using UnityEngine;

// Token: 0x020001B3 RID: 435
public class HiveKnightStinger : MonoBehaviour
{
	// Token: 0x06000994 RID: 2452 RVA: 0x0003499C File Offset: 0x00032B9C
	private void OnEnable()
	{
		if (!this.initialised)
		{
			this.startPos = base.transform.localPosition;
			this.initialised = true;
		}
		else
		{
			base.transform.localPosition = this.startPos;
		}
		if (this.rb == null)
		{
			this.rb = base.GetComponent<Rigidbody2D>();
		}
		this.timer = this.time;
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00034A04 File Offset: 0x00032C04
	private void Update()
	{
		float x = this.speed * Mathf.Cos(this.direction * 0.017453292f);
		float y = this.speed * Mathf.Sin(this.direction * 0.017453292f);
		Vector2 velocity;
		velocity.x = x;
		velocity.y = y;
		this.rb.velocity = velocity;
		if (this.timer > 0f)
		{
			this.timer -= Time.deltaTime;
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00034A8B File Offset: 0x00032C8B
	public HiveKnightStinger()
	{
		this.speed = 20f;
		this.time = 2f;
		base..ctor();
	}

	// Token: 0x04000AA6 RID: 2726
	public float direction;

	// Token: 0x04000AA7 RID: 2727
	private float speed;

	// Token: 0x04000AA8 RID: 2728
	private float time;

	// Token: 0x04000AA9 RID: 2729
	private float timer;

	// Token: 0x04000AAA RID: 2730
	private bool initialised;

	// Token: 0x04000AAB RID: 2731
	private Rigidbody2D rb;

	// Token: 0x04000AAC RID: 2732
	private Vector3 startPos;
}
