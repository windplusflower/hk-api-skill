using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C8F RID: 3215
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Set the value of a Game Object Variable in another All FSM. Accept null reference")]
	public class SetAllFsmGameObject : FsmStateAction
	{
		// Token: 0x06004321 RID: 17185 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00172644 File Offset: 0x00170844
		public override void OnEnter()
		{
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00003603 File Offset: 0x00001803
		private void DoSetFsmGameObject()
		{
		}

		// Token: 0x04004778 RID: 18296
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004779 RID: 18297
		public bool everyFrame;
	}
}
