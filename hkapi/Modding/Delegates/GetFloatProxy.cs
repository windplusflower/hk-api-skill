using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to get a float
	/// </summary>
	/// <param name="name">The field being set</param>
	/// <param name="orig">The original value</param>
	/// <returns>The value, if overrode, else null.</returns>
	// Token: 0x02000DE8 RID: 3560
	// (Invoke) Token: 0x0600498B RID: 18827
	public delegate float GetFloatProxy(string name, float orig);
}
