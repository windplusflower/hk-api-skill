using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000463 RID: 1123
[ActionCategory("Hollow Knight")]
public class GetCharmNum : FsmStateAction
{
	// Token: 0x06001945 RID: 6469 RVA: 0x00078B08 File Offset: 0x00076D08
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00078B18 File Offset: 0x00076D18
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			InvCharmBackboard component = gameObject.GetComponent<InvCharmBackboard>();
			if (component != null)
			{
				this.storeValue.Value = component.GetCharmNum();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E57 RID: 7767
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04001E58 RID: 7768
	public FsmInt storeValue;
}
