using System;
using UnityEngine;

// Token: 0x0200018F RID: 399
public class EnemyKillEventListener : MonoBehaviour
{
	// Token: 0x060008EF RID: 2287 RVA: 0x00031E9F File Offset: 0x0003009F
	private void Awake()
	{
		this.healthManager = base.GetComponent<HealthManager>();
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00031EAD File Offset: 0x000300AD
	private void OnEnable()
	{
		if (this.killEvent)
		{
			this.killEvent.OnReceivedEvent += this.Die;
		}
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00031ED3 File Offset: 0x000300D3
	private void OnDisable()
	{
		if (this.killEvent)
		{
			this.killEvent.OnReceivedEvent -= this.Die;
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00031EFC File Offset: 0x000300FC
	private void Die()
	{
		if (this.healthManager)
		{
			this.healthManager.Hit(new HitInstance
			{
				AttackType = AttackTypes.Generic,
				CircleDirection = false,
				DamageDealt = 9999,
				Direction = 0f,
				IgnoreInvulnerable = true,
				Multiplier = 1f
			});
		}
	}

	// Token: 0x040009FF RID: 2559
	public EventRegister killEvent;

	// Token: 0x04000A00 RID: 2560
	private HealthManager healthManager;
}
