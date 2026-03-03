using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D10 RID: 3344
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Turn GUILayout on/off. If you don't use GUILayout actions you can get some performace back by turning GUILayout off. This can make a difference on iOS platforms.")]
	public class UseGUILayout : FsmStateAction
	{
		// Token: 0x0600455D RID: 17757 RVA: 0x00178EAF File Offset: 0x001770AF
		public override void Reset()
		{
			this.turnOffGUIlayout = true;
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00178EB8 File Offset: 0x001770B8
		public override void OnEnter()
		{
			base.Fsm.Owner.useGUILayout = !this.turnOffGUIlayout;
			base.Finish();
		}

		// Token: 0x040049C5 RID: 18885
		[RequiredField]
		public bool turnOffGUIlayout;
	}
}
