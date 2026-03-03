using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E5 RID: 2533
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class IncrementPlayerDataInt : FsmStateAction
	{
		// Token: 0x0600374E RID: 14158 RVA: 0x001464FE File Offset: 0x001446FE
		public override void Reset()
		{
			this.gameObject = null;
			this.intName = null;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00146510 File Offset: 0x00144710
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
				Debug.Log("IncrementPlayerDataInt: could not find a GameManager on this object, please refere to the GameManager global variable");
				return;
			}
			component.IncrementPlayerDataInt(this.intName.Value);
			base.Finish();
		}

		// Token: 0x0400398F RID: 14735
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003990 RID: 14736
		[RequiredField]
		public FsmString intName;
	}
}
