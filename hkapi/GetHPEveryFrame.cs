using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[ActionCategory("Hollow Knight")]
public class GetHPEveryFrame : FsmStateAction
{
	// Token: 0x06000973 RID: 2419 RVA: 0x00034463 File Offset: 0x00032663
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.storeValue = new FsmInt
		{
			UseVariable = true
		};
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00034484 File Offset: 0x00032684
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			this.healthManager = safe.GetComponent<HealthManager>();
		}
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x000344B3 File Offset: 0x000326B3
	public override void OnUpdate()
	{
		if (this.healthManager != null && !this.storeValue.IsNone)
		{
			this.storeValue.Value = this.healthManager.hp;
		}
	}

	// Token: 0x04000A8F RID: 2703
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A90 RID: 2704
	[UIHint(UIHint.Variable)]
	public FsmInt storeValue;

	// Token: 0x04000A91 RID: 2705
	private HealthManager healthManager;
}
