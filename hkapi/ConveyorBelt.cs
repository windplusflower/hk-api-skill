using System;
using UnityEngine;

// Token: 0x020003A2 RID: 930
public class ConveyorBelt : MonoBehaviour
{
	// Token: 0x06001563 RID: 5475 RVA: 0x00066184 File Offset: 0x00064384
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<ConveyorMovement>())
		{
			collision.gameObject.GetComponent<ConveyorMovement>().StartConveyorMove(this.speed, 0f);
		}
		if (collision.gameObject.GetComponent<DropCrystal>())
		{
			collision.gameObject.GetComponent<DropCrystal>().StartConveyorMove(this.speed, 0f);
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
			collision.gameObject.GetComponent<HeroController>().cState.onConveyor = true;
		}
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00066264 File Offset: 0x00064464
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<ConveyorMovement>())
		{
			collision.gameObject.GetComponent<ConveyorMovement>().StopConveyorMove();
		}
		if (collision.gameObject.GetComponent<DropCrystal>())
		{
			collision.gameObject.GetComponent<DropCrystal>().StopConveyorMove();
		}
		if (collision.gameObject.GetComponent<HeroController>())
		{
			collision.gameObject.GetComponent<ConveyorMovementHero>().StopConveyorMove();
			collision.gameObject.GetComponent<HeroController>().cState.onConveyor = false;
			collision.gameObject.GetComponent<HeroController>().cState.onConveyorV = false;
		}
	}

	// Token: 0x040019AE RID: 6574
	public float speed;

	// Token: 0x040019AF RID: 6575
	public bool vertical;
}
