using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000178 RID: 376
[ActionCategory("Hollow Knight")]
public class SetDamageHeroAmount : FsmStateAction
{
	// Token: 0x0600089F RID: 2207 RVA: 0x0002F451 File Offset: 0x0002D651
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.damageDealt = null;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x0002F468 File Offset: 0x0002D668
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			DamageHero component = safe.GetComponent<DamageHero>();
			if (component != null && !this.damageDealt.IsNone)
			{
				component.damageDealt = this.damageDealt.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x0400098A RID: 2442
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x0400098B RID: 2443
	public FsmInt damageDealt;
}
