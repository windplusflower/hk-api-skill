using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x020001FF RID: 511
public class PerformanceHUD : MonoBehaviour
{
	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003AF31 File Offset: 0x00039131
	public static PerformanceHUD Shared
	{
		get
		{
			return PerformanceHUD.shared;
		}
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0003AF38 File Offset: 0x00039138
	public static void Init()
	{
		if (PerformanceHUD.shared == null)
		{
			GameObject gameObject = new GameObject(typeof(PerformanceHUD).Name);
			PerformanceHUD.shared = gameObject.AddComponent<PerformanceHUD>();
			PerformanceHUD.shared.enabled = false;
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003AF76 File Offset: 0x00039176
	// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0003AF7E File Offset: 0x0003917E
	public bool FpsFrames
	{
		get
		{
			return this.fpsFrames;
		}
		set
		{
			this.fpsFrames = value;
		}
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0003AF88 File Offset: 0x00039188
	protected void Awake()
	{
		this.frameCounter = 0;
		this.lastSecond = (int)Time.realtimeSinceStartup;
		this.framesLastSecondContent = new GUIContent("N/A");
		this.framesColor = Color.gray;
		BuildMetadata embedded = BuildMetadata.Embedded;
		if (embedded != null)
		{
			this.versionContent = new GUIContent(string.Concat(new string[]
			{
				embedded.BranchName,
				" r",
				embedded.Revision,
				" (",
				embedded.CommitTime.ToString(),
				")"
			}));
		}
		else
		{
			this.versionContent = new GUIContent("No Build Metadata");
		}
		this.memoryContent = new GUIContent("N/A");
		this.loadReports = new List<PerformanceHUD.LoadReport>();
		this.vibrationsContent = new GUIContent("");
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0003B05A File Offset: 0x0003925A
	protected void OnEnable()
	{
		GameManager.SceneTransitionBegan += this.GameManager_SceneTransitionBegan;
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0003B06D File Offset: 0x0003926D
	protected void OnDisable()
	{
		GameManager.SceneTransitionBegan -= this.GameManager_SceneTransitionBegan;
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0003B080 File Offset: 0x00039280
	protected void Update()
	{
		this.frameCounter++;
		int num = (int)Time.realtimeSinceStartup;
		if (num != this.lastSecond)
		{
			this.framesLastSecond = this.frameCounter;
			if (this.framesLastSecond >= 58)
			{
				this.framesColor = Color.green;
			}
			else if (this.framesLastSecond >= 50)
			{
				this.framesColor = Color.yellow;
			}
			else
			{
				this.framesColor = Color.red;
			}
			this.framesLastSecondContent.text = this.framesLastSecond.ToString();
			this.lastSecond = num;
			this.frameCounter = 0;
			this.UpdateMemory();
		}
		if (this.fpsFrames)
		{
			this.instantaneousFrames = new float?(1f / Time.unscaledDeltaTime);
		}
		else
		{
			this.instantaneousFrames = null;
		}
		if (PerformanceHUD.ShowVibrations)
		{
			VibrationMixer mixer = VibrationManager.GetMixer();
			if (mixer != null)
			{
				string text = "";
				for (int i = 0; i < mixer.PlayingEmissionCount; i++)
				{
					if (text.Length > 0)
					{
						text += ", ";
					}
					text += mixer.GetPlayingEmission(i).ToString();
				}
				this.vibrationsContent.text = text;
				return;
			}
			this.vibrationsContent.text = "";
		}
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x0003B1B4 File Offset: 0x000393B4
	private void GameManager_SceneTransitionBegan(SceneLoad sceneLoad)
	{
		PerformanceHUD.LoadReport loadReport = new PerformanceHUD.LoadReport
		{
			Color = Color.white,
			Content = new GUIContent()
		};
		this.loadReports.Add(loadReport);
		while (this.loadReports.Count > 2)
		{
			this.loadReports.RemoveAt(0);
		}
		sceneLoad.FetchComplete += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		sceneLoad.ActivationComplete += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		sceneLoad.Complete += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		sceneLoad.StartCalled += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		sceneLoad.BossLoaded += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		sceneLoad.Finish += delegate()
		{
			this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
		};
		this.UpdateSceneLoadRecordContent(sceneLoad, loadReport);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0003B2C0 File Offset: 0x000394C0
	private void UpdateSceneLoadRecordContent(SceneLoad sceneLoad, PerformanceHUD.LoadReport report)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(sceneLoad.TargetSceneName);
		stringBuilder.Append(":    ");
		float num = 0f;
		for (int i = 0; i < 8; i++)
		{
			SceneLoad.Phases phase = (SceneLoad.Phases)i;
			float? duration = sceneLoad.GetDuration(phase);
			if (duration != null && duration.Value > Mathf.Epsilon)
			{
				stringBuilder.Append(phase.ToString());
				stringBuilder.Append(": ");
				stringBuilder.Append(duration.Value.ToString("0.00s"));
				stringBuilder.Append("    ");
				num += duration.Value;
			}
		}
		if (num > Mathf.Epsilon)
		{
			stringBuilder.Append("Total: ");
			stringBuilder.Append(num.ToString("0.00s"));
		}
		if (num > 3.5f)
		{
			report.Color = Color.red;
		}
		else if (num > 3f)
		{
			report.Color = Color.yellow;
		}
		else
		{
			report.Color = Color.white;
		}
		report.Content.text = stringBuilder.ToString();
		if (sceneLoad.IsFinished && !report.DidPost)
		{
			report.DidPost = true;
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0003B3F9 File Offset: 0x000395F9
	private IEnumerator ReportUpload(WWW www)
	{
		yield return www;
		Debug.LogFormat("Finished upload (isDone={0}, error={1}).", new object[]
		{
			www.isDone,
			www.error
		});
		yield break;
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x0003B408 File Offset: 0x00039608
	private static string GetTimeStr(float? time)
	{
		if (time != null)
		{
			return time.Value.ToString("0.00") + "s";
		}
		return "N/A";
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0003B444 File Offset: 0x00039644
	private void UpdateMemory()
	{
		double num = (double)GCManager.GetMemoryUsage() / 1024.0 / 1024.0;
		double num2 = (double)((long)SystemInfo.systemMemorySize);
		this.memoryContent.text = string.Concat(new string[]
		{
			"Memory (CPU): ",
			num.ToString("0.0"),
			"/",
			num2.ToString("0.0"),
			" - ",
			GCManager.IsAutomaticCollectionEnabled ? "GC On" : "GC Off"
		});
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x0003B4D8 File Offset: 0x000396D8
	protected void OnGUI()
	{
		GUI.color = this.framesColor;
		this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 24), (float)Screen.width, 24f), this.framesLastSecondContent);
		GUI.color = Color.white;
		this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 48), (float)Screen.width, 24f), this.versionContent);
		GUI.color = Color.white;
		this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 72), (float)Screen.width, 24f), this.memoryContent);
		for (int i = 0; i < this.loadReports.Count; i++)
		{
			PerformanceHUD.LoadReport loadReport = this.loadReports[i];
			GUI.color = loadReport.Color;
			this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 24 * (i + 4)), (float)Screen.width, 24f), loadReport.Content);
		}
		if (this.fpsFrames && this.instantaneousFrames != null)
		{
			float value = this.instantaneousFrames.Value;
			if (value < 57.5f)
			{
				Color color = Color.yellow;
				if (value < 50.5f)
				{
					color = Color.red;
				}
				GUI.color = color;
				GUI.DrawTexture(new Rect(0f, 0f, 2f, (float)Screen.height), Texture2D.whiteTexture);
				GUI.DrawTexture(new Rect((float)(Screen.width - 2), 0f, 2f, (float)Screen.height), Texture2D.whiteTexture);
				GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, 2f), Texture2D.whiteTexture);
				GUI.DrawTexture(new Rect(0f, (float)(Screen.height - 2), (float)Screen.width, 2f), Texture2D.whiteTexture);
				GUI.color = Color.white;
			}
		}
		if (PerformanceHUD.ShowVibrations)
		{
			GUI.color = Color.white;
			this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 144), (float)Screen.width, 24f), this.vibrationsContent);
		}
		if (GameManager.instance && GameManager.instance.sm)
		{
			SceneManager sm = GameManager.instance.sm;
			string text2 = string.Format("Saturation: {0}, Adjusted: {1}", sm.saturation, sm.AdjustSaturation(sm.saturation));
			GUI.color = Color.white;
			this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 168), (float)Screen.width, 24f), new GUIContent(text2));
		}
		StringBuilder ggInfo = new StringBuilder();
		int lineCount = 0;
		Action<string> action = delegate(string line)
		{
			int lineCount;
			if (lineCount > 0)
			{
				ggInfo.Append('\n');
			}
			ggInfo.Append(line);
			lineCount = lineCount;
			lineCount++;
		};
		Action<string> action2 = delegate(string text)
		{
			ggInfo.Append(text);
		};
		action("Challenge Type: ");
		if (BossSceneController.IsBossScene)
		{
			if (BossSequenceController.IsInSequence)
			{
				action2("Boss Sequence");
			}
			else
			{
				action2("Boss Statue");
			}
			action("Boss Level: ");
			action2(BossSceneController.Instance.BossLevel.ToString());
			action("Boss Health: ");
			if (BossSceneController.Instance.BossHealthLookup.Count > 0)
			{
				using (Dictionary<HealthManager, BossSceneController.BossHealthDetails>.Enumerator enumerator = BossSceneController.Instance.BossHealthLookup.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<HealthManager, BossSceneController.BossHealthDetails> keyValuePair = enumerator.Current;
						action(string.Format(" - {0} - Base: {1}, Adjusted: {2}, Current: {3}", new object[]
						{
							keyValuePair.Key ? keyValuePair.Key.gameObject.name : "(missing)",
							keyValuePair.Value.baseHP,
							keyValuePair.Value.adjustedHP,
							keyValuePair.Key ? keyValuePair.Key.hp.ToString() : "(missing)"
						}));
					}
					goto IL_44F;
				}
			}
			action(" - (none)");
		}
		else
		{
			action2("Regular");
		}
		IL_44F:
		float num = (float)(24 + (lineCount - 1) * 16);
		this.LabelWithShadow(new Rect(0f, (float)(Screen.height - 168) - num, (float)Screen.width, num), new GUIContent(ggInfo.ToString()));
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0003B990 File Offset: 0x00039B90
	private void LabelWithShadow(Rect rect, GUIContent content)
	{
		Vector2 vector = GUI.skin.label.CalcSize(content);
		Color color = GUI.color;
		try
		{
			GUI.color = new Color(0f, 0f, 0f, 0.5f);
			GUI.DrawTexture(new Rect(rect.x, rect.y, vector.x, rect.height), Texture2D.whiteTexture);
			GUI.color = Color.black;
			GUI.Label(new Rect(rect.x + 2f, rect.y + 2f, rect.width, rect.height), content);
			GUI.color = color;
			GUI.Label(new Rect(rect.x + 0f, rect.y + 0f, rect.width, rect.height), content);
		}
		finally
		{
			GUI.color = color;
		}
	}

	// Token: 0x04000C2A RID: 3114
	private static PerformanceHUD shared;

	// Token: 0x04000C2B RID: 3115
	private int frameCounter;

	// Token: 0x04000C2C RID: 3116
	private int lastSecond;

	// Token: 0x04000C2D RID: 3117
	private int framesLastSecond;

	// Token: 0x04000C2E RID: 3118
	private GUIContent framesLastSecondContent;

	// Token: 0x04000C2F RID: 3119
	private Color framesColor;

	// Token: 0x04000C30 RID: 3120
	private bool fpsFrames;

	// Token: 0x04000C31 RID: 3121
	private float? instantaneousFrames;

	// Token: 0x04000C32 RID: 3122
	private int lastScreenWidth;

	// Token: 0x04000C33 RID: 3123
	private int lastScreenHeight;

	// Token: 0x04000C34 RID: 3124
	private GUIContent versionContent;

	// Token: 0x04000C35 RID: 3125
	private GUIContent memoryContent;

	// Token: 0x04000C36 RID: 3126
	private List<PerformanceHUD.LoadReport> loadReports;

	// Token: 0x04000C37 RID: 3127
	public static bool ShowVibrations;

	// Token: 0x04000C38 RID: 3128
	private GUIContent vibrationsContent;

	// Token: 0x02000200 RID: 512
	public class LoadReport
	{
		// Token: 0x04000C39 RID: 3129
		public Color Color;

		// Token: 0x04000C3A RID: 3130
		public GUIContent Content;

		// Token: 0x04000C3B RID: 3131
		public bool DidPost;
	}
}
