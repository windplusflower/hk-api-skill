using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F8 RID: 504
[ExecuteInEditMode]
[RequireComponent(typeof(Text))]
public class FixVerticalAlign : MonoBehaviour
{
	// Token: 0x06000AE9 RID: 2793 RVA: 0x00039F90 File Offset: 0x00038190
	private void OnEnable()
	{
		if (this.labelFixType == FixVerticalAlign.LabelFixType.Normal)
		{
			this.AlignText();
			return;
		}
		if (this.labelFixType == FixVerticalAlign.LabelFixType.KeyMap)
		{
			this.AlignTextKeymap();
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00039F90 File Offset: 0x00038190
	private void Start()
	{
		if (this.labelFixType == FixVerticalAlign.LabelFixType.Normal)
		{
			this.AlignText();
			return;
		}
		if (this.labelFixType == FixVerticalAlign.LabelFixType.KeyMap)
		{
			this.AlignTextKeymap();
		}
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00039FB0 File Offset: 0x000381B0
	public void AlignText()
	{
		this.text = base.GetComponent<Text>();
		if (!string.IsNullOrEmpty(this.text.text))
		{
			if (this.text.text[this.text.text.Length - 1] != '\n')
			{
				Text text = this.text;
				text.text += "\n";
			}
			this.text.lineSpacing = -0.33f;
		}
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0003A02C File Offset: 0x0003822C
	public void AlignTextKeymap()
	{
		this.text = base.GetComponent<Text>();
		if (!string.IsNullOrEmpty(this.text.text))
		{
			if (this.text.text[this.text.text.Length - 1] != '\n')
			{
				Text text = this.text;
				text.text += "\n";
			}
			this.text.lineSpacing = -0.05f;
		}
	}

	// Token: 0x04000BF4 RID: 3060
	private Text text;

	// Token: 0x04000BF5 RID: 3061
	public FixVerticalAlign.LabelFixType labelFixType;

	// Token: 0x020001F9 RID: 505
	public enum LabelFixType
	{
		// Token: 0x04000BF7 RID: 3063
		Normal,
		// Token: 0x04000BF8 RID: 3064
		KeyMap
	}
}
