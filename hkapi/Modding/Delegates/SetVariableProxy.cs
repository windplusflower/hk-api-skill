using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to set a generic variable
	/// </summary>
	/// <param name="type">The type of the variable</param>
	/// <param name="name">The name of the field being set</param>
	/// <param name="value">The original value the field was being set to</param>
	/// <returns>The new value of the field</returns>
	// Token: 0x02000DEF RID: 3567
	// (Invoke) Token: 0x060049A7 RID: 18855
	public delegate object SetVariableProxy(Type type, string name, object value);
}
