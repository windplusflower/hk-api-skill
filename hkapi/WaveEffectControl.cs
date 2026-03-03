using System;
using UnityEngine;

// Token: 0x020005C0 RID: 1472
public class WaveEffectControl : MonoBehaviour
{
	// Token: 0x06002184 RID: 8580 RVA: 0x000A8B78 File Offset: 0x000A6D78
	private void Start()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x000A8B88 File Offset: 0x000A6D88
	private void OnEnable()
	{
		this.timer = 0f;
		if (this.blackWave)
		{
			this.colour = new Color(0f, 0f, 0f, 1f);
		}
		else if (!this.otherColour)
		{
			this.colour = new Color(1f, 1f, 1f, 1f);
		}
		this.accel = this.accelStart;
		if (!this.doNotPositionZ)
		{
			base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, 0.1f);
		}
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000A8C3C File Offset: 0x000A6E3C
	private void Update()
	{
		this.timer += Time.deltaTime * this.accel;
		float num = (1f + this.timer * 4f) * this.scaleMultiplier;
		base.transform.localScale = new Vector3(num, num, num);
		Color color = this.spriteRenderer.color;
		color.a = 1f - this.timer;
		this.spriteRenderer.color = color;
		if (this.timer > 1f)
		{
			if (!this.doNotRecycle)
			{
				base.gameObject.Recycle();
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x000A8CE7 File Offset: 0x000A6EE7
	private void FixedUpdate()
	{
		this.accel *= 0.95f;
		if (this.accel < 0.5f)
		{
			this.accel = 0.5f;
		}
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x000A8D13 File Offset: 0x000A6F13
	public WaveEffectControl()
	{
		this.accelStart = 5f;
		this.scaleMultiplier = 1f;
		base..ctor();
	}

	// Token: 0x040026E6 RID: 9958
	private float timer;

	// Token: 0x040026E7 RID: 9959
	public Color colour;

	// Token: 0x040026E8 RID: 9960
	public SpriteRenderer spriteRenderer;

	// Token: 0x040026E9 RID: 9961
	public float accel;

	// Token: 0x040026EA RID: 9962
	public float accelStart;

	// Token: 0x040026EB RID: 9963
	public bool doNotRecycle;

	// Token: 0x040026EC RID: 9964
	public bool doNotPositionZ;

	// Token: 0x040026ED RID: 9965
	public bool blackWave;

	// Token: 0x040026EE RID: 9966
	public bool otherColour;

	// Token: 0x040026EF RID: 9967
	public float scaleMultiplier;
}
