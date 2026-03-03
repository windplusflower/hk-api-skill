using System;
using UnityEngine;

// Token: 0x02000506 RID: 1286
[CreateAssetMenu(fileName = "GamepadVibration", menuName = "Hollow Knight/Gamepad Vibration", order = 164)]
public class GamepadVibration : ScriptableObject
{
	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0008584D File Offset: 0x00083A4D
	public AnimationCurve SmallMotor
	{
		get
		{
			return this.smallMotor;
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00085855 File Offset: 0x00083A55
	public AnimationCurve LargeMotor
	{
		get
		{
			return this.largeMotor;
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0008585D File Offset: 0x00083A5D
	public float PlaybackRate
	{
		get
		{
			return this.playbackRate;
		}
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00085868 File Offset: 0x00083A68
	protected void Reset()
	{
		this.smallMotor = AnimationCurve.Constant(0f, 1f, 1f);
		this.largeMotor = AnimationCurve.Constant(0f, 1f, 1f);
		this.playbackRate = 1f;
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x000858B4 File Offset: 0x00083AB4
	public float GetDuration()
	{
		return Mathf.Max(GamepadVibration.GetDuration(this.smallMotor), GamepadVibration.GetDuration(this.largeMotor));
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x000858D4 File Offset: 0x00083AD4
	private static float GetDuration(AnimationCurve animationCurve)
	{
		if (animationCurve.length == 0)
		{
			return 0f;
		}
		return animationCurve[animationCurve.length - 1].time;
	}

	// Token: 0x04002203 RID: 8707
	[SerializeField]
	private AnimationCurve smallMotor;

	// Token: 0x04002204 RID: 8708
	[SerializeField]
	private AnimationCurve largeMotor;

	// Token: 0x04002205 RID: 8709
	[SerializeField]
	[Range(0.01f, 5f)]
	private float playbackRate;
}
