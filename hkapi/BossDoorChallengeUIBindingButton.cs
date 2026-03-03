using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200028B RID: 651
public class BossDoorChallengeUIBindingButton : MonoBehaviour, ISubmitHandler, IEventSystemHandler, ICancelHandler, IPointerClickHandler
{
	// Token: 0x1400001B RID: 27
	// (add) Token: 0x06000D9F RID: 3487 RVA: 0x00043ACC File Offset: 0x00041CCC
	// (remove) Token: 0x06000DA0 RID: 3488 RVA: 0x00043B04 File Offset: 0x00041D04
	public event BossDoorChallengeUIBindingButton.OnSelectionEvent OnButtonSelected;

	// Token: 0x1400001C RID: 28
	// (add) Token: 0x06000DA1 RID: 3489 RVA: 0x00043B3C File Offset: 0x00041D3C
	// (remove) Token: 0x06000DA2 RID: 3490 RVA: 0x00043B74 File Offset: 0x00041D74
	public event BossDoorChallengeUIBindingButton.OnCancelEvent OnButtonCancelled;

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00043BA9 File Offset: 0x00041DA9
	public bool Selected
	{
		get
		{
			return this.selected;
		}
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x00043BB1 File Offset: 0x00041DB1
	private void Awake()
	{
		if (this.iconImage)
		{
			this.defaultSprite = this.iconImage.sprite;
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x00043BD4 File Offset: 0x00041DD4
	public void Reset()
	{
		this.selected = false;
		if (this.chainAnimator)
		{
			this.chainAnimator.Play("Unbind", 0, 1f);
		}
		if (this.iconImage)
		{
			this.iconImage.sprite = this.defaultSprite;
			this.iconImage.SetNativeSize();
		}
		base.StartCoroutine(this.SetAnimSizeDelayed("Unbind", 1f));
		if (this.bindAllEffect)
		{
			this.bindAllEffect.SetActive(false);
		}
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00043C64 File Offset: 0x00041E64
	private void OnDisable()
	{
		if (this.isCounted)
		{
			BossDoorChallengeUIBindingButton.currentAmount--;
			this.isCounted = false;
		}
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00043C84 File Offset: 0x00041E84
	public void OnSubmit(BaseEventData eventData)
	{
		this.selected = !this.selected;
		if (this.iconImage)
		{
			this.iconImage.sprite = (this.selected ? this.selectedSprite : this.defaultSprite);
			this.iconImage.SetNativeSize();
		}
		if (this.iconAnimator)
		{
			this.iconAnimator.Play("Select");
		}
		if (this.chainAnimator)
		{
			this.chainAnimator.Play(this.selected ? "Bind" : "Unbind");
		}
		if (this.selected && !this.isCounted)
		{
			this.isCounted = true;
			BossDoorChallengeUIBindingButton.currentAmount++;
		}
		else if (!this.selected && this.isCounted)
		{
			BossDoorChallengeUIBindingButton.currentAmount--;
			this.isCounted = false;
		}
		AudioEvent audioEvent = this.selected ? this.selectedSound : this.deselectedSound;
		float num = Mathf.Lerp(this.pitchShiftMin, this.pitchShiftMax, (float)BossDoorChallengeUIBindingButton.currentAmount / (float)this.maxAmount);
		audioEvent.PitchMin += num;
		audioEvent.PitchMax += num;
		audioEvent.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
		GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
		if (this.OnButtonSelected != null)
		{
			this.OnButtonSelected();
		}
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00043DF8 File Offset: 0x00041FF8
	public void SetAllSelected(bool value)
	{
		if (this.iconImage)
		{
			if (value)
			{
				this.iconImage.sprite = (this.allSelectedSprite ? this.allSelectedSprite : this.selectedSprite);
			}
			else
			{
				this.iconImage.sprite = (this.selected ? this.selectedSprite : this.defaultSprite);
			}
			this.iconImage.SetNativeSize();
		}
		if (this.iconAnimator)
		{
			this.iconAnimator.Play("Select");
		}
		base.StartCoroutine(this.SetAnimSizeDelayed(value ? "Bind All" : (this.selected ? "Bind" : "Unbind"), (float)((!value && this.selected) ? 1 : 0)));
		if (this.bindAllEffect)
		{
			this.bindAllEffect.SetActive(value);
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00043EDA File Offset: 0x000420DA
	private IEnumerator SetAnimSizeDelayed(string anim, float normalizedTime)
	{
		if (this.chainAnimator)
		{
			this.chainAnimator.Play(anim, 0, normalizedTime);
		}
		float scale = this.chainAnimator.transform.localScale.x;
		this.chainAnimator.transform.SetScaleX(0f);
		yield return null;
		Image component = this.chainAnimator.GetComponent<Image>();
		if (component)
		{
			component.SetNativeSize();
		}
		this.chainAnimator.transform.SetScaleX(scale);
		yield break;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00043EF7 File Offset: 0x000420F7
	public void OnCancel(BaseEventData eventData)
	{
		if (this.OnButtonCancelled != null)
		{
			this.OnButtonCancelled();
		}
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00043F0C File Offset: 0x0004210C
	public void OnPointerClick(PointerEventData eventData)
	{
		this.OnSubmit(eventData);
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00043F15 File Offset: 0x00042115
	public BossDoorChallengeUIBindingButton()
	{
		this.pitchShiftMax = 0.5f;
		this.maxAmount = 4;
		base..ctor();
	}

	// Token: 0x04000E87 RID: 3719
	public Image iconImage;

	// Token: 0x04000E88 RID: 3720
	public Animator iconAnimator;

	// Token: 0x04000E89 RID: 3721
	private Sprite defaultSprite;

	// Token: 0x04000E8A RID: 3722
	public Sprite selectedSprite;

	// Token: 0x04000E8B RID: 3723
	public Sprite allSelectedSprite;

	// Token: 0x04000E8C RID: 3724
	public Animator chainAnimator;

	// Token: 0x04000E8D RID: 3725
	public GameObject bindAllEffect;

	// Token: 0x04000E8E RID: 3726
	public AudioSource audioSourcePrefab;

	// Token: 0x04000E8F RID: 3727
	public AudioEvent selectedSound;

	// Token: 0x04000E90 RID: 3728
	public AudioEvent deselectedSound;

	// Token: 0x04000E91 RID: 3729
	public float pitchShiftMin;

	// Token: 0x04000E92 RID: 3730
	public float pitchShiftMax;

	// Token: 0x04000E93 RID: 3731
	public int maxAmount;

	// Token: 0x04000E94 RID: 3732
	private static int currentAmount;

	// Token: 0x04000E95 RID: 3733
	private bool isCounted;

	// Token: 0x04000E96 RID: 3734
	private bool selected;

	// Token: 0x0200028C RID: 652
	// (Invoke) Token: 0x06000DAF RID: 3503
	public delegate void OnSelectionEvent();

	// Token: 0x0200028D RID: 653
	// (Invoke) Token: 0x06000DB3 RID: 3507
	public delegate void OnCancelEvent();
}
