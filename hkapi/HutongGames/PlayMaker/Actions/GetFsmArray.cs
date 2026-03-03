using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B24 RID: 2852
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Copy an Array Variable from another FSM.")]
	public class GetFsmArray : BaseFsmVariableAction
	{
		// Token: 0x06003D15 RID: 15637 RVA: 0x0015FB7C File Offset: 0x0015DD7C
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = null;
			this.storeValue = null;
			this.copyValues = true;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0015FBAA File Offset: 0x0015DDAA
		public override void OnEnter()
		{
			this.DoSetFsmArrayCopy();
			base.Finish();
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0015FBB8 File Offset: 0x0015DDB8
		private void DoSetFsmArrayCopy()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget, this.fsmName.Value))
			{
				return;
			}
			FsmArray fsmArray = this.fsm.FsmVariables.GetFsmArray(this.variableName.Value);
			if (fsmArray == null)
			{
				base.DoVariableNotFound(this.variableName.Value);
				return;
			}
			if (fsmArray.ElementType != this.storeValue.ElementType)
			{
				base.LogError(string.Concat(new string[]
				{
					"Can only copy arrays with the same elements type. Found <",
					fsmArray.ElementType.ToString(),
					"> and <",
					this.storeValue.ElementType.ToString(),
					">"
				}));
				return;
			}
			this.storeValue.Resize(0);
			if (this.copyValues)
			{
				this.storeValue.Values = (fsmArray.Values.Clone() as object[]);
				return;
			}
			this.storeValue.Values = fsmArray.Values;
		}

		// Token: 0x0400411E RID: 16670
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400411F RID: 16671
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x04004120 RID: 16672
		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004121 RID: 16673
		[RequiredField]
		[Tooltip("Get the content of the array variable.")]
		[UIHint(UIHint.Variable)]
		public FsmArray storeValue;

		// Token: 0x04004122 RID: 16674
		[Tooltip("If true, makes copies. if false, values share the same reference and editing one array item value will affect the source and vice versa. Warning, this only affect the current items of the source array. Adding or removing items doesn't affect other FsmArrays.")]
		public bool copyValues;
	}
}
