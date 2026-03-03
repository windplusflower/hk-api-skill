using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InControl.Internal
{
	// Token: 0x0200073B RID: 1851
	public class CodeWriter
	{
		// Token: 0x06002E9B RID: 11931 RVA: 0x000F7EF5 File Offset: 0x000F60F5
		public CodeWriter()
		{
			this.indent = 0;
			this.stringBuilder = new StringBuilder(4096);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000F7F14 File Offset: 0x000F6114
		public void IncreaseIndent()
		{
			this.indent++;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000F7F24 File Offset: 0x000F6124
		public void DecreaseIndent()
		{
			this.indent--;
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000F7F34 File Offset: 0x000F6134
		public void Append(string code)
		{
			this.Append(false, code);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000F7F40 File Offset: 0x000F6140
		public void Append(bool trim, string code)
		{
			if (trim)
			{
				code = code.Trim();
			}
			string[] array = Regex.Split(code, "\\r?\\n|\\n");
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string text = array[i];
				if (!text.All(new Func<char, bool>(char.IsWhiteSpace)))
				{
					this.stringBuilder.Append('\t', this.indent);
					this.stringBuilder.Append(text);
				}
				if (i < num - 1)
				{
					this.stringBuilder.Append('\n');
				}
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000F7FC3 File Offset: 0x000F61C3
		public void AppendLine(string code)
		{
			this.Append(code);
			this.stringBuilder.Append('\n');
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000F7FDA File Offset: 0x000F61DA
		public void AppendLine(int count)
		{
			this.stringBuilder.Append('\n', count);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000F7FEB File Offset: 0x000F61EB
		public void AppendFormat(string format, params object[] args)
		{
			this.Append(string.Format(format, args));
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000F7FFA File Offset: 0x000F61FA
		public void AppendLineFormat(string format, params object[] args)
		{
			this.AppendLine(string.Format(format, args));
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000F8009 File Offset: 0x000F6209
		public override string ToString()
		{
			return this.stringBuilder.ToString();
		}

		// Token: 0x0400330B RID: 13067
		private const char newLine = '\n';

		// Token: 0x0400330C RID: 13068
		private int indent;

		// Token: 0x0400330D RID: 13069
		private readonly StringBuilder stringBuilder;
	}
}
