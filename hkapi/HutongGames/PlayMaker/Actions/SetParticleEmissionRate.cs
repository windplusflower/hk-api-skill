using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A49 RID: 2633
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class SetParticleEmissionRate : FsmStateAction
	{
		// Token: 0x06003904 RID: 14596 RVA: 0x0014CEF8 File Offset: 0x0014B0F8
		public override void Reset()
		{
			this.gameObject = null;
			this.emissionRate = null;
			this.everyFrame = false;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0014CF10 File Offset: 0x0014B110
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget)
				{
					this.emitter = ownerDefaultTarget.GetComponent<ParticleSystem>();
				}
				this.DoSetEmitRate();
				if (!this.everyFrame)
				{
					base.Finish();
				}
			}
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x0014CF5F File Offset: 0x0014B15F
		public override void OnUpdate()
		{
			this.DoSetEmitRate();
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x0014CF67 File Offset: 0x0014B167
		private void DoSetEmitRate()
		{
			if (this.emitter)
			{
				this.emitter.emissionRate = this.emissionRate.Value;
			}
		}

		// Token: 0x04003B9F RID: 15263
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BA0 RID: 15264
		public FsmFloat emissionRate;

		// Token: 0x04003BA1 RID: 15265
		public bool everyFrame;

		// Token: 0x04003BA2 RID: 15266
		private ParticleSystem emitter;
	}
}
