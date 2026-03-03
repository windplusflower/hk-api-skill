using System;
using UnityEngine;

// Token: 0x02000141 RID: 321
public class PlayParticleOnEntry : MonoBehaviour
{
	// Token: 0x0600077A RID: 1914 RVA: 0x0002A9EC File Offset: 0x00028BEC
	private void Start()
	{
		this.particle = base.GetComponent<ParticleSystem>();
		if (this.particle)
		{
			this.particle.Stop();
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0002AA12 File Offset: 0x00028C12
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.particle)
		{
			this.particle.Play();
		}
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0002AA2C File Offset: 0x00028C2C
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (this.particle)
		{
			this.particle.Stop();
		}
	}

	// Token: 0x04000850 RID: 2128
	private ParticleSystem particle;
}
