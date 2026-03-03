using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004C9 RID: 1225
public class UpdateTextWithSliderValue : MonoBehaviour
{
	// Token: 0x06001B40 RID: 6976 RVA: 0x00082FF4 File Offset: 0x000811F4
	private void Start()
	{
		this.textUI = base.GetComponent<Text>();
		this.textUI.text = this.slider.value.ToString();
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0008302C File Offset: 0x0008122C
	public void UpdateValue()
	{
		this.textUI.text = this.slider.value.ToString();
	}

	// Token: 0x040020B7 RID: 8375
	public Slider slider;

	// Token: 0x040020B8 RID: 8376
	private Text textUI;

	// Token: 0x040020B9 RID: 8377
	public float value;
}
