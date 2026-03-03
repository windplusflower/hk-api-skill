using System;
using InControl;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000694 RID: 1684
	public class MenuScroller : UIBehaviour, IMoveHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler, ISubmitHandler, IPointerClickHandler, ICancelHandler
	{
		// Token: 0x0600280B RID: 10251 RVA: 0x000E0BDC File Offset: 0x000DEDDC
		public void OnSelect(BaseEventData eventData)
		{
			this.prevRepeatRate = this.inputModule.moveRepeatDelayDuration;
			this.prevInitialDelay = this.inputModule.moveRepeatFirstDuration;
			this.inputModule.moveRepeatDelayDuration = this.scrollRepeatRate;
			this.inputModule.moveRepeatFirstDuration = this.scrollFirstDelay;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000E0C2D File Offset: 0x000DEE2D
		public void OnDeselect(BaseEventData eventData)
		{
			this.inputModule.moveRepeatDelayDuration = this.prevRepeatRate;
			this.inputModule.moveRepeatFirstDuration = this.prevInitialDelay;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000E0C51 File Offset: 0x000DEE51
		public void OnSubmit(BaseEventData eventData)
		{
			this.OnDeselect(eventData);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000E0C51 File Offset: 0x000DEE51
		public void OnPointerClick(PointerEventData eventData)
		{
			this.OnDeselect(eventData);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000E0C51 File Offset: 0x000DEE51
		public void OnCancel(BaseEventData eventData)
		{
			this.OnDeselect(eventData);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000E0C5C File Offset: 0x000DEE5C
		public void OnMove(AxisEventData move)
		{
			if (move.moveDir == MoveDirection.Up)
			{
				this.scrollbar.value += this.scrollRate;
				return;
			}
			if (move.moveDir == MoveDirection.Down)
			{
				this.scrollbar.value -= this.scrollRate;
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000E0CAC File Offset: 0x000DEEAC
		public MenuScroller()
		{
			this.scrollRate = 0.1f;
			this.scrollRepeatRate = 0.02f;
			this.scrollFirstDelay = 0.4f;
			base..ctor();
		}

		// Token: 0x04002D0A RID: 11530
		public ScrollRect scrollRect;

		// Token: 0x04002D0B RID: 11531
		public Scrollbar scrollbar;

		// Token: 0x04002D0C RID: 11532
		public HollowKnightInputModule inputModule;

		// Token: 0x04002D0D RID: 11533
		public float scrollRate;

		// Token: 0x04002D0E RID: 11534
		public float scrollRepeatRate;

		// Token: 0x04002D0F RID: 11535
		public float scrollFirstDelay;

		// Token: 0x04002D10 RID: 11536
		private EventSystem eventSystem;

		// Token: 0x04002D11 RID: 11537
		private float prevRepeatRate;

		// Token: 0x04002D12 RID: 11538
		private float prevInitialDelay;
	}
}
