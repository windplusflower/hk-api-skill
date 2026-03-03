using System;
using UnityEngine;

// Token: 0x02000353 RID: 851
public class ParticleSystemAutoDestroy : MonoBehaviour
{
	// Token: 0x06001359 RID: 4953 RVA: 0x0005801C File Offset: 0x0005621C
	public void Start()
	{
		this.ps = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x0005802C File Offset: 0x0005622C
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
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}

	// Token: 0x04001294 RID: 4756
	private ParticleSystem ps;

	// Token: 0x04001295 RID: 4757
	private bool activated;
}
