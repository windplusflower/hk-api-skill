using System;
using UnityEngine;

// Token: 0x02000424 RID: 1060
public class TriggerEnterEvent : MonoBehaviour
{
	// Token: 0x14000034 RID: 52
	// (add) Token: 0x060017E8 RID: 6120 RVA: 0x00070B58 File Offset: 0x0006ED58
	// (remove) Token: 0x060017E9 RID: 6121 RVA: 0x00070B90 File Offset: 0x0006ED90
	public event TriggerEnterEvent.CollisionEvent OnTriggerEntered;

	// Token: 0x14000035 RID: 53
	// (add) Token: 0x060017EA RID: 6122 RVA: 0x00070BC8 File Offset: 0x0006EDC8
	// (remove) Token: 0x060017EB RID: 6123 RVA: 0x00070C00 File Offset: 0x0006EE00
	public event TriggerEnterEvent.CollisionEvent OnTriggerExited;

	// Token: 0x14000036 RID: 54
	// (add) Token: 0x060017EC RID: 6124 RVA: 0x00070C38 File Offset: 0x0006EE38
	// (remove) Token: 0x060017ED RID: 6125 RVA: 0x00070C70 File Offset: 0x0006EE70
	public event TriggerEnterEvent.CollisionEvent OnTriggerStayed;

	// Token: 0x060017EE RID: 6126 RVA: 0x00070CA8 File Offset: 0x0006EEA8
	private void Start()
	{
		this.active = false;
		if (!this.waitForHeroInPosition)
		{
			this.active = true;
			return;
		}
		if (HeroController.instance.isHeroInPosition)
		{
			this.active = true;
			return;
		}
		HeroController.HeroInPosition temp = null;
		temp = delegate(bool forceDirect)
		{
			this.active = true;
			HeroController.instance.heroInPosition -= temp;
		};
		HeroController.instance.heroInPosition += temp;
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00070D16 File Offset: 0x0006EF16
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.active)
		{
			return;
		}
		if (this.OnTriggerEntered != null)
		{
			this.OnTriggerEntered(collision, base.gameObject);
		}
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00070D3B File Offset: 0x0006EF3B
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (!this.active)
		{
			return;
		}
		if (this.OnTriggerExited != null)
		{
			this.OnTriggerExited(collision, base.gameObject);
		}
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00070D60 File Offset: 0x0006EF60
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (!this.active)
		{
			return;
		}
		if (this.OnTriggerStayed != null)
		{
			this.OnTriggerStayed(collision, base.gameObject);
		}
	}

	// Token: 0x04001CBD RID: 7357
	public bool waitForHeroInPosition;

	// Token: 0x04001CBE RID: 7358
	private bool active;

	// Token: 0x02000425 RID: 1061
	// (Invoke) Token: 0x060017F4 RID: 6132
	public delegate void CollisionEvent(Collider2D collider, GameObject sender);
}
