using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001C1 RID: 449
[ActionCategory("Hollow Knight")]
public class BehaviourListRemove : FsmStateAction
{
	// Token: 0x060009EF RID: 2543 RVA: 0x00037109 File Offset: 0x00035309
	public override void Reset()
	{
		this.owner = new FsmOwnerDefault();
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00037118 File Offset: 0x00035318
	public override void OnEnter()
	{
		GameObject safe = this.owner.GetSafe(this);
		if (safe)
		{
			LimitBehaviour component = safe.GetComponent<LimitBehaviour>();
			if (component)
			{
				component.RemoveSelf();
			}
		}
		base.Finish();
	}

	// Token: 0x04000B16 RID: 2838
	[RequiredField]
	public FsmOwnerDefault owner;
}
