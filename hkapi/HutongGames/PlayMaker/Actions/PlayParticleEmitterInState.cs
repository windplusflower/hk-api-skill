using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A03 RID: 2563
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class PlayParticleEmitterInState : FsmStateAction
	{
		// Token: 0x060037CF RID: 14287 RVA: 0x0014809E File Offset: 0x0014629E
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x001480A8 File Offset: 0x001462A8
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
					if (component && !component.isPlaying)
					{
						component.Play();
					}
				}
			}
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x001480F8 File Offset: 0x001462F8
		public override void OnExit()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
					if (component && component.isPlaying)
					{
						component.Stop();
					}
				}
			}
		}

		// Token: 0x04003A4F RID: 14927
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;
	}
}
