using System;

namespace Modding
{
	/// <summary>
	/// An interface that signifies that the mod will save data into a save file.
	/// </summary>
	/// <typeparam name="S">The type representing the settings.</typeparam>
	// Token: 0x02000D84 RID: 3460
	public interface ILocalSettings<S>
	{
		/// <summary>
		/// Called when the mod just loaded the save data.
		/// </summary>
		/// <param name="s">The settings the mod loaded.</param>
		// Token: 0x060047EA RID: 18410
		void OnLoadLocal(S s);

		/// <summary>
		/// Called when the mod needs to save data.
		/// </summary>
		/// <returns>The settings to be stored.</returns>
		// Token: 0x060047EB RID: 18411
		S OnSaveLocal();
	}
}
