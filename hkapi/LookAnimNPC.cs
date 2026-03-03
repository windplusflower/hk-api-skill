using System;
using UnityEngine;

// Token: 0x020003D7 RID: 983
public class LookAnimNPC : MonoBehaviour
{
	// Token: 0x06001684 RID: 5764 RVA: 0x0006AB75 File Offset: 0x00068D75
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		if (!this.anim)
		{
			Debug.LogError(string.Format("LookAnimNPC on {0} could not find a tk2dSpriteAnimator!", base.gameObject.name), this);
		}
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x0006ABAC File Offset: 0x00068DAC
	private void Start()
	{
		if (this.limitZ > 0f && Mathf.Abs(base.transform.position.z - 0.004f) > this.limitZ)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		this.state = (this.defaultLeft ? LookAnimNPC.AnimState.Left : LookAnimNPC.AnimState.Right);
		if (this.anim)
		{
			tk2dSpriteAnimationClip clipByName = this.anim.GetClipByName(this.defaultLeft ? this.leftAnim : this.rightAnim);
			this.anim.PlayFromFrame(clipByName, clipByName.frames.Length - 1);
		}
		if (this.enterDetector)
		{
			this.enterDetector.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
			{
				this.target = collider.transform;
			};
		}
		if (this.exitDetector)
		{
			this.exitDetector.OnTriggerExited += delegate(Collider2D collider, GameObject sender)
			{
				this.target = null;
			};
		}
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x0006AC8F File Offset: 0x00068E8F
	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(base.transform.position + new Vector3(this.centreOffset, 0f, 0f), 0.25f);
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x0006ACC0 File Offset: 0x00068EC0
	private void Update()
	{
		if (this.anim)
		{
			if (!this.isTurning)
			{
				bool flag = this.target ? ((this.target.transform.position.x - (base.transform.position.x + this.centreOffset)) * base.transform.localScale.x < 0f) : this.defaultLeft;
				LookAnimNPC.AnimState animState = this.state;
				if (animState != LookAnimNPC.AnimState.Left)
				{
					if (animState == LookAnimNPC.AnimState.Right)
					{
						if (flag)
						{
							float num = this.anim.PlayAnimGetTime(this.leftAnim);
							this.state = LookAnimNPC.AnimState.TurningLeft;
							this.isTurning = true;
							this.turnFinishTime = Time.time + num;
						}
					}
				}
				else if (!flag)
				{
					float num2 = this.anim.PlayAnimGetTime(this.rightAnim);
					this.state = LookAnimNPC.AnimState.TurningRight;
					this.isTurning = true;
					this.turnFinishTime = Time.time + num2;
				}
			}
			if (this.isTurning && Time.time >= this.turnFinishTime)
			{
				this.isTurning = false;
				LookAnimNPC.AnimState animState = this.state;
				if (animState == LookAnimNPC.AnimState.TurningLeft)
				{
					this.state = LookAnimNPC.AnimState.Left;
					return;
				}
				if (animState != LookAnimNPC.AnimState.TurningRight)
				{
					return;
				}
				this.state = LookAnimNPC.AnimState.Right;
			}
		}
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x0006ADF0 File Offset: 0x00068FF0
	public LookAnimNPC()
	{
		this.defaultLeft = true;
		base..ctor();
	}

	// Token: 0x04001B1A RID: 6938
	public string leftAnim;

	// Token: 0x04001B1B RID: 6939
	public string rightAnim;

	// Token: 0x04001B1C RID: 6940
	public bool defaultLeft;

	// Token: 0x04001B1D RID: 6941
	public float centreOffset;

	// Token: 0x04001B1E RID: 6942
	[Tooltip("Limit's behaviour if further than this from the hero's Z. Leave 0 for no limit.")]
	public float limitZ;

	// Token: 0x04001B1F RID: 6943
	public TriggerEnterEvent enterDetector;

	// Token: 0x04001B20 RID: 6944
	public TriggerEnterEvent exitDetector;

	// Token: 0x04001B21 RID: 6945
	private Transform target;

	// Token: 0x04001B22 RID: 6946
	private LookAnimNPC.AnimState state;

	// Token: 0x04001B23 RID: 6947
	private float turnFinishTime;

	// Token: 0x04001B24 RID: 6948
	private bool isTurning;

	// Token: 0x04001B25 RID: 6949
	private tk2dSpriteAnimator anim;

	// Token: 0x020003D8 RID: 984
	private enum AnimState
	{
		// Token: 0x04001B27 RID: 6951
		Left,
		// Token: 0x04001B28 RID: 6952
		TurningLeft,
		// Token: 0x04001B29 RID: 6953
		Right,
		// Token: 0x04001B2A RID: 6954
		TurningRight
	}
}
