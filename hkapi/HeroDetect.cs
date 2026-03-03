using System;
using UnityEngine;

// Token: 0x020002A2 RID: 674
public class HeroDetect : MonoBehaviour
{
	// Token: 0x1400001D RID: 29
	// (add) Token: 0x06000E17 RID: 3607 RVA: 0x00045430 File Offset: 0x00043630
	// (remove) Token: 0x06000E18 RID: 3608 RVA: 0x00045468 File Offset: 0x00043668
	public event HeroDetect.ColliderEvent OnEnter;

	// Token: 0x1400001E RID: 30
	// (add) Token: 0x06000E19 RID: 3609 RVA: 0x000454A0 File Offset: 0x000436A0
	// (remove) Token: 0x06000E1A RID: 3610 RVA: 0x000454D8 File Offset: 0x000436D8
	public event HeroDetect.ColliderEvent OnExit;

	// Token: 0x06000E1B RID: 3611 RVA: 0x0004550D File Offset: 0x0004370D
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.OnEnter != null)
		{
			this.OnEnter(collision);
		}
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00045523 File Offset: 0x00043723
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (this.OnExit != null)
		{
			this.OnExit(collision);
		}
	}

	// Token: 0x020002A3 RID: 675
	// (Invoke) Token: 0x06000E1F RID: 3615
	public delegate void ColliderEvent(Collider2D collider);
}
