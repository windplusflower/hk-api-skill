using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x020006D3 RID: 1747
	public class InControlManager : SingletonMonoBehavior<InControlManager>
	{
		// Token: 0x060029D7 RID: 10711 RVA: 0x000E7B08 File Offset: 0x000E5D08
		private void OnEnable()
		{
			if (base.EnforceSingleton)
			{
				return;
			}
			InputManager.InvertYAxis = this.invertYAxis;
			InputManager.SuspendInBackground = this.suspendInBackground;
			InputManager.EnableICade = this.enableICade;
			InputManager.EnableXInput = this.enableXInput;
			InputManager.XInputUpdateRate = (uint)Mathf.Max(this.xInputUpdateRate, 0);
			InputManager.XInputBufferSize = (uint)Mathf.Max(this.xInputBufferSize, 0);
			InputManager.EnableNativeInput = this.enableNativeInput;
			InputManager.NativeInputEnableXInput = this.nativeInputEnableXInput;
			InputManager.NativeInputEnableMFi = this.nativeInputEnableMFi;
			InputManager.NativeInputUpdateRate = (uint)Mathf.Max(this.nativeInputUpdateRate, 0);
			InputManager.NativeInputPreventSleep = this.nativeInputPreventSleep;
			if (InputManager.SetupInternal() && this.logDebugInfo)
			{
				Logger.OnLogMessage -= InControlManager.LogMessage;
				Logger.OnLogMessage += InControlManager.LogMessage;
				Logger.LogInfo("InControl (version " + InputManager.Version.ToString() + ")");
			}
			UnityEngine.SceneManagement.SceneManager.sceneLoaded -= this.OnSceneWasLoaded;
			UnityEngine.SceneManagement.SceneManager.sceneLoaded += this.OnSceneWasLoaded;
			if (this.dontDestroyOnLoad)
			{
				UnityEngine.Object.DontDestroyOnLoad(this);
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000E7C31 File Offset: 0x000E5E31
		private void OnDisable()
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			UnityEngine.SceneManagement.SceneManager.sceneLoaded -= this.OnSceneWasLoaded;
			InputManager.ResetInternal();
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000E7C52 File Offset: 0x000E5E52
		private void Update()
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			if (this.updateMode == InControlUpdateMode.Default || (this.updateMode == InControlUpdateMode.FixedUpdate && Utility.IsZero(Time.timeScale)))
			{
				InputManager.UpdateInternal();
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000E7C88 File Offset: 0x000E5E88
		private void FixedUpdate()
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			if (this.updateMode == InControlUpdateMode.FixedUpdate)
			{
				InputManager.UpdateInternal();
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000E7CAA File Offset: 0x000E5EAA
		private void OnApplicationFocus(bool focusState)
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			InputManager.OnApplicationFocus(focusState);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000E7CC4 File Offset: 0x000E5EC4
		private void OnApplicationPause(bool pauseState)
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			InputManager.OnApplicationPause(pauseState);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000E7CDE File Offset: 0x000E5EDE
		private void OnApplicationQuit()
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			InputManager.OnApplicationQuit();
			this.applicationHasQuit = true;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000E7CFE File Offset: 0x000E5EFE
		private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
			if (base.IsNotTheSingleton)
			{
				return;
			}
			if (this.applicationHasQuit)
			{
				return;
			}
			if (loadSceneMode == LoadSceneMode.Single)
			{
				InputManager.OnLevelWasLoaded();
			}
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000E7D1C File Offset: 0x000E5F1C
		private static void LogMessage(LogMessage logMessage)
		{
			switch (logMessage.type)
			{
			case LogMessageType.Info:
				Debug.Log(logMessage.text);
				return;
			case LogMessageType.Warning:
				Debug.LogWarning(logMessage.text);
				return;
			case LogMessageType.Error:
				Debug.LogError(logMessage.text);
				return;
			default:
				return;
			}
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000E7D66 File Offset: 0x000E5F66
		public InControlManager()
		{
			this.logDebugInfo = true;
			this.dontDestroyOnLoad = true;
			this.enableNativeInput = true;
			this.nativeInputEnableXInput = true;
			base..ctor();
		}

		// Token: 0x04002FC3 RID: 12227
		public bool logDebugInfo;

		// Token: 0x04002FC4 RID: 12228
		public bool invertYAxis;

		// Token: 0x04002FC5 RID: 12229
		[SerializeField]
		private bool useFixedUpdate;

		// Token: 0x04002FC6 RID: 12230
		public bool dontDestroyOnLoad;

		// Token: 0x04002FC7 RID: 12231
		public bool suspendInBackground;

		// Token: 0x04002FC8 RID: 12232
		public InControlUpdateMode updateMode;

		// Token: 0x04002FC9 RID: 12233
		public bool enableICade;

		// Token: 0x04002FCA RID: 12234
		public bool enableXInput;

		// Token: 0x04002FCB RID: 12235
		public bool xInputOverrideUpdateRate;

		// Token: 0x04002FCC RID: 12236
		public int xInputUpdateRate;

		// Token: 0x04002FCD RID: 12237
		public bool xInputOverrideBufferSize;

		// Token: 0x04002FCE RID: 12238
		public int xInputBufferSize;

		// Token: 0x04002FCF RID: 12239
		public bool enableNativeInput;

		// Token: 0x04002FD0 RID: 12240
		public bool nativeInputEnableXInput;

		// Token: 0x04002FD1 RID: 12241
		public bool nativeInputEnableMFi;

		// Token: 0x04002FD2 RID: 12242
		public bool nativeInputPreventSleep;

		// Token: 0x04002FD3 RID: 12243
		public bool nativeInputOverrideUpdateRate;

		// Token: 0x04002FD4 RID: 12244
		public int nativeInputUpdateRate;

		// Token: 0x04002FD5 RID: 12245
		private bool applicationHasQuit;
	}
}
