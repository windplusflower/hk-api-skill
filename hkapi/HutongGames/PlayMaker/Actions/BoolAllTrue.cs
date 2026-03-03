using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B35 RID: 2869
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the given Bool Variables are True.")]
	public class BoolAllTrue : FsmStateAction
	{
		// Token: 0x06003D54 RID: 15700 RVA: 0x00160B30 File Offset: 0x0015ED30
		public override void Reset()
		{
			this.boolVariables = null;
			this.sendEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00160B4E File Offset: 0x0015ED4E
		public override void OnEnter()
		{
			this.DoAllTrue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00160B64 File Offset: 0x0015ED64
		public override void OnUpdate()
		{
			this.DoAllTrue();
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00160B6C File Offset: 0x0015ED6C
		private void DoAllTrue()
		{
			if (this.boolVariables.Length == 0)
			{
				return;
			}
			bool flag = true;
			for (int i = 0; i < this.boolVariables.Length; i++)
			{
				if (!this.boolVariables[i].Value)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = flag;
		}

		// Token: 0x04004167 RID: 16743
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variables to check.")]
		public FsmBool[] boolVariables;

		// Token: 0x04004168 RID: 16744
		[Tooltip("Event to send if all the Bool variables are True.")]
		public FsmEvent sendEvent;

		// Token: 0x04004169 RID: 16745
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x0400416A RID: 16746
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
