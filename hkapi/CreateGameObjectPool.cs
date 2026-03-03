using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class CreateGameObjectPool : FsmStateAction
{
	// Token: 0x060000F9 RID: 249 RVA: 0x000060CC File Offset: 0x000042CC
	public override void Reset()
	{
		this.prefab = null;
		this.amount = null;
		this.useExisting = new FsmBool(true);
	}

	// Token: 0x060000FA RID: 250 RVA: 0x000060F0 File Offset: 0x000042F0
	public override void OnEnter()
	{
		if (this.prefab.Value)
		{
			int num = this.amount.Value;
			if (this.useExisting.Value)
			{
				List<GameObject> pooled = ObjectPool.GetPooled(this.prefab.Value, null, false);
				num -= pooled.Count;
			}
			if (num > 0)
			{
				ObjectPool.CreatePool(this.prefab.Value, num);
			}
		}
		base.Finish();
	}

	// Token: 0x040000AD RID: 173
	public FsmGameObject prefab;

	// Token: 0x040000AE RID: 174
	public FsmInt amount;

	// Token: 0x040000AF RID: 175
	public FsmBool useExisting;
}
