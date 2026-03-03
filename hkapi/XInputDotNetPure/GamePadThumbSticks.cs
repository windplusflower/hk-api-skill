using System;
using UnityEngine;

namespace XInputDotNetPure
{
	// Token: 0x020006B3 RID: 1715
	public struct GamePadThumbSticks
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x000E4A91 File Offset: 0x000E2C91
		internal GamePadThumbSticks(GamePadThumbSticks.StickValue left, GamePadThumbSticks.StickValue right)
		{
			this.left = left;
			this.right = right;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000E4AA1 File Offset: 0x000E2CA1
		public GamePadThumbSticks.StickValue Left
		{
			get
			{
				return this.left;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000E4AA9 File Offset: 0x000E2CA9
		public GamePadThumbSticks.StickValue Right
		{
			get
			{
				return this.right;
			}
		}

		// Token: 0x04002E8E RID: 11918
		private GamePadThumbSticks.StickValue left;

		// Token: 0x04002E8F RID: 11919
		private GamePadThumbSticks.StickValue right;

		// Token: 0x020006B4 RID: 1716
		public struct StickValue
		{
			// Token: 0x060028B4 RID: 10420 RVA: 0x000E4AB1 File Offset: 0x000E2CB1
			internal StickValue(float x, float y)
			{
				this.vector = new Vector2(x, y);
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000E4AC0 File Offset: 0x000E2CC0
			public float X
			{
				get
				{
					return this.vector.x;
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000E4ACD File Offset: 0x000E2CCD
			public float Y
			{
				get
				{
					return this.vector.y;
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000E4ADA File Offset: 0x000E2CDA
			public Vector2 Vector
			{
				get
				{
					return this.vector;
				}
			}

			// Token: 0x04002E90 RID: 11920
			private Vector2 vector;
		}
	}
}
