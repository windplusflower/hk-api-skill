using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020004EF RID: 1263
public class SceneLoad
{
	// Token: 0x1700035C RID: 860
	// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000848A4 File Offset: 0x00082AA4
	public string TargetSceneName
	{
		get
		{
			return this.targetSceneName;
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000848AC File Offset: 0x00082AAC
	// (set) Token: 0x06001BDF RID: 7135 RVA: 0x000848B4 File Offset: 0x00082AB4
	public bool IsFetchAllowed { get; set; }

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000848BD File Offset: 0x00082ABD
	// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x000848C5 File Offset: 0x00082AC5
	public bool IsActivationAllowed { get; set; }

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000848CE File Offset: 0x00082ACE
	// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x000848D6 File Offset: 0x00082AD6
	public bool IsUnloadAssetsRequired { get; set; }

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000848DF File Offset: 0x00082ADF
	// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000848E7 File Offset: 0x00082AE7
	public bool IsGarbageCollectRequired { get; set; }

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000848F0 File Offset: 0x00082AF0
	// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x000848F8 File Offset: 0x00082AF8
	public bool IsFinished { get; private set; }

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00084904 File Offset: 0x00082B04
	public SceneLoad(MonoBehaviour runner, string targetSceneName)
	{
		this.runner = runner;
		this.targetSceneName = targetSceneName;
		this.phaseInfos = new SceneLoad.PhaseInfo[8];
		for (int i = 0; i < 8; i++)
		{
			this.phaseInfos[i] = new SceneLoad.PhaseInfo
			{
				BeginTime = null
			};
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00084956 File Offset: 0x00082B56
	public float? BeginTime
	{
		get
		{
			return this.phaseInfos[0].BeginTime;
		}
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00084965 File Offset: 0x00082B65
	private void RecordBeginTime(SceneLoad.Phases phase)
	{
		this.phaseInfos[(int)phase].BeginTime = new float?(Time.realtimeSinceStartup);
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x0008497E File Offset: 0x00082B7E
	private void RecordEndTime(SceneLoad.Phases phase)
	{
		this.phaseInfos[(int)phase].EndTime = new float?(Time.realtimeSinceStartup);
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x00084998 File Offset: 0x00082B98
	public float? GetDuration(SceneLoad.Phases phase)
	{
		SceneLoad.PhaseInfo phaseInfo = this.phaseInfos[(int)phase];
		if (phaseInfo.BeginTime != null && phaseInfo.EndTime != null)
		{
			return new float?(phaseInfo.EndTime.Value - phaseInfo.BeginTime.Value);
		}
		return null;
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000849EE File Offset: 0x00082BEE
	public void Begin()
	{
		this.runner.StartCoroutine(this.BeginRoutine());
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x00084A02 File Offset: 0x00082C02
	private IEnumerator BeginRoutine()
	{
		SceneAdditiveLoadConditional.loadInSequence = true;
		yield return this.runner.StartCoroutine(ScenePreloader.FinishPendingOperations());
		this.RecordBeginTime(SceneLoad.Phases.FetchBlocked);
		while (!this.IsFetchAllowed)
		{
			yield return null;
		}
		this.RecordEndTime(SceneLoad.Phases.FetchBlocked);
		this.RecordBeginTime(SceneLoad.Phases.Fetch);
		AsyncOperation loadOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(this.targetSceneName, LoadSceneMode.Additive);
		loadOperation.allowSceneActivation = false;
		while (loadOperation.progress < 0.9f)
		{
			yield return null;
		}
		this.RecordEndTime(SceneLoad.Phases.Fetch);
		if (this.FetchComplete != null)
		{
			try
			{
				this.FetchComplete();
			}
			catch (Exception exception)
			{
				Debug.LogError("Exception in responders to SceneLoad.FetchComplete. Attempting to continue load regardless.");
				Debug.LogException(exception);
			}
		}
		this.RecordBeginTime(SceneLoad.Phases.ActivationBlocked);
		while (!this.IsActivationAllowed)
		{
			yield return null;
		}
		this.RecordEndTime(SceneLoad.Phases.ActivationBlocked);
		this.RecordBeginTime(SceneLoad.Phases.Activation);
		if (this.WillActivate != null)
		{
			try
			{
				this.WillActivate();
			}
			catch (Exception exception2)
			{
				Debug.LogError("Exception in responders to SceneLoad.WillActivate. Attempting to continue load regardless.");
				Debug.LogException(exception2);
			}
		}
		loadOperation.allowSceneActivation = true;
		yield return loadOperation;
		this.RecordEndTime(SceneLoad.Phases.Activation);
		if (this.ActivationComplete != null)
		{
			try
			{
				this.ActivationComplete();
			}
			catch (Exception exception3)
			{
				Debug.LogError("Exception in responders to SceneLoad.ActivationComplete. Attempting to continue load regardless.");
				Debug.LogException(exception3);
			}
		}
		this.RecordBeginTime(SceneLoad.Phases.UnloadUnusedAssets);
		if (this.IsUnloadAssetsRequired)
		{
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
			yield return asyncOperation;
		}
		this.RecordEndTime(SceneLoad.Phases.UnloadUnusedAssets);
		this.RecordBeginTime(SceneLoad.Phases.GarbageCollect);
		if (this.IsGarbageCollectRequired)
		{
			GCManager.Collect();
		}
		this.RecordEndTime(SceneLoad.Phases.GarbageCollect);
		if (this.Complete != null)
		{
			try
			{
				this.Complete();
			}
			catch (Exception exception4)
			{
				Debug.LogError("Exception in responders to SceneLoad.Complete. Attempting to continue load regardless.");
				Debug.LogException(exception4);
			}
		}
		this.RecordBeginTime(SceneLoad.Phases.StartCall);
		yield return null;
		this.RecordEndTime(SceneLoad.Phases.StartCall);
		if (this.StartCalled != null)
		{
			try
			{
				this.StartCalled();
			}
			catch (Exception exception5)
			{
				Debug.LogError("Exception in responders to SceneLoad.StartCalled. Attempting to continue load regardless.");
				Debug.LogException(exception5);
			}
		}
		if (SceneAdditiveLoadConditional.ShouldLoadBoss)
		{
			this.RecordBeginTime(SceneLoad.Phases.LoadBoss);
			yield return this.runner.StartCoroutine(SceneAdditiveLoadConditional.LoadAll());
			this.RecordEndTime(SceneLoad.Phases.LoadBoss);
			try
			{
				if (this.BossLoaded != null)
				{
					this.BossLoaded();
				}
				if (GameManager.instance)
				{
					GameManager.instance.LoadedBoss();
				}
			}
			catch (Exception exception6)
			{
				Debug.LogError("Exception in responders to SceneLoad.BossLoaded. Attempting to continue load regardless.");
				Debug.LogException(exception6);
			}
		}
		try
		{
			ScenePreloader.Cleanup();
		}
		catch (Exception exception7)
		{
			Debug.LogError("Exception in responders to ScenePreloader.Cleanup. Attempting to continue load regardless.");
			Debug.LogException(exception7);
		}
		this.IsFinished = true;
		if (this.Finish != null)
		{
			try
			{
				this.Finish();
				yield break;
			}
			catch (Exception exception8)
			{
				Debug.LogError("Exception in responders to SceneLoad.Finish. Attempting to continue load regardless.");
				Debug.LogException(exception8);
				yield break;
			}
		}
		yield break;
	}

	// Token: 0x14000039 RID: 57
	// (add) Token: 0x06001BEF RID: 7151 RVA: 0x00084A14 File Offset: 0x00082C14
	// (remove) Token: 0x06001BF0 RID: 7152 RVA: 0x00084A4C File Offset: 0x00082C4C
	public event SceneLoad.FetchCompleteDelegate FetchComplete;

	// Token: 0x1400003A RID: 58
	// (add) Token: 0x06001BF1 RID: 7153 RVA: 0x00084A84 File Offset: 0x00082C84
	// (remove) Token: 0x06001BF2 RID: 7154 RVA: 0x00084ABC File Offset: 0x00082CBC
	public event SceneLoad.WillActivateDelegate WillActivate;

	// Token: 0x1400003B RID: 59
	// (add) Token: 0x06001BF3 RID: 7155 RVA: 0x00084AF4 File Offset: 0x00082CF4
	// (remove) Token: 0x06001BF4 RID: 7156 RVA: 0x00084B2C File Offset: 0x00082D2C
	public event SceneLoad.ActivationCompleteDelegate ActivationComplete;

	// Token: 0x1400003C RID: 60
	// (add) Token: 0x06001BF5 RID: 7157 RVA: 0x00084B64 File Offset: 0x00082D64
	// (remove) Token: 0x06001BF6 RID: 7158 RVA: 0x00084B9C File Offset: 0x00082D9C
	public event SceneLoad.CompleteDelegate Complete;

	// Token: 0x1400003D RID: 61
	// (add) Token: 0x06001BF7 RID: 7159 RVA: 0x00084BD4 File Offset: 0x00082DD4
	// (remove) Token: 0x06001BF8 RID: 7160 RVA: 0x00084C0C File Offset: 0x00082E0C
	public event SceneLoad.StartCalledDelegate StartCalled;

	// Token: 0x1400003E RID: 62
	// (add) Token: 0x06001BF9 RID: 7161 RVA: 0x00084C44 File Offset: 0x00082E44
	// (remove) Token: 0x06001BFA RID: 7162 RVA: 0x00084C7C File Offset: 0x00082E7C
	public event SceneLoad.BossLoadCompleteDelegate BossLoaded;

	// Token: 0x1400003F RID: 63
	// (add) Token: 0x06001BFB RID: 7163 RVA: 0x00084CB4 File Offset: 0x00082EB4
	// (remove) Token: 0x06001BFC RID: 7164 RVA: 0x00084CEC File Offset: 0x00082EEC
	public event SceneLoad.FinishDelegate Finish;

	// Token: 0x040021C4 RID: 8644
	private readonly MonoBehaviour runner;

	// Token: 0x040021C5 RID: 8645
	private readonly string targetSceneName;

	// Token: 0x040021C6 RID: 8646
	public const int PhaseCount = 8;

	// Token: 0x040021C7 RID: 8647
	private readonly SceneLoad.PhaseInfo[] phaseInfos;

	// Token: 0x020004F0 RID: 1264
	public enum Phases
	{
		// Token: 0x040021D5 RID: 8661
		FetchBlocked,
		// Token: 0x040021D6 RID: 8662
		Fetch,
		// Token: 0x040021D7 RID: 8663
		ActivationBlocked,
		// Token: 0x040021D8 RID: 8664
		Activation,
		// Token: 0x040021D9 RID: 8665
		UnloadUnusedAssets,
		// Token: 0x040021DA RID: 8666
		GarbageCollect,
		// Token: 0x040021DB RID: 8667
		StartCall,
		// Token: 0x040021DC RID: 8668
		LoadBoss
	}

	// Token: 0x020004F1 RID: 1265
	private class PhaseInfo
	{
		// Token: 0x040021DD RID: 8669
		public float? BeginTime;

		// Token: 0x040021DE RID: 8670
		public float? EndTime;
	}

	// Token: 0x020004F2 RID: 1266
	// (Invoke) Token: 0x06001BFF RID: 7167
	public delegate void FetchCompleteDelegate();

	// Token: 0x020004F3 RID: 1267
	// (Invoke) Token: 0x06001C03 RID: 7171
	public delegate void WillActivateDelegate();

	// Token: 0x020004F4 RID: 1268
	// (Invoke) Token: 0x06001C07 RID: 7175
	public delegate void ActivationCompleteDelegate();

	// Token: 0x020004F5 RID: 1269
	// (Invoke) Token: 0x06001C0B RID: 7179
	public delegate void CompleteDelegate();

	// Token: 0x020004F6 RID: 1270
	// (Invoke) Token: 0x06001C0F RID: 7183
	public delegate void StartCalledDelegate();

	// Token: 0x020004F7 RID: 1271
	// (Invoke) Token: 0x06001C13 RID: 7187
	public delegate void BossLoadCompleteDelegate();

	// Token: 0x020004F8 RID: 1272
	// (Invoke) Token: 0x06001C17 RID: 7191
	public delegate void FinishDelegate();
}
