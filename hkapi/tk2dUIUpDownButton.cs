using System;
using UnityEngine;

// Token: 0x020005AF RID: 1455
[AddComponentMenu("2D Toolkit/UI/tk2dUIUpDownButton")]
public class tk2dUIUpDownButton : tk2dUIBaseItemControl
{
	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000A51B6 File Offset: 0x000A33B6
	public bool UseOnReleaseInsteadOfOnUp
	{
		get
		{
			return this.useOnReleaseInsteadOfOnUp;
		}
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000A51BE File Offset: 0x000A33BE
	private void Start()
	{
		this.SetState();
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x000A51C8 File Offset: 0x000A33C8
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown += this.ButtonDown;
			if (this.useOnReleaseInsteadOfOnUp)
			{
				this.uiItem.OnRelease += this.ButtonUp;
				return;
			}
			this.uiItem.OnUp += this.ButtonUp;
		}
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x000A5230 File Offset: 0x000A3430
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown -= this.ButtonDown;
			if (this.useOnReleaseInsteadOfOnUp)
			{
				this.uiItem.OnRelease -= this.ButtonUp;
				return;
			}
			this.uiItem.OnUp -= this.ButtonUp;
		}
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000A5298 File Offset: 0x000A3498
	private void ButtonUp()
	{
		this.isDown = false;
		this.SetState();
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000A52A7 File Offset: 0x000A34A7
	private void ButtonDown()
	{
		this.isDown = true;
		this.SetState();
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000A52B6 File Offset: 0x000A34B6
	private void SetState()
	{
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.upStateGO, !this.isDown);
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.downStateGO, this.isDown);
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000A52DD File Offset: 0x000A34DD
	public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
	{
		this.useOnReleaseInsteadOfOnUp = state;
	}

	// Token: 0x0400266B RID: 9835
	public GameObject upStateGO;

	// Token: 0x0400266C RID: 9836
	public GameObject downStateGO;

	// Token: 0x0400266D RID: 9837
	[SerializeField]
	private bool useOnReleaseInsteadOfOnUp;

	// Token: 0x0400266E RID: 9838
	private bool isDown;
}
