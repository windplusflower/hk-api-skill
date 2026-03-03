using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020004DB RID: 1243
public static class FSMUtility
{
	// Token: 0x06001B90 RID: 7056 RVA: 0x00083BB8 File Offset: 0x00081DB8
	private static List<PlayMakerFSM> ObtainFsmList()
	{
		if (FSMUtility.fsmListPool.Count > 0)
		{
			List<PlayMakerFSM> result = FSMUtility.fsmListPool[FSMUtility.fsmListPool.Count - 1];
			FSMUtility.fsmListPool.RemoveAt(FSMUtility.fsmListPool.Count - 1);
			return result;
		}
		return new List<PlayMakerFSM>();
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x00083C04 File Offset: 0x00081E04
	private static void ReleaseFsmList(List<PlayMakerFSM> fsmList)
	{
		fsmList.Clear();
		if (FSMUtility.fsmListPool.Count < 20)
		{
			FSMUtility.fsmListPool.Add(fsmList);
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00083C28 File Offset: 0x00081E28
	public static bool ContainsFSM(GameObject go, string fsmName)
	{
		if (go == null)
		{
			return false;
		}
		List<PlayMakerFSM> list = FSMUtility.ObtainFsmList();
		go.GetComponents<PlayMakerFSM>(list);
		bool result = false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].FsmName == fsmName)
			{
				result = true;
				break;
			}
		}
		FSMUtility.ReleaseFsmList(list);
		return result;
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x00083C80 File Offset: 0x00081E80
	public static PlayMakerFSM LocateFSM(GameObject go, string fsmName)
	{
		if (go == null)
		{
			return null;
		}
		List<PlayMakerFSM> list = FSMUtility.ObtainFsmList();
		go.GetComponents<PlayMakerFSM>(list);
		PlayMakerFSM result = null;
		for (int i = 0; i < list.Count; i++)
		{
			PlayMakerFSM playMakerFSM = list[i];
			if (playMakerFSM.FsmName == fsmName)
			{
				result = playMakerFSM;
				break;
			}
		}
		FSMUtility.ReleaseFsmList(list);
		return result;
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x00083CD9 File Offset: 0x00081ED9
	public static PlayMakerFSM LocateMyFSM(this GameObject go, string fsmName)
	{
		return FSMUtility.LocateFSM(go, fsmName);
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x00083CE2 File Offset: 0x00081EE2
	public static PlayMakerFSM GetFSM(GameObject go)
	{
		return go.GetComponent<PlayMakerFSM>();
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x00083CEA File Offset: 0x00081EEA
	public static void SendEventToGameObject(GameObject go, string eventName, bool isRecursive = false)
	{
		if (go != null)
		{
			FSMUtility.SendEventToGameObject(go, FsmEvent.FindEvent(eventName), isRecursive);
		}
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x00083D04 File Offset: 0x00081F04
	public static void SendEventToGameObject(GameObject go, FsmEvent ev, bool isRecursive = false)
	{
		if (go != null)
		{
			List<PlayMakerFSM> list = FSMUtility.ObtainFsmList();
			go.GetComponents<PlayMakerFSM>(list);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Fsm.Event(ev);
			}
			FSMUtility.ReleaseFsmList(list);
			if (isRecursive)
			{
				Transform transform = go.transform;
				for (int j = 0; j < transform.childCount; j++)
				{
					FSMUtility.SendEventToGameObject(transform.GetChild(j).gameObject, ev, isRecursive);
				}
			}
		}
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00083D7E File Offset: 0x00081F7E
	public static GameObject GetSafe(this FsmOwnerDefault ownerDefault, FsmStateAction stateAction)
	{
		if (ownerDefault.OwnerOption == OwnerDefaultOption.UseOwner)
		{
			return stateAction.Owner;
		}
		return ownerDefault.GameObject.Value;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x00083D9A File Offset: 0x00081F9A
	public static bool GetBool(PlayMakerFSM fsm, string variableName)
	{
		return fsm.FsmVariables.FindFsmBool(variableName).Value;
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x00083DAD File Offset: 0x00081FAD
	public static int GetInt(PlayMakerFSM fsm, string variableName)
	{
		return fsm.FsmVariables.FindFsmInt(variableName).Value;
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x00083DC0 File Offset: 0x00081FC0
	public static float GetFloat(PlayMakerFSM fsm, string variableName)
	{
		return fsm.FsmVariables.FindFsmFloat(variableName).Value;
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x00083DD3 File Offset: 0x00081FD3
	public static string GetString(PlayMakerFSM fsm, string variableName)
	{
		return fsm.FsmVariables.FindFsmString(variableName).Value;
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x00083DE6 File Offset: 0x00081FE6
	public static Vector3 GetVector3(PlayMakerFSM fsm, string variableName)
	{
		return fsm.FsmVariables.FindFsmVector3(variableName).Value;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00083DF9 File Offset: 0x00081FF9
	public static void SetBool(PlayMakerFSM fsm, string variableName, bool value)
	{
		fsm.FsmVariables.GetFsmBool(variableName).Value = value;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00083E0D File Offset: 0x0008200D
	public static void SetInt(PlayMakerFSM fsm, string variableName, int value)
	{
		fsm.FsmVariables.GetFsmInt(variableName).Value = value;
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00083E21 File Offset: 0x00082021
	public static void SetFloat(PlayMakerFSM fsm, string variableName, float value)
	{
		fsm.FsmVariables.GetFsmFloat(variableName).Value = value;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00083E35 File Offset: 0x00082035
	public static void SetString(PlayMakerFSM fsm, string variableName, string value)
	{
		fsm.FsmVariables.GetFsmString(variableName).Value = value;
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00083E4C File Offset: 0x0008204C
	public static PlayMakerFSM FindFSMWithPersistentBool(PlayMakerFSM[] fsmArray)
	{
		for (int i = 0; i < fsmArray.Length; i++)
		{
			if (fsmArray[i].FsmVariables.FindFsmBool("Activated") != null)
			{
				return fsmArray[i];
			}
		}
		return null;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x00083E80 File Offset: 0x00082080
	public static PlayMakerFSM FindFSMWithPersistentInt(PlayMakerFSM[] fsmArray)
	{
		for (int i = 0; i < fsmArray.Length; i++)
		{
			if (fsmArray[i].FsmVariables.FindFsmInt("Value") != null)
			{
				return fsmArray[i];
			}
		}
		return null;
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x00083EB4 File Offset: 0x000820B4
	// Note: this type is marked as 'beforefieldinit'.
	static FSMUtility()
	{
		FSMUtility.fsmListPool = new List<List<PlayMakerFSM>>();
	}

	// Token: 0x04002198 RID: 8600
	private const int FsmListPoolSizeMax = 20;

	// Token: 0x04002199 RID: 8601
	private static List<List<PlayMakerFSM>> fsmListPool;

	// Token: 0x020004DC RID: 1244
	public abstract class CheckFsmStateAction : FsmStateAction
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001BA5 RID: 7077
		public abstract bool IsTrue { get; }

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00083EC0 File Offset: 0x000820C0
		public override void Reset()
		{
			this.trueEvent = null;
			this.falseEvent = null;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00083ED0 File Offset: 0x000820D0
		public override void OnEnter()
		{
			if (this.IsTrue)
			{
				base.Fsm.Event(this.trueEvent);
			}
			else
			{
				base.Fsm.Event(this.falseEvent);
			}
			base.Finish();
		}

		// Token: 0x0400219A RID: 8602
		public FsmEvent trueEvent;

		// Token: 0x0400219B RID: 8603
		public FsmEvent falseEvent;
	}

	// Token: 0x020004DD RID: 1245
	public abstract class GetIntFsmStateAction : FsmStateAction
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001BA9 RID: 7081
		public abstract int IntValue { get; }

		// Token: 0x06001BAA RID: 7082 RVA: 0x00083F04 File Offset: 0x00082104
		public override void Reset()
		{
			this.storeValue = null;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00083F0D File Offset: 0x0008210D
		public override void OnEnter()
		{
			if (!this.storeValue.IsNone)
			{
				this.storeValue.Value = this.IntValue;
			}
			base.Finish();
		}

		// Token: 0x0400219C RID: 8604
		[UIHint(UIHint.Variable)]
		public FsmInt storeValue;
	}

	// Token: 0x020004DE RID: 1246
	public abstract class SetBoolFsmStateAction : FsmStateAction
	{
		// Token: 0x17000358 RID: 856
		// (set) Token: 0x06001BAD RID: 7085
		public abstract bool BoolValue { set; }

		// Token: 0x06001BAE RID: 7086 RVA: 0x00083F33 File Offset: 0x00082133
		public override void Reset()
		{
			this.setValue = null;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00083F3C File Offset: 0x0008213C
		public override void OnEnter()
		{
			if (!this.setValue.IsNone)
			{
				this.BoolValue = this.setValue.Value;
			}
			base.Finish();
		}

		// Token: 0x0400219D RID: 8605
		public FsmBool setValue;
	}
}
