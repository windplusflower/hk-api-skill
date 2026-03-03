using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200038D RID: 909
public class GetPreInstantiatedGameObject : FsmStateAction
{
	// Token: 0x06001518 RID: 5400 RVA: 0x000643F6 File Offset: 0x000625F6
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00064404 File Offset: 0x00062604
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			PreInstantiateGameObject component = safe.GetComponent<PreInstantiateGameObject>();
			if (component)
			{
				GameObject instantiatedGameObject = component.InstantiatedGameObject;
				if (instantiatedGameObject)
				{
					instantiatedGameObject.SetActive(true);
					this.storeGameObject.Value = instantiatedGameObject;
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04001930 RID: 6448
	[RequiredField]
	public FsmOwnerDefault target;

	// Token: 0x04001931 RID: 6449
	[RequiredField]
	[UIHint(UIHint.Variable)]
	public FsmGameObject storeGameObject;
}
