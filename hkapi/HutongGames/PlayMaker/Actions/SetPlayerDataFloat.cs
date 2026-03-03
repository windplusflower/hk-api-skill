using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4C RID: 2636
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class SetPlayerDataFloat : FsmStateAction
	{
		// Token: 0x06003911 RID: 14609 RVA: 0x0014D065 File Offset: 0x0014B265
		public override void Reset()
		{
			this.gameObject = null;
			this.floatName = null;
			this.value = null;
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x0014D07C File Offset: 0x0014B27C
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
				Debug.Log("SetPlayerDataFloat: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			component.SetPlayerDataFloat(this.floatName.Value, this.value.Value);
			base.Finish();
		}

		// Token: 0x04003BA9 RID: 15273
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BAA RID: 15274
		[RequiredField]
		public FsmString floatName;

		// Token: 0x04003BAB RID: 15275
		[RequiredField]
		public FsmFloat value;
	}
}
