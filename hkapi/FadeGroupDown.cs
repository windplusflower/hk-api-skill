using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000456 RID: 1110
[ActionCategory("Hollow Knight")]
public class FadeGroupDown : FsmStateAction
{
	// Token: 0x060018E9 RID: 6377 RVA: 0x00074A48 File Offset: 0x00072C48
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00074A58 File Offset: 0x00072C58
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			FadeGroup component = gameObject.GetComponent<FadeGroup>();
			if (component != null)
			{
				if (this.fast.Value)
				{
					component.FadeDownFast();
				}
				else
				{
					component.FadeDown();
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04001DDE RID: 7646
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04001DDF RID: 7647
	public FsmBool fast;
}
