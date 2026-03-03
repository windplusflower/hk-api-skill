using System;

namespace Modding
{
	/// <summary>
	/// Interface which signifies that this mod will register a custom menu in the mod list.
	/// </summary>
	// Token: 0x02000D62 RID: 3426
	public interface ICustomMenuMod : IMod, ILogger
	{
		/// <summary>
		/// Will the toggle button (for an ITogglableMod) be inside the returned menu screen.
		/// If this is set, an `ITogglableMod` will not create the toggle entry in the main menu.
		/// </summary>
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060046A8 RID: 18088
		bool ToggleButtonInsideMenu { get; }

		/// <summary>
		/// Gets the built menu screen.
		/// </summary>
		/// <param name="modListMenu">The menu screen that is the mod list menu.</param>
		/// <param name="toggleDelegates">
		/// The delegates used for toggling the mod.
		/// This will be null if `ToggleButtonInsideMenu` is false or the mod is not an `ITogglableMod`.
		/// </param>
		/// <remarks>
		/// The implementor of this method will need to add an option using `toggleDelegates`
		/// if they want it to appear in their menu. The mod loader will not add it automatically.
		/// </remarks>
		/// <returns></returns>
		// Token: 0x060046A9 RID: 18089
		MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates);
	}
}
