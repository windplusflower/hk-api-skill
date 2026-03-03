using System;
using JetBrains.Annotations;

namespace Modding.Patches
{
	/// <inheritdoc />
	/// <summary>
	/// MonoMod attribute for replacing a method call
	/// </summary>
	// Token: 0x02000DAA RID: 3498
	[UsedImplicitly]
	internal class ReplaceMethodAttribute : Attribute
	{
		/// <inheritdoc />
		/// <summary>
		/// Replace method call with alternate method call
		/// </summary>
		// Token: 0x0600488D RID: 18573 RVA: 0x0018928B File Offset: 0x0018748B
		public ReplaceMethodAttribute(string type1, string method1, string[] params1, string type2, string method2, string[] params2)
		{
		}
	}
}
