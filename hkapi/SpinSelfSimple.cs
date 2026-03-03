using System;
using UnityEngine;

// Token: 0x0200008F RID: 143
public class SpinSelfSimple : MonoBehaviour
{
	// Token: 0x060002FC RID: 764 RVA: 0x0000FD63 File Offset: 0x0000DF63
	private void Update()
	{
		if (this.timing && !this.waitForCall)
		{
			if (this.timer > 0f)
			{
				this.timer -= Time.deltaTime;
				return;
			}
			this.timing = false;
			this.DoSpin();
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
	private void OnEnable()
	{
		if (this.rb == null)
		{
			this.rb = base.GetComponent<Rigidbody2D>();
		}
		if (this.randomStartRotation)
		{
			base.transform.localEulerAngles = new Vector3(0f, 0f, UnityEngine.Random.Range(0f, 360f));
		}
		this.timing = true;
		this.timer = 0.01f;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0000FE10 File Offset: 0x0000E010
	public void DoSpin()
	{
		float torque = -(this.rb.velocity.x * this.spinFactor);
		this.rb.AddTorque(torque, ForceMode2D.Force);
	}

	// Token: 0x04000278 RID: 632
	public bool randomStartRotation;

	// Token: 0x04000279 RID: 633
	public float spinFactor;

	// Token: 0x0400027A RID: 634
	public bool waitForCall;

	// Token: 0x0400027B RID: 635
	public Rigidbody2D rb;

	// Token: 0x0400027C RID: 636
	private bool timing;

	// Token: 0x0400027D RID: 637
	private float timer;
}
