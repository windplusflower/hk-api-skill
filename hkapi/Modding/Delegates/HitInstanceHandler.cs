using System;
using HutongGames.PlayMaker;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when a HitInstance is created in TakeDamage. The hit instance returned defines the hit behavior that will
	///     happen. Overrides default behavior
	/// </summary>
	// Token: 0x02000DDF RID: 3551
	// (Invoke) Token: 0x06004967 RID: 18791
	public delegate HitInstance HitInstanceHandler(Fsm owner, HitInstance hit);
}
