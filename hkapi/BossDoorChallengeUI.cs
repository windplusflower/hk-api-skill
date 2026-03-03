using System;
using System.Collections;
using Language;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000283 RID: 643
public class BossDoorChallengeUI : MonoBehaviour
{
	// Token: 0x14000019 RID: 25
	// (add) Token: 0x06000D74 RID: 3444 RVA: 0x000432A0 File Offset: 0x000414A0
	// (remove) Token: 0x06000D75 RID: 3445 RVA: 0x000432D8 File Offset: 0x000414D8
	public event BossDoorChallengeUI.HideEvent OnHidden;

	// Token: 0x1400001A RID: 26
	// (add) Token: 0x06000D76 RID: 3446 RVA: 0x00043310 File Offset: 0x00041510
	// (remove) Token: 0x06000D77 RID: 3447 RVA: 0x00043348 File Offset: 0x00041548
	public event BossDoorChallengeUI.BeginEvent OnBegin;

	// Token: 0x06000D78 RID: 3448 RVA: 0x0004337D File Offset: 0x0004157D
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
		this.canvas = base.GetComponent<Canvas>();
		this.group = base.GetComponent<CanvasGroup>();
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x000433A4 File Offset: 0x000415A4
	private void Start()
	{
		this.canvas.worldCamera = GameCameras.instance.hudCamera;
		this.buttons = new BossDoorChallengeUIBindingButton[4];
		this.buttons[0] = this.boundNailButton;
		this.buttons[1] = this.boundHeartButton;
		this.buttons[2] = this.boundCharmsButton;
		this.buttons[3] = this.boundSoulButton;
		foreach (BossDoorChallengeUIBindingButton bossDoorChallengeUIBindingButton in this.buttons)
		{
			bossDoorChallengeUIBindingButton.OnButtonSelected += this.UpdateAllButtons;
			bossDoorChallengeUIBindingButton.OnButtonCancelled += this.Hide;
			bossDoorChallengeUIBindingButton.Reset();
		}
		this.group.alpha = 0f;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0004345C File Offset: 0x0004165C
	private void OnEnable()
	{
		if (this.buttons != null)
		{
			BossDoorChallengeUIBindingButton[] array = this.buttons;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
			this.allPreviouslySelected = false;
		}
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00043498 File Offset: 0x00041698
	public void Setup(BossSequenceDoor door)
	{
		this.door = door;
		if (this.titleTextSuper)
		{
			this.titleTextSuper.text = Language.Get(door.titleSuperKey, door.titleSuperSheet);
		}
		if (this.titleTextMain)
		{
			this.titleTextMain.text = Language.Get(door.titleMainKey, door.titleMainSheet);
		}
		if (this.descriptionText)
		{
			this.descriptionText.text = Language.Get(door.descriptionKey, door.descriptionSheet);
		}
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00043528 File Offset: 0x00041728
	private void UpdateAllButtons()
	{
		bool flag = true;
		BossDoorChallengeUIBindingButton[] array = this.buttons;
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].Selected)
			{
				flag = false;
				break;
			}
		}
		if (flag || this.allPreviouslySelected)
		{
			array = this.buttons;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetAllSelected(flag);
			}
		}
		if (flag)
		{
			GameCameras.instance.cameraShakeFSM.SendEvent("AverageShake");
			this.allSelectedSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
			if (this.allSelectedEffect)
			{
				this.allSelectedEffect.SetActive(false);
				this.allSelectedEffect.SetActive(true);
				this.allSelectedEffect.SetActiveChildren(true);
			}
		}
		this.allPreviouslySelected = flag;
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x000435EE File Offset: 0x000417EE
	public void Show()
	{
		base.gameObject.SetActive(true);
		base.StartCoroutine(this.ShowSequence());
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "OUT", false);
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x0004361E File Offset: 0x0004181E
	private IEnumerator ShowSequence()
	{
		this.group.interactable = false;
		EventSystem.current.SetSelectedGameObject(null);
		yield return null;
		if (this.animator)
		{
			this.animator.Play("Open");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		this.group.interactable = true;
		if (this.buttons.Length != 0)
		{
			EventSystem.current.SetSelectedGameObject(this.buttons[0].gameObject);
		}
		InputHandler.Instance.StartUIInput();
		yield break;
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x0004362D File Offset: 0x0004182D
	public void Hide()
	{
		base.StartCoroutine(this.HideSequence(true));
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x0004363D File Offset: 0x0004183D
	private IEnumerator HideSequence(bool sendEvent)
	{
		GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
		if (currentSelectedGameObject)
		{
			MenuButton component = currentSelectedGameObject.GetComponent<MenuButton>();
			if (component)
			{
				component.ForceDeselect();
			}
		}
		if (this.animator)
		{
			this.animator.Play("Close");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		if (sendEvent && this.OnHidden != null)
		{
			this.OnHidden();
		}
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "IN", false);
		if (this.allSelectedEffect)
		{
			this.allSelectedEffect.SetActive(false);
		}
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00043654 File Offset: 0x00041854
	public void Begin()
	{
		base.StartCoroutine(this.HideSequence(false));
		GameManager.instance.playerData.SetStringSwappedArgs(this.door.dreamReturnGate.name, "bossReturnEntryGate");
		BossSequenceController.ChallengeBindings challengeBindings = BossSequenceController.ChallengeBindings.None;
		if (this.boundNailButton.Selected)
		{
			challengeBindings |= BossSequenceController.ChallengeBindings.Nail;
		}
		if (this.boundHeartButton.Selected)
		{
			challengeBindings |= BossSequenceController.ChallengeBindings.Shell;
		}
		if (this.boundCharmsButton.Selected)
		{
			challengeBindings |= BossSequenceController.ChallengeBindings.Charms;
		}
		if (this.boundSoulButton.Selected)
		{
			challengeBindings |= BossSequenceController.ChallengeBindings.Soul;
		}
		BossSequenceController.SetupNewSequence(this.door.bossSequence, challengeBindings, this.door.playerDataString);
		if (this.OnBegin != null)
		{
			this.OnBegin();
		}
	}

	// Token: 0x04000E65 RID: 3685
	public Text titleTextSuper;

	// Token: 0x04000E66 RID: 3686
	public Text titleTextMain;

	// Token: 0x04000E67 RID: 3687
	public Text descriptionText;

	// Token: 0x04000E68 RID: 3688
	public BossDoorChallengeUIBindingButton boundNailButton;

	// Token: 0x04000E69 RID: 3689
	public BossDoorChallengeUIBindingButton boundHeartButton;

	// Token: 0x04000E6A RID: 3690
	public BossDoorChallengeUIBindingButton boundCharmsButton;

	// Token: 0x04000E6B RID: 3691
	public BossDoorChallengeUIBindingButton boundSoulButton;

	// Token: 0x04000E6C RID: 3692
	private BossDoorChallengeUIBindingButton[] buttons;

	// Token: 0x04000E6D RID: 3693
	private bool allPreviouslySelected;

	// Token: 0x04000E6E RID: 3694
	public AudioSource audioPlayerPrefab;

	// Token: 0x04000E6F RID: 3695
	public AudioEvent allSelectedSound;

	// Token: 0x04000E70 RID: 3696
	public GameObject allSelectedEffect;

	// Token: 0x04000E71 RID: 3697
	private BossSequenceDoor door;

	// Token: 0x04000E72 RID: 3698
	private Animator animator;

	// Token: 0x04000E73 RID: 3699
	private Canvas canvas;

	// Token: 0x04000E74 RID: 3700
	private CanvasGroup group;

	// Token: 0x02000284 RID: 644
	// (Invoke) Token: 0x06000D84 RID: 3460
	public delegate void HideEvent();

	// Token: 0x02000285 RID: 645
	// (Invoke) Token: 0x06000D88 RID: 3464
	public delegate void BeginEvent();
}
