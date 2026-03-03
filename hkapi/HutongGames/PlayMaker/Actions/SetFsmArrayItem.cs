using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B27 RID: 2855
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set an item in an Array Variable in another FSM.")]
	public class SetFsmArrayItem : BaseFsmVariableIndexAction
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x0015FF64 File Offset: 0x0015E164
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.value = null;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x0015FF84 File Offset: 0x0015E184
		public override void OnEnter()
		{
			this.DoSetFsmArray();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x0015FF9C File Offset: 0x0015E19C
		private void DoSetFsmArray()
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
			if (fsmArray.ElementType == this.value.NamedVar.VariableType)
			{
				this.value.UpdateValue();
				fsmArray.Set(this.index.Value, this.value.GetValue());
				return;
			}
			base.LogWarning("Incompatible variable type: " + this.variableName.Value);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00160098 File Offset: 0x0015E298
		public override void OnUpdate()
		{
			this.DoSetFsmArray();
		}

		// Token: 0x0400412E RID: 16686
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400412F RID: 16687
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x04004130 RID: 16688
		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004131 RID: 16689
		[Tooltip("The index into the array.")]
		public FsmInt index;

		// Token: 0x04004132 RID: 16690
		[RequiredField]
		[Tooltip("Set the value of the array at the specified index.")]
		public FsmVar value;

		// Token: 0x04004133 RID: 16691
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;
	}
}
