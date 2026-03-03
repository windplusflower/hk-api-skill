using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD6 RID: 3286
	[ActionCategory(ActionCategory.UnityObject)]
	[Tooltip("Sets the value of an Object Variable.")]
	public class SetObjectValue : FsmStateAction
	{
		// Token: 0x06004459 RID: 17497 RVA: 0x001757DE File Offset: 0x001739DE
		public override void Reset()
		{
			this.objectVariable = null;
			this.objectValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x001757F5 File Offset: 0x001739F5
		public override void OnEnter()
		{
			this.objectVariable.Value = this.objectValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x0017581B File Offset: 0x00173A1B
		public override void OnUpdate()
		{
			this.objectVariable.Value = this.objectValue.Value;
		}

		// Token: 0x040048A1 RID: 18593
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmObject objectVariable;

		// Token: 0x040048A2 RID: 18594
		[RequiredField]
		public FsmObject objectValue;

		// Token: 0x040048A3 RID: 18595
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
