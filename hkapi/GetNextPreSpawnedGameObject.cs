using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000027 RID: 39
[ActionCategory("Hollow Knight")]
public class GetNextPreSpawnedGameObject : FsmStateAction
{
	// Token: 0x06000102 RID: 258 RVA: 0x0000628D File Offset: 0x0000448D
	public override void Reset()
	{
		this.storedArray = null;
		this.spawnPosition = null;
		this.storeObject = null;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x000062A4 File Offset: 0x000044A4
	public override void OnEnter()
	{
		if (!this.currentIndex.IsNone && this.currentIndex.Value < this.storedArray.Length)
		{
			GameObject gameObject = (GameObject)this.storedArray.Values[this.currentIndex.Value];
			if (!this.spawnPosition.IsNone)
			{
				gameObject.transform.position = this.spawnPosition.Value;
			}
			gameObject.SetActive(true);
			this.storeObject.Value = gameObject;
			FsmInt fsmInt = this.currentIndex;
			int value = fsmInt.Value;
			fsmInt.Value = value + 1;
		}
		base.Finish();
	}

	// Token: 0x040000B5 RID: 181
	[UIHint(UIHint.Variable)]
	[ArrayEditor(VariableType.GameObject, "", 0, 0, 65536)]
	public FsmArray storedArray;

	// Token: 0x040000B6 RID: 182
	public FsmVector3 spawnPosition;

	// Token: 0x040000B7 RID: 183
	[UIHint(UIHint.Variable)]
	public FsmGameObject storeObject;

	// Token: 0x040000B8 RID: 184
	[UIHint(UIHint.Variable)]
	public FsmInt currentIndex;
}
