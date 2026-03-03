using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D9 RID: 2521
	[ActionCategory("PlayerData")]
	[Tooltip("Sends a Message to PlayerData to send and receive data.")]
	public class GetPlayerDataBool : FsmStateAction
	{
		// Token: 0x06003716 RID: 14102 RVA: 0x0014476B File Offset: 0x0014296B
		public override void Reset()
		{
			this.boolName = null;
			this.storeValue = null;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0014477C File Offset: 0x0014297C
		public override void OnEnter()
		{
			GameManager instance = GameManager.instance;
			if (instance == null)
			{
				Debug.Log("GameManager could not be found");
				return;
			}
			this.storeValue.Value = instance.GetPlayerDataBool(this.boolName.Value);
			base.Finish();
		}

		// Token: 0x0400392F RID: 14639
		[RequiredField]
		public FsmString boolName;

		// Token: 0x04003930 RID: 14640
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool storeValue;
	}
}
