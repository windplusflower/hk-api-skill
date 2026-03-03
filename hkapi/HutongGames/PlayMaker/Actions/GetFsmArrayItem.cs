using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B25 RID: 2853
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Gets an item in an Array Variable in another FSM.")]
	public class GetFsmArrayItem : BaseFsmVariableIndexAction
	{
		// Token: 0x06003D19 RID: 15641 RVA: 0x0015FCD9 File Offset: 0x0015DED9
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0015FCF9 File Offset: 0x0015DEF9
		public override void OnEnter()
		{
			this.DoGetFsmArray();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0015FD10 File Offset: 0x0015DF10
		private void DoGetFsmArray()
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
			if (this.index.Value < 0 || this.index.Value >= fsmArray.Length)
			{
				base.Fsm.Event(this.indexOutOfRange);
				base.Finish();
				return;
			}
			if (fsmArray.ElementType == this.storeValue.NamedVar.VariableType)
			{
				this.storeValue.SetValue(fsmArray.Get(this.index.Value));
				return;
			}
			base.LogWarning("Incompatible variable type: " + this.variableName.Value);
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0015FE01 File Offset: 0x0015E001
		public override void OnUpdate()
		{
			this.DoGetFsmArray();
		}

		// Token: 0x04004123 RID: 16675
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004124 RID: 16676
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x04004125 RID: 16677
		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004126 RID: 16678
		[Tooltip("The index into the array.")]
		public FsmInt index;

		// Token: 0x04004127 RID: 16679
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the value of the array at the specified index.")]
		public FsmVar storeValue;

		// Token: 0x04004128 RID: 16680
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;
	}
}
