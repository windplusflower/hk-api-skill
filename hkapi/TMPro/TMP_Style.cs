using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200060C RID: 1548
	[Serializable]
	public class TMP_Style
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x000BBFF2 File Offset: 0x000BA1F2
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x000BBFFA File Offset: 0x000BA1FA
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				if (value != this.m_Name)
				{
					this.m_Name = value;
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000BC011 File Offset: 0x000BA211
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x000BC019 File Offset: 0x000BA219
		public int hashCode
		{
			get
			{
				return this.m_HashCode;
			}
			set
			{
				if (value != this.m_HashCode)
				{
					this.m_HashCode = value;
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000BC02B File Offset: 0x000BA22B
		public string styleOpeningDefinition
		{
			get
			{
				return this.m_OpeningDefinition;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000BC033 File Offset: 0x000BA233
		public string styleClosingDefinition
		{
			get
			{
				return this.m_ClosingDefinition;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000BC03B File Offset: 0x000BA23B
		public int[] styleOpeningTagArray
		{
			get
			{
				return this.m_OpeningTagArray;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000BC043 File Offset: 0x000BA243
		public int[] styleClosingTagArray
		{
			get
			{
				return this.m_ClosingTagArray;
			}
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000BC04C File Offset: 0x000BA24C
		public void RefreshStyle()
		{
			this.m_HashCode = TMP_TextUtilities.GetSimpleHashCode(this.m_Name);
			this.m_OpeningTagArray = new int[this.m_OpeningDefinition.Length];
			for (int i = 0; i < this.m_OpeningDefinition.Length; i++)
			{
				this.m_OpeningTagArray[i] = (int)this.m_OpeningDefinition[i];
			}
			this.m_ClosingTagArray = new int[this.m_ClosingDefinition.Length];
			for (int j = 0; j < this.m_ClosingDefinition.Length; j++)
			{
				this.m_ClosingTagArray[j] = (int)this.m_ClosingDefinition[j];
			}
		}

		// Token: 0x0400289C RID: 10396
		[SerializeField]
		private string m_Name;

		// Token: 0x0400289D RID: 10397
		[SerializeField]
		private int m_HashCode;

		// Token: 0x0400289E RID: 10398
		[SerializeField]
		private string m_OpeningDefinition;

		// Token: 0x0400289F RID: 10399
		[SerializeField]
		private string m_ClosingDefinition;

		// Token: 0x040028A0 RID: 10400
		[SerializeField]
		private int[] m_OpeningTagArray;

		// Token: 0x040028A1 RID: 10401
		[SerializeField]
		private int[] m_ClosingTagArray;
	}
}
