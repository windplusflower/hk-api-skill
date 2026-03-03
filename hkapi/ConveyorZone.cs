using System;
using UnityEngine;

// Token: 0x020003A6 RID: 934
public class ConveyorZone : MonoBehaviour
{
	// Token: 0x06001572 RID: 5490 RVA: 0x00066514 File Offset: 0x00064714
	private void Start()
	{
		if (HeroController.instance)
		{
			this.activated = false;
			HeroController.HeroInPosition temp = null;
			temp = delegate(bool b)
			{
				this.activated = true;
				HeroController.instance.heroInPosition -= temp;
			};
			HeroController.instance.heroInPosition += temp;
		}
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x0006656C File Offset: 0x0006476C
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.activated)
		{
			return;
		}
		if (collision.gameObject.GetComponent<ConveyorMovement>())
		{
			collision.gameObject.GetComponent<ConveyorMovement>().StartConveyorMove(this.speed, 0f);
		}
		if (collision.gameObject.GetComponent<HeroController>())
		{
			if (this.vertical)
			{
				collision.gameObject.GetComponent<ConveyorMovementHero>().StartConveyorMove(0f, this.speed);
				collision.gameObject.GetComponent<HeroController>().cState.onConveyorV = true;
				return;
			}
			collision.gameObject.GetComponent<HeroController>().SetConveyorSpeed(this.speed);
			collision.gameObject.GetComponent<HeroController>().cState.inConveyorZone = true;
		}
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00066628 File Offset: 0x00064828
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (!this.activated)
		{
			return;
		}
		if (collision.gameObject.GetComponent<ConveyorMovement>())
		{
			collision.gameObject.GetComponent<ConveyorMovement>().StopConveyorMove();
		}
		if (collision.gameObject.GetComponent<HeroController>())
		{
			collision.gameObject.GetComponent<ConveyorMovementHero>().StopConveyorMove();
			collision.gameObject.GetComponent<HeroController>().cState.inConveyorZone = false;
			collision.gameObject.GetComponent<HeroController>().cState.onConveyorV = false;
		}
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x000666AE File Offset: 0x000648AE
	public ConveyorZone()
	{
		this.activated = true;
		base..ctor();
	}

	// Token: 0x040019B9 RID: 6585
	public float speed;

	// Token: 0x040019BA RID: 6586
	public bool vertical;

	// Token: 0x040019BB RID: 6587
	private bool activated;
}
