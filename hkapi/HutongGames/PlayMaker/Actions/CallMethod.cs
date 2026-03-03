using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B3F RID: 2879
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Call a method in a behaviour.")]
	public class CallMethod : FsmStateAction
	{
		// Token: 0x06003D7B RID: 15739 RVA: 0x001610EB File Offset: 0x0015F2EB
		public override void Reset()
		{
			this.behaviour = null;
			this.methodName = null;
			this.parameters = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00161110 File Offset: 0x0015F310
		public override void OnEnter()
		{
			this.parametersArray = new object[this.parameters.Length];
			this.DoMethodCall();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00161139 File Offset: 0x0015F339
		public override void OnUpdate()
		{
			this.DoMethodCall();
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00161144 File Offset: 0x0015F344
		private void DoMethodCall()
		{
			if (this.behaviour.Value == null)
			{
				base.Finish();
				return;
			}
			if (this.NeedToUpdateCache() && !this.DoCache())
			{
				Debug.LogError(this.errorString);
				base.Finish();
				return;
			}
			object value;
			if (this.cachedParameterInfo.Length == 0)
			{
				value = this.cachedMethodInfo.Invoke(this.cachedBehaviour.Value, null);
			}
			else
			{
				for (int i = 0; i < this.parameters.Length; i++)
				{
					FsmVar fsmVar = this.parameters[i];
					fsmVar.UpdateValue();
					if (fsmVar.Type == VariableType.Array)
					{
						fsmVar.UpdateValue();
						object[] array = fsmVar.GetValue() as object[];
						Array array2 = Array.CreateInstance(this.cachedParameterInfo[i].ParameterType.GetElementType(), array.Length);
						for (int j = 0; j < array.Length; j++)
						{
							array2.SetValue(array[j], j);
						}
						this.parametersArray[i] = array2;
					}
					else
					{
						fsmVar.UpdateValue();
						this.parametersArray[i] = fsmVar.GetValue();
					}
				}
				value = this.cachedMethodInfo.Invoke(this.cachedBehaviour.Value, this.parametersArray);
			}
			if (this.storeResult != null && !this.storeResult.IsNone && this.storeResult.Type != VariableType.Unknown)
			{
				this.storeResult.SetValue(value);
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x001612A0 File Offset: 0x0015F4A0
		private bool NeedToUpdateCache()
		{
			return this.cachedBehaviour == null || this.cachedMethodName == null || this.cachedBehaviour.Value != this.behaviour.Value || this.cachedBehaviour.Name != this.behaviour.Name || this.cachedMethodName.Value != this.methodName.Value || this.cachedMethodName.Name != this.methodName.Name;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00161334 File Offset: 0x0015F534
		private void ClearCache()
		{
			this.cachedBehaviour = null;
			this.cachedMethodName = null;
			this.cachedType = null;
			this.cachedMethodInfo = null;
			this.cachedParameterInfo = null;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0016135C File Offset: 0x0015F55C
		private bool DoCache()
		{
			this.ClearCache();
			this.errorString = string.Empty;
			this.cachedBehaviour = new FsmObject(this.behaviour);
			this.cachedMethodName = new FsmString(this.methodName);
			if (this.cachedBehaviour.Value == null)
			{
				if (!this.behaviour.UsesVariable || Application.isPlaying)
				{
					this.errorString += "Behaviour is invalid!\n";
				}
				base.Finish();
				return false;
			}
			this.cachedType = this.behaviour.Value.GetType();
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
			this.cachedParameterInfo = this.cachedMethodInfo.GetParameters();
			return true;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x0016149C File Offset: 0x0015F69C
		public override string ErrorCheck()
		{
			if (Application.isPlaying)
			{
				return this.errorString;
			}
			if (!this.DoCache())
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

		// Token: 0x04004190 RID: 16784
		[ObjectType(typeof(MonoBehaviour))]
		[Tooltip("Store the component in an Object variable.\nNOTE: Set theObject variable's Object Type to get a component of that type. E.g., set Object Type to UnityEngine.AudioListener to get the AudioListener component on the camera.")]
		public FsmObject behaviour;

		// Token: 0x04004191 RID: 16785
		[Tooltip("Name of the method to call on the component")]
		public FsmString methodName;

		// Token: 0x04004192 RID: 16786
		[Tooltip("Method paramters. NOTE: these must match the method's signature!")]
		public FsmVar[] parameters;

		// Token: 0x04004193 RID: 16787
		[ActionSection("Store Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the method call.")]
		public FsmVar storeResult;

		// Token: 0x04004194 RID: 16788
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004195 RID: 16789
		[Tooltip("Use the old manual editor UI.")]
		public bool manualUI;

		// Token: 0x04004196 RID: 16790
		private FsmObject cachedBehaviour;

		// Token: 0x04004197 RID: 16791
		private FsmString cachedMethodName;

		// Token: 0x04004198 RID: 16792
		private Type cachedType;

		// Token: 0x04004199 RID: 16793
		private MethodInfo cachedMethodInfo;

		// Token: 0x0400419A RID: 16794
		private ParameterInfo[] cachedParameterInfo;

		// Token: 0x0400419B RID: 16795
		private object[] parametersArray;

		// Token: 0x0400419C RID: 16796
		private string errorString;
	}
}
