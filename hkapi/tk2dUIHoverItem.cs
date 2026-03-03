using System;
using UnityEngine;

// Token: 0x020005A1 RID: 1441
[AddComponentMenu("2D Toolkit/UI/tk2dUIHoverItem")]
public class tk2dUIHoverItem : tk2dUIBaseItemControl
{
	// Token: 0x14000049 RID: 73
	// (add) Token: 0x06002022 RID: 8226 RVA: 0x000A1D20 File Offset: 0x0009FF20
	// (remove) Token: 0x06002023 RID: 8227 RVA: 0x000A1D58 File Offset: 0x0009FF58
	public event Action<tk2dUIHoverItem> OnToggleHover;

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06002024 RID: 8228 RVA: 0x000A1D8D File Offset: 0x0009FF8D
	// (set) Token: 0x06002025 RID: 8229 RVA: 0x000A1D95 File Offset: 0x0009FF95
	public bool IsOver
	{
		get
		{
			return this.isOver;
		}
		set
		{
			if (this.isOver != value)
			{
				this.isOver = value;
				this.SetState();
				if (this.OnToggleHover != null)
				{
					this.OnToggleHover(this);
				}
				base.DoSendMessage(this.SendMessageOnToggleHoverMethodName, this);
			}
		}
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000A1DCE File Offset: 0x0009FFCE
	private void Start()
	{
		this.SetState();
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000A1DD6 File Offset: 0x0009FFD6
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnHoverOver += this.HoverOver;
			this.uiItem.OnHoverOut += this.HoverOut;
		}
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000A1E13 File Offset: 0x000A0013
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnHoverOver -= this.HoverOver;
			this.uiItem.OnHoverOut -= this.HoverOut;
		}
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000A1E50 File Offset: 0x000A0050
	private void HoverOver()
	{
		this.IsOver = true;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000A1E59 File Offset: 0x000A0059
	private void HoverOut()
	{
		this.IsOver = false;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000A1E62 File Offset: 0x000A0062
	public void SetState()
	{
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.overStateGO, this.isOver);
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.outStateGO, !this.isOver);
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000A1E89 File Offset: 0x000A0089
	public tk2dUIHoverItem()
	{
		this.SendMessageOnToggleHoverMethodName = "";
		base..ctor();
	}

	// Token: 0x040025EA RID: 9706
	public GameObject outStateGO;

	// Token: 0x040025EB RID: 9707
	public GameObject overStateGO;

	// Token: 0x040025EC RID: 9708
	private bool isOver;

	// Token: 0x040025EE RID: 9710
	public string SendMessageOnToggleHoverMethodName;
}
