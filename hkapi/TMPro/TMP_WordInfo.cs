using System;

namespace TMPro
{
	// Token: 0x0200063C RID: 1596
	public struct TMP_WordInfo
	{
		// Token: 0x06002633 RID: 9779 RVA: 0x000C8800 File Offset: 0x000C6A00
		public string GetWord()
		{
			string text = string.Empty;
			TMP_CharacterInfo[] characterInfo = this.textComponent.textInfo.characterInfo;
			for (int i = this.firstCharacterIndex; i < this.lastCharacterIndex + 1; i++)
			{
				text += characterInfo[i].character.ToString();
			}
			return text;
		}

		// Token: 0x04002A80 RID: 10880
		public TMP_Text textComponent;

		// Token: 0x04002A81 RID: 10881
		public int firstCharacterIndex;

		// Token: 0x04002A82 RID: 10882
		public int lastCharacterIndex;

		// Token: 0x04002A83 RID: 10883
		public int characterCount;
	}
}
