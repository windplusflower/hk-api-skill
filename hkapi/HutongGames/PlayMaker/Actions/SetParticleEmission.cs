using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A48 RID: 2632
	[ActionCategory("Particle System")]
	[Tooltip("Set particle emission on or off on an object with a particle emitter")]
	public class SetParticleEmission : FsmStateAction
	{
		// Token: 0x06003901 RID: 14593 RVA: 0x0014CE94 File Offset: 0x0014B094
		public override void Reset()
		{
			this.gameObject = null;
			this.emission = false;
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0014CEAC File Offset: 0x0014B0AC
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					ownerDefaultTarget.GetComponent<ParticleSystem>().enableEmission = this.emission.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003B9D RID: 15261
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B9E RID: 15262
		public FsmBool emission;
	}
}
