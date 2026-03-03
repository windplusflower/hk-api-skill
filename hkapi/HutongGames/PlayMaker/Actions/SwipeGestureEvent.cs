using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CFB RID: 3323
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends an event when a swipe is detected.")]
	public class SwipeGestureEvent : FsmStateAction
	{
		// Token: 0x06004505 RID: 17669 RVA: 0x00177D71 File Offset: 0x00175F71
		public override void Reset()
		{
			this.minSwipeDistance = 0.1f;
			this.swipeLeftEvent = null;
			this.swipeRightEvent = null;
			this.swipeUpEvent = null;
			this.swipeDownEvent = null;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00177D9F File Offset: 0x00175F9F
		public override void OnEnter()
		{
			this.screenDiagonalSize = Mathf.Sqrt((float)(Screen.width * Screen.width + Screen.height * Screen.height));
			this.minSwipeDistancePixels = this.minSwipeDistance.Value * this.screenDiagonalSize;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00177DDC File Offset: 0x00175FDC
		public override void OnUpdate()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.touches[0];
				switch (touch.phase)
				{
				case TouchPhase.Began:
					this.touchStarted = true;
					this.touchStartPos = touch.position;
					return;
				case TouchPhase.Moved:
				case TouchPhase.Stationary:
					break;
				case TouchPhase.Ended:
					if (this.touchStarted)
					{
						this.TestForSwipeGesture(touch);
						this.touchStarted = false;
						return;
					}
					break;
				case TouchPhase.Canceled:
					this.touchStarted = false;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00177E54 File Offset: 0x00176054
		private void TestForSwipeGesture(Touch touch)
		{
			Vector2 position = touch.position;
			if (Vector2.Distance(position, this.touchStartPos) > this.minSwipeDistancePixels)
			{
				float x = position.y - this.touchStartPos.y;
				float y = position.x - this.touchStartPos.x;
				float num = 57.29578f * Mathf.Atan2(y, x);
				num = (360f + num - 45f) % 360f;
				Debug.Log(num);
				if (num < 90f)
				{
					base.Fsm.Event(this.swipeRightEvent);
					return;
				}
				if (num < 180f)
				{
					base.Fsm.Event(this.swipeDownEvent);
					return;
				}
				if (num < 270f)
				{
					base.Fsm.Event(this.swipeLeftEvent);
					return;
				}
				base.Fsm.Event(this.swipeUpEvent);
			}
		}

		// Token: 0x04004956 RID: 18774
		[Tooltip("How far a touch has to travel to be considered a swipe. Uses normalized distance (e.g. 1 = 1 screen diagonal distance). Should generally be a very small number.")]
		public FsmFloat minSwipeDistance;

		// Token: 0x04004957 RID: 18775
		[Tooltip("Event to send when swipe left detected.")]
		public FsmEvent swipeLeftEvent;

		// Token: 0x04004958 RID: 18776
		[Tooltip("Event to send when swipe right detected.")]
		public FsmEvent swipeRightEvent;

		// Token: 0x04004959 RID: 18777
		[Tooltip("Event to send when swipe up detected.")]
		public FsmEvent swipeUpEvent;

		// Token: 0x0400495A RID: 18778
		[Tooltip("Event to send when swipe down detected.")]
		public FsmEvent swipeDownEvent;

		// Token: 0x0400495B RID: 18779
		private float screenDiagonalSize;

		// Token: 0x0400495C RID: 18780
		private float minSwipeDistancePixels;

		// Token: 0x0400495D RID: 18781
		private bool touchStarted;

		// Token: 0x0400495E RID: 18782
		private Vector2 touchStartPos;
	}
}
