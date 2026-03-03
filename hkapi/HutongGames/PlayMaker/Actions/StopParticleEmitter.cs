using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6B RID: 2667
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class StopParticleEmitter : FsmStateAction
	{
		// Token: 0x0600398A RID: 14730 RVA: 0x0014FB41 File Offset: 0x0014DD41
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0014FB4C File Offset: 0x0014DD4C
		public override void OnEnter()
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
			base.Finish();
		}

		// Token: 0x04003C85 RID: 15493
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;
	}
}
