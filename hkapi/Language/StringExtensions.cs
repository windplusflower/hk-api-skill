using System;

namespace Language
{
	// Token: 0x020006AD RID: 1709
	public static class StringExtensions
	{
		// Token: 0x06002895 RID: 10389 RVA: 0x000E4804 File Offset: 0x000E2A04
		public static string UnescapeXML(this string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			return s.Replace("&apos;", "'").Replace("&quot;", "\"").Replace("&gt;", ">").Replace("&lt;", "<").Replace("&amp;", "&");
		}
	}
}
