using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3B RID: 2619
	[ActionCategory("GameObject")]
	[Tooltip("Set Audio Source to active or inactive. Can only be one Audio Source on object. ")]
	public class SetAudioSource : FsmStateAction
	{
		// Token: 0x060038D2 RID: 14546 RVA: 0x0014C6FF File Offset: 0x0014A8FF
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0014C714 File Offset: 0x0014A914
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					AudioSource component = ownerDefaultTarget.GetComponent<AudioSource>();
					if (component != null)
					{
						component.enabled = this.active.Value;
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003B7C RID: 15228
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B7D RID: 15229
		public FsmBool active;
	}
}
