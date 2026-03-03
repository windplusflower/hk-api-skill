using System;
using UnityEngine;

// Token: 0x02000408 RID: 1032
public class ShadowGateColliderControl : MonoBehaviour
{
	// Token: 0x06001764 RID: 5988 RVA: 0x0006E8D9 File Offset: 0x0006CAD9
	private void Awake()
	{
		this.eventRegister = base.GetComponent<EventRegister>();
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x0006E8E7 File Offset: 0x0006CAE7
	private void Start()
	{
		if (this.eventRegister)
		{
			this.eventRegister.OnReceivedEvent += this.Setup;
		}
		this.Setup();
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x0006E913 File Offset: 0x0006CB13
	private void OnDestroy()
	{
		if (this.eventRegister)
		{
			this.eventRegister.OnReceivedEvent -= this.Setup;
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x0006E939 File Offset: 0x0006CB39
	private void Setup()
	{
		if (GameManager.instance.playerData.GetBool("hasShadowDash"))
		{
			this.unlocked = true;
		}
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x0006E958 File Offset: 0x0006CB58
	private void FixedUpdate()
	{
		if (this.unlocked)
		{
			if (HeroController.instance.cState.dashing && this.disableCollider.enabled)
			{
				this.disableCollider.enabled = false;
			}
			if (!HeroController.instance.cState.dashing && !this.disableCollider.enabled)
			{
				this.disableCollider.enabled = true;
			}
		}
	}

	// Token: 0x04001C26 RID: 7206
	public Collider2D disableCollider;

	// Token: 0x04001C27 RID: 7207
	private bool unlocked;

	// Token: 0x04001C28 RID: 7208
	private EventRegister eventRegister;
}
