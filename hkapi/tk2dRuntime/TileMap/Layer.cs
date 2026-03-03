using System;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x02000650 RID: 1616
	[Serializable]
	public class Layer
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x000DCC01 File Offset: 0x000DAE01
		public Layer(int hash, int width, int height, int divX, int divY)
		{
			this.spriteChannel = new SpriteChannel();
			this.Init(hash, width, height, divX, divY);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000DCC24 File Offset: 0x000DAE24
		public void Init(int hash, int width, int height, int divX, int divY)
		{
			this.divX = divX;
			this.divY = divY;
			this.hash = hash;
			this.numColumns = (width + divX - 1) / divX;
			this.numRows = (height + divY - 1) / divY;
			this.width = width;
			this.height = height;
			this.spriteChannel.chunks = new SpriteChunk[this.numColumns * this.numRows];
			for (int i = 0; i < this.numColumns * this.numRows; i++)
			{
				this.spriteChannel.chunks[i] = new SpriteChunk();
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000DCCBB File Offset: 0x000DAEBB
		public bool IsEmpty
		{
			get
			{
				return this.spriteChannel.chunks.Length == 0;
			}
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000DCCCC File Offset: 0x000DAECC
		public void Create()
		{
			this.spriteChannel.chunks = new SpriteChunk[this.numColumns * this.numRows];
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000DCCEB File Offset: 0x000DAEEB
		public int[] GetChunkData(int x, int y)
		{
			return this.GetChunk(x, y).spriteIds;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000DCCFA File Offset: 0x000DAEFA
		public SpriteChunk GetChunk(int x, int y)
		{
			return this.spriteChannel.chunks[y * this.numColumns + x];
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000DCD14 File Offset: 0x000DAF14
		private SpriteChunk FindChunkAndCoordinate(int x, int y, out int offset)
		{
			int num = x / this.divX;
			int num2 = y / this.divY;
			SpriteChunk result = this.spriteChannel.chunks[num2 * this.numColumns + num];
			int num3 = x - num * this.divX;
			int num4 = y - num2 * this.divY;
			offset = num4 * this.divX + num3;
			return result;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000DCD6C File Offset: 0x000DAF6C
		private bool GetRawTileValue(int x, int y, ref int value)
		{
			int num;
			SpriteChunk spriteChunk = this.FindChunkAndCoordinate(x, y, out num);
			if (spriteChunk.spriteIds == null || spriteChunk.spriteIds.Length == 0)
			{
				return false;
			}
			value = spriteChunk.spriteIds[num];
			return true;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000DCDA4 File Offset: 0x000DAFA4
		private void SetRawTileValue(int x, int y, int value)
		{
			int num;
			SpriteChunk spriteChunk = this.FindChunkAndCoordinate(x, y, out num);
			if (spriteChunk != null)
			{
				this.CreateChunk(spriteChunk);
				spriteChunk.spriteIds[num] = value;
				spriteChunk.Dirty = true;
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000DCDD8 File Offset: 0x000DAFD8
		public void DestroyGameData(tk2dTileMap tilemap)
		{
			foreach (SpriteChunk spriteChunk in this.spriteChannel.chunks)
			{
				if (spriteChunk.HasGameData)
				{
					spriteChunk.DestroyColliderData(tilemap);
					spriteChunk.DestroyGameData(tilemap);
				}
			}
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000DCE1C File Offset: 0x000DB01C
		public int GetTile(int x, int y)
		{
			int num = 0;
			if (this.GetRawTileValue(x, y, ref num) && num != -1)
			{
				return num & 16777215;
			}
			return -1;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000DCE44 File Offset: 0x000DB044
		public tk2dTileFlags GetTileFlags(int x, int y)
		{
			int num = 0;
			if (this.GetRawTileValue(x, y, ref num) && num != -1)
			{
				return (tk2dTileFlags)(num & -16777216);
			}
			return tk2dTileFlags.None;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000DCE6C File Offset: 0x000DB06C
		public int GetRawTile(int x, int y)
		{
			int result = 0;
			if (this.GetRawTileValue(x, y, ref result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000DCE8C File Offset: 0x000DB08C
		public void SetTile(int x, int y, int tile)
		{
			tk2dTileFlags tileFlags = this.GetTileFlags(x, y);
			int value = (tile == -1) ? -1 : (tile | (int)tileFlags);
			this.SetRawTileValue(x, y, value);
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000DCEB8 File Offset: 0x000DB0B8
		public void SetTileFlags(int x, int y, tk2dTileFlags flags)
		{
			int tile = this.GetTile(x, y);
			if (tile != -1)
			{
				int value = tile | (int)flags;
				this.SetRawTileValue(x, y, value);
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000DCEDF File Offset: 0x000DB0DF
		public void ClearTile(int x, int y)
		{
			this.SetTile(x, y, -1);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000DCEEA File Offset: 0x000DB0EA
		public void SetRawTile(int x, int y, int rawTile)
		{
			this.SetRawTileValue(x, y, rawTile);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000DCEF8 File Offset: 0x000DB0F8
		private void CreateChunk(SpriteChunk chunk)
		{
			if (chunk.spriteIds == null || chunk.spriteIds.Length == 0)
			{
				chunk.spriteIds = new int[this.divX * this.divY];
				for (int i = 0; i < this.divX * this.divY; i++)
				{
					chunk.spriteIds[i] = -1;
				}
			}
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000DCF50 File Offset: 0x000DB150
		private void Optimize(SpriteChunk chunk)
		{
			bool flag = true;
			int[] spriteIds = chunk.spriteIds;
			for (int i = 0; i < spriteIds.Length; i++)
			{
				if (spriteIds[i] != -1)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				chunk.spriteIds = new int[0];
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000DCF90 File Offset: 0x000DB190
		public void Optimize()
		{
			foreach (SpriteChunk chunk in this.spriteChannel.chunks)
			{
				this.Optimize(chunk);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000DCFC4 File Offset: 0x000DB1C4
		public void OptimizeIncremental()
		{
			foreach (SpriteChunk spriteChunk in this.spriteChannel.chunks)
			{
				if (spriteChunk.Dirty)
				{
					this.Optimize(spriteChunk);
				}
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000DD000 File Offset: 0x000DB200
		public void ClearDirtyFlag()
		{
			SpriteChunk[] chunks = this.spriteChannel.chunks;
			for (int i = 0; i < chunks.Length; i++)
			{
				chunks[i].Dirty = false;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000DD030 File Offset: 0x000DB230
		public int NumActiveChunks
		{
			get
			{
				int num = 0;
				SpriteChunk[] chunks = this.spriteChannel.chunks;
				for (int i = 0; i < chunks.Length; i++)
				{
					if (!chunks[i].IsEmpty)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x04002B57 RID: 11095
		public int hash;

		// Token: 0x04002B58 RID: 11096
		public SpriteChannel spriteChannel;

		// Token: 0x04002B59 RID: 11097
		private const int tileMask = 16777215;

		// Token: 0x04002B5A RID: 11098
		private const int flagMask = -16777216;

		// Token: 0x04002B5B RID: 11099
		public int width;

		// Token: 0x04002B5C RID: 11100
		public int height;

		// Token: 0x04002B5D RID: 11101
		public int numColumns;

		// Token: 0x04002B5E RID: 11102
		public int numRows;

		// Token: 0x04002B5F RID: 11103
		public int divX;

		// Token: 0x04002B60 RID: 11104
		public int divY;

		// Token: 0x04002B61 RID: 11105
		public GameObject gameObject;
	}
}
