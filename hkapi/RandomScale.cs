using System;
using UnityEngine;

// Token: 0x02000400 RID: 1024
public class RandomScale : MonoBehaviour, IExternalDebris
{
	// Token: 0x06001749 RID: 5961 RVA: 0x0006E3F8 File Offset: 0x0006C5F8
	private void Start()
	{
		if (!this.didScale)
		{
			this.ApplyScale();
		}
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x0006E408 File Offset: 0x0006C608
	private void OnEnable()
	{
		if (this.scaleOnEnable)
		{
			this.ApplyScale();
		}
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x0006E418 File Offset: 0x0006C618
	private void ApplyScale()
	{
		base.transform.localScale = Vector3.one * UnityEngine.Random.Range(this.minScale, this.maxScale);
		this.didScale = true;
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x0006E447 File Offset: 0x0006C647
	void IExternalDebris.InitExternalDebris()
	{
		this.ApplyScale();
	}

	// Token: 0x04001C0E RID: 7182
	public float minScale;

	// Token: 0x04001C0F RID: 7183
	public float maxScale;

	// Token: 0x04001C10 RID: 7184
	public bool scaleOnEnable;

	// Token: 0x04001C11 RID: 7185
	private bool didScale;
}
