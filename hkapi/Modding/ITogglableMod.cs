using System;

namespace Modding
{
	/// <inheritdoc />
	/// <summary>
	///     Interface which signifies that this mod can be loaded _and_ unloaded while in game. When re-initialized the mod
	///     will be passed null rather than preloading again.
	/// </summary>
	// Token: 0x02000D9E RID: 3486
	public interface ITogglableMod : IMod, ILogger
	{
		/// <summary>
		///     Called when the Mod is disabled or unloaded.  Ensure you unhook any events that you hooked up in the Initialize
		///     method.
		/// </summary>
		// Token: 0x06004876 RID: 18550
		void Unload();
	}
}
