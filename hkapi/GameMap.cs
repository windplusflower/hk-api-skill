using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000459 RID: 1113
public class GameMap : MonoBehaviour
{
	// Token: 0x060018F3 RID: 6387 RVA: 0x00074CA2 File Offset: 0x00072EA2
	private void OnEnable()
	{
		this.gm = GameManager.instance;
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00003603 File Offset: 0x00001803
	private void OnDisable()
	{
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00074CB0 File Offset: 0x00072EB0
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = PlayerData.instance;
		this.hero = HeroController.instance.gameObject;
		this.inputHandler = this.gm.GetComponent<InputHandler>();
		if (this.gm.IsGameplayScene())
		{
			this.GetTilemapDimensions();
		}
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x00074D07 File Offset: 0x00072F07
	public void LevelReady()
	{
		this.inRoom = false;
		if (this.gm.IsGameplayScene())
		{
			this.GetTilemapDimensions();
		}
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x00074D07 File Offset: 0x00072F07
	private void OnLevelWasLoaded()
	{
		this.inRoom = false;
		if (this.gm.IsGameplayScene())
		{
			this.GetTilemapDimensions();
		}
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x00074D24 File Offset: 0x00072F24
	public void SetCompassPoint()
	{
		this.pd.SetFloatSwappedArgs(this.doorX, "gMap_doorX");
		this.pd.SetFloatSwappedArgs(this.doorY, "gMap_doorY");
		this.pd.SetStringSwappedArgs(this.doorScene, "gMap_doorScene");
		this.pd.SetStringSwappedArgs(this.doorMapZone, "gMap_doorMapZone");
		this.pd.SetFloatSwappedArgs(this.doorOriginOffsetX, "gMap_doorOriginOffsetX");
		this.pd.SetFloatSwappedArgs(this.doorOriginOffsetY, "gMap_doorOriginOffsetY");
		this.pd.SetFloatSwappedArgs(this.doorSceneWidth, "gMap_doorSceneWidth");
		this.pd.SetFloatSwappedArgs(this.doorSceneHeight, "gMap_doorSceneHeight");
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00074DE4 File Offset: 0x00072FE4
	public void GetDoorValues()
	{
		this.doorX = this.pd.GetFloat("gMap_doorX");
		this.doorY = this.pd.GetFloat("gMap_doorY");
		this.doorScene = this.pd.GetString("gMap_doorScene");
		this.doorMapZone = this.pd.GetString("gMap_doorMapZone");
		this.doorOriginOffsetX = this.pd.GetFloat("gMap_doorOriginOffsetX");
		this.doorOriginOffsetY = this.pd.GetFloat("gMap_doorOriginOffsetY");
		this.doorSceneWidth = this.pd.GetFloat("gMap_doorSceneWidth");
		this.doorSceneHeight = this.pd.GetFloat("gMap_doorSceneHeight");
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00074EA4 File Offset: 0x000730A4
	public void SetupMap(bool pinsOnly = false)
	{
		for (int i = 0; i < base.transform.childCount; i++)
		{
			GameObject gameObject = base.transform.GetChild(i).gameObject;
			for (int j = 0; j < gameObject.transform.childCount; j++)
			{
				GameObject gameObject2 = gameObject.transform.GetChild(j).gameObject;
				if (this.pd.GetVariable<List<string>>("scenesMapped").Contains(gameObject2.transform.name) || this.pd.GetBool("mapAllRooms"))
				{
					if (this.pd.GetBool("hasQuill") && !pinsOnly)
					{
						gameObject2.SetActive(true);
					}
					for (int k = 0; k < gameObject2.transform.childCount; k++)
					{
						GameObject gameObject3 = gameObject2.transform.GetChild(k).gameObject;
						if (gameObject3.name == "pin_blue_health" && !gameObject3.activeSelf && this.pd.GetVariable<List<string>>("scenesEncounteredCocoon").Contains(gameObject2.transform.name) && this.pd.GetBool("hasPinCocoon"))
						{
							gameObject3.SetActive(true);
						}
						if (gameObject3.name == "pin_dream_tree" && !gameObject3.activeSelf && this.pd.GetVariable<List<string>>("scenesEncounteredDreamPlant").Contains(gameObject2.transform.name) && this.pd.GetBool("hasPinDreamPlant"))
						{
							gameObject3.SetActive(true);
						}
						if (gameObject3.name == "pin_dream_tree" && gameObject3.activeSelf && this.pd.GetVariable<List<string>>("scenesEncounteredDreamPlantC").Contains(gameObject2.transform.name))
						{
							gameObject3.SetActive(false);
						}
					}
				}
			}
		}
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x0007508C File Offset: 0x0007328C
	private void GetTilemapDimensions()
	{
		this.originOffsetX = 0f;
		this.originOffsetY = 0f;
		tk2dTileMap tilemap = this.gm.tilemap;
		this.sceneWidth = (float)tilemap.width;
		this.sceneHeight = (float)tilemap.height;
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x000750D8 File Offset: 0x000732D8
	public void WorldMap()
	{
		string currentMapZone = this.gm.GetCurrentMapZone();
		this.displayNextArea = false;
		this.shadeMarker.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.SetupMapMarkers();
		this.panMinX = -1.44f;
		this.panMaxX = 4.55f;
		this.panMinY = -8.642f;
		this.panMaxY = -5.58f;
		if (this.pd.GetBool("mapAbyss") || (currentMapZone == "ABYSS" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapAbyss"))
			{
				this.areaAncientBasin.SetActive(true);
			}
			if (this.panMinX > -13.44f)
			{
				this.panMinX = -13.44f;
			}
			if (this.panMaxY < 15.6913f)
			{
				this.panMaxY = 15.6913f;
			}
		}
		if (this.pd.GetBool("mapCity") || ((currentMapZone == "CITY" || currentMapZone == "KINGS_STATION" || currentMapZone == "SOUL_SOCIETY" || currentMapZone == "LURIENS_TOWER") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapCity"))
			{
				this.areaCity.SetActive(true);
			}
			if (this.panMinX > -14.26f)
			{
				this.panMinX = -14.26f;
			}
			if (this.panMaxY < 2.27f)
			{
				this.panMaxY = 2.27f;
			}
		}
		if (this.pd.GetBool("mapCliffs") || (currentMapZone == "CLIFFS" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapCliffs"))
			{
				this.areaCliffs.SetActive(true);
			}
			if (this.panMaxX < 9.07f)
			{
				this.panMaxX = 9.07f;
			}
			if (this.panMinY > -10.6653f)
			{
				this.panMinY = -10.6653f;
			}
		}
		if (this.pd.GetBool("mapCrossroads"))
		{
			this.areaCrossroads.SetActive(true);
		}
		if (this.pd.GetBool("mapMines") || (currentMapZone == "MINES" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapMines"))
			{
				this.areaCrystalPeak.SetActive(true);
			}
			if (this.panMinX > -13.47f)
			{
				this.panMinX = -13.47f;
			}
			if (this.panMinY > -12.58548f)
			{
				this.panMinY = -12.58548f;
			}
		}
		if (this.pd.GetBool("mapDeepnest") || ((currentMapZone == "DEEPNEST" || currentMapZone == "BEASTS_DEN") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapDeepnest"))
			{
				this.areaDeepnest.SetActive(true);
			}
			if (this.panMaxX < 17.3f)
			{
				this.panMaxX = 17.3f;
			}
			if (this.panMaxY < 8.29f)
			{
				this.panMaxY = 8.29f;
			}
		}
		if (this.pd.GetBool("mapFogCanyon") || ((currentMapZone == "FOG_CANYON" || currentMapZone == "MONOMON_ARCHIVE") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapFogCanyon"))
			{
				this.areaFogCanyon.SetActive(true);
			}
			if (this.panMaxX < 7.13f)
			{
				this.panMaxX = 7.13f;
			}
			if (this.panMaxY < -2.49f)
			{
				this.panMaxY = -2.49f;
			}
		}
		if (this.pd.GetBool("mapFungalWastes") || ((currentMapZone == "WASTES" || currentMapZone == "QUEENS_STATION") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapFungalWastes"))
			{
				this.areaFungalWastes.SetActive(true);
			}
			if (this.panMaxY < 4.14f)
			{
				this.panMaxY = 4.14f;
			}
		}
		if (this.pd.GetBool("mapGreenpath") || (currentMapZone == "GREEN_PATH" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapGreenpath"))
			{
				this.areaGreenpath.SetActive(true);
			}
			if (this.panMaxX < 17.26f)
			{
				this.panMaxX = 17.26f;
			}
			if (this.panMaxY < -6.22f)
			{
				this.panMaxY = -6.22f;
			}
		}
		if (this.pd.GetBool("mapOutskirts") || ((currentMapZone == "OUTSKIRTS" || currentMapZone == "HIVE" || currentMapZone == "COLOSSEUM") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapOutskirts"))
			{
				this.areaKingdomsEdge.SetActive(true);
			}
			if (this.panMinX > -24.16f)
			{
				this.panMinX = -24.16f;
			}
			if (this.panMaxY < 8.16f)
			{
				this.panMaxY = 8.16f;
			}
		}
		if (this.pd.GetBool("mapRoyalGardens") || (currentMapZone == "ROYAL_GARDENS" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapRoyalGardens"))
			{
				this.areaQueensGardens.SetActive(true);
			}
			if (this.panMaxX < 17.3f)
			{
				this.panMaxX = 17.3f;
			}
			if (this.panMaxY < 1.53f)
			{
				this.panMaxY = 1.53f;
			}
		}
		if (this.pd.GetBool("mapRestingGrounds") || (currentMapZone == "RESTING_GROUNDS" && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapRestingGrounds"))
			{
				this.areaRestingGrounds.SetActive(true);
			}
			if (this.panMinX > -14.59f)
			{
				this.panMinX = -14.59f;
			}
			if (this.panMaxY < -5.77f)
			{
				this.panMaxY = -5.77f;
			}
		}
		this.areaDirtmouth.SetActive(true);
		if (this.pd.GetBool("mapWaterways") || ((currentMapZone == "WATERWAYS" || currentMapZone == "GODSEEKER_WASTE") && this.pd.GetBool("equippedCharm_2")))
		{
			if (this.pd.GetBool("mapWaterways"))
			{
				this.areaWaterways.SetActive(true);
			}
			if (this.panMinX > -11.39f)
			{
				this.panMinX = -11.39f;
			}
			if (this.panMaxY < 7.06f)
			{
				this.panMaxY = 7.06f;
			}
		}
		this.flamePins.SetActive(true);
		this.PositionCompass(false);
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x000757DC File Offset: 0x000739DC
	public void QuickMapAncientBasin()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(true);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x000758D8 File Offset: 0x00073AD8
	public void QuickMapCity()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(true);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x000759D4 File Offset: 0x00073BD4
	public void QuickMapCliffs()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(true);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00075AD0 File Offset: 0x00073CD0
	public void QuickMapCrossroads()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(true);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x00075BCC File Offset: 0x00073DCC
	public void QuickMapCrystalPeak()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(true);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x00075CC8 File Offset: 0x00073EC8
	public void QuickMapDeepnest()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(true);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x00075DC4 File Offset: 0x00073FC4
	public void QuickMapFogCanyon()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(true);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x00075EC0 File Offset: 0x000740C0
	public void QuickMapFungalWastes()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(true);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00075FBC File Offset: 0x000741BC
	public void QuickMapGreenpath()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(true);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x000760B8 File Offset: 0x000742B8
	public void QuickMapKingdomsEdge()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(true);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x000761B4 File Offset: 0x000743B4
	public void QuickMapQueensGardens()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(true);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x000762B0 File Offset: 0x000744B0
	public void QuickMapRestingGrounds()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(true);
		this.areaRestingGrounds.SetActive(true);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x000763AC File Offset: 0x000745AC
	public void QuickMapDirtmouth()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(true);
		this.areaWaterways.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x000764A8 File Offset: 0x000746A8
	public void QuickMapWaterways()
	{
		this.shadeMarker.SetActive(true);
		this.flamePins.SetActive(true);
		this.dreamGateMarker.SetActive(true);
		this.dreamerPins.SetActive(true);
		this.displayNextArea = true;
		this.SetupMapMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.areaWaterways.SetActive(true);
		this.areaDirtmouth.SetActive(false);
		this.PositionCompass(false);
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x000765B0 File Offset: 0x000747B0
	public void CloseQuickMap()
	{
		this.shadeMarker.SetActive(false);
		this.dreamGateMarker.SetActive(false);
		this.dreamerPins.SetActive(false);
		this.DisableMarkers();
		this.areaAncientBasin.SetActive(false);
		this.areaCity.SetActive(false);
		this.areaCliffs.SetActive(false);
		this.areaCrossroads.SetActive(false);
		this.areaCrystalPeak.SetActive(false);
		this.areaDeepnest.SetActive(false);
		this.areaFogCanyon.SetActive(false);
		this.areaFungalWastes.SetActive(false);
		this.areaGreenpath.SetActive(false);
		this.areaKingdomsEdge.SetActive(false);
		this.areaQueensGardens.SetActive(false);
		this.areaRestingGrounds.SetActive(false);
		this.areaDirtmouth.SetActive(false);
		this.flamePins.SetActive(false);
		this.areaWaterways.SetActive(false);
		this.compassIcon.SetActive(false);
		this.displayNextArea = false;
		this.displayingCompass = false;
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x000766B5 File Offset: 0x000748B5
	public void PositionDreamGateMarker()
	{
		this.posGate = true;
		this.PositionCompass(false);
		this.posGate = false;
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x000766CC File Offset: 0x000748CC
	public void PositionCompass(bool posShade)
	{
		GameObject gameObject = null;
		string currentMapZone = this.gm.GetCurrentMapZone();
		if (currentMapZone == "DREAM_WORLD" || currentMapZone == "WHITE_PALACE" || currentMapZone == "GODS_GLORY")
		{
			this.compassIcon.SetActive(false);
			this.displayingCompass = false;
			return;
		}
		string sceneName;
		if (!this.inRoom)
		{
			sceneName = this.gm.sceneName;
		}
		else
		{
			currentMapZone = this.doorMapZone;
			sceneName = this.doorScene;
		}
		if (currentMapZone == "ABYSS")
		{
			gameObject = this.areaAncientBasin;
			for (int i = 0; i < this.areaAncientBasin.transform.childCount; i++)
			{
				GameObject gameObject2 = this.areaAncientBasin.transform.GetChild(i).gameObject;
				if (gameObject2.name == sceneName)
				{
					this.currentScene = gameObject2;
					break;
				}
			}
		}
		else if (currentMapZone == "CITY" || currentMapZone == "KINGS_STATION" || currentMapZone == "SOUL_SOCIETY" || currentMapZone == "LURIENS_TOWER")
		{
			gameObject = this.areaCity;
			for (int j = 0; j < this.areaCity.transform.childCount; j++)
			{
				GameObject gameObject3 = this.areaCity.transform.GetChild(j).gameObject;
				if (gameObject3.name == sceneName)
				{
					this.currentScene = gameObject3;
					break;
				}
			}
		}
		else if (currentMapZone == "CLIFFS")
		{
			gameObject = this.areaCliffs;
			for (int k = 0; k < this.areaCliffs.transform.childCount; k++)
			{
				GameObject gameObject4 = this.areaCliffs.transform.GetChild(k).gameObject;
				if (gameObject4.name == sceneName)
				{
					this.currentScene = gameObject4;
					break;
				}
			}
		}
		else if (currentMapZone == "CROSSROADS" || currentMapZone == "SHAMAN_TEMPLE")
		{
			gameObject = this.areaCrossroads;
			for (int l = 0; l < this.areaCrossroads.transform.childCount; l++)
			{
				GameObject gameObject5 = this.areaCrossroads.transform.GetChild(l).gameObject;
				if (gameObject5.name == sceneName)
				{
					this.currentScene = gameObject5;
					break;
				}
			}
		}
		else if (currentMapZone == "MINES")
		{
			gameObject = this.areaCrystalPeak;
			for (int m = 0; m < this.areaCrystalPeak.transform.childCount; m++)
			{
				GameObject gameObject6 = this.areaCrystalPeak.transform.GetChild(m).gameObject;
				if (gameObject6.name == sceneName)
				{
					this.currentScene = gameObject6;
					break;
				}
			}
		}
		else if (currentMapZone == "DEEPNEST" || currentMapZone == "BEASTS_DEN")
		{
			gameObject = this.areaDeepnest;
			for (int n = 0; n < this.areaDeepnest.transform.childCount; n++)
			{
				GameObject gameObject7 = this.areaDeepnest.transform.GetChild(n).gameObject;
				if (gameObject7.name == sceneName)
				{
					this.currentScene = gameObject7;
					break;
				}
			}
		}
		else if (currentMapZone == "FOG_CANYON" || currentMapZone == "MONOMON_ARCHIVE")
		{
			gameObject = this.areaFogCanyon;
			for (int num = 0; num < this.areaFogCanyon.transform.childCount; num++)
			{
				GameObject gameObject8 = this.areaFogCanyon.transform.GetChild(num).gameObject;
				if (gameObject8.name == sceneName)
				{
					this.currentScene = gameObject8;
					break;
				}
			}
		}
		else if (currentMapZone == "WASTES" || currentMapZone == "QUEENS_STATION")
		{
			gameObject = this.areaFungalWastes;
			for (int num2 = 0; num2 < this.areaFungalWastes.transform.childCount; num2++)
			{
				GameObject gameObject9 = this.areaFungalWastes.transform.GetChild(num2).gameObject;
				if (gameObject9.name == sceneName)
				{
					this.currentScene = gameObject9;
					break;
				}
			}
		}
		else if (currentMapZone == "GREEN_PATH")
		{
			gameObject = this.areaGreenpath;
			for (int num3 = 0; num3 < this.areaGreenpath.transform.childCount; num3++)
			{
				GameObject gameObject10 = this.areaGreenpath.transform.GetChild(num3).gameObject;
				if (gameObject10.name == sceneName)
				{
					this.currentScene = gameObject10;
					break;
				}
			}
		}
		else if (currentMapZone == "OUTSKIRTS" || currentMapZone == "HIVE" || currentMapZone == "COLOSSEUM")
		{
			gameObject = this.areaKingdomsEdge;
			for (int num4 = 0; num4 < this.areaKingdomsEdge.transform.childCount; num4++)
			{
				GameObject gameObject11 = this.areaKingdomsEdge.transform.GetChild(num4).gameObject;
				if (gameObject11.name == sceneName)
				{
					this.currentScene = gameObject11;
					break;
				}
			}
		}
		else if (currentMapZone == "ROYAL_GARDENS")
		{
			gameObject = this.areaQueensGardens;
			for (int num5 = 0; num5 < this.areaQueensGardens.transform.childCount; num5++)
			{
				GameObject gameObject12 = this.areaQueensGardens.transform.GetChild(num5).gameObject;
				if (gameObject12.name == sceneName)
				{
					this.currentScene = gameObject12;
					break;
				}
			}
		}
		else if (currentMapZone == "RESTING_GROUNDS")
		{
			gameObject = this.areaRestingGrounds;
			for (int num6 = 0; num6 < this.areaRestingGrounds.transform.childCount; num6++)
			{
				GameObject gameObject13 = this.areaRestingGrounds.transform.GetChild(num6).gameObject;
				if (gameObject13.name == sceneName)
				{
					this.currentScene = gameObject13;
					break;
				}
			}
		}
		else if (currentMapZone == "TOWN" || currentMapZone == "KINGS_PASS")
		{
			gameObject = this.areaDirtmouth;
			for (int num7 = 0; num7 < this.areaDirtmouth.transform.childCount; num7++)
			{
				GameObject gameObject14 = this.areaDirtmouth.transform.GetChild(num7).gameObject;
				if (gameObject14.name == sceneName)
				{
					this.currentScene = gameObject14;
					break;
				}
			}
		}
		else if (currentMapZone == "WATERWAYS" || currentMapZone == "GODSEEKER_WASTE")
		{
			gameObject = this.areaWaterways;
			for (int num8 = 0; num8 < this.areaWaterways.transform.childCount; num8++)
			{
				GameObject gameObject15 = this.areaWaterways.transform.GetChild(num8).gameObject;
				if (gameObject15.name == sceneName)
				{
					this.currentScene = gameObject15;
					break;
				}
			}
		}
		if (this.currentScene != null)
		{
			this.currentScenePos = new Vector3(this.currentScene.transform.localPosition.x + gameObject.transform.localPosition.x, this.currentScene.transform.localPosition.y + gameObject.transform.localPosition.y, 0f);
			if (!posShade && !this.posGate)
			{
				if (this.pd.GetBool("equippedCharm_2"))
				{
					this.displayingCompass = true;
					this.compassIcon.SetActive(true);
				}
				else
				{
					this.compassIcon.SetActive(false);
					this.displayingCompass = false;
				}
			}
			if (posShade)
			{
				if (!this.inRoom)
				{
					this.shadeMarker.transform.localPosition = new Vector3(this.currentScenePos.x, this.currentScenePos.y, 0f);
				}
				else
				{
					float x = this.currentScenePos.x - this.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.x / 100f / 2f + (this.doorX + this.doorOriginOffsetX) / this.doorSceneWidth * (this.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.x / 100f * base.transform.localScale.x) / base.transform.localScale.x;
					float y = this.currentScenePos.y - this.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.y / 100f / 2f + (this.doorY + this.doorOriginOffsetY) / this.doorSceneHeight * (this.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.y / 100f * base.transform.localScale.y) / base.transform.localScale.y;
					this.shadeMarker.transform.localPosition = new Vector3(x, y, 0f);
				}
				this.pd.SetVector3SwappedArgs(new Vector3(this.currentScenePos.x, this.currentScenePos.y, 0f), "shadeMapPos");
			}
			if (this.posGate)
			{
				this.dreamGateMarker.transform.localPosition = new Vector3(this.currentScenePos.x, this.currentScenePos.y, 0f);
				this.pd.SetVector3SwappedArgs(new Vector3(this.currentScenePos.x, this.currentScenePos.y, 0f), "dreamgateMapPos");
				return;
			}
		}
		else
		{
			Debug.Log("Couldn't find current scene object!");
			if (posShade)
			{
				this.pd.SetVector3SwappedArgs(new Vector3(-10000f, -10000f, 0f), "shadeMapPos");
				this.shadeMarker.transform.localPosition = this.pd.GetVector3("shadeMapPos");
			}
		}
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x000770FC File Offset: 0x000752FC
	private void Update()
	{
		if (this.displayingCompass)
		{
			Vector2 vector = this.currentScene.GetComponent<SpriteRenderer>().sprite.bounds.size;
			if (!this.inRoom)
			{
				float x = this.currentScenePos.x - vector.x / 2f + (this.hero.transform.position.x + this.originOffsetX) / this.sceneWidth * (vector.x * base.transform.localScale.x) / base.transform.localScale.x;
				float y = this.currentScenePos.y - vector.y / 2f + (this.hero.transform.position.y + this.originOffsetY) / this.sceneHeight * (vector.y * base.transform.localScale.y) / base.transform.localScale.y;
				this.compassIcon.transform.localPosition = new Vector3(x, y, -1f);
			}
			else
			{
				float x = this.currentScenePos.x - vector.x / 2f + (this.doorX + this.doorOriginOffsetX) / this.doorSceneWidth * (vector.x * base.transform.localScale.x) / base.transform.localScale.x;
				float y = this.currentScenePos.y - vector.y / 2f + (this.doorY + this.doorOriginOffsetY) / this.doorSceneHeight * (vector.y * base.transform.localScale.y) / base.transform.localScale.y;
				this.compassIcon.transform.localPosition = new Vector3(x, y, -1f);
				this.displayingCompass = false;
			}
			if (!this.compassIcon.activeSelf)
			{
				this.compassIcon.SetActive(true);
			}
		}
		if (this.canPan)
		{
			if (this.inputHandler.inputActions.rs_down.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + this.panSpeed * 2f * Time.deltaTime, base.transform.position.z);
			}
			else if (this.inputHandler.inputActions.down.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + this.panSpeed * Time.deltaTime, base.transform.position.z);
			}
			if (this.inputHandler.inputActions.rs_up.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - this.panSpeed * 2f * Time.deltaTime, base.transform.position.z);
			}
			else if (this.inputHandler.inputActions.up.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - this.panSpeed * Time.deltaTime, base.transform.position.z);
			}
			if (this.inputHandler.inputActions.rs_left.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x + this.panSpeed * 2f * Time.deltaTime, base.transform.position.y, base.transform.position.z);
			}
			else if (this.inputHandler.inputActions.left.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x + this.panSpeed * Time.deltaTime, base.transform.position.y, base.transform.position.z);
			}
			if (this.inputHandler.inputActions.rs_right.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x - this.panSpeed * 2f * Time.deltaTime, base.transform.position.y, base.transform.position.z);
			}
			else if (this.inputHandler.inputActions.right.IsPressed)
			{
				base.transform.position = new Vector3(base.transform.position.x - this.panSpeed * Time.deltaTime, base.transform.position.y, base.transform.position.z);
			}
			this.KeepWithinBounds();
			if (base.transform.position.x == this.panMinX && this.panArrowR.activeSelf)
			{
				this.panArrowR.SetActive(false);
			}
			else if (base.transform.position.x > this.panMinX && !this.panArrowR.activeSelf)
			{
				this.panArrowR.SetActive(true);
			}
			if (base.transform.position.x == this.panMaxX && this.panArrowL.activeSelf)
			{
				this.panArrowL.SetActive(false);
			}
			else if (base.transform.position.x < this.panMaxX && !this.panArrowL.activeSelf)
			{
				this.panArrowL.SetActive(true);
			}
			if (base.transform.position.y == this.panMinY && this.panArrowU.activeSelf)
			{
				this.panArrowU.SetActive(false);
			}
			else if (base.transform.position.y > this.panMinY && !this.panArrowU.activeSelf)
			{
				this.panArrowU.SetActive(true);
			}
			if (base.transform.position.y == this.panMaxY && this.panArrowD.activeSelf)
			{
				this.panArrowD.SetActive(false);
				return;
			}
			if (base.transform.position.y < this.panMaxY && !this.panArrowD.activeSelf)
			{
				this.panArrowD.SetActive(true);
			}
		}
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x000777FC File Offset: 0x000759FC
	private void DisableMarkers()
	{
		for (int i = 0; i < this.mapMarkersBlue.Length; i++)
		{
			this.mapMarkersBlue[i].SetActive(false);
		}
		for (int j = 0; j < this.mapMarkersRed.Length; j++)
		{
			this.mapMarkersRed[j].SetActive(false);
		}
		for (int k = 0; k < this.mapMarkersYellow.Length; k++)
		{
			this.mapMarkersYellow[k].SetActive(false);
		}
		for (int l = 0; l < this.mapMarkersWhite.Length; l++)
		{
			this.mapMarkersWhite[l].SetActive(false);
		}
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x0007788D File Offset: 0x00075A8D
	public void SetManualTilemap(float offsetX, float offsetY, float width, float height)
	{
		this.originOffsetX = offsetX;
		this.originOffsetY = offsetY;
		this.sceneWidth = width;
		this.sceneHeight = height;
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x000778AC File Offset: 0x00075AAC
	public void SetDoorValues(float x, float y, string scene, string mapZone)
	{
		this.doorX = x;
		this.doorY = y;
		this.doorScene = scene;
		this.doorMapZone = mapZone;
		this.doorOriginOffsetX = this.originOffsetX;
		this.doorOriginOffsetY = this.originOffsetY;
		this.doorSceneWidth = this.sceneWidth;
		this.doorSceneHeight = this.sceneHeight;
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x00077908 File Offset: 0x00075B08
	public void SetCustomCompassPos(float x, float y, string scene, string mapZone, float offsetX, float offsetY, float width, float height)
	{
		this.inRoom = true;
		this.doorX = x;
		this.doorY = y;
		this.doorScene = scene;
		this.doorMapZone = mapZone;
		this.doorOriginOffsetX = offsetX;
		this.doorOriginOffsetY = offsetY;
		this.doorSceneWidth = width;
		this.doorSceneHeight = height;
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00077959 File Offset: 0x00075B59
	public void SetInRoom(bool room)
	{
		this.inRoom = room;
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00077962 File Offset: 0x00075B62
	public void SetCanPan(bool pan)
	{
		this.canPan = pan;
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x0007796B File Offset: 0x00075B6B
	public string GetDoorMapZone()
	{
		return this.doorMapZone;
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00077973 File Offset: 0x00075B73
	public bool GetInRoom()
	{
		return this.inRoom;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x0007797B File Offset: 0x00075B7B
	public void SetPanArrows(GameObject arrowU, GameObject arrowD, GameObject arrowL, GameObject arrowR)
	{
		this.panArrowU = arrowU;
		this.panArrowD = arrowD;
		this.panArrowL = arrowL;
		this.panArrowR = arrowR;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x0007799C File Offset: 0x00075B9C
	public void KeepWithinBounds()
	{
		if (base.transform.position.x < this.panMinX)
		{
			base.transform.position = new Vector3(this.panMinX, base.transform.position.y, base.transform.position.z);
		}
		if (base.transform.position.x > this.panMaxX)
		{
			base.transform.position = new Vector3(this.panMaxX, base.transform.position.y, base.transform.position.z);
		}
		if (base.transform.position.y < this.panMinY)
		{
			base.transform.position = new Vector3(base.transform.position.x, this.panMinY, base.transform.position.z);
		}
		if (base.transform.position.y > this.panMaxY)
		{
			base.transform.position = new Vector3(base.transform.position.x, this.panMaxY, base.transform.position.z);
		}
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00077AE1 File Offset: 0x00075CE1
	public void StopPan()
	{
		this.canPan = false;
		this.panArrowU.SetActive(false);
		this.panArrowL.SetActive(false);
		this.panArrowR.SetActive(false);
		this.panArrowD.SetActive(false);
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00077B1A File Offset: 0x00075D1A
	public void StartPan()
	{
		this.canPan = true;
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00077B24 File Offset: 0x00075D24
	public void SetupMapMarkers()
	{
		this.DisableMarkers();
		for (int i = 0; i < this.pd.GetVariable<List<Vector3>>("placedMarkers_b").Count; i++)
		{
			this.mapMarkersBlue[i].SetActive(true);
			this.mapMarkersBlue[i].transform.localPosition = this.pd.GetVariable<List<Vector3>>("placedMarkers_b")[i];
		}
		for (int j = 0; j < this.pd.GetVariable<List<Vector3>>("placedMarkers_r").Count; j++)
		{
			this.mapMarkersRed[j].SetActive(true);
			this.mapMarkersRed[j].transform.localPosition = this.pd.GetVariable<List<Vector3>>("placedMarkers_r")[j];
		}
		for (int k = 0; k < this.pd.GetVariable<List<Vector3>>("placedMarkers_y").Count; k++)
		{
			this.mapMarkersYellow[k].SetActive(true);
			this.mapMarkersYellow[k].transform.localPosition = this.pd.GetVariable<List<Vector3>>("placedMarkers_y")[k];
		}
		for (int l = 0; l < this.pd.GetVariable<List<Vector3>>("placedMarkers_w").Count; l++)
		{
			this.mapMarkersWhite[l].SetActive(true);
			this.mapMarkersWhite[l].transform.localPosition = this.pd.GetVariable<List<Vector3>>("placedMarkers_w")[l];
		}
	}

	// Token: 0x04001DE6 RID: 7654
	private GameManager gm;

	// Token: 0x04001DE7 RID: 7655
	private PlayerData pd;

	// Token: 0x04001DE8 RID: 7656
	private GameObject hero;

	// Token: 0x04001DE9 RID: 7657
	private InputHandler inputHandler;

	// Token: 0x04001DEA RID: 7658
	public GameObject compassIcon;

	// Token: 0x04001DEB RID: 7659
	private float originOffsetX;

	// Token: 0x04001DEC RID: 7660
	private float originOffsetY;

	// Token: 0x04001DED RID: 7661
	private float sceneWidth;

	// Token: 0x04001DEE RID: 7662
	private float sceneHeight;

	// Token: 0x04001DEF RID: 7663
	public float doorX;

	// Token: 0x04001DF0 RID: 7664
	public float doorY;

	// Token: 0x04001DF1 RID: 7665
	public string doorScene;

	// Token: 0x04001DF2 RID: 7666
	public string doorMapZone;

	// Token: 0x04001DF3 RID: 7667
	public float doorOriginOffsetX;

	// Token: 0x04001DF4 RID: 7668
	public float doorOriginOffsetY;

	// Token: 0x04001DF5 RID: 7669
	public float doorSceneWidth;

	// Token: 0x04001DF6 RID: 7670
	public float doorSceneHeight;

	// Token: 0x04001DF7 RID: 7671
	public bool inRoom;

	// Token: 0x04001DF8 RID: 7672
	public GameObject areaAncientBasin;

	// Token: 0x04001DF9 RID: 7673
	public GameObject areaCity;

	// Token: 0x04001DFA RID: 7674
	public GameObject areaCliffs;

	// Token: 0x04001DFB RID: 7675
	public GameObject areaCrossroads;

	// Token: 0x04001DFC RID: 7676
	public GameObject areaCrystalPeak;

	// Token: 0x04001DFD RID: 7677
	public GameObject areaDeepnest;

	// Token: 0x04001DFE RID: 7678
	public GameObject areaFogCanyon;

	// Token: 0x04001DFF RID: 7679
	public GameObject areaFungalWastes;

	// Token: 0x04001E00 RID: 7680
	public GameObject areaGreenpath;

	// Token: 0x04001E01 RID: 7681
	public GameObject areaKingdomsEdge;

	// Token: 0x04001E02 RID: 7682
	public GameObject areaQueensGardens;

	// Token: 0x04001E03 RID: 7683
	public GameObject areaRestingGrounds;

	// Token: 0x04001E04 RID: 7684
	public GameObject areaDirtmouth;

	// Token: 0x04001E05 RID: 7685
	public GameObject areaWaterways;

	// Token: 0x04001E06 RID: 7686
	public GameObject flamePins;

	// Token: 0x04001E07 RID: 7687
	public GameObject dreamerPins;

	// Token: 0x04001E08 RID: 7688
	public GameObject shadeMarker;

	// Token: 0x04001E09 RID: 7689
	public GameObject dreamGateMarker;

	// Token: 0x04001E0A RID: 7690
	private bool posGate;

	// Token: 0x04001E0B RID: 7691
	public bool displayNextArea;

	// Token: 0x04001E0C RID: 7692
	private bool displayingCompass;

	// Token: 0x04001E0D RID: 7693
	public Vector3 currentScenePos;

	// Token: 0x04001E0E RID: 7694
	public GameObject currentScene;

	// Token: 0x04001E0F RID: 7695
	public bool canPan;

	// Token: 0x04001E10 RID: 7696
	public float panSpeed;

	// Token: 0x04001E11 RID: 7697
	public float panMinX;

	// Token: 0x04001E12 RID: 7698
	public float panMaxX;

	// Token: 0x04001E13 RID: 7699
	public float panMinY;

	// Token: 0x04001E14 RID: 7700
	public float panMaxY;

	// Token: 0x04001E15 RID: 7701
	public GameObject panArrowU;

	// Token: 0x04001E16 RID: 7702
	public GameObject panArrowD;

	// Token: 0x04001E17 RID: 7703
	public GameObject panArrowL;

	// Token: 0x04001E18 RID: 7704
	public GameObject panArrowR;

	// Token: 0x04001E19 RID: 7705
	public GameObject[] mapMarkersBlue;

	// Token: 0x04001E1A RID: 7706
	public GameObject[] mapMarkersRed;

	// Token: 0x04001E1B RID: 7707
	public GameObject[] mapMarkersYellow;

	// Token: 0x04001E1C RID: 7708
	public GameObject[] mapMarkersWhite;
}
