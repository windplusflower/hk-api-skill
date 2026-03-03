using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DC RID: 2524
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class GetPlayerDataString : FsmStateAction
	{
		// Token: 0x0600371F RID: 14111 RVA: 0x001448C2 File Offset: 0x00142AC2
		public override void Reset()
		{
			this.gameObject = null;
			this.stringName = null;
			this.storeValue = null;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x001448DC File Offset: 0x00142ADC
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
				Debug.Log("GetPlayerDataString: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			this.storeValue.Value = component.GetPlayerDataString(this.stringName.Value);
			base.Finish();
		}

		// Token: 0x04003937 RID: 14647
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003938 RID: 14648
		[RequiredField]
		public FsmString stringName;

		// Token: 0x04003939 RID: 14649
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeValue;
	}
}
