using System;
using UnityEngine;

// Token: 0x0200011E RID: 286
public class DisableAfterTime : MonoBehaviour
{
	// Token: 0x060006AD RID: 1709 RVA: 0x00026F8F File Offset: 0x0002518F
	private void OnEnable()
	{
		this.disableTime = Time.time + this.waitTime;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00026FA3 File Offset: 0x000251A3
	private void Update()
	{
		if (Time.time >= this.disableTime)
		{
			if (this.sendEvent != "")
			{
				FSMUtility.SendEventToGameObject(base.gameObject, this.sendEvent, false);
				return;
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00026FE3 File Offset: 0x000251E3
	public DisableAfterTime()
	{
		this.waitTime = 5f;
		base..ctor();
	}

	// Token: 0x04000745 RID: 1861
	public float waitTime;

	// Token: 0x04000746 RID: 1862
	private float disableTime;

	// Token: 0x04000747 RID: 1863
	public string sendEvent;
}
