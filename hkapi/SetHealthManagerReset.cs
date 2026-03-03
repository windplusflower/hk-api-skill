using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AD RID: 429
[ActionCategory("Hollow Knight")]
public class SetHealthManagerReset : FsmStateAction
{
	// Token: 0x06000983 RID: 2435 RVA: 0x000346FF File Offset: 0x000328FF
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.reset = new FsmBool();
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00034718 File Offset: 0x00032918
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				component.deathReset = this.reset.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A9C RID: 2716
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A9D RID: 2717
	public FsmBool reset;
}
