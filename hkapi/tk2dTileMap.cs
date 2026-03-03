using System;
using System.Collections.Generic;
using tk2dRuntime;
using tk2dRuntime.TileMap;
using UnityEngine;

// Token: 0x02000596 RID: 1430
[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/TileMap/TileMap")]
public class tk2dTileMap : MonoBehaviour, ISpriteCollectionForceBuild
{
	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x000A040A File Offset: 0x0009E60A
	// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x000A0412 File Offset: 0x0009E612
	public tk2dSpriteCollectionData Editor__SpriteCollection
	{
		get
		{
			return this.spriteCollection;
		}
		set
		{
			this.spriteCollection = value;
		}
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x000A041B File Offset: 0x0009E61B
	public tk2dSpriteCollectionData SpriteCollectionInst
	{
		get
		{
			if (this.spriteCollection != null)
			{
				return this.spriteCollection.inst;
			}
			return null;
		}
	}

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000A0438 File Offset: 0x0009E638
	public bool AllowEdit
	{
		get
		{
			return this._inEditMode;
		}
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000A0440 File Offset: 0x0009E640
	private void Awake()
	{
		bool flag = true;
		if (this.SpriteCollectionInst && (this.SpriteCollectionInst.buildKey != this.spriteCollectionKey || this.SpriteCollectionInst.needMaterialInstance))
		{
			flag = false;
		}
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
		{
			if ((Application.isPlaying && this._inEditMode) || !flag)
			{
				this.EndEditMode();
				return;
			}
			if (this.spriteCollection != null && this.data != null && this.renderData == null)
			{
				this.Build(tk2dTileMap.BuildFlags.ForceBuild);
				return;
			}
		}
		else
		{
			if (this._inEditMode)
			{
				Debug.LogError("Tilemap " + base.name + " is still in edit mode. Please fix.Building overhead will be significant.");
				this.EndEditMode();
				return;
			}
			if (!flag)
			{
				this.Build(tk2dTileMap.BuildFlags.ForceBuild);
				return;
			}
			if (this.spriteCollection != null && this.data != null && this.renderData == null)
			{
				this.Build(tk2dTileMap.BuildFlags.ForceBuild);
			}
		}
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000A0544 File Offset: 0x0009E744
	private void OnDestroy()
	{
		if (this.layers != null)
		{
			Layer[] array = this.layers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DestroyGameData(this);
			}
		}
		if (this.renderData != null)
		{
			tk2dUtil.DestroyImmediate(this.renderData);
		}
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000A0590 File Offset: 0x0009E790
	public void Build()
	{
		this.Build(tk2dTileMap.BuildFlags.Default);
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000A0599 File Offset: 0x0009E799
	public void ForceBuild()
	{
		this.Build(tk2dTileMap.BuildFlags.ForceBuild);
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000A05A4 File Offset: 0x0009E7A4
	private void ClearSpawnedInstances()
	{
		if (this.layers == null)
		{
			return;
		}
		BuilderUtil.HideTileMapPrefabs(this);
		for (int i = 0; i < this.layers.Length; i++)
		{
			Layer layer = this.layers[i];
			for (int j = 0; j < layer.spriteChannel.chunks.Length; j++)
			{
				SpriteChunk spriteChunk = layer.spriteChannel.chunks[j];
				if (!(spriteChunk.gameObject == null))
				{
					Transform transform = spriteChunk.gameObject.transform;
					List<Transform> list = new List<Transform>();
					for (int k = 0; k < transform.childCount; k++)
					{
						list.Add(transform.GetChild(k));
					}
					for (int l = 0; l < list.Count; l++)
					{
						tk2dUtil.DestroyImmediate(list[l].gameObject);
					}
				}
			}
		}
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000A067F File Offset: 0x0009E87F
	private void SetPrefabsRootActive(bool active)
	{
		if (this.prefabsRoot != null)
		{
			tk2dUtil.SetActive(this.prefabsRoot, active);
		}
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000A069C File Offset: 0x0009E89C
	public void Build(tk2dTileMap.BuildFlags buildFlags)
	{
		if (this.data != null && this.spriteCollection != null)
		{
			if (this.data.tilePrefabs == null)
			{
				this.data.tilePrefabs = new GameObject[this.SpriteCollectionInst.Count];
			}
			else if (this.data.tilePrefabs.Length != this.SpriteCollectionInst.Count)
			{
				Array.Resize<GameObject>(ref this.data.tilePrefabs, this.SpriteCollectionInst.Count);
			}
			BuilderUtil.InitDataStore(this);
			if (this.SpriteCollectionInst)
			{
				this.SpriteCollectionInst.InitMaterialIds();
			}
			bool flag = (buildFlags & tk2dTileMap.BuildFlags.ForceBuild) > tk2dTileMap.BuildFlags.Default;
			if (this.SpriteCollectionInst && this.SpriteCollectionInst.buildKey != this.spriteCollectionKey)
			{
				flag = true;
			}
			Dictionary<Layer, bool> dictionary = new Dictionary<Layer, bool>();
			if (this.layers != null)
			{
				for (int i = 0; i < this.layers.Length; i++)
				{
					Layer layer = this.layers[i];
					if (layer != null && layer.gameObject != null)
					{
						dictionary[layer] = layer.gameObject.activeSelf;
					}
				}
			}
			if (flag)
			{
				this.ClearSpawnedInstances();
			}
			BuilderUtil.CreateRenderData(this, this._inEditMode, dictionary);
			RenderMeshBuilder.Build(this, this._inEditMode, flag);
			if (!this._inEditMode)
			{
				tk2dSpriteDefinition firstValidDefinition = this.SpriteCollectionInst.FirstValidDefinition;
				if (firstValidDefinition != null && firstValidDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D)
				{
					ColliderBuilder2D.Build(this, flag);
				}
				else
				{
					ColliderBuilder3D.Build(this, flag);
				}
				BuilderUtil.SpawnPrefabs(this, flag);
			}
			Layer[] array = this.layers;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].ClearDirtyFlag();
			}
			if (this.colorChannel != null)
			{
				this.colorChannel.ClearDirtyFlag();
			}
			if (this.SpriteCollectionInst)
			{
				this.spriteCollectionKey = this.SpriteCollectionInst.buildKey;
			}
			return;
		}
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000A0874 File Offset: 0x0009EA74
	public bool GetTileAtPosition(Vector3 position, out int x, out int y)
	{
		float num;
		float num2;
		bool tileFracAtPosition = this.GetTileFracAtPosition(position, out num, out num2);
		x = (int)num;
		y = (int)num2;
		return tileFracAtPosition;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000A0894 File Offset: 0x0009EA94
	public bool GetTileFracAtPosition(Vector3 position, out float x, out float y)
	{
		tk2dTileMapData.TileType tileType = this.data.tileType;
		if (tileType != tk2dTileMapData.TileType.Rectangular)
		{
			if (tileType == tk2dTileMapData.TileType.Isometric)
			{
				if (this.data.tileSize.x != 0f)
				{
					float num = Mathf.Atan2(this.data.tileSize.y, this.data.tileSize.x / 2f);
					Vector3 vector = base.transform.worldToLocalMatrix.MultiplyPoint(position);
					x = (vector.x - this.data.tileOrigin.x) / this.data.tileSize.x;
					y = (vector.y - this.data.tileOrigin.y) / this.data.tileSize.y;
					float num2 = y * 0.5f;
					int num3 = (int)num2;
					float num4 = num2 - (float)num3;
					float num5 = x % 1f;
					x = (float)((int)x);
					y = (float)(num3 * 2);
					if (num5 > 0.5f)
					{
						if (num4 > 0.5f && Mathf.Atan2(1f - num4, (num5 - 0.5f) * 2f) < num)
						{
							y += 1f;
						}
						else if (num4 < 0.5f && Mathf.Atan2(num4, (num5 - 0.5f) * 2f) < num)
						{
							y -= 1f;
						}
					}
					else if (num5 < 0.5f)
					{
						if (num4 > 0.5f && Mathf.Atan2(num4 - 0.5f, num5 * 2f) > num)
						{
							y += 1f;
							x -= 1f;
						}
						if (num4 < 0.5f && Mathf.Atan2(num4, (0.5f - num5) * 2f) < num)
						{
							y -= 1f;
							x -= 1f;
						}
					}
					return x >= 0f && x < (float)this.width && y >= 0f && y < (float)this.height;
				}
			}
			x = 0f;
			y = 0f;
			return false;
		}
		Vector3 vector2 = base.transform.worldToLocalMatrix.MultiplyPoint(position);
		x = (vector2.x - this.data.tileOrigin.x) / this.data.tileSize.x;
		y = (vector2.y - this.data.tileOrigin.y) / this.data.tileSize.y;
		return x >= 0f && x < (float)this.width && y >= 0f && y < (float)this.height;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000A0B50 File Offset: 0x0009ED50
	public Vector3 GetTilePosition(int x, int y)
	{
		tk2dTileMapData.TileType tileType = this.data.tileType;
		if (tileType == tk2dTileMapData.TileType.Rectangular || tileType != tk2dTileMapData.TileType.Isometric)
		{
			Vector3 point = new Vector3((float)x * this.data.tileSize.x + this.data.tileOrigin.x, (float)y * this.data.tileSize.y + this.data.tileOrigin.y, 0f);
			return base.transform.localToWorldMatrix.MultiplyPoint(point);
		}
		Vector3 point2 = new Vector3(((float)x + (((y & 1) == 0) ? 0f : 0.5f)) * this.data.tileSize.x + this.data.tileOrigin.x, (float)y * this.data.tileSize.y + this.data.tileOrigin.y, 0f);
		return base.transform.localToWorldMatrix.MultiplyPoint(point2);
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000A0C54 File Offset: 0x0009EE54
	public int GetTileIdAtPosition(Vector3 position, int layer)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return -1;
		}
		int x;
		int y;
		if (!this.GetTileAtPosition(position, out x, out y))
		{
			return -1;
		}
		return this.layers[layer].GetTile(x, y);
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000A0C90 File Offset: 0x0009EE90
	public TileInfo GetTileInfoForTileId(int tileId)
	{
		return this.data.GetTileInfoForSprite(tileId);
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000A0CA0 File Offset: 0x0009EEA0
	public Color GetInterpolatedColorAtPosition(Vector3 position)
	{
		Vector3 vector = base.transform.worldToLocalMatrix.MultiplyPoint(position);
		int num = (int)((vector.x - this.data.tileOrigin.x) / this.data.tileSize.x);
		int num2 = (int)((vector.y - this.data.tileOrigin.y) / this.data.tileSize.y);
		if (this.colorChannel == null || this.colorChannel.IsEmpty)
		{
			return Color.white;
		}
		if (num < 0 || num >= this.width || num2 < 0 || num2 >= this.height)
		{
			return this.colorChannel.clearColor;
		}
		int num3;
		ColorChunk colorChunk = this.colorChannel.FindChunkAndCoordinate(num, num2, out num3);
		if (colorChunk.Empty)
		{
			return this.colorChannel.clearColor;
		}
		int num4 = this.partitionSizeX + 1;
		Color a = colorChunk.colors[num3];
		Color b = colorChunk.colors[num3 + 1];
		Color a2 = colorChunk.colors[num3 + num4];
		Color b2 = colorChunk.colors[num3 + num4 + 1];
		float num5 = (float)num * this.data.tileSize.x + this.data.tileOrigin.x;
		float num6 = (float)num2 * this.data.tileSize.y + this.data.tileOrigin.y;
		float t = (vector.x - num5) / this.data.tileSize.x;
		float t2 = (vector.y - num6) / this.data.tileSize.y;
		Color a3 = Color.Lerp(a, b, t);
		Color b3 = Color.Lerp(a2, b2, t);
		return Color.Lerp(a3, b3, t2);
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000A0E87 File Offset: 0x0009F087
	public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
	{
		return this.spriteCollection != null && (spriteCollection == this.spriteCollection || spriteCollection == this.spriteCollection.inst);
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x000A0EBA File Offset: 0x0009F0BA
	public void EndEditMode()
	{
		this._inEditMode = false;
		this.SetPrefabsRootActive(true);
		this.Build(tk2dTileMap.BuildFlags.ForceBuild);
		if (this.prefabsRoot != null)
		{
			tk2dUtil.DestroyImmediate(this.prefabsRoot);
			this.prefabsRoot = null;
		}
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x00003603 File Offset: 0x00001803
	public void TouchMesh(Mesh mesh)
	{
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000A0EF1 File Offset: 0x0009F0F1
	public void DestroyMesh(Mesh mesh)
	{
		tk2dUtil.DestroyImmediate(mesh);
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000A0EF9 File Offset: 0x0009F0F9
	public int GetTilePrefabsListCount()
	{
		return this.tilePrefabsList.Count;
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000A0F06 File Offset: 0x0009F106
	public List<tk2dTileMap.TilemapPrefabInstance> TilePrefabsList
	{
		get
		{
			return this.tilePrefabsList;
		}
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000A0F10 File Offset: 0x0009F110
	public void GetTilePrefabsListItem(int index, out int x, out int y, out int layer, out GameObject instance)
	{
		tk2dTileMap.TilemapPrefabInstance tilemapPrefabInstance = this.tilePrefabsList[index];
		x = tilemapPrefabInstance.x;
		y = tilemapPrefabInstance.y;
		layer = tilemapPrefabInstance.layer;
		instance = tilemapPrefabInstance.instance;
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000A0F4C File Offset: 0x0009F14C
	public void SetTilePrefabsList(List<int> xs, List<int> ys, List<int> layers, List<GameObject> instances)
	{
		int count = instances.Count;
		this.tilePrefabsList = new List<tk2dTileMap.TilemapPrefabInstance>(count);
		for (int i = 0; i < count; i++)
		{
			tk2dTileMap.TilemapPrefabInstance tilemapPrefabInstance = new tk2dTileMap.TilemapPrefabInstance();
			tilemapPrefabInstance.x = xs[i];
			tilemapPrefabInstance.y = ys[i];
			tilemapPrefabInstance.layer = layers[i];
			tilemapPrefabInstance.instance = instances[i];
			this.tilePrefabsList.Add(tilemapPrefabInstance);
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000A0FC0 File Offset: 0x0009F1C0
	// (set) Token: 0x06001FDE RID: 8158 RVA: 0x000A0FC8 File Offset: 0x0009F1C8
	public Layer[] Layers
	{
		get
		{
			return this.layers;
		}
		set
		{
			this.layers = value;
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000A0FD1 File Offset: 0x0009F1D1
	// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x000A0FD9 File Offset: 0x0009F1D9
	public ColorChannel ColorChannel
	{
		get
		{
			return this.colorChannel;
		}
		set
		{
			this.colorChannel = value;
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x000A0FE2 File Offset: 0x0009F1E2
	// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x000A0FEA File Offset: 0x0009F1EA
	public GameObject PrefabsRoot
	{
		get
		{
			return this.prefabsRoot;
		}
		set
		{
			this.prefabsRoot = value;
		}
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000A0FF3 File Offset: 0x0009F1F3
	public int GetTile(int x, int y, int layer)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return -1;
		}
		return this.layers[layer].GetTile(x, y);
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000A1015 File Offset: 0x0009F215
	public tk2dTileFlags GetTileFlags(int x, int y, int layer)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return tk2dTileFlags.None;
		}
		return this.layers[layer].GetTileFlags(x, y);
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000A1037 File Offset: 0x0009F237
	public void SetTile(int x, int y, int layer, int tile)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return;
		}
		this.layers[layer].SetTile(x, y, tile);
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000A105A File Offset: 0x0009F25A
	public void SetTileFlags(int x, int y, int layer, tk2dTileFlags flags)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return;
		}
		this.layers[layer].SetTileFlags(x, y, flags);
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000A107D File Offset: 0x0009F27D
	public void ClearTile(int x, int y, int layer)
	{
		if (layer < 0 || layer >= this.layers.Length)
		{
			return;
		}
		this.layers[layer].ClearTile(x, y);
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000A10A0 File Offset: 0x0009F2A0
	public tk2dTileMap()
	{
		this.editorDataGUID = "";
		this.width = 128;
		this.height = 128;
		this.partitionSizeX = 32;
		this.partitionSizeY = 32;
		this.tilePrefabsList = new List<tk2dTileMap.TilemapPrefabInstance>();
		base..ctor();
	}

	// Token: 0x040025A6 RID: 9638
	public string editorDataGUID;

	// Token: 0x040025A7 RID: 9639
	public tk2dTileMapData data;

	// Token: 0x040025A8 RID: 9640
	public GameObject renderData;

	// Token: 0x040025A9 RID: 9641
	[SerializeField]
	private tk2dSpriteCollectionData spriteCollection;

	// Token: 0x040025AA RID: 9642
	[SerializeField]
	private int spriteCollectionKey;

	// Token: 0x040025AB RID: 9643
	public int width;

	// Token: 0x040025AC RID: 9644
	public int height;

	// Token: 0x040025AD RID: 9645
	public int partitionSizeX;

	// Token: 0x040025AE RID: 9646
	public int partitionSizeY;

	// Token: 0x040025AF RID: 9647
	[SerializeField]
	private Layer[] layers;

	// Token: 0x040025B0 RID: 9648
	[SerializeField]
	private ColorChannel colorChannel;

	// Token: 0x040025B1 RID: 9649
	[SerializeField]
	private GameObject prefabsRoot;

	// Token: 0x040025B2 RID: 9650
	[SerializeField]
	private List<tk2dTileMap.TilemapPrefabInstance> tilePrefabsList;

	// Token: 0x040025B3 RID: 9651
	[SerializeField]
	private bool _inEditMode;

	// Token: 0x040025B4 RID: 9652
	public string serializedMeshPath;

	// Token: 0x02000597 RID: 1431
	[Serializable]
	public class TilemapPrefabInstance
	{
		// Token: 0x040025B5 RID: 9653
		public int x;

		// Token: 0x040025B6 RID: 9654
		public int y;

		// Token: 0x040025B7 RID: 9655
		public int layer;

		// Token: 0x040025B8 RID: 9656
		public GameObject instance;
	}

	// Token: 0x02000598 RID: 1432
	[Flags]
	public enum BuildFlags
	{
		// Token: 0x040025BA RID: 9658
		Default = 0,
		// Token: 0x040025BB RID: 9659
		EditMode = 1,
		// Token: 0x040025BC RID: 9660
		ForceBuild = 2
	}
}
