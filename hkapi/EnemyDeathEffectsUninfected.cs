using System;
using UnityEngine;

// Token: 0x02000184 RID: 388
public class EnemyDeathEffectsUninfected : EnemyDeathEffects
{
	// Token: 0x060008C8 RID: 2248 RVA: 0x000305BC File Offset: 0x0002E7BC
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
		this.uninfectedDeathPt.Spawn(base.transform.position + this.effectOrigin);
		FlingUtils.SpawnAndFling(new FlingUtils.Config
		{
			Prefab = this.slashEffectGhost1,
			AmountMin = 8,
			AmountMax = 8,
			SpeedMin = 2f,
			SpeedMax = 35f,
			AngleMin = 0f,
			AngleMax = 360f,
			OriginVariationX = 0f,
			OriginVariationY = 0f
		}, base.transform, this.effectOrigin);
		FlingUtils.SpawnAndFling(new FlingUtils.Config
		{
			Prefab = this.slashEffectGhost2,
			AmountMin = 2,
			AmountMax = 3,
			SpeedMin = 2f,
			SpeedMax = 35f,
			AngleMin = 0f,
			AngleMax = 360f,
			OriginVariationX = 0f,
			OriginVariationY = 0f
		}, base.transform, this.effectOrigin);
		base.EmitSound();
		base.ShakeCameraIfVisible("EnemyKillShake");
		UnityEngine.Object.Instantiate<GameObject>(this.whiteWave, base.transform.position + this.effectOrigin, Quaternion.identity);
	}

	// Token: 0x040009BD RID: 2493
	[Header("Uninfected Variables")]
	public GameObject uninfectedDeathPt;

	// Token: 0x040009BE RID: 2494
	public GameObject slashEffectGhost1;

	// Token: 0x040009BF RID: 2495
	public GameObject slashEffectGhost2;

	// Token: 0x040009C0 RID: 2496
	public GameObject whiteWave;
}
