using System;
using UnityEngine;

// Token: 0x0200059F RID: 1439
[AddComponentMenu("2D Toolkit/UI/tk2dUIDropDownItem")]
public class tk2dUIDropDownItem : tk2dUIBaseItemControl
{
	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000A14F9 File Offset: 0x0009F6F9
	// (set) Token: 0x06001FFF RID: 8191 RVA: 0x000A1501 File Offset: 0x0009F701
	public int Index
	{
		get
		{
			return this.index;
		}
		set
		{
			this.index = value;
		}
	}

	// Token: 0x14000047 RID: 71
	// (add) Token: 0x06002000 RID: 8192 RVA: 0x000A150C File Offset: 0x0009F70C
	// (remove) Token: 0x06002001 RID: 8193 RVA: 0x000A1544 File Offset: 0x0009F744
	public event Action<tk2dUIDropDownItem> OnItemSelected;

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06002002 RID: 8194 RVA: 0x000A1579 File Offset: 0x0009F779
	// (set) Token: 0x06002003 RID: 8195 RVA: 0x000A1586 File Offset: 0x0009F786
	public string LabelText
	{
		get
		{
			return this.label.text;
		}
		set
		{
			this.label.text = value;
			this.label.Commit();
		}
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000A159F File Offset: 0x0009F79F
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick += this.ItemSelected;
		}
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000A15C5 File Offset: 0x0009F7C5
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick -= this.ItemSelected;
		}
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000A15EB File Offset: 0x0009F7EB
	private void ItemSelected()
	{
		if (this.OnItemSelected != null)
		{
			this.OnItemSelected(this);
		}
	}

	// Token: 0x040025D7 RID: 9687
	public tk2dTextMesh label;

	// Token: 0x040025D8 RID: 9688
	public float height;

	// Token: 0x040025D9 RID: 9689
	public tk2dUIUpDownHoverButton upDownHoverBtn;

	// Token: 0x040025DA RID: 9690
	private int index;
}
