using System;
using UnityEngine;

// Token: 0x020003A8 RID: 936
[RequireComponent(typeof(Rigidbody2D))]
public class DebrisPiece : MonoBehaviour
{
	// Token: 0x06001578 RID: 5496 RVA: 0x000666DB File Offset: 0x000648DB
	protected void Reset()
	{
		this.resetOnDisable = true;
		this.forceZ = true;
		this.forcedZ = 0.015f;
		this.randomStartRotation = false;
		this.zRandomRadius = 0.000999f;
		this.spinFactor = 10f;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00066713 File Offset: 0x00064913
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		if (this.body == null)
		{
			Debug.LogErrorFormat(this, "Missing Rigidbody2D on {0}", new object[]
			{
				base.name
			});
		}
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00066749 File Offset: 0x00064949
	protected void OnEnable()
	{
		if (!this.didLaunch)
		{
			this.Launch();
		}
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00066759 File Offset: 0x00064959
	protected void OnDisable()
	{
		if (this.resetOnDisable)
		{
			this.didLaunch = false;
			this.didSpin = false;
		}
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00066774 File Offset: 0x00064974
	private void Launch()
	{
		this.didLaunch = true;
		if (this.forceZ)
		{
			Vector3 position = base.transform.position;
			position.z = this.forcedZ;
			base.transform.position = position;
		}
		if (this.randomStartRotation)
		{
			Vector3 localEulerAngles = base.transform.localEulerAngles;
			localEulerAngles.z = UnityEngine.Random.Range(0f, 360f);
			base.transform.localEulerAngles = localEulerAngles;
		}
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x000667EB File Offset: 0x000649EB
	protected void FixedUpdate()
	{
		if (!this.didSpin)
		{
			this.Spin();
		}
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x000667FC File Offset: 0x000649FC
	private void Spin()
	{
		this.didSpin = true;
		if (this.spinFactor != 0f)
		{
			if (this.zRandomRadius != 0f)
			{
				Vector3 position = base.transform.position;
				position.z += UnityEngine.Random.Range(-this.zRandomRadius, this.zRandomRadius);
				base.transform.position = position;
			}
			this.body.AddTorque(-this.body.velocity.x * this.spinFactor);
		}
	}

	// Token: 0x040019BE RID: 6590
	[SerializeField]
	private bool resetOnDisable;

	// Token: 0x040019BF RID: 6591
	private bool didLaunch;

	// Token: 0x040019C0 RID: 6592
	private bool didSpin;

	// Token: 0x040019C1 RID: 6593
	[Header("'set_z' Functionality")]
	[SerializeField]
	private bool forceZ;

	// Token: 0x040019C2 RID: 6594
	[SerializeField]
	private float forcedZ;

	// Token: 0x040019C3 RID: 6595
	[Header("'spin_self' Functionality")]
	[SerializeField]
	private bool randomStartRotation;

	// Token: 0x040019C4 RID: 6596
	[SerializeField]
	private float zRandomRadius;

	// Token: 0x040019C5 RID: 6597
	[SerializeField]
	private float spinFactor;

	// Token: 0x040019C6 RID: 6598
	private Rigidbody2D body;
}
