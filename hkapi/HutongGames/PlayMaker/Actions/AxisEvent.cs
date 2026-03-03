using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2E RID: 2862
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends events based on the direction of Input Axis (Left/Right/Up/Down...).")]
	public class AxisEvent : FsmStateAction
	{
		// Token: 0x06003D3B RID: 15675 RVA: 0x001604D0 File Offset: 0x0015E6D0
		public override void Reset()
		{
			this.horizontalAxis = "Horizontal";
			this.verticalAxis = "Vertical";
			this.leftEvent = null;
			this.rightEvent = null;
			this.upEvent = null;
			this.downEvent = null;
			this.anyDirection = null;
			this.noDirection = null;
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00160528 File Offset: 0x0015E728
		public override void OnUpdate()
		{
			float num = (this.horizontalAxis.Value != "") ? Input.GetAxis(this.horizontalAxis.Value) : 0f;
			float num2 = (this.verticalAxis.Value != "") ? Input.GetAxis(this.verticalAxis.Value) : 0f;
			if ((num * num + num2 * num2).Equals(0f))
			{
				if (this.noDirection != null)
				{
					base.Fsm.Event(this.noDirection);
				}
				return;
			}
			float num3 = Mathf.Atan2(num2, num) * 57.29578f + 45f;
			if (num3 < 0f)
			{
				num3 += 360f;
			}
			int num4 = (int)(num3 / 90f);
			if (num4 == 0 && this.rightEvent != null)
			{
				base.Fsm.Event(this.rightEvent);
				return;
			}
			if (num4 == 1 && this.upEvent != null)
			{
				base.Fsm.Event(this.upEvent);
				return;
			}
			if (num4 == 2 && this.leftEvent != null)
			{
				base.Fsm.Event(this.leftEvent);
				return;
			}
			if (num4 == 3 && this.downEvent != null)
			{
				base.Fsm.Event(this.downEvent);
				return;
			}
			if (this.anyDirection != null)
			{
				base.Fsm.Event(this.anyDirection);
			}
		}

		// Token: 0x04004144 RID: 16708
		[Tooltip("Horizontal axis as defined in the Input Manager")]
		public FsmString horizontalAxis;

		// Token: 0x04004145 RID: 16709
		[Tooltip("Vertical axis as defined in the Input Manager")]
		public FsmString verticalAxis;

		// Token: 0x04004146 RID: 16710
		[Tooltip("Event to send if input is to the left.")]
		public FsmEvent leftEvent;

		// Token: 0x04004147 RID: 16711
		[Tooltip("Event to send if input is to the right.")]
		public FsmEvent rightEvent;

		// Token: 0x04004148 RID: 16712
		[Tooltip("Event to send if input is to the up.")]
		public FsmEvent upEvent;

		// Token: 0x04004149 RID: 16713
		[Tooltip("Event to send if input is to the down.")]
		public FsmEvent downEvent;

		// Token: 0x0400414A RID: 16714
		[Tooltip("Event to send if input is in any direction.")]
		public FsmEvent anyDirection;

		// Token: 0x0400414B RID: 16715
		[Tooltip("Event to send if no axis input (centered).")]
		public FsmEvent noDirection;
	}
}
