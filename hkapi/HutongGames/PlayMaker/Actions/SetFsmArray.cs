using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B26 RID: 2854
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Copy an Array Variable in another FSM.")]
	public class SetFsmArray : BaseFsmVariableAction
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x0015FE11 File Offset: 0x0015E011
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = null;
			this.setValue = null;
			this.copyValues = true;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x0015FE3F File Offset: 0x0015E03F
		public override void OnEnter()
		{
			this.DoSetFsmArrayCopy();
			base.Finish();
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x0015FE50 File Offset: 0x0015E050
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
			if (fsmArray.ElementType != this.setValue.ElementType)
			{
				base.LogError(string.Concat(new string[]
				{
					"Can only copy arrays with the same elements type. Found <",
					fsmArray.ElementType.ToString(),
					"> and <",
					this.setValue.ElementType.ToString(),
					">"
				}));
				return;
			}
			fsmArray.Resize(0);
			if (this.copyValues)
			{
				fsmArray.Values = (this.setValue.Values.Clone() as object[]);
				return;
			}
			fsmArray.Values = this.setValue.Values;
		}

		// Token: 0x04004129 RID: 16681
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400412A RID: 16682
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x0400412B RID: 16683
		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400412C RID: 16684
		[RequiredField]
		[Tooltip("Set the content of the array variable.")]
		[UIHint(UIHint.Variable)]
		public FsmArray setValue;

		// Token: 0x0400412D RID: 16685
		[Tooltip("If true, makes copies. if false, values share the same reference and editing one array item value will affect the source and vice versa. Warning, this only affect the current items of the source array. Adding or removing items doesn't affect other FsmArrays.")]
		public bool copyValues;
	}
}
