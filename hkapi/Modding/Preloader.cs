using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Modding
{
	// Token: 0x02000D88 RID: 3464
	internal class Preloader : MonoBehaviour
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x001864C2 File Offset: 0x001846C2
		private static string DataPath
		{
			get
			{
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return Application.dataPath;
				}
				return Path.Combine(Application.dataPath, "Resources", "Data");
			}
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x001864E6 File Offset: 0x001846E6
		private void Start()
		{
			this.progressBar = base.gameObject.AddComponent<ProgressBar>();
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x001864F9 File Offset: 0x001846F9
		public IEnumerator Preload(Dictionary<string, List<ValueTuple<ModLoader.ModInstance, List<string>>>> toPreload, Dictionary<ModLoader.ModInstance, Dictionary<string, Dictionary<string, GameObject>>> preloadedObjects, Dictionary<string, List<Func<IEnumerator>>> sceneHooks)
		{
			Preloader.<Preload>d__4 <Preload>d__ = new Preloader.<Preload>d__4(0);
			<Preload>d__.<>4__this = this;
			<Preload>d__.toPreload = toPreload;
			<Preload>d__.preloadedObjects = preloadedObjects;
			<Preload>d__.sceneHooks = sceneHooks;
			return <Preload>d__;
		}

		/// <summary>
		///     Mutes all audio from AudioListeners.
		/// </summary>
		// Token: 0x060047F6 RID: 18422 RVA: 0x0018651D File Offset: 0x0018471D
		private static void MuteAllAudio()
		{
			AudioListener.pause = true;
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x00186525 File Offset: 0x00184725
		private IEnumerator DoPreloadAssetBundle([TupleElementNames(new string[]
		{
			"Mod",
			"Preloads"
		})] Dictionary<string, List<ValueTuple<ModLoader.ModInstance, List<string>>>> toPreload, IDictionary<ModLoader.ModInstance, Dictionary<string, Dictionary<string, GameObject>>> preloadedObjects, Dictionary<string, List<Func<IEnumerator>>> sceneHooks)
		{
			Preloader.<DoPreloadAssetBundle>d__6 <DoPreloadAssetBundle>d__ = new Preloader.<DoPreloadAssetBundle>d__6(0);
			<DoPreloadAssetBundle>d__.<>4__this = this;
			<DoPreloadAssetBundle>d__.toPreload = toPreload;
			<DoPreloadAssetBundle>d__.preloadedObjects = preloadedObjects;
			<DoPreloadAssetBundle>d__.sceneHooks = sceneHooks;
			return <DoPreloadAssetBundle>d__;
		}

		/// <summary>
		///     Preload using `DoPreloadScenes`, but first preprocess them to only contain relevant objects
		/// </summary>
		// Token: 0x060047F8 RID: 18424 RVA: 0x00186549 File Offset: 0x00184749
		private IEnumerator DoPreloadRepackedScenes([TupleElementNames(new string[]
		{
			"Mod",
			"Preloads"
		})] Dictionary<string, List<ValueTuple<ModLoader.ModInstance, List<string>>>> toPreload, IDictionary<ModLoader.ModInstance, Dictionary<string, Dictionary<string, GameObject>>> preloadedObjects, Dictionary<string, List<Func<IEnumerator>>> sceneHooks)
		{
			Preloader.<DoPreloadRepackedScenes>d__7 <DoPreloadRepackedScenes>d__ = new Preloader.<DoPreloadRepackedScenes>d__7(0);
			<DoPreloadRepackedScenes>d__.<>4__this = this;
			<DoPreloadRepackedScenes>d__.toPreload = toPreload;
			<DoPreloadRepackedScenes>d__.preloadedObjects = preloadedObjects;
			<DoPreloadRepackedScenes>d__.sceneHooks = sceneHooks;
			return <DoPreloadRepackedScenes>d__;
		}

		/// <summary>
		///     Preload original scenes using a queue bounded by GlobalSettings.PreloadBatchSize
		/// </summary>
		// Token: 0x060047F9 RID: 18425 RVA: 0x0018656D File Offset: 0x0018476D
		private IEnumerator DoPreloadScenes([TupleElementNames(new string[]
		{
			"Mod",
			"Preloads"
		})] Dictionary<string, List<ValueTuple<ModLoader.ModInstance, List<string>>>> toPreload, IDictionary<ModLoader.ModInstance, Dictionary<string, Dictionary<string, GameObject>>> preloadedObjects, Dictionary<string, List<Func<IEnumerator>>> sceneHooks, string scenePrefix = "", float progressAlpha = 1f, float progressBeta = 0f)
		{
			Preloader.<DoPreloadScenes>d__8 <DoPreloadScenes>d__ = new Preloader.<DoPreloadScenes>d__8(0);
			<DoPreloadScenes>d__.<>4__this = this;
			<DoPreloadScenes>d__.toPreload = toPreload;
			<DoPreloadScenes>d__.preloadedObjects = preloadedObjects;
			<DoPreloadScenes>d__.sceneHooks = sceneHooks;
			<DoPreloadScenes>d__.scenePrefix = scenePrefix;
			<DoPreloadScenes>d__.progressAlpha = progressAlpha;
			<DoPreloadScenes>d__.progressBeta = progressBeta;
			return <DoPreloadScenes>d__;
		}

		/// <summary>
		///     Clean up everything from preloading.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060047FA RID: 18426 RVA: 0x001865A9 File Offset: 0x001847A9
		private IEnumerator CleanUpPreloading()
		{
			Preloader.<CleanUpPreloading>d__9 <CleanUpPreloading>d__ = new Preloader.<CleanUpPreloading>d__9(0);
			<CleanUpPreloading>d__.<>4__this = this;
			return <CleanUpPreloading>d__;
		}

		/// <summary>
		///     Unmutes all audio from AudioListeners.
		/// </summary>
		// Token: 0x060047FB RID: 18427 RVA: 0x001865B8 File Offset: 0x001847B8
		private static void UnmuteAllAudio()
		{
			AudioListener.pause = false;
		}

		// Token: 0x04004C15 RID: 19477
		private ProgressBar progressBar;
	}
}
