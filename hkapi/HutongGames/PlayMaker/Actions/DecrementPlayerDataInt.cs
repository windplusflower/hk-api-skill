using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B2 RID: 2482
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class DecrementPlayerDataInt : FsmStateAction
	{
		// Token: 0x06003654 RID: 13908 RVA: 0x00140624 File Offset: 0x0013E824
		public override void Reset()
		{
			this.gameObject = null;
			this.intName = null;
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00140634 File Offset: 0x0013E834
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
				Debug.Log("DecrementPlayerDataInt: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			component.DecrementPlayerDataInt(this.intName.Value);
			base.Finish();
		}

		// Token: 0x04003823 RID: 14371
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003824 RID: 14372
		[RequiredField]
		public FsmString intName;
	}
}
