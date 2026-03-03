using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000509 RID: 1289
[ActionCategory("Hollow Knight")]
public class PlayVibration : FsmStateAction
{
	// Token: 0x06001C65 RID: 7269 RVA: 0x00085960 File Offset: 0x00083B60
	public override void Reset()
	{
		base.Reset();
		this.lowFidelityVibration = new FsmEnum
		{
			UseVariable = false
		};
		this.highFidelityVibration = new FsmObject
		{
			UseVariable = false
		};
		this.motors = new FsmEnum
		{
			UseVariable = false,
			Value = VibrationMotors.All
		};
		this.loopTime = new FsmFloat
		{
			UseVariable = true
		};
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x000859C7 File Offset: 0x00083BC7
	public override void OnEnter()
	{
		base.OnEnter();
		this.Play(false);
		this.EnqueueNextLoop();
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x000859DC File Offset: 0x00083BDC
	private void Play(bool loop)
	{
		VibrationMotors vibrationMotors = VibrationMotors.All;
		if (!this.motors.IsNone)
		{
			vibrationMotors = (VibrationMotors)this.motors.Value;
		}
		VibrationManager.PlayVibrationClipOneShot(VibrationData.Create((LowFidelityVibrations)this.lowFidelityVibration.Value, this.highFidelityVibration.Value as TextAsset, this.gamepadVibration.Value as GamepadVibration), new VibrationTarget?(new VibrationTarget(vibrationMotors)), loop, this.tag.Value ?? "");
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00085A64 File Offset: 0x00083C64
	public override void OnUpdate()
	{
		base.OnUpdate();
		this.cooldownTimer -= Time.deltaTime;
		if (this.cooldownTimer <= 0f)
		{
			this.Play(false);
			this.EnqueueNextLoop();
		}
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x00085A98 File Offset: 0x00083C98
	private void EnqueueNextLoop()
	{
		float num = 0f;
		if (!this.loopTime.IsNone)
		{
			num = this.loopTime.Value;
		}
		if (num < Mathf.Epsilon)
		{
			base.Finish();
			return;
		}
		this.cooldownTimer = num;
	}

	// Token: 0x0400220A RID: 8714
	[ObjectType(typeof(LowFidelityVibrations))]
	public FsmEnum lowFidelityVibration;

	// Token: 0x0400220B RID: 8715
	[ObjectType(typeof(TextAsset))]
	public FsmObject highFidelityVibration;

	// Token: 0x0400220C RID: 8716
	[ObjectType(typeof(VibrationMotors))]
	public FsmEnum motors;

	// Token: 0x0400220D RID: 8717
	public FsmFloat loopTime;

	// Token: 0x0400220E RID: 8718
	public FsmBool isLooping;

	// Token: 0x0400220F RID: 8719
	public FsmString tag;

	// Token: 0x04002210 RID: 8720
	[ObjectType(typeof(GamepadVibration))]
	public FsmObject gamepadVibration;

	// Token: 0x04002211 RID: 8721
	private float cooldownTimer;
}
