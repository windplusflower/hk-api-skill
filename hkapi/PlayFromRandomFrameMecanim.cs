using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000083 RID: 131
[RequireComponent(typeof(Animator))]
public class PlayFromRandomFrameMecanim : MonoBehaviour
{
	// Token: 0x060002CE RID: 718 RVA: 0x0000F7C2 File Offset: 0x0000D9C2
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
	private void Start()
	{
		if (!this.onEnable)
		{
			this.DoPlay();
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
	private void OnEnable()
	{
		if (this.onEnable)
		{
			this.DoPlay();
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
	private void DoPlay()
	{
		if (!string.IsNullOrEmpty(this.stateToPlay))
		{
			base.StartCoroutine(this.DelayStart());
			return;
		}
		Debug.LogError("PlayFromRandomFrameMecanim: No state name specified to play." + base.gameObject.name);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000F827 File Offset: 0x0000DA27
	private IEnumerator DelayStart()
	{
		yield return null;
		this.animator.Play(this.stateToPlay, 0, UnityEngine.Random.Range(0f, 1f));
		yield break;
	}

	// Token: 0x04000252 RID: 594
	private Animator animator;

	// Token: 0x04000253 RID: 595
	[Tooltip("The name of the Animator state to play randomly.")]
	public string stateToPlay;

	// Token: 0x04000254 RID: 596
	public bool onEnable;
}
