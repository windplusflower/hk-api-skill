using System;
using GlobalEnums;
using TMPro;
using UnityEngine;

// Token: 0x0200042E RID: 1070
[RequireComponent(typeof(SpriteRenderer))]
public abstract class ActionButtonIconBase : MonoBehaviour
{
	// Token: 0x14000038 RID: 56
	// (add) Token: 0x0600181A RID: 6170 RVA: 0x00071590 File Offset: 0x0006F790
	// (remove) Token: 0x0600181B RID: 6171 RVA: 0x000715C8 File Offset: 0x0006F7C8
	public event ActionButtonIconBase.IconUpdateEvent OnIconUpdate;

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x0600181C RID: 6172
	public abstract HeroActionButton Action { get; }

	// Token: 0x0600181D RID: 6173 RVA: 0x000715FD File Offset: 0x0006F7FD
	private void Awake()
	{
		this.sr = base.GetComponent<SpriteRenderer>();
		this.uibs = UIManager.instance.uiButtonSkins;
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x0007161C File Offset: 0x0006F81C
	protected virtual void OnEnable()
	{
		if (this.ih == null)
		{
			this.ih = GameManager.instance.inputHandler;
		}
		if (this.ih != null)
		{
			this.ih.RefreshActiveControllerEvent += this.RefreshController;
		}
		this.RefreshButtonIcon();
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00071672 File Offset: 0x0006F872
	protected virtual void OnDisable()
	{
		if (this.ih != null)
		{
			this.ih.RefreshActiveControllerEvent -= this.RefreshController;
		}
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x0007169C File Offset: 0x0006F89C
	protected void GetButtonIcon(HeroActionButton actionButton)
	{
		ButtonSkin buttonSkinFor = this.uibs.GetButtonSkinFor(actionButton);
		if (buttonSkinFor == null)
		{
			Debug.LogError("Couldn't get button skin for " + actionButton.ToString(), this);
			return;
		}
		this.sr.sprite = buttonSkinFor.sprite;
		if (this.textContainer != null)
		{
			if (buttonSkinFor.skinType == ButtonSkinType.BLANK)
			{
				this.textContainer.width = this.blnkWidth;
				this.textContainer.height = this.blnkHeight;
			}
			else if (buttonSkinFor.skinType == ButtonSkinType.SQUARE)
			{
				this.textContainer.width = this.sqrWidth;
				this.textContainer.height = this.sqrHeight;
			}
			else if (buttonSkinFor.skinType == ButtonSkinType.WIDE)
			{
				this.textContainer.width = this.wideWidth;
				this.textContainer.height = this.wideHeight;
			}
		}
		if (this.label != null)
		{
			if (buttonSkinFor.skinType == ButtonSkinType.BLANK)
			{
				this.label.fontSizeMin = this.blnkFontMin;
				this.label.fontSizeMax = this.blnkFontMax;
			}
			else if (buttonSkinFor.skinType == ButtonSkinType.SQUARE)
			{
				this.label.fontSizeMin = this.sqrFontMin;
				this.label.fontSizeMax = this.sqrFontMax;
			}
			else if (buttonSkinFor.skinType == ButtonSkinType.WIDE)
			{
				this.label.fontSizeMin = this.wideFontMin;
				this.label.fontSizeMax = this.wideFontMax;
			}
			this.label.text = buttonSkinFor.symbol;
		}
		if (this.OnIconUpdate != null)
		{
			this.OnIconUpdate();
		}
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x00071836 File Offset: 0x0006FA36
	public void RefreshController()
	{
		if (this.liveUpdate)
		{
			this.RefreshButtonIcon();
		}
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00071846 File Offset: 0x0006FA46
	public void RefreshButtonIcon()
	{
		this.GetButtonIcon(this.Action);
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x00071854 File Offset: 0x0006FA54
	protected ActionButtonIconBase()
	{
		this.blnkWidth = 1.685f;
		this.blnkHeight = 0.6f;
		this.blnkFontMax = 9.5f;
		this.blnkFontMin = 4f;
		this.sqrWidth = 0.7f;
		this.sqrHeight = 0.8f;
		this.sqrFontMax = 9.5f;
		this.sqrFontMin = 3.35f;
		this.wideWidth = 1.685f;
		this.wideHeight = 0.7f;
		this.wideFontMax = 9.5f;
		this.wideFontMin = 4f;
		base..ctor();
	}

	// Token: 0x04001CE6 RID: 7398
	[Header("Optional")]
	[Tooltip("This will update the button skin to reflect the currently active controller at all times.")]
	public bool liveUpdate;

	// Token: 0x04001CE7 RID: 7399
	public TextMeshPro label;

	// Token: 0x04001CE8 RID: 7400
	public TextContainer textContainer;

	// Token: 0x04001CE9 RID: 7401
	protected SpriteRenderer sr;

	// Token: 0x04001CEA RID: 7402
	private UIButtonSkins uibs;

	// Token: 0x04001CEB RID: 7403
	private InputHandler ih;

	// Token: 0x04001CEC RID: 7404
	private float blnkWidth;

	// Token: 0x04001CED RID: 7405
	private float blnkHeight;

	// Token: 0x04001CEE RID: 7406
	private float blnkFontMax;

	// Token: 0x04001CEF RID: 7407
	private float blnkFontMin;

	// Token: 0x04001CF0 RID: 7408
	private float sqrWidth;

	// Token: 0x04001CF1 RID: 7409
	private float sqrHeight;

	// Token: 0x04001CF2 RID: 7410
	private float sqrFontMax;

	// Token: 0x04001CF3 RID: 7411
	private float sqrFontMin;

	// Token: 0x04001CF4 RID: 7412
	private float wideWidth;

	// Token: 0x04001CF5 RID: 7413
	private float wideHeight;

	// Token: 0x04001CF6 RID: 7414
	private float wideFontMax;

	// Token: 0x04001CF7 RID: 7415
	private float wideFontMin;

	// Token: 0x0200042F RID: 1071
	// (Invoke) Token: 0x06001825 RID: 6181
	public delegate void IconUpdateEvent();
}
