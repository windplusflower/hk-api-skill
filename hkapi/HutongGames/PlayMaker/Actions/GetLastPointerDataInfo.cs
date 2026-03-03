using System;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A7E RID: 2686
	[ActionCategory("uGUI")]
	[Tooltip("Gets pointer data on the last System event.")]
	public class GetLastPointerDataInfo : FsmStateAction
	{
		// Token: 0x060039E9 RID: 14825 RVA: 0x00151C58 File Offset: 0x0014FE58
		public override void Reset()
		{
			this.clickCount = null;
			this.clickTime = null;
			this.delta = null;
			this.dragging = null;
			this.eligibleForClick = null;
			this.enterEventCamera = null;
			this.pressEventCamera = null;
			this.isPointerMoving = null;
			this.isScrolling = null;
			this.lastPress = null;
			this.pointerDrag = null;
			this.pointerEnter = null;
			this.pointerId = null;
			this.pointerPress = null;
			this.position = null;
			this.pressPosition = null;
			this.rawPointerPress = null;
			this.scrollDelta = null;
			this.used = null;
			this.useDragThreshold = null;
			this.worldNormal = null;
			this.worldPosition = null;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00151D00 File Offset: 0x0014FF00
		public override void OnEnter()
		{
			if (GetLastPointerDataInfo.lastPointeEventData == null)
			{
				base.Finish();
				return;
			}
			if (!this.clickCount.IsNone)
			{
				this.clickCount.Value = GetLastPointerDataInfo.lastPointeEventData.clickCount;
			}
			if (!this.clickTime.IsNone)
			{
				this.clickTime.Value = GetLastPointerDataInfo.lastPointeEventData.clickTime;
			}
			if (!this.delta.IsNone)
			{
				this.delta.Value = GetLastPointerDataInfo.lastPointeEventData.delta;
			}
			if (!this.dragging.IsNone)
			{
				this.dragging.Value = GetLastPointerDataInfo.lastPointeEventData.dragging;
			}
			if (!this.eligibleForClick.IsNone)
			{
				this.eligibleForClick.Value = GetLastPointerDataInfo.lastPointeEventData.eligibleForClick;
			}
			if (!this.enterEventCamera.IsNone)
			{
				this.enterEventCamera.Value = GetLastPointerDataInfo.lastPointeEventData.enterEventCamera.gameObject;
			}
			if (!this.isPointerMoving.IsNone)
			{
				this.isPointerMoving.Value = GetLastPointerDataInfo.lastPointeEventData.IsPointerMoving();
			}
			if (!this.isScrolling.IsNone)
			{
				this.isScrolling.Value = GetLastPointerDataInfo.lastPointeEventData.IsScrolling();
			}
			if (!this.lastPress.IsNone)
			{
				this.lastPress.Value = GetLastPointerDataInfo.lastPointeEventData.lastPress;
			}
			if (!this.pointerDrag.IsNone)
			{
				this.pointerDrag.Value = GetLastPointerDataInfo.lastPointeEventData.pointerDrag;
			}
			if (!this.pointerEnter.IsNone)
			{
				this.pointerEnter.Value = GetLastPointerDataInfo.lastPointeEventData.pointerEnter;
			}
			if (!this.pointerId.IsNone)
			{
				this.pointerId.Value = GetLastPointerDataInfo.lastPointeEventData.pointerId;
			}
			if (!this.pointerPress.IsNone)
			{
				this.pointerPress.Value = GetLastPointerDataInfo.lastPointeEventData.pointerPress;
			}
			if (!this.position.IsNone)
			{
				this.position.Value = GetLastPointerDataInfo.lastPointeEventData.position;
			}
			if (!this.pressEventCamera.IsNone)
			{
				this.pressEventCamera.Value = GetLastPointerDataInfo.lastPointeEventData.pressEventCamera.gameObject;
			}
			if (!this.pressPosition.IsNone)
			{
				this.pressPosition.Value = GetLastPointerDataInfo.lastPointeEventData.pressPosition;
			}
			if (!this.rawPointerPress.IsNone)
			{
				this.rawPointerPress.Value = GetLastPointerDataInfo.lastPointeEventData.rawPointerPress;
			}
			if (!this.scrollDelta.IsNone)
			{
				this.scrollDelta.Value = GetLastPointerDataInfo.lastPointeEventData.scrollDelta;
			}
			if (!this.used.IsNone)
			{
				this.used.Value = GetLastPointerDataInfo.lastPointeEventData.used;
			}
			if (!this.useDragThreshold.IsNone)
			{
				this.useDragThreshold.Value = GetLastPointerDataInfo.lastPointeEventData.useDragThreshold;
			}
			if (!this.worldNormal.IsNone)
			{
				this.worldNormal.Value = GetLastPointerDataInfo.lastPointeEventData.worldNormal;
			}
			if (!this.worldPosition.IsNone)
			{
				this.worldPosition.Value = GetLastPointerDataInfo.lastPointeEventData.worldPosition;
			}
			base.Finish();
		}

		// Token: 0x04003D02 RID: 15618
		public static PointerEventData lastPointeEventData;

		// Token: 0x04003D03 RID: 15619
		[UIHint(UIHint.Variable)]
		public FsmInt clickCount;

		// Token: 0x04003D04 RID: 15620
		[UIHint(UIHint.Variable)]
		public FsmFloat clickTime;

		// Token: 0x04003D05 RID: 15621
		[UIHint(UIHint.Variable)]
		public FsmVector2 delta;

		// Token: 0x04003D06 RID: 15622
		[UIHint(UIHint.Variable)]
		public FsmBool dragging;

		// Token: 0x04003D07 RID: 15623
		[UIHint(UIHint.Variable)]
		public FsmBool eligibleForClick;

		// Token: 0x04003D08 RID: 15624
		[UIHint(UIHint.Variable)]
		public FsmGameObject enterEventCamera;

		// Token: 0x04003D09 RID: 15625
		[UIHint(UIHint.Variable)]
		public FsmGameObject pressEventCamera;

		// Token: 0x04003D0A RID: 15626
		[UIHint(UIHint.Variable)]
		public FsmBool isPointerMoving;

		// Token: 0x04003D0B RID: 15627
		[UIHint(UIHint.Variable)]
		public FsmBool isScrolling;

		// Token: 0x04003D0C RID: 15628
		[UIHint(UIHint.Variable)]
		public FsmGameObject lastPress;

		// Token: 0x04003D0D RID: 15629
		[UIHint(UIHint.Variable)]
		public FsmGameObject pointerDrag;

		// Token: 0x04003D0E RID: 15630
		[UIHint(UIHint.Variable)]
		public FsmGameObject pointerEnter;

		// Token: 0x04003D0F RID: 15631
		[UIHint(UIHint.Variable)]
		public FsmInt pointerId;

		// Token: 0x04003D10 RID: 15632
		[UIHint(UIHint.Variable)]
		public FsmGameObject pointerPress;

		// Token: 0x04003D11 RID: 15633
		[UIHint(UIHint.Variable)]
		public FsmVector2 position;

		// Token: 0x04003D12 RID: 15634
		[UIHint(UIHint.Variable)]
		public FsmVector2 pressPosition;

		// Token: 0x04003D13 RID: 15635
		[UIHint(UIHint.Variable)]
		public FsmGameObject rawPointerPress;

		// Token: 0x04003D14 RID: 15636
		[UIHint(UIHint.Variable)]
		public FsmVector2 scrollDelta;

		// Token: 0x04003D15 RID: 15637
		[UIHint(UIHint.Variable)]
		public FsmBool used;

		// Token: 0x04003D16 RID: 15638
		[UIHint(UIHint.Variable)]
		public FsmBool useDragThreshold;

		// Token: 0x04003D17 RID: 15639
		[UIHint(UIHint.Variable)]
		public FsmVector3 worldNormal;

		// Token: 0x04003D18 RID: 15640
		[UIHint(UIHint.Variable)]
		public FsmVector3 worldPosition;
	}
}
