using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000629 RID: 1577
	public class Compute_DT_EventArgs
	{
		// Token: 0x0600260C RID: 9740 RVA: 0x000C7FDD File Offset: 0x000C61DD
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
		{
			this.EventType = type;
			this.ProgressPercentage = progress;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000C7FF3 File Offset: 0x000C61F3
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors)
		{
			this.EventType = type;
			this.Colors = colors;
		}

		// Token: 0x04002A07 RID: 10759
		public Compute_DistanceTransform_EventTypes EventType;

		// Token: 0x04002A08 RID: 10760
		public float ProgressPercentage;

		// Token: 0x04002A09 RID: 10761
		public Color[] Colors;
	}
}
