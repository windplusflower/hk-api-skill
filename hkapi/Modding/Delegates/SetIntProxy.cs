using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to set an int
	/// </summary>
	/// <param name="name">The field which is being set</param>
	/// <param name="orig">The original value</param>
	/// <returns>The int if overrode, else null</returns>
	// Token: 0x02000DE7 RID: 3559
	// (Invoke) Token: 0x06004987 RID: 18823
	public delegate int SetIntProxy(string name, int orig);
}
