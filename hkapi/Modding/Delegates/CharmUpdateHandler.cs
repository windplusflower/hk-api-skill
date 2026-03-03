using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called after player values for charms have been set
	/// </summary>
	/// <param name="data">Current PlayerData</param>
	/// <param name="controller">Current HeroController</param>
	// Token: 0x02000DDC RID: 3548
	// (Invoke) Token: 0x0600495B RID: 18779
	public delegate void CharmUpdateHandler(PlayerData data, HeroController controller);
}
