using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000522 RID: 1314
public class GetPersistentBoolFromSaveData : FsmStateAction
{
	// Token: 0x06001CDA RID: 7386 RVA: 0x000866AB File Offset: 0x000848AB
	public bool ShouldHideDirect()
	{
		return this.Target.OwnerOption == OwnerDefaultOption.UseOwner || (this.Target.GameObject != null && this.Target.GameObject.Value != null);
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x000866E1 File Offset: 0x000848E1
	public override void Reset()
	{
		this.Target = new FsmOwnerDefault
		{
			OwnerOption = OwnerDefaultOption.SpecifyGameObject,
			GameObject = null
		};
		this.SceneName = null;
		this.ID = null;
		this.StoreValue = null;
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x00086714 File Offset: 0x00084914
	public override void OnEnter()
	{
		GameObject safe = this.Target.GetSafe(this);
		string sceneName;
		string id;
		if (safe != null)
		{
			PersistentBoolData persistentBoolData = safe.GetComponent<PersistentBoolItem>().persistentBoolData;
			sceneName = persistentBoolData.sceneName;
			id = persistentBoolData.id;
		}
		else
		{
			sceneName = this.SceneName.Value;
			id = this.ID.Value;
		}
		PersistentBoolData persistentBoolData2 = SceneData.instance.FindMyState(new PersistentBoolData
		{
			id = id,
			sceneName = sceneName
		});
		this.StoreValue.Value = (persistentBoolData2 != null && persistentBoolData2.activated);
		base.Finish();
	}

	// Token: 0x04002242 RID: 8770
	[CheckForComponent(typeof(PersistentBoolItem))]
	public FsmOwnerDefault Target;

	// Token: 0x04002243 RID: 8771
	[HideIf("ShouldHideDirect")]
	public FsmString SceneName;

	// Token: 0x04002244 RID: 8772
	[HideIf("ShouldHideDirect")]
	public FsmString ID;

	// Token: 0x04002245 RID: 8773
	[UIHint(UIHint.Variable)]
	public FsmBool StoreValue;
}
