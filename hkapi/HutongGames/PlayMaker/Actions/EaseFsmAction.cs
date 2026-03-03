using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B05 RID: 2821
	[Tooltip("Ease base action - don't use!")]
	public abstract class EaseFsmAction : FsmStateAction
	{
		// Token: 0x06003C80 RID: 15488 RVA: 0x0015D7D4 File Offset: 0x0015B9D4
		public override void Reset()
		{
			this.easeType = EaseFsmAction.EaseType.linear;
			this.time = new FsmFloat
			{
				Value = 1f
			};
			this.delay = new FsmFloat
			{
				UseVariable = true
			};
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.reverse = new FsmBool
			{
				Value = false
			};
			this.realTime = false;
			this.finishEvent = null;
			this.ease = null;
			this.runningTime = 0f;
			this.lastTime = 0f;
			this.percentage = 0f;
			this.fromFloats = new float[0];
			this.toFloats = new float[0];
			this.resultFloats = new float[0];
			this.finishAction = false;
			this.start = false;
			this.finished = false;
			this.isRunning = false;
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0015D8AC File Offset: 0x0015BAAC
		public override void OnEnter()
		{
			this.finished = false;
			this.isRunning = false;
			this.SetEasingFunction();
			this.runningTime = 0f;
			this.percentage = (this.reverse.IsNone ? 0f : (this.reverse.Value ? 1f : 0f));
			this.finishAction = false;
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
			this.delayTime = (this.delay.IsNone ? 0f : (this.delayTime = this.delay.Value));
			this.start = true;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x0015D964 File Offset: 0x0015BB64
		public override void OnUpdate()
		{
			if (this.start && !this.isRunning)
			{
				if (this.delayTime >= 0f)
				{
					if (this.realTime)
					{
						this.deltaTime = FsmTime.RealtimeSinceStartup - this.startTime - this.lastTime;
						this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
						this.delayTime -= this.deltaTime;
					}
					else
					{
						this.delayTime -= Time.deltaTime;
					}
				}
				else
				{
					this.isRunning = true;
					this.start = false;
					this.startTime = FsmTime.RealtimeSinceStartup;
					this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
				}
			}
			if (this.isRunning && !this.finished)
			{
				if (this.reverse.IsNone || !this.reverse.Value)
				{
					this.UpdatePercentage();
					if (this.percentage < 1f)
					{
						for (int i = 0; i < this.fromFloats.Length; i++)
						{
							this.resultFloats[i] = this.ease(this.fromFloats[i], this.toFloats[i], this.percentage);
						}
						return;
					}
					this.finishAction = true;
					this.finished = true;
					this.isRunning = false;
					return;
				}
				else
				{
					this.UpdatePercentage();
					if (this.percentage > 0f)
					{
						for (int j = 0; j < this.fromFloats.Length; j++)
						{
							this.resultFloats[j] = this.ease(this.fromFloats[j], this.toFloats[j], this.percentage);
						}
						return;
					}
					this.finishAction = true;
					this.finished = true;
					this.isRunning = false;
				}
			}
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0015DB1C File Offset: 0x0015BD1C
		protected void UpdatePercentage()
		{
			if (this.realTime)
			{
				this.deltaTime = FsmTime.RealtimeSinceStartup - this.startTime - this.lastTime;
				this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
				if (!this.speed.IsNone)
				{
					this.runningTime += this.deltaTime * this.speed.Value;
				}
				else
				{
					this.runningTime += this.deltaTime;
				}
			}
			else if (!this.speed.IsNone)
			{
				this.runningTime += Time.deltaTime * this.speed.Value;
			}
			else
			{
				this.runningTime += Time.deltaTime;
			}
			if (!this.reverse.IsNone && this.reverse.Value)
			{
				this.percentage = 1f - this.runningTime / this.time.Value;
				return;
			}
			this.percentage = this.runningTime / this.time.Value;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x0015DC34 File Offset: 0x0015BE34
		protected void SetEasingFunction()
		{
			switch (this.easeType)
			{
			case EaseFsmAction.EaseType.easeInQuad:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInQuad);
				return;
			case EaseFsmAction.EaseType.easeOutQuad:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutQuad);
				return;
			case EaseFsmAction.EaseType.easeInOutQuad:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutQuad);
				return;
			case EaseFsmAction.EaseType.easeInCubic:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInCubic);
				return;
			case EaseFsmAction.EaseType.easeOutCubic:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutCubic);
				return;
			case EaseFsmAction.EaseType.easeInOutCubic:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutCubic);
				return;
			case EaseFsmAction.EaseType.easeInQuart:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInQuart);
				return;
			case EaseFsmAction.EaseType.easeOutQuart:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutQuart);
				return;
			case EaseFsmAction.EaseType.easeInOutQuart:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutQuart);
				return;
			case EaseFsmAction.EaseType.easeInQuint:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInQuint);
				return;
			case EaseFsmAction.EaseType.easeOutQuint:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutQuint);
				return;
			case EaseFsmAction.EaseType.easeInOutQuint:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutQuint);
				return;
			case EaseFsmAction.EaseType.easeInSine:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInSine);
				return;
			case EaseFsmAction.EaseType.easeOutSine:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutSine);
				return;
			case EaseFsmAction.EaseType.easeInOutSine:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutSine);
				return;
			case EaseFsmAction.EaseType.easeInExpo:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInExpo);
				return;
			case EaseFsmAction.EaseType.easeOutExpo:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutExpo);
				return;
			case EaseFsmAction.EaseType.easeInOutExpo:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutExpo);
				return;
			case EaseFsmAction.EaseType.easeInCirc:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInCirc);
				return;
			case EaseFsmAction.EaseType.easeOutCirc:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutCirc);
				return;
			case EaseFsmAction.EaseType.easeInOutCirc:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutCirc);
				return;
			case EaseFsmAction.EaseType.linear:
				this.ease = new EaseFsmAction.EasingFunction(this.linear);
				return;
			case EaseFsmAction.EaseType.spring:
				this.ease = new EaseFsmAction.EasingFunction(this.spring);
				return;
			case EaseFsmAction.EaseType.bounce:
				this.ease = new EaseFsmAction.EasingFunction(this.bounce);
				return;
			case EaseFsmAction.EaseType.easeInBack:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInBack);
				return;
			case EaseFsmAction.EaseType.easeOutBack:
				this.ease = new EaseFsmAction.EasingFunction(this.easeOutBack);
				return;
			case EaseFsmAction.EaseType.easeInOutBack:
				this.ease = new EaseFsmAction.EasingFunction(this.easeInOutBack);
				return;
			case EaseFsmAction.EaseType.elastic:
				this.ease = new EaseFsmAction.EasingFunction(this.elastic);
				return;
			default:
				return;
			}
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x000B2BE2 File Offset: 0x000B0DE2
		protected float linear(float start, float end, float value)
		{
			return Mathf.Lerp(start, end, value);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0015DED4 File Offset: 0x0015C0D4
		protected float clerp(float start, float end, float value)
		{
			float num = 0f;
			float num2 = 360f;
			float num3 = Mathf.Abs((num2 - num) / 2f);
			float result;
			if (end - start < -num3)
			{
				float num4 = (num2 - start + end) * value;
				result = start + num4;
			}
			else if (end - start > num3)
			{
				float num4 = -(num2 - end + start) * value;
				result = start + num4;
			}
			else
			{
				result = start + (end - start) * value;
			}
			return result;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0015DF40 File Offset: 0x0015C140
		protected float spring(float start, float end, float value)
		{
			value = Mathf.Clamp01(value);
			value = (Mathf.Sin(value * 3.1415927f * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + 1.2f * (1f - value));
			return start + (end - start) * value;
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x000B2CC0 File Offset: 0x000B0EC0
		protected float easeInQuad(float start, float end, float value)
		{
			end -= start;
			return end * value * value + start;
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x000B2CD0 File Offset: 0x000B0ED0
		protected float easeOutQuad(float start, float end, float value)
		{
			end -= start;
			return -end * value * (value - 2f) + start;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x0015DFA8 File Offset: 0x0015C1A8
		protected float easeInOutQuad(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end / 2f * value * value + start;
			}
			value -= 1f;
			return -end / 2f * (value * (value - 2f) - 1f) + start;
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x000B2D42 File Offset: 0x000B0F42
		protected float easeInCubic(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value + start;
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x000B2D54 File Offset: 0x000B0F54
		protected float easeOutCubic(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * (value * value * value + 1f) + start;
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0015E004 File Offset: 0x0015C204
		protected float easeInOutCubic(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end / 2f * value * value * value + start;
			}
			value -= 2f;
			return end / 2f * (value * value * value + 2f) + start;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x000B2DCF File Offset: 0x000B0FCF
		protected float easeInQuart(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value * value + start;
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x000B2DE3 File Offset: 0x000B0FE3
		protected float easeOutQuart(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return -end * (value * value * value * value - 1f) + start;
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x0015E05C File Offset: 0x0015C25C
		protected float easeInOutQuart(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end / 2f * value * value * value * value + start;
			}
			value -= 2f;
			return -end / 2f * (value * value * value * value - 2f) + start;
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x000B2E68 File Offset: 0x000B1068
		protected float easeInQuint(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value * value * value + start;
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x000B2E7E File Offset: 0x000B107E
		protected float easeOutQuint(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * (value * value * value * value * value + 1f) + start;
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0015E0B8 File Offset: 0x0015C2B8
		protected float easeInOutQuint(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end / 2f * value * value * value * value * value + start;
			}
			value -= 2f;
			return end / 2f * (value * value * value * value * value + 2f) + start;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x000B2F07 File Offset: 0x000B1107
		protected float easeInSine(float start, float end, float value)
		{
			end -= start;
			return -end * Mathf.Cos(value / 1f * 1.5707964f) + end + start;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x000B2F29 File Offset: 0x000B1129
		protected float easeOutSine(float start, float end, float value)
		{
			end -= start;
			return end * Mathf.Sin(value / 1f * 1.5707964f) + start;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000B2F48 File Offset: 0x000B1148
		protected float easeInOutSine(float start, float end, float value)
		{
			end -= start;
			return -end / 2f * (Mathf.Cos(3.1415927f * value / 1f) - 1f) + start;
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x000B2F74 File Offset: 0x000B1174
		protected float easeInExpo(float start, float end, float value)
		{
			end -= start;
			return end * Mathf.Pow(2f, 10f * (value / 1f - 1f)) + start;
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x000B2F9E File Offset: 0x000B119E
		protected float easeOutExpo(float start, float end, float value)
		{
			end -= start;
			return end * (-Mathf.Pow(2f, -10f * value / 1f) + 1f) + start;
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0015E118 File Offset: 0x0015C318
		protected float easeInOutExpo(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end / 2f * Mathf.Pow(2f, 10f * (value - 1f)) + start;
			}
			value -= 1f;
			return end / 2f * (-Mathf.Pow(2f, -10f * value) + 2f) + start;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x000B3042 File Offset: 0x000B1242
		protected float easeInCirc(float start, float end, float value)
		{
			end -= start;
			return -end * (Mathf.Sqrt(1f - value * value) - 1f) + start;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x000B3064 File Offset: 0x000B1264
		protected float easeOutCirc(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * Mathf.Sqrt(1f - value * value) + start;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0015E190 File Offset: 0x0015C390
		protected float easeInOutCirc(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return -end / 2f * (Mathf.Sqrt(1f - value * value) - 1f) + start;
			}
			value -= 2f;
			return end / 2f * (Mathf.Sqrt(1f - value * value) + 1f) + start;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x0015E200 File Offset: 0x0015C400
		protected float bounce(float start, float end, float value)
		{
			value /= 1f;
			end -= start;
			if (value < 0.36363637f)
			{
				return end * (7.5625f * value * value) + start;
			}
			if (value < 0.72727275f)
			{
				value -= 0.54545456f;
				return end * (7.5625f * value * value + 0.75f) + start;
			}
			if ((double)value < 0.9090909090909091)
			{
				value -= 0.8181818f;
				return end * (7.5625f * value * value + 0.9375f) + start;
			}
			value -= 0.95454544f;
			return end * (7.5625f * value * value + 0.984375f) + start;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0015E2A8 File Offset: 0x0015C4A8
		protected float easeInBack(float start, float end, float value)
		{
			end -= start;
			value /= 1f;
			float num = 1.70158f;
			return end * value * value * ((num + 1f) * value - num) + start;
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x0015E2E0 File Offset: 0x0015C4E0
		protected float easeOutBack(float start, float end, float value)
		{
			float num = 1.70158f;
			end -= start;
			value = value / 1f - 1f;
			return end * (value * value * ((num + 1f) * value + num) + 1f) + start;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0015E324 File Offset: 0x0015C524
		protected float easeInOutBack(float start, float end, float value)
		{
			float num = 1.70158f;
			end -= start;
			value /= 0.5f;
			if (value < 1f)
			{
				num *= 1.525f;
				return end / 2f * (value * value * ((num + 1f) * value - num)) + start;
			}
			value -= 2f;
			num *= 1.525f;
			return end / 2f * (value * value * ((num + 1f) * value + num) + 2f) + start;
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0015E3A8 File Offset: 0x0015C5A8
		protected float punch(float amplitude, float value)
		{
			if (value == 0f)
			{
				return 0f;
			}
			if (value == 1f)
			{
				return 0f;
			}
			float num = 0.3f;
			float num2 = num / 6.2831855f * Mathf.Asin(0f);
			return amplitude * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * 1f - num2) * 6.2831855f / num);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x0015E41C File Offset: 0x0015C61C
		protected float elastic(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (value == 0f)
			{
				return start;
			}
			if ((value /= num) == 1f)
			{
				return start + end;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(end))
			{
				num3 = end;
				num4 = num2 / 4f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
			}
			return num3 * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * num - num4) * 6.2831855f / num2) + end + start;
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x0015E4BF File Offset: 0x0015C6BF
		protected EaseFsmAction()
		{
			this.easeType = EaseFsmAction.EaseType.linear;
			this.fromFloats = new float[0];
			this.toFloats = new float[0];
			this.resultFloats = new float[0];
			base..ctor();
		}

		// Token: 0x04004084 RID: 16516
		[RequiredField]
		public FsmFloat time;

		// Token: 0x04004085 RID: 16517
		public FsmFloat speed;

		// Token: 0x04004086 RID: 16518
		public FsmFloat delay;

		// Token: 0x04004087 RID: 16519
		public EaseFsmAction.EaseType easeType;

		// Token: 0x04004088 RID: 16520
		public FsmBool reverse;

		// Token: 0x04004089 RID: 16521
		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		// Token: 0x0400408A RID: 16522
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x0400408B RID: 16523
		protected EaseFsmAction.EasingFunction ease;

		// Token: 0x0400408C RID: 16524
		protected float runningTime;

		// Token: 0x0400408D RID: 16525
		protected float lastTime;

		// Token: 0x0400408E RID: 16526
		protected float startTime;

		// Token: 0x0400408F RID: 16527
		protected float deltaTime;

		// Token: 0x04004090 RID: 16528
		protected float delayTime;

		// Token: 0x04004091 RID: 16529
		protected float percentage;

		// Token: 0x04004092 RID: 16530
		protected float[] fromFloats;

		// Token: 0x04004093 RID: 16531
		protected float[] toFloats;

		// Token: 0x04004094 RID: 16532
		protected float[] resultFloats;

		// Token: 0x04004095 RID: 16533
		protected bool finishAction;

		// Token: 0x04004096 RID: 16534
		protected bool start;

		// Token: 0x04004097 RID: 16535
		protected bool finished;

		// Token: 0x04004098 RID: 16536
		protected bool isRunning;

		// Token: 0x02000B06 RID: 2822
		// (Invoke) Token: 0x06003CA6 RID: 15526
		protected delegate float EasingFunction(float start, float end, float value);

		// Token: 0x02000B07 RID: 2823
		public enum EaseType
		{
			// Token: 0x0400409A RID: 16538
			easeInQuad,
			// Token: 0x0400409B RID: 16539
			easeOutQuad,
			// Token: 0x0400409C RID: 16540
			easeInOutQuad,
			// Token: 0x0400409D RID: 16541
			easeInCubic,
			// Token: 0x0400409E RID: 16542
			easeOutCubic,
			// Token: 0x0400409F RID: 16543
			easeInOutCubic,
			// Token: 0x040040A0 RID: 16544
			easeInQuart,
			// Token: 0x040040A1 RID: 16545
			easeOutQuart,
			// Token: 0x040040A2 RID: 16546
			easeInOutQuart,
			// Token: 0x040040A3 RID: 16547
			easeInQuint,
			// Token: 0x040040A4 RID: 16548
			easeOutQuint,
			// Token: 0x040040A5 RID: 16549
			easeInOutQuint,
			// Token: 0x040040A6 RID: 16550
			easeInSine,
			// Token: 0x040040A7 RID: 16551
			easeOutSine,
			// Token: 0x040040A8 RID: 16552
			easeInOutSine,
			// Token: 0x040040A9 RID: 16553
			easeInExpo,
			// Token: 0x040040AA RID: 16554
			easeOutExpo,
			// Token: 0x040040AB RID: 16555
			easeInOutExpo,
			// Token: 0x040040AC RID: 16556
			easeInCirc,
			// Token: 0x040040AD RID: 16557
			easeOutCirc,
			// Token: 0x040040AE RID: 16558
			easeInOutCirc,
			// Token: 0x040040AF RID: 16559
			linear,
			// Token: 0x040040B0 RID: 16560
			spring,
			// Token: 0x040040B1 RID: 16561
			bounce,
			// Token: 0x040040B2 RID: 16562
			easeInBack,
			// Token: 0x040040B3 RID: 16563
			easeOutBack,
			// Token: 0x040040B4 RID: 16564
			easeInOutBack,
			// Token: 0x040040B5 RID: 16565
			elastic,
			// Token: 0x040040B6 RID: 16566
			punch
		}
	}
}
