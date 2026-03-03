using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AEC RID: 2796
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets properties on the last event that caused a state change. Use Set Event Properties to define these values when sending events")]
	public class GetEventProperties : FsmStateAction
	{
		// Token: 0x06003C0B RID: 15371 RVA: 0x00159C58 File Offset: 0x00157E58
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.datas = new FsmVar[1];
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00159C74 File Offset: 0x00157E74
		public override void OnEnter()
		{
			try
			{
				if (SetEventProperties.properties == null)
				{
					throw new ArgumentException("no properties");
				}
				for (int i = 0; i < this.keys.Length; i++)
				{
					if (SetEventProperties.properties.ContainsKey(this.keys[i].Value))
					{
						PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.datas[i], SetEventProperties.properties[this.keys[i].Value]);
					}
				}
			}
			catch (Exception ex)
			{
				string str = "no properties found ";
				Exception ex2 = ex;
				Debug.Log(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			base.Finish();
		}

		// Token: 0x04003FB3 RID: 16307
		[CompoundArray("Event Properties", "Key", "Data")]
		public FsmString[] keys;

		// Token: 0x04003FB4 RID: 16308
		[UIHint(UIHint.Variable)]
		public FsmVar[] datas;
	}
}
