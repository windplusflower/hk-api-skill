using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B39 RID: 2873
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the Bool Variables are False.\nSend an event or store the result.")]
	public class BoolNoneTrue : FsmStateAction
	{
		// Token: 0x06003D65 RID: 15717 RVA: 0x00160D11 File Offset: 0x0015EF11
		public override void Reset()
		{
			this.boolVariables = null;
			this.sendEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00160D2F File Offset: 0x0015EF2F
		public override void OnEnter()
		{
			this.DoNoneTrue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00160D45 File Offset: 0x0015EF45
		public override void OnUpdate()
		{
			this.DoNoneTrue();
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00160D50 File Offset: 0x0015EF50
		private void DoNoneTrue()
		{
			if (this.boolVariables.Length == 0)
			{
				return;
			}
			bool flag = true;
			for (int i = 0; i < this.boolVariables.Length; i++)
			{
				if (this.boolVariables[i].Value)
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

		// Token: 0x04004174 RID: 16756
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variables to check.")]
		public FsmBool[] boolVariables;

		// Token: 0x04004175 RID: 16757
		[Tooltip("Event to send if none of the Bool variables are True.")]
		public FsmEvent sendEvent;

		// Token: 0x04004176 RID: 16758
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x04004177 RID: 16759
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
