using System;
using UnityEngine;

// Token: 0x020000A4 RID: 164
public class WalkArea : MonoBehaviour
{
	// Token: 0x06000384 RID: 900 RVA: 0x000129FC File Offset: 0x00010BFC
	protected void Awake()
	{
		this.myCollider = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00012A0A File Offset: 0x00010C0A
	private void Start()
	{
		this.gm = GameManager.instance;
		this.gm.UnloadingLevel += this.Deactivate;
		this.heroCtrl = HeroController.instance;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00012A39 File Offset: 0x00010C39
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.layer == 9)
		{
			if (this.verboseMode)
			{
				Debug.Log("ENTER Activated Walk Zone");
			}
			this.activated = true;
			this.heroCtrl.SetWalkZone(true);
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00012A70 File Offset: 0x00010C70
	private void OnTriggerStay2D(Collider2D otherCollider)
	{
		if (!this.activated && this.myCollider.enabled && otherCollider.gameObject.layer == 9)
		{
			if (this.verboseMode)
			{
				Debug.Log("STAY Activated Walk Zone");
			}
			this.activated = true;
			this.heroCtrl.SetWalkZone(true);
		}
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00012AC6 File Offset: 0x00010CC6
	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.layer == 9)
		{
			if (this.verboseMode)
			{
				Debug.Log("EXIT Deactivated Walk Zone");
			}
			this.activated = false;
			this.heroCtrl.SetWalkZone(false);
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00012AFC File Offset: 0x00010CFC
	private void Deactivate()
	{
		if (this.verboseMode)
		{
			Debug.Log("UNLOAD Deactivated Walk Zone");
		}
		this.activated = false;
		this.heroCtrl.SetWalkZone(false);
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00012B23 File Offset: 0x00010D23
	private void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.UnloadingLevel -= this.Deactivate;
		}
	}

	// Token: 0x040002EF RID: 751
	private Collider2D myCollider;

	// Token: 0x040002F0 RID: 752
	private GameManager gm;

	// Token: 0x040002F1 RID: 753
	private HeroController heroCtrl;

	// Token: 0x040002F2 RID: 754
	private bool activated;

	// Token: 0x040002F3 RID: 755
	private bool verboseMode;
}
