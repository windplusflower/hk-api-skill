using System;
using System.Collections;
using UnityEngine;

// Token: 0x020001F5 RID: 501
public class FSMActivator : MonoBehaviour
{
	// Token: 0x06000AD7 RID: 2775 RVA: 0x00039D18 File Offset: 0x00037F18
	private void Awake()
	{
		this.fsms = base.GetComponents<PlayMakerFSM>();
		this.spriteAnim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00039D34 File Offset: 0x00037F34
	public void Activate()
	{
		if (this.activateStaggered)
		{
			base.StartCoroutine(this.ActivateStaggered());
			return;
		}
		if (!this.activated)
		{
			if (this.fsms.Length != 0)
			{
				for (int i = 0; i < this.fsms.Length; i++)
				{
					this.fsms[i].enabled = true;
				}
			}
			if (this.spriteAnim != null)
			{
				this.spriteAnim.Play();
			}
			this.activated = true;
		}
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00039DA9 File Offset: 0x00037FA9
	public IEnumerator ActivateStaggered()
	{
		if (!this.activated)
		{
			if (this.fsms.Length != 0)
			{
				this.activated = true;
				int num;
				for (int i = 0; i < this.fsms.Length; i = num + 1)
				{
					this.fsms[i].enabled = true;
					yield return null;
					num = i;
				}
			}
			if (this.spriteAnim != null)
			{
				this.activated = true;
				this.spriteAnim.Play();
			}
		}
		yield break;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00039DB8 File Offset: 0x00037FB8
	public void Deactivate()
	{
		if (this.activated && this.fsms.Length != 0)
		{
			for (int i = 0; i < this.fsms.Length; i++)
			{
				this.fsms[i].enabled = false;
			}
		}
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00039DF7 File Offset: 0x00037FF7
	public IEnumerator DeactivateStaggered()
	{
		if (this.activated && this.fsms.Length != 0)
		{
			int num;
			for (int i = 0; i < this.fsms.Length; i = num + 1)
			{
				this.fsms[i].enabled = false;
				yield return null;
				num = i;
			}
		}
		yield break;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00039E06 File Offset: 0x00038006
	public FSMActivator()
	{
		this.activateStaggered = true;
		base..ctor();
	}

	// Token: 0x04000BE8 RID: 3048
	[HideInInspector]
	public bool activateStaggered;

	// Token: 0x04000BE9 RID: 3049
	private PlayMakerFSM[] fsms;

	// Token: 0x04000BEA RID: 3050
	private tk2dSpriteAnimator spriteAnim;

	// Token: 0x04000BEB RID: 3051
	private bool activated;
}
