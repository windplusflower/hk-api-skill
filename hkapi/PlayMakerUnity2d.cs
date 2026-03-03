using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class PlayMakerUnity2d : MonoBehaviour
{
	// Token: 0x0600014C RID: 332 RVA: 0x00006BC3 File Offset: 0x00004DC3
	public static void RecordLastRaycastHitInfo(Fsm fsm, RaycastHit2D info)
	{
		if (PlayMakerUnity2d.lastRaycastHit2DInfoLUT == null)
		{
			PlayMakerUnity2d.lastRaycastHit2DInfoLUT = new Dictionary<Fsm, RaycastHit2D>();
		}
		PlayMakerUnity2d.lastRaycastHit2DInfoLUT[fsm] = info;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00006BE4 File Offset: 0x00004DE4
	public static RaycastHit2D GetLastRaycastHitInfo(Fsm fsm)
	{
		if (PlayMakerUnity2d.lastRaycastHit2DInfoLUT == null)
		{
			PlayMakerUnity2d.lastRaycastHit2DInfoLUT[fsm] = default(RaycastHit2D);
			return PlayMakerUnity2d.lastRaycastHit2DInfoLUT[fsm];
		}
		return PlayMakerUnity2d.lastRaycastHit2DInfoLUT[fsm];
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00006C24 File Offset: 0x00004E24
	private void Awake()
	{
		PlayMakerUnity2d.fsmProxy = base.GetComponent<PlayMakerFSM>();
		if (PlayMakerUnity2d.fsmProxy == null)
		{
			Debug.LogError("'PlayMaker Unity 2D' is missing.", this);
		}
		PlayMakerUnity2d.goTarget = new FsmOwnerDefault();
		PlayMakerUnity2d.goTarget.GameObject = new FsmGameObject();
		PlayMakerUnity2d.goTarget.OwnerOption = OwnerDefaultOption.SpecifyGameObject;
		FsmEventTarget fsmEventTarget = new FsmEventTarget();
		fsmEventTarget.excludeSelf = false;
		fsmEventTarget.target = FsmEventTarget.EventTarget.GameObject;
		fsmEventTarget.gameObject = PlayMakerUnity2d.goTarget;
		fsmEventTarget.sendToChildren = false;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00006CA6 File Offset: 0x00004EA6
	private void OnLevelWasLoaded(int level)
	{
		if (PlayMakerUnity2d.lastRaycastHit2DInfoLUT != null)
		{
			PlayMakerUnity2d.lastRaycastHit2DInfoLUT.Clear();
		}
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00006CB9 File Offset: 0x00004EB9
	public static bool isAvailable()
	{
		return PlayMakerUnity2d.fsmProxy != null;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00006CC8 File Offset: 0x00004EC8
	public static void ForwardEventToGameObject(GameObject target, string eventName)
	{
		PlayMakerUnity2d.goTarget.GameObject.Value = target;
		FsmEventTarget fsmEventTarget = new FsmEventTarget();
		fsmEventTarget.target = FsmEventTarget.EventTarget.GameObject;
		fsmEventTarget.gameObject = PlayMakerUnity2d.goTarget;
		FsmEvent fsmEvent = new FsmEvent(eventName);
		PlayMakerUnity2d.fsmProxy.Fsm.Event(fsmEventTarget, fsmEvent.Name);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00006D1C File Offset: 0x00004F1C
	public static void ForwardCollisionToCurrentState(GameObject target, PlayMakerUnity2d.Collision2DType type, Collision2D CollisionInfo)
	{
		foreach (PlayMakerFSM playMakerFSM in target.GetComponents<PlayMakerFSM>())
		{
			FsmState fsmState = null;
			foreach (FsmState fsmState2 in playMakerFSM.FsmStates)
			{
				if (fsmState2.Name.Equals(playMakerFSM.ActiveStateName))
				{
					fsmState = fsmState2;
					break;
				}
			}
			if (fsmState != null)
			{
				foreach (IFsmCollider2DStateAction fsmCollider2DStateAction in fsmState.Actions)
				{
					if (type == PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D)
					{
						fsmCollider2DStateAction.DoCollisionEnter2D(CollisionInfo);
					}
				}
			}
		}
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00006DBC File Offset: 0x00004FBC
	// Note: this type is marked as 'beforefieldinit'.
	static PlayMakerUnity2d()
	{
		PlayMakerUnity2d.PlayMakerUnity2dProxyName = "PlayMaker Unity 2D";
		PlayMakerUnity2d.OnCollisionEnter2DEvent = "COLLISION ENTER 2D";
		PlayMakerUnity2d.OnCollisionExit2DEvent = "COLLISION EXIT 2D";
		PlayMakerUnity2d.OnCollisionStay2DEvent = "COLLISION STAY 2D";
		PlayMakerUnity2d.OnTriggerEnter2DEvent = "TRIGGER ENTER 2D";
		PlayMakerUnity2d.OnTriggerExit2DEvent = "TRIGGER EXIT 2D";
		PlayMakerUnity2d.OnTriggerStay2DEvent = "TRIGGER STAY 2D";
	}

	// Token: 0x040000ED RID: 237
	private static PlayMakerFSM fsmProxy;

	// Token: 0x040000EE RID: 238
	public static string PlayMakerUnity2dProxyName;

	// Token: 0x040000EF RID: 239
	private static FsmOwnerDefault goTarget;

	// Token: 0x040000F0 RID: 240
	public static string OnCollisionEnter2DEvent;

	// Token: 0x040000F1 RID: 241
	public static string OnCollisionExit2DEvent;

	// Token: 0x040000F2 RID: 242
	public static string OnCollisionStay2DEvent;

	// Token: 0x040000F3 RID: 243
	public static string OnTriggerEnter2DEvent;

	// Token: 0x040000F4 RID: 244
	public static string OnTriggerExit2DEvent;

	// Token: 0x040000F5 RID: 245
	public static string OnTriggerStay2DEvent;

	// Token: 0x040000F6 RID: 246
	private static Dictionary<Fsm, RaycastHit2D> lastRaycastHit2DInfoLUT;

	// Token: 0x0200003B RID: 59
	public enum Collision2DType
	{
		// Token: 0x040000F8 RID: 248
		OnCollisionEnter2D,
		// Token: 0x040000F9 RID: 249
		OnCollisionStay2D,
		// Token: 0x040000FA RID: 250
		OnCollisionExit2D
	}

	// Token: 0x0200003C RID: 60
	public enum Trigger2DType
	{
		// Token: 0x040000FC RID: 252
		OnTriggerEnter2D,
		// Token: 0x040000FD RID: 253
		OnTriggerStay2D,
		// Token: 0x040000FE RID: 254
		OnTriggerExit2D
	}
}
