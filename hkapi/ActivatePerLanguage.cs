using System;
using Language;
using UnityEngine;

// Token: 0x020002C6 RID: 710
public class ActivatePerLanguage : MonoBehaviour
{
	// Token: 0x06000EFC RID: 3836 RVA: 0x00049D7C File Offset: 0x00047F7C
	private void Start()
	{
		LanguageCode languageCode = Language.CurrentLanguage();
		foreach (ActivatePerLanguage.LangBoolPair langBoolPair in this.languages)
		{
			if (langBoolPair.language == languageCode)
			{
				if (this.target)
				{
					this.target.SetActive(langBoolPair.activate);
				}
				if (this.alt)
				{
					this.alt.SetActive(!langBoolPair.activate);
				}
				return;
			}
		}
		this.target.SetActive(this.defaultActivation);
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00049E06 File Offset: 0x00048006
	public ActivatePerLanguage()
	{
		this.defaultActivation = true;
		base..ctor();
	}

	// Token: 0x04000FB9 RID: 4025
	public GameObject target;

	// Token: 0x04000FBA RID: 4026
	public GameObject alt;

	// Token: 0x04000FBB RID: 4027
	[Space]
	public ActivatePerLanguage.LangBoolPair[] languages;

	// Token: 0x04000FBC RID: 4028
	[Space]
	public bool defaultActivation;

	// Token: 0x020002C7 RID: 711
	[Serializable]
	public struct LangBoolPair
	{
		// Token: 0x04000FBD RID: 4029
		public LanguageCode language;

		// Token: 0x04000FBE RID: 4030
		public bool activate;
	}
}
