using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000462 RID: 1122
[ActionCategory("Hollow Knight")]
public class SelectCharmBackboard : FsmStateAction
{
	// Token: 0x06001942 RID: 6466 RVA: 0x00078AA1 File Offset: 0x00076CA1
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00078AB0 File Offset: 0x00076CB0
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			InvCharmBackboard component = gameObject.GetComponent<InvCharmBackboard>();
			if (component != null)
			{
				component.SelectCharm();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E56 RID: 7766
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
