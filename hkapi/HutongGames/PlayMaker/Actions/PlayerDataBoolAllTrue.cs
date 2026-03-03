using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A04 RID: 2564
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the value of a Boolean Variable.")]
	public class PlayerDataBoolAllTrue : FsmStateAction
	{
		// Token: 0x060037D3 RID: 14291 RVA: 0x00148145 File Offset: 0x00146345
		public override void Reset()
		{
			this.gameObject = null;
			this.stringVariables = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00148174 File Offset: 0x00146374
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.gm = ownerDefaultTarget.GetComponent<GameManager>();
			if (this.gm == null)
			{
				return;
			}
			this.DoAllTrue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x001481CC File Offset: 0x001463CC
		public override void OnUpdate()
		{
			this.DoAllTrue();
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x001481D4 File Offset: 0x001463D4
		private void DoAllTrue()
		{
			if (this.stringVariables.Length == 0)
			{
				return;
			}
			bool flag = true;
			for (int i = 0; i < this.stringVariables.Length; i++)
			{
				if (!this.gm.GetPlayerDataBool(this.stringVariables[i].Value))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.Fsm.Event(this.trueEvent);
			}
			else
			{
				base.Fsm.Event(this.falseEvent);
			}
			this.storeResult.Value = flag;
		}

		// Token: 0x04003A50 RID: 14928
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A51 RID: 14929
		[RequiredField]
		public FsmString[] stringVariables;

		// Token: 0x04003A52 RID: 14930
		[Tooltip("Event to send if all the Bool variables are True.")]
		public FsmEvent trueEvent;

		// Token: 0x04003A53 RID: 14931
		[Tooltip("Event to send if not all the bool variables are true.")]
		public FsmEvent falseEvent;

		// Token: 0x04003A54 RID: 14932
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x04003A55 RID: 14933
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x04003A56 RID: 14934
		private bool boolCheck;

		// Token: 0x04003A57 RID: 14935
		private GameManager gm;
	}
}
