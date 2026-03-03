using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000429 RID: 1065
public class AchievementPopup : MonoBehaviour
{
	// Token: 0x14000037 RID: 55
	// (add) Token: 0x06001802 RID: 6146 RVA: 0x00070EFC File Offset: 0x0006F0FC
	// (remove) Token: 0x06001803 RID: 6147 RVA: 0x00070F34 File Offset: 0x0006F134
	public event AchievementPopup.SelfEvent OnFinish;

	// Token: 0x06001804 RID: 6148 RVA: 0x00070F69 File Offset: 0x0006F169
	private void Awake()
	{
		this.group = base.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00070F78 File Offset: 0x0006F178
	public void Setup(Sprite icon, string name, string description)
	{
		if (this.image)
		{
			this.image.sprite = icon;
		}
		if (this.nameText)
		{
			this.nameText.text = name;
		}
		if (this.descriptionText)
		{
			this.descriptionText.text = description;
		}
		this.sound.SpawnAndPlayOneShot(this.audioPlayerPrefab, Vector3.zero);
		this.currentState = AchievementPopup.FadeState.FadeUp;
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00070FF0 File Offset: 0x0006F1F0
	private void Update()
	{
		switch (this.currentState)
		{
		case AchievementPopup.FadeState.FadeUp:
			if (this.currentState != this.previousState)
			{
				this.elapsed = 0f;
				this.previousState = this.currentState;
			}
			this.group.alpha = Mathf.Lerp(0f, 1f, this.elapsed / this.fadeInTime);
			this.elapsed += Time.unscaledDeltaTime;
			if (this.elapsed >= this.fadeInTime)
			{
				this.group.alpha = 1f;
				this.currentState = AchievementPopup.FadeState.Wait;
				return;
			}
			break;
		case AchievementPopup.FadeState.Wait:
			if (this.currentState != this.previousState)
			{
				this.elapsed = 0f;
				this.previousState = this.currentState;
			}
			this.elapsed += Time.unscaledDeltaTime;
			if (this.elapsed >= this.holdTime)
			{
				this.currentState = AchievementPopup.FadeState.FadeDown;
				return;
			}
			break;
		case AchievementPopup.FadeState.FadeDown:
			if (this.currentState != this.previousState)
			{
				this.elapsed = 0f;
				this.previousState = this.currentState;
				if (this.fluerAnimator)
				{
					this.fluerAnimator.Play(this.fluerCloseName);
				}
			}
			this.group.alpha = Mathf.Lerp(1f, 0f, this.elapsed / this.fadeInTime);
			this.elapsed += Time.unscaledDeltaTime;
			if (this.elapsed >= this.fadeInTime)
			{
				this.group.alpha = 0f;
				this.currentState = AchievementPopup.FadeState.Finish;
				return;
			}
			break;
		case AchievementPopup.FadeState.Finish:
			if (this.currentState != this.previousState)
			{
				this.previousState = this.currentState;
				if (this.OnFinish != null)
				{
					this.OnFinish(this);
					return;
				}
				base.gameObject.SetActive(false);
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x000711D1 File Offset: 0x0006F3D1
	public AchievementPopup()
	{
		this.fadeInTime = 0.25f;
		this.holdTime = 3f;
		this.fadeOutTime = 0.5f;
		this.fluerCloseName = "Close";
		base..ctor();
	}

	// Token: 0x04001CC8 RID: 7368
	public Image image;

	// Token: 0x04001CC9 RID: 7369
	public Text nameText;

	// Token: 0x04001CCA RID: 7370
	public Text descriptionText;

	// Token: 0x04001CCB RID: 7371
	private CanvasGroup group;

	// Token: 0x04001CCC RID: 7372
	[Space]
	public float fadeInTime;

	// Token: 0x04001CCD RID: 7373
	public float holdTime;

	// Token: 0x04001CCE RID: 7374
	public float fadeOutTime;

	// Token: 0x04001CCF RID: 7375
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x04001CD0 RID: 7376
	public AudioEvent sound;

	// Token: 0x04001CD1 RID: 7377
	[Space]
	public Animator fluerAnimator;

	// Token: 0x04001CD2 RID: 7378
	public string fluerCloseName;

	// Token: 0x04001CD3 RID: 7379
	private AchievementPopup.FadeState currentState;

	// Token: 0x04001CD4 RID: 7380
	private AchievementPopup.FadeState previousState;

	// Token: 0x04001CD5 RID: 7381
	private float elapsed;

	// Token: 0x0200042A RID: 1066
	// (Invoke) Token: 0x06001809 RID: 6153
	public delegate void SelfEvent(AchievementPopup sender);

	// Token: 0x0200042B RID: 1067
	private enum FadeState
	{
		// Token: 0x04001CD7 RID: 7383
		None,
		// Token: 0x04001CD8 RID: 7384
		FadeUp,
		// Token: 0x04001CD9 RID: 7385
		Wait,
		// Token: 0x04001CDA RID: 7386
		FadeDown,
		// Token: 0x04001CDB RID: 7387
		Finish
	}
}
