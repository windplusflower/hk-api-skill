using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004FA RID: 1274
public static class StaticVariableList
{
	// Token: 0x06001C20 RID: 7200 RVA: 0x000850F0 File Offset: 0x000832F0
	public static void Clear()
	{
		if (StaticVariableList.variables != null)
		{
			StaticVariableList.variables.Clear();
		}
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x00085103 File Offset: 0x00083303
	public static void SetValue<T>(string variableName, T value)
	{
		if (StaticVariableList.variables == null)
		{
			StaticVariableList.variables = new Dictionary<string, object>();
		}
		StaticVariableList.variables[variableName] = value;
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x00085128 File Offset: 0x00083328
	public static T GetValue<T>(string variableName)
	{
		if (StaticVariableList.variables == null || !StaticVariableList.variables.ContainsKey(variableName))
		{
			Debug.LogError(string.Format("Attempt to get {0} from static variable list failed!", variableName));
			return default(T);
		}
		return (T)((object)StaticVariableList.variables[variableName]);
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x00085173 File Offset: 0x00083373
	public static bool Exists(string variableName)
	{
		return StaticVariableList.variables != null && StaticVariableList.variables.ContainsKey(variableName);
	}

	// Token: 0x040021E3 RID: 8675
	public static Dictionary<string, object> variables;
}
