using System;
using UnityEngine;

// Token: 0x02000177 RID: 375
public class DamageHero : MonoBehaviour
{
	// Token: 0x0600089D RID: 2205 RVA: 0x0002F401 File Offset: 0x0002D601
	private void OnEnable()
	{
		if (this.resetOnEnable)
		{
			if (this.initialValue == null)
			{
				this.initialValue = new int?(this.damageDealt);
				return;
			}
			this.damageDealt = this.initialValue.Value;
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002F43B File Offset: 0x0002D63B
	public DamageHero()
	{
		this.damageDealt = 1;
		this.hazardType = 1;
		base..ctor();
	}

	// Token: 0x04000985 RID: 2437
	public int damageDealt;

	// Token: 0x04000986 RID: 2438
	public int hazardType;

	// Token: 0x04000987 RID: 2439
	public bool shadowDashHazard;

	// Token: 0x04000988 RID: 2440
	public bool resetOnEnable;

	// Token: 0x04000989 RID: 2441
	private int? initialValue;
}
