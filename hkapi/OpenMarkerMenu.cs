using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200047A RID: 1146
[ActionCategory("Inventory")]
public class OpenMarkerMenu : FsmStateAction
{
	// Token: 0x060019BA RID: 6586 RVA: 0x0007BF04 File Offset: 0x0007A104
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0007BF14 File Offset: 0x0007A114
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			MapMarkerMenu component = gameObject.GetComponent<MapMarkerMenu>();
			if (component != null)
			{
				component.Open();
			}
		}
		base.Finish();
	}

	// Token: 0x04001F1C RID: 7964
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
