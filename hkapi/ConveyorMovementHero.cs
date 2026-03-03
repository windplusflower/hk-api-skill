using System;
using UnityEngine;

// Token: 0x020003A4 RID: 932
public class ConveyorMovementHero : MonoBehaviour
{
	// Token: 0x0600156B RID: 5483 RVA: 0x00066393 File Offset: 0x00064593
	private void Start()
	{
		this.heroCon = base.GetComponent<HeroController>();
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x000663A1 File Offset: 0x000645A1
	public void StartConveyorMove(float c_xSpeed, float c_ySpeed)
	{
		this.onConveyor = true;
		this.xSpeed = c_xSpeed;
		this.ySpeed = c_ySpeed;
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x000663B8 File Offset: 0x000645B8
	public void StopConveyorMove()
	{
		this.onConveyor = false;
		if (this.gravityOff)
		{
			if (!this.heroCon.cState.superDashing)
			{
				this.heroCon.AffectedByGravity(true);
			}
			this.gravityOff = false;
		}
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x000663F0 File Offset: 0x000645F0
	private void LateUpdate()
	{
		if (this.onConveyor)
		{
			float num = this.xSpeed;
			if (this.ySpeed != 0f && (this.heroCon.cState.wallSliding || this.heroCon.cState.superDashOnWall))
			{
				if (this.heroCon.cState.superDashOnWall)
				{
					base.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f);
				}
				base.GetComponent<Rigidbody2D>().velocity = new Vector2(base.GetComponent<Rigidbody2D>().velocity.x, this.ySpeed);
				if (!this.gravityOff)
				{
					this.heroCon.AffectedByGravity(false);
					this.gravityOff = true;
					return;
				}
			}
			else if (this.gravityOff && !this.heroCon.cState.superDashing)
			{
				this.heroCon.AffectedByGravity(true);
				this.gravityOff = false;
			}
		}
	}

	// Token: 0x040019B3 RID: 6579
	private float xSpeed;

	// Token: 0x040019B4 RID: 6580
	private float ySpeed;

	// Token: 0x040019B5 RID: 6581
	private bool onConveyor;

	// Token: 0x040019B6 RID: 6582
	public bool gravityOff;

	// Token: 0x040019B7 RID: 6583
	private HeroController heroCon;
}
