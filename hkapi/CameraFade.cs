using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000DB RID: 219
public class CameraFade : MonoBehaviour
{
	// Token: 0x06000488 RID: 1160 RVA: 0x000167D9 File Offset: 0x000149D9
	private void Awake()
	{
		this.fadeTexture = new Texture2D(1, 1);
		this.backgroundStyle.normal.background = this.fadeTexture;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x000167FE File Offset: 0x000149FE
	private IEnumerator Start()
	{
		if (this.fadeOnStart == CameraFade.FadeTypes.BLACK_TO_CLEAR)
		{
			this.SetScreenOverlayColor(new Color(0f, 0f, 0f, 1f));
		}
		else if (this.fadeOnStart == CameraFade.FadeTypes.CLEAR_TO_BLACK)
		{
			this.SetScreenOverlayColor(new Color(0f, 0f, 0f, 0f));
		}
		if (this.startDelay > 0f)
		{
			yield return new WaitForSeconds(this.startDelay);
		}
		else
		{
			yield return new WaitForEndOfFrame();
		}
		if (this.fadeOnStart == CameraFade.FadeTypes.BLACK_TO_CLEAR)
		{
			this.FadeToTransparent(this.fadeTime);
		}
		else if (this.fadeOnStart == CameraFade.FadeTypes.CLEAR_TO_BLACK)
		{
			this.FadeToBlack(this.fadeTime);
		}
		yield break;
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00016810 File Offset: 0x00014A10
	private void OnGUI()
	{
		if (this.currentScreenOverlayColor != this.targetScreenOverlayColor)
		{
			if (Mathf.Abs(this.currentScreenOverlayColor.a - this.targetScreenOverlayColor.a) < Mathf.Abs(this.deltaColor.a) * Time.deltaTime)
			{
				this.currentScreenOverlayColor = this.targetScreenOverlayColor;
				this.SetScreenOverlayColor(this.currentScreenOverlayColor);
				this.deltaColor = new Color(0f, 0f, 0f, 0f);
			}
			else
			{
				this.SetScreenOverlayColor(this.currentScreenOverlayColor + this.deltaColor * Time.deltaTime);
			}
		}
		if (this.currentScreenOverlayColor.a > 0f)
		{
			GUI.depth = this.fadeGUIDepth;
			GUI.Label(new Rect(-10f, -10f, (float)(Screen.width + 10), (float)(Screen.height + 10)), this.fadeTexture, this.backgroundStyle);
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00016910 File Offset: 0x00014B10
	public void SetScreenOverlayColor(Color newScreenOverlayColor)
	{
		this.currentScreenOverlayColor = newScreenOverlayColor;
		this.fadeTexture.SetPixel(0, 0, this.currentScreenOverlayColor);
		this.fadeTexture.Apply();
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00016937 File Offset: 0x00014B37
	public void StartFade(Color newScreenOverlayColor, float fadeDuration)
	{
		if (fadeDuration <= 0f)
		{
			this.SetScreenOverlayColor(newScreenOverlayColor);
			return;
		}
		this.targetScreenOverlayColor = newScreenOverlayColor;
		this.deltaColor = (this.targetScreenOverlayColor - this.currentScreenOverlayColor) / (fadeDuration * 2f);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00016974 File Offset: 0x00014B74
	public void FadeToBlack(float duration)
	{
		this.SetScreenOverlayColor(new Color(0f, 0f, 0f, 0f));
		this.StartFade(new Color(0f, 0f, 0f, 1f), duration);
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000169C0 File Offset: 0x00014BC0
	public void FadeToTransparent(float duration)
	{
		this.SetScreenOverlayColor(new Color(0f, 0f, 0f, 1f));
		this.StartFade(new Color(0f, 0f, 0f, 0f), duration);
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00016A0C File Offset: 0x00014C0C
	public CameraFade()
	{
		this.backgroundStyle = new GUIStyle();
		this.currentScreenOverlayColor = new Color(0f, 0f, 0f, 0f);
		this.targetScreenOverlayColor = new Color(0f, 0f, 0f, 1f);
		this.deltaColor = new Color(0f, 0f, 0f, 0f);
		this.fadeGUIDepth = -1000;
		base..ctor();
	}

	// Token: 0x04000422 RID: 1058
	private GUIStyle backgroundStyle;

	// Token: 0x04000423 RID: 1059
	private Texture2D fadeTexture;

	// Token: 0x04000424 RID: 1060
	private Color currentScreenOverlayColor;

	// Token: 0x04000425 RID: 1061
	private Color targetScreenOverlayColor;

	// Token: 0x04000426 RID: 1062
	private Color deltaColor;

	// Token: 0x04000427 RID: 1063
	private int fadeGUIDepth;

	// Token: 0x04000428 RID: 1064
	[Header("Fade On Scene Start")]
	[Space(6f)]
	[Tooltip("Type of fade to do on Start.")]
	public CameraFade.FadeTypes fadeOnStart;

	// Token: 0x04000429 RID: 1065
	[Tooltip("The time in seconds to wait after Start before performing the delay.")]
	public float startDelay;

	// Token: 0x0400042A RID: 1066
	[Tooltip("Time to perform fade in seconds on Start.")]
	public float fadeTime;

	// Token: 0x020000DC RID: 220
	public enum FadeTypes
	{
		// Token: 0x0400042C RID: 1068
		NONE,
		// Token: 0x0400042D RID: 1069
		BLACK_TO_CLEAR,
		// Token: 0x0400042E RID: 1070
		CLEAR_TO_BLACK
	}
}
