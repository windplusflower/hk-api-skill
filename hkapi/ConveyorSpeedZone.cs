using System;
using UnityEngine;

// Token: 0x020003A5 RID: 933
public class ConveyorSpeedZone : MonoBehaviour
{
	// Token: 0x06001570 RID: 5488 RVA: 0x000664E9 File Offset: 0x000646E9
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.GetComponent<HeroController>())
		{
			collision.gameObject.GetComponent<HeroController>().SetConveyorSpeed(this.speed);
		}
	}

	// Token: 0x040019B8 RID: 6584
	public float speed;
}
