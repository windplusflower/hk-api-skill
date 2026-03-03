using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001C0 RID: 448
[ActionCategory("Hollow Knight")]
public class BehaviourListAdd : FsmStateAction
{
	// Token: 0x060009EC RID: 2540 RVA: 0x000370BF File Offset: 0x000352BF
	public override void Reset()
	{
		this.owner = new FsmOwnerDefault();
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x000370CC File Offset: 0x000352CC
	public override void OnEnter()
	{
		GameObject safe = this.owner.GetSafe(this);
		if (safe)
		{
			LimitBehaviour component = safe.GetComponent<LimitBehaviour>();
			if (component)
			{
				component.Add();
			}
		}
		base.Finish();
	}

	// Token: 0x04000B15 RID: 2837
	[RequiredField]
	public FsmOwnerDefault owner;
}
