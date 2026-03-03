using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200047B RID: 1147
[ActionCategory("Inventory")]
public class CloseMarkerMenu : FsmStateAction
{
	// Token: 0x060019BD RID: 6589 RVA: 0x0007BF6C File Offset: 0x0007A16C
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x0007BF7C File Offset: 0x0007A17C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			MapMarkerMenu component = gameObject.GetComponent<MapMarkerMenu>();
			if (component != null)
			{
				component.Close();
			}
		}
		base.Finish();
	}

	// Token: 0x04001F1D RID: 7965
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
