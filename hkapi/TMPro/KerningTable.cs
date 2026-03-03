using System;
using System.Collections.Generic;
using System.Linq;

namespace TMPro
{
	// Token: 0x02000632 RID: 1586
	[Serializable]
	public class KerningTable
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x000C84E3 File Offset: 0x000C66E3
		public KerningTable()
		{
			this.kerningPairs = new List<KerningPair>();
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000C84F8 File Offset: 0x000C66F8
		public void AddKerningPair()
		{
			if (this.kerningPairs.Count == 0)
			{
				this.kerningPairs.Add(new KerningPair(0, 0, 0f));
				return;
			}
			int ascII_Left = this.kerningPairs.Last<KerningPair>().AscII_Left;
			int ascII_Right = this.kerningPairs.Last<KerningPair>().AscII_Right;
			float xadvanceOffset = this.kerningPairs.Last<KerningPair>().XadvanceOffset;
			this.kerningPairs.Add(new KerningPair(ascII_Left, ascII_Right, xadvanceOffset));
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000C8570 File Offset: 0x000C6770
		public int AddKerningPair(int left, int right, float offset)
		{
			if (this.kerningPairs.FindIndex((KerningPair item) => item.AscII_Left == left && item.AscII_Right == right) == -1)
			{
				this.kerningPairs.Add(new KerningPair(left, right, offset));
				return 0;
			}
			return -1;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000C85CC File Offset: 0x000C67CC
		public void RemoveKerningPair(int left, int right)
		{
			int num = this.kerningPairs.FindIndex((KerningPair item) => item.AscII_Left == left && item.AscII_Right == right);
			if (num != -1)
			{
				this.kerningPairs.RemoveAt(num);
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000C8615 File Offset: 0x000C6815
		public void RemoveKerningPair(int index)
		{
			this.kerningPairs.RemoveAt(index);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000C8624 File Offset: 0x000C6824
		public void SortKerningPairs()
		{
			if (this.kerningPairs.Count > 0)
			{
				this.kerningPairs = (from s in this.kerningPairs
				orderby s.AscII_Left, s.AscII_Right
				select s).ToList<KerningPair>();
			}
		}

		// Token: 0x04002A3B RID: 10811
		public List<KerningPair> kerningPairs;
	}
}
