using System;
using UnityEngine;

// Token: 0x0200013F RID: 319
public class ParticleSystemAutoDisable : MonoBehaviour
{
	// Token: 0x06000774 RID: 1908 RVA: 0x0002A911 File Offset: 0x00028B11
	public void Start()
	{
		this.ps = base.GetComponent<ParticleSystem>();
		if (!this.ps)
		{
			this.ps = base.GetComponentInChildren<ParticleSystem>();
		}
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0002A938 File Offset: 0x00028B38
	public void Update()
	{
		if (this.ps)
		{
			if (this.ps.IsAlive())
			{
				this.activated = true;
			}
			if (!this.ps.IsAlive() && this.activated)
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x0400084C RID: 2124
	private ParticleSystem ps;

	// Token: 0x0400084D RID: 2125
	private bool activated;
}
