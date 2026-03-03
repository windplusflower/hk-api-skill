using System;
using UnityEngine;

// Token: 0x020002C3 RID: 707
public class KillOnContact : MonoBehaviour
{
	// Token: 0x06000EF3 RID: 3827 RVA: 0x00049BAC File Offset: 0x00047DAC
	private void OnCollisionEnter2D(Collision2D collision)
	{
		HealthManager component = collision.gameObject.GetComponent<HealthManager>();
		if (component)
		{
			component.Die(null, AttackTypes.Generic, true);
			return;
		}
		GeoControl component2 = collision.gameObject.GetComponent<GeoControl>();
		if (component2)
		{
			component2.Disable(0f);
			return;
		}
		HeroController component3 = collision.gameObject.GetComponent<HeroController>();
		if (component3)
		{
			base.StartCoroutine(component3.HazardRespawn());
		}
	}
}
