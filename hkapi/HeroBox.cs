using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x020000F6 RID: 246
public class HeroBox : MonoBehaviour
{
	// Token: 0x06000523 RID: 1315 RVA: 0x0001B4C9 File Offset: 0x000196C9
	private void Start()
	{
		this.heroCtrl = HeroController.instance;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0001B4D6 File Offset: 0x000196D6
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (!HeroBox.inactive)
		{
			this.CheckForDamage(otherCollider);
		}
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0001B4D6 File Offset: 0x000196D6
	private void OnTriggerStay2D(Collider2D otherCollider)
	{
		if (!HeroBox.inactive)
		{
			this.CheckForDamage(otherCollider);
		}
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001B4E8 File Offset: 0x000196E8
	private void CheckForDamage(Collider2D otherCollider)
	{
		if (!FSMUtility.ContainsFSM(otherCollider.gameObject, "damages_hero"))
		{
			DamageHero component = otherCollider.gameObject.GetComponent<DamageHero>();
			if (component != null)
			{
				if (this.heroCtrl.cState.shadowDashing && component.shadowDashHazard)
				{
					return;
				}
				this.damageDealt = component.damageDealt;
				this.hazardType = component.hazardType;
				this.damagingObject = otherCollider.gameObject;
				this.collisionSide = ((this.damagingObject.transform.position.x > base.transform.position.x) ? CollisionSide.right : CollisionSide.left);
				if (!HeroBox.IsHitTypeBuffered(this.hazardType))
				{
					this.ApplyBufferedHit();
					return;
				}
				this.isHitBuffered = true;
			}
			return;
		}
		PlayMakerFSM fsm = FSMUtility.LocateFSM(otherCollider.gameObject, "damages_hero");
		int @int = FSMUtility.GetInt(fsm, "damageDealt");
		int int2 = FSMUtility.GetInt(fsm, "hazardType");
		if (otherCollider.transform.position.x > base.transform.position.x)
		{
			this.heroCtrl.TakeDamage(otherCollider.gameObject, CollisionSide.right, @int, int2);
			return;
		}
		this.heroCtrl.TakeDamage(otherCollider.gameObject, CollisionSide.left, @int, int2);
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001B61D File Offset: 0x0001981D
	private static bool IsHitTypeBuffered(int hazardType)
	{
		return hazardType == 0;
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0001B623 File Offset: 0x00019823
	private void LateUpdate()
	{
		if (this.isHitBuffered)
		{
			this.ApplyBufferedHit();
		}
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0001B633 File Offset: 0x00019833
	private void ApplyBufferedHit()
	{
		this.heroCtrl.TakeDamage(this.damagingObject, this.collisionSide, this.damageDealt, this.hazardType);
		this.isHitBuffered = false;
	}

	// Token: 0x04000512 RID: 1298
	public static bool inactive;

	// Token: 0x04000513 RID: 1299
	private HeroController heroCtrl;

	// Token: 0x04000514 RID: 1300
	private GameObject damagingObject;

	// Token: 0x04000515 RID: 1301
	private bool isHitBuffered;

	// Token: 0x04000516 RID: 1302
	private int damageDealt;

	// Token: 0x04000517 RID: 1303
	private int hazardType;

	// Token: 0x04000518 RID: 1304
	private CollisionSide collisionSide;
}
