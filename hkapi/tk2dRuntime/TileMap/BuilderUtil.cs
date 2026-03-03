using System;
using System.Collections.Generic;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x0200064A RID: 1610
	public static class BuilderUtil
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x000DB6A4 File Offset: 0x000D98A4
		public static bool InitDataStore(tk2dTileMap tileMap)
		{
			bool result = false;
			int numLayers = tileMap.data.NumLayers;
			if (tileMap.Layers == null)
			{
				tileMap.Layers = new Layer[numLayers];
				for (int i = 0; i < numLayers; i++)
				{
					tileMap.Layers[i] = new Layer(tileMap.data.Layers[i].hash, tileMap.width, tileMap.height, tileMap.partitionSizeX, tileMap.partitionSizeY);
				}
				result = true;
			}
			else
			{
				Layer[] array = new Layer[numLayers];
				for (int j = 0; j < numLayers; j++)
				{
					LayerInfo layerInfo = tileMap.data.Layers[j];
					bool flag = false;
					for (int k = 0; k < tileMap.Layers.Length; k++)
					{
						if (tileMap.Layers[k].hash == layerInfo.hash)
						{
							array[j] = tileMap.Layers[k];
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						array[j] = new Layer(layerInfo.hash, tileMap.width, tileMap.height, tileMap.partitionSizeX, tileMap.partitionSizeY);
					}
				}
				int num = 0;
				Layer[] array2 = array;
				for (int l = 0; l < array2.Length; l++)
				{
					if (!array2[l].IsEmpty)
					{
						num++;
					}
				}
				int num2 = 0;
				array2 = tileMap.Layers;
				for (int l = 0; l < array2.Length; l++)
				{
					if (!array2[l].IsEmpty)
					{
						num2++;
					}
				}
				if (num != num2)
				{
					result = true;
				}
				tileMap.Layers = array;
			}
			if (tileMap.ColorChannel == null)
			{
				tileMap.ColorChannel = new ColorChannel(tileMap.width, tileMap.height, tileMap.partitionSizeX, tileMap.partitionSizeY);
			}
			return result;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000DB850 File Offset: 0x000D9A50
		private static GameObject GetExistingTilePrefabInstance(tk2dTileMap tileMap, int tileX, int tileY, int tileLayer)
		{
			int tilePrefabsListCount = tileMap.GetTilePrefabsListCount();
			for (int i = 0; i < tilePrefabsListCount; i++)
			{
				int num;
				int num2;
				int num3;
				GameObject result;
				tileMap.GetTilePrefabsListItem(i, out num, out num2, out num3, out result);
				if (num == tileX && num2 == tileY && num3 == tileLayer)
				{
					return result;
				}
			}
			return null;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000DB890 File Offset: 0x000D9A90
		public static void SpawnPrefabsForChunk(tk2dTileMap tileMap, SpriteChunk chunk, int baseX, int baseY, int layer, int[] prefabCounts)
		{
			int[] spriteIds = chunk.spriteIds;
			GameObject[] tilePrefabs = tileMap.data.tilePrefabs;
			Vector3 tileSize = tileMap.data.tileSize;
			Transform transform = chunk.gameObject.transform;
			float num = 0f;
			float num2 = 0f;
			tileMap.data.GetTileOffset(out num, out num2);
			for (int i = 0; i < tileMap.partitionSizeY; i++)
			{
				float num3 = (float)(baseY + i & 1) * num;
				for (int j = 0; j < tileMap.partitionSizeX; j++)
				{
					int tileFromRawTile = BuilderUtil.GetTileFromRawTile(spriteIds[i * tileMap.partitionSizeX + j]);
					if (tileFromRawTile >= 0 && tileFromRawTile < tilePrefabs.Length)
					{
						UnityEngine.Object @object = tilePrefabs[tileFromRawTile];
						if (@object != null)
						{
							prefabCounts[tileFromRawTile]++;
							GameObject gameObject = BuilderUtil.GetExistingTilePrefabInstance(tileMap, baseX + j, baseY + i, layer);
							bool flag = gameObject != null;
							if (gameObject == null)
							{
								gameObject = (UnityEngine.Object.Instantiate(@object, Vector3.zero, Quaternion.identity) as GameObject);
							}
							if (gameObject != null)
							{
								GameObject gameObject2 = @object as GameObject;
								Vector3 vector = new Vector3(tileSize.x * ((float)j + num3), tileSize.y * (float)i, 0f);
								bool flag2 = false;
								TileInfo tileInfoForSprite = tileMap.data.GetTileInfoForSprite(tileFromRawTile);
								if (tileInfoForSprite != null)
								{
									flag2 = tileInfoForSprite.enablePrefabOffset;
								}
								if (flag2 && gameObject2 != null)
								{
									vector += gameObject2.transform.position;
								}
								if (!flag)
								{
									gameObject.name = @object.name + " " + prefabCounts[tileFromRawTile].ToString();
								}
								tk2dUtil.SetTransformParent(gameObject.transform, transform);
								gameObject.transform.localPosition = vector;
								BuilderUtil.TilePrefabsX.Add(baseX + j);
								BuilderUtil.TilePrefabsY.Add(baseY + i);
								BuilderUtil.TilePrefabsLayer.Add(layer);
								BuilderUtil.TilePrefabsInstance.Add(gameObject);
							}
						}
					}
				}
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000DBAA4 File Offset: 0x000D9CA4
		public static void SpawnPrefabs(tk2dTileMap tileMap, bool forceBuild)
		{
			BuilderUtil.TilePrefabsX = new List<int>();
			BuilderUtil.TilePrefabsY = new List<int>();
			BuilderUtil.TilePrefabsLayer = new List<int>();
			BuilderUtil.TilePrefabsInstance = new List<GameObject>();
			int[] prefabCounts = new int[tileMap.data.tilePrefabs.Length];
			int num = tileMap.Layers.Length;
			for (int i = 0; i < num; i++)
			{
				Layer layer = tileMap.Layers[i];
				LayerInfo layerInfo = tileMap.data.Layers[i];
				if (!layer.IsEmpty && !layerInfo.skipMeshGeneration)
				{
					for (int j = 0; j < layer.numRows; j++)
					{
						int baseY = j * layer.divY;
						for (int k = 0; k < layer.numColumns; k++)
						{
							int baseX = k * layer.divX;
							SpriteChunk chunk = layer.GetChunk(k, j);
							if (!chunk.IsEmpty && (forceBuild || chunk.Dirty))
							{
								BuilderUtil.SpawnPrefabsForChunk(tileMap, chunk, baseX, baseY, i, prefabCounts);
							}
						}
					}
				}
			}
			tileMap.SetTilePrefabsList(BuilderUtil.TilePrefabsX, BuilderUtil.TilePrefabsY, BuilderUtil.TilePrefabsLayer, BuilderUtil.TilePrefabsInstance);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000DBBC0 File Offset: 0x000D9DC0
		public static void HideTileMapPrefabs(tk2dTileMap tileMap)
		{
			if (tileMap.renderData == null || tileMap.Layers == null)
			{
				return;
			}
			if (tileMap.PrefabsRoot == null)
			{
				GameObject gameObject = tileMap.PrefabsRoot = tk2dUtil.CreateGameObject("Prefabs");
				gameObject.transform.parent = tileMap.renderData.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.transform.localScale = Vector3.one;
			}
			int tilePrefabsListCount = tileMap.GetTilePrefabsListCount();
			bool[] array = new bool[tilePrefabsListCount];
			for (int i = 0; i < tileMap.Layers.Length; i++)
			{
				Layer layer = tileMap.Layers[i];
				for (int j = 0; j < layer.spriteChannel.chunks.Length; j++)
				{
					SpriteChunk spriteChunk = layer.spriteChannel.chunks[j];
					if (!(spriteChunk.gameObject == null))
					{
						Transform transform = spriteChunk.gameObject.transform;
						int childCount = transform.childCount;
						for (int k = 0; k < childCount; k++)
						{
							GameObject gameObject2 = transform.GetChild(k).gameObject;
							for (int l = 0; l < tilePrefabsListCount; l++)
							{
								int num;
								int num2;
								int num3;
								GameObject x;
								tileMap.GetTilePrefabsListItem(l, out num, out num2, out num3, out x);
								if (x == gameObject2)
								{
									array[l] = true;
									break;
								}
							}
						}
					}
				}
			}
			UnityEngine.Object[] tilePrefabs = tileMap.data.tilePrefabs;
			UnityEngine.Object[] array2 = tilePrefabs;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			List<GameObject> list4 = new List<GameObject>();
			for (int m = 0; m < tilePrefabsListCount; m++)
			{
				int num4;
				int num5;
				int num6;
				GameObject gameObject3;
				tileMap.GetTilePrefabsListItem(m, out num4, out num5, out num6, out gameObject3);
				if (!array[m])
				{
					int num7 = (num4 >= 0 && num4 < tileMap.width && num5 >= 0 && num5 < tileMap.height) ? tileMap.GetTile(num4, num5, num6) : -1;
					if (num7 >= 0 && num7 < array2.Length && array2[num7] != null)
					{
						array[m] = true;
					}
				}
				if (array[m])
				{
					list.Add(num4);
					list2.Add(num5);
					list3.Add(num6);
					list4.Add(gameObject3);
					tk2dUtil.SetTransformParent(gameObject3.transform, tileMap.PrefabsRoot.transform);
				}
			}
			tileMap.SetTilePrefabsList(list, list2, list3, list4);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000DBE1F File Offset: 0x000DA01F
		private static Vector3 GetTilePosition(tk2dTileMap tileMap, int x, int y)
		{
			return new Vector3(tileMap.data.tileSize.x * (float)x, tileMap.data.tileSize.y * (float)y, 0f);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000DBE54 File Offset: 0x000DA054
		public static void CreateRenderData(tk2dTileMap tileMap, bool editMode, Dictionary<Layer, bool> layersActive)
		{
			if (tileMap.renderData == null)
			{
				tileMap.renderData = tk2dUtil.CreateGameObject(tileMap.name + " Render Data");
			}
			tileMap.renderData.transform.position = tileMap.transform.position;
			float num = 0f;
			int num2 = 0;
			foreach (Layer layer in tileMap.Layers)
			{
				float z = tileMap.data.Layers[num2].z;
				if (num2 != 0)
				{
					num -= z;
				}
				if (layer.IsEmpty && layer.gameObject != null)
				{
					tk2dUtil.DestroyImmediate(layer.gameObject);
					layer.gameObject = null;
				}
				else if (!layer.IsEmpty && layer.gameObject == null)
				{
					(layer.gameObject = tk2dUtil.CreateGameObject("")).transform.parent = tileMap.renderData.transform;
				}
				int unityLayer = tileMap.data.Layers[num2].unityLayer;
				if (layer.gameObject != null)
				{
					if (!editMode && layersActive.ContainsKey(layer) && layer.gameObject.activeSelf != layersActive[layer])
					{
						layer.gameObject.SetActive(layersActive[layer]);
					}
					layer.gameObject.name = tileMap.data.Layers[num2].name;
					layer.gameObject.transform.localPosition = new Vector3(0f, 0f, tileMap.data.layersFixedZ ? (-z) : num);
					layer.gameObject.transform.localRotation = Quaternion.identity;
					layer.gameObject.transform.localScale = Vector3.one;
					layer.gameObject.layer = unityLayer;
				}
				int num3;
				int num4;
				int num5;
				int num6;
				int num7;
				int num8;
				BuilderUtil.GetLoopOrder(tileMap.data.sortMethod, layer.numColumns, layer.numRows, out num3, out num4, out num5, out num6, out num7, out num8);
				float num9 = 0f;
				for (int num10 = num6; num10 != num7; num10 += num8)
				{
					for (int num11 = num3; num11 != num4; num11 += num5)
					{
						SpriteChunk chunk = layer.GetChunk(num11, num10);
						bool flag = layer.IsEmpty || chunk.IsEmpty;
						if (editMode)
						{
							flag = false;
						}
						if (flag && chunk.HasGameData)
						{
							chunk.DestroyGameData(tileMap);
						}
						else if (!flag && chunk.gameObject == null)
						{
							string name = "Chunk " + num10.ToString() + " " + num11.ToString();
							GameObject gameObject = chunk.gameObject = tk2dUtil.CreateGameObject(name);
							gameObject.transform.parent = layer.gameObject.transform;
							MeshFilter meshFilter = tk2dUtil.AddComponent<MeshFilter>(gameObject);
							tk2dUtil.AddComponent<MeshRenderer>(gameObject);
							chunk.mesh = tk2dUtil.CreateMesh();
							meshFilter.mesh = chunk.mesh;
						}
						if (chunk.gameObject != null)
						{
							Vector3 tilePosition = BuilderUtil.GetTilePosition(tileMap, num11 * tileMap.partitionSizeX, num10 * tileMap.partitionSizeY);
							tilePosition.z += num9;
							chunk.gameObject.transform.localPosition = tilePosition;
							chunk.gameObject.transform.localRotation = Quaternion.identity;
							chunk.gameObject.transform.localScale = Vector3.one;
							chunk.gameObject.layer = unityLayer;
							if (editMode)
							{
								chunk.DestroyColliderData(tileMap);
							}
						}
						num9 -= 1E-06f;
					}
				}
				num2++;
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000DC210 File Offset: 0x000DA410
		public static void GetLoopOrder(tk2dTileMapData.SortMethod sortMethod, int w, int h, out int x0, out int x1, out int dx, out int y0, out int y1, out int dy)
		{
			switch (sortMethod)
			{
			case tk2dTileMapData.SortMethod.BottomLeft:
				break;
			case tk2dTileMapData.SortMethod.TopLeft:
				x0 = 0;
				x1 = w;
				dx = 1;
				y0 = h - 1;
				y1 = -1;
				dy = -1;
				return;
			case tk2dTileMapData.SortMethod.BottomRight:
				x0 = w - 1;
				x1 = -1;
				dx = -1;
				y0 = 0;
				y1 = h;
				dy = 1;
				return;
			case tk2dTileMapData.SortMethod.TopRight:
				x0 = w - 1;
				x1 = -1;
				dx = -1;
				y0 = h - 1;
				y1 = -1;
				dy = -1;
				return;
			default:
				Debug.LogError("Unhandled sort method");
				break;
			}
			x0 = 0;
			x1 = w;
			dx = 1;
			y0 = 0;
			y1 = h;
			dy = 1;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000DC2A8 File Offset: 0x000DA4A8
		public static int GetTileFromRawTile(int rawTile)
		{
			if (rawTile == -1)
			{
				return -1;
			}
			return rawTile & 16777215;
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000DC2B7 File Offset: 0x000DA4B7
		public static bool IsRawTileFlagSet(int rawTile, tk2dTileFlags flag)
		{
			return rawTile != -1 && (rawTile & (int)flag) != 0;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000DC2C5 File Offset: 0x000DA4C5
		public static void SetRawTileFlag(ref int rawTile, tk2dTileFlags flag, bool setValue)
		{
			if (rawTile == -1)
			{
				return;
			}
			rawTile = (setValue ? (rawTile | (int)flag) : (rawTile & (int)(~(int)flag)));
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000DC2E0 File Offset: 0x000DA4E0
		public static void InvertRawTileFlag(ref int rawTile, tk2dTileFlags flag)
		{
			if (rawTile == -1)
			{
				return;
			}
			rawTile = (((rawTile & (int)flag) == 0) ? (rawTile | (int)flag) : (rawTile & (int)(~(int)flag)));
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000DC30C File Offset: 0x000DA50C
		public static Vector3 ApplySpriteVertexTileFlags(tk2dTileMap tileMap, tk2dSpriteDefinition spriteDef, Vector3 pos, bool flipH, bool flipV, bool rot90)
		{
			float num = tileMap.data.tileOrigin.x + 0.5f * tileMap.data.tileSize.x;
			float num2 = tileMap.data.tileOrigin.y + 0.5f * tileMap.data.tileSize.y;
			float num3 = pos.x - num;
			float num4 = pos.y - num2;
			if (rot90)
			{
				float num5 = num3;
				num3 = num4;
				num4 = -num5;
			}
			if (flipH)
			{
				num3 *= -1f;
			}
			if (flipV)
			{
				num4 *= -1f;
			}
			pos.x = num + num3;
			pos.y = num2 + num4;
			return pos;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000DC3B0 File Offset: 0x000DA5B0
		public static Vector2 ApplySpriteVertexTileFlags(tk2dTileMap tileMap, tk2dSpriteDefinition spriteDef, Vector2 pos, bool flipH, bool flipV, bool rot90)
		{
			float num = tileMap.data.tileOrigin.x + 0.5f * tileMap.data.tileSize.x;
			float num2 = tileMap.data.tileOrigin.y + 0.5f * tileMap.data.tileSize.y;
			float num3 = pos.x - num;
			float num4 = pos.y - num2;
			if (rot90)
			{
				float num5 = num3;
				num3 = num4;
				num4 = -num5;
			}
			if (flipH)
			{
				num3 *= -1f;
			}
			if (flipV)
			{
				num4 *= -1f;
			}
			pos.x = num + num3;
			pos.y = num2 + num4;
			return pos;
		}

		// Token: 0x04002B41 RID: 11073
		private static List<int> TilePrefabsX;

		// Token: 0x04002B42 RID: 11074
		private static List<int> TilePrefabsY;

		// Token: 0x04002B43 RID: 11075
		private static List<int> TilePrefabsLayer;

		// Token: 0x04002B44 RID: 11076
		private static List<GameObject> TilePrefabsInstance;

		// Token: 0x04002B45 RID: 11077
		private const int tileMask = 16777215;
	}
}
