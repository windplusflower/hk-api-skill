using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020005A0 RID: 1440
[AddComponentMenu("2D Toolkit/UI/tk2dUIDropDownMenu")]
public class tk2dUIDropDownMenu : MonoBehaviour
{
	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06002008 RID: 8200 RVA: 0x000A1609 File Offset: 0x0009F809
	// (set) Token: 0x06002009 RID: 8201 RVA: 0x000A1611 File Offset: 0x0009F811
	public List<string> ItemList
	{
		get
		{
			return this.itemList;
		}
		set
		{
			this.itemList = value;
		}
	}

	// Token: 0x14000048 RID: 72
	// (add) Token: 0x0600200A RID: 8202 RVA: 0x000A161C File Offset: 0x0009F81C
	// (remove) Token: 0x0600200B RID: 8203 RVA: 0x000A1654 File Offset: 0x0009F854
	public event Action OnSelectedItemChange;

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x0600200C RID: 8204 RVA: 0x000A1689 File Offset: 0x0009F889
	// (set) Token: 0x0600200D RID: 8205 RVA: 0x000A1691 File Offset: 0x0009F891
	public int Index
	{
		get
		{
			return this.index;
		}
		set
		{
			this.index = Mathf.Clamp(value, 0, this.ItemList.Count - 1);
			this.SetSelectedItem();
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x0600200E RID: 8206 RVA: 0x000A16B3 File Offset: 0x0009F8B3
	public string SelectedItem
	{
		get
		{
			if (this.index >= 0 && this.index < this.itemList.Count)
			{
				return this.itemList[this.index];
			}
			return "";
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x0600200F RID: 8207 RVA: 0x000A16E8 File Offset: 0x0009F8E8
	// (set) Token: 0x06002010 RID: 8208 RVA: 0x000A1705 File Offset: 0x0009F905
	public GameObject SendMessageTarget
	{
		get
		{
			if (this.dropDownButton != null)
			{
				return this.dropDownButton.sendMessageTarget;
			}
			return null;
		}
		set
		{
			if (this.dropDownButton != null && this.dropDownButton.sendMessageTarget != value)
			{
				this.dropDownButton.sendMessageTarget = value;
			}
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06002011 RID: 8209 RVA: 0x000A1734 File Offset: 0x0009F934
	// (set) Token: 0x06002012 RID: 8210 RVA: 0x000A173C File Offset: 0x0009F93C
	public tk2dUILayout MenuLayoutItem
	{
		get
		{
			return this.menuLayoutItem;
		}
		set
		{
			this.menuLayoutItem = value;
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06002013 RID: 8211 RVA: 0x000A1745 File Offset: 0x0009F945
	// (set) Token: 0x06002014 RID: 8212 RVA: 0x000A174D File Offset: 0x0009F94D
	public tk2dUILayout TemplateLayoutItem
	{
		get
		{
			return this.templateLayoutItem;
		}
		set
		{
			this.templateLayoutItem = value;
		}
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000A1758 File Offset: 0x0009F958
	private void Awake()
	{
		foreach (string item in this.startingItemList)
		{
			this.itemList.Add(item);
		}
		this.index = this.startingIndex;
		this.dropDownItemTemplate.gameObject.SetActive(false);
		this.UpdateList();
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000A17AD File Offset: 0x0009F9AD
	private void OnEnable()
	{
		this.dropDownButton.OnDown += this.ExpandButtonPressed;
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x000A17C6 File Offset: 0x0009F9C6
	private void OnDisable()
	{
		this.dropDownButton.OnDown -= this.ExpandButtonPressed;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000A17E0 File Offset: 0x0009F9E0
	public void UpdateList()
	{
		if (this.dropDownItems.Count > this.ItemList.Count)
		{
			for (int i = this.ItemList.Count; i < this.dropDownItems.Count; i++)
			{
				this.dropDownItems[i].gameObject.SetActive(false);
			}
		}
		while (this.dropDownItems.Count < this.ItemList.Count)
		{
			this.dropDownItems.Add(this.CreateAnotherDropDownItem());
		}
		for (int j = 0; j < this.ItemList.Count; j++)
		{
			tk2dUIDropDownItem tk2dUIDropDownItem = this.dropDownItems[j];
			Vector3 localPosition = tk2dUIDropDownItem.transform.localPosition;
			if (this.menuLayoutItem != null && this.templateLayoutItem != null)
			{
				localPosition.y = this.menuLayoutItem.bMin.y - (float)j * (this.templateLayoutItem.bMax.y - this.templateLayoutItem.bMin.y);
			}
			else
			{
				localPosition.y = -this.height - (float)j * tk2dUIDropDownItem.height;
			}
			tk2dUIDropDownItem.transform.localPosition = localPosition;
			if (tk2dUIDropDownItem.label != null)
			{
				tk2dUIDropDownItem.LabelText = this.itemList[j];
			}
			tk2dUIDropDownItem.Index = j;
		}
		this.SetSelectedItem();
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000A1948 File Offset: 0x0009FB48
	public void SetSelectedItem()
	{
		if (this.index < 0 || this.index >= this.ItemList.Count)
		{
			this.index = 0;
		}
		if (this.index >= 0 && this.index < this.ItemList.Count)
		{
			this.selectedTextMesh.text = this.ItemList[this.index];
			this.selectedTextMesh.Commit();
		}
		else
		{
			this.selectedTextMesh.text = "";
			this.selectedTextMesh.Commit();
		}
		if (this.OnSelectedItemChange != null)
		{
			this.OnSelectedItemChange();
		}
		if (this.SendMessageTarget != null && this.SendMessageOnSelectedItemChangeMethodName.Length > 0)
		{
			this.SendMessageTarget.SendMessage(this.SendMessageOnSelectedItemChangeMethodName, this, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000A1A1C File Offset: 0x0009FC1C
	private tk2dUIDropDownItem CreateAnotherDropDownItem()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.dropDownItemTemplate.gameObject);
		gameObject.name = "DropDownItem";
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = this.dropDownItemTemplate.transform.localPosition;
		gameObject.transform.localRotation = this.dropDownItemTemplate.transform.localRotation;
		gameObject.transform.localScale = this.dropDownItemTemplate.transform.localScale;
		tk2dUIDropDownItem component = gameObject.GetComponent<tk2dUIDropDownItem>();
		component.OnItemSelected += this.ItemSelected;
		tk2dUIUpDownHoverButton component2 = gameObject.GetComponent<tk2dUIUpDownHoverButton>();
		component.upDownHoverBtn = component2;
		component2.OnToggleOver += this.DropDownItemHoverBtnToggle;
		return component;
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000A1ADF File Offset: 0x0009FCDF
	private void ItemSelected(tk2dUIDropDownItem item)
	{
		if (this.isExpanded)
		{
			this.CollapseList();
		}
		this.Index = item.Index;
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000A1AFB File Offset: 0x0009FCFB
	private void ExpandButtonPressed()
	{
		if (this.isExpanded)
		{
			this.CollapseList();
			return;
		}
		this.ExpandList();
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000A1B14 File Offset: 0x0009FD14
	private void ExpandList()
	{
		this.isExpanded = true;
		int num = Mathf.Min(this.ItemList.Count, this.dropDownItems.Count);
		for (int i = 0; i < num; i++)
		{
			this.dropDownItems[i].gameObject.SetActive(true);
		}
		tk2dUIDropDownItem tk2dUIDropDownItem = this.dropDownItems[this.index];
		if (tk2dUIDropDownItem.upDownHoverBtn != null)
		{
			tk2dUIDropDownItem.upDownHoverBtn.IsOver = true;
		}
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000A1B94 File Offset: 0x0009FD94
	private void CollapseList()
	{
		this.isExpanded = false;
		foreach (tk2dUIDropDownItem tk2dUIDropDownItem in this.dropDownItems)
		{
			tk2dUIDropDownItem.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
	private void DropDownItemHoverBtnToggle(tk2dUIUpDownHoverButton upDownHoverButton)
	{
		if (upDownHoverButton.IsOver)
		{
			foreach (tk2dUIDropDownItem tk2dUIDropDownItem in this.dropDownItems)
			{
				if (tk2dUIDropDownItem.upDownHoverBtn != upDownHoverButton && tk2dUIDropDownItem.upDownHoverBtn != null)
				{
					tk2dUIDropDownItem.upDownHoverBtn.IsOver = false;
				}
			}
		}
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000A1C70 File Offset: 0x0009FE70
	private void OnDestroy()
	{
		foreach (tk2dUIDropDownItem tk2dUIDropDownItem in this.dropDownItems)
		{
			tk2dUIDropDownItem.OnItemSelected -= this.ItemSelected;
			if (tk2dUIDropDownItem.upDownHoverBtn != null)
			{
				tk2dUIDropDownItem.upDownHoverBtn.OnToggleOver -= this.DropDownItemHoverBtnToggle;
			}
		}
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x000A1CF4 File Offset: 0x0009FEF4
	public tk2dUIDropDownMenu()
	{
		this.itemList = new List<string>();
		this.SendMessageOnSelectedItemChangeMethodName = "";
		this.dropDownItems = new List<tk2dUIDropDownItem>();
		base..ctor();
	}

	// Token: 0x040025DC RID: 9692
	public tk2dUIItem dropDownButton;

	// Token: 0x040025DD RID: 9693
	public tk2dTextMesh selectedTextMesh;

	// Token: 0x040025DE RID: 9694
	[HideInInspector]
	public float height;

	// Token: 0x040025DF RID: 9695
	public tk2dUIDropDownItem dropDownItemTemplate;

	// Token: 0x040025E0 RID: 9696
	[SerializeField]
	private string[] startingItemList;

	// Token: 0x040025E1 RID: 9697
	[SerializeField]
	private int startingIndex;

	// Token: 0x040025E2 RID: 9698
	private List<string> itemList;

	// Token: 0x040025E4 RID: 9700
	public string SendMessageOnSelectedItemChangeMethodName;

	// Token: 0x040025E5 RID: 9701
	private int index;

	// Token: 0x040025E6 RID: 9702
	private List<tk2dUIDropDownItem> dropDownItems;

	// Token: 0x040025E7 RID: 9703
	private bool isExpanded;

	// Token: 0x040025E8 RID: 9704
	[SerializeField]
	[HideInInspector]
	private tk2dUILayout menuLayoutItem;

	// Token: 0x040025E9 RID: 9705
	[SerializeField]
	[HideInInspector]
	private tk2dUILayout templateLayoutItem;
}
