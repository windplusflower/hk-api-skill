using System;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x020005DB RID: 1499
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000B45BE File Offset: 0x000B27BE
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x000B45C6 File Offset: 0x000B27C6
		public Color startColor
		{
			get
			{
				return this.m_StartColor;
			}
			set
			{
				this.m_StartColor = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000B45CF File Offset: 0x000B27CF
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x000B45D7 File Offset: 0x000B27D7
		public Color targetColor
		{
			get
			{
				return this.m_TargetColor;
			}
			set
			{
				this.m_TargetColor = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x000B45E0 File Offset: 0x000B27E0
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x000B45E8 File Offset: 0x000B27E8
		public ColorTween.ColorTweenMode tweenMode
		{
			get
			{
				return this.m_TweenMode;
			}
			set
			{
				this.m_TweenMode = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000B45F1 File Offset: 0x000B27F1
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x000B45F9 File Offset: 0x000B27F9
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000B4602 File Offset: 0x000B2802
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x000B460A File Offset: 0x000B280A
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

		// Token: 0x060022FE RID: 8958 RVA: 0x000B4614 File Offset: 0x000B2814
		public void TweenValue(float floatPercentage)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			Color arg = Color.Lerp(this.m_StartColor, this.m_TargetColor, floatPercentage);
			if (this.m_TweenMode == ColorTween.ColorTweenMode.Alpha)
			{
				arg.r = this.m_StartColor.r;
				arg.g = this.m_StartColor.g;
				arg.b = this.m_StartColor.b;
			}
			else if (this.m_TweenMode == ColorTween.ColorTweenMode.RGB)
			{
				arg.a = this.m_StartColor.a;
			}
			this.m_Target.Invoke(arg);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000B46A5 File Offset: 0x000B28A5
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new ColorTween.ColorTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000B4602 File Offset: 0x000B2802
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000B45F1 File Offset: 0x000B27F1
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000B46C6 File Offset: 0x000B28C6
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x0400278F RID: 10127
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x04002790 RID: 10128
		private Color m_StartColor;

		// Token: 0x04002791 RID: 10129
		private Color m_TargetColor;

		// Token: 0x04002792 RID: 10130
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x04002793 RID: 10131
		private float m_Duration;

		// Token: 0x04002794 RID: 10132
		private bool m_IgnoreTimeScale;

		// Token: 0x020005DC RID: 1500
		public enum ColorTweenMode
		{
			// Token: 0x04002796 RID: 10134
			All,
			// Token: 0x04002797 RID: 10135
			RGB,
			// Token: 0x04002798 RID: 10136
			Alpha
		}

		// Token: 0x020005DD RID: 1501
		public class ColorTweenCallback : UnityEvent<Color>
		{
		}
	}
}
