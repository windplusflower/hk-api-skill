using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4F RID: 2639
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class SetPlayerDataVector3 : FsmStateAction
	{
		// Token: 0x0600391A RID: 14618 RVA: 0x0014D1BA File Offset: 0x0014B3BA
		public override void Reset()
		{
			this.gameObject = null;
			this.vector3Name = null;
			this.value = null;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0014D1D4 File Offset: 0x0014B3D4
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
			component.SetPlayerDataVector3(this.vector3Name.Value, this.value.Value);
			base.Finish();
		}

		// Token: 0x04003BB1 RID: 15281
		[RequiredField]
		[Tooltip("GameManager reference, set this to the global variable GameManager.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BB2 RID: 15282
		[RequiredField]
		public FsmString vector3Name;

		// Token: 0x04003BB3 RID: 15283
		[RequiredField]
		public FsmVector3 value;
	}
}
