using System;
using UnityEngine;

// Token: 0x020001E9 RID: 489
public class ExtraDamageableProxy : MonoBehaviour, IExtraDamageable
{
	// Token: 0x06000AA4 RID: 2724 RVA: 0x00039671 File Offset: 0x00037871
	void IExtraDamageable.RecieveExtraDamage(ExtraDamageTypes extraDamageTypes)
	{
		if (this.passTo != null)
		{
			this.passTo.RecieveExtraDamage(extraDamageTypes);
		}
	}

	// Token: 0x04000BBA RID: 3002
	public ExtraDamageable passTo;
}
