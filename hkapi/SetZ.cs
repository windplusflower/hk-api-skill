using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000405 RID: 1029
public class SetZ : MonoBehaviour
{
	// Token: 0x06001759 RID: 5977 RVA: 0x0006E768 File Offset: 0x0006C968
	private void OnEnable()
	{
		this.setZ = this.z;
		if (!this.dontRandomize)
		{
			this.setZ = UnityEngine.Random.Range(this.z, this.z + 0.0009999f);
		}
		if (this.randomizeFromStartingValue)
		{
			this.setZ = UnityEngine.Random.Range(base.transform.position.z, base.transform.position.z + 0.0009999f);
		}
		base.StartCoroutine(this.SetPosition());
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0006E7EC File Offset: 0x0006C9EC
	private IEnumerator SetPosition()
	{
		yield return new WaitForSeconds(this.delayBeforeRandomizing);
		this.transform.SetPositionZ(this.setZ);
		yield break;
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x0006E7FB File Offset: 0x0006C9FB
	public SetZ()
	{
		this.delayBeforeRandomizing = 0.5f;
		base..ctor();
	}

	// Token: 0x04001C1C RID: 7196
	public float z;

	// Token: 0x04001C1D RID: 7197
	public bool dontRandomize;

	// Token: 0x04001C1E RID: 7198
	public bool randomizeFromStartingValue;

	// Token: 0x04001C1F RID: 7199
	public float delayBeforeRandomizing;

	// Token: 0x04001C20 RID: 7200
	private float setZ;
}
