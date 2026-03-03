using System;
using UnityEngine;

// Token: 0x020005B4 RID: 1460
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIItem")]
public class tk2dUIItem : MonoBehaviour
{
	// Token: 0x14000051 RID: 81
	// (add) Token: 0x060020FB RID: 8443 RVA: 0x000A58A0 File Offset: 0x000A3AA0
	// (remove) Token: 0x060020FC RID: 8444 RVA: 0x000A58D8 File Offset: 0x000A3AD8
	public event Action OnDown;

	// Token: 0x14000052 RID: 82
	// (add) Token: 0x060020FD RID: 8445 RVA: 0x000A5910 File Offset: 0x000A3B10
	// (remove) Token: 0x060020FE RID: 8446 RVA: 0x000A5948 File Offset: 0x000A3B48
	public event Action OnUp;

	// Token: 0x14000053 RID: 83
	// (add) Token: 0x060020FF RID: 8447 RVA: 0x000A5980 File Offset: 0x000A3B80
	// (remove) Token: 0x06002100 RID: 8448 RVA: 0x000A59B8 File Offset: 0x000A3BB8
	public event Action OnClick;

	// Token: 0x14000054 RID: 84
	// (add) Token: 0x06002101 RID: 8449 RVA: 0x000A59F0 File Offset: 0x000A3BF0
	// (remove) Token: 0x06002102 RID: 8450 RVA: 0x000A5A28 File Offset: 0x000A3C28
	public event Action OnRelease;

	// Token: 0x14000055 RID: 85
	// (add) Token: 0x06002103 RID: 8451 RVA: 0x000A5A60 File Offset: 0x000A3C60
	// (remove) Token: 0x06002104 RID: 8452 RVA: 0x000A5A98 File Offset: 0x000A3C98
	public event Action OnHoverOver;

	// Token: 0x14000056 RID: 86
	// (add) Token: 0x06002105 RID: 8453 RVA: 0x000A5AD0 File Offset: 0x000A3CD0
	// (remove) Token: 0x06002106 RID: 8454 RVA: 0x000A5B08 File Offset: 0x000A3D08
	public event Action OnHoverOut;

	// Token: 0x14000057 RID: 87
	// (add) Token: 0x06002107 RID: 8455 RVA: 0x000A5B40 File Offset: 0x000A3D40
	// (remove) Token: 0x06002108 RID: 8456 RVA: 0x000A5B78 File Offset: 0x000A3D78
	public event Action<tk2dUIItem> OnDownUIItem;

	// Token: 0x14000058 RID: 88
	// (add) Token: 0x06002109 RID: 8457 RVA: 0x000A5BB0 File Offset: 0x000A3DB0
	// (remove) Token: 0x0600210A RID: 8458 RVA: 0x000A5BE8 File Offset: 0x000A3DE8
	public event Action<tk2dUIItem> OnUpUIItem;

	// Token: 0x14000059 RID: 89
	// (add) Token: 0x0600210B RID: 8459 RVA: 0x000A5C20 File Offset: 0x000A3E20
	// (remove) Token: 0x0600210C RID: 8460 RVA: 0x000A5C58 File Offset: 0x000A3E58
	public event Action<tk2dUIItem> OnClickUIItem;

	// Token: 0x1400005A RID: 90
	// (add) Token: 0x0600210D RID: 8461 RVA: 0x000A5C90 File Offset: 0x000A3E90
	// (remove) Token: 0x0600210E RID: 8462 RVA: 0x000A5CC8 File Offset: 0x000A3EC8
	public event Action<tk2dUIItem> OnReleaseUIItem;

	// Token: 0x1400005B RID: 91
	// (add) Token: 0x0600210F RID: 8463 RVA: 0x000A5D00 File Offset: 0x000A3F00
	// (remove) Token: 0x06002110 RID: 8464 RVA: 0x000A5D38 File Offset: 0x000A3F38
	public event Action<tk2dUIItem> OnHoverOverUIItem;

	// Token: 0x1400005C RID: 92
	// (add) Token: 0x06002111 RID: 8465 RVA: 0x000A5D70 File Offset: 0x000A3F70
	// (remove) Token: 0x06002112 RID: 8466 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
	public event Action<tk2dUIItem> OnHoverOutUIItem;

	// Token: 0x06002113 RID: 8467 RVA: 0x000A5DDD File Offset: 0x000A3FDD
	private void Awake()
	{
		if (this.isChildOfAnotherUIItem)
		{
			this.UpdateParent();
		}
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000A5DED File Offset: 0x000A3FED
	private void Start()
	{
		if (tk2dUIManager.Instance == null)
		{
			Debug.LogError("Unable to find tk2dUIManager. Please create a tk2dUIManager in the scene before proceeding.");
		}
		if (this.isChildOfAnotherUIItem && this.parentUIItem == null)
		{
			this.UpdateParent();
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06002115 RID: 8469 RVA: 0x000A5E22 File Offset: 0x000A4022
	public bool IsPressed
	{
		get
		{
			return this.isPressed;
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06002116 RID: 8470 RVA: 0x000A5E2A File Offset: 0x000A402A
	public tk2dUITouch Touch
	{
		get
		{
			return this.touch;
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A5E32 File Offset: 0x000A4032
	public tk2dUIItem ParentUIItem
	{
		get
		{
			return this.parentUIItem;
		}
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000A5E3A File Offset: 0x000A403A
	public void UpdateParent()
	{
		this.parentUIItem = this.GetParentUIItem();
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000A5E48 File Offset: 0x000A4048
	public void ManuallySetParent(tk2dUIItem newParentUIItem)
	{
		this.parentUIItem = newParentUIItem;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000A5E51 File Offset: 0x000A4051
	public void RemoveParent()
	{
		this.parentUIItem = null;
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000A5E5A File Offset: 0x000A405A
	public bool Press(tk2dUITouch touch)
	{
		return this.Press(touch, null);
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000A5E64 File Offset: 0x000A4064
	public bool Press(tk2dUITouch touch, tk2dUIItem sentFromChild)
	{
		if (this.isPressed)
		{
			return false;
		}
		if (!this.isPressed)
		{
			this.touch = touch;
			if ((this.registerPressFromChildren || sentFromChild == null) && base.enabled)
			{
				this.isPressed = true;
				if (this.OnDown != null)
				{
					this.OnDown();
				}
				if (this.OnDownUIItem != null)
				{
					this.OnDownUIItem(this);
				}
				this.DoSendMessage(this.SendMessageOnDownMethodName);
			}
			if (this.parentUIItem != null)
			{
				this.parentUIItem.Press(touch, this);
			}
		}
		return true;
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000A5EFD File Offset: 0x000A40FD
	public void UpdateTouch(tk2dUITouch touch)
	{
		this.touch = touch;
		if (this.parentUIItem != null)
		{
			this.parentUIItem.UpdateTouch(touch);
		}
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000A5F20 File Offset: 0x000A4120
	private void DoSendMessage(string methodName)
	{
		if (this.sendMessageTarget != null && methodName.Length > 0)
		{
			this.sendMessageTarget.SendMessage(methodName, this, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000A5F48 File Offset: 0x000A4148
	public void Release()
	{
		if (this.isPressed)
		{
			this.isPressed = false;
			if (this.OnUp != null)
			{
				this.OnUp();
			}
			if (this.OnUpUIItem != null)
			{
				this.OnUpUIItem(this);
			}
			this.DoSendMessage(this.SendMessageOnUpMethodName);
			if (this.OnClick != null)
			{
				this.OnClick();
			}
			if (this.OnClickUIItem != null)
			{
				this.OnClickUIItem(this);
			}
			this.DoSendMessage(this.SendMessageOnClickMethodName);
		}
		if (this.OnRelease != null)
		{
			this.OnRelease();
		}
		if (this.OnReleaseUIItem != null)
		{
			this.OnReleaseUIItem(this);
		}
		this.DoSendMessage(this.SendMessageOnReleaseMethodName);
		if (this.parentUIItem != null)
		{
			this.parentUIItem.Release();
		}
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x000A6018 File Offset: 0x000A4218
	public void CurrentOverUIItem(tk2dUIItem overUIItem)
	{
		if (overUIItem != this)
		{
			if (this.isPressed)
			{
				if (!this.CheckIsUIItemChildOfMe(overUIItem))
				{
					this.Exit();
					if (this.parentUIItem != null)
					{
						this.parentUIItem.CurrentOverUIItem(overUIItem);
						return;
					}
				}
			}
			else if (this.parentUIItem != null)
			{
				this.parentUIItem.CurrentOverUIItem(overUIItem);
			}
		}
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000A607C File Offset: 0x000A427C
	public bool CheckIsUIItemChildOfMe(tk2dUIItem uiItem)
	{
		tk2dUIItem tk2dUIItem = null;
		bool result = false;
		if (uiItem != null)
		{
			tk2dUIItem = uiItem.parentUIItem;
		}
		while (tk2dUIItem != null)
		{
			if (tk2dUIItem == this)
			{
				result = true;
				break;
			}
			tk2dUIItem = tk2dUIItem.parentUIItem;
		}
		return result;
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000A60C0 File Offset: 0x000A42C0
	public void Exit()
	{
		if (this.isPressed)
		{
			this.isPressed = false;
			if (this.OnUp != null)
			{
				this.OnUp();
			}
			if (this.OnUpUIItem != null)
			{
				this.OnUpUIItem(this);
			}
			this.DoSendMessage(this.SendMessageOnUpMethodName);
		}
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000A6110 File Offset: 0x000A4310
	public bool HoverOver(tk2dUIItem prevHover)
	{
		bool flag = false;
		tk2dUIItem tk2dUIItem = null;
		if (!this.isHoverOver)
		{
			if (this.OnHoverOver != null)
			{
				this.OnHoverOver();
			}
			if (this.OnHoverOverUIItem != null)
			{
				this.OnHoverOverUIItem(this);
			}
			this.isHoverOver = true;
		}
		if (prevHover == this)
		{
			flag = true;
		}
		if (this.parentUIItem != null && this.parentUIItem.isHoverEnabled)
		{
			tk2dUIItem = this.parentUIItem;
		}
		if (tk2dUIItem == null)
		{
			return flag;
		}
		return tk2dUIItem.HoverOver(prevHover) || flag;
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000A6198 File Offset: 0x000A4398
	public void HoverOut(tk2dUIItem currHoverButton)
	{
		if (this.isHoverOver)
		{
			if (this.OnHoverOut != null)
			{
				this.OnHoverOut();
			}
			if (this.OnHoverOutUIItem != null)
			{
				this.OnHoverOutUIItem(this);
			}
			this.isHoverOver = false;
		}
		if (this.parentUIItem != null && this.parentUIItem.isHoverEnabled)
		{
			if (currHoverButton == null)
			{
				this.parentUIItem.HoverOut(currHoverButton);
				return;
			}
			if (!this.parentUIItem.CheckIsUIItemChildOfMe(currHoverButton) && currHoverButton != this.parentUIItem)
			{
				this.parentUIItem.HoverOut(currHoverButton);
			}
		}
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000A6234 File Offset: 0x000A4434
	private tk2dUIItem GetParentUIItem()
	{
		Transform parent = base.transform.parent;
		while (parent != null)
		{
			tk2dUIItem component = parent.GetComponent<tk2dUIItem>();
			if (component != null)
			{
				return component;
			}
			parent = parent.parent;
		}
		return null;
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000A6274 File Offset: 0x000A4474
	public void SimulateClick()
	{
		if (this.OnDown != null)
		{
			this.OnDown();
		}
		if (this.OnDownUIItem != null)
		{
			this.OnDownUIItem(this);
		}
		this.DoSendMessage(this.SendMessageOnDownMethodName);
		if (this.OnUp != null)
		{
			this.OnUp();
		}
		if (this.OnUpUIItem != null)
		{
			this.OnUpUIItem(this);
		}
		this.DoSendMessage(this.SendMessageOnUpMethodName);
		if (this.OnClick != null)
		{
			this.OnClick();
		}
		if (this.OnClickUIItem != null)
		{
			this.OnClickUIItem(this);
		}
		this.DoSendMessage(this.SendMessageOnClickMethodName);
		if (this.OnRelease != null)
		{
			this.OnRelease();
		}
		if (this.OnReleaseUIItem != null)
		{
			this.OnReleaseUIItem(this);
		}
		this.DoSendMessage(this.SendMessageOnReleaseMethodName);
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000A634D File Offset: 0x000A454D
	public void InternalSetIsChildOfAnotherUIItem(bool state)
	{
		this.isChildOfAnotherUIItem = state;
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000A6356 File Offset: 0x000A4556
	public bool InternalGetIsChildOfAnotherUIItem()
	{
		return this.isChildOfAnotherUIItem;
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000A6360 File Offset: 0x000A4560
	public tk2dUIItem()
	{
		this.SendMessageOnDownMethodName = "";
		this.SendMessageOnUpMethodName = "";
		this.SendMessageOnClickMethodName = "";
		this.SendMessageOnReleaseMethodName = "";
		this.editorExtraBounds = new Transform[0];
		this.editorIgnoreBounds = new Transform[0];
		base..ctor();
	}

	// Token: 0x0400268A RID: 9866
	public GameObject sendMessageTarget;

	// Token: 0x0400268B RID: 9867
	public string SendMessageOnDownMethodName;

	// Token: 0x0400268C RID: 9868
	public string SendMessageOnUpMethodName;

	// Token: 0x0400268D RID: 9869
	public string SendMessageOnClickMethodName;

	// Token: 0x0400268E RID: 9870
	public string SendMessageOnReleaseMethodName;

	// Token: 0x0400268F RID: 9871
	[SerializeField]
	private bool isChildOfAnotherUIItem;

	// Token: 0x04002690 RID: 9872
	public bool registerPressFromChildren;

	// Token: 0x04002691 RID: 9873
	public bool isHoverEnabled;

	// Token: 0x04002692 RID: 9874
	public Transform[] editorExtraBounds;

	// Token: 0x04002693 RID: 9875
	public Transform[] editorIgnoreBounds;

	// Token: 0x04002694 RID: 9876
	private bool isPressed;

	// Token: 0x04002695 RID: 9877
	private bool isHoverOver;

	// Token: 0x04002696 RID: 9878
	private tk2dUITouch touch;

	// Token: 0x04002697 RID: 9879
	private tk2dUIItem parentUIItem;
}
