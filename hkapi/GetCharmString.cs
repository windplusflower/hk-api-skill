using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000464 RID: 1124
[ActionCategory("Hollow Knight")]
public class GetCharmString : FsmStateAction
{
	// Token: 0x06001948 RID: 6472 RVA: 0x00078B7B File Offset: 0x00076D7B
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x00078B88 File Offset: 0x00076D88
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			InvCharmBackboard component = gameObject.GetComponent<InvCharmBackboard>();
			if (component != null)
			{
				this.storeValue.Value = component.GetCharmString();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E59 RID: 7769
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04001E5A RID: 7770
	public FsmString storeValue;
}
