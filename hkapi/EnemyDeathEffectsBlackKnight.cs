using System;
using UnityEngine;

// Token: 0x02000180 RID: 384
public class EnemyDeathEffectsBlackKnight : EnemyDeathEffects
{
	// Token: 0x060008C0 RID: 2240 RVA: 0x00030398 File Offset: 0x0002E598
	protected override void EmitEffects()
	{
		if (this.corpse != null)
		{
			SpriteFlash component = this.corpse.GetComponent<SpriteFlash>();
			if (component != null)
			{
				component.flashFocusHeal();
			}
		}
		this.deathPuffLargePrefab.Spawn(base.transform.position + this.effectOrigin);
		base.EmitSound();
		base.ShakeCameraIfVisible("AverageShake");
		UnityEngine.Object.Instantiate<GameObject>(this.deathWaveInfectedPrefab, base.transform.position + this.effectOrigin, Quaternion.identity).transform.localScale = new Vector3(2f, 2f, 2f);
	}
}
