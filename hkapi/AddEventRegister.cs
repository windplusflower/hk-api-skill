using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001E8 RID: 488
[ActionCategory("Hollow Knight")]
public class AddEventRegister : FsmStateAction
{
	// Token: 0x06000AA1 RID: 2721 RVA: 0x0003960E File Offset: 0x0003780E
	public override void Reset()
	{
		this.eventName = new FsmString();
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0003961C File Offset: 0x0003781C
	public override void OnEnter()
	{
		if (this.eventName.Value != "")
		{
			GameObject safe = this.target.GetSafe(this);
			if (safe)
			{
				safe.AddComponent<EventRegister>().SwitchEvent(this.eventName.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000BB8 RID: 3000
	public FsmOwnerDefault target;

	// Token: 0x04000BB9 RID: 3001
	public FsmString eventName;
}
