using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called at the end of the take damage function
	/// </summary>
	/// <param name="hazardType"></param>
	/// <param name="damageAmount"></param>
	// Token: 0x02000DDD RID: 3549
	// (Invoke) Token: 0x0600495F RID: 18783
	public delegate int AfterTakeDamageHandler(int hazardType, int damageAmount);
}
