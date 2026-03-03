using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class StartAudioPlayerAfterHeroInPosition : MonoBehaviour
{
	// Token: 0x06000410 RID: 1040 RVA: 0x000143D1 File Offset: 0x000125D1
	protected IEnumerator Start()
	{
		yield return null;
		while (HeroController.instance == null || !HeroController.instance.isHeroInPosition)
		{
			yield return null;
		}
		AudioSource component = this.GetComponent<AudioSource>();
		if (component != null)
		{
			component.Play();
		}
		yield break;
	}
}
