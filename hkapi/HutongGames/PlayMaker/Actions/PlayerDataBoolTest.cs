using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A05 RID: 2565
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the value of a Boolean Variable.")]
	public class PlayerDataBoolTest : FsmStateAction
	{
		// Token: 0x060037D8 RID: 14296 RVA: 0x00148251 File Offset: 0x00146451
		public override void Reset()
		{
			this.gameObject = null;
			this.boolName = null;
			this.isTrue = null;
			this.isFalse = null;
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00148270 File Offset: 0x00146470
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
			this.boolCheck = component.GetPlayerDataBool(this.boolName.Value);
			if (this.boolCheck)
			{
				base.Fsm.Event(this.isTrue);
			}
			else
			{
				base.Fsm.Event(this.isFalse);
			}
			base.Finish();
		}

		// Token: 0x04003A58 RID: 14936
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A59 RID: 14937
		[RequiredField]
		public FsmString boolName;

		// Token: 0x04003A5A RID: 14938
		[Tooltip("Event to send if the Bool variable is True.")]
		public FsmEvent isTrue;

		// Token: 0x04003A5B RID: 14939
		[Tooltip("Event to send if the Bool variable is False.")]
		public FsmEvent isFalse;

		// Token: 0x04003A5C RID: 14940
		private bool boolCheck;
	}
}
