using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001CB RID: 459
[ActionCategory("Hollow Knight")]
public class SetRecoilFreeze : FsmStateAction
{
	// Token: 0x06000A21 RID: 2593 RVA: 0x0003791C File Offset: 0x00035B1C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject)
		{
			Recoil component = gameObject.GetComponent<Recoil>();
			if (component)
			{
				component.freezeInPlace = this.freeze.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000B39 RID: 2873
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000B3A RID: 2874
	public FsmBool freeze;
}
