using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C89 RID: 3209
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets the Scale of a Game Object sends an event based on positivity or negativity of x/y value")]
	public class SendEventByScale : FsmStateAction
	{
		// Token: 0x0600430E RID: 17166 RVA: 0x00171E2A File Offset: 0x0017002A
		public override void Reset()
		{
			this.xScale = true;
			this.gameObject = null;
			this.space = Space.World;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00171E44 File Offset: 0x00170044
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = (this.space == Space.World) ? ownerDefaultTarget.transform.lossyScale : ownerDefaultTarget.transform.localScale;
			float num;
			if (this.xScale)
			{
				num = vector.x;
			}
			else
			{
				num = vector.y;
			}
			if (num > 0f)
			{
				base.Fsm.Event(this.eventTarget, this.positiveEvent);
			}
			else
			{
				base.Fsm.Event(this.eventTarget, this.negativeEvent);
			}
			base.Finish();
		}

		// Token: 0x0400475C RID: 18268
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400475D RID: 18269
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x0400475E RID: 18270
		[Tooltip("If false, check Y scale")]
		public bool xScale;

		// Token: 0x0400475F RID: 18271
		public FsmEvent positiveEvent;

		// Token: 0x04004760 RID: 18272
		public FsmEvent negativeEvent;

		// Token: 0x04004761 RID: 18273
		public Space space;
	}
}
