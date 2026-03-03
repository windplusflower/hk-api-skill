using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DB RID: 2523
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class GetPlayerDataInt : FsmStateAction
	{
		// Token: 0x0600371C RID: 14108 RVA: 0x00144842 File Offset: 0x00142A42
		public override void Reset()
		{
			this.gameObject = null;
			this.intName = null;
			this.storeValue = null;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0014485C File Offset: 0x00142A5C
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
			this.storeValue.Value = component.GetPlayerDataInt(this.intName.Value);
			base.Finish();
		}

		// Token: 0x04003934 RID: 14644
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003935 RID: 14645
		[RequiredField]
		public FsmString intName;

		// Token: 0x04003936 RID: 14646
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeValue;
	}
}
