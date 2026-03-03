using System;
using UnityEngine;

// Token: 0x020003DE RID: 990
public class RestBench : MonoBehaviour
{
	// Token: 0x06001695 RID: 5781 RVA: 0x0006AF76 File Offset: 0x00069176
	private void Start()
	{
		this.heroCtrl = HeroController.instance;
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0006AF83 File Offset: 0x00069183
	private void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.gameObject.layer == 9)
		{
			this.heroCtrl.NearBench(true);
		}
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0006AFA0 File Offset: 0x000691A0
	private void OnTriggerExit2D(Collider2D otherObject)
	{
		if (otherObject.gameObject.layer == 9)
		{
			this.heroCtrl.NearBench(false);
		}
	}

	// Token: 0x04001B36 RID: 6966
	private HeroController heroCtrl;
}
