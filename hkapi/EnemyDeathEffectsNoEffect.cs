using System;

// Token: 0x02000183 RID: 387
public class EnemyDeathEffectsNoEffect : EnemyDeathEffects
{
	// Token: 0x060008C6 RID: 2246 RVA: 0x0003057C File Offset: 0x0002E77C
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
		this.doKillFreeze = false;
	}
}
