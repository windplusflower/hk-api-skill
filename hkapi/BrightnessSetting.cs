using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000439 RID: 1081
public class BrightnessSetting : MonoBehaviour
{
	// Token: 0x0600185C RID: 6236 RVA: 0x00072585 File Offset: 0x00070785
	private void Start()
	{
		this.gs = GameManager.instance.gameSettings;
		this.UpdateValue();
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x000725A0 File Offset: 0x000707A0
	public void UpdateValue()
	{
		this.textUI.text = (this.slider.value * this.valueMultiplier).ToString() + "%";
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x000725DC File Offset: 0x000707DC
	public void UpdateTextValue(float value)
	{
		this.textUI.text = (value * this.valueMultiplier).ToString() + "%";
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x0007260E File Offset: 0x0007080E
	public void SetBrightness(float value)
	{
		GameCameras.instance.brightnessEffect.SetBrightness(value / 20f);
		this.gs.brightnessAdjustment = value;
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x00072634 File Offset: 0x00070834
	public void RefreshValueFromSettings()
	{
		if (this.gs == null)
		{
			this.gs = GameManager.instance.gameSettings;
		}
		this.slider.value = this.gs.brightnessAdjustment;
		this.slider.onValueChanged.Invoke(this.slider.value);
		this.UpdateValue();
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x00072690 File Offset: 0x00070890
	public void DoneMode()
	{
		this.doneButton.gameObject.SetActive(true);
		this.backButton.gameObject.SetActive(false);
		this.slider.navigation = new Navigation
		{
			mode = Navigation.Mode.Explicit,
			selectOnDown = this.doneButton,
			selectOnUp = this.doneButton
		};
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x000726F8 File Offset: 0x000708F8
	public void NormalMode()
	{
		this.doneButton.gameObject.SetActive(false);
		this.backButton.gameObject.SetActive(true);
		this.slider.navigation = new Navigation
		{
			mode = Navigation.Mode.Explicit,
			selectOnDown = this.backButton,
			selectOnUp = this.backButton
		};
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x0007275D File Offset: 0x0007095D
	public BrightnessSetting()
	{
		this.valueMultiplier = 5f;
		base..ctor();
	}

	// Token: 0x04001D24 RID: 7460
	private GameSettings gs;

	// Token: 0x04001D25 RID: 7461
	private float valueMultiplier;

	// Token: 0x04001D26 RID: 7462
	public Slider slider;

	// Token: 0x04001D27 RID: 7463
	public MenuButton doneButton;

	// Token: 0x04001D28 RID: 7464
	public MenuButton backButton;

	// Token: 0x04001D29 RID: 7465
	public Text textUI;
}
