using System;
using UnityEngine;

// Token: 0x0200009A RID: 154
[RequireComponent(typeof(Animator))]
public class StopAnimatorsAtPoint : MonoBehaviour
{
	// Token: 0x06000350 RID: 848 RVA: 0x00011C3D File Offset: 0x0000FE3D
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00011C4C File Offset: 0x0000FE4C
	private void Start()
	{
		if (this.stopEvent)
		{
			this.stopEvent.OnReceivedEvent += delegate()
			{
				this.shouldStop = true;
				this.animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
			};
		}
		if (this.stopInstantEvent)
		{
			this.stopInstantEvent.OnReceivedEvent += delegate()
			{
				this.animator.enabled = false;
				Vector3 localPosition = base.transform.localPosition;
				localPosition.y = this.stopInstantHeight;
				base.transform.localPosition = localPosition;
			};
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00011CA1 File Offset: 0x0000FEA1
	public void SetCanStop()
	{
		this.canStop = true;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00011CAA File Offset: 0x0000FEAA
	public void SetCannotStop()
	{
		this.canStop = false;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00011CB3 File Offset: 0x0000FEB3
	private void Update()
	{
		if (this.shouldStop && this.canStop && this.animator.enabled)
		{
			this.animator.enabled = false;
			this.canStop = false;
			this.shouldStop = false;
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00011CEC File Offset: 0x0000FEEC
	public StopAnimatorsAtPoint()
	{
		this.stopInstantHeight = 1.75f;
		base..ctor();
	}

	// Token: 0x040002AE RID: 686
	public EventRegister stopEvent;

	// Token: 0x040002AF RID: 687
	public EventRegister stopInstantEvent;

	// Token: 0x040002B0 RID: 688
	private bool canStop;

	// Token: 0x040002B1 RID: 689
	private bool shouldStop;

	// Token: 0x040002B2 RID: 690
	public float stopInstantHeight;

	// Token: 0x040002B3 RID: 691
	private Animator animator;
}
