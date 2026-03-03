using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000455 RID: 1109
[ActionCategory("Hollow Knight")]
public class FadeGroupUp : FsmStateAction
{
	// Token: 0x060018E6 RID: 6374 RVA: 0x000749E1 File Offset: 0x00072BE1
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x000749F0 File Offset: 0x00072BF0
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			FadeGroup component = gameObject.GetComponent<FadeGroup>();
			if (component != null)
			{
				component.FadeUp();
			}
		}
		base.Finish();
	}

	// Token: 0x04001DDD RID: 7645
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
