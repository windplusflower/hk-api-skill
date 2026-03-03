using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000999 RID: 2457
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the given Bool Variables are are equal to thier Bool States.")]
	public class BoolTestMulti : FsmStateAction
	{
		// Token: 0x060035D9 RID: 13785 RVA: 0x0013DADC File Offset: 0x0013BCDC
		public override void Reset()
		{
			this.boolVariables = null;
			this.boolStates = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0013DB08 File Offset: 0x0013BD08
		public override void OnEnter()
		{
			this.DoAllTrue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0013DB1E File Offset: 0x0013BD1E
		public override void OnUpdate()
		{
			this.DoAllTrue();
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0013DB28 File Offset: 0x0013BD28
		private void DoAllTrue()
		{
			if (this.boolVariables.Length == 0 || this.boolStates.Length == 0)
			{
				return;
			}
			if (this.boolVariables.Length != this.boolStates.Length)
			{
				return;
			}
			bool flag = true;
			for (int i = 0; i < this.boolVariables.Length; i++)
			{
				if (this.boolVariables[i].Value != this.boolStates[i].Value)
				{
					flag = false;
					break;
				}
			}
			this.storeResult.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.trueEvent);
				return;
			}
			base.Fsm.Event(this.falseEvent);
		}

		// Token: 0x04003771 RID: 14193
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("This must be the same number used for Bool States.")]
		public FsmBool[] boolVariables;

		// Token: 0x04003772 RID: 14194
		[RequiredField]
		[Tooltip("This must be the same number used for Bool Variables.")]
		public FsmBool[] boolStates;

		// Token: 0x04003773 RID: 14195
		public FsmEvent trueEvent;

		// Token: 0x04003774 RID: 14196
		public FsmEvent falseEvent;

		// Token: 0x04003775 RID: 14197
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x04003776 RID: 14198
		public bool everyFrame;
	}
}
