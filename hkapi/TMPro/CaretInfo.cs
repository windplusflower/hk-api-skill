using System;

namespace TMPro
{
	// Token: 0x02000621 RID: 1569
	public struct CaretInfo
	{
		// Token: 0x060025CC RID: 9676 RVA: 0x000C62ED File Offset: 0x000C44ED
		public CaretInfo(int index, CaretPosition position)
		{
			this.index = index;
			this.position = position;
		}

		// Token: 0x040029E5 RID: 10725
		public int index;

		// Token: 0x040029E6 RID: 10726
		public CaretPosition position;
	}
}
