using System;
using UnityEngine;

// Token: 0x0200040D RID: 1037
public class SpinSelf : MonoBehaviour
{
	// Token: 0x0600177B RID: 6011 RVA: 0x0006F082 File Offset: 0x0006D282
	private void Start()
	{
		base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, (float)UnityEngine.Random.Range(0, 360));
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x0006F0C0 File Offset: 0x0006D2C0
	private void FixedUpdate()
	{
		if (!this.spun)
		{
			if (this.stepCounter >= 1)
			{
				Rigidbody2D component = base.GetComponent<Rigidbody2D>();
				float torque = component.velocity.x * this.spinFactor;
				component.AddTorque(torque);
				this.spun = true;
			}
			this.stepCounter++;
		}
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x0006F112 File Offset: 0x0006D312
	public SpinSelf()
	{
		this.spinFactor = -7.5f;
		base..ctor();
	}

	// Token: 0x04001C45 RID: 7237
	public float spinFactor;

	// Token: 0x04001C46 RID: 7238
	private int stepCounter;

	// Token: 0x04001C47 RID: 7239
	private bool spun;
}
