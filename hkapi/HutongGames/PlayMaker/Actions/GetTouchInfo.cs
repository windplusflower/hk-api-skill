using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C1E RID: 3102
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets info on a touch event.")]
	public class GetTouchInfo : FsmStateAction
	{
		// Token: 0x0600410A RID: 16650 RVA: 0x0016B7AC File Offset: 0x001699AC
		public override void Reset()
		{
			this.fingerId = new FsmInt
			{
				UseVariable = true
			};
			this.normalize = true;
			this.storePosition = null;
			this.storeDeltaPosition = null;
			this.storeDeltaTime = null;
			this.storeTapCount = null;
			this.everyFrame = true;
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x0016B7FA File Offset: 0x001699FA
		public override void OnEnter()
		{
			this.screenWidth = (float)Screen.width;
			this.screenHeight = (float)Screen.height;
			this.DoGetTouchInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x0016B828 File Offset: 0x00169A28
		public override void OnUpdate()
		{
			this.DoGetTouchInfo();
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x0016B830 File Offset: 0x00169A30
		private void DoGetTouchInfo()
		{
			if (Input.touchCount > 0)
			{
				foreach (Touch touch in Input.touches)
				{
					if (this.fingerId.IsNone || touch.fingerId == this.fingerId.Value)
					{
						float num = (!this.normalize.Value) ? touch.position.x : (touch.position.x / this.screenWidth);
						float num2 = (!this.normalize.Value) ? touch.position.y : (touch.position.y / this.screenHeight);
						if (!this.storePosition.IsNone)
						{
							this.storePosition.Value = new Vector3(num, num2, 0f);
						}
						this.storeX.Value = num;
						this.storeY.Value = num2;
						float num3 = (!this.normalize.Value) ? touch.deltaPosition.x : (touch.deltaPosition.x / this.screenWidth);
						float num4 = (!this.normalize.Value) ? touch.deltaPosition.y : (touch.deltaPosition.y / this.screenHeight);
						if (!this.storeDeltaPosition.IsNone)
						{
							this.storeDeltaPosition.Value = new Vector3(num3, num4, 0f);
						}
						this.storeDeltaX.Value = num3;
						this.storeDeltaY.Value = num4;
						this.storeDeltaTime.Value = touch.deltaTime;
						this.storeTapCount.Value = touch.tapCount;
					}
				}
			}
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x0016B9EF File Offset: 0x00169BEF
		public GetTouchInfo()
		{
			this.everyFrame = true;
			base..ctor();
		}

		// Token: 0x0400454D RID: 17741
		[Tooltip("Filter by a Finger ID. You can store a Finger ID in other Touch actions, e.g., Touch Event.")]
		public FsmInt fingerId;

		// Token: 0x0400454E RID: 17742
		[Tooltip("If true, all screen coordinates are returned normalized (0-1), otherwise in pixels.")]
		public FsmBool normalize;

		// Token: 0x0400454F RID: 17743
		[UIHint(UIHint.Variable)]
		public FsmVector3 storePosition;

		// Token: 0x04004550 RID: 17744
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		// Token: 0x04004551 RID: 17745
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		// Token: 0x04004552 RID: 17746
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeDeltaPosition;

		// Token: 0x04004553 RID: 17747
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDeltaX;

		// Token: 0x04004554 RID: 17748
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDeltaY;

		// Token: 0x04004555 RID: 17749
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDeltaTime;

		// Token: 0x04004556 RID: 17750
		[UIHint(UIHint.Variable)]
		public FsmInt storeTapCount;

		// Token: 0x04004557 RID: 17751
		public bool everyFrame;

		// Token: 0x04004558 RID: 17752
		private float screenWidth;

		// Token: 0x04004559 RID: 17753
		private float screenHeight;
	}
}
