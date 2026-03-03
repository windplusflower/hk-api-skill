using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200021A RID: 538
[DefaultExecutionOrder(1)]
public class BossDoorTargetLock : MonoBehaviour
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003CE59 File Offset: 0x0003B059
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0003CE7A File Offset: 0x0003B07A
	private bool IsUnlocked
	{
		get
		{
			return !string.IsNullOrEmpty(this.playerData) && GameManager.instance.GetPlayerDataBool(this.playerData);
		}
		set
		{
			if (!string.IsNullOrEmpty(this.playerData))
			{
				GameManager.instance.SetPlayerDataBool(this.playerData, value);
				return;
			}
			Debug.LogError("Can't save an empty PlayerData bool!", this);
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0003CEA6 File Offset: 0x0003B0A6
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0003CEB4 File Offset: 0x0003B0B4
	private void Start()
	{
		bool flag = true;
		BossDoorTargetLock.BossDoorTarget[] array = this.targets;
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].Evaluate())
			{
				flag = false;
			}
		}
		if (this.IsUnlocked)
		{
			if (this.animator)
			{
				this.animator.Play(this.unlockedAnimation);
				return;
			}
		}
		else if (flag && this.unlockTrigger)
		{
			TriggerEnterEvent.CollisionEvent temp = null;
			temp = delegate(Collider2D collider, GameObject sender)
			{
				this.StartCoroutine(this.UnlockSequence());
				this.unlockTrigger.OnTriggerEntered -= temp;
			};
			this.unlockTrigger.OnTriggerEntered += temp;
		}
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0003CF52 File Offset: 0x0003B152
	private IEnumerator UnlockSequence()
	{
		if (this.animator)
		{
			this.animator.Play(this.unlockAnimation);
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		this.IsUnlocked = true;
		yield break;
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0003CF64 File Offset: 0x0003B164
	private void StartRoarLock()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(HeroController.instance.gameObject, "Roar Lock");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmGameObject("Roar Object").Value = base.gameObject;
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR ENTER", false);
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0003CFBE File Offset: 0x0003B1BE
	private void StopRoarLock()
	{
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR EXIT", false);
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0003CFD5 File Offset: 0x0003B1D5
	public BossDoorTargetLock()
	{
		this.playerData = "finalBossDoorUnlocked";
		this.unlockAnimation = "Unlock";
		this.unlockedAnimation = "Unlocked";
		base..ctor();
	}

	// Token: 0x04000C80 RID: 3200
	public BossDoorTargetLock.BossDoorTarget[] targets;

	// Token: 0x04000C81 RID: 3201
	public string playerData;

	// Token: 0x04000C82 RID: 3202
	public TriggerEnterEvent unlockTrigger;

	// Token: 0x04000C83 RID: 3203
	public string unlockAnimation;

	// Token: 0x04000C84 RID: 3204
	public string unlockedAnimation;

	// Token: 0x04000C85 RID: 3205
	private Animator animator;

	// Token: 0x0200021B RID: 539
	[Serializable]
	public class BossDoorTarget
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x0003D000 File Offset: 0x0003B200
		public bool Evaluate()
		{
			if (this.door && this.indicator)
			{
				bool completed = this.door.CurrentCompletion.completed;
				this.indicator.SetActive(completed);
				return completed;
			}
			return false;
		}

		// Token: 0x04000C86 RID: 3206
		public BossSequenceDoor door;

		// Token: 0x04000C87 RID: 3207
		public GameObject indicator;
	}
}
