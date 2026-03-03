using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C05 RID: 3077
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last particle collision event. See Unity Particle System docs.")]
	public class GetParticleCollisionInfo : FsmStateAction
	{
		// Token: 0x0600409F RID: 16543 RVA: 0x0016A985 File Offset: 0x00168B85
		public override void Reset()
		{
			this.gameObjectHit = null;
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0016A98E File Offset: 0x00168B8E
		private void StoreCollisionInfo()
		{
			this.gameObjectHit.Value = base.Fsm.ParticleCollisionGO;
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0016A9A6 File Offset: 0x00168BA6
		public override void OnEnter()
		{
			this.StoreCollisionInfo();
			base.Finish();
		}

		// Token: 0x040044F1 RID: 17649
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit.")]
		public FsmGameObject gameObjectHit;
	}
}
