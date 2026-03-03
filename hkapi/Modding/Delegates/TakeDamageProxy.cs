using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when damage is dealt to the player
	/// </summary>
	/// <param name="hazardType">The type of hazard that caused the damage.</param>
	/// <param name="damage">Amount of Damage</param>
	/// <returns>Modified Damage</returns>
	// Token: 0x02000DF0 RID: 3568
	// (Invoke) Token: 0x060049AB RID: 18859
	public delegate int TakeDamageProxy(ref int hazardType, int damage);
}
