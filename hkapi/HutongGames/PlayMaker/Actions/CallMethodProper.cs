using System;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099D RID: 2461
	[ActionCategory(ActionCategory.ScriptControl)]
	public class CallMethodProper : FsmStateAction
	{
		// Token: 0x060035ED RID: 13805 RVA: 0x0013DDC9 File Offset: 0x0013BFC9
		public override void OnEnter()
		{
			this.parametersArray = new object[this.parameters.Length];
			this.DoMethodCall();
			base.Finish();
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0013DDEC File Offset: 0x0013BFEC
		private void DoMethodCall()
		{
			if (this.behaviour.Value == null)
			{
				base.Finish();
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.component = (ownerDefaultTarget.GetComponent(this.behaviour.Value) as MonoBehaviour);
			if (this.component == null)
			{
				base.LogWarning("CallMethodProper: " + ownerDefaultTarget.name + " missing behaviour: " + this.behaviour.Value);
				return;
			}
			if (this.cachedMethodInfo == null)
			{
				this.errorString = string.Empty;
				if (!this.DoCache())
				{
					Debug.LogError(this.errorString);
					base.Finish();
					return;
				}
			}
			object value = null;
			if (this.cachedParameterInfo.Length == 0)
			{
				value = this.cachedMethodInfo.Invoke(this.cachedBehaviour, null);
			}
			else
			{
				for (int i = 0; i < this.parameters.Length; i++)
				{
					FsmVar fsmVar = this.parameters[i];
					fsmVar.UpdateValue();
					this.parametersArray[i] = fsmVar.GetValue();
				}
				try
				{
					value = this.cachedMethodInfo.Invoke(this.cachedBehaviour, this.parametersArray);
				}
				catch (Exception ex)
				{
					string str = "CallMethodProper error on ";
					string ownerName = base.Fsm.OwnerName;
					string str2 = " -> ";
					Exception ex2 = ex;
					Debug.LogError(str + ownerName + str2 + ((ex2 != null) ? ex2.ToString() : null));
				}
			}
			if (this.storeResult.Type != VariableType.Unknown)
			{
				this.storeResult.SetValue(value);
			}
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0013DF78 File Offset: 0x0013C178
		private bool DoCache()
		{
			this.cachedBehaviour = this.component;
			this.cachedType = this.component.GetType();
			this.cachedMethodInfo = this.cachedType.GetMethod(this.methodName.Value);
			if (this.cachedMethodInfo == null)
			{
				this.errorString = this.errorString + "Method Name is invalid: " + this.methodName.Value + "\n";
				base.Finish();
				return false;
			}
			this.cachedParameterInfo = this.cachedMethodInfo.GetParameters();
			return true;
		}

		// Token: 0x04003785 RID: 14213
		[RequiredField]
		[Tooltip("The game object that owns the Behaviour.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003786 RID: 14214
		[RequiredField]
		[UIHint(UIHint.Behaviour)]
		[Tooltip("The Behaviour that contains the method to start as a coroutine.")]
		public FsmString behaviour;

		// Token: 0x04003787 RID: 14215
		[UIHint(UIHint.Method)]
		[Tooltip("Name of the method to call on the component")]
		public FsmString methodName;

		// Token: 0x04003788 RID: 14216
		[Tooltip("Method paramters. NOTE: these must match the method's signature!")]
		public FsmVar[] parameters;

		// Token: 0x04003789 RID: 14217
		[ActionSection("Store Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the method call.")]
		public FsmVar storeResult;

		// Token: 0x0400378A RID: 14218
		private UnityEngine.Object cachedBehaviour;

		// Token: 0x0400378B RID: 14219
		private Type cachedType;

		// Token: 0x0400378C RID: 14220
		private MethodInfo cachedMethodInfo;

		// Token: 0x0400378D RID: 14221
		private ParameterInfo[] cachedParameterInfo;

		// Token: 0x0400378E RID: 14222
		private object[] parametersArray;

		// Token: 0x0400378F RID: 14223
		private string errorString;

		// Token: 0x04003790 RID: 14224
		private MonoBehaviour component;
	}
}
