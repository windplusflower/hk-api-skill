using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C44 RID: 3140
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compare 2 Object Variables and send events based on the result.")]
	public class ObjectCompare : FsmStateAction
	{
		// Token: 0x060041BB RID: 16827 RVA: 0x0016DC47 File Offset: 0x0016BE47
		public override void Reset()
		{
			this.objectVariable = null;
			this.compareTo = null;
			this.storeResult = null;
			this.equalEvent = null;
			this.notEqualEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x0016DC73 File Offset: 0x0016BE73
		public override void OnEnter()
		{
			this.DoObjectCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x0016DC89 File Offset: 0x0016BE89
		public override void OnUpdate()
		{
			this.DoObjectCompare();
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0016DC94 File Offset: 0x0016BE94
		private void DoObjectCompare()
		{
			bool flag = this.objectVariable.Value == this.compareTo.Value;
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.equalEvent : this.notEqualEvent);
		}

		// Token: 0x0400461E RID: 17950
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmObject objectVariable;

		// Token: 0x0400461F RID: 17951
		[RequiredField]
		public FsmObject compareTo;

		// Token: 0x04004620 RID: 17952
		[Tooltip("Event to send if the 2 object values are equal.")]
		public FsmEvent equalEvent;

		// Token: 0x04004621 RID: 17953
		[Tooltip("Event to send if the 2 object values are not equal.")]
		public FsmEvent notEqualEvent;

		// Token: 0x04004622 RID: 17954
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a variable.")]
		public FsmBool storeResult;

		// Token: 0x04004623 RID: 17955
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
