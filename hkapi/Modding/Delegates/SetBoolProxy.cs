using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when anything in the game tries to set a bool
	/// </summary>
	/// <param name="name">The field being set</param>
	/// <param name="orig">The original value the bool was being set to</param>
	/// <returns>The bool, if overridden, else orig.</returns>
	// Token: 0x02000DE5 RID: 3557
	// (Invoke) Token: 0x0600497F RID: 18815
	public delegate bool SetBoolProxy(string name, bool orig);
}
