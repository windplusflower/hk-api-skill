using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000023 RID: 35
public class AnimSpeedLerp : FsmStateAction
{
	// Token: 0x060000F4 RID: 244 RVA: 0x00005FC5 File Offset: 0x000041C5
	public override void Reset()
	{
		this.target = null;
		this.duration = null;
		this.toSpeed = null;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00005FDC File Offset: 0x000041DC
	public override void OnEnter()
	{
		this.elapsed = 0f;
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			this.animator = safe.GetComponent<Animator>();
			if (this.animator)
			{
				this.fromSpeed = this.animator.speed;
				return;
			}
		}
		base.Finish();
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0000603C File Offset: 0x0000423C
	public override void OnUpdate()
	{
		if (this.animator)
		{
			this.animator.speed = Mathf.Lerp(this.fromSpeed, this.toSpeed.Value, Mathf.Min(1f, this.elapsed / this.duration.Value));
			this.elapsed += Time.deltaTime;
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x000060A5 File Offset: 0x000042A5
	public override void OnExit()
	{
		if (this.animator)
		{
			this.animator.speed = 0f;
		}
	}

	// Token: 0x040000A7 RID: 167
	public FsmOwnerDefault target;

	// Token: 0x040000A8 RID: 168
	public FsmFloat duration;

	// Token: 0x040000A9 RID: 169
	public FsmFloat toSpeed;

	// Token: 0x040000AA RID: 170
	private float elapsed;

	// Token: 0x040000AB RID: 171
	private float fromSpeed;

	// Token: 0x040000AC RID: 172
	private Animator animator;
}
