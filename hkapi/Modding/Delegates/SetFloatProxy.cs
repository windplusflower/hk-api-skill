using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to set a float
	/// </summary>
	/// <param name="name">The field being set</param>
	/// <param name="orig">The original value the float was being set to</param>
	/// <returns>The modified value of the set</returns>
	// Token: 0x02000DE9 RID: 3561
	// (Invoke) Token: 0x0600498F RID: 18831
	public delegate float SetFloatProxy(string name, float orig);
}
