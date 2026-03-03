using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001CC RID: 460
public class SendEnemyMessageTrigger : MonoBehaviour
{
	// Token: 0x06000A23 RID: 2595 RVA: 0x00037980 File Offset: 0x00035B80
	private void Start()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "enemy_message");
		if (playMakerFSM != null)
		{
			FsmString fsmString = playMakerFSM.FsmVariables.FindFsmString("Event");
			if (fsmString != null)
			{
				this.eventName = fsmString.Value;
			}
			playMakerFSM.enabled = false;
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x000379CE File Offset: 0x00035BCE
	private void FixedUpdate()
	{
		this.enteredEnemies.Clear();
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x000379DC File Offset: 0x00035BDC
	private void OnTriggerStay2D(Collider2D collision)
	{
		GameObject gameObject = collision.attachedRigidbody.gameObject;
		if (!this.enteredEnemies.Contains(gameObject))
		{
			this.enteredEnemies.Add(gameObject);
			this.SendEvent(collision.gameObject);
		}
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00037A1C File Offset: 0x00035C1C
	private void SendEvent(GameObject obj)
	{
		if (this.eventName != "")
		{
			FSMUtility.SendEventToGameObject(obj, this.eventName, false);
			if (!string.IsNullOrEmpty(this.eventName))
			{
				string text = this.eventName;
				if (text != null)
				{
					if (text == "GO LEFT")
					{
						SendEnemyMessageTrigger.SendWalkerGoInDirection(obj, -1);
						return;
					}
					if (!(text == "GO RIGHT"))
					{
						return;
					}
					SendEnemyMessageTrigger.SendWalkerGoInDirection(obj, 1);
				}
			}
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00037A8C File Offset: 0x00035C8C
	private static void SendWalkerGoInDirection(GameObject target, int facing)
	{
		Walker component = target.GetComponent<Walker>();
		if (component != null)
		{
			component.RecieveGoMessage(facing);
		}
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00037AB0 File Offset: 0x00035CB0
	public SendEnemyMessageTrigger()
	{
		this.eventName = "";
		this.enteredEnemies = new List<GameObject>();
		base..ctor();
	}

	// Token: 0x04000B3B RID: 2875
	[UnityEngine.Tooltip("If there is an enemy_message FSM on this gameobject, this value will be gotten from it.")]
	public string eventName;

	// Token: 0x04000B3C RID: 2876
	private List<GameObject> enteredEnemies;
}
