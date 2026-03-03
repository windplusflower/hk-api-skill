using System;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x020004BC RID: 1212
public class SetTextMeshProGameText : MonoBehaviour
{
	// Token: 0x06001AC8 RID: 6856 RVA: 0x0007FD9C File Offset: 0x0007DF9C
	private void Awake()
	{
		this.textMesh = base.GetComponent<TextMeshPro>();
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x0007FDAA File Offset: 0x0007DFAA
	private void Start()
	{
		this.UpdateText();
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x0007FDB4 File Offset: 0x0007DFB4
	public void UpdateText()
	{
		if (this.textMesh)
		{
			this.textMesh.text = Language.Get(this.convName, this.sheetName);
			string text = this.textMesh.text;
			text = text.Replace("<br>", "\n");
			this.textMesh.text = text;
		}
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0007FDAA File Offset: 0x0007DFAA
	private void ChangedLanguage(LanguageCode code)
	{
		this.UpdateText();
	}

	// Token: 0x0400201C RID: 8220
	private TextMeshPro textMesh;

	// Token: 0x0400201D RID: 8221
	public string sheetName;

	// Token: 0x0400201E RID: 8222
	public string convName;
}
