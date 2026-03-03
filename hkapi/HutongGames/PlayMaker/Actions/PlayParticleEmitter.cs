using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A02 RID: 2562
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class PlayParticleEmitter : FsmStateAction
	{
		// Token: 0x060037CC RID: 14284 RVA: 0x00148000 File Offset: 0x00146200
		public override void Reset()
		{
			this.gameObject = null;
			this.emit = new FsmInt(0);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0014801C File Offset: 0x0014621C
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
					if (component && !component.isPlaying && this.emit.Value <= 0)
					{
						component.Play();
					}
					else if (this.emit.Value > 0)
					{
						component.Emit(this.emit.Value);
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003A4D RID: 14925
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A4E RID: 14926
		public FsmInt emit;
	}
}
