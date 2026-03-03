using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000235 RID: 565
public class BossSequenceBindingsDoor : MonoBehaviour
{
	// Token: 0x06000C01 RID: 3073 RVA: 0x0003DEFD File Offset: 0x0003C0FD
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0003DF0C File Offset: 0x0003C10C
	private void Start()
	{
		if (GameManager.instance.GetPlayerDataBool(this.playerData))
		{
			this.SetUnlocked(true, false);
			return;
		}
		this.SetUnlocked(false, false);
		int num = BossSequenceBindingsDisplay.CountCompletedBindings();
		for (int i = 0; i < this.bindingIcons.Length; i++)
		{
			this.bindingIcons[i].SetActive(i < num);
		}
		if (num >= this.bindingIcons.Length)
		{
			this.shouldBeUnlocked = true;
		}
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0003DF78 File Offset: 0x0003C178
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.isUnlocked && this.shouldBeUnlocked)
		{
			GameManager.instance.SetPlayerDataBool(this.playerData, true);
			this.SetUnlocked(true, true);
		}
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
	private void SetUnlocked(bool value, bool doUnlockAnimation = false)
	{
		this.isUnlocked = value;
		if (value)
		{
			if (doUnlockAnimation && this.animator)
			{
				base.StartCoroutine(this.DoUnlockAnimation());
				return;
			}
			this.animator.Play(this.unlockedAnimation);
			if (this.transitionPointDoor)
			{
				this.transitionPointDoor.SetActive(true);
				return;
			}
		}
		else if (this.transitionPointDoor)
		{
			this.transitionPointDoor.SetActive(false);
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0003E01D File Offset: 0x0003C21D
	private IEnumerator DoUnlockAnimation()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(HeroController.instance.gameObject, "Roar Lock");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmGameObject("Roar Object").Value = this.gameObject;
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR ENTER", false);
		this.animator.Play(this.unlockAnimation);
		yield return null;
		yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR EXIT", false);
		if (this.transitionPointDoor)
		{
			this.transitionPointDoor.SetActive(true);
		}
		yield break;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0003E02C File Offset: 0x0003C22C
	public BossSequenceBindingsDoor()
	{
		this.playerData = "blueRoomDoorUnlocked";
		this.doorEnableAnimDelay = 1f;
		this.unlockAnimation = "Unlock";
		this.unlockedAnimation = "Unlocked";
		base..ctor();
	}

	// Token: 0x04000CE2 RID: 3298
	public string playerData;

	// Token: 0x04000CE3 RID: 3299
	public GameObject[] bindingIcons;

	// Token: 0x04000CE4 RID: 3300
	public GameObject transitionPointDoor;

	// Token: 0x04000CE5 RID: 3301
	public float doorEnableAnimDelay;

	// Token: 0x04000CE6 RID: 3302
	public string unlockAnimation;

	// Token: 0x04000CE7 RID: 3303
	public string unlockedAnimation;

	// Token: 0x04000CE8 RID: 3304
	private bool isUnlocked;

	// Token: 0x04000CE9 RID: 3305
	private bool shouldBeUnlocked;

	// Token: 0x04000CEA RID: 3306
	private Animator animator;
}
