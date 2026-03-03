using System;
using System.Collections.Generic;

namespace Modding
{
	/// <summary>
	/// Interface which signifies that this mod will register a menu in the mod list.
	/// </summary>
	// Token: 0x02000D60 RID: 3424
	public interface IMenuMod : IMod, ILogger
	{
		/// <summary>
		/// Will the toggle button (for an ITogglableMod) be inside the returned menu screen.
		/// If this is set, an `ITogglableMod` will not create the toggle entry in the main menu.
		/// </summary>
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060046A5 RID: 18085
		bool ToggleButtonInsideMenu { get; }

		/// <summary>
		/// Gets the data for the custom menu.
		/// </summary>
		/// <remarks>
		/// The implementor of this method will need to add the `toggleButtonEntry`
		/// if they want it to appear in their menu. The mod loader will not add it automatically.
		/// </remarks>
		/// <param name="toggleButtonEntry">
		/// An entry representing the mod toggle button.
		/// This will be null if `ToggleButtonInsideMenu` is false or the mod is not an `ITogglableMod`.
		/// </param>
		/// <returns></returns>
		// Token: 0x060046A6 RID: 18086
		List<IMenuMod.MenuEntry> GetMenuData(IMenuMod.MenuEntry? toggleButtonEntry);

		/// <summary>
		/// A struct representing a menu option.
		/// </summary>
		// Token: 0x02000D61 RID: 3425
		public struct MenuEntry
		{
			/// <summary>
			/// Creates a new menu entry.
			/// </summary>
			// Token: 0x060046A7 RID: 18087 RVA: 0x00180723 File Offset: 0x0017E923
			public MenuEntry(string name, string[] values, string description, Action<int> saver, Func<int> loader)
			{
				this.Name = name;
				this.Description = description;
				this.Values = values;
				this.Saver = saver;
				this.Loader = loader;
			}

			/// <summary>
			/// The name of the setting.
			/// </summary>
			// Token: 0x04004B69 RID: 19305
			public string Name;

			/// <summary>
			/// The description of the setting. May be null.
			/// </summary>
			// Token: 0x04004B6A RID: 19306
			public string Description;

			/// <summary>
			/// The values to display for the setting.
			/// </summary>
			// Token: 0x04004B6B RID: 19307
			public string[] Values;

			/// <summary>
			/// A function to take the current value index and save it.
			/// </summary>
			// Token: 0x04004B6C RID: 19308
			public Action<int> Saver;

			/// <summary>
			/// A function to get the saved data and convert it into a value index.
			/// </summary>
			// Token: 0x04004B6D RID: 19309
			public Func<int> Loader;
		}
	}
}
