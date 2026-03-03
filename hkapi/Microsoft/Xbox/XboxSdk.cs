using System;
using UnityEngine;
using UnityEngine.UI;
using XGamingRuntime;

namespace Microsoft.Xbox
{
	// Token: 0x020008B9 RID: 2233
	public class XboxSdk : MonoBehaviour
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x0012E798 File Offset: 0x0012C998
		public static XboxSdk Helpers
		{
			get
			{
				if (XboxSdk._xboxHelpers == null)
				{
					XboxSdk[] array = UnityEngine.Object.FindObjectsOfType<XboxSdk>();
					if (array.Length != 0)
					{
						XboxSdk._xboxHelpers = array[0];
						XboxSdk._xboxHelpers._Initialize();
					}
					else
					{
						XboxSdk._LogError("Error: Could not find Xbox prefab. Make sure you have added the Xbox prefab to your scene.");
					}
				}
				return XboxSdk._xboxHelpers;
			}
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x060031AA RID: 12714 RVA: 0x0012E7E0 File Offset: 0x0012C9E0
		// (remove) Token: 0x060031AB RID: 12715 RVA: 0x0012E818 File Offset: 0x0012CA18
		public event XboxSdk.OnGameSaveLoadedHandler OnGameSaveLoaded;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060031AC RID: 12716 RVA: 0x0012E850 File Offset: 0x0012CA50
		// (remove) Token: 0x060031AD RID: 12717 RVA: 0x0012E888 File Offset: 0x0012CA88
		public event XboxSdk.OnErrorHandler OnError;

		// Token: 0x060031AE RID: 12718 RVA: 0x0012E8BD File Offset: 0x0012CABD
		private void Start()
		{
			this._Initialize();
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x0012E8C5 File Offset: 0x0012CAC5
		private void _Initialize()
		{
			if (XboxSdk._initialized)
			{
				return;
			}
			XboxSdk._initialized = true;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			if (!XboxSdk.Succeeded(SDK.XGameRuntimeInitialize(), "Initialize baming runtime"))
			{
				return;
			}
			if (this.signInOnStart)
			{
				this.SignIn();
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0012E900 File Offset: 0x0012CB00
		public void SignIn()
		{
			this.SignInImpl();
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x0012E908 File Offset: 0x0012CB08
		public void Save(byte[] data)
		{
			this.SaveImpl(data);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x0012E911 File Offset: 0x0012CB11
		public void LoadSaveData()
		{
			this.LoadSaveDataImpl();
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0012E919 File Offset: 0x0012CB19
		public void UnlockAchievement(string achievementId)
		{
			this.UnlockAchievementImpl(achievementId);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0012E922 File Offset: 0x0012CB22
		private void SignInImpl()
		{
			SDK.XUserAddAsync(XUserAddOptions.AddDefaultUserAllowingUI, new XUserAddCompleted(this.AddUserComplete));
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0012E936 File Offset: 0x0012CB36
		private void AddUserComplete(int hresult, XUserHandle userHandle)
		{
			if (!XboxSdk.Succeeded(hresult, "Sign in."))
			{
				return;
			}
			this._userHandle = userHandle;
			this.CompletePostSignInInitialization();
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0012E954 File Offset: 0x0012CB54
		private void CompletePostSignInInitialization()
		{
			string empty = string.Empty;
			if (this.gamertagLabel != null && XboxSdk.Succeeded(SDK.XUserGetGamertag(this._userHandle, XUserGamertagComponent.UniqueModern, out empty), "Get gamertag."))
			{
				this.gamertagLabel.text = empty;
			}
			XboxSdk.Succeeded(SDK.XBL.XblInitialize(this.scid), "Initialize Xbox Live");
			XboxSdk.Succeeded(SDK.XBL.XblContextCreateHandle(this._userHandle, out this._xblContextHandle), "Create Xbox Live context");
			this.InitializeGameSaves();
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0012E9D3 File Offset: 0x0012CBD3
		private void InitializeGameSaves()
		{
			SDK.XGameSaveInitializeProviderAsync(this._userHandle, "", false, new XGameSaveInitializeProviderCompleted(this.XGameSaveInitializeCompleted));
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0012E9F2 File Offset: 0x0012CBF2
		private void XGameSaveInitializeCompleted(int hresult, XGameSaveProviderHandle gameSaveProviderHandle)
		{
			if (!XboxSdk.Succeeded(hresult, "Initialize game save provider"))
			{
				return;
			}
			this._gameSaveProviderHandle = gameSaveProviderHandle;
			XboxSdk.Succeeded(SDK.XGameSaveCreateContainer(this._gameSaveProviderHandle, "x_game_save_default_container", out this._gameSaveContainerHandle), "Create container");
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0012EA2C File Offset: 0x0012CC2C
		private void SaveImpl(byte[] data)
		{
			XGameSaveUpdateHandle updateHandle;
			if (!XboxSdk.Succeeded(SDK.XGameSaveCreateUpdate(this._gameSaveContainerHandle, "x_game_save_default_container", out updateHandle), "Update container"))
			{
				return;
			}
			if (!XboxSdk.Succeeded(SDK.XGameSaveSubmitBlobWrite(updateHandle, "x_game_save_default_blob", data), "Submit blob write"))
			{
				return;
			}
			SDK.XGameSaveSubmitUpdateAsync(updateHandle, new XGameSaveSubmitUpdateCompleted(this.GameSaveSubmitUpdateCompleted));
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0012EA83 File Offset: 0x0012CC83
		private void GameSaveSubmitUpdateCompleted(int hresult)
		{
			XboxSdk.Succeeded(hresult, "Game save submit update complete");
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0012EA91 File Offset: 0x0012CC91
		private void LoadSaveDataImpl()
		{
			SDK.XGameSaveReadBlobDataAsync(this._gameSaveContainerHandle, new string[]
			{
				"x_game_save_default_blob"
			}, new XGameSaveReadBlobDataCompleted(this.GameSaveReadBlobDataCompleted));
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x0012EAB8 File Offset: 0x0012CCB8
		private void GameSaveReadBlobDataCompleted(int hresult, XGameSaveBlob[] blobs)
		{
			if (!XboxSdk.Succeeded(hresult, "Read Blob"))
			{
				return;
			}
			byte[] data = null;
			int num = 0;
			if (num < blobs.Length)
			{
				data = blobs[num].Data;
			}
			if (XboxSdk.Helpers.OnGameSaveLoaded != null)
			{
				XboxSdk.Helpers.OnGameSaveLoaded(XboxSdk.Helpers, new GameSaveLoadedArgs(data));
			}
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0012EB14 File Offset: 0x0012CD14
		private void UnlockAchievementImpl(string achievementId)
		{
			ulong xboxUserId;
			if (!XboxSdk.Succeeded(SDK.XUserGetId(this._userHandle, out xboxUserId), "Get Xbox user ID"))
			{
				return;
			}
			SDK.XBL.XblAchievementsUpdateAchievementAsync(this._xblContextHandle, xboxUserId, achievementId, 100U, new SDK.XBL.XblAchievementsUpdateAchievementResult(this.UnlockAchievementComplete));
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0012EB56 File Offset: 0x0012CD56
		private void UnlockAchievementComplete(int hresult)
		{
			XboxSdk.Succeeded(hresult, "Unlock achievement");
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0012EB64 File Offset: 0x0012CD64
		private void Update()
		{
			SDK.XTaskQueueDispatch(0U);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0012EB6C File Offset: 0x0012CD6C
		protected static bool Succeeded(int hresult, string operationFriendlyName)
		{
			bool result = false;
			if (hresult >= 0)
			{
				result = true;
			}
			else
			{
				string text = hresult.ToString("X8");
				string text2 = operationFriendlyName + " failed.";
				XboxSdk._LogError(string.Format("{0} Error code: hr=0x{1}", text2, text));
				if (XboxSdk.Helpers.OnError != null)
				{
					XboxSdk.Helpers.OnError(XboxSdk.Helpers, new ErrorEventArgs(text, text2));
				}
			}
			return result;
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0012EBD5 File Offset: 0x0012CDD5
		private static void _LogError(string message)
		{
			Debug.Log(message);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0012EBDD File Offset: 0x0012CDDD
		public XboxSdk()
		{
			this.signInOnStart = true;
			base..ctor();
		}

		// Token: 0x04003335 RID: 13109
		[Header("You can find the value of the scid in your MicrosoftGame.config")]
		public string scid;

		// Token: 0x04003336 RID: 13110
		public Text gamertagLabel;

		// Token: 0x04003337 RID: 13111
		public bool signInOnStart;

		// Token: 0x04003338 RID: 13112
		private static XboxSdk _xboxHelpers;

		// Token: 0x04003339 RID: 13113
		private static bool _initialized;

		// Token: 0x0400333A RID: 13114
		private XUserHandle _userHandle;

		// Token: 0x0400333B RID: 13115
		private XblContextHandle _xblContextHandle;

		// Token: 0x0400333C RID: 13116
		private XGameSaveProviderHandle _gameSaveProviderHandle;

		// Token: 0x0400333D RID: 13117
		private XGameSaveContainerHandle _gameSaveContainerHandle;

		// Token: 0x0400333E RID: 13118
		private const string _GAME_SAVE_CONTAINER_NAME = "x_game_save_default_container";

		// Token: 0x0400333F RID: 13119
		private const string _GAME_SAVE_BLOB_NAME = "x_game_save_default_blob";

		// Token: 0x020008BA RID: 2234
		// (Invoke) Token: 0x060031C4 RID: 12740
		public delegate void OnGameSaveLoadedHandler(object sender, GameSaveLoadedArgs e);

		// Token: 0x020008BB RID: 2235
		// (Invoke) Token: 0x060031C8 RID: 12744
		public delegate void OnErrorHandler(object sender, ErrorEventArgs e);

		// Token: 0x020008BC RID: 2236
		private class GameSaves
		{
		}
	}
}
