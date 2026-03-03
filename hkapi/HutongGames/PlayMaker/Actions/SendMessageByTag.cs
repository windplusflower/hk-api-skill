using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A33 RID: 2611
	public class SendMessageByTag : FsmStateAction
	{
		// Token: 0x060038AC RID: 14508 RVA: 0x0014B7E0 File Offset: 0x001499E0
		public override void OnEnter()
		{
			GameObject[] array = GameObject.FindGameObjectsWithTag(this.tag.Value);
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SendMessage(this.message.Value);
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x04003B53 RID: 15187
		public FsmString tag;

		// Token: 0x04003B54 RID: 15188
		public FsmString message;
	}
}
