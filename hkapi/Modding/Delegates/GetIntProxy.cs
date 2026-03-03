using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to get an int
	/// </summary>
	/// <param name="name">The field being gotten</param>
	/// <param name="orig">The original value of the field</param>
	/// <returns>The int, if overridden, else orig.</returns>
	// Token: 0x02000DE6 RID: 3558
	// (Invoke) Token: 0x06004983 RID: 18819
	public delegate int GetIntProxy(string name, int orig);
}
