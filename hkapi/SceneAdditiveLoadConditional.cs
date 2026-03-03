using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000525 RID: 1317
public class SceneAdditiveLoadConditional : MonoBehaviour
{
	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00086A5F File Offset: 0x00084C5F
	private string SceneNameToLoad
	{
		get
		{
			if (!this.loadAlt)
			{
				return this.sceneNameToLoad;
			}
			return this.altSceneNameToLoad;
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00086A76 File Offset: 0x00084C76
	public static bool ShouldLoadBoss
	{
		get
		{
			return SceneAdditiveLoadConditional.additiveSceneLoads != null && SceneAdditiveLoadConditional.additiveSceneLoads.Count > 0;
		}
	}

	// Token: 0x06001CEC RID: 7404 RVA: 0x00086A90 File Offset: 0x00084C90
	private void OnEnable()
	{
		if (this.sceneNameToLoad != "")
		{
			bool flag = false;
			if (this.saveStateData.id != "" && this.saveStateData.sceneName != "")
			{
				this.saveStateData.semiPersistent = false;
				PersistentBoolData persistentBoolData = SceneData.instance.FindMyState(this.saveStateData);
				if (persistentBoolData != null && persistentBoolData.activated)
				{
					this.skipExtraTests = true;
				}
			}
			if (this.needsPlayerDataBool != "" && GameManager.instance.GetPlayerDataBool(this.needsPlayerDataBool) != this.playerDataBoolValue)
			{
				flag = true;
			}
			if (!flag && this.extraBoolTests != null && this.extraBoolTests.Length != 0 && !this.skipExtraTests)
			{
				foreach (SceneAdditiveLoadConditional.BoolTest boolTest in this.extraBoolTests)
				{
					if (GameManager.instance.GetPlayerDataBool(boolTest.playerDataBool) != boolTest.value)
					{
						flag = true;
					}
				}
			}
			if (!flag && this.needsPlayerDataInt != "" && GameManager.instance.GetPlayerDataInt(this.needsPlayerDataInt) == this.playerDataIntValue != this.isIntValue)
			{
				flag = true;
			}
			if (!flag && this.extraIntTests != null && this.extraIntTests.Length > 1 && !this.skipExtraTests)
			{
				foreach (SceneAdditiveLoadConditional.IntTest intTest in this.extraIntTests)
				{
					int playerDataInt = GameManager.instance.GetPlayerDataInt(intTest.playerDataInt);
					int num = (intTest.otherPlayerDataInt == "") ? intTest.value : GameManager.instance.GetPlayerDataInt(intTest.otherPlayerDataInt);
					bool flag2 = false;
					switch (intTest.testType)
					{
					case SceneAdditiveLoadConditional.IntTest.TestType.Equal:
						flag2 = (playerDataInt == num);
						break;
					case SceneAdditiveLoadConditional.IntTest.TestType.Less:
						flag2 = (playerDataInt < num);
						break;
					case SceneAdditiveLoadConditional.IntTest.TestType.More:
						flag2 = (playerDataInt > num);
						break;
					case SceneAdditiveLoadConditional.IntTest.TestType.NotEqual:
						flag2 = (playerDataInt != num);
						break;
					case SceneAdditiveLoadConditional.IntTest.TestType.LessOrEqual:
						flag2 = (playerDataInt <= num);
						break;
					case SceneAdditiveLoadConditional.IntTest.TestType.MoreOrEqual:
						flag2 = (playerDataInt >= num);
						break;
					}
					if (!flag2)
					{
						flag = true;
					}
				}
			}
			if (!flag && this.usePersistentBoolItem)
			{
				PersistentBoolData persistentBoolData2 = SceneData.instance.FindMyState(this.persistentBoolData);
				if (persistentBoolData2 != null && persistentBoolData2.activated)
				{
					flag = true;
				}
			}
			if (GameManager.instance.entryGateName != "dreamGate" && !flag && this.doorTrigger != "" && TransitionPoint.lastEntered != this.doorTrigger)
			{
				flag = true;
			}
			if (flag)
			{
				if (this.altSceneNameToLoad == "")
				{
					return;
				}
				this.loadAlt = true;
			}
			else if (this.saveStateData.id != "" && this.saveStateData.sceneName != "")
			{
				this.saveStateData.activated = true;
				SceneData.instance.SaveMyState(this.saveStateData);
			}
			if (SceneAdditiveLoadConditional.loadInSequence)
			{
				SceneAdditiveLoadConditional.additiveSceneLoads.Add(this);
				return;
			}
			base.StartCoroutine(this.LoadRoutine(true));
		}
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x00086DC8 File Offset: 0x00084FC8
	private void OnDisable()
	{
		if (this.sceneLoaded)
		{
			SceneAdditiveLoadConditional.additiveSceneLoads.Remove(this);
			UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(this.SceneNameToLoad);
		}
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x00086DEA File Offset: 0x00084FEA
	public static IEnumerator LoadAll()
	{
		return new SceneAdditiveLoadConditional.<LoadAll>d__26(0);
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00086DF2 File Offset: 0x00084FF2
	private IEnumerator LoadRoutine(bool callEvent = false)
	{
		bool inSequence = SceneAdditiveLoadConditional.loadInSequence;
		yield return null;
		AsyncOperation asyncOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(this.SceneNameToLoad, LoadSceneMode.Additive);
		yield return asyncOperation;
		Debug.Log("Additively loaded scene: " + this.SceneNameToLoad + (inSequence ? " in sequence" : " out of sequence"));
		this.sceneLoaded = true;
		if (callEvent && GameManager.instance)
		{
			GameManager.instance.LoadedBoss();
		}
		yield break;
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00086E08 File Offset: 0x00085008
	public SceneAdditiveLoadConditional()
	{
		this.sceneNameToLoad = "";
		this.altSceneNameToLoad = "";
		this.needsPlayerDataBool = "";
		this.needsPlayerDataInt = "";
		this.doorTrigger = "";
		base..ctor();
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x00086E47 File Offset: 0x00085047
	// Note: this type is marked as 'beforefieldinit'.
	static SceneAdditiveLoadConditional()
	{
		SceneAdditiveLoadConditional.additiveSceneLoads = new List<SceneAdditiveLoadConditional>();
		SceneAdditiveLoadConditional.loadInSequence = false;
	}

	// Token: 0x0400224E RID: 8782
	public string sceneNameToLoad;

	// Token: 0x0400224F RID: 8783
	public string altSceneNameToLoad;

	// Token: 0x04002250 RID: 8784
	private bool loadAlt;

	// Token: 0x04002251 RID: 8785
	[Header("Main Tests")]
	public string needsPlayerDataBool;

	// Token: 0x04002252 RID: 8786
	public bool playerDataBoolValue;

	// Token: 0x04002253 RID: 8787
	[Space]
	public string needsPlayerDataInt;

	// Token: 0x04002254 RID: 8788
	public int playerDataIntValue;

	// Token: 0x04002255 RID: 8789
	public bool isIntValue;

	// Token: 0x04002256 RID: 8790
	[Header("Extra tests (not tested if persistent bool true)")]
	public SceneAdditiveLoadConditional.BoolTest[] extraBoolTests;

	// Token: 0x04002257 RID: 8791
	[Space]
	public SceneAdditiveLoadConditional.IntTest[] extraIntTests;

	// Token: 0x04002258 RID: 8792
	[Space]
	public bool usePersistentBoolItem;

	// Token: 0x04002259 RID: 8793
	public PersistentBoolData persistentBoolData;

	// Token: 0x0400225A RID: 8794
	[Space]
	public string doorTrigger;

	// Token: 0x0400225B RID: 8795
	private bool sceneLoaded;

	// Token: 0x0400225C RID: 8796
	[Header("Save State On Load (not required)")]
	public PersistentBoolData saveStateData;

	// Token: 0x0400225D RID: 8797
	private bool skipExtraTests;

	// Token: 0x0400225E RID: 8798
	private static List<SceneAdditiveLoadConditional> additiveSceneLoads;

	// Token: 0x0400225F RID: 8799
	public static bool loadInSequence;

	// Token: 0x02000526 RID: 1318
	[Serializable]
	public struct BoolTest
	{
		// Token: 0x04002260 RID: 8800
		public string playerDataBool;

		// Token: 0x04002261 RID: 8801
		public bool value;
	}

	// Token: 0x02000527 RID: 1319
	[Serializable]
	public struct IntTest
	{
		// Token: 0x04002262 RID: 8802
		public string playerDataInt;

		// Token: 0x04002263 RID: 8803
		public string otherPlayerDataInt;

		// Token: 0x04002264 RID: 8804
		public int value;

		// Token: 0x04002265 RID: 8805
		public SceneAdditiveLoadConditional.IntTest.TestType testType;

		// Token: 0x02000528 RID: 1320
		public enum TestType
		{
			// Token: 0x04002267 RID: 8807
			Equal,
			// Token: 0x04002268 RID: 8808
			Less,
			// Token: 0x04002269 RID: 8809
			More,
			// Token: 0x0400226A RID: 8810
			NotEqual,
			// Token: 0x0400226B RID: 8811
			LessOrEqual,
			// Token: 0x0400226C RID: 8812
			MoreOrEqual
		}
	}
}
