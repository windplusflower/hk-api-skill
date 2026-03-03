using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CE RID: 2254
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Interrupts the automatic target matching. CompleteMatch will make the gameobject match the target completely at the next frame.")]
	public class AnimatorInterruptMatchTarget : FsmStateAction
	{
		// Token: 0x0600323D RID: 12861 RVA: 0x0013163A File Offset: 0x0012F83A
		public override void Reset()
		{
			this.gameObject = null;
			this.completeMatch = true;
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00131650 File Offset: 0x0012F850
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			Animator component = ownerDefaultTarget.GetComponent<Animator>();
			if (component != null)
			{
				component.InterruptMatchTarget(this.completeMatch.Value);
			}
			base.Finish();
		}

		// Token: 0x0400338B RID: 13195
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400338C RID: 13196
		[Tooltip("Will make the gameobject match the target completely at the next frame")]
		public FsmBool completeMatch;
	}
}
