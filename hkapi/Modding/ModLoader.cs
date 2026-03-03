using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using UnityEngine;

namespace Modding
{
	/// <summary>
	///     Handles loading of mods.
	/// </summary>
	// Token: 0x02000D7C RID: 3452
	[PublicAPI]
	internal static class ModLoader
	{
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x00185562 File Offset: 0x00183762
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x00185569 File Offset: 0x00183769
		public static Dictionary<Type, ModLoader.ModInstance> ModInstanceTypeMap { get; private set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00185571 File Offset: 0x00183771
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00185578 File Offset: 0x00183778
		public static Dictionary<string, ModLoader.ModInstance> ModInstanceNameMap { get; private set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00185580 File Offset: 0x00183780
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00185587 File Offset: 0x00183787
		public static HashSet<ModLoader.ModInstance> ModInstances { get; private set; }

		/// <summary>
		/// Try to add a ModInstance to the internal dictionaries.
		/// </summary>
		/// <param name="ty">The type of the mod.</param>
		/// <param name="mod">The ModInstance.</param>
		/// <returns>True if the ModInstance was successfully added; false otherwise.</returns>
		// Token: 0x060047D4 RID: 18388 RVA: 0x00185590 File Offset: 0x00183790
		private static bool TryAddModInstance(Type ty, ModLoader.ModInstance mod)
		{
			if (ModLoader.ModInstanceNameMap.ContainsKey(mod.Name))
			{
				Logger.APILogger.LogWarn("Found multiple mods with name " + mod.Name + ".");
				mod.Error = new ModLoader.ModErrorState?(ModLoader.ModErrorState.Duplicate);
				ModLoader.ModInstanceNameMap[mod.Name].Error = new ModLoader.ModErrorState?(ModLoader.ModErrorState.Duplicate);
				ModLoader.ModInstanceTypeMap[ty] = mod;
				ModLoader.ModInstances.Add(mod);
				return false;
			}
			ModLoader.ModInstanceTypeMap[ty] = mod;
			ModLoader.ModInstanceNameMap[mod.Name] = mod;
			ModLoader.ModInstances.Add(mod);
			return true;
		}

		/// <summary>
		/// Starts the main loading of all mods.
		/// This loads assemblies, constructs and initializes mods, and creates the mod list menu.<br />
		/// This method should only be called once in the lifetime of the game.
		/// </summary>
		/// <param name="coroutineHolder"></param>
		/// <returns></returns>
		// Token: 0x060047D5 RID: 18389 RVA: 0x00185639 File Offset: 0x00183839
		public static IEnumerator LoadModsInit(GameObject coroutineHolder)
		{
			ModLoader.<LoadModsInit>d__16 <LoadModsInit>d__ = new ModLoader.<LoadModsInit>d__16(0);
			<LoadModsInit>d__.coroutineHolder = coroutineHolder;
			return <LoadModsInit>d__;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x00185648 File Offset: 0x00183848
		private static void GetPreloads(ModLoader.ModInstance[] orderedMods, List<string> scenes, [TupleElementNames(new string[]
		{
			null,
			"objectNames"
		})] Dictionary<string, List<ValueTuple<ModLoader.ModInstance, List<string>>>> toPreload, Dictionary<string, List<Func<IEnumerator>>> sceneHooks)
		{
			foreach (ModLoader.ModInstance modInstance in orderedMods)
			{
				if (modInstance.Error == null)
				{
					Logger.APILogger.LogDebug("Checking preloads for mod \"" + modInstance.Mod.GetName() + "\"");
					List<ValueTuple<string, string>> list = null;
					try
					{
						list = modInstance.Mod.GetPreloadNames();
					}
					catch (Exception ex)
					{
						Loggable apilogger = Logger.APILogger;
						string str = "Error getting preload names for mod ";
						string name = modInstance.Name;
						string str2 = "\n";
						Exception ex2 = ex;
						apilogger.LogError(str + name + str2 + ((ex2 != null) ? ex2.ToString() : null));
					}
					try
					{
						foreach (ValueTuple<string, Func<IEnumerator>> valueTuple in modInstance.Mod.PreloadSceneHooks())
						{
							string item = valueTuple.Item1;
							Func<IEnumerator> item2 = valueTuple.Item2;
							List<Func<IEnumerator>> list2;
							if (!sceneHooks.TryGetValue(item, out list2))
							{
								list2 = (sceneHooks[item] = new List<Func<IEnumerator>>());
							}
							list2.Add(item2);
						}
					}
					catch (Exception ex3)
					{
						Loggable apilogger2 = Logger.APILogger;
						string str3 = "Error getting preload hooks for mod ";
						string name2 = modInstance.Name;
						string str4 = "\n";
						Exception ex4 = ex3;
						apilogger2.LogError(str3 + name2 + str4 + ((ex4 != null) ? ex4.ToString() : null));
					}
					if (list != null)
					{
						Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
						foreach (ValueTuple<string, string> valueTuple2 in list)
						{
							string item3 = valueTuple2.Item1;
							string item4 = valueTuple2.Item2;
							if (string.IsNullOrEmpty(item3) || string.IsNullOrEmpty(item4))
							{
								Logger.APILogger.LogWarn("Mod `" + modInstance.Mod.GetName() + "` passed null values to preload");
							}
							else if (!scenes.Contains(item3))
							{
								Logger.APILogger.LogWarn(string.Concat(new string[]
								{
									"Mod `",
									modInstance.Mod.GetName(),
									"` attempted preload from non-existent scene `",
									item3,
									"`"
								}));
							}
							else
							{
								List<string> list3;
								if (!dictionary.TryGetValue(item3, out list3))
								{
									list3 = new List<string>();
									dictionary[item3] = list3;
								}
								Logger.APILogger.LogFine(string.Concat(new string[]
								{
									"Found object `",
									item3,
									".",
									item4,
									"`"
								}));
								list3.Add(item4);
							}
						}
						foreach (KeyValuePair<string, List<string>> self in dictionary)
						{
							string text;
							List<string> list4;
							self.Deconstruct(out text, out list4);
							string text2 = text;
							List<string> list5 = list4;
							List<ValueTuple<ModLoader.ModInstance, List<string>>> list6;
							if (!toPreload.TryGetValue(text2, out list6))
							{
								list6 = new List<ValueTuple<ModLoader.ModInstance, List<string>>>();
								toPreload[text2] = list6;
							}
							Logger.APILogger.LogFine(string.Format("`{0}` preloads {1} objects in the `{2}` scene", modInstance.Name, list5.Count, text2));
							list6.Add(new ValueTuple<ModLoader.ModInstance, List<string>>(modInstance, list5));
							toPreload[text2] = list6;
						}
					}
				}
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x001859A8 File Offset: 0x00183BA8
		private static void UpdateModText()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Modding API: " + ModHooks.ModVersion);
			foreach (ModLoader.ModInstance modInstance in ModLoader.ModInstances)
			{
				ModLoader.ModErrorState? error = modInstance.Error;
				if (error != null)
				{
					switch (error.GetValueOrDefault())
					{
					case ModLoader.ModErrorState.Construct:
						stringBuilder.AppendLine(modInstance.Name + " : Failed to call constructor! Check ModLog.txt");
						break;
					case ModLoader.ModErrorState.Duplicate:
						stringBuilder.AppendLine(modInstance.Name + " : Failed to load! Duplicate mod detected");
						break;
					case ModLoader.ModErrorState.Initialize:
						stringBuilder.AppendLine(modInstance.Name + " : Failed to initialize! Check ModLog.txt");
						break;
					case ModLoader.ModErrorState.Unload:
						stringBuilder.AppendLine(modInstance.Name + " : Failed to unload! Check ModLog.txt");
						break;
					default:
						throw new ArgumentOutOfRangeException();
					}
				}
				else if (modInstance.Enabled)
				{
					stringBuilder.AppendLine(modInstance.Name + " : " + modInstance.Mod.GetVersionSafe("ERROR"));
				}
			}
			ModLoader.modVersionDraw.drawString = stringBuilder.ToString();
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00185AFC File Offset: 0x00183CFC
		internal static void LoadMod(ModLoader.ModInstance mod, bool updateModText = true, Dictionary<string, Dictionary<string, GameObject>> preloadedObjects = null)
		{
			try
			{
				if (mod != null && !mod.Enabled)
				{
					ModLoader.ModErrorState? error = mod.Error;
					if (error == null)
					{
						mod.Enabled = true;
						mod.Mod.Initialize(preloadedObjects);
					}
				}
			}
			catch (Exception arg)
			{
				mod.Error = new ModLoader.ModErrorState?(ModLoader.ModErrorState.Initialize);
				Logger.APILogger.LogError(string.Format("Failed to load Mod `{0}`\n{1}", mod.Mod.GetName(), arg));
			}
			if (updateModText)
			{
				ModLoader.UpdateModText();
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x00185B80 File Offset: 0x00183D80
		internal static void UnloadMod(ModLoader.ModInstance mod, bool updateModText = true)
		{
			try
			{
				if (mod != null)
				{
					ITogglableMod togglableMod = mod.Mod as ITogglableMod;
					if (togglableMod != null && mod.Enabled)
					{
						ModLoader.ModErrorState? error = mod.Error;
						if (error == null)
						{
							mod.Enabled = false;
							togglableMod.Unload();
						}
					}
				}
			}
			catch (Exception arg)
			{
				mod.Error = new ModLoader.ModErrorState?(ModLoader.ModErrorState.Unload);
				Logger.APILogger.LogError(string.Format("Failed to unload Mod `{0}`\n{1}", mod.Name, arg));
			}
			if (updateModText)
			{
				ModLoader.UpdateModText();
			}
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00185C08 File Offset: 0x00183E08
		// Note: this type is marked as 'beforefieldinit'.
		static ModLoader()
		{
			ModLoader.LoadState = ModLoader.ModLoadState.NotStarted;
			ModLoader.ModInstanceTypeMap = new Dictionary<Type, ModLoader.ModInstance>();
			ModLoader.ModInstanceNameMap = new Dictionary<string, ModLoader.ModInstance>();
			ModLoader.ModInstances = new HashSet<ModLoader.ModInstance>();
		}

		// Token: 0x04004BF4 RID: 19444
		public static ModLoader.ModLoadState LoadState;

		// Token: 0x04004BF8 RID: 19448
		private static ModVersionDraw modVersionDraw;

		// Token: 0x02000D7D RID: 3453
		[Flags]
		public enum ModLoadState
		{
			// Token: 0x04004BFA RID: 19450
			NotStarted = 0,
			// Token: 0x04004BFB RID: 19451
			Started = 1,
			// Token: 0x04004BFC RID: 19452
			Preloaded = 2,
			// Token: 0x04004BFD RID: 19453
			Loaded = 4
		}

		// Token: 0x02000D7E RID: 3454
		public class ModInstance
		{
			// Token: 0x04004BFE RID: 19454
			public IMod Mod;

			// Token: 0x04004BFF RID: 19455
			public string Name;

			// Token: 0x04004C00 RID: 19456
			public ModLoader.ModErrorState? Error;

			// Token: 0x04004C01 RID: 19457
			public bool Enabled;
		}

		// Token: 0x02000D7F RID: 3455
		public enum ModErrorState
		{
			// Token: 0x04004C03 RID: 19459
			Construct,
			// Token: 0x04004C04 RID: 19460
			Duplicate,
			// Token: 0x04004C05 RID: 19461
			Initialize,
			// Token: 0x04004C06 RID: 19462
			Unload
		}
	}
}
