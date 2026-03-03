using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class HeroPlatformStick : MonoBehaviour
{
	// Token: 0x0600003D RID: 61 RVA: 0x00003404 File Offset: 0x00001604
	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject gameObject = collision.gameObject;
		if (gameObject.layer == 9)
		{
			HeroController component = gameObject.GetComponent<HeroController>();
			if (component != null)
			{
				component.SetHeroParent(base.transform);
			}
			else
			{
				gameObject.transform.SetParent(base.transform);
			}
			Rigidbody2D component2 = gameObject.GetComponent<Rigidbody2D>();
			if (component2 != null)
			{
				component2.interpolation = RigidbodyInterpolation2D.None;
			}
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00003468 File Offset: 0x00001668
	private void OnCollisionExit2D(Collision2D collision)
	{
		GameObject gameObject = collision.gameObject;
		if (gameObject.layer == 9)
		{
			HeroController component = gameObject.GetComponent<HeroController>();
			if (component != null)
			{
				component.SetHeroParent(null);
			}
			else
			{
				gameObject.transform.SetParent(null);
			}
			Rigidbody2D component2 = gameObject.GetComponent<Rigidbody2D>();
			if (component2 != null)
			{
				component2.interpolation = RigidbodyInterpolation2D.Interpolate;
			}
		}
	}
}
