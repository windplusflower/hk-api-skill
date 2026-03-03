using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004BE RID: 1214
public class ShopMenuStock : MonoBehaviour
{
	// Token: 0x06001AE0 RID: 6880 RVA: 0x0008027C File Offset: 0x0007E47C
	private void Start()
	{
		PlayerData instance = PlayerData.instance;
		if (this.altPlayerDataBool != "" && (instance.GetBool(this.altPlayerDataBool) || (this.altPlayerDataBoolAlt != "" && instance.GetBool(this.altPlayerDataBoolAlt))))
		{
			this.stock = this.stockAlt;
		}
		this.SpawnStock();
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x000802E4 File Offset: 0x0007E4E4
	private void SpawnStock()
	{
		if (this.masterList)
		{
			ShopMenuStock component = this.masterList.GetComponent<ShopMenuStock>();
			if (component)
			{
				this.spawnedStock = component.spawnedStock;
			}
		}
		if (this.spawnedStock == null && this.stock.Length != 0)
		{
			this.spawnedStock = new Dictionary<GameObject, GameObject>(this.stock.Length);
			foreach (GameObject gameObject in this.stock)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
				gameObject2.SetActive(false);
				this.spawnedStock.Add(gameObject, gameObject2);
			}
		}
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x0008037C File Offset: 0x0007E57C
	public void UpdateStock()
	{
		PlayerData instance = PlayerData.instance;
		if (this.altPlayerDataBool != "" && instance.GetBool(this.altPlayerDataBool))
		{
			this.stock = this.stockAlt;
		}
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000803BB File Offset: 0x0007E5BB
	private void BuildFromMasterList()
	{
		this.masterList = base.transform.parent.gameObject;
		this.stock = this.masterList.GetComponent<ShopMenuStock>().stock;
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000803EC File Offset: 0x0007E5EC
	public bool StockLeft()
	{
		PlayerData instance = PlayerData.instance;
		bool result = false;
		if (instance != null)
		{
			for (int i = 0; i < this.stock.Length; i++)
			{
				if (this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == "" || this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == "Null" || this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == null)
				{
					if (!instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetPlayerDataBoolName()) && (this.stock[i].GetComponent<ShopItemStats>().removalPlayerDataBool == "" || !instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRemovalPlayerDataBoolName())))
					{
						result = true;
					}
				}
				else if (!instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetPlayerDataBoolName()) && instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRequiredPlayerDataBoolName()) && (this.stock[i].GetComponent<ShopItemStats>().removalPlayerDataBool == "" || !instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRemovalPlayerDataBoolName())))
				{
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x0008053C File Offset: 0x0007E73C
	private void BuildItemList()
	{
		PlayerData instance = PlayerData.instance;
		if (this.spawnedStock == null)
		{
			this.SpawnStock();
		}
		this.itemCount = -1;
		float num = 0f;
		this.stockInv = new GameObject[this.stock.Length];
		for (int i = 0; i < this.stock.Length; i++)
		{
			if (this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == "" || this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == "Null" || this.stock[i].GetComponent<ShopItemStats>().requiredPlayerDataBool == null)
			{
				if ((!instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetPlayerDataBoolName()) || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == "" || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == "Null" || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == null) && (this.stock[i].GetComponent<ShopItemStats>().removalPlayerDataBool == "" || !instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRemovalPlayerDataBoolName())))
				{
					this.itemCount++;
					GameObject gameObject = this.spawnedStock[this.stock[i]];
					gameObject.transform.SetParent(base.transform, false);
					gameObject.transform.localPosition = new Vector3(0f, num, 0f);
					gameObject.GetComponent<ShopItemStats>().itemNumber = this.itemCount;
					this.stockInv[this.itemCount] = gameObject;
					num += this.yDistance;
					gameObject.SetActive(true);
				}
			}
			else if ((!instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetPlayerDataBoolName()) || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == "" || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == "Null" || this.stock[i].GetComponent<ShopItemStats>().playerDataBoolName == null) && instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRequiredPlayerDataBoolName()) && (this.stock[i].GetComponent<ShopItemStats>().removalPlayerDataBool == "" || !instance.GetBool(this.stock[i].GetComponent<ShopItemStats>().GetRemovalPlayerDataBoolName())))
			{
				this.itemCount++;
				GameObject gameObject = this.spawnedStock[this.stock[i]];
				gameObject.transform.SetParent(base.transform, false);
				gameObject.transform.localPosition = new Vector3(0f, num, 0f);
				gameObject.GetComponent<ShopItemStats>().itemNumber = this.itemCount;
				this.stockInv[this.itemCount] = gameObject;
				num += this.yDistance;
				gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00080854 File Offset: 0x0007EA54
	public int GetItemCount()
	{
		return this.itemCount;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x0008085C File Offset: 0x0007EA5C
	public int GetCost(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetCost();
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x00080870 File Offset: 0x0007EA70
	public int GetNotchCost(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetNotchCost();
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x00080884 File Offset: 0x0007EA84
	public string GetNameConvo(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetNameConvo();
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00080898 File Offset: 0x0007EA98
	public string GetDescConvo(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetDescConvo();
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000808AC File Offset: 0x0007EAAC
	public string GetPlayerDataBoolName(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetPlayerDataBoolName();
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000808C0 File Offset: 0x0007EAC0
	public int GetSpecialType(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetSpecialType();
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000808D4 File Offset: 0x0007EAD4
	public int GetRelicNumber(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetRelicNumber();
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000808E8 File Offset: 0x0007EAE8
	public int GetCharmsRequired(int itemNum)
	{
		return this.stockInv[itemNum].GetComponent<ShopItemStats>().GetCharmsRequired();
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000808FC File Offset: 0x0007EAFC
	public float GetYDistance()
	{
		return this.yDistance;
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00080904 File Offset: 0x0007EB04
	public Sprite GetItemSprite(int itemNum)
	{
		return this.stockInv[itemNum].transform.Find("Item Sprite").gameObject.GetComponent<SpriteRenderer>().sprite;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0008092C File Offset: 0x0007EB2C
	public Vector3 GetItemSpriteScale(int itemNum)
	{
		return this.stockInv[itemNum].transform.Find("Item Sprite").gameObject.transform.localScale;
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00080954 File Offset: 0x0007EB54
	public bool CanBuy(int itemNum)
	{
		PlayerData instance = PlayerData.instance;
		bool result = this.stockInv[itemNum].GetComponent<ShopItemStats>().relicNumber > 0 || instance.GetInt("geo") >= this.stockInv[itemNum].GetComponent<ShopItemStats>().GetCost();
		if (instance.GetInt("charmsOwned") < this.stockInv[itemNum].GetComponent<ShopItemStats>().charmsRequired)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000809C7 File Offset: 0x0007EBC7
	public GameObject GetItemGameObject(int itemNum)
	{
		return this.stockInv[itemNum];
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000809D1 File Offset: 0x0007EBD1
	public ShopMenuStock()
	{
		this.yDistance = -1.5f;
		this.itemCount = -1;
		base..ctor();
	}

	// Token: 0x0400203B RID: 8251
	public GameObject masterList;

	// Token: 0x0400203C RID: 8252
	public GameObject[] stock;

	// Token: 0x0400203D RID: 8253
	public GameObject[] stockInv;

	// Token: 0x0400203E RID: 8254
	public GameObject[] stockAlt;

	// Token: 0x0400203F RID: 8255
	public string altPlayerDataBool;

	// Token: 0x04002040 RID: 8256
	public string altPlayerDataBoolAlt;

	// Token: 0x04002041 RID: 8257
	private Dictionary<GameObject, GameObject> spawnedStock;

	// Token: 0x04002042 RID: 8258
	public float yDistance;

	// Token: 0x04002043 RID: 8259
	private Vector3 selfPos;

	// Token: 0x04002044 RID: 8260
	public int itemCount;
}
