using System;
using System.Collections.Generic;
using tk2dRuntime.TileMap;
using UnityEngine;

// Token: 0x02000599 RID: 1433
public class tk2dTileMapData : ScriptableObject
{
	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000A10EF File Offset: 0x0009F2EF
	public int NumLayers
	{
		get
		{
			if (this.tileMapLayers == null || this.tileMapLayers.Count == 0)
			{
				this.InitLayers();
			}
			return this.tileMapLayers.Count;
		}
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000A1117 File Offset: 0x0009F317
	public LayerInfo[] Layers
	{
		get
		{
			if (this.tileMapLayers == null || this.tileMapLayers.Count == 0)
			{
				this.InitLayers();
			}
			return this.tileMapLayers.ToArray();
		}
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000A113F File Offset: 0x0009F33F
	public TileInfo GetTileInfoForSprite(int tileId)
	{
		if (this.tileInfo == null || tileId < 0 || tileId >= this.tileInfo.Length)
		{
			return null;
		}
		return this.tileInfo[tileId];
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000A1164 File Offset: 0x0009F364
	public TileInfo[] GetOrCreateTileInfo(int numTiles)
	{
		bool flag = false;
		if (this.tileInfo == null)
		{
			this.tileInfo = new TileInfo[numTiles];
			flag = true;
		}
		else if (this.tileInfo.Length != numTiles)
		{
			Array.Resize<TileInfo>(ref this.tileInfo, numTiles);
			flag = true;
		}
		if (flag)
		{
			for (int i = 0; i < this.tileInfo.Length; i++)
			{
				if (this.tileInfo[i] == null)
				{
					this.tileInfo[i] = new TileInfo();
				}
			}
		}
		return this.tileInfo;
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000A11D8 File Offset: 0x0009F3D8
	public void GetTileOffset(out float x, out float y)
	{
		tk2dTileMapData.TileType tileType = this.tileType;
		if (tileType != tk2dTileMapData.TileType.Rectangular && tileType == tk2dTileMapData.TileType.Isometric)
		{
			x = 0.5f;
			y = 0f;
			return;
		}
		x = 0f;
		y = 0f;
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000A1210 File Offset: 0x0009F410
	private void InitLayers()
	{
		this.tileMapLayers = new List<LayerInfo>();
		LayerInfo layerInfo = new LayerInfo();
		layerInfo = new LayerInfo();
		layerInfo.name = "Layer 0";
		layerInfo.hash = 1892887448;
		layerInfo.z = 0f;
		this.tileMapLayers.Add(layerInfo);
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000A1261 File Offset: 0x0009F461
	public tk2dTileMapData()
	{
		this.tilePrefabs = new GameObject[0];
		this.tileInfo = new TileInfo[0];
		this.tileMapLayers = new List<LayerInfo>();
		base..ctor();
	}

	// Token: 0x040025BD RID: 9661
	public Vector3 tileSize;

	// Token: 0x040025BE RID: 9662
	public Vector3 tileOrigin;

	// Token: 0x040025BF RID: 9663
	public tk2dTileMapData.TileType tileType;

	// Token: 0x040025C0 RID: 9664
	public tk2dTileMapData.ColorMode colorMode;

	// Token: 0x040025C1 RID: 9665
	public tk2dTileMapData.SortMethod sortMethod;

	// Token: 0x040025C2 RID: 9666
	public bool generateUv2;

	// Token: 0x040025C3 RID: 9667
	public bool layersFixedZ;

	// Token: 0x040025C4 RID: 9668
	public bool useSortingLayers;

	// Token: 0x040025C5 RID: 9669
	public GameObject[] tilePrefabs;

	// Token: 0x040025C6 RID: 9670
	[SerializeField]
	private TileInfo[] tileInfo;

	// Token: 0x040025C7 RID: 9671
	[SerializeField]
	public List<LayerInfo> tileMapLayers;

	// Token: 0x0200059A RID: 1434
	public enum SortMethod
	{
		// Token: 0x040025C9 RID: 9673
		BottomLeft,
		// Token: 0x040025CA RID: 9674
		TopLeft,
		// Token: 0x040025CB RID: 9675
		BottomRight,
		// Token: 0x040025CC RID: 9676
		TopRight
	}

	// Token: 0x0200059B RID: 1435
	public enum TileType
	{
		// Token: 0x040025CE RID: 9678
		Rectangular,
		// Token: 0x040025CF RID: 9679
		Isometric
	}

	// Token: 0x0200059C RID: 1436
	public enum ColorMode
	{
		// Token: 0x040025D1 RID: 9681
		Interpolate,
		// Token: 0x040025D2 RID: 9682
		Solid
	}
}
