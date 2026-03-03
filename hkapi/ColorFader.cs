using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x020000F0 RID: 240
public class ColorFader : MonoBehaviour
{
	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600050D RID: 1293 RVA: 0x0001AB54 File Offset: 0x00018D54
	// (remove) Token: 0x0600050E RID: 1294 RVA: 0x0001AB8C File Offset: 0x00018D8C
	public event ColorFader.FadeEndEvent OnFadeEnd;

	// Token: 0x0600050F RID: 1295 RVA: 0x0001ABC4 File Offset: 0x00018DC4
	private void Reset()
	{
		foreach (PlayMakerFSM playMakerFSM in base.GetComponents<PlayMakerFSM>())
		{
			if ((playMakerFSM.FsmTemplate ? playMakerFSM.FsmTemplate.name : playMakerFSM.FsmName) == "color_fader")
			{
				this.downColour = playMakerFSM.FsmVariables.GetFsmColor("Down Colour").Value;
				this.downTime = playMakerFSM.FsmVariables.GetFsmFloat("Down Time").Value;
				this.upColour = playMakerFSM.FsmVariables.GetFsmColor("Up Colour").Value;
				this.upDelay = playMakerFSM.FsmVariables.GetFsmFloat("Up Delay").Value;
				this.upTime = playMakerFSM.FsmVariables.GetFsmFloat("Up Time").Value;
				return;
			}
		}
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0001ACA7 File Offset: 0x00018EA7
	private void Start()
	{
		this.Setup();
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0001ACB0 File Offset: 0x00018EB0
	private void Setup()
	{
		if (!this.setup)
		{
			this.setup = true;
			if (!this.spriteRenderer)
			{
				this.spriteRenderer = base.GetComponent<SpriteRenderer>();
			}
			if (this.spriteRenderer)
			{
				this.initialColour = (this.useInitialColour ? this.spriteRenderer.color : Color.white);
				this.spriteRenderer.color = this.downColour * this.initialColour;
				return;
			}
			if (!this.textRenderer)
			{
				this.textRenderer = base.GetComponent<TextMeshPro>();
			}
			if (this.textRenderer)
			{
				this.initialColour = (this.useInitialColour ? this.textRenderer.color : Color.white);
				this.textRenderer.color = this.downColour * this.initialColour;
				return;
			}
			if (!this.tk2dSprite)
			{
				this.tk2dSprite = base.GetComponent<tk2dSprite>();
			}
			if (this.tk2dSprite)
			{
				this.initialColour = (this.useInitialColour ? this.tk2dSprite.color : Color.white);
				this.tk2dSprite.color = this.downColour * this.initialColour;
			}
		}
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0001ADF8 File Offset: 0x00018FF8
	public void Fade(bool up)
	{
		this.Setup();
		if (this.fadeRoutine != null)
		{
			base.StopCoroutine(this.fadeRoutine);
		}
		if (up)
		{
			this.fadeRoutine = base.StartCoroutine(this.Fade(this.upColour, this.upTime, this.upDelay));
			return;
		}
		this.fadeRoutine = base.StartCoroutine(this.Fade(this.downColour, this.downTime, 0f));
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001AE6A File Offset: 0x0001906A
	private IEnumerator Fade(Color to, float time, float delay)
	{
		if (!this.spriteRenderer)
		{
			this.spriteRenderer = this.GetComponent<SpriteRenderer>();
		}
		Color from = this.spriteRenderer ? this.spriteRenderer.color : (this.textRenderer ? this.textRenderer.color : (this.tk2dSprite ? this.tk2dSprite.color : Color.white));
		if (delay > 0f)
		{
			yield return new WaitForSeconds(this.upDelay);
		}
		for (float elapsed = 0f; elapsed < time; elapsed += Time.deltaTime)
		{
			Color color = Color.Lerp(from, to, elapsed / time) * this.initialColour;
			if (this.spriteRenderer)
			{
				this.spriteRenderer.color = color;
			}
			else if (this.textRenderer)
			{
				this.textRenderer.color = color;
			}
			else if (this.tk2dSprite)
			{
				this.tk2dSprite.color = color;
			}
			yield return null;
		}
		if (this.spriteRenderer)
		{
			this.spriteRenderer.color = to * this.initialColour;
		}
		else if (this.textRenderer)
		{
			this.textRenderer.color = to * this.initialColour;
		}
		else if (this.tk2dSprite)
		{
			this.tk2dSprite.color = to * this.initialColour;
		}
		if (this.OnFadeEnd != null)
		{
			this.OnFadeEnd(to == this.upColour);
		}
		yield break;
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001AE90 File Offset: 0x00019090
	public ColorFader()
	{
		this.downColour = new Color(1f, 1f, 1f, 0f);
		this.downTime = 0.5f;
		this.upColour = new Color(1f, 1f, 1f, 1f);
		this.upTime = 0.4f;
		this.useInitialColour = true;
		base..ctor();
	}

	// Token: 0x040004DC RID: 1244
	public Color downColour;

	// Token: 0x040004DD RID: 1245
	public float downTime;

	// Token: 0x040004DE RID: 1246
	public Color upColour;

	// Token: 0x040004DF RID: 1247
	public float upDelay;

	// Token: 0x040004E0 RID: 1248
	public float upTime;

	// Token: 0x040004E1 RID: 1249
	private Color initialColour;

	// Token: 0x040004E2 RID: 1250
	public bool useInitialColour;

	// Token: 0x040004E3 RID: 1251
	private SpriteRenderer spriteRenderer;

	// Token: 0x040004E4 RID: 1252
	private TextMeshPro textRenderer;

	// Token: 0x040004E5 RID: 1253
	private tk2dSprite tk2dSprite;

	// Token: 0x040004E6 RID: 1254
	private bool setup;

	// Token: 0x040004E7 RID: 1255
	private Coroutine fadeRoutine;

	// Token: 0x020000F1 RID: 241
	// (Invoke) Token: 0x06000516 RID: 1302
	public delegate void FadeEndEvent(bool up);
}
