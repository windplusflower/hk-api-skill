using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000026 RID: 38
[ActionCategory("Hollow Knight")]
public class PreSpawnGameObjects : FsmStateAction
{
	// Token: 0x060000FF RID: 255 RVA: 0x000061B0 File Offset: 0x000043B0
	public override void Reset()
	{
		this.prefab = null;
		this.storeArray = null;
		this.spawnAmount = null;
		this.spawnAmountMultiplier = 1;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000061D4 File Offset: 0x000043D4
	public override void OnEnter()
	{
		if (this.prefab.Value && !this.storeArray.IsNone && this.spawnAmount.Value > 0 && this.spawnAmountMultiplier.Value > 0)
		{
			int num = this.spawnAmount.Value * this.spawnAmountMultiplier.Value;
			this.storeArray.Resize(num);
			for (int i = 0; i < num; i++)
			{
				this.storeArray.Values[i] = UnityEngine.Object.Instantiate<GameObject>(this.prefab.Value);
				((GameObject)this.storeArray.Values[i]).SetActive(false);
			}
		}
		base.Finish();
	}

	// Token: 0x040000B1 RID: 177
	public FsmGameObject prefab;

	// Token: 0x040000B2 RID: 178
	[UIHint(UIHint.Variable)]
	[ArrayEditor(VariableType.GameObject, "", 0, 0, 65536)]
	public FsmArray storeArray;

	// Token: 0x040000B3 RID: 179
	public FsmInt spawnAmount;

	// Token: 0x040000B4 RID: 180
	public FsmInt spawnAmountMultiplier;
}
