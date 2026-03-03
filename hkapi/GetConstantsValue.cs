using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020004D5 RID: 1237
[ActionCategory("Hollow Knight")]
public class GetConstantsValue : FsmStateAction
{
	// Token: 0x06001B61 RID: 7009 RVA: 0x00083490 File Offset: 0x00081690
	public override void Reset()
	{
		this.variableName = null;
		this.storeValue = null;
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x000834A0 File Offset: 0x000816A0
	public override void OnEnter()
	{
		if (!this.variableName.IsNone && !this.storeValue.IsNone)
		{
			switch (this.storeValue.Type)
			{
			case VariableType.Float:
				this.storeValue.SetValue(Constants.GetConstantValue<float>(this.variableName.Value));
				goto IL_123;
			case VariableType.Int:
				this.storeValue.SetValue(Constants.GetConstantValue<int>(this.variableName.Value));
				goto IL_123;
			case VariableType.Bool:
				this.storeValue.SetValue(Constants.GetConstantValue<bool>(this.variableName.Value));
				goto IL_123;
			case VariableType.String:
				this.storeValue.SetValue(Constants.GetConstantValue<string>(this.variableName.Value));
				goto IL_123;
			}
			Debug.LogWarning(string.Format("Couldn't get constant value: {0}, Variable type \"{1}\" not implemented!", this.variableName.Value, this.storeValue.Type.ToString()));
		}
		else
		{
			Debug.LogWarning(string.Format("Couldn't get constant value: {0}, please ensure variableName and storeValue are not empty.", this.variableName.Value));
		}
		IL_123:
		base.Finish();
	}

	// Token: 0x04002190 RID: 8592
	public FsmString variableName;

	// Token: 0x04002191 RID: 8593
	[UIHint(UIHint.Variable)]
	public FsmVar storeValue;
}
