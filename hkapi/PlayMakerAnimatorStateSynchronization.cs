using System;
using System.Collections.Generic;
using System.Reflection;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class PlayMakerAnimatorStateSynchronization : MonoBehaviour
{
	// Token: 0x060000D3 RID: 211 RVA: 0x00004F44 File Offset: 0x00003144
	private void Start()
	{
		this.animator = base.GetComponent<Animator>();
		if (this.Fsm != null)
		{
			string layerName = this.animator.GetLayerName(this.LayerIndex);
			this.fsmStateLUT = new Dictionary<int, FsmState>();
			foreach (FsmState fsmState in this.Fsm.Fsm.States)
			{
				string name = fsmState.Name;
				this.RegisterHash(fsmState.Name, fsmState);
				if (!name.StartsWith(layerName + "."))
				{
					this.RegisterHash(layerName + "." + fsmState.Name, fsmState);
				}
			}
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00004FEC File Offset: 0x000031EC
	private void RegisterHash(string key, FsmState state)
	{
		int key2 = Animator.StringToHash(key);
		this.fsmStateLUT.Add(key2, state);
		if (this.debug)
		{
			Debug.Log("registered " + key + " ->" + key2.ToString());
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00005031 File Offset: 0x00003231
	private void Update()
	{
		if (this.EveryFrame)
		{
			this.Synchronize();
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00005044 File Offset: 0x00003244
	public void Synchronize()
	{
		if (this.animator == null || this.Fsm == null)
		{
			return;
		}
		bool flag = false;
		if (this.animator.IsInTransition(this.LayerIndex))
		{
			int nameHash = this.animator.GetAnimatorTransitionInfo(this.LayerIndex).nameHash;
			int userNameHash = this.animator.GetAnimatorTransitionInfo(this.LayerIndex).userNameHash;
			if (this.lastTransition != nameHash)
			{
				if (this.debug)
				{
					Debug.Log("is in transition");
				}
				if (this.fsmStateLUT.ContainsKey(userNameHash))
				{
					FsmState fsmState = this.fsmStateLUT[userNameHash];
					if (this.Fsm.Fsm.ActiveState != fsmState)
					{
						this.SwitchState(this.Fsm.Fsm, fsmState);
						flag = true;
					}
				}
				if (!flag && this.fsmStateLUT.ContainsKey(nameHash))
				{
					FsmState fsmState2 = this.fsmStateLUT[nameHash];
					if (this.Fsm.Fsm.ActiveState != fsmState2)
					{
						this.SwitchState(this.Fsm.Fsm, fsmState2);
						flag = true;
					}
				}
				if (!flag && this.debug)
				{
					Debug.LogWarning("Fsm is missing animator transition name or username for hash:" + nameHash.ToString());
				}
				this.lastTransition = nameHash;
			}
		}
		if (!flag)
		{
			int nameHash2 = this.animator.GetCurrentAnimatorStateInfo(this.LayerIndex).nameHash;
			if (this.lastState != nameHash2)
			{
				if (this.debug)
				{
					Debug.Log("Net state switch");
				}
				if (this.fsmStateLUT.ContainsKey(nameHash2))
				{
					FsmState fsmState3 = this.fsmStateLUT[nameHash2];
					if (this.Fsm.Fsm.ActiveState != fsmState3)
					{
						this.SwitchState(this.Fsm.Fsm, fsmState3);
					}
				}
				else if (this.debug)
				{
					Debug.LogWarning("Fsm is missing animator state hash:" + nameHash2.ToString());
				}
				this.lastState = nameHash2;
			}
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000523C File Offset: 0x0000343C
	private void SwitchState(Fsm fsm, FsmState state)
	{
		MethodInfo method = fsm.GetType().GetMethod("SwitchState", BindingFlags.Instance | BindingFlags.NonPublic);
		if (method != null)
		{
			method.Invoke(fsm, new object[]
			{
				state
			});
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00005277 File Offset: 0x00003477
	public PlayMakerAnimatorStateSynchronization()
	{
		this.EveryFrame = true;
		base..ctor();
	}

	// Token: 0x0400006F RID: 111
	public int LayerIndex;

	// Token: 0x04000070 RID: 112
	public PlayMakerFSM Fsm;

	// Token: 0x04000071 RID: 113
	public bool EveryFrame;

	// Token: 0x04000072 RID: 114
	public bool debug;

	// Token: 0x04000073 RID: 115
	private Animator animator;

	// Token: 0x04000074 RID: 116
	private int lastState;

	// Token: 0x04000075 RID: 117
	private int lastTransition;

	// Token: 0x04000076 RID: 118
	private Dictionary<int, FsmState> fsmStateLUT;
}
