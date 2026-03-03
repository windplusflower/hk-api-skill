using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4D RID: 2637
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class SetPlayerDataInt : FsmStateAction
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x0014D0E2 File Offset: 0x0014B2E2
		public override void Reset()
		{
			this.intName = null;
			this.value = null;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0014D0F4 File Offset: 0x0014B2F4
		public override void OnEnter()
		{
			GameManager instance = GameManager.instance;
			if (instance == null)
			{
				Debug.Log("GameManager could not be found");
				return;
			}
			instance.SetPlayerDataInt(this.intName.Value, this.value.Value);
			base.Finish();
		}

		// Token: 0x04003BAC RID: 15276
		[RequiredField]
		public FsmString intName;

		// Token: 0x04003BAD RID: 15277
		[RequiredField]
		public FsmInt value;
	}
}
