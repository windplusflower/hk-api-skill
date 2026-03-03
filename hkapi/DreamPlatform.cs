using System;
using UnityEngine;

// Token: 0x020003B1 RID: 945
public class DreamPlatform : MonoBehaviour
{
	// Token: 0x060015B3 RID: 5555 RVA: 0x0006773E File Offset: 0x0006593E
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0006774C File Offset: 0x0006594C
	private void Start()
	{
		if (this.showOnEnable)
		{
			return;
		}
		if (this.outerCollider)
		{
			this.outerCollider.OnTriggerExited += delegate(Collider2D collider, GameObject sender)
			{
				this.Hide();
			};
		}
		if (this.innerCollider)
		{
			this.innerCollider.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
			{
				this.Show();
			};
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x000677AA File Offset: 0x000659AA
	private void OnEnable()
	{
		if (this.showOnEnable)
		{
			this.Show();
		}
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x000677BA File Offset: 0x000659BA
	public void Show()
	{
		if (!this.visible)
		{
			this.PlayAnimation("Show");
			this.activateSound.PlayOnSource(this.audioSource, 0.85f, 1.15f);
			this.visible = true;
		}
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x000677F1 File Offset: 0x000659F1
	public void Hide()
	{
		if (this.visible)
		{
			this.PlayAnimation("Hide");
			this.deactivateSound.PlayOnSource(this.audioSource, 0.85f, 1.15f);
			this.visible = false;
		}
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00067828 File Offset: 0x00065A28
	private void PlayAnimation(string animationName)
	{
		if (this.animator)
		{
			this.animator.Play(animationName);
		}
	}

	// Token: 0x04001A10 RID: 6672
	public TriggerEnterEvent outerCollider;

	// Token: 0x04001A11 RID: 6673
	public TriggerEnterEvent innerCollider;

	// Token: 0x04001A12 RID: 6674
	public Animator animator;

	// Token: 0x04001A13 RID: 6675
	public AudioClip activateSound;

	// Token: 0x04001A14 RID: 6676
	public AudioClip deactivateSound;

	// Token: 0x04001A15 RID: 6677
	private bool visible;

	// Token: 0x04001A16 RID: 6678
	public bool showOnEnable;

	// Token: 0x04001A17 RID: 6679
	private AudioSource audioSource;
}
