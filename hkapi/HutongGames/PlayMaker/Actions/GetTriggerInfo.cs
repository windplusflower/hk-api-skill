using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C20 RID: 3104
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last Trigger event and store in variables.")]
	public class GetTriggerInfo : FsmStateAction
	{
		// Token: 0x06004114 RID: 16660 RVA: 0x0016BA76 File Offset: 0x00169C76
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.physicsMaterialName = null;
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x0016BA88 File Offset: 0x00169C88
		private void StoreTriggerInfo()
		{
			if (base.Fsm.TriggerCollider == null)
			{
				return;
			}
			this.gameObjectHit.Value = base.Fsm.TriggerCollider.gameObject;
			this.physicsMaterialName.Value = base.Fsm.TriggerCollider.material.name;
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x0016BAE4 File Offset: 0x00169CE4
		public override void OnEnter()
		{
			this.StoreTriggerInfo();
			base.Finish();
		}

		// Token: 0x0400455D RID: 17757
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObjectHit;

		// Token: 0x0400455E RID: 17758
		[UIHint(UIHint.Variable)]
		[Tooltip("Useful for triggering different effects. Audio, particles...")]
		public FsmString physicsMaterialName;
	}
}
