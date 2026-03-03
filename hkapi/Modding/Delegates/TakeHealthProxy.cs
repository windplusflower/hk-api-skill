using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when health is taken from the player
	/// </summary>
	/// <param name="damage">Amount of Damage</param>
	/// <returns>Modified Damaged</returns>
	// Token: 0x02000DF1 RID: 3569
	// (Invoke) Token: 0x060049AF RID: 18863
	public delegate int TakeHealthProxy(int damage);
}
