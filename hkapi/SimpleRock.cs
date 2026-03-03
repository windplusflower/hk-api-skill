using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000409 RID: 1033
public class SimpleRock : MonoBehaviour
{
	// Token: 0x0600176A RID: 5994 RVA: 0x0006E9C4 File Offset: 0x0006CBC4
	private void Start()
	{
		base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, (float)UnityEngine.Random.Range(0, 360));
		this.rb = base.GetComponent<Rigidbody2D>();
		this.setZ = UnityEngine.Random.Range(base.transform.position.z, base.transform.position.z + 0.0009999f);
		base.transform.SetPositionZ(this.setZ);
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x0006EA5C File Offset: 0x0006CC5C
	private void FixedUpdate()
	{
		if (!this.spun)
		{
			if (this.stepCounter >= 1)
			{
				float torque = this.rb.velocity.x * -7.5f;
				this.rb.AddTorque(torque);
				this.spun = true;
				return;
			}
			this.stepCounter++;
		}
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x0006EAB4 File Offset: 0x0006CCB4
	private void OnTriggerEnter(Collider other)
	{
		PhysLayers layer = (PhysLayers)other.gameObject.layer;
		if (layer == PhysLayers.ENEMIES || layer == PhysLayers.HERO_BOX)
		{
			Vector2 force = new Vector2(UnityEngine.Random.Range(-100f, 100f), UnityEngine.Random.Range(--0f, 40f));
			this.rb.AddForce(force);
			this.rb.AddTorque(UnityEngine.Random.Range(-50f, 50f));
		}
	}

	// Token: 0x04001C29 RID: 7209
	private int stepCounter;

	// Token: 0x04001C2A RID: 7210
	private bool spun;

	// Token: 0x04001C2B RID: 7211
	private Rigidbody2D rb;

	// Token: 0x04001C2C RID: 7212
	private float setZ;
}
