using System;
using GlobalEnums;
using InControl;
using UnityEngine;

// Token: 0x0200042D RID: 1069
[RequireComponent(typeof(SpriteRenderer))]
public class ActionButtonIcon : ActionButtonIconBase
{
	// Token: 0x17000315 RID: 789
	// (get) Token: 0x06001813 RID: 6163 RVA: 0x0007145F File Offset: 0x0006F65F
	public override HeroActionButton Action
	{
		get
		{
			return this.action;
		}
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00071467 File Offset: 0x0006F667
	protected override void OnEnable()
	{
		base.OnIconUpdate += this.CheckHideIcon;
		base.OnEnable();
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x00071481 File Offset: 0x0006F681
	protected override void OnDisable()
	{
		base.OnIconUpdate -= this.CheckHideIcon;
		base.OnDisable();
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x0007149C File Offset: 0x0006F69C
	private void CheckHideIcon()
	{
		if (this.showForControllerOnly && this.sr)
		{
			if (this.initialScale == null)
			{
				this.initialScale = new Vector3?(base.transform.localScale);
			}
			InputHandler instance = InputHandler.Instance;
			if (instance.lastActiveController == BindingSourceType.KeyBindingSource || instance.lastActiveController == BindingSourceType.None)
			{
				base.transform.localScale = Vector3.zero;
				return;
			}
			if (instance.lastActiveController == BindingSourceType.DeviceBindingSource)
			{
				base.transform.localScale = this.initialScale.Value;
			}
		}
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x0007152B File Offset: 0x0006F72B
	public void SetAction(HeroActionButton action)
	{
		this.action = action;
		base.GetButtonIcon(action);
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x0007153C File Offset: 0x0006F73C
	public void SetActionString(string action)
	{
		object obj = Enum.Parse(typeof(HeroActionButton), action);
		if (obj != null)
		{
			this.action = (HeroActionButton)obj;
			base.GetButtonIcon((HeroActionButton)obj);
			return;
		}
		Debug.LogError("SetAction couldn't convert " + action);
	}

	// Token: 0x04001CE2 RID: 7394
	public HeroActionButton action;

	// Token: 0x04001CE3 RID: 7395
	public bool showForControllerOnly;

	// Token: 0x04001CE4 RID: 7396
	private Vector3? initialScale;
}
