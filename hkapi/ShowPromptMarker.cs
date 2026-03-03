using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000393 RID: 915
public class ShowPromptMarker : FsmStateAction
{
	// Token: 0x06001533 RID: 5427 RVA: 0x00064804 File Offset: 0x00062A04
	public override void Reset()
	{
		this.prefab = new FsmGameObject();
		this.labelName = new FsmString();
		this.spawnPoint = new FsmGameObject();
		this.storeObject = new FsmGameObject();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00064834 File Offset: 0x00062A34
	public override void OnEnter()
	{
		if (this.prefab.Value && this.spawnPoint.Value)
		{
			GameObject gameObject;
			if (this.storeObject.Value)
			{
				gameObject = this.storeObject.Value;
			}
			else
			{
				gameObject = this.prefab.Value.Spawn();
				this.storeObject.Value = gameObject;
			}
			gameObject.transform.position = this.spawnPoint.Value.transform.position;
			PromptMarker component = gameObject.GetComponent<PromptMarker>();
			if (component)
			{
				component.SetLabel(this.labelName.Value);
				component.SetOwner(base.Owner);
				component.Show();
			}
		}
		base.Finish();
	}

	// Token: 0x0400193F RID: 6463
	public FsmGameObject prefab;

	// Token: 0x04001940 RID: 6464
	public FsmString labelName;

	// Token: 0x04001941 RID: 6465
	[UIHint(UIHint.Variable)]
	public FsmGameObject spawnPoint;

	// Token: 0x04001942 RID: 6466
	[UIHint(UIHint.Variable)]
	public FsmGameObject storeObject;
}
