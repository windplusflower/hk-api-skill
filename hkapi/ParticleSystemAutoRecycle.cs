using System;
using UnityEngine;

// Token: 0x02000140 RID: 320
public class ParticleSystemAutoRecycle : MonoBehaviour
{
	// Token: 0x06000777 RID: 1911 RVA: 0x0002A987 File Offset: 0x00028B87
	public void Start()
	{
		this.ps = base.GetComponent<ParticleSystem>();
		if (!this.ps)
		{
			this.ps = base.GetComponentInChildren<ParticleSystem>();
		}
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0002A9AE File Offset: 0x00028BAE
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
				this.Recycle<ParticleSystemAutoRecycle>();
			}
		}
	}

	// Token: 0x0400084E RID: 2126
	private ParticleSystem ps;

	// Token: 0x0400084F RID: 2127
	private bool activated;
}
