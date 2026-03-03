using System;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AED RID: 2797
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sets Event Data before sending an event. Get the Event Data, Get Event Properties action.")]
	public class SetEventProperties : FsmStateAction
	{
		// Token: 0x06003C0E RID: 15374 RVA: 0x00159D24 File Offset: 0x00157F24
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.datas = new FsmVar[1];
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00159D40 File Offset: 0x00157F40
		public override void OnEnter()
		{
			SetEventProperties.properties = new Dictionary<string, object>();
			for (int i = 0; i < this.keys.Length; i++)
			{
				SetEventProperties.properties[this.keys[i].Value] = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.datas[i]);
			}
			base.Finish();
		}

		// Token: 0x04003FB5 RID: 16309
		[CompoundArray("Event Properties", "Key", "Data")]
		public FsmString[] keys;

		// Token: 0x04003FB6 RID: 16310
		public FsmVar[] datas;

		// Token: 0x04003FB7 RID: 16311
		public static Dictionary<string, object> properties;
	}
}
