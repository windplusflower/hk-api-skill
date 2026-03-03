using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A06 RID: 2566
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Checks whether a player bool is true and another is false. Sends event.")]
	public class PlayerDataBoolTrueAndFalse : FsmStateAction
	{
		// Token: 0x060037DB RID: 14299 RVA: 0x001482F3 File Offset: 0x001464F3
		public override void Reset()
		{
			this.gameObject = null;
			this.trueBool = null;
			this.falseBool = null;
			this.isTrue = null;
			this.isFalse = null;
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00148318 File Offset: 0x00146518
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			GameManager component = ownerDefaultTarget.GetComponent<GameManager>();
			if (component == null)
			{
				return;
			}
			if (component.GetPlayerDataBool(this.trueBool.Value) && !component.GetPlayerDataBool(this.falseBool.Value))
			{
				base.Fsm.Event(this.isTrue);
			}
			else
			{
				base.Fsm.Event(this.isFalse);
			}
			base.Finish();
		}

		// Token: 0x04003A5D RID: 14941
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A5E RID: 14942
		[RequiredField]
		public FsmString trueBool;

		// Token: 0x04003A5F RID: 14943
		[RequiredField]
		public FsmString falseBool;

		// Token: 0x04003A60 RID: 14944
		[Tooltip("Event to send if conditions met.")]
		public FsmEvent isTrue;

		// Token: 0x04003A61 RID: 14945
		[Tooltip("Event to send if conditions not met.")]
		public FsmEvent isFalse;
	}
}
