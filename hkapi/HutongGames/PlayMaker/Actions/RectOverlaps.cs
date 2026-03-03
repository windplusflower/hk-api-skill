using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C73 RID: 3187
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Tests if 2 Rects overlap.")]
	public class RectOverlaps : FsmStateAction
	{
		// Token: 0x0600429B RID: 17051 RVA: 0x0017091C File Offset: 0x0016EB1C
		public override void Reset()
		{
			this.rect1 = new FsmRect
			{
				UseVariable = true
			};
			this.rect2 = new FsmRect
			{
				UseVariable = true
			};
			this.storeResult = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00170969 File Offset: 0x0016EB69
		public override void OnEnter()
		{
			this.DoRectOverlap();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x0017097F File Offset: 0x0016EB7F
		public override void OnUpdate()
		{
			this.DoRectOverlap();
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x00170988 File Offset: 0x0016EB88
		private void DoRectOverlap()
		{
			if (this.rect1.IsNone || this.rect2.IsNone)
			{
				return;
			}
			bool flag = RectOverlaps.Intersect(this.rect1.Value, this.rect2.Value);
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x001709F4 File Offset: 0x0016EBF4
		public static bool Intersect(Rect a, Rect b)
		{
			RectOverlaps.FlipNegative(ref a);
			RectOverlaps.FlipNegative(ref b);
			bool flag = a.xMin < b.xMax;
			bool flag2 = a.xMax > b.xMin;
			bool flag3 = a.yMin < b.yMax;
			bool flag4 = a.yMax > b.yMin;
			return flag && flag2 && flag3 && flag4;
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x00170A58 File Offset: 0x0016EC58
		public static void FlipNegative(ref Rect r)
		{
			if (r.width < 0f)
			{
				r.x -= (r.width *= -1f);
			}
			if (r.height < 0f)
			{
				r.y -= (r.height *= -1f);
			}
		}

		// Token: 0x040046FD RID: 18173
		[RequiredField]
		[Tooltip("First Rectangle.")]
		public FsmRect rect1;

		// Token: 0x040046FE RID: 18174
		[RequiredField]
		[Tooltip("Second Rectangle.")]
		public FsmRect rect2;

		// Token: 0x040046FF RID: 18175
		[Tooltip("Event to send if the Rects overlap.")]
		public FsmEvent trueEvent;

		// Token: 0x04004700 RID: 18176
		[Tooltip("Event to send if the Rects do not overlap.")]
		public FsmEvent falseEvent;

		// Token: 0x04004701 RID: 18177
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a variable.")]
		public FsmBool storeResult;

		// Token: 0x04004702 RID: 18178
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
