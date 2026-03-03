using System;
using UnityEngine;

// Token: 0x020005A2 RID: 1442
[AddComponentMenu("2D Toolkit/UI/tk2dUIMultiStateToggleButton")]
public class tk2dUIMultiStateToggleButton : tk2dUIBaseItemControl
{
	// Token: 0x1400004A RID: 74
	// (add) Token: 0x0600202D RID: 8237 RVA: 0x000A1E9C File Offset: 0x000A009C
	// (remove) Token: 0x0600202E RID: 8238 RVA: 0x000A1ED4 File Offset: 0x000A00D4
	public event Action<tk2dUIMultiStateToggleButton> OnStateToggle;

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x0600202F RID: 8239 RVA: 0x000A1F09 File Offset: 0x000A0109
	// (set) Token: 0x06002030 RID: 8240 RVA: 0x000A1F14 File Offset: 0x000A0114
	public int Index
	{
		get
		{
			return this.index;
		}
		set
		{
			if (value >= this.states.Length)
			{
				value = this.states.Length;
			}
			if (value < 0)
			{
				value = 0;
			}
			if (this.index != value)
			{
				this.index = value;
				this.SetState();
				if (this.OnStateToggle != null)
				{
					this.OnStateToggle(this);
				}
				base.DoSendMessage(this.SendMessageOnStateToggleMethodName, this);
			}
		}
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000A1F78 File Offset: 0x000A0178
	private void Start()
	{
		this.SetState();
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000A1F80 File Offset: 0x000A0180
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick += this.ButtonClick;
			this.uiItem.OnDown += this.ButtonDown;
		}
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000A1FBD File Offset: 0x000A01BD
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick -= this.ButtonClick;
			this.uiItem.OnDown -= this.ButtonDown;
		}
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000A1FFA File Offset: 0x000A01FA
	private void ButtonClick()
	{
		if (!this.activateOnPress)
		{
			this.ButtonToggle();
		}
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x000A200A File Offset: 0x000A020A
	private void ButtonDown()
	{
		if (this.activateOnPress)
		{
			this.ButtonToggle();
		}
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000A201C File Offset: 0x000A021C
	private void ButtonToggle()
	{
		if (this.Index + 1 >= this.states.Length)
		{
			this.Index = 0;
			return;
		}
		int num = this.Index;
		this.Index = num + 1;
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000A2054 File Offset: 0x000A0254
	private void SetState()
	{
		for (int i = 0; i < this.states.Length; i++)
		{
			if (this.states[i] != null)
			{
				if (i != this.index)
				{
					if (this.states[i].activeInHierarchy)
					{
						this.states[i].SetActive(false);
					}
				}
				else if (!this.states[i].activeInHierarchy)
				{
					this.states[i].SetActive(true);
				}
			}
		}
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000A20C9 File Offset: 0x000A02C9
	public tk2dUIMultiStateToggleButton()
	{
		this.SendMessageOnStateToggleMethodName = "";
		base..ctor();
	}

	// Token: 0x040025EF RID: 9711
	public GameObject[] states;

	// Token: 0x040025F0 RID: 9712
	public bool activateOnPress;

	// Token: 0x040025F2 RID: 9714
	private int index;

	// Token: 0x040025F3 RID: 9715
	public string SendMessageOnStateToggleMethodName;
}
