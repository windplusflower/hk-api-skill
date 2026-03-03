using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000216 RID: 534
[RequireComponent(typeof(Animator))]
public class BossDoorCage : MonoBehaviour
{
	// Token: 0x06000B7D RID: 2941 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
		this.cameraShake = base.GetComponent<CameraControlAnimationEvents>();
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0003CABC File Offset: 0x0003ACBC
	private void Start()
	{
		if (GameManager.instance.GetPlayerDataBool(this.playerData))
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.unlockTrigger)
		{
			this.unlockTrigger.OnTriggerEntered += delegate(Collider2D collision, GameObject sender)
			{
				this.Unlock();
			};
		}
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0003CB0C File Offset: 0x0003AD0C
	private void Unlock()
	{
		if (GameManager.instance.GetPlayerDataBool(this.playerData))
		{
			return;
		}
		BossSequenceDoor[] array = this.requiredComplete;
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].CurrentCompletion.completed)
			{
				return;
			}
		}
		GameManager.instance.SetPlayerDataBool(this.playerData, true);
		base.StartCoroutine(this.UnlockRoutine());
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x0003CB6F File Offset: 0x0003AD6F
	private IEnumerator UnlockRoutine()
	{
		this.animator.Play("Unlock");
		yield return null;
		yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		yield break;
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0003CB80 File Offset: 0x0003AD80
	public void StartShakeLock()
	{
		if (this.cameraShake)
		{
			this.cameraShake.SmallRumble();
		}
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(HeroController.instance.gameObject, "Roar Lock");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmGameObject("Roar Object").Value = base.gameObject;
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR ENTER", false);
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x0003CBF2 File Offset: 0x0003ADF2
	public void StopShakeLock()
	{
		if (this.cameraShake)
		{
			this.cameraShake.StopRumble();
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR EXIT", false);
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x0003CC21 File Offset: 0x0003AE21
	public BossDoorCage()
	{
		this.playerData = "bossDoorCageUnlocked";
		base..ctor();
	}

	// Token: 0x04000C73 RID: 3187
	public BossSequenceDoor[] requiredComplete;

	// Token: 0x04000C74 RID: 3188
	public TriggerEnterEvent unlockTrigger;

	// Token: 0x04000C75 RID: 3189
	public string playerData;

	// Token: 0x04000C76 RID: 3190
	private Animator animator;

	// Token: 0x04000C77 RID: 3191
	private CameraControlAnimationEvents cameraShake;
}
