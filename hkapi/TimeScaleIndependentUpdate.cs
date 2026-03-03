using System;
using System.Collections;
using UnityEngine;

// Token: 0x020004FF RID: 1279
public class TimeScaleIndependentUpdate : MonoBehaviour
{
	// Token: 0x17000365 RID: 869
	// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0008555F File Offset: 0x0008375F
	// (set) Token: 0x06001C32 RID: 7218 RVA: 0x00085567 File Offset: 0x00083767
	public float deltaTime { get; private set; }

	// Token: 0x06001C33 RID: 7219 RVA: 0x00085570 File Offset: 0x00083770
	protected virtual void Awake()
	{
		this.previousTimeSinceStartup = Time.realtimeSinceStartup;
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x00085580 File Offset: 0x00083780
	protected virtual void Update()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		this.deltaTime = realtimeSinceStartup - this.previousTimeSinceStartup;
		this.previousTimeSinceStartup = realtimeSinceStartup;
		if (this.deltaTime < 0f)
		{
			this.deltaTime = 0f;
		}
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000855C0 File Offset: 0x000837C0
	public IEnumerator TimeScaleIndependentWaitForSeconds(float seconds)
	{
		for (float elapsedTime = 0f; elapsedTime < seconds; elapsedTime += this.deltaTime)
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x040021ED RID: 8685
	private float previousTimeSinceStartup;
}
