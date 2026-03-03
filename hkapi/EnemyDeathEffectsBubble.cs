using System;
using UnityEngine;

// Token: 0x02000181 RID: 385
public class EnemyDeathEffectsBubble : EnemyDeathEffects
{
	// Token: 0x060008C2 RID: 2242 RVA: 0x00030450 File Offset: 0x0002E650
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
		base.ShakeCameraIfVisible("EnemyKillShake");
		GameManager.instance.FreezeMoment(1);
		UnityEngine.Object.Instantiate<GameObject>(this.bubblePopPrefab, base.transform.position + this.effectOrigin, Quaternion.identity);
	}

	// Token: 0x040009BB RID: 2491
	[Header("Bubble Effects")]
	public GameObject bubblePopPrefab;
}
