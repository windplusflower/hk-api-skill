using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200043B RID: 1083
public class BuildEquippedCharms : MonoBehaviour
{
	// Token: 0x06001867 RID: 6247 RVA: 0x00003603 File Offset: 0x00001803
	private void Start()
	{
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00072858 File Offset: 0x00070A58
	private void BuildCharmList()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.pd == null)
		{
			this.pd = PlayerData.instance;
		}
		this.uiItems = 0;
		this.equippedCharms = this.pd.GetVariable<List<int>>("equippedCharms");
		this.charmSlots = this.pd.GetInt("charmSlots");
		this.charmSlotsFilled = this.pd.GetInt("charmSlotsFilled");
		this.equippedAmount = 0;
		int count = this.pd.GetVariable<List<int>>("equippedCharms").Count;
		float num;
		if (count < 9)
		{
			num = this.CHARM_DISTANCE_X;
		}
		else if (count == 9)
		{
			num = 1.7f;
		}
		else if (count == 10)
		{
			num = 1.5f;
		}
		else
		{
			num = 1.4f;
		}
		this.instanceList = new List<GameObject>();
		this.gm.StoryRecord_charmsChanged();
		float num2 = this.START_X;
		for (int i = 0; i < this.equippedCharms.Count; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gameObjectList[this.equippedCharms[i] - 1]);
			gameObject.transform.position = new Vector3(num2, this.START_Y, -10f);
			gameObject.transform.SetParent(this.charmsFolder.transform, false);
			gameObject.transform.localScale = new Vector3(this.CHARM_SCALE, this.CHARM_SCALE, this.CHARM_SCALE);
			this.gm.StoryRecord_charmEquipped(gameObject.name);
			gameObject.name = this.equippedCharms[i].ToString();
			gameObject.GetComponent<CharmItem>().listNumber = i + 1;
			this.instanceList.Add(gameObject);
			num2 += num;
		}
		this.uiItems = this.instanceList.Count;
		if (this.pd.GetInt("charmSlotsFilled") < this.pd.GetInt("charmSlots"))
		{
			this.uiItems++;
			this.instanceList.Add(this.nextDot);
		}
		this.nextDot.transform.localPosition = new Vector3(num2, this.START_Y, -6f);
		this.nextDot.GetComponent<CharmItem>().listNumber = this.instanceList.Count + 1;
		this.UpdateNotches();
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00003603 File Offset: 0x00001803
	public void UpdateNotches()
	{
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00072AB9 File Offset: 0x00070CB9
	public GameObject GetObjectAt(int listNumber)
	{
		return this.instanceList[listNumber - 1];
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00072AC9 File Offset: 0x00070CC9
	public int GetUICount()
	{
		return this.uiItems;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00072AD1 File Offset: 0x00070CD1
	public string GetItemName(int itemNum)
	{
		return this.instanceList[itemNum - 1].name;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00072AE6 File Offset: 0x00070CE6
	public BuildEquippedCharms()
	{
		this.START_X = -7.28f;
		this.START_Y = -3.86f;
		this.CHARM_SCALE = 1.15f;
		this.CHARM_DISTANCE_X = 1.76f;
		base..ctor();
	}

	// Token: 0x04001D2C RID: 7468
	public Color notchFullColor;

	// Token: 0x04001D2D RID: 7469
	public Color notchOverColor;

	// Token: 0x04001D2E RID: 7470
	public List<int> equippedCharms;

	// Token: 0x04001D2F RID: 7471
	public List<GameObject> gameObjectList;

	// Token: 0x04001D30 RID: 7472
	public List<GameObject> instanceList;

	// Token: 0x04001D31 RID: 7473
	private PlayerData pd;

	// Token: 0x04001D32 RID: 7474
	private GameObject textNotches;

	// Token: 0x04001D33 RID: 7475
	public GameObject nextDot;

	// Token: 0x04001D34 RID: 7476
	public GameObject charmsFolder;

	// Token: 0x04001D35 RID: 7477
	private GameManager gm;

	// Token: 0x04001D36 RID: 7478
	public int charmSlots;

	// Token: 0x04001D37 RID: 7479
	public int charmSlotsFilled;

	// Token: 0x04001D38 RID: 7480
	public int equippedAmount;

	// Token: 0x04001D39 RID: 7481
	public int uiItems;

	// Token: 0x04001D3A RID: 7482
	private float START_X;

	// Token: 0x04001D3B RID: 7483
	private float START_Y;

	// Token: 0x04001D3C RID: 7484
	private float CHARM_SCALE;

	// Token: 0x04001D3D RID: 7485
	private float CHARM_DISTANCE_X;
}
