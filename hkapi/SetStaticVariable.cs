using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020004FB RID: 1275
public class SetStaticVariable : FsmStateAction
{
	// Token: 0x06001C24 RID: 7204 RVA: 0x00085189 File Offset: 0x00083389
	public override void Reset()
	{
		this.variableName = null;
		this.setValue = null;
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x0008519C File Offset: 0x0008339C
	public override void OnEnter()
	{
		if (!this.variableName.IsNone && !this.setValue.IsNone)
		{
			Type realType = this.setValue.RealType;
			object valueFromFsmVar = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.setValue);
			switch (this.setValue.Type)
			{
			case VariableType.Float:
				StaticVariableList.SetValue<float>(this.variableName.Value, (float)valueFromFsmVar);
				goto IL_11B;
			case VariableType.Int:
				StaticVariableList.SetValue<int>(this.variableName.Value, (int)valueFromFsmVar);
				goto IL_11B;
			case VariableType.Bool:
				StaticVariableList.SetValue<bool>(this.variableName.Value, (bool)valueFromFsmVar);
				goto IL_11B;
			case VariableType.String:
				StaticVariableList.SetValue<string>(this.variableName.Value, (string)valueFromFsmVar);
				goto IL_11B;
			}
			Debug.LogWarning(string.Format("Couldn't set static variable: {0}, Variable type \"{1}\" not implemented!", this.variableName.Value, this.setValue.Type.ToString()));
		}
		else
		{
			Debug.LogWarning(string.Format("Couldn't set static variable: {0}", this.variableName.Value));
		}
		IL_11B:
		base.Finish();
	}

	// Token: 0x040021E4 RID: 8676
	public FsmString variableName;

	// Token: 0x040021E5 RID: 8677
	public FsmVar setValue;
}
