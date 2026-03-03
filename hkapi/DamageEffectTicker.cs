using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200010A RID: 266
public class DamageEffectTicker : MonoBehaviour
{
	// Token: 0x06000683 RID: 1667 RVA: 0x00026930 File Offset: 0x00024B30
	private void OnEnable()
	{
		this.enemyList.Clear();
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00026940 File Offset: 0x00024B40
	private void Update()
	{
		this.timer += Time.deltaTime;
		if (this.timer >= this.damageInterval)
		{
			for (int i = 0; i < this.enemyList.Count; i++)
			{
				if (!(this.enemyList[i] == null))
				{
					PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(this.enemyList[i], "Extra Damage");
					if (playMakerFSM != null)
					{
						playMakerFSM.SendEvent(this.damageEvent);
					}
					IExtraDamageable component = this.enemyList[i].GetComponent<IExtraDamageable>();
					if (component != null)
					{
						component.RecieveExtraDamage(this.extraDamageType);
					}
				}
			}
			this.timer -= this.damageInterval;
		}
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x000269FA File Offset: 0x00024BFA
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		this.enemyList.Add(otherCollider.gameObject);
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00026A0D File Offset: 0x00024C0D
	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		this.enemyList.Remove(otherCollider.gameObject);
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00026930 File Offset: 0x00024B30
	public void EmptyDamageList()
	{
		this.enemyList.Clear();
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00026A21 File Offset: 0x00024C21
	public void SetDamageEvent(string newEvent)
	{
		this.damageEvent = newEvent;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00026A2A File Offset: 0x00024C2A
	public void SetDamageInterval(float newInterval)
	{
		this.damageInterval = newInterval;
	}

	// Token: 0x040006FC RID: 1788
	public List<GameObject> enemyList;

	// Token: 0x040006FD RID: 1789
	public float damageInterval;

	// Token: 0x040006FE RID: 1790
	public string damageEvent;

	// Token: 0x040006FF RID: 1791
	public ExtraDamageTypes extraDamageType;

	// Token: 0x04000700 RID: 1792
	private float timer;
}
