using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A07 RID: 2567
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class PlayerDataIntAdd : FsmStateAction
	{
		// Token: 0x060037DE RID: 14302 RVA: 0x001483A2 File Offset: 0x001465A2
		public override void Reset()
		{
			this.gameObject = null;
			this.intName = null;
			this.amount = null;
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x001483BC File Offset: 0x001465BC
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
				Debug.Log("GetPlayerDataInt: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			component.IntAdd(this.intName.Value, this.amount.Value);
			base.Finish();
		}

		// Token: 0x04003A62 RID: 14946
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A63 RID: 14947
		[RequiredField]
		public FsmString intName;

		// Token: 0x04003A64 RID: 14948
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt amount;
	}
}
