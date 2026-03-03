using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using InControl;
using Language;
using Modding;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000415 RID: 1045
public class OnScreenDebugInfo : MonoBehaviour
{
	// Token: 0x0600179E RID: 6046 RVA: 0x0006F918 File Offset: 0x0006DB18
	private void Awake()
	{
		if (ModLoader.LoadState == ModLoader.ModLoadState.NotStarted)
		{
			Modding.Logger.APILogger.Log("Main menu loading");
			ModLoader.LoadState = ModLoader.ModLoadState.Started;
			GameObject gameObject = new GameObject();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			ThreadStart start;
			if ((start = OnScreenDebugInfo.<>O.<0>__PreloadCommonTypes) == null)
			{
				start = (OnScreenDebugInfo.<>O.<0>__PreloadCommonTypes = new ThreadStart(ReflectionHelper.PreloadCommonTypes));
			}
			new Thread(start).Start();
			gameObject.AddComponent<NonBouncer>().StartCoroutine(ModLoader.LoadModsInit(gameObject));
		}
		else
		{
			Modding.Logger.APILogger.LogDebug(string.Format("OnScreenDebugInfo: Already begun mod loading (state {0})", ModLoader.LoadState));
		}
		this.orig_Awake();
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x0006F9AA File Offset: 0x0006DBAA
	private IEnumerator Start()
	{
		this.gm = GameManager.instance;
		this.gm.UnloadingLevel += this.OnLevelUnload;
		this.ih = this.gm.inputHandler;
		this.RetrieveInfo();
		GUI.depth = 2;
		while (this.showFPS)
		{
			if (Time.timeScale == 1f)
			{
				yield return new WaitForSeconds(0.1f);
				this.frameRate = 1f / Time.deltaTime;
				this.fps = "FPS :" + Mathf.Round(this.frameRate).ToString();
			}
			else
			{
				this.fps = "Pause";
			}
			yield return new WaitForSeconds(0.5f);
		}
		yield break;
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0006F9B9 File Offset: 0x0006DBB9
	private void LevelActivated(Scene sceneFrom, Scene sceneTo)
	{
		this.RetrieveInfo();
		if (this.showLoadingTime)
		{
			this.loadTime = (float)Math.Round((double)(Time.realtimeSinceStartup - this.unloadTime), 2);
		}
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0006F9E3 File Offset: 0x0006DBE3
	private void OnEnable()
	{
		UnityEngine.SceneManagement.SceneManager.activeSceneChanged += this.LevelActivated;
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0006F9F6 File Offset: 0x0006DBF6
	private void OnDisable()
	{
		UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= this.LevelActivated;
		if (this.gm != null)
		{
			this.gm.UnloadingLevel -= this.OnLevelUnload;
		}
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x0006FA30 File Offset: 0x0006DC30
	private void OnGUI()
	{
		if (this.showInfo)
		{
			if (this.showFPS)
			{
				GUI.Label(this.fpsRect, this.fps);
			}
			if (this.showInfo)
			{
				GUI.Label(this.infoRect, this.infoString);
			}
			if (this.showInput)
			{
				GUI.Label(this.inputRect, this.ReadInput());
			}
			if (this.showLoadingTime)
			{
				GUI.Label(this.loadProfilerRect, this.loadTime.ToString() + "s");
			}
			if (this.showTFR)
			{
				GUI.Label(this.tfrRect, "TFR: " + Application.targetFrameRate.ToString());
			}
		}
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x0006FAE5 File Offset: 0x0006DCE5
	public void ShowFPS()
	{
		this.showFPS = !this.showFPS;
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x0006FAF6 File Offset: 0x0006DCF6
	public void ShowGameInfo()
	{
		this.showInfo = !this.showInfo;
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x0006FB07 File Offset: 0x0006DD07
	public void ShowInput()
	{
		this.showInput = !this.showInput;
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x0006FB18 File Offset: 0x0006DD18
	public void ShowLoadingTime()
	{
		this.showLoadingTime = !this.showLoadingTime;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x0006FB29 File Offset: 0x0006DD29
	public void ShowTargetFrameRate()
	{
		this.showTFR = !this.showTFR;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0006FB3A File Offset: 0x0006DD3A
	private void OnLevelUnload()
	{
		this.unloadTime = Time.realtimeSinceStartup;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x0006FB48 File Offset: 0x0006DD48
	private void RetrieveInfo()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		this.versionNumber = "1.5.78.11833";
		this.infoString = string.Concat(new string[]
		{
			Language.Get("GAME_TITLE"),
			"\r\n",
			this.versionNumber,
			" ",
			Language.CurrentLanguage().ToString(),
			"\r\n",
			this.gm.GetSceneNameString()
		});
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x0006FBDC File Offset: 0x0006DDDC
	private string ReadInput()
	{
		string str = "";
		string format = "Move Vector: {0}, {1}";
		Vector2 vector = this.ih.inputActions.moveVector.Vector;
		object arg = vector.x.ToString();
		vector = this.ih.inputActions.moveVector.Vector;
		return str + string.Format(format, arg, vector.y.ToString()) + string.Format("\nMove Pressed: {0}", this.ih.inputActions.left.IsPressed || this.ih.inputActions.right.IsPressed) + string.Format("\nMove Raw L: {0} R: {1}", this.ih.inputActions.left.RawValue, this.ih.inputActions.right.RawValue) + string.Format("\nInputX: " + this.ih.inputX.ToString(), Array.Empty<object>()) + string.Format("\nAny Key Down: {0}", InputManager.AnyKeyIsPressed);
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x0006FD0C File Offset: 0x0006DF0C
	private void orig_Awake()
	{
		this.fpsRect = new Rect(7f, 5f, 100f, 25f);
		this.infoRect = new Rect((float)(Screen.width - 105), 5f, 100f, 70f);
		this.inputRect = new Rect(7f, 65f, 300f, 120f);
		this.loadProfilerRect = new Rect((float)(Screen.width / 2) - 50f, 5f, 100f, 25f);
		this.tfrRect = new Rect(7f, 20f, 100f, 25f);
	}

	// Token: 0x04001C5D RID: 7261
	private GameManager gm;

	// Token: 0x04001C5E RID: 7262
	private InputHandler ih;

	// Token: 0x04001C5F RID: 7263
	private float unloadTime;

	// Token: 0x04001C60 RID: 7264
	private float loadTime;

	// Token: 0x04001C61 RID: 7265
	private float frameRate;

	// Token: 0x04001C62 RID: 7266
	private string fps;

	// Token: 0x04001C63 RID: 7267
	private string infoString;

	// Token: 0x04001C64 RID: 7268
	private string versionNumber;

	// Token: 0x04001C65 RID: 7269
	private const float textWidth = 100f;

	// Token: 0x04001C66 RID: 7270
	private Rect loadProfilerRect;

	// Token: 0x04001C67 RID: 7271
	private Rect fpsRect;

	// Token: 0x04001C68 RID: 7272
	private Rect infoRect;

	// Token: 0x04001C69 RID: 7273
	private Rect inputRect;

	// Token: 0x04001C6A RID: 7274
	private Rect tfrRect;

	// Token: 0x04001C6B RID: 7275
	private bool showFPS;

	// Token: 0x04001C6C RID: 7276
	private bool showInfo;

	// Token: 0x04001C6D RID: 7277
	private bool showInput;

	// Token: 0x04001C6E RID: 7278
	private bool showLoadingTime;

	// Token: 0x04001C6F RID: 7279
	private bool showTFR;

	// Token: 0x02000417 RID: 1047
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04001C73 RID: 7283
		public static ThreadStart <0>__PreloadCommonTypes;
	}
}
