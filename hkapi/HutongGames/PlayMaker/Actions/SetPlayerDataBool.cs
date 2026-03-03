using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4B RID: 2635
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class SetPlayerDataBool : FsmStateAction
	{
		// Token: 0x0600390E RID: 14606 RVA: 0x0014D00B File Offset: 0x0014B20B
		public override void Reset()
		{
			this.boolName = null;
			this.value = null;
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0014D01C File Offset: 0x0014B21C
		public override void OnEnter()
		{
			GameManager instance = GameManager.instance;
			if (instance == null)
			{
				Debug.Log("GameManager could not be found");
				return;
			}
			instance.SetPlayerDataBool(this.boolName.Value, this.value.Value);
			base.Finish();
		}

		// Token: 0x04003BA7 RID: 15271
		[RequiredField]
		public FsmString boolName;

		// Token: 0x04003BA8 RID: 15272
		[RequiredField]
		public FsmBool value;
	}
}
