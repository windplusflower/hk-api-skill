using System;

namespace TMPro
{
	// Token: 0x0200063B RID: 1595
	public struct TMP_LinkInfo
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x000C8734 File Offset: 0x000C6934
		internal void SetLinkID(char[] text, int startIndex, int length)
		{
			if (this.linkID == null || this.linkID.Length < length)
			{
				this.linkID = new char[length];
			}
			for (int i = 0; i < length; i++)
			{
				this.linkID[i] = text[startIndex + i];
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000C877C File Offset: 0x000C697C
		public string GetLinkText()
		{
			string text = string.Empty;
			TMP_TextInfo textInfo = this.textComponent.textInfo;
			for (int i = this.linkTextfirstCharacterIndex; i < this.linkTextfirstCharacterIndex + this.linkTextLength; i++)
			{
				text += textInfo.characterInfo[i].character.ToString();
			}
			return text;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000C87D6 File Offset: 0x000C69D6
		public string GetLinkID()
		{
			if (this.textComponent == null)
			{
				return string.Empty;
			}
			return new string(this.linkID, 0, this.linkIdLength);
		}

		// Token: 0x04002A79 RID: 10873
		public TMP_Text textComponent;

		// Token: 0x04002A7A RID: 10874
		public int hashCode;

		// Token: 0x04002A7B RID: 10875
		public int linkIdFirstCharacterIndex;

		// Token: 0x04002A7C RID: 10876
		public int linkIdLength;

		// Token: 0x04002A7D RID: 10877
		public int linkTextfirstCharacterIndex;

		// Token: 0x04002A7E RID: 10878
		public int linkTextLength;

		// Token: 0x04002A7F RID: 10879
		internal char[] linkID;
	}
}
