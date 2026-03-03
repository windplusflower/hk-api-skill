using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4E RID: 2638
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class SetPlayerDataString : FsmStateAction
	{
		// Token: 0x06003917 RID: 14615 RVA: 0x0014D13D File Offset: 0x0014B33D
		public override void Reset()
		{
			this.gameObject = null;
			this.stringName = null;
			this.value = null;
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0014D154 File Offset: 0x0014B354
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
				Debug.Log("SetPlayerDataInt: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			component.SetPlayerDataString(this.stringName.Value, this.value.Value);
			base.Finish();
		}

		// Token: 0x04003BAE RID: 15278
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BAF RID: 15279
		[RequiredField]
		public FsmString stringName;

		// Token: 0x04003BB0 RID: 15280
		[RequiredField]
		public FsmString value;
	}
}
