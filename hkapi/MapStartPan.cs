using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200045B RID: 1115
[ActionCategory("Inventory")]
public class MapStartPan : FsmStateAction
{
	// Token: 0x06001920 RID: 6432 RVA: 0x00077CF4 File Offset: 0x00075EF4
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00077D04 File Offset: 0x00075F04
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			GameMap component = gameObject.GetComponent<GameMap>();
			if (component != null)
			{
				component.StartPan();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E1E RID: 7710
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
