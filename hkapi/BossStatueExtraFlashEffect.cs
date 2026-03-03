using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200025F RID: 607
public class BossStatueExtraFlashEffect : MonoBehaviour
{
	// Token: 0x06000CC7 RID: 3271 RVA: 0x00040E60 File Offset: 0x0003F060
	private void Start()
	{
		BossStatue componentInParent = base.GetComponentInParent<BossStatue>();
		if (componentInParent && !componentInParent.DreamStatueState.hasBeenSeen && !componentInParent.isAlwaysUnlockedDream)
		{
			this.toggle.SetActive(false);
			if (componentInParent.DreamStatueState.isUnlocked)
			{
				if (componentInParent.StatueState.isUnlocked && !componentInParent.StatueState.hasBeenSeen && this.mainEffect)
				{
					this.mainEffect.OnFlashBegin += delegate()
					{
						base.Invoke("DoAppear", this.flashSequenceDelay);
					};
				}
				else if (this.triggerUnlockEvent)
				{
					TriggerEnterEvent.CollisionEvent temp = null;
					temp = (TriggerEnterEvent.CollisionEvent)Delegate.Combine(temp, new TriggerEnterEvent.CollisionEvent(delegate(Collider2D collision, GameObject sender)
					{
						this.DoAppear();
						this.triggerUnlockEvent.OnTriggerEntered -= temp;
					}));
					this.triggerUnlockEvent.OnTriggerEntered += temp;
				}
			}
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00040F56 File Offset: 0x0003F156
	private void DoAppear()
	{
		base.gameObject.SetActive(true);
		base.StartCoroutine(this.AppearRoutine(this.toggle));
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00040F77 File Offset: 0x0003F177
	private IEnumerator AppearRoutine(GameObject toggle)
	{
		yield return new WaitForSeconds(this.toggleEnableTime);
		toggle.SetActive(true);
		yield break;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00040F8D File Offset: 0x0003F18D
	public BossStatueExtraFlashEffect()
	{
		this.flashSequenceDelay = 2f;
		this.toggleEnableTime = 1.35f;
		base..ctor();
	}

	// Token: 0x04000DBC RID: 3516
	public BossStatueFlashEffect mainEffect;

	// Token: 0x04000DBD RID: 3517
	public float flashSequenceDelay;

	// Token: 0x04000DBE RID: 3518
	public TriggerEnterEvent triggerUnlockEvent;

	// Token: 0x04000DBF RID: 3519
	public float toggleEnableTime;

	// Token: 0x04000DC0 RID: 3520
	public GameObject toggle;
}
