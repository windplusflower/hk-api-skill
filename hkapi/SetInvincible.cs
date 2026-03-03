using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[ActionCategory("Hollow Knight")]
public class SetInvincible : FsmStateAction
{
	// Token: 0x0600095B RID: 2395 RVA: 0x000340AB File Offset: 0x000322AB
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.Invincible = null;
		this.InvincibleFromDirection = null;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x000340C8 File Offset: 0x000322C8
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null)
			{
				if (!this.Invincible.IsNone)
				{
					component.IsInvincible = this.Invincible.Value;
				}
				if (!this.InvincibleFromDirection.IsNone)
				{
					component.InvincibleFromDirection = this.InvincibleFromDirection.Value;
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04000A7E RID: 2686
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A7F RID: 2687
	public FsmBool Invincible;

	// Token: 0x04000A80 RID: 2688
	public FsmInt InvincibleFromDirection;
}
