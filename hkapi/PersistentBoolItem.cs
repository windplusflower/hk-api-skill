using System;
using UnityEngine;

// Token: 0x0200051D RID: 1309
public class PersistentBoolItem : MonoBehaviour
{
	// Token: 0x14000040 RID: 64
	// (add) Token: 0x06001CBF RID: 7359 RVA: 0x0008626C File Offset: 0x0008446C
	// (remove) Token: 0x06001CC0 RID: 7360 RVA: 0x000862A4 File Offset: 0x000844A4
	public event PersistentBoolItem.BoolEvent OnSetSaveState;

	// Token: 0x14000041 RID: 65
	// (add) Token: 0x06001CC1 RID: 7361 RVA: 0x000862DC File Offset: 0x000844DC
	// (remove) Token: 0x06001CC2 RID: 7362 RVA: 0x00086314 File Offset: 0x00084514
	public event PersistentBoolItem.BoolRefEvent OnGetSaveState;

	// Token: 0x06001CC3 RID: 7363 RVA: 0x00086349 File Offset: 0x00084549
	private void Awake()
	{
		this.persistentBoolData.semiPersistent = this.semiPersistent;
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x0008635C File Offset: 0x0008455C
	private void OnEnable()
	{
		this.gm = GameManager.instance;
		this.gm.SavePersistentObjects += this.SaveState;
		if (this.semiPersistent)
		{
			this.gm.ResetSemiPersistentObjects += this.ResetState;
		}
		if (this.OnGetSaveState == null)
		{
			this.LookForMyFSM();
		}
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x000863B8 File Offset: 0x000845B8
	private void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.SavePersistentObjects -= this.SaveState;
			this.gm.ResetSemiPersistentObjects -= this.ResetState;
		}
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x000863F8 File Offset: 0x000845F8
	private void Start()
	{
		if (this.started)
		{
			return;
		}
		this.SetMyID();
		PersistentBoolData persistentBoolData = SceneData.instance.FindMyState(this.persistentBoolData);
		if (persistentBoolData != null)
		{
			this.persistentBoolData.activated = persistentBoolData.activated;
			if (this.OnSetSaveState != null)
			{
				this.OnSetSaveState(persistentBoolData.activated);
				return;
			}
			if (this.myFSM != null)
			{
				this.myFSM.FsmVariables.FindFsmBool("Activated").Value = persistentBoolData.activated;
				return;
			}
			this.LookForMyFSM();
			return;
		}
		else
		{
			if (this.OnGetSaveState != null)
			{
				this.OnGetSaveState(ref this.persistentBoolData.activated);
				return;
			}
			this.UpdateActivatedFromFSM();
			return;
		}
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x000864AE File Offset: 0x000846AE
	public void SaveState()
	{
		this.SetMyID();
		if (this.OnGetSaveState != null)
		{
			this.OnGetSaveState(ref this.persistentBoolData.activated);
		}
		else
		{
			this.UpdateActivatedFromFSM();
		}
		SceneData.instance.SaveMyState(this.persistentBoolData);
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x000864EC File Offset: 0x000846EC
	private void ResetState()
	{
		if (this.semiPersistent)
		{
			this.persistentBoolData.activated = false;
			if (this.myFSM != null)
			{
				this.myFSM.SendEvent("RESET");
				return;
			}
			Debug.LogWarning("Persistent Bool Item - Couldn't reset value on FSM because it's missing.");
		}
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x0008652C File Offset: 0x0008472C
	private void SetMyID()
	{
		if (string.IsNullOrEmpty(this.persistentBoolData.id))
		{
			this.persistentBoolData.id = base.name;
		}
		if (string.IsNullOrEmpty(this.persistentBoolData.sceneName))
		{
			this.persistentBoolData.sceneName = GameManager.GetBaseSceneName(base.gameObject.scene.name);
		}
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x00086591 File Offset: 0x00084791
	public void PreSetup()
	{
		this.Start();
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00086599 File Offset: 0x00084799
	private void UpdateActivatedFromFSM()
	{
		if (this.myFSM != null)
		{
			this.persistentBoolData.activated = this.myFSM.FsmVariables.FindFsmBool("Activated").Value;
			return;
		}
		this.LookForMyFSM();
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x000865D8 File Offset: 0x000847D8
	private void LookForMyFSM()
	{
		PlayMakerFSM[] components = base.GetComponents<PlayMakerFSM>();
		if (components == null)
		{
			Debug.LogErrorFormat("Persistent Bool Item ({0}) does not have a PlayMakerFSM attached to read state from.", new object[]
			{
				base.name
			});
			return;
		}
		this.myFSM = FSMUtility.FindFSMWithPersistentBool(components);
		if (this.myFSM == null)
		{
			Debug.LogErrorFormat("Persistent Bool Item ({0}) does not have a PlayMakerFSM attached to read state from.", new object[]
			{
				base.name
			});
		}
	}

	// Token: 0x04002235 RID: 8757
	[SerializeField]
	public bool semiPersistent;

	// Token: 0x04002236 RID: 8758
	[SerializeField]
	public PersistentBoolData persistentBoolData;

	// Token: 0x04002239 RID: 8761
	private GameManager gm;

	// Token: 0x0400223A RID: 8762
	private PlayMakerFSM myFSM;

	// Token: 0x0400223B RID: 8763
	private bool started;

	// Token: 0x0200051E RID: 1310
	// (Invoke) Token: 0x06001CCF RID: 7375
	public delegate void BoolEvent(bool value);

	// Token: 0x0200051F RID: 1311
	// (Invoke) Token: 0x06001CD3 RID: 7379
	public delegate void BoolRefEvent(ref bool value);
}
