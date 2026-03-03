using System;
using UnityEngine;

// Token: 0x020005AA RID: 1450
[AddComponentMenu("2D Toolkit/UI/tk2dUIToggleButton")]
public class tk2dUIToggleButton : tk2dUIBaseItemControl
{
	// Token: 0x1400004E RID: 78
	// (add) Token: 0x060020AA RID: 8362 RVA: 0x000A4970 File Offset: 0x000A2B70
	// (remove) Token: 0x060020AB RID: 8363 RVA: 0x000A49A8 File Offset: 0x000A2BA8
	public event Action<tk2dUIToggleButton> OnToggle;

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x060020AC RID: 8364 RVA: 0x000A49DD File Offset: 0x000A2BDD
	// (set) Token: 0x060020AD RID: 8365 RVA: 0x000A49E5 File Offset: 0x000A2BE5
	public bool IsOn
	{
		get
		{
			return this.isOn;
		}
		set
		{
			if (this.isOn != value)
			{
				this.isOn = value;
				this.SetState();
				if (this.OnToggle != null)
				{
					this.OnToggle(this);
				}
			}
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x060020AE RID: 8366 RVA: 0x000A4A11 File Offset: 0x000A2C11
	// (set) Token: 0x060020AF RID: 8367 RVA: 0x000A4A19 File Offset: 0x000A2C19
	public bool IsInToggleGroup
	{
		get
		{
			return this.isInToggleGroup;
		}
		set
		{
			this.isInToggleGroup = value;
		}
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000A4A22 File Offset: 0x000A2C22
	private void Start()
	{
		this.SetState();
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000A4A2A File Offset: 0x000A2C2A
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick += this.ButtonClick;
			this.uiItem.OnDown += this.ButtonDown;
		}
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x000A4A67 File Offset: 0x000A2C67
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnClick -= this.ButtonClick;
			this.uiItem.OnDown -= this.ButtonDown;
		}
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000A4AA4 File Offset: 0x000A2CA4
	private void ButtonClick()
	{
		if (!this.activateOnPress)
		{
			this.ButtonToggle();
		}
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
	private void ButtonDown()
	{
		if (this.activateOnPress)
		{
			this.ButtonToggle();
		}
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000A4AC4 File Offset: 0x000A2CC4
	private void ButtonToggle()
	{
		if (!this.isOn || !this.isInToggleGroup)
		{
			this.isOn = !this.isOn;
			this.SetState();
			if (this.OnToggle != null)
			{
				this.OnToggle(this);
			}
			base.DoSendMessage(this.SendMessageOnToggleMethodName, this);
		}
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000A4B17 File Offset: 0x000A2D17
	private void SetState()
	{
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.offStateGO, !this.isOn);
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.onStateGO, this.isOn);
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000A4B3E File Offset: 0x000A2D3E
	public tk2dUIToggleButton()
	{
		this.isOn = true;
		this.SendMessageOnToggleMethodName = "";
		base..ctor();
	}

	// Token: 0x04002651 RID: 9809
	public GameObject offStateGO;

	// Token: 0x04002652 RID: 9810
	public GameObject onStateGO;

	// Token: 0x04002653 RID: 9811
	public bool activateOnPress;

	// Token: 0x04002654 RID: 9812
	[SerializeField]
	private bool isOn;

	// Token: 0x04002655 RID: 9813
	private bool isInToggleGroup;

	// Token: 0x04002657 RID: 9815
	public string SendMessageOnToggleMethodName;
}
