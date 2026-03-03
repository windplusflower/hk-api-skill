using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DD RID: 2525
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class GetPlayerDataVector3 : FsmStateAction
	{
		// Token: 0x06003722 RID: 14114 RVA: 0x00144942 File Offset: 0x00142B42
		public override void Reset()
		{
			this.gameObject = null;
			this.vector3Name = null;
			this.storeValue = null;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0014495C File Offset: 0x00142B5C
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
			this.storeValue.Value = component.GetPlayerDataVector3(this.vector3Name.Value);
			base.Finish();
		}

		// Token: 0x0400393A RID: 14650
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400393B RID: 14651
		[RequiredField]
		public FsmString vector3Name;

		// Token: 0x0400393C RID: 14652
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeValue;
	}
}
