using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF9 RID: 2809
	public abstract class AnimateFsmAction : FsmStateAction
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x0015ABB8 File Offset: 0x00158DB8
		public override void Reset()
		{
			this.finishEvent = null;
			this.realTime = false;
			this.time = new FsmFloat
			{
				UseVariable = true
			};
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.delay = new FsmFloat
			{
				UseVariable = true
			};
			this.ignoreCurveOffset = new FsmBool
			{
				Value = true
			};
			this.resultFloats = new float[0];
			this.fromFloats = new float[0];
			this.toFloats = new float[0];
			this.endTimes = new float[0];
			this.keyOffsets = new float[0];
			this.curves = new AnimationCurve[0];
			this.finishAction = false;
			this.start = false;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x0015AC74 File Offset: 0x00158E74
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
			this.deltaTime = 0f;
			this.currentTime = 0f;
			this.isRunning = false;
			this.finishAction = false;
			this.looping = false;
			this.delayTime = (this.delay.IsNone ? 0f : (this.delayTime = this.delay.Value));
			this.start = true;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x0015AD00 File Offset: 0x00158F00
		protected void Init()
		{
			this.endTimes = new float[this.curves.Length];
			this.keyOffsets = new float[this.curves.Length];
			this.largestEndTime = 0f;
			for (int i = 0; i < this.curves.Length; i++)
			{
				if (this.curves[i] != null && this.curves[i].keys.Length != 0)
				{
					this.keyOffsets[i] = ((this.curves[i].keys.Length != 0) ? (this.time.IsNone ? this.curves[i].keys[0].time : (this.time.Value / this.curves[i].keys[this.curves[i].length - 1].time * this.curves[i].keys[0].time)) : 0f);
					this.currentTime = (this.ignoreCurveOffset.IsNone ? 0f : (this.ignoreCurveOffset.Value ? this.keyOffsets[i] : 0f));
					if (!this.time.IsNone)
					{
						this.endTimes[i] = this.time.Value;
					}
					else
					{
						this.endTimes[i] = this.curves[i].keys[this.curves[i].length - 1].time;
					}
					if (this.largestEndTime < this.endTimes[i])
					{
						this.largestEndTime = this.endTimes[i];
					}
					if (!this.looping)
					{
						this.looping = ActionHelpers.IsLoopingWrapMode(this.curves[i].postWrapMode);
					}
				}
				else
				{
					this.endTimes[i] = -1f;
				}
			}
			for (int j = 0; j < this.curves.Length; j++)
			{
				if (this.largestEndTime > 0f && this.endTimes[j] == -1f)
				{
					this.endTimes[j] = this.largestEndTime;
				}
				else if (this.largestEndTime == 0f && this.endTimes[j] == -1f)
				{
					if (this.time.IsNone)
					{
						this.endTimes[j] = 1f;
					}
					else
					{
						this.endTimes[j] = this.time.Value;
					}
				}
			}
			this.UpdateAnimation();
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x0015AF71 File Offset: 0x00159171
		public override void OnUpdate()
		{
			this.CheckStart();
			if (this.isRunning)
			{
				this.UpdateTime();
				this.UpdateAnimation();
				this.CheckFinished();
			}
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0015AF94 File Offset: 0x00159194
		private void CheckStart()
		{
			if (!this.isRunning && this.start)
			{
				if (this.delayTime >= 0f)
				{
					if (this.realTime)
					{
						this.deltaTime = FsmTime.RealtimeSinceStartup - this.startTime - this.lastTime;
						this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
						this.delayTime -= this.deltaTime;
						return;
					}
					this.delayTime -= Time.deltaTime;
					return;
				}
				else
				{
					this.isRunning = true;
					this.start = false;
				}
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0015B02C File Offset: 0x0015922C
		private void UpdateTime()
		{
			if (this.realTime)
			{
				this.deltaTime = FsmTime.RealtimeSinceStartup - this.startTime - this.lastTime;
				this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
				if (!this.speed.IsNone)
				{
					this.currentTime += this.deltaTime * this.speed.Value;
					return;
				}
				this.currentTime += this.deltaTime;
				return;
			}
			else
			{
				if (!this.speed.IsNone)
				{
					this.currentTime += Time.deltaTime * this.speed.Value;
					return;
				}
				this.currentTime += Time.deltaTime;
				return;
			}
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0015B0EC File Offset: 0x001592EC
		public void UpdateAnimation()
		{
			for (int i = 0; i < this.curves.Length; i++)
			{
				if (this.curves[i] != null && this.curves[i].keys.Length != 0)
				{
					if (this.calculations[i] != AnimateFsmAction.Calculation.None)
					{
						switch (this.calculations[i])
						{
						case AnimateFsmAction.Calculation.SetValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time);
							}
							else
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime);
							}
							break;
						case AnimateFsmAction.Calculation.AddToValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = this.fromFloats[i] + this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time);
							}
							else
							{
								this.resultFloats[i] = this.fromFloats[i] + this.curves[i].Evaluate(this.currentTime);
							}
							break;
						case AnimateFsmAction.Calculation.SubtractFromValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = this.fromFloats[i] - this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time);
							}
							else
							{
								this.resultFloats[i] = this.fromFloats[i] - this.curves[i].Evaluate(this.currentTime);
							}
							break;
						case AnimateFsmAction.Calculation.SubtractValueFromCurve:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) - this.fromFloats[i];
							}
							else
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime) - this.fromFloats[i];
							}
							break;
						case AnimateFsmAction.Calculation.MultiplyValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) * this.fromFloats[i];
							}
							else
							{
								this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime) * this.fromFloats[i];
							}
							break;
						case AnimateFsmAction.Calculation.DivideValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = ((this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) != 0f) ? (this.fromFloats[i] / this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time)) : float.MaxValue);
							}
							else
							{
								this.resultFloats[i] = ((this.curves[i].Evaluate(this.currentTime) != 0f) ? (this.fromFloats[i] / this.curves[i].Evaluate(this.currentTime)) : float.MaxValue);
							}
							break;
						case AnimateFsmAction.Calculation.DivideCurveByValue:
							if (!this.time.IsNone)
							{
								this.resultFloats[i] = ((this.fromFloats[i] != 0f) ? (this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) / this.fromFloats[i]) : float.MaxValue);
							}
							else
							{
								this.resultFloats[i] = ((this.fromFloats[i] != 0f) ? (this.curves[i].Evaluate(this.currentTime) / this.fromFloats[i]) : float.MaxValue);
							}
							break;
						}
					}
					else
					{
						this.resultFloats[i] = this.fromFloats[i];
					}
				}
				else
				{
					this.resultFloats[i] = this.fromFloats[i];
				}
			}
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0015B620 File Offset: 0x00159820
		private void CheckFinished()
		{
			if (this.isRunning && !this.looping)
			{
				this.finishAction = true;
				for (int i = 0; i < this.endTimes.Length; i++)
				{
					if (this.currentTime < this.endTimes[i])
					{
						this.finishAction = false;
					}
				}
				this.isRunning = !this.finishAction;
			}
		}

		// Token: 0x04003FFF RID: 16383
		[Tooltip("Define time to use your curve scaled to be stretched or shrinked.")]
		public FsmFloat time;

		// Token: 0x04004000 RID: 16384
		[Tooltip("If you define speed, your animation will be speeded up or slowed down.")]
		public FsmFloat speed;

		// Token: 0x04004001 RID: 16385
		[Tooltip("Delayed animimation start.")]
		public FsmFloat delay;

		// Token: 0x04004002 RID: 16386
		[Tooltip("Animation curve start from any time. If IgnoreCurveOffset is true the animation starts right after the state become entered.")]
		public FsmBool ignoreCurveOffset;

		// Token: 0x04004003 RID: 16387
		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		// Token: 0x04004004 RID: 16388
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x04004005 RID: 16389
		private float startTime;

		// Token: 0x04004006 RID: 16390
		private float currentTime;

		// Token: 0x04004007 RID: 16391
		private float[] endTimes;

		// Token: 0x04004008 RID: 16392
		private float lastTime;

		// Token: 0x04004009 RID: 16393
		private float deltaTime;

		// Token: 0x0400400A RID: 16394
		private float delayTime;

		// Token: 0x0400400B RID: 16395
		private float[] keyOffsets;

		// Token: 0x0400400C RID: 16396
		protected AnimationCurve[] curves;

		// Token: 0x0400400D RID: 16397
		protected AnimateFsmAction.Calculation[] calculations;

		// Token: 0x0400400E RID: 16398
		protected float[] resultFloats;

		// Token: 0x0400400F RID: 16399
		protected float[] fromFloats;

		// Token: 0x04004010 RID: 16400
		protected float[] toFloats;

		// Token: 0x04004011 RID: 16401
		protected bool finishAction;

		// Token: 0x04004012 RID: 16402
		protected bool isRunning;

		// Token: 0x04004013 RID: 16403
		protected bool looping;

		// Token: 0x04004014 RID: 16404
		private bool start;

		// Token: 0x04004015 RID: 16405
		private float largestEndTime;

		// Token: 0x02000AFA RID: 2810
		public enum Calculation
		{
			// Token: 0x04004017 RID: 16407
			None,
			// Token: 0x04004018 RID: 16408
			SetValue,
			// Token: 0x04004019 RID: 16409
			AddToValue,
			// Token: 0x0400401A RID: 16410
			SubtractFromValue,
			// Token: 0x0400401B RID: 16411
			SubtractValueFromCurve,
			// Token: 0x0400401C RID: 16412
			MultiplyValue,
			// Token: 0x0400401D RID: 16413
			DivideValue,
			// Token: 0x0400401E RID: 16414
			DivideCurveByValue
		}
	}
}
