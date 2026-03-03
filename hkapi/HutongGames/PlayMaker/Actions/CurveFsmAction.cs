using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AFF RID: 2815
	[Tooltip("Animate base action - DON'T USE IT!")]
	public abstract class CurveFsmAction : FsmStateAction
	{
		// Token: 0x06003C67 RID: 15463 RVA: 0x0015C020 File Offset: 0x0015A220
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
			this.distances = new float[0];
			this.endTimes = new float[0];
			this.keyOffsets = new float[0];
			this.curves = new AnimationCurve[0];
			this.finishAction = false;
			this.start = false;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x0015C0E8 File Offset: 0x0015A2E8
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

		// Token: 0x06003C69 RID: 15465 RVA: 0x0015C174 File Offset: 0x0015A374
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
			this.distances = new float[this.fromFloats.Length];
			for (int k = 0; k < this.fromFloats.Length; k++)
			{
				this.distances[k] = this.toFloats[k] - this.fromFloats[k];
			}
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x0015C420 File Offset: 0x0015A620
		public override void OnUpdate()
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
			if (this.isRunning && !this.finishAction)
			{
				if (this.realTime)
				{
					this.deltaTime = FsmTime.RealtimeSinceStartup - this.startTime - this.lastTime;
					this.lastTime = FsmTime.RealtimeSinceStartup - this.startTime;
					if (!this.speed.IsNone)
					{
						this.currentTime += this.deltaTime * this.speed.Value;
					}
					else
					{
						this.currentTime += this.deltaTime;
					}
				}
				else if (!this.speed.IsNone)
				{
					this.currentTime += Time.deltaTime * this.speed.Value;
				}
				else
				{
					this.currentTime += Time.deltaTime;
				}
				for (int i = 0; i < this.curves.Length; i++)
				{
					if (this.curves[i] != null && this.curves[i].keys.Length != 0)
					{
						if (this.calculations[i] != CurveFsmAction.Calculation.None)
						{
							switch (this.calculations[i])
							{
							case CurveFsmAction.Calculation.AddToValue:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = this.fromFloats[i] + (this.distances[i] * (this.currentTime / this.time.Value) + this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time));
								}
								else
								{
									this.resultFloats[i] = this.fromFloats[i] + (this.distances[i] * (this.currentTime / this.endTimes[i]) + this.curves[i].Evaluate(this.currentTime));
								}
								break;
							case CurveFsmAction.Calculation.SubtractFromValue:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = this.fromFloats[i] + (this.distances[i] * (this.currentTime / this.time.Value) - this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time));
								}
								else
								{
									this.resultFloats[i] = this.fromFloats[i] + (this.distances[i] * (this.currentTime / this.endTimes[i]) - this.curves[i].Evaluate(this.currentTime));
								}
								break;
							case CurveFsmAction.Calculation.SubtractValueFromCurve:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) - this.distances[i] * (this.currentTime / this.time.Value) + this.fromFloats[i];
								}
								else
								{
									this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime) - this.distances[i] * (this.currentTime / this.endTimes[i]) + this.fromFloats[i];
								}
								break;
							case CurveFsmAction.Calculation.MultiplyValue:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) * this.distances[i] * (this.currentTime / this.time.Value) + this.fromFloats[i];
								}
								else
								{
									this.resultFloats[i] = this.curves[i].Evaluate(this.currentTime) * this.distances[i] * (this.currentTime / this.endTimes[i]) + this.fromFloats[i];
								}
								break;
							case CurveFsmAction.Calculation.DivideValue:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = ((this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) != 0f) ? (this.fromFloats[i] + this.distances[i] * (this.currentTime / this.time.Value) / this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time)) : float.MaxValue);
								}
								else
								{
									this.resultFloats[i] = ((this.curves[i].Evaluate(this.currentTime) != 0f) ? (this.fromFloats[i] + this.distances[i] * (this.currentTime / this.endTimes[i]) / this.curves[i].Evaluate(this.currentTime)) : float.MaxValue);
								}
								break;
							case CurveFsmAction.Calculation.DivideCurveByValue:
								if (!this.time.IsNone)
								{
									this.resultFloats[i] = ((this.fromFloats[i] != 0f) ? (this.curves[i].Evaluate(this.currentTime / this.time.Value * this.curves[i].keys[this.curves[i].length - 1].time) / (this.distances[i] * (this.currentTime / this.time.Value)) + this.fromFloats[i]) : float.MaxValue);
								}
								else
								{
									this.resultFloats[i] = ((this.fromFloats[i] != 0f) ? (this.curves[i].Evaluate(this.currentTime) / (this.distances[i] * (this.currentTime / this.endTimes[i])) + this.fromFloats[i]) : float.MaxValue);
								}
								break;
							}
						}
						else if (!this.time.IsNone)
						{
							this.resultFloats[i] = this.fromFloats[i] + this.distances[i] * (this.currentTime / this.time.Value);
						}
						else
						{
							this.resultFloats[i] = this.fromFloats[i] + this.distances[i] * (this.currentTime / this.endTimes[i]);
						}
					}
					else if (!this.time.IsNone)
					{
						this.resultFloats[i] = this.fromFloats[i] + this.distances[i] * (this.currentTime / this.time.Value);
					}
					else if (this.largestEndTime == 0f)
					{
						this.resultFloats[i] = this.fromFloats[i] + this.distances[i] * (this.currentTime / 1f);
					}
					else
					{
						this.resultFloats[i] = this.fromFloats[i] + this.distances[i] * (this.currentTime / this.largestEndTime);
					}
				}
				if (this.isRunning)
				{
					this.finishAction = true;
					for (int j = 0; j < this.endTimes.Length; j++)
					{
						if (this.currentTime < this.endTimes[j])
						{
							this.finishAction = false;
						}
					}
					this.isRunning = !this.finishAction;
				}
			}
		}

		// Token: 0x04004044 RID: 16452
		[Tooltip("Define time to use your curve scaled to be stretched or shrinked.")]
		public FsmFloat time;

		// Token: 0x04004045 RID: 16453
		[Tooltip("If you define speed, your animation will be speeded up or slowed down.")]
		public FsmFloat speed;

		// Token: 0x04004046 RID: 16454
		[Tooltip("Delayed animimation start.")]
		public FsmFloat delay;

		// Token: 0x04004047 RID: 16455
		[Tooltip("Animation curve start from any time. If IgnoreCurveOffset is true the animation starts right after the state become entered.")]
		public FsmBool ignoreCurveOffset;

		// Token: 0x04004048 RID: 16456
		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		// Token: 0x04004049 RID: 16457
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x0400404A RID: 16458
		private float startTime;

		// Token: 0x0400404B RID: 16459
		private float currentTime;

		// Token: 0x0400404C RID: 16460
		private float[] endTimes;

		// Token: 0x0400404D RID: 16461
		private float lastTime;

		// Token: 0x0400404E RID: 16462
		private float deltaTime;

		// Token: 0x0400404F RID: 16463
		private float delayTime;

		// Token: 0x04004050 RID: 16464
		private float[] keyOffsets;

		// Token: 0x04004051 RID: 16465
		protected AnimationCurve[] curves;

		// Token: 0x04004052 RID: 16466
		protected CurveFsmAction.Calculation[] calculations;

		// Token: 0x04004053 RID: 16467
		protected float[] resultFloats;

		// Token: 0x04004054 RID: 16468
		protected float[] fromFloats;

		// Token: 0x04004055 RID: 16469
		protected float[] toFloats;

		// Token: 0x04004056 RID: 16470
		private float[] distances;

		// Token: 0x04004057 RID: 16471
		protected bool finishAction;

		// Token: 0x04004058 RID: 16472
		protected bool isRunning;

		// Token: 0x04004059 RID: 16473
		protected bool looping;

		// Token: 0x0400405A RID: 16474
		private bool start;

		// Token: 0x0400405B RID: 16475
		private float largestEndTime;

		// Token: 0x02000B00 RID: 2816
		public enum Calculation
		{
			// Token: 0x0400405D RID: 16477
			None,
			// Token: 0x0400405E RID: 16478
			AddToValue,
			// Token: 0x0400405F RID: 16479
			SubtractFromValue,
			// Token: 0x04004060 RID: 16480
			SubtractValueFromCurve,
			// Token: 0x04004061 RID: 16481
			MultiplyValue,
			// Token: 0x04004062 RID: 16482
			DivideValue,
			// Token: 0x04004063 RID: 16483
			DivideCurveByValue
		}
	}
}
