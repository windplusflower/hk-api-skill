using System;

namespace Modding
{
	/// <summary>
	/// An interface that signifies that the mod will save global data.
	/// </summary>
	/// <typeparam name="S">The type representing the settings.</typeparam>
	// Token: 0x02000D85 RID: 3461
	public interface IGlobalSettings<S>
	{
		/// <summary>
		/// Called when the mod just loaded the global settings.
		/// </summary>
		/// <param name="s">The settings the mod loaded.</param>
		// Token: 0x060047EC RID: 18412
		void OnLoadGlobal(S s);

		/// <summary>
		/// Called when the mod needs to save the global settings.
		/// </summary>
		/// <returns>The settings to be stored.</returns>
		// Token: 0x060047ED RID: 18413
		S OnSaveGlobal();
	}
}
