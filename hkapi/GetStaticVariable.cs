using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020004FC RID: 1276
public class GetStaticVariable : FsmStateAction
{
	// Token: 0x06001C27 RID: 7207 RVA: 0x000852CA File Offset: 0x000834CA
	public override void Reset()
	{
		this.variableName = null;
		this.storeValue = null;
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x000852DC File Offset: 0x000834DC
	public override void OnEnter()
	{
		if (!this.variableName.IsNone && !this.storeValue.IsNone && StaticVariableList.Exists(this.variableName.Value))
		{
			switch (this.storeValue.Type)
			{
			case VariableType.Float:
				this.storeValue.SetValue(StaticVariableList.GetValue<float>(this.variableName.Value));
				goto IL_138;
			case VariableType.Int:
				this.storeValue.SetValue(StaticVariableList.GetValue<int>(this.variableName.Value));
				goto IL_138;
			case VariableType.Bool:
				this.storeValue.SetValue(StaticVariableList.GetValue<bool>(this.variableName.Value));
				goto IL_138;
			case VariableType.String:
				this.storeValue.SetValue(StaticVariableList.GetValue<string>(this.variableName.Value));
				goto IL_138;
			}
			Debug.LogWarning(string.Format("Couldn't get static variable: {0}, Variable type \"{1}\" not implemented!", this.variableName.Value, this.storeValue.Type.ToString()));
		}
		else
		{
			Debug.LogWarning(string.Format("Couldn't get static variable: {0}", this.variableName.Value));
		}
		IL_138:
		base.Finish();
	}

	// Token: 0x040021E6 RID: 8678
	public FsmString variableName;

	// Token: 0x040021E7 RID: 8679
	[UIHint(UIHint.Variable)]
	public FsmVar storeValue;
}
