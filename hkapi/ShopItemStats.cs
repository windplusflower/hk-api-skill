using System;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x020004BD RID: 1213
public class ShopItemStats : MonoBehaviour
{
	// Token: 0x06001ACD RID: 6861 RVA: 0x0007FE14 File Offset: 0x0007E014
	private void Awake()
	{
		if (this.pd == null)
		{
			this.pd = PlayerData.instance;
		}
		string text = Language.Get(this.priceConvo, "Prices");
		try
		{
			this.cost = int.Parse(text);
		}
		catch
		{
			Debug.LogError("Input string \"" + text + "\"could not be parsed to int");
		}
		if (this.specialType == 2)
		{
			this.playerData = PlayerData.instance;
			this.notchCost = this.playerData.GetInt(this.notchCostBool);
		}
		this.geoSprite = base.transform.Find("Geo Sprite").gameObject;
		this.itemSprite = base.transform.Find("Item Sprite").gameObject;
		this.itemCost = base.transform.Find("Item cost").gameObject;
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x0007FEF8 File Offset: 0x0007E0F8
	private void OnEnable()
	{
		this.runningCost = this.cost;
		if (this.dungDiscount && this.pd.GetBool("equippedCharm_10"))
		{
			this.runningCost = (int)((float)this.cost * 0.8f);
		}
		this.itemCost.GetComponent<TextMeshPro>().text = this.runningCost.ToString();
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		this.hidden = true;
		if (this.relic)
		{
			this.SetCanBuy(true);
			string text = this.pd.GetInt(this.relicPDInt).ToString();
			base.transform.Find("Amount").gameObject.GetComponent<TextMeshPro>().text = text;
			return;
		}
		if (this.pd.GetInt("geo") >= this.runningCost && this.pd.GetInt("charmsOwned") >= this.charmsRequired)
		{
			this.geoSprite.GetComponent<SpriteRenderer>().color = this.activeColour;
			this.itemSprite.GetComponent<SpriteRenderer>().color = this.activeColour;
			this.itemCost.GetComponent<TextMeshPro>().color = this.activeColour;
			return;
		}
		this.geoSprite.GetComponent<SpriteRenderer>().color = this.inactiveColour;
		this.itemSprite.GetComponent<SpriteRenderer>().color = this.inactiveColour;
		this.itemCost.GetComponent<TextMeshPro>().color = this.inactiveColour;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x000800B0 File Offset: 0x0007E2B0
	private void Update()
	{
		float y = base.transform.position.y;
		if (y > this.topY || y < this.botY)
		{
			if (!this.hidden)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				this.hidden = true;
				return;
			}
		}
		else if (this.hidden)
		{
			foreach (object obj2 in base.transform)
			{
				((Transform)obj2).gameObject.SetActive(true);
			}
			this.hidden = false;
		}
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x0008019C File Offset: 0x0007E39C
	public int GetCost()
	{
		return this.runningCost;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x000801A4 File Offset: 0x0007E3A4
	public int GetNotchCost()
	{
		if (this.notchCost == 0 && this.specialType == 2)
		{
			this.playerData = PlayerData.instance;
			this.notchCost = this.playerData.GetInt(this.notchCostBool);
		}
		return this.notchCost;
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x000801DF File Offset: 0x0007E3DF
	public int GetCharmsRequired()
	{
		return this.charmsRequired;
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x000801E7 File Offset: 0x0007E3E7
	public int GetRelicNumber()
	{
		return this.relicNumber;
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x000801EF File Offset: 0x0007E3EF
	public string GetNameConvo()
	{
		return this.nameConvo;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000801F7 File Offset: 0x0007E3F7
	public string GetDescConvo()
	{
		return this.descConvo;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x000801FF File Offset: 0x0007E3FF
	public string GetPlayerDataBoolName()
	{
		return this.playerDataBoolName;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00080207 File Offset: 0x0007E407
	public string GetRequiredPlayerDataBoolName()
	{
		return this.requiredPlayerDataBool;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x0008020F File Offset: 0x0007E40F
	public string GetRemovalPlayerDataBoolName()
	{
		return this.removalPlayerDataBool;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x00080217 File Offset: 0x0007E417
	public int GetItemNumber()
	{
		return this.itemNumber;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x0008021F File Offset: 0x0007E41F
	public int GetSpecialType()
	{
		return this.specialType;
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x00080227 File Offset: 0x0007E427
	public bool CanBuy()
	{
		return this.canBuy;
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x0008022F File Offset: 0x0007E42F
	public void SetCanBuy(bool can)
	{
		this.canBuy = can;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x00080238 File Offset: 0x0007E438
	public void SetDescConvo(string convo)
	{
		this.descConvo = convo;
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00080241 File Offset: 0x0007E441
	public void SetCost(int newCost)
	{
		this.cost = newCost;
		this.runningCost = this.cost;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00080256 File Offset: 0x0007E456
	public ShopItemStats()
	{
		this.topY = 4.9f;
		this.botY = -5.25f;
		this.hidden = true;
		base..ctor();
	}

	// Token: 0x0400201F RID: 8223
	public string playerDataBoolName;

	// Token: 0x04002020 RID: 8224
	public string nameConvo;

	// Token: 0x04002021 RID: 8225
	public string descConvo;

	// Token: 0x04002022 RID: 8226
	public string priceConvo;

	// Token: 0x04002023 RID: 8227
	public string requiredPlayerDataBool;

	// Token: 0x04002024 RID: 8228
	public string removalPlayerDataBool;

	// Token: 0x04002025 RID: 8229
	[Tooltip("0 = None, 1 = Heart Piece, 2 = Charm, 3 = Soul Piece, 4 = Relic1,  5 = Relic2, 6 = Relic3, 7 = Relic4, 8 = Notch, 9 = Map, 10 = Simple Key, 11 = Rancid Egg, 12 = Repair Glass HP, 13 = Repair Glass Geo, 14 = Repair Glass Attack, 15 = Salubra's Blessing, 16 = Map Pin, 17 = Map Marker")]
	public int specialType;

	// Token: 0x04002026 RID: 8230
	public int relicNumber;

	// Token: 0x04002027 RID: 8231
	public int charmsRequired;

	// Token: 0x04002028 RID: 8232
	public Color activeColour;

	// Token: 0x04002029 RID: 8233
	public Color inactiveColour;

	// Token: 0x0400202A RID: 8234
	public bool dungDiscount;

	// Token: 0x0400202B RID: 8235
	public bool relic;

	// Token: 0x0400202C RID: 8236
	public string relicPDInt;

	// Token: 0x0400202D RID: 8237
	[Header("Charms Only")]
	public string notchCostBool;

	// Token: 0x0400202E RID: 8238
	[Header("Don't need to enter below variables!")]
	public int cost;

	// Token: 0x0400202F RID: 8239
	private int runningCost;

	// Token: 0x04002030 RID: 8240
	public int itemNumber;

	// Token: 0x04002031 RID: 8241
	public bool canBuy;

	// Token: 0x04002032 RID: 8242
	private PlayerData playerData;

	// Token: 0x04002033 RID: 8243
	private int notchCost;

	// Token: 0x04002034 RID: 8244
	private float topY;

	// Token: 0x04002035 RID: 8245
	private float botY;

	// Token: 0x04002036 RID: 8246
	private bool hidden;

	// Token: 0x04002037 RID: 8247
	private PlayerData pd;

	// Token: 0x04002038 RID: 8248
	private GameObject geoSprite;

	// Token: 0x04002039 RID: 8249
	private GameObject itemSprite;

	// Token: 0x0400203A RID: 8250
	private GameObject itemCost;
}
