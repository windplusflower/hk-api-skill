using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6C RID: 2668
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class StopParticleEmittersInChildren : FsmStateAction
	{
		// Token: 0x0600398D RID: 14733 RVA: 0x0014FB9F File Offset: 0x0014DD9F
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0014FBA8 File Offset: 0x0014DDA8
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					foreach (ParticleSystem particleSystem in ownerDefaultTarget.GetComponentsInChildren<ParticleSystem>())
					{
						if (particleSystem.isPlaying)
						{
							particleSystem.Stop();
						}
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003C86 RID: 15494
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;
	}
}
