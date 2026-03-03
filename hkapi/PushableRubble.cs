using System;
using UnityEngine;

// Token: 0x020003FD RID: 1021
[RequireComponent(typeof(Rigidbody2D))]
public class PushableRubble : MonoBehaviour
{
	// Token: 0x0600173B RID: 5947 RVA: 0x0006E1EF File Offset: 0x0006C3EF
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x0006E1FD File Offset: 0x0006C3FD
	protected void OnTriggerEnter2D(Collider2D collider)
	{
		this.Push();
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x0006E205 File Offset: 0x0006C405
	private void Push()
	{
		this.body.AddForce(new Vector2((float)UnityEngine.Random.Range(-100, 100), (float)UnityEngine.Random.Range(0, 40)), ForceMode2D.Force);
		this.body.AddTorque((float)UnityEngine.Random.Range(-50, 50), ForceMode2D.Force);
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x0006E241 File Offset: 0x0006C441
	public void EndRubble()
	{
		base.Invoke("EndRubbleContinuation", 5f);
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x0006E254 File Offset: 0x0006C454
	private void EndRubbleContinuation()
	{
		this.body.isKinematic = true;
		this.body.velocity = Vector2.zero;
		Collider2D component = base.GetComponent<Collider2D>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x04001C0B RID: 7179
	private Rigidbody2D body;
}
