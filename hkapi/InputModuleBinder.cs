using System;
using InControl;
using UnityEngine;

// Token: 0x020002AC RID: 684
[RequireComponent(typeof(InControlInputModule))]
public class InputModuleBinder : MonoBehaviour
{
	// Token: 0x06000E7A RID: 3706 RVA: 0x00047C80 File Offset: 0x00045E80
	private void OnEnable()
	{
		this.actions = new InputModuleBinder.MyActionSet();
		InControlInputModule component = base.GetComponent<InControlInputModule>();
		component.SubmitAction = this.actions.Submit;
		component.CancelAction = this.actions.Cancel;
		component.MoveAction = this.actions.Move;
		this.BindAndApplyActions();
		Platform.AcceptRejectInputStyleChanged += this.OnAcceptRejectInputStyleChanged;
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00047CE7 File Offset: 0x00045EE7
	private void OnDisable()
	{
		Platform.AcceptRejectInputStyleChanged -= this.OnAcceptRejectInputStyleChanged;
		this.actions.Destroy();
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00047D05 File Offset: 0x00045F05
	private void OnAcceptRejectInputStyleChanged()
	{
		this.BindAndApplyActions();
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00047D10 File Offset: 0x00045F10
	private void BindAndApplyActions()
	{
		this.actions.Submit.ClearBindings();
		this.actions.Cancel.ClearBindings();
		Platform.AcceptRejectInputStyles acceptRejectInputStyle = Platform.Current.AcceptRejectInputStyle;
		if (acceptRejectInputStyle == Platform.AcceptRejectInputStyles.NonJapaneseStyle || acceptRejectInputStyle != Platform.AcceptRejectInputStyles.JapaneseStyle)
		{
			this.actions.Submit.AddDefaultBinding(InputControlType.Action1);
			this.actions.Submit.AddDefaultBinding(new Key[]
			{
				Key.Space
			});
			this.actions.Submit.AddDefaultBinding(new Key[]
			{
				Key.Return
			});
			this.actions.Cancel.AddDefaultBinding(InputControlType.Action2);
			this.actions.Cancel.AddDefaultBinding(new Key[]
			{
				Key.Escape
			});
		}
		else
		{
			this.actions.Cancel.AddDefaultBinding(InputControlType.Action1);
			this.actions.Cancel.AddDefaultBinding(new Key[]
			{
				Key.Escape
			});
			this.actions.Submit.AddDefaultBinding(InputControlType.Action2);
			this.actions.Submit.AddDefaultBinding(new Key[]
			{
				Key.Space
			});
			this.actions.Submit.AddDefaultBinding(new Key[]
			{
				Key.Return
			});
		}
		this.actions.Up.ClearBindings();
		this.actions.Up.AddDefaultBinding(InputControlType.LeftStickUp);
		this.actions.Up.AddDefaultBinding(InputControlType.DPadUp);
		this.actions.Up.AddDefaultBinding(new Key[]
		{
			Key.UpArrow
		});
		this.actions.Down.ClearBindings();
		this.actions.Down.AddDefaultBinding(InputControlType.LeftStickDown);
		this.actions.Down.AddDefaultBinding(InputControlType.DPadDown);
		this.actions.Down.AddDefaultBinding(new Key[]
		{
			Key.DownArrow
		});
		this.actions.Left.ClearBindings();
		this.actions.Left.AddDefaultBinding(InputControlType.LeftStickLeft);
		this.actions.Left.AddDefaultBinding(InputControlType.DPadLeft);
		this.actions.Left.AddDefaultBinding(new Key[]
		{
			Key.LeftArrow
		});
		this.actions.Right.ClearBindings();
		this.actions.Right.AddDefaultBinding(InputControlType.LeftStickRight);
		this.actions.Right.AddDefaultBinding(InputControlType.DPadRight);
		this.actions.Right.AddDefaultBinding(new Key[]
		{
			Key.RightArrow
		});
	}

	// Token: 0x04000F2F RID: 3887
	private InputModuleBinder.MyActionSet actions;

	// Token: 0x020002AD RID: 685
	public class MyActionSet : PlayerActionSet
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x00047F74 File Offset: 0x00046174
		public MyActionSet()
		{
			this.Submit = base.CreatePlayerAction("Submit");
			this.Cancel = base.CreatePlayerAction("Cancel");
			this.Left = base.CreatePlayerAction("Move Left");
			this.Right = base.CreatePlayerAction("Move Right");
			this.Up = base.CreatePlayerAction("Move Up");
			this.Down = base.CreatePlayerAction("Move Down");
			this.Move = base.CreateTwoAxisPlayerAction(this.Left, this.Right, this.Down, this.Up);
		}

		// Token: 0x04000F30 RID: 3888
		public PlayerAction Submit;

		// Token: 0x04000F31 RID: 3889
		public PlayerAction Cancel;

		// Token: 0x04000F32 RID: 3890
		public PlayerAction Left;

		// Token: 0x04000F33 RID: 3891
		public PlayerAction Right;

		// Token: 0x04000F34 RID: 3892
		public PlayerAction Up;

		// Token: 0x04000F35 RID: 3893
		public PlayerAction Down;

		// Token: 0x04000F36 RID: 3894
		public PlayerTwoAxisAction Move;
	}
}
