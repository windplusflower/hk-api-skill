using System;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x0200064F RID: 1615
	[Serializable]
	public class ColorChannel
	{
		// Token: 0x06002718 RID: 10008 RVA: 0x000DC671 File Offset: 0x000DA871
		public ColorChannel(int width, int height, int divX, int divY)
		{
			this.clearColor = Color.white;
			base..ctor();
			this.Init(width, height, divX, divY);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000DC68F File Offset: 0x000DA88F
		public ColorChannel()
		{
			this.clearColor = Color.white;
			base..ctor();
			this.chunks = new ColorChunk[0];
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000DC6AE File Offset: 0x000DA8AE
		public void Init(int width, int height, int divX, int divY)
		{
			this.numColumns = (width + divX - 1) / divX;
			this.numRows = (height + divY - 1) / divY;
			this.chunks = new ColorChunk[0];
			this.divX = divX;
			this.divY = divY;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000DC6E8 File Offset: 0x000DA8E8
		public ColorChunk FindChunkAndCoordinate(int x, int y, out int offset)
		{
			int num = x / this.divX;
			int num2 = y / this.divY;
			num = Mathf.Clamp(num, 0, this.numColumns - 1);
			num2 = Mathf.Clamp(num2, 0, this.numRows - 1);
			int num3 = num2 * this.numColumns + num;
			ColorChunk result = this.chunks[num3];
			int num4 = x - num * this.divX;
			int num5 = y - num2 * this.divY;
			offset = num5 * (this.divX + 1) + num4;
			return result;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000DC760 File Offset: 0x000DA960
		public Color GetColor(int x, int y)
		{
			if (this.IsEmpty)
			{
				return this.clearColor;
			}
			int num;
			ColorChunk colorChunk = this.FindChunkAndCoordinate(x, y, out num);
			if (colorChunk.colors.Length == 0)
			{
				return this.clearColor;
			}
			return colorChunk.colors[num];
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000DC7A8 File Offset: 0x000DA9A8
		private void InitChunk(ColorChunk chunk)
		{
			if (chunk.colors.Length == 0)
			{
				chunk.colors = new Color32[(this.divX + 1) * (this.divY + 1)];
				for (int i = 0; i < chunk.colors.Length; i++)
				{
					chunk.colors[i] = this.clearColor;
				}
			}
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000DC804 File Offset: 0x000DAA04
		public void SetColor(int x, int y, Color color)
		{
			if (this.IsEmpty)
			{
				this.Create();
			}
			int num = this.divX + 1;
			int num2 = Mathf.Max(x - 1, 0) / this.divX;
			int num3 = Mathf.Max(y - 1, 0) / this.divY;
			ColorChunk chunk = this.GetChunk(num2, num3, true);
			int num4 = x - num2 * this.divX;
			int num5 = y - num3 * this.divY;
			chunk.colors[num5 * num + num4] = color;
			chunk.Dirty = true;
			bool flag = false;
			bool flag2 = false;
			if (x != 0 && x % this.divX == 0 && num2 + 1 < this.numColumns)
			{
				flag = true;
			}
			if (y != 0 && y % this.divY == 0 && num3 + 1 < this.numRows)
			{
				flag2 = true;
			}
			if (flag)
			{
				int num6 = num2 + 1;
				ColorChunk chunk2 = this.GetChunk(num6, num3, true);
				num4 = x - num6 * this.divX;
				num5 = y - num3 * this.divY;
				chunk2.colors[num5 * num + num4] = color;
				chunk2.Dirty = true;
			}
			if (flag2)
			{
				int num7 = num3 + 1;
				ColorChunk chunk3 = this.GetChunk(num2, num7, true);
				num4 = x - num2 * this.divX;
				num5 = y - num7 * this.divY;
				chunk3.colors[num5 * num + num4] = color;
				chunk3.Dirty = true;
			}
			if (flag && flag2)
			{
				int num8 = num2 + 1;
				int num9 = num3 + 1;
				ColorChunk chunk4 = this.GetChunk(num8, num9, true);
				num4 = x - num8 * this.divX;
				num5 = y - num9 * this.divY;
				chunk4.colors[num5 * num + num4] = color;
				chunk4.Dirty = true;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000DC9A5 File Offset: 0x000DABA5
		public ColorChunk GetChunk(int x, int y)
		{
			if (this.chunks == null || this.chunks.Length == 0)
			{
				return null;
			}
			return this.chunks[y * this.numColumns + x];
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000DC9CC File Offset: 0x000DABCC
		public ColorChunk GetChunk(int x, int y, bool init)
		{
			if (this.chunks == null || this.chunks.Length == 0)
			{
				return null;
			}
			ColorChunk colorChunk = this.chunks[y * this.numColumns + x];
			this.InitChunk(colorChunk);
			return colorChunk;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000DCA08 File Offset: 0x000DAC08
		public void ClearChunk(ColorChunk chunk)
		{
			for (int i = 0; i < chunk.colors.Length; i++)
			{
				chunk.colors[i] = this.clearColor;
			}
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000DCA40 File Offset: 0x000DAC40
		public void ClearDirtyFlag()
		{
			ColorChunk[] array = this.chunks;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dirty = false;
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000DCA6C File Offset: 0x000DAC6C
		public void Clear(Color color)
		{
			this.clearColor = color;
			foreach (ColorChunk chunk in this.chunks)
			{
				this.ClearChunk(chunk);
			}
			this.Optimize();
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000DCAA6 File Offset: 0x000DACA6
		public void Delete()
		{
			this.chunks = new ColorChunk[0];
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000DCAB4 File Offset: 0x000DACB4
		public void Create()
		{
			this.chunks = new ColorChunk[this.numColumns * this.numRows];
			for (int i = 0; i < this.chunks.Length; i++)
			{
				this.chunks[i] = new ColorChunk();
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000DCAFC File Offset: 0x000DACFC
		private void Optimize(ColorChunk chunk)
		{
			bool flag = true;
			Color32 color = this.clearColor;
			foreach (Color32 color2 in chunk.colors)
			{
				if (color2.r != color.r || color2.g != color.g || color2.b != color.b || color2.a != color.a)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				chunk.colors = new Color32[0];
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000DCB84 File Offset: 0x000DAD84
		public void Optimize()
		{
			foreach (ColorChunk chunk in this.chunks)
			{
				this.Optimize(chunk);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000DCBB1 File Offset: 0x000DADB1
		public bool IsEmpty
		{
			get
			{
				return this.chunks.Length == 0;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000DCBC0 File Offset: 0x000DADC0
		public int NumActiveChunks
		{
			get
			{
				int num = 0;
				foreach (ColorChunk colorChunk in this.chunks)
				{
					if (colorChunk != null && colorChunk.colors != null && colorChunk.colors.Length != 0)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x04002B51 RID: 11089
		public Color clearColor;

		// Token: 0x04002B52 RID: 11090
		public ColorChunk[] chunks;

		// Token: 0x04002B53 RID: 11091
		public int numColumns;

		// Token: 0x04002B54 RID: 11092
		public int numRows;

		// Token: 0x04002B55 RID: 11093
		public int divX;

		// Token: 0x04002B56 RID: 11094
		public int divY;
	}
}
