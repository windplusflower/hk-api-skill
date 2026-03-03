using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000465 RID: 1125
[ActionCategory("Hollow Knight")]
public class GetCharmNumString : FsmStateAction
{
	// Token: 0x0600194B RID: 6475 RVA: 0x00078BEB File Offset: 0x00076DEB
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00078BF8 File Offset: 0x00076DF8
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			InvCharmBackboard component = gameObject.GetComponent<InvCharmBackboard>();
			if (component != null)
			{
				this.storeValue.Value = component.GetCharmNumString();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E5B RID: 7771
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04001E5C RID: 7772
	public FsmString storeValue;
}
