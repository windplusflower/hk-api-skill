using System;
using UnityEngine;

// Token: 0x02000470 RID: 1136
public class JournalListOld : MonoBehaviour
{
	// Token: 0x06001983 RID: 6531 RVA: 0x00003603 File Offset: 0x00001803
	private void Start()
	{
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x00079B8C File Offset: 0x00077D8C
	private void BuildItemList()
	{
		Debug.Log("build item list");
		this.firstNewItem = -1;
		this.itemCount = -1;
		this.pd = PlayerData.instance;
		float num = 0f;
		this.listInv = new GameObject[this.list.Length];
		for (int i = 0; i < this.list.Length; i++)
		{
			if (this.pd.GetBool(this.list[i].GetComponent<JournalEntryStats>().GetPlayerDataBoolName()) || this.pd.GetBool("fillJournal"))
			{
				this.itemCount++;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.list[i]);
				gameObject.transform.position = new Vector3(0f, num, 0f);
				gameObject.transform.SetParent(base.transform, false);
				gameObject.GetComponent<JournalEntryStats>().itemNumber = this.itemCount;
				this.listInv[this.itemCount] = gameObject;
				num += this.yDistance;
				if (this.pd.GetBool(this.list[i].GetComponent<JournalEntryStats>().GetPlayerDataNewDataName()) && this.firstNewItem == -1)
				{
					this.firstNewItem = this.itemCount;
				}
			}
		}
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00079CC7 File Offset: 0x00077EC7
	public int GetItemCount()
	{
		return this.itemCount;
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00079CCF File Offset: 0x00077ECF
	public string GetNameConvo(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetNameConvo();
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x00079CE3 File Offset: 0x00077EE3
	public string GetDescConvo(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetDescConvo();
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x00079CF7 File Offset: 0x00077EF7
	public bool GetWarriorGhost(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetWarriorGhost();
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x00079D0B File Offset: 0x00077F0B
	public string GetNotesConvo(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetNotesConvo();
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x00079D1F File Offset: 0x00077F1F
	public string GetPlayerDataBoolName(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataBoolName();
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x00079D33 File Offset: 0x00077F33
	public string GetPlayerDataKillsName(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataKillsName();
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00079D47 File Offset: 0x00077F47
	public string GetPlayerDataNewDataName(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataNewDataName();
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x00079D5B File Offset: 0x00077F5B
	public Sprite GetSprite(int itemNum)
	{
		return this.listInv[itemNum].GetComponent<JournalEntryStats>().GetSprite();
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x00079D6F File Offset: 0x00077F6F
	public float GetYDistance()
	{
		return this.yDistance;
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x00079D77 File Offset: 0x00077F77
	public int GetFirstNewItem()
	{
		return this.firstNewItem;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00079D7F File Offset: 0x00077F7F
	public JournalListOld()
	{
		this.yDistance = -1.5f;
		this.itemCount = -1;
		base..ctor();
	}

	// Token: 0x04001EAF RID: 7855
	public GameObject[] list;

	// Token: 0x04001EB0 RID: 7856
	public GameObject[] listInv;

	// Token: 0x04001EB1 RID: 7857
	public PlayerData pd;

	// Token: 0x04001EB2 RID: 7858
	public float yDistance;

	// Token: 0x04001EB3 RID: 7859
	private Vector3 selfPos;

	// Token: 0x04001EB4 RID: 7860
	public int itemCount;

	// Token: 0x04001EB5 RID: 7861
	public int firstNewItem;
}
