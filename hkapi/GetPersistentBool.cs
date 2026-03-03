using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000521 RID: 1313
[ActionCategory("Hollow Knight")]
public class GetPersistentBool : FsmStateAction
{
	// Token: 0x06001CD7 RID: 7383 RVA: 0x0008663C File Offset: 0x0008483C
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001CD8 RID: 7384 RVA: 0x0008664C File Offset: 0x0008484C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			PersistentBoolItem component = gameObject.GetComponent<PersistentBoolItem>();
			this.storeValue.Value = component.persistentBoolData.activated;
		}
		base.Finish();
	}

	// Token: 0x04002240 RID: 8768
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04002241 RID: 8769
	public FsmBool storeValue;
}
