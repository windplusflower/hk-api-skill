using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200045A RID: 1114
[ActionCategory("Inventory")]
public class MapStopPan : FsmStateAction
{
	// Token: 0x0600191D RID: 6429 RVA: 0x00077C8F File Offset: 0x00075E8F
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00077C9C File Offset: 0x00075E9C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			GameMap component = gameObject.GetComponent<GameMap>();
			if (component != null)
			{
				component.StopPan();
			}
		}
		base.Finish();
	}

	// Token: 0x04001E1D RID: 7709
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
