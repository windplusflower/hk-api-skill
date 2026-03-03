using System;
using UnityEngine;

// Token: 0x020003EF RID: 1007
public class SteepSlope : MonoBehaviour
{
	// Token: 0x060016F3 RID: 5875 RVA: 0x0006D063 File Offset: 0x0006B263
	private void Start()
	{
		this.hc = HeroController.instance;
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x0006D070 File Offset: 0x0006B270
	private void OnCollisionStay2D(Collision2D collision)
	{
		GameObject gameObject = collision.gameObject;
		Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
		component.velocity = new Vector2(component.velocity.x, -20f);
		if (gameObject.CompareTag("Player"))
		{
			this.hc.ResetHardLandingTimer();
			this.hc.CancelSuperDash();
		}
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0006D0C8 File Offset: 0x0006B2C8
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			if (this.slideLeft)
			{
				this.hc.cState.slidingLeft = true;
			}
			if (this.slideRight)
			{
				this.hc.cState.slidingRight = true;
			}
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0006D11C File Offset: 0x0006B31C
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			if (this.slideLeft)
			{
				this.hc.cState.slidingLeft = false;
			}
			if (this.slideRight)
			{
				this.hc.cState.slidingRight = false;
			}
		}
	}

	// Token: 0x04001BBB RID: 7099
	public bool slideLeft;

	// Token: 0x04001BBC RID: 7100
	public bool slideRight;

	// Token: 0x04001BBD RID: 7101
	private HeroController hc;
}
