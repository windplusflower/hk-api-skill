using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DA RID: 2522
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class GetPlayerDataFloat : FsmStateAction
	{
		// Token: 0x06003719 RID: 14105 RVA: 0x001447C5 File Offset: 0x001429C5
		public override void Reset()
		{
			this.gameObject = null;
			this.floatName = null;
			this.storeValue = null;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x001447DC File Offset: 0x001429DC
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
				Debug.Log("GetPlayerDataFloat: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			this.storeValue.Value = component.GetPlayerDataFloat(this.floatName.Value);
			base.Finish();
		}

		// Token: 0x04003931 RID: 14641
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003932 RID: 14642
		[RequiredField]
		public FsmString floatName;

		// Token: 0x04003933 RID: 14643
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeValue;
	}
}
