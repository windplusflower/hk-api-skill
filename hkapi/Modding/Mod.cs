using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;
using Language;
using Modding.Patches;
using MonoMod.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Modding
{
	/// <inheritdoc cref="T:Modding.Loggable" />
	/// <inheritdoc cref="T:Modding.IMod" />
	/// <summary>
	///     Base mod class.
	/// </summary>
	// Token: 0x02000D6E RID: 3438
	[PublicAPI]
	public abstract class Mod : Loggable, IMod, ILogger
	{
		/// <inheritdoc />
		/// <summary>
		///     Constructs the mod, assigns the instance and sets the name.
		/// </summary>
		// Token: 0x060046E0 RID: 18144 RVA: 0x00180F44 File Offset: 0x0017F144
		protected Mod(string name = null)
		{
			if (string.IsNullOrEmpty(name))
			{
				name = base.GetType().Name;
			}
			Type type = base.GetType().GetInterfaces().FirstOrDefault((Type x) => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IGlobalSettings<>));
			if (type != null)
			{
				this.globalSettingsType = type.GetGenericArguments()[0];
				foreach (MethodInfo methodInfo in type.GetMethods())
				{
					string name2 = methodInfo.Name;
					if (!(name2 == "OnLoadGlobal"))
					{
						if (name2 == "OnSaveGlobal")
						{
							this.onSaveGlobalSettings = methodInfo.GetFastDelegate(true);
						}
					}
					else
					{
						this.onLoadGlobalSettings = methodInfo.GetFastDelegate(true);
					}
				}
			}
			Type type2 = base.GetType().GetInterfaces().FirstOrDefault((Type x) => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ILocalSettings<>));
			if (type2 != null)
			{
				this.saveSettingsType = type2.GetGenericArguments()[0];
				foreach (MethodInfo methodInfo2 in type2.GetMethods())
				{
					string name2 = methodInfo2.Name;
					if (!(name2 == "OnLoadLocal"))
					{
						if (name2 == "OnSaveLocal")
						{
							this.onSaveSaveSettings = methodInfo2.GetFastDelegate(true);
						}
					}
					else
					{
						this.onLoadSaveSettings = methodInfo2.GetFastDelegate(true);
					}
				}
			}
			this.Name = name;
			base.Log("Initializing");
			if (this._globalSettingsPath == null)
			{
				this._globalSettingsPath = this.GetGlobalSettingsPath();
			}
			this.LoadGlobalSettings();
			this.HookSaveMethods();
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x001810E0 File Offset: 0x0017F2E0
		private string GetGlobalSettingsPath()
		{
			string path = base.GetType().Name + ".GlobalSettings.json";
			string text = Path.Combine(Path.GetDirectoryName(base.GetType().Assembly.Location), path);
			if (File.Exists(text))
			{
				base.Log("Overriding Global Settings path with Mod directory");
				return text;
			}
			return Path.Combine(Application.persistentDataPath, path);
		}

		/// <inheritdoc />
		/// <summary>
		///     Get's the Mod's Name
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046E2 RID: 18146 RVA: 0x0018113F File Offset: 0x0017F33F
		public string GetName()
		{
			return this.Name;
		}

		/// <inheritdoc />
		/// <summary>
		///     Returns the objects to preload in order for the mod to work.
		/// </summary>
		/// <returns>A List of tuples containing scene name, object name</returns>
		// Token: 0x060046E3 RID: 18147 RVA: 0x000086D3 File Offset: 0x000068D3
		public virtual List<ValueTuple<string, string>> GetPreloadNames()
		{
			return null;
		}

		/// <summary>
		/// A list of requested scenes to be preloaded and actions to execute on loading of those scenes
		/// </summary>
		/// <returns>List of tuples containg scene names and the respective actions.</returns>
		// Token: 0x060046E4 RID: 18148 RVA: 0x00181147 File Offset: 0x0017F347
		public virtual ValueTuple<string, Func<IEnumerator>>[] PreloadSceneHooks()
		{
			return Array.Empty<ValueTuple<string, Func<IEnumerator>>>();
		}

		/// <inheritdoc />
		/// <summary>
		///     Called after preloading of all mods.
		/// </summary>
		/// <param name="preloadedObjects">The preloaded objects relevant to this <see cref="T:Modding.Mod" /></param>
		// Token: 0x060046E5 RID: 18149 RVA: 0x0018114E File Offset: 0x0017F34E
		public virtual void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
		{
			this.Initialize();
		}

		/// <inheritdoc />
		/// <summary>
		///     Returns version of Mod
		/// </summary>
		/// <returns>Mod Version</returns>
		// Token: 0x060046E6 RID: 18150 RVA: 0x00181156 File Offset: 0x0017F356
		public virtual string GetVersion()
		{
			return "UNKNOWN";
		}

		/// <summary>
		///     Controls when this mod should load compared to other mods.  Defaults to ordered by name.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046E7 RID: 18151 RVA: 0x0004E56C File Offset: 0x0004C76C
		public virtual int LoadPriority()
		{
			return 1;
		}

		/// <summary>
		///     Called after preloading of all mods.
		/// </summary>
		// Token: 0x060046E8 RID: 18152 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void Initialize()
		{
		}

		/// <summary>
		///     If this mod defines a menu via the <see cref="T:Modding.IMenuMod" /> or <see cref="T:Modding.ICustomMenuMod" /> interfaces, override this method to 
		///     change the text of the button to jump to this mod's menu.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060046E9 RID: 18153 RVA: 0x0018115D File Offset: 0x0017F35D
		public virtual string GetMenuButtonText()
		{
			return this.GetName() + " " + Language.Get("MAIN_OPTIONS", "MainMenu");
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00181180 File Offset: 0x0017F380
		private void HookSaveMethods()
		{
			ModHooks.ApplicationQuitHook += this.SaveGlobalSettings;
			ModHooks.SaveLocalSettings += this.SaveLocalSettings;
			ModHooks.LoadLocalSettings += this.LoadLocalSettings;
			UnityEngine.SceneManagement.SceneManager.activeSceneChanged += this.SceneChanged;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x001811D4 File Offset: 0x0017F3D4
		private void SceneChanged(Scene arg0, Scene arg1)
		{
			if (arg1.name != "Menu_Title")
			{
				return;
			}
			Type type = this.saveSettingsType;
			if (type != null)
			{
				this.onLoadSaveSettings(this, new object[]
				{
					Activator.CreateInstance(type)
				});
			}
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0018121C File Offset: 0x0017F41C
		private void LoadGlobalSettings()
		{
			try
			{
				Type type = this.globalSettingsType;
				if (type != null)
				{
					if (File.Exists(this._globalSettingsPath))
					{
						base.Log("Loading Global Settings");
						if (!this.TryLoadGlobalSettings(this._globalSettingsPath, type))
						{
							base.LogError("Null global settings passed to " + this.GetName());
							string text = this._globalSettingsPath + ".bak";
							if (File.Exists(text))
							{
								if (this.TryLoadGlobalSettings(text, type))
								{
									base.Log("Successfully loaded global settings from backup");
									File.Delete(this._globalSettingsPath);
									File.Copy(text, this._globalSettingsPath);
								}
								base.LogError("Failed to load global settings from backup");
							}
						}
					}
				}
			}
			catch (Exception message)
			{
				base.LogError(message);
			}
		}

		/// <summary>
		/// Try to load the global settings from the given path. Returns true if the global settings were successfully loaded.
		/// </summary>
		// Token: 0x060046ED RID: 18157 RVA: 0x001812EC File Offset: 0x0017F4EC
		private bool TryLoadGlobalSettings(string path, Type saveType)
		{
			bool result;
			using (FileStream fileStream = File.OpenRead(this._globalSettingsPath))
			{
				using (StreamReader streamReader = new StreamReader(fileStream))
				{
					object obj = JsonConvert.DeserializeObject(streamReader.ReadToEnd(), saveType, new JsonSerializerSettings
					{
						ContractResolver = ShouldSerializeContractResolver.Instance,
						TypeNameHandling = TypeNameHandling.Auto,
						ObjectCreationHandling = ObjectCreationHandling.Replace,
						Converters = JsonConverterTypes.ConverterTypes
					});
					if (obj == null)
					{
						result = false;
					}
					else
					{
						this.onLoadGlobalSettings(this, new object[]
						{
							obj
						});
						result = true;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Save global settings to saves folder.
		/// </summary>
		// Token: 0x060046EE RID: 18158 RVA: 0x00181398 File Offset: 0x0017F598
		protected void SaveGlobalSettings()
		{
			try
			{
				if (this.globalSettingsType != null)
				{
					base.Log("Saving Global Settings");
					object obj = this.onSaveGlobalSettings(this, Array.Empty<object>());
					if (obj != null)
					{
						if (File.Exists(this._globalSettingsPath + ".bak"))
						{
							File.Delete(this._globalSettingsPath + ".bak");
						}
						if (File.Exists(this._globalSettingsPath))
						{
							File.Move(this._globalSettingsPath, this._globalSettingsPath + ".bak");
						}
						using (FileStream fileStream = File.Create(this._globalSettingsPath))
						{
							using (StreamWriter streamWriter = new StreamWriter(fileStream))
							{
								streamWriter.Write(JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
								{
									ContractResolver = ShouldSerializeContractResolver.Instance,
									TypeNameHandling = TypeNameHandling.Auto,
									Converters = JsonConverterTypes.ConverterTypes
								}));
							}
						}
					}
				}
			}
			catch (Exception message)
			{
				base.LogError(message);
			}
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x001814B8 File Offset: 0x0017F6B8
		private void LoadLocalSettings(ModSavegameData data)
		{
			try
			{
				Type type = this.saveSettingsType;
				if (type != null)
				{
					JToken jtoken;
					if (data.modData.TryGetValue(this.GetName(), out jtoken))
					{
						this.onLoadSaveSettings(this, new object[]
						{
							jtoken.ToObject(type, JsonSerializer.Create(new JsonSerializerSettings
							{
								ContractResolver = ShouldSerializeContractResolver.Instance,
								TypeNameHandling = TypeNameHandling.Auto,
								ObjectCreationHandling = ObjectCreationHandling.Replace,
								Converters = JsonConverterTypes.ConverterTypes
							}))
						});
					}
				}
			}
			catch (Exception message)
			{
				base.LogError(message);
			}
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00181550 File Offset: 0x0017F750
		private void SaveLocalSettings(ModSavegameData data)
		{
			try
			{
				if (this.saveSettingsType != null)
				{
					object obj = this.onSaveSaveSettings(this, Array.Empty<object>());
					if (obj != null)
					{
						data.modData[this.GetName()] = JToken.FromObject(obj, JsonSerializer.Create(new JsonSerializerSettings
						{
							ContractResolver = ShouldSerializeContractResolver.Instance,
							TypeNameHandling = TypeNameHandling.Auto,
							Converters = JsonConverterTypes.ConverterTypes
						}));
					}
				}
			}
			catch (Exception message)
			{
				base.LogError(message);
			}
		}

		// Token: 0x04004B8E RID: 19342
		private readonly string _globalSettingsPath;

		// Token: 0x04004B8F RID: 19343
		private readonly Type globalSettingsType;

		// Token: 0x04004B90 RID: 19344
		private readonly FastReflectionDelegate onLoadGlobalSettings;

		// Token: 0x04004B91 RID: 19345
		private readonly FastReflectionDelegate onSaveGlobalSettings;

		// Token: 0x04004B92 RID: 19346
		private readonly Type saveSettingsType;

		// Token: 0x04004B93 RID: 19347
		private readonly FastReflectionDelegate onLoadSaveSettings;

		// Token: 0x04004B94 RID: 19348
		private readonly FastReflectionDelegate onSaveSaveSettings;

		/// <summary>
		///     The Mods Name
		/// </summary>
		// Token: 0x04004B95 RID: 19349
		public readonly string Name;
	}
}
