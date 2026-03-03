using System;
using UnityEngine;

// Token: 0x020005B0 RID: 1456
[AddComponentMenu("2D Toolkit/UI/tk2dUIUpDownHoverButton")]
public class tk2dUIUpDownHoverButton : tk2dUIBaseItemControl
{
	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000A52E6 File Offset: 0x000A34E6
	public bool UseOnReleaseInsteadOfOnUp
	{
		get
		{
			return this.useOnReleaseInsteadOfOnUp;
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000A52EE File Offset: 0x000A34EE
	// (set) Token: 0x060020E2 RID: 8418 RVA: 0x000A5300 File Offset: 0x000A3500
	public bool IsOver
	{
		get
		{
			return this.isDown || this.isHover;
		}
		set
		{
			if (value != this.isDown || this.isHover)
			{
				if (value)
				{
					this.isHover = true;
					this.SetState();
					if (this.OnToggleOver != null)
					{
						this.OnToggleOver(this);
					}
				}
				else if (this.isDown && this.isHover)
				{
					this.isDown = false;
					this.isHover = false;
					this.SetState();
					if (this.OnToggleOver != null)
					{
						this.OnToggleOver(this);
					}
				}
				else if (this.isDown)
				{
					this.isDown = false;
					this.SetState();
					if (this.OnToggleOver != null)
					{
						this.OnToggleOver(this);
					}
				}
				else
				{
					this.isHover = false;
					this.SetState();
					if (this.OnToggleOver != null)
					{
						this.OnToggleOver(this);
					}
				}
				base.DoSendMessage(this.SendMessageOnToggleOverMethodName, this);
			}
		}
	}

	// Token: 0x14000050 RID: 80
	// (add) Token: 0x060020E3 RID: 8419 RVA: 0x000A53E0 File Offset: 0x000A35E0
	// (remove) Token: 0x060020E4 RID: 8420 RVA: 0x000A5418 File Offset: 0x000A3618
	public event Action<tk2dUIUpDownHoverButton> OnToggleOver;

	// Token: 0x060020E5 RID: 8421 RVA: 0x000A544D File Offset: 0x000A364D
	private void Start()
	{
		this.SetState();
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000A5458 File Offset: 0x000A3658
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown += this.ButtonDown;
			if (this.useOnReleaseInsteadOfOnUp)
			{
				this.uiItem.OnRelease += this.ButtonUp;
			}
			else
			{
				this.uiItem.OnUp += this.ButtonUp;
			}
			this.uiItem.OnHoverOver += this.ButtonHoverOver;
			this.uiItem.OnHoverOut += this.ButtonHoverOut;
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000A54F4 File Offset: 0x000A36F4
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown -= this.ButtonDown;
			if (this.useOnReleaseInsteadOfOnUp)
			{
				this.uiItem.OnRelease -= this.ButtonUp;
			}
			else
			{
				this.uiItem.OnUp -= this.ButtonUp;
			}
			this.uiItem.OnHoverOver -= this.ButtonHoverOver;
			this.uiItem.OnHoverOut -= this.ButtonHoverOut;
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000A558E File Offset: 0x000A378E
	private void ButtonUp()
	{
		if (this.isDown)
		{
			this.isDown = false;
			this.SetState();
			if (!this.isHover && this.OnToggleOver != null)
			{
				this.OnToggleOver(this);
			}
		}
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000A55C1 File Offset: 0x000A37C1
	private void ButtonDown()
	{
		if (!this.isDown)
		{
			this.isDown = true;
			this.SetState();
			if (!this.isHover && this.OnToggleOver != null)
			{
				this.OnToggleOver(this);
			}
		}
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000A55F4 File Offset: 0x000A37F4
	private void ButtonHoverOver()
	{
		if (!this.isHover)
		{
			this.isHover = true;
			this.SetState();
			if (!this.isDown && this.OnToggleOver != null)
			{
				this.OnToggleOver(this);
			}
		}
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000A5627 File Offset: 0x000A3827
	private void ButtonHoverOut()
	{
		if (this.isHover)
		{
			this.isHover = false;
			this.SetState();
			if (!this.isDown && this.OnToggleOver != null)
			{
				this.OnToggleOver(this);
			}
		}
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000A565C File Offset: 0x000A385C
	public void SetState()
	{
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.upStateGO, !this.isDown && !this.isHover);
		if (this.downStateGO == this.hoverOverStateGO)
		{
			tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.downStateGO, this.isDown || this.isHover);
			return;
		}
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.downStateGO, this.isDown);
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.hoverOverStateGO, this.isHover);
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000A56DA File Offset: 0x000A38DA
	public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
	{
		this.useOnReleaseInsteadOfOnUp = state;
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000A56E3 File Offset: 0x000A38E3
	public tk2dUIUpDownHoverButton()
	{
		this.SendMessageOnToggleOverMethodName = "";
		base..ctor();
	}

	// Token: 0x0400266F RID: 9839
	public GameObject upStateGO;

	// Token: 0x04002670 RID: 9840
	public GameObject downStateGO;

	// Token: 0x04002671 RID: 9841
	public GameObject hoverOverStateGO;

	// Token: 0x04002672 RID: 9842
	[SerializeField]
	private bool useOnReleaseInsteadOfOnUp;

	// Token: 0x04002673 RID: 9843
	private bool isDown;

	// Token: 0x04002674 RID: 9844
	private bool isHover;

	// Token: 0x04002675 RID: 9845
	public string SendMessageOnToggleOverMethodName;
}
