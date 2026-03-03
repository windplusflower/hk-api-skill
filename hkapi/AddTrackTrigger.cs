using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200041F RID: 1055
[ActionCategory("Hollow Knight")]
public class AddTrackTrigger : FsmStateAction
{
	// Token: 0x060017CD RID: 6093 RVA: 0x00070509 File Offset: 0x0006E709
	public override void Reset()
	{
		this.target = null;
		this.skipIfPresent = true;
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x00070520 File Offset: 0x0006E720
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe && !safe.GetComponent<TrackTriggerObjects>())
		{
			safe.AddComponent<TrackTriggerObjects>();
		}
		base.Finish();
	}

	// Token: 0x04001C91 RID: 7313
	public FsmOwnerDefault target;

	// Token: 0x04001C92 RID: 7314
	public FsmBool skipIfPresent;
}
