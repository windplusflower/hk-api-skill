using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A31 RID: 2609
	[ActionCategory("Hollow Knight")]
	[Tooltip("Hook for enemy messages for scripts. Translates messages into appropriate method calls.")]
	public class SendEnemyMessage : FsmStateAction
	{
		// Token: 0x060038A4 RID: 14500 RVA: 0x0014B695 File Offset: 0x00149895
		public override void Reset()
		{
			this.Target = new FsmGameObject
			{
				UseVariable = true
			};
			this.EventString = new FsmString
			{
				UseVariable = true
			};
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0014B6BC File Offset: 0x001498BC
		public override void OnEnter()
		{
			GameObject value = this.Target.Value;
			string value2 = this.EventString.Value;
			if (value != null && !string.IsNullOrEmpty(value2) && value2 != null)
			{
				if (!(value2 == "GO LEFT"))
				{
					if (value2 == "GO RIGHT")
					{
						SendEnemyMessage.SendWalkerGoInDirection(value, 1);
					}
				}
				else
				{
					SendEnemyMessage.SendWalkerGoInDirection(value, -1);
				}
			}
			base.Finish();
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0014B728 File Offset: 0x00149928
		private static void SendWalkerGoInDirection(GameObject target, int facing)
		{
			Walker component = target.GetComponent<Walker>();
			if (component != null)
			{
				component.RecieveGoMessage(facing);
			}
		}

		// Token: 0x04003B4E RID: 15182
		public FsmGameObject Target;

		// Token: 0x04003B4F RID: 15183
		public FsmString EventString;
	}
}
