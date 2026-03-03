using System;
using UnityEngine;

// Token: 0x0200014D RID: 333
public class EndBeta : MonoBehaviour
{
	// Token: 0x060007C1 RID: 1985 RVA: 0x0002BEC9 File Offset: 0x0002A0C9
	private void Awake()
	{
		this.gm = GameManager.instance;
		this.isActive = true;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00003603 File Offset: 0x00001803
	private void Start()
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00003603 File Offset: 0x00001803
	private void Update()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x0002BEDD File Offset: 0x0002A0DD
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Player" && this.isActive)
		{
			this.isActive = false;
		}
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0002BF05 File Offset: 0x0002A105
	public void Reactivate()
	{
		this.isActive = true;
	}

	// Token: 0x040008A1 RID: 2209
	private GameManager gm;

	// Token: 0x040008A2 RID: 2210
	private bool isActive;
}
