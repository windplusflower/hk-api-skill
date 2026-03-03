using System;
using InControl;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000448 RID: 1096
[RequireComponent(typeof(Text))]
public class ControllerButtonLabel : MonoBehaviour
{
	// Token: 0x060018A0 RID: 6304 RVA: 0x000735F2 File Offset: 0x000717F2
	private void Awake()
	{
		this.ih = GameManager.instance.inputHandler;
		this.ui = UIManager.instance;
		this.buttonText = base.GetComponent<Text>();
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x0007361B File Offset: 0x0007181B
	private void OnEnable()
	{
		if (!string.IsNullOrEmpty(this.overrideLabelKey))
		{
			this.buttonText.text = Language.Get(this.overrideLabelKey, "MainMenu");
			return;
		}
		this.ShowCurrentBinding();
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x0007364C File Offset: 0x0007184C
	private void ShowCurrentBinding()
	{
		this.buttonText.text = "+";
		if (this.controllerButton == InputControlType.None)
		{
			this.buttonText.text = Language.Get("CTRL_UNMAPPED", "MainMenu");
			return;
		}
		PlayerAction playerAction = this.ih.GetActionForMappableControllerButton(this.controllerButton);
		if (playerAction != null)
		{
			this.buttonText.text = Language.Get(this.ih.ActionButtonLocalizedKey(playerAction), "MainMenu");
			return;
		}
		playerAction = this.ih.GetActionForDefaultControllerButton(this.controllerButton);
		if (playerAction != null)
		{
			this.buttonText.text = Language.Get(this.ih.ActionButtonLocalizedKey(playerAction), "MainMenu");
			return;
		}
		this.buttonText.text = Language.Get("CTRL_UNMAPPED", "MainMenu");
	}

	// Token: 0x04001D81 RID: 7553
	[Header("Button Text")]
	private Text buttonText;

	// Token: 0x04001D82 RID: 7554
	[Header("Button Label")]
	public string overrideLabelKey;

	// Token: 0x04001D83 RID: 7555
	[Header("Button Mapping")]
	public InputControlType controllerButton;

	// Token: 0x04001D84 RID: 7556
	private InputHandler ih;

	// Token: 0x04001D85 RID: 7557
	private UIManager ui;
}
