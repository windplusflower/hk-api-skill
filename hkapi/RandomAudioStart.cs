using System;
using UnityEngine;

// Token: 0x020003DD RID: 989
public class RandomAudioStart : MonoBehaviour
{
	// Token: 0x06001692 RID: 5778 RVA: 0x0006AEF3 File Offset: 0x000690F3
	private void Start()
	{
		this.time = UnityEngine.Random.Range(this.timeMin, this.timeMax);
		if (this.audioSource == null)
		{
			this.audioSource = base.GetComponent<AudioSource>();
		}
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0006AF26 File Offset: 0x00069126
	private void Update()
	{
		if (!this.started)
		{
			if (this.timer >= this.time)
			{
				this.audioSource.Play();
				this.started = true;
				return;
			}
			this.timer += Time.deltaTime;
		}
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0006AF63 File Offset: 0x00069163
	public RandomAudioStart()
	{
		this.timeMax = 1f;
		base..ctor();
	}

	// Token: 0x04001B30 RID: 6960
	public AudioSource audioSource;

	// Token: 0x04001B31 RID: 6961
	public float timeMin;

	// Token: 0x04001B32 RID: 6962
	public float timeMax;

	// Token: 0x04001B33 RID: 6963
	private float time;

	// Token: 0x04001B34 RID: 6964
	private float timer;

	// Token: 0x04001B35 RID: 6965
	private bool started;
}
