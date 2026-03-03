using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200020D RID: 525
public class TriggerActivateComponent : MonoBehaviour
{
	// Token: 0x06000B59 RID: 2905 RVA: 0x0003C3CD File Offset: 0x0003A5CD
	private void Start()
	{
		this.disableTimer = base.StartCoroutine(this.DisableTimer());
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x0003C3E1 File Offset: 0x0003A5E1
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.component)
		{
			this.component.enabled = true;
		}
		if (this.disableTimer != null)
		{
			base.StopCoroutine(this.disableTimer);
			this.disableTimer = null;
		}
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x0003C417 File Offset: 0x0003A617
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (this.disableTimer != null)
		{
			base.StopCoroutine(this.disableTimer);
		}
		this.disableTimer = base.StartCoroutine(this.DisableTimer());
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0003C43F File Offset: 0x0003A63F
	private IEnumerator DisableTimer()
	{
		while (HeroController.instance && !HeroController.instance.isHeroInPosition)
		{
			yield return null;
		}
		yield return new WaitForSeconds(this.disableTime);
		if (this.component)
		{
			this.component.enabled = false;
		}
		yield break;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x0003C44E File Offset: 0x0003A64E
	public TriggerActivateComponent()
	{
		this.disableTime = 1f;
		base..ctor();
	}

	// Token: 0x04000C55 RID: 3157
	public MonoBehaviour component;

	// Token: 0x04000C56 RID: 3158
	public float disableTime;

	// Token: 0x04000C57 RID: 3159
	private Coroutine disableTimer;
}
