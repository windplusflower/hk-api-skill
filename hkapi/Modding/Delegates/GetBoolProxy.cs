using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to get a bool
	/// </summary>
	/// <param name="name">The field being gotten</param>
	/// <param name="orig">The original value of the bool</param>
	/// <returns>The bool, if you are overriding it, otherwise orig.</returns>
	// Token: 0x02000DE4 RID: 3556
	// (Invoke) Token: 0x0600497B RID: 18811
	public delegate bool GetBoolProxy(string name, bool orig);
}
