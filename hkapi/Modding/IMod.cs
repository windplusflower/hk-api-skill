using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Modding
{
	/// <inheritdoc />
	/// <summary>
	///     Base interface for Mods
	/// </summary>
	// Token: 0x02000D64 RID: 3428
	public interface IMod : ILogger
	{
		/// <summary>
		///     Get's the Mod's Name
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046AA RID: 18090
		string GetName();

		/// <summary>
		///     Returns the objects to preload in order for the mod to work.
		/// </summary>
		/// <returns>A List of tuples containing scene name, object name</returns>
		// Token: 0x060046AB RID: 18091
		List<ValueTuple<string, string>> GetPreloadNames();

		/// <summary>
		/// A list of requested scenes to be preloaded and actions to execute on loading of those scenes
		/// </summary>
		/// <returns>List of tuples containg scene names and the respective actions.</returns>
		// Token: 0x060046AC RID: 18092
		ValueTuple<string, Func<IEnumerator>>[] PreloadSceneHooks();

		/// <summary>
		///     Called after preloading of all mods.
		/// </summary>
		/// <param name="preloadedObjects">The preloaded objects relevant to this <see cref="T:Modding.Mod" /></param>
		// Token: 0x060046AD RID: 18093
		void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects);

		/// <summary>
		///     Returns version of Mod
		/// </summary>
		/// <returns>Mod Version</returns>
		// Token: 0x060046AE RID: 18094
		string GetVersion();

		/// <summary>
		///     Controls when this mod should load compared to other mods.  Defaults to ordered by name.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046AF RID: 18095
		int LoadPriority();

		/// <summary>
		///     Returns the text that should be displayed on the mod menu button, if there is one.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046B0 RID: 18096
		string GetMenuButtonText();
	}
}
