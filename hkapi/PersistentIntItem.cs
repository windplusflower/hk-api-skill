using System;
using UnityEngine;

// Token: 0x02000523 RID: 1315
public class PersistentIntItem : MonoBehaviour
{
	// Token: 0x06001CDE RID: 7390 RVA: 0x000867A4 File Offset: 0x000849A4
	private void Awake()
	{
		this.persistentIntData.semiPersistent = this.semiPersistent;
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x000867B8 File Offset: 0x000849B8
	private void OnEnable()
	{
		this.gm = GameManager.instance;
		this.gm.SavePersistentObjects += this.SaveState;
		if (this.semiPersistent)
		{
			this.gm.ResetSemiPersistentObjects += this.ResetState;
		}
		this.LookForMyFSM();
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x0008680C File Offset: 0x00084A0C
	private void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.SavePersistentObjects -= this.SaveState;
			this.gm.ResetSemiPersistentObjects -= this.ResetState;
		}
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x0008684C File Offset: 0x00084A4C
	private void Start()
	{
		this.SetMyID();
		PersistentIntData persistentIntData = SceneData.instance.FindMyState(this.persistentIntData);
		if (persistentIntData == null)
		{
			this.UpdateValueFromFSM();
			return;
		}
		this.persistentIntData.value = persistentIntData.value;
		if (this.myFSM != null)
		{
			this.myFSM.FsmVariables.GetFsmInt("Value").Value = persistentIntData.value;
			return;
		}
		this.LookForMyFSM();
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x000868C0 File Offset: 0x00084AC0
	private void SaveState()
	{
		this.SetMyID();
		this.UpdateValueFromFSM();
		SceneData.instance.SaveMyState(this.persistentIntData);
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x000868DE File Offset: 0x00084ADE
	private void ResetState()
	{
		if (this.semiPersistent)
		{
			this.persistentIntData.value = -1;
			if (this.myFSM != null)
			{
				this.myFSM.SendEvent("RESET");
				return;
			}
			Debug.LogError("Persistent Bool Item - Couldn't reset value on FSM because it's missing.");
		}
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x00086920 File Offset: 0x00084B20
	private void SetMyID()
	{
		if (string.IsNullOrEmpty(this.persistentIntData.id))
		{
			this.persistentIntData.id = base.name;
		}
		if (string.IsNullOrEmpty(this.persistentIntData.sceneName))
		{
			this.persistentIntData.sceneName = GameManager.GetBaseSceneName(base.gameObject.scene.name);
		}
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x00086985 File Offset: 0x00084B85
	private void UpdateValueFromFSM()
	{
		if (this.myFSM != null)
		{
			this.persistentIntData.value = this.myFSM.FsmVariables.GetFsmInt("Value").Value;
			return;
		}
		this.LookForMyFSM();
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x000869C1 File Offset: 0x00084BC1
	private void SetValueOnFSM(int newValue)
	{
		if (this.myFSM != null)
		{
			this.myFSM.FsmVariables.GetFsmInt("Value").Value = newValue;
		}
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x000869EC File Offset: 0x00084BEC
	private void LookForMyFSM()
	{
		PlayMakerFSM[] components = base.GetComponents<PlayMakerFSM>();
		if (components == null)
		{
			Debug.LogErrorFormat("Persistent Int Item ({0}) does not have a PlayMakerFSM attached to read state from.", new object[]
			{
				base.name
			});
			return;
		}
		this.myFSM = FSMUtility.FindFSMWithPersistentInt(components);
		if (this.myFSM == null)
		{
			Debug.LogErrorFormat("Persistent Int Item ({0}) does not have a PlayMakerFSM attached to read state from.", new object[]
			{
				base.name
			});
		}
	}

	// Token: 0x04002246 RID: 8774
	[SerializeField]
	[Tooltip("If checked, this object will reset its state under certain circumstances such as hero death.")]
	public bool semiPersistent;

	// Token: 0x04002247 RID: 8775
	[SerializeField]
	public PersistentIntData persistentIntData;

	// Token: 0x04002248 RID: 8776
	private GameManager gm;

	// Token: 0x04002249 RID: 8777
	private PlayMakerFSM myFSM;
}
