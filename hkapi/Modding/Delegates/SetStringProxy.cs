using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to set a string
	/// </summary>
	/// <param name="name">The name of the field</param>
	/// <param name="res">The original set value of the string</param>
	/// <returns>The modified value of the set</returns>
	// Token: 0x02000DEB RID: 3563
	// (Invoke) Token: 0x06004997 RID: 18839
	public delegate string SetStringProxy(string name, string res);
}
