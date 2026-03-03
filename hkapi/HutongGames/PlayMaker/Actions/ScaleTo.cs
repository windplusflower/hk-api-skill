using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A30 RID: 2608
	[ActionCategory("Hollow Knight")]
	[Tooltip("Scales a transform to a level.")]
	public class ScaleTo : FsmStateAction
	{
		// Token: 0x0600389B RID: 14491 RVA: 0x0014B4C4 File Offset: 0x001496C4
		public override void Reset()
		{
			base.Reset();
			this.gameObject = new FsmOwnerDefault
			{
				OwnerOption = OwnerDefaultOption.UseOwner
			};
			this.target = null;
			this.duration = 1f;
			this.delay = 0f;
			this.curve = ScaleToCurves.Linear;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0014B518 File Offset: 0x00149718
		public override void OnEnter()
		{
			base.OnEnter();
			this.timer = 0f;
			GameObject safe = this.gameObject.GetSafe(this);
			if (safe != null)
			{
				this.transform = safe.transform;
				this.startScale = this.transform.localScale;
			}
			else
			{
				this.transform = null;
			}
			this.UpdateScaling();
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0014B578 File Offset: 0x00149778
		public override void OnUpdate()
		{
			base.OnUpdate();
			this.UpdateScaling();
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0014B588 File Offset: 0x00149788
		private void UpdateScaling()
		{
			if (this.transform != null)
			{
				this.timer += Time.deltaTime;
				float curved = ScaleTo.GetCurved(Mathf.Clamp01((this.timer - this.delay.Value) / this.duration.Value), this.curve);
				this.transform.localScale = Vector3.Lerp(this.startScale, this.target.Value, curved);
				if (this.timer > this.duration.Value + this.delay.Value)
				{
					this.transform.localScale = this.target.Value;
					base.Finish();
					return;
				}
			}
			else
			{
				base.Finish();
			}
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0014B64B File Offset: 0x0014984B
		private static float GetCurved(float val, ScaleToCurves curve)
		{
			switch (curve)
			{
			default:
				return ScaleTo.Linear(val);
			case ScaleToCurves.QuadraticOut:
				return ScaleTo.QuadraticOut(val);
			case ScaleToCurves.SinusoidalOut:
				return ScaleTo.SinusoidalOut(val);
			}
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0014B673 File Offset: 0x00149873
		private static float Linear(float val)
		{
			return val;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0014B676 File Offset: 0x00149876
		private static float QuadraticOut(float val)
		{
			return val * (2f - val);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0014B681 File Offset: 0x00149881
		private static float SinusoidalOut(float val)
		{
			return Mathf.Sin(val * 3.1415927f * 0.5f);
		}

		// Token: 0x04003B46 RID: 15174
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B47 RID: 15175
		[RequiredField]
		public FsmVector3 target;

		// Token: 0x04003B48 RID: 15176
		public FsmFloat duration;

		// Token: 0x04003B49 RID: 15177
		public FsmFloat delay;

		// Token: 0x04003B4A RID: 15178
		public ScaleToCurves curve;

		// Token: 0x04003B4B RID: 15179
		private float timer;

		// Token: 0x04003B4C RID: 15180
		private Transform transform;

		// Token: 0x04003B4D RID: 15181
		private Vector3 startScale;
	}
}
