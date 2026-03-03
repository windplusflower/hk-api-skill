using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD0 RID: 2768
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last Trigger 2d event and store in variables.  See Unity and PlayMaker docs on Unity 2D physics.")]
	public class GetTrigger2dInfo : FsmStateAction
	{
		// Token: 0x06003B83 RID: 15235 RVA: 0x00157999 File Offset: 0x00155B99
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.shapeCount = null;
			this.physics2dMaterialName = null;
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x001579B0 File Offset: 0x00155BB0
		private void StoreTriggerInfo()
		{
			if (base.Fsm.TriggerCollider2D == null)
			{
				return;
			}
			this.gameObjectHit.Value = base.Fsm.TriggerCollider2D.gameObject;
			this.shapeCount.Value = base.Fsm.TriggerCollider2D.shapeCount;
			this.physics2dMaterialName.Value = ((base.Fsm.TriggerCollider2D.sharedMaterial != null) ? base.Fsm.TriggerCollider2D.sharedMaterial.name : "");
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00157A46 File Offset: 0x00155C46
		public override void OnEnter()
		{
			this.StoreTriggerInfo();
			base.Finish();
		}

		// Token: 0x04003F0E RID: 16142
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x04003F0F RID: 16143
		[UIHint(UIHint.Variable)]
		[Tooltip("The number of separate shaped regions in the collider.")]
		public FsmInt shapeCount;

		// Token: 0x04003F10 RID: 16144
		[UIHint(UIHint.Variable)]
		[Tooltip("Useful for triggering different effects. Audio, particles...")]
		public FsmString physics2dMaterialName;
	}
}
