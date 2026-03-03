using System;
using System.Collections;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005E0 RID: 1504
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x000B4789 File Offset: 0x000B2989
		private static IEnumerator Start(T tweenInfo)
		{
			if (!tweenInfo.ValidTarget())
			{
				yield break;
			}
			float elapsedTime = 0f;
			while (elapsedTime < tweenInfo.duration)
			{
				elapsedTime += (tweenInfo.ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime);
				float floatPercentage = Mathf.Clamp01(elapsedTime / tweenInfo.duration);
				tweenInfo.TweenValue(floatPercentage);
				yield return null;
			}
			tweenInfo.TweenValue(1f);
			yield break;
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000B4798 File Offset: 0x000B2998
		public void Init(MonoBehaviour coroutineContainer)
		{
			this.m_CoroutineContainer = coroutineContainer;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000B47A4 File Offset: 0x000B29A4
		public void StartTween(T info)
		{
			if (this.m_CoroutineContainer == null)
			{
				Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
				return;
			}
			this.StopTween();
			if (!this.m_CoroutineContainer.gameObject.activeInHierarchy)
			{
				info.TweenValue(1f);
				return;
			}
			this.m_Tween = TweenRunner<T>.Start(info);
			this.m_CoroutineContainer.StartCoroutine(this.m_Tween);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000B4813 File Offset: 0x000B2A13
		public void StopTween()
		{
			if (this.m_Tween != null)
			{
				this.m_CoroutineContainer.StopCoroutine(this.m_Tween);
				this.m_Tween = null;
			}
		}

		// Token: 0x0400279E RID: 10142
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x0400279F RID: 10143
		protected IEnumerator m_Tween;
	}
}
