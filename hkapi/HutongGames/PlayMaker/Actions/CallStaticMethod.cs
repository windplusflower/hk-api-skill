using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B40 RID: 2880
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Call a static method in a class.")]
	public class CallStaticMethod : FsmStateAction
	{
		// Token: 0x06003D84 RID: 15748 RVA: 0x0016161B File Offset: 0x0015F81B
		public override void OnEnter()
		{
			this.parametersArray = new object[this.parameters.Length];
			this.DoMethodCall();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00161644 File Offset: 0x0015F844
		public override void OnUpdate()
		{
			this.DoMethodCall();
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x0016164C File Offset: 0x0015F84C
		private void DoMethodCall()
		{
			if (this.className == null || string.IsNullOrEmpty(this.className.Value))
			{
				base.Finish();
				return;
			}
			if (this.cachedClassName != this.className.Value || this.cachedMethodName != this.methodName.Value)
			{
				this.errorString = string.Empty;
				if (!this.DoCache())
				{
					Debug.LogError(this.errorString);
					base.Finish();
					return;
				}
			}
			object value;
			if (this.cachedParameterInfo.Length == 0)
			{
				value = this.cachedMethodInfo.Invoke(null, null);
			}
			else
			{
				for (int i = 0; i < this.parameters.Length; i++)
				{
					FsmVar fsmVar = this.parameters[i];
					fsmVar.UpdateValue();
					this.parametersArray[i] = fsmVar.GetValue();
				}
				value = this.cachedMethodInfo.Invoke(null, this.parametersArray);
			}
			this.storeResult.SetValue(value);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x0016173C File Offset: 0x0015F93C
		private bool DoCache()
		{
			this.cachedType = ReflectionUtils.GetGlobalType(this.className.Value);
			if (this.cachedType == null)
			{
				this.errorString = this.errorString + "Class is invalid: " + this.className.Value + "\n";
				base.Finish();
				return false;
			}
			this.cachedClassName = this.className.Value;
			List<Type> list = new List<Type>(this.parameters.Length);
			foreach (FsmVar fsmVar in this.parameters)
			{
				list.Add(fsmVar.RealType);
			}
			this.cachedMethodInfo = this.cachedType.GetMethod(this.methodName.Value, list.ToArray());
			if (this.cachedMethodInfo == null)
			{
				this.errorString = this.errorString + "Invalid Method Name or Parameters: " + this.methodName.Value + "\n";
				base.Finish();
				return false;
			}
			this.cachedMethodName = this.methodName.Value;
			this.cachedParameterInfo = this.cachedMethodInfo.GetParameters();
			return true;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00161860 File Offset: 0x0015FA60
		public override string ErrorCheck()
		{
			this.errorString = string.Empty;
			this.DoCache();
			if (!string.IsNullOrEmpty(this.errorString))
			{
				return this.errorString;
			}
			if (this.parameters.Length != this.cachedParameterInfo.Length)
			{
				return string.Concat(new string[]
				{
					"Parameter count does not match method.\nMethod has ",
					this.cachedParameterInfo.Length.ToString(),
					" parameters.\nYou specified ",
					this.parameters.Length.ToString(),
					" paramaters."
				});
			}
			for (int i = 0; i < this.parameters.Length; i++)
			{
				Type realType = this.parameters[i].RealType;
				Type parameterType = this.cachedParameterInfo[i].ParameterType;
				if (realType != parameterType)
				{
					string[] array = new string[6];
					array[0] = "Parameters do not match method signature.\nParameter ";
					array[1] = (i + 1).ToString();
					array[2] = " (";
					int num = 3;
					Type type = realType;
					array[num] = ((type != null) ? type.ToString() : null);
					array[4] = ") should be of type: ";
					int num2 = 5;
					Type type2 = parameterType;
					array[num2] = ((type2 != null) ? type2.ToString() : null);
					return string.Concat(array);
				}
			}
			if (this.cachedMethodInfo.ReturnType == typeof(void))
			{
				if (!string.IsNullOrEmpty(this.storeResult.variableName))
				{
					return "Method does not have return.\nSpecify 'none' in Store Result.";
				}
			}
			else if (this.cachedMethodInfo.ReturnType != this.storeResult.RealType)
			{
				string str = "Store Result is of the wrong type.\nIt should be of type: ";
				Type returnType = this.cachedMethodInfo.ReturnType;
				return str + ((returnType != null) ? returnType.ToString() : null);
			}
			return string.Empty;
		}

		// Token: 0x0400419D RID: 16797
		[Tooltip("Full path to the class that contains the static method.")]
		public FsmString className;

		// Token: 0x0400419E RID: 16798
		[Tooltip("The static method to call.")]
		public FsmString methodName;

		// Token: 0x0400419F RID: 16799
		[Tooltip("Method paramters. NOTE: these must match the method's signature!")]
		public FsmVar[] parameters;

		// Token: 0x040041A0 RID: 16800
		[ActionSection("Store Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the method call.")]
		public FsmVar storeResult;

		// Token: 0x040041A1 RID: 16801
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040041A2 RID: 16802
		private Type cachedType;

		// Token: 0x040041A3 RID: 16803
		private string cachedClassName;

		// Token: 0x040041A4 RID: 16804
		private string cachedMethodName;

		// Token: 0x040041A5 RID: 16805
		private MethodInfo cachedMethodInfo;

		// Token: 0x040041A6 RID: 16806
		private ParameterInfo[] cachedParameterInfo;

		// Token: 0x040041A7 RID: 16807
		private object[] parametersArray;

		// Token: 0x040041A8 RID: 16808
		private string errorString;
	}
}
