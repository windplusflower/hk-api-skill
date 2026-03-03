using System;
using UnityEngine;

// Token: 0x020001EB RID: 491
[RequireComponent(typeof(Rigidbody2D))]
public class FinishingRigidBody : MonoBehaviour
{
	// Token: 0x06000AAA RID: 2730 RVA: 0x00039707 File Offset: 0x00037907
	protected void Reset()
	{
		this.waitDuration = 8f;
		this.shrinkDuration = 1f;
		this.conclusion = FinishingRigidBody.Conclusions.Disable;
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00039726 File Offset: 0x00037926
	protected void Awake()
	{
		this.rend = base.GetComponent<Renderer>();
		this.body = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00039740 File Offset: 0x00037940
	protected void OnEnable()
	{
		this.state = FinishingRigidBody.States.Ready;
		this.timer = 0f;
		this.framesEnabled = 0;
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x0003975C File Offset: 0x0003795C
	protected void Update()
	{
		if (this.state == FinishingRigidBody.States.Ready && !this.body.IsAwake())
		{
			this.timer += Time.deltaTime;
			if (this.timer > this.waitDuration)
			{
				this.timer = 0f;
				this.state = FinishingRigidBody.States.Shrinking;
				this.shrinkStartScale = base.transform.localScale;
			}
		}
		if (this.state == FinishingRigidBody.States.Shrinking)
		{
			this.timer += Time.deltaTime;
			if (this.timer > this.shrinkDuration)
			{
				this.Conclude();
				return;
			}
			float d = 1f - Mathf.Clamp01(this.timer / this.shrinkDuration);
			base.transform.localScale = d * this.shrinkStartScale;
		}
		if (!this.persistOffScreen && this.rend != null && !this.rend.isVisible && this.framesEnabled > 10)
		{
			this.Conclude();
			return;
		}
		this.framesEnabled++;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00039864 File Offset: 0x00037A64
	private void Conclude()
	{
		if (this.state == FinishingRigidBody.States.Shrinking)
		{
			base.transform.localScale = this.shrinkStartScale;
		}
		this.state = FinishingRigidBody.States.Concluded;
		if (this.conclusion == FinishingRigidBody.Conclusions.Disable)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.conclusion == FinishingRigidBody.Conclusions.Recycle)
		{
			base.gameObject.Recycle();
			return;
		}
		if (this.conclusion == FinishingRigidBody.Conclusions.Destroy)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000BBE RID: 3006
	[SerializeField]
	private float waitDuration;

	// Token: 0x04000BBF RID: 3007
	[SerializeField]
	private float shrinkDuration;

	// Token: 0x04000BC0 RID: 3008
	[SerializeField]
	private FinishingRigidBody.Conclusions conclusion;

	// Token: 0x04000BC1 RID: 3009
	[SerializeField]
	private bool persistOffScreen;

	// Token: 0x04000BC2 RID: 3010
	private Renderer rend;

	// Token: 0x04000BC3 RID: 3011
	private Rigidbody2D body;

	// Token: 0x04000BC4 RID: 3012
	private FinishingRigidBody.States state;

	// Token: 0x04000BC5 RID: 3013
	private Vector3 shrinkStartScale;

	// Token: 0x04000BC6 RID: 3014
	private float timer;

	// Token: 0x04000BC7 RID: 3015
	private int framesEnabled;

	// Token: 0x020001EC RID: 492
	private enum Conclusions
	{
		// Token: 0x04000BC9 RID: 3017
		Disable,
		// Token: 0x04000BCA RID: 3018
		Recycle,
		// Token: 0x04000BCB RID: 3019
		Destroy
	}

	// Token: 0x020001ED RID: 493
	private enum States
	{
		// Token: 0x04000BCD RID: 3021
		Ready,
		// Token: 0x04000BCE RID: 3022
		Concluded,
		// Token: 0x04000BCF RID: 3023
		Shrinking
	}
}
