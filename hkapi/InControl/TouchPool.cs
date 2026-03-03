using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200071A RID: 1818
	public class TouchPool
	{
		// Token: 0x06002D18 RID: 11544 RVA: 0x000F2764 File Offset: 0x000F0964
		public TouchPool(int capacity)
		{
			this.freeTouches = new List<Touch>(capacity);
			for (int i = 0; i < capacity; i++)
			{
				this.freeTouches.Add(new Touch());
			}
			this.usedTouches = new List<Touch>(capacity);
			this.Touches = new ReadOnlyCollection<Touch>(this.usedTouches);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000F27BC File Offset: 0x000F09BC
		public TouchPool() : this(16)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000F27C8 File Offset: 0x000F09C8
		public Touch FindOrCreateTouch(int fingerId)
		{
			int count = this.usedTouches.Count;
			Touch touch;
			for (int i = 0; i < count; i++)
			{
				touch = this.usedTouches[i];
				if (touch.fingerId == fingerId)
				{
					return touch;
				}
			}
			touch = this.NewTouch();
			touch.fingerId = fingerId;
			this.usedTouches.Add(touch);
			return touch;
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000F2820 File Offset: 0x000F0A20
		public Touch FindTouch(int fingerId)
		{
			int count = this.usedTouches.Count;
			for (int i = 0; i < count; i++)
			{
				Touch touch = this.usedTouches[i];
				if (touch.fingerId == fingerId)
				{
					return touch;
				}
			}
			return null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000F2860 File Offset: 0x000F0A60
		private Touch NewTouch()
		{
			int count = this.freeTouches.Count;
			if (count > 0)
			{
				Touch result = this.freeTouches[count - 1];
				this.freeTouches.RemoveAt(count - 1);
				return result;
			}
			return new Touch();
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000F289F File Offset: 0x000F0A9F
		public void FreeTouch(Touch touch)
		{
			touch.Reset();
			this.freeTouches.Add(touch);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000F28B4 File Offset: 0x000F0AB4
		public void FreeEndedTouches()
		{
			for (int i = this.usedTouches.Count - 1; i >= 0; i--)
			{
				if (this.usedTouches[i].phase == TouchPhase.Ended)
				{
					this.usedTouches.RemoveAt(i);
				}
			}
		}

		// Token: 0x04003292 RID: 12946
		public readonly ReadOnlyCollection<Touch> Touches;

		// Token: 0x04003293 RID: 12947
		private List<Touch> usedTouches;

		// Token: 0x04003294 RID: 12948
		private List<Touch> freeTouches;
	}
}
