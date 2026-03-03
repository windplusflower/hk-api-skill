using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A4A RID: 2634
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class SetParticleEmissionSpeed : FsmStateAction
	{
		// Token: 0x06003909 RID: 14601 RVA: 0x0014CF8C File Offset: 0x0014B18C
		public override void Reset()
		{
			this.gameObject = null;
			this.emissionSpeed = null;
			this.everyFrame = false;
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0014CFA4 File Offset: 0x0014B1A4
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.emitter = ownerDefaultTarget.GetComponent<ParticleSystem>();
				this.DoSetEmitSpeed();
				if (!this.everyFrame)
				{
					base.Finish();
				}
			}
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0014CFEB File Offset: 0x0014B1EB
		public override void OnUpdate()
		{
			this.DoSetEmitSpeed();
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0014CFF3 File Offset: 0x0014B1F3
		private void DoSetEmitSpeed()
		{
			this.emitter.startSpeed = this.emissionSpeed.Value;
		}

		// Token: 0x04003BA3 RID: 15267
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BA4 RID: 15268
		public FsmFloat emissionSpeed;

		// Token: 0x04003BA5 RID: 15269
		public bool everyFrame;

		// Token: 0x04003BA6 RID: 15270
		private ParticleSystem emitter;
	}
}
