using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C72 RID: 3186
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Tests if a point is inside a rectangle.")]
	public class RectContains : FsmStateAction
	{
		// Token: 0x06004296 RID: 17046 RVA: 0x001707E8 File Offset: 0x0016E9E8
		public override void Reset()
		{
			this.rectangle = new FsmRect
			{
				UseVariable = true
			};
			this.point = new FsmVector3
			{
				UseVariable = true
			};
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.storeResult = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00170859 File Offset: 0x0016EA59
		public override void OnEnter()
		{
			this.DoRectContains();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x0017086F File Offset: 0x0016EA6F
		public override void OnUpdate()
		{
			this.DoRectContains();
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00170878 File Offset: 0x0016EA78
		private void DoRectContains()
		{
			if (this.rectangle.IsNone)
			{
				return;
			}
			Vector3 value = this.point.Value;
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			bool flag = this.rectangle.Value.Contains(value);
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x040046F5 RID: 18165
		[RequiredField]
		[Tooltip("Rectangle to test.")]
		public FsmRect rectangle;

		// Token: 0x040046F6 RID: 18166
		[Tooltip("Point to test.")]
		public FsmVector3 point;

		// Token: 0x040046F7 RID: 18167
		[Tooltip("Specify/override X value.")]
		public FsmFloat x;

		// Token: 0x040046F8 RID: 18168
		[Tooltip("Specify/override Y value.")]
		public FsmFloat y;

		// Token: 0x040046F9 RID: 18169
		[Tooltip("Event to send if the Point is inside the Rectangle.")]
		public FsmEvent trueEvent;

		// Token: 0x040046FA RID: 18170
		[Tooltip("Event to send if the Point is outside the Rectangle.")]
		public FsmEvent falseEvent;

		// Token: 0x040046FB RID: 18171
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a variable.")]
		public FsmBool storeResult;

		// Token: 0x040046FC RID: 18172
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
