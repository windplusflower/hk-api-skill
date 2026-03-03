using System;
using JetBrains.Annotations;

namespace Modding.Patches
{
	/// <inheritdoc />
	/// <summary>
	/// MonoMod attribute for removing method call
	/// </summary>
	// Token: 0x02000DA9 RID: 3497
	[UsedImplicitly]
	public class RemoveMethodCall : Attribute
	{
		/// <inheritdoc />
		/// <summary>
		/// Remove call to method
		/// </summary>
		/// <param name="type">Type full name</param>
		/// <param name="method">Method name</param>
		// Token: 0x0600488C RID: 18572 RVA: 0x0018928B File Offset: 0x0018748B
		public RemoveMethodCall(string type, string method)
		{
		}
	}
}
