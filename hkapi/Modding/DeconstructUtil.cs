using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Modding
{
	/// <summary>
	/// Used for Deconstruct when not given by .NET 
	/// </summary>
	// Token: 0x02000D5E RID: 3422
	[PublicAPI]
	public static class DeconstructUtil
	{
		/// <summary>
		/// Deconstructs a KeyValuePair into key and value
		/// </summary>
		/// <param name="self">The KeyValuePair</param>
		/// <param name="key">Output key</param>
		/// <param name="value">Output value</param>
		/// <typeparam name="TKey">Type of KeyValuePair Key</typeparam>
		/// <typeparam name="TValue">Type of KeyValuePair Value</typeparam>
		// Token: 0x0600469A RID: 18074 RVA: 0x00180707 File Offset: 0x0017E907
		public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> self, out TKey key, out TValue value)
		{
			key = self.Key;
			value = self.Value;
		}
	}
}
