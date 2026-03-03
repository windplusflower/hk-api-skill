using System;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x020005DE RID: 1502
	internal struct FloatTween : ITweenValue
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x000B46D9 File Offset: 0x000B28D9
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x000B46E1 File Offset: 0x000B28E1
		public float startValue
		{
			get
			{
				return this.m_StartValue;
			}
			set
			{
				this.m_StartValue = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x000B46EA File Offset: 0x000B28EA
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x000B46F2 File Offset: 0x000B28F2
		public float targetValue
		{
			get
			{
				return this.m_TargetValue;
			}
			set
			{
				this.m_TargetValue = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x000B46FB File Offset: 0x000B28FB
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x000B4703 File Offset: 0x000B2903
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
			set
			{
				this.m_Duration = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000B470C File Offset: 0x000B290C
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x000B4714 File Offset: 0x000B2914
		public bool ignoreTimeScale
		{
			get
			{
				return this.m_IgnoreTimeScale;
			}
			set
			{
				this.m_IgnoreTimeScale = value;
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000B4720 File Offset: 0x000B2920
		public void TweenValue(float floatPercentage)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			float arg = Mathf.Lerp(this.m_StartValue, this.m_TargetValue, floatPercentage);
			this.m_Target.Invoke(arg);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000B4755 File Offset: 0x000B2955
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new FloatTween.FloatTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000B470C File Offset: 0x000B290C
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000B46FB File Offset: 0x000B28FB
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000B4776 File Offset: 0x000B2976
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x04002799 RID: 10137
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x0400279A RID: 10138
		private float m_StartValue;

		// Token: 0x0400279B RID: 10139
		private float m_TargetValue;

		// Token: 0x0400279C RID: 10140
		private float m_Duration;

		// Token: 0x0400279D RID: 10141
		private bool m_IgnoreTimeScale;

		// Token: 0x020005DF RID: 1503
		public class FloatTweenCallback : UnityEvent<float>
		{
		}
	}
}
