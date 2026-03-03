using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to get a string
	/// </summary>
	/// <param name="name">The name of the field</param>
	/// <param name="res">The original value of the field</param>
	/// <returns>The modified value of the get</returns>
	// Token: 0x02000DEA RID: 3562
	// (Invoke) Token: 0x06004993 RID: 18835
	public delegate string GetStringProxy(string name, string res);
}
