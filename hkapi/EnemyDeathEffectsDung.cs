using System;
using UnityEngine;

// Token: 0x02000182 RID: 386
public class EnemyDeathEffectsDung : EnemyDeathEffects
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x000304C4 File Offset: 0x0002E6C4
	protected override void EmitEffects()
	{
		if (this.corpse != null)
		{
			SpriteFlash component = this.corpse.GetComponent<SpriteFlash>();
			if (component != null)
			{
				component.flashDung();
			}
		}
		this.deathPuffDung.Spawn(base.transform.position + this.effectOrigin);
		base.EmitSound();
		base.ShakeCameraIfVisible("AverageShake");
		UnityEngine.Object.Instantiate<GameObject>(this.deathWaveInfectedPrefab, base.transform.position + this.effectOrigin, Quaternion.identity).transform.localScale = new Vector3(2f, 2f, 2f);
		GameManager.instance.FreezeMoment(1);
	}

	// Token: 0x040009BC RID: 2492
	[Header("Dung Variables")]
	public GameObject deathPuffDung;
}
