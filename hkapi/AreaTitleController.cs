using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000431 RID: 1073
public class AreaTitleController : MonoBehaviour
{
	// Token: 0x0600182A RID: 6186 RVA: 0x00071900 File Offset: 0x0006FB00
	private void Start()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "Area Title Controller");
		if (playMakerFSM)
		{
			this.areaEvent = FSMUtility.GetString(playMakerFSM, "Area Event");
			this.displayRight = FSMUtility.GetBool(playMakerFSM, "Display Right");
			this.doorTrigger = FSMUtility.GetString(playMakerFSM, "Door Trigger");
			this.onlyOnRevisit = FSMUtility.GetBool(playMakerFSM, "Only On Revisit");
			this.unvisitedPause = FSMUtility.GetFloat(playMakerFSM, "Unvisited Pause");
			this.visitedPause = FSMUtility.GetFloat(playMakerFSM, "Visited Pause");
			this.waitForTrigger = FSMUtility.GetBool(playMakerFSM, "Wait for Trigger");
		}
		else
		{
			Debug.LogError("No FSM attached to " + base.gameObject.name + " to get data from!");
		}
		if (this.waitForHeroInPosition)
		{
			this.hc = HeroController.instance;
			if (this.hc != null)
			{
				this.heroInPositionResponder = delegate(bool <p0>)
				{
					this.FindAreaTitle();
					this.DoPlay();
					this.hc.heroInPosition -= this.heroInPositionResponder;
					this.heroInPositionResponder = null;
				};
				this.hc.heroInPosition += this.heroInPositionResponder;
				return;
			}
		}
		else
		{
			this.FindAreaTitle();
			this.DoPlay();
		}
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00071A0F File Offset: 0x0006FC0F
	private void FindAreaTitle()
	{
		if (AreaTitle.instance)
		{
			this.areaTitle = AreaTitle.instance.gameObject;
		}
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00071A2D File Offset: 0x0006FC2D
	private void DoPlay()
	{
		if (!this.waitForTrigger)
		{
			this.Play();
		}
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00071A3D File Offset: 0x0006FC3D
	protected void OnDestroy()
	{
		if (this.hc != null && this.heroInPositionResponder != null)
		{
			this.hc.heroInPosition -= this.heroInPositionResponder;
			this.hc = null;
			this.heroInPositionResponder = null;
		}
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00071A74 File Offset: 0x0006FC74
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.played)
		{
			return;
		}
		if (collision.tag == "Player")
		{
			this.Play();
		}
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x00071A98 File Offset: 0x0006FC98
	private void Play()
	{
		if (this.played)
		{
			return;
		}
		this.played = true;
		if (this.doorTrigger == "")
		{
			this.CheckArea();
			return;
		}
		if (HeroController.instance.GetEntryGateName() == this.doorTrigger)
		{
			this.CheckArea();
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x00071AF8 File Offset: 0x0006FCF8
	private void CheckArea()
	{
		this.area = this.areaList.FirstOrDefault((AreaTitleController.Area o) => o.identifier == this.areaEvent);
		if (this.area != null)
		{
			if (this.area.evaluateDelegate != null)
			{
				this.area.evaluateDelegate(this.area, this);
			}
		}
		else
		{
			Debug.LogWarning("No area with identifier \"" + this.areaEvent + "\" found in area list. Creating default SubArea.");
			this.area = new AreaTitleController.Area(this.areaEvent, 0, true, "");
		}
		if (this.doFinish)
		{
			this.Finish();
		}
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00071B90 File Offset: 0x0006FD90
	private void Finish()
	{
		if (this.area.subArea)
		{
			base.StartCoroutine(this.VisitPause(true));
			return;
		}
		int @int = GameManager.instance.playerData.GetInt("currentArea");
		bool @bool = GameManager.instance.playerData.GetBool(this.area.visitedBool);
		bool flag = true;
		if ((!@bool && this.onlyOnRevisit) || this.area.areaID == @int)
		{
			flag = false;
			base.gameObject.SetActive(false);
		}
		else
		{
			GameManager.instance.playerData.SetInt("currentArea", this.area.areaID);
		}
		if (flag)
		{
			base.StartCoroutine(@bool ? this.VisitPause(true) : this.UnvisitPause(true));
		}
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x00071C50 File Offset: 0x0006FE50
	private IEnumerator VisitPause(bool pause = true)
	{
		if (pause)
		{
			yield return new WaitForSeconds(this.visitedPause);
		}
		GameManager.instance.StoryRecord_travelledToArea(this.area.identifier);
		if (this.areaTitle)
		{
			this.areaTitle.SetActive(true);
			PlayMakerFSM fsm = FSMUtility.GetFSM(this.areaTitle);
			if (fsm)
			{
				FSMUtility.SetBool(fsm, "Visited", true);
				FSMUtility.SetBool(fsm, "NPC Title", false);
				FSMUtility.SetBool(fsm, "Display Right", this.displayRight);
				FSMUtility.SetString(fsm, "Area Event", this.areaEvent);
			}
		}
		yield break;
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x00071C66 File Offset: 0x0006FE66
	private IEnumerator UnvisitPause(bool pause = true)
	{
		if (pause)
		{
			yield return new WaitForSeconds(this.unvisitedPause);
		}
		GameManager.instance.StoryRecord_discoveredArea(this.area.identifier);
		if (this.areaTitle)
		{
			this.areaTitle.SetActive(true);
			PlayMakerFSM fsm = FSMUtility.GetFSM(this.areaTitle);
			if (fsm)
			{
				FSMUtility.SetBool(fsm, "Visited", false);
				FSMUtility.SetBool(fsm, "NPC Title", false);
				FSMUtility.SetString(fsm, "Area Event", this.areaEvent);
				GameManager.instance.playerData.SetBool(this.area.visitedBool, true);
			}
		}
		yield break;
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00071C7C File Offset: 0x0006FE7C
	public AreaTitleController()
	{
		List<AreaTitleController.Area> list = new List<AreaTitleController.Area>();
		list.Add(new AreaTitleController.Area("ABYSS", 13, false, "visitedAbyss"));
		list.Add(new AreaTitleController.Area("CROSSROADS", 2, false, "visitedCrossroads", delegate(AreaTitleController.Area self, AreaTitleController sender)
		{
			if (GameManager.instance.playerData.GetBool("crossroadsInfected"))
			{
				self.identifier = "CROSSROADS_INF";
				sender.areaEvent = "CROSSROADS_INF";
			}
		}));
		list.Add(new AreaTitleController.Area("DEEPNEST", 9, false, "visitedDeepnest"));
		list.Add(new AreaTitleController.Area("DIRTMOUTH", 1, false, "visitedDirtmouth"));
		list.Add(new AreaTitleController.Area("EGGTEMPLE", 0, true, ""));
		list.Add(new AreaTitleController.Area("FOG_CANYON", 4, false, "visitedFogCanyon"));
		list.Add(new AreaTitleController.Area("FUNGUS", 5, false, "visitedFungus"));
		list.Add(new AreaTitleController.Area("GREENPATH", 3, false, "visitedGreenpath"));
		list.Add(new AreaTitleController.Area("HIVE", 11, false, "visitedHive", delegate(AreaTitleController.Area self, AreaTitleController sender)
		{
			sender.doFinish = false;
			if (GameManager.instance.playerData.GetBool("visitedHive"))
			{
				sender.StartCoroutine(sender.VisitPause(false));
				return;
			}
			sender.StartCoroutine(sender.UnvisitPause(false));
		}));
		list.Add(new AreaTitleController.Area("KINGSPASS", 0, true, "", delegate(AreaTitleController.Area self, AreaTitleController sender)
		{
			if (!GameManager.instance.playerData.GetBool("visitedCrossroads"))
			{
				sender.doFinish = false;
				sender.gameObject.SetActive(false);
			}
		}));
		list.Add(new AreaTitleController.Area("MINES", 8, false, "visitedMines"));
		list.Add(new AreaTitleController.Area("RESTING_GROUNDS", 12, false, "visitedRestingGrounds"));
		list.Add(new AreaTitleController.Area("ROYAL_GARDENS", 10, false, "visitedRoyalGardens"));
		list.Add(new AreaTitleController.Area("RUINS", 6, false, "visitedRuins"));
		list.Add(new AreaTitleController.Area("SHAMANTEMPLE", 0, true, ""));
		list.Add(new AreaTitleController.Area("WATERWAYS", 7, false, "visitedWaterways"));
		list.Add(new AreaTitleController.Area("MANTIS_VILLAGE", 0, true, ""));
		list.Add(new AreaTitleController.Area("FUNGUS_CORE", 0, true, ""));
		list.Add(new AreaTitleController.Area("MAGE_TOWER", 0, true, ""));
		list.Add(new AreaTitleController.Area("FUNGUS_SHAMAN", 0, true, ""));
		list.Add(new AreaTitleController.Area("QUEENS_STATION", 0, true, ""));
		list.Add(new AreaTitleController.Area("KINGS_STATION", 0, true, ""));
		list.Add(new AreaTitleController.Area("BLUE_LAKE", 0, true, ""));
		list.Add(new AreaTitleController.Area("ACID_LAKE", 0, true, ""));
		list.Add(new AreaTitleController.Area("OUTSKIRTS", 14, false, "visitedOutskirts"));
		list.Add(new AreaTitleController.Area("LOVE_TOWER", 0, true, ""));
		list.Add(new AreaTitleController.Area("SPIDER_VILLAGE", 0, true, ""));
		list.Add(new AreaTitleController.Area("HEGEMOL_NEST", 0, true, ""));
		list.Add(new AreaTitleController.Area("WHITE_PALACE", 15, false, "visitedWhitePalace"));
		list.Add(new AreaTitleController.Area("COLOSSEUM", 0, true, "seenColosseumTitle", delegate(AreaTitleController.Area self, AreaTitleController sender)
		{
			sender.doFinish = false;
			if (GameManager.instance.playerData.GetBool("seenColosseumTitle"))
			{
				sender.StartCoroutine(sender.VisitPause(true));
				return;
			}
			sender.StartCoroutine(sender.UnvisitPause(true));
		}));
		list.Add(new AreaTitleController.Area("ABYSS_DEEP", 16, false, "visitedAbyssLower"));
		list.Add(new AreaTitleController.Area("CLIFFS", 17, false, "visitedCliffs"));
		list.Add(new AreaTitleController.Area("GODHOME", 18, false, "visitedGodhome"));
		list.Add(new AreaTitleController.Area("GODSEEKER_WASTE", 0, true, ""));
		this.areaList = list;
		this.waitForHeroInPosition = true;
		this.areaEvent = "";
		this.doorTrigger = "";
		this.unvisitedPause = 2f;
		this.visitedPause = 2f;
		this.doFinish = true;
		base..ctor();
	}

	// Token: 0x04001CF9 RID: 7417
	private List<AreaTitleController.Area> areaList;

	// Token: 0x04001CFA RID: 7418
	public bool waitForHeroInPosition;

	// Token: 0x04001CFB RID: 7419
	[Header("Values copied from FSM")]
	public string areaEvent;

	// Token: 0x04001CFC RID: 7420
	public bool displayRight;

	// Token: 0x04001CFD RID: 7421
	public string doorTrigger;

	// Token: 0x04001CFE RID: 7422
	public bool onlyOnRevisit;

	// Token: 0x04001CFF RID: 7423
	public float unvisitedPause;

	// Token: 0x04001D00 RID: 7424
	public float visitedPause;

	// Token: 0x04001D01 RID: 7425
	public bool waitForTrigger;

	// Token: 0x04001D02 RID: 7426
	[Space]
	public GameObject areaTitle;

	// Token: 0x04001D03 RID: 7427
	private AreaTitleController.Area area;

	// Token: 0x04001D04 RID: 7428
	private bool played;

	// Token: 0x04001D05 RID: 7429
	private bool doFinish;

	// Token: 0x04001D06 RID: 7430
	private HeroController hc;

	// Token: 0x04001D07 RID: 7431
	private HeroController.HeroInPosition heroInPositionResponder;

	// Token: 0x02000432 RID: 1074
	private class Area
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x000720A1 File Offset: 0x000702A1
		public Area(string identifier, int areaID, bool subArea, string visitedBool)
		{
			this.identifier = "AREA";
			this.visitedBool = "";
			base..ctor();
			this.identifier = identifier;
			this.areaID = areaID;
			this.subArea = subArea;
			this.visitedBool = visitedBool;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000720DC File Offset: 0x000702DC
		public Area(string identifier, int areaID, bool subArea, string visitedBool, Action<AreaTitleController.Area, AreaTitleController> evaluateDelegate)
		{
			this.identifier = "AREA";
			this.visitedBool = "";
			base..ctor();
			this.identifier = identifier;
			this.areaID = areaID;
			this.subArea = subArea;
			this.visitedBool = visitedBool;
			this.evaluateDelegate = evaluateDelegate;
		}

		// Token: 0x04001D08 RID: 7432
		public string identifier;

		// Token: 0x04001D09 RID: 7433
		public int areaID;

		// Token: 0x04001D0A RID: 7434
		public bool subArea;

		// Token: 0x04001D0B RID: 7435
		public string visitedBool;

		// Token: 0x04001D0C RID: 7436
		public Action<AreaTitleController.Area, AreaTitleController> evaluateDelegate;
	}
}
