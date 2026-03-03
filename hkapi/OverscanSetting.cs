using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004A8 RID: 1192
public class OverscanSetting : MonoBehaviour
{
	// Token: 0x06001A80 RID: 6784 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
	private void Start()
	{
		this.gs = GameManager.instance.gameSettings;
		this.textUI.text = this.slider.value.ToString();
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x0007F2E4 File Offset: 0x0007D4E4
	public void UpdateValue()
	{
		this.textUI.text = this.slider.value.ToString();
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0007F30F File Offset: 0x0007D50F
	public void UpdateTextValue(float value)
	{
		this.textUI.text = value.ToString();
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x0007F324 File Offset: 0x0007D524
	public void SetOverscan(float value)
	{
		float overscan = value * 0.01f;
		GameCameras.instance.SetOverscan(overscan);
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x0007F344 File Offset: 0x0007D544
	public void RefreshValueFromSettings()
	{
		if (this.gs == null)
		{
			this.gs = GameManager.instance.gameSettings;
		}
		this.slider.value = this.gs.overScanAdjustment * 100f;
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x0007F37C File Offset: 0x0007D57C
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

	// Token: 0x06001A86 RID: 6790 RVA: 0x0007F3E4 File Offset: 0x0007D5E4
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

	// Token: 0x04001FE5 RID: 8165
	private GameSettings gs;

	// Token: 0x04001FE6 RID: 8166
	public Slider slider;

	// Token: 0x04001FE7 RID: 8167
	public MenuButton doneButton;

	// Token: 0x04001FE8 RID: 8168
	public MenuButton backButton;

	// Token: 0x04001FE9 RID: 8169
	public Text textUI;

	// Token: 0x04001FEA RID: 8170
	public float value;
}
