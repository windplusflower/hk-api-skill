using System;
using UnityEngine;

// Token: 0x0200046F RID: 1135
public class JournalList : MonoBehaviour
{
	// Token: 0x06001974 RID: 6516 RVA: 0x000798C0 File Offset: 0x00077AC0
	public void BuildEnemyList()
	{
		this.pd = PlayerData.instance;
		this.firstNewItem = -1;
		this.listInv = new GameObject[this.list.Length];
		for (int i = 0; i < this.list.Length; i++)
		{
			if (this.list[i] != null)
			{
				this.itemCount++;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.list[i]);
				gameObject.transform.SetParent(base.transform, false);
				this.listInv[this.itemCount] = gameObject;
			}
			else
			{
				Debug.LogErrorFormat("JournalList cannot instantiate item {0} in enemyList as it is NULL", new object[]
				{
					i
				});
			}
		}
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x0007996C File Offset: 0x00077B6C
	public void UpdateEnemyList()
	{
		this.firstNewItem = -1;
		this.itemCount = -1;
		float num = 0f;
		this.currentList = new GameObject[this.listInv.Length];
		for (int i = 0; i < this.listInv.Length; i++)
		{
			GameObject gameObject = this.listInv[i];
			JournalEntryStats component = gameObject.GetComponent<JournalEntryStats>();
			if (this.pd.GetBool(this.listInv[i].GetComponent<JournalEntryStats>().GetPlayerDataBoolName()) || this.pd.GetBool("fillJournal"))
			{
				this.itemCount++;
				gameObject.SetActive(true);
				gameObject.transform.localPosition = new Vector3(0f, num, 0f);
				component.itemNumber = this.itemCount;
				this.currentList[this.itemCount] = gameObject;
				num += this.yDistance;
				if (this.pd.GetBool(component.GetPlayerDataNewDataName()) && this.firstNewItem == -1)
				{
					this.firstNewItem = this.itemCount;
				}
			}
			else
			{
				gameObject.SetActive(false);
				gameObject.GetComponent<JournalEntryStats>().itemNumber = -10;
			}
		}
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x00079A8E File Offset: 0x00077C8E
	public int GetItemCount()
	{
		return this.itemCount;
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00079A98 File Offset: 0x00077C98
	public string GetNameConvo(int itemNum)
	{
		string nameConvo = this.currentList[itemNum].GetComponent<JournalEntryStats>().GetNameConvo();
		if (nameConvo != null)
		{
			return nameConvo;
		}
		return "";
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x00079AC2 File Offset: 0x00077CC2
	public string GetDescConvo(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetDescConvo();
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x00079AD6 File Offset: 0x00077CD6
	public bool GetWarriorGhost(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetWarriorGhost();
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x00079AEA File Offset: 0x00077CEA
	public bool GetGrimm(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetGrimm();
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x00079AFE File Offset: 0x00077CFE
	public string GetNotesConvo(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetNotesConvo();
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x00079B12 File Offset: 0x00077D12
	public string GetPlayerDataBoolName(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataBoolName();
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x00079B26 File Offset: 0x00077D26
	public string GetPlayerDataKillsName(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataKillsName();
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x00079B3A File Offset: 0x00077D3A
	public string GetPlayerDataNewDataName(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetPlayerDataNewDataName();
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x00079B4E File Offset: 0x00077D4E
	public Sprite GetSprite(int itemNum)
	{
		return this.currentList[itemNum].GetComponent<JournalEntryStats>().GetSprite();
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x00079B62 File Offset: 0x00077D62
	public float GetYDistance()
	{
		return this.yDistance;
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x00079B6A File Offset: 0x00077D6A
	public int GetFirstNewItem()
	{
		return this.firstNewItem;
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00079B72 File Offset: 0x00077D72
	public JournalList()
	{
		this.yDistance = -1.5f;
		this.itemCount = -1;
		base..ctor();
	}

	// Token: 0x04001EA7 RID: 7847
	public GameObject[] list;

	// Token: 0x04001EA8 RID: 7848
	public GameObject[] listInv;

	// Token: 0x04001EA9 RID: 7849
	private GameObject[] currentList;

	// Token: 0x04001EAA RID: 7850
	private PlayerData pd;

	// Token: 0x04001EAB RID: 7851
	public float yDistance;

	// Token: 0x04001EAC RID: 7852
	private Vector3 selfPos;

	// Token: 0x04001EAD RID: 7853
	public int itemCount;

	// Token: 0x04001EAE RID: 7854
	public int firstNewItem;
}
