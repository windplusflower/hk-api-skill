using System;
using UnityEngine;

// Token: 0x020005AB RID: 1451
[AddComponentMenu("2D Toolkit/UI/tk2dUIToggleButtonGroup")]
public class tk2dUIToggleButtonGroup : MonoBehaviour
{
	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000A4B58 File Offset: 0x000A2D58
	public tk2dUIToggleButton[] ToggleBtns
	{
		get
		{
			return this.toggleBtns;
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000A4B60 File Offset: 0x000A2D60
	// (set) Token: 0x060020BA RID: 8378 RVA: 0x000A4B68 File Offset: 0x000A2D68
	public int SelectedIndex
	{
		get
		{
			return this.selectedIndex;
		}
		set
		{
			if (this.selectedIndex != value)
			{
				this.selectedIndex = value;
				this.SetToggleButtonUsingSelectedIndex();
			}
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x060020BB RID: 8379 RVA: 0x000A4B80 File Offset: 0x000A2D80
	// (set) Token: 0x060020BC RID: 8380 RVA: 0x000A4B88 File Offset: 0x000A2D88
	public tk2dUIToggleButton SelectedToggleButton
	{
		get
		{
			return this.selectedToggleButton;
		}
		set
		{
			this.ButtonToggle(value);
		}
	}

	// Token: 0x1400004F RID: 79
	// (add) Token: 0x060020BD RID: 8381 RVA: 0x000A4B94 File Offset: 0x000A2D94
	// (remove) Token: 0x060020BE RID: 8382 RVA: 0x000A4BCC File Offset: 0x000A2DCC
	public event Action<tk2dUIToggleButtonGroup> OnChange;

	// Token: 0x060020BF RID: 8383 RVA: 0x000A4C01 File Offset: 0x000A2E01
	protected virtual void Awake()
	{
		this.Setup();
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000A4C0C File Offset: 0x000A2E0C
	protected void Setup()
	{
		foreach (tk2dUIToggleButton tk2dUIToggleButton in this.toggleBtns)
		{
			if (tk2dUIToggleButton != null)
			{
				tk2dUIToggleButton.IsInToggleGroup = true;
				tk2dUIToggleButton.IsOn = false;
				tk2dUIToggleButton.OnToggle += this.ButtonToggle;
			}
		}
		this.SetToggleButtonUsingSelectedIndex();
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000A4C61 File Offset: 0x000A2E61
	public void AddNewToggleButtons(tk2dUIToggleButton[] newToggleBtns)
	{
		this.ClearExistingToggleBtns();
		this.toggleBtns = newToggleBtns;
		this.Setup();
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000A4C78 File Offset: 0x000A2E78
	private void ClearExistingToggleBtns()
	{
		if (this.toggleBtns != null && this.toggleBtns.Length != 0)
		{
			foreach (tk2dUIToggleButton tk2dUIToggleButton in this.toggleBtns)
			{
				tk2dUIToggleButton.IsInToggleGroup = false;
				tk2dUIToggleButton.OnToggle -= this.ButtonToggle;
				tk2dUIToggleButton.IsOn = false;
			}
		}
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
	private void SetToggleButtonUsingSelectedIndex()
	{
		tk2dUIToggleButton tk2dUIToggleButton;
		if (this.selectedIndex >= 0 && this.selectedIndex < this.toggleBtns.Length)
		{
			tk2dUIToggleButton = this.toggleBtns[this.selectedIndex];
			tk2dUIToggleButton.IsOn = true;
			return;
		}
		tk2dUIToggleButton = null;
		this.selectedIndex = -1;
		this.ButtonToggle(tk2dUIToggleButton);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000A4D20 File Offset: 0x000A2F20
	private void ButtonToggle(tk2dUIToggleButton toggleButton)
	{
		if (toggleButton == null || toggleButton.IsOn)
		{
			foreach (tk2dUIToggleButton tk2dUIToggleButton in this.toggleBtns)
			{
				if (tk2dUIToggleButton != toggleButton)
				{
					tk2dUIToggleButton.IsOn = false;
				}
			}
			if (toggleButton != this.selectedToggleButton)
			{
				this.selectedToggleButton = toggleButton;
				this.SetSelectedIndexFromSelectedToggleButton();
				if (this.OnChange != null)
				{
					this.OnChange(this);
				}
				if (this.sendMessageTarget != null && this.SendMessageOnChangeMethodName.Length > 0)
				{
					this.sendMessageTarget.SendMessage(this.SendMessageOnChangeMethodName, this, SendMessageOptions.RequireReceiver);
				}
			}
		}
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000A4DC8 File Offset: 0x000A2FC8
	private void SetSelectedIndexFromSelectedToggleButton()
	{
		this.selectedIndex = -1;
		for (int i = 0; i < this.toggleBtns.Length; i++)
		{
			if (this.toggleBtns[i] == this.selectedToggleButton)
			{
				this.selectedIndex = i;
				return;
			}
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000A4E0C File Offset: 0x000A300C
	public tk2dUIToggleButtonGroup()
	{
		this.SendMessageOnChangeMethodName = "";
		base..ctor();
	}

	// Token: 0x04002658 RID: 9816
	[SerializeField]
	private tk2dUIToggleButton[] toggleBtns;

	// Token: 0x04002659 RID: 9817
	public GameObject sendMessageTarget;

	// Token: 0x0400265A RID: 9818
	[SerializeField]
	private int selectedIndex;

	// Token: 0x0400265B RID: 9819
	private tk2dUIToggleButton selectedToggleButton;

	// Token: 0x0400265D RID: 9821
	public string SendMessageOnChangeMethodName;
}
