using System;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C8 RID: 712
public class AutoLocalizeTextUI : MonoBehaviour
{
	// Token: 0x06000EFE RID: 3838 RVA: 0x00049E15 File Offset: 0x00048015
	private void Awake()
	{
		this.textAligner = base.GetComponent<FixVerticalAlign>();
		if (this.textAligner)
		{
			this.hasTextAligner = true;
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00049E37 File Offset: 0x00048037
	private void OnEnable()
	{
		this.gm = GameManager.instance;
		if (this.gm)
		{
			this.gm.RefreshLanguageText += this.RefreshTextFromLocalization;
		}
		this.RefreshTextFromLocalization();
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00049E6E File Offset: 0x0004806E
	private void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.RefreshLanguageText -= this.RefreshTextFromLocalization;
		}
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00049E98 File Offset: 0x00048098
	public void RefreshTextFromLocalization()
	{
		string text = Language.Get(this.textKey, this.sheetTitle);
		text = text.Replace("\\n", Environment.NewLine);
		text = text.Replace("<br>", Environment.NewLine);
		this.textField.text = text;
		if (this.hasTextAligner)
		{
			this.textAligner.AlignText();
		}
	}

	// Token: 0x04000FBF RID: 4031
	[Tooltip("UI Text component to place text.")]
	public Text textField;

	// Token: 0x04000FC0 RID: 4032
	[Tooltip("The page name to reference the text from.")]
	public string sheetTitle;

	// Token: 0x04000FC1 RID: 4033
	[Tooltip("The key to look up.")]
	public string textKey;

	// Token: 0x04000FC2 RID: 4034
	private GameManager gm;

	// Token: 0x04000FC3 RID: 4035
	private FixVerticalAlign textAligner;

	// Token: 0x04000FC4 RID: 4036
	private bool hasTextAligner;
}
