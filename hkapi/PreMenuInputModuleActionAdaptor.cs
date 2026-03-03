using System;
using InControl;
using UnityEngine;

// Token: 0x020002AF RID: 687
[RequireComponent(typeof(InControlInputModule))]
public class PreMenuInputModuleActionAdaptor : MonoBehaviour
{
	// Token: 0x06000E88 RID: 3720 RVA: 0x00048124 File Offset: 0x00046324
	private void OnEnable()
	{
		this.CreateActions();
		InControlInputModule component = base.GetComponent<InControlInputModule>();
		if (component != null)
		{
			component.SubmitAction = this.actions.Submit;
			component.CancelAction = this.actions.Cancel;
			component.MoveAction = this.actions.Move;
		}
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0004817A File Offset: 0x0004637A
	private void OnDisable()
	{
		this.DestroyActions();
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00048184 File Offset: 0x00046384
	private void CreateActions()
	{
		this.actions = new PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions();
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
		this.actions.Up.AddDefaultBinding(InputControlType.LeftStickUp);
		this.actions.Up.AddDefaultBinding(InputControlType.DPadUp);
		this.actions.Up.AddDefaultBinding(new Key[]
		{
			Key.UpArrow
		});
		this.actions.Down.AddDefaultBinding(InputControlType.LeftStickDown);
		this.actions.Down.AddDefaultBinding(InputControlType.DPadDown);
		this.actions.Down.AddDefaultBinding(new Key[]
		{
			Key.DownArrow
		});
		this.actions.Left.AddDefaultBinding(InputControlType.LeftStickLeft);
		this.actions.Left.AddDefaultBinding(InputControlType.DPadLeft);
		this.actions.Left.AddDefaultBinding(new Key[]
		{
			Key.LeftArrow
		});
		this.actions.Right.AddDefaultBinding(InputControlType.LeftStickRight);
		this.actions.Right.AddDefaultBinding(InputControlType.DPadRight);
		this.actions.Right.AddDefaultBinding(new Key[]
		{
			Key.RightArrow
		});
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00048309 File Offset: 0x00046509
	private void DestroyActions()
	{
		this.actions.Destroy();
	}

	// Token: 0x04000F3A RID: 3898
	private PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions actions;

	// Token: 0x020002B0 RID: 688
	public class PreMenuInputModuleActions : PlayerActionSet
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00048318 File Offset: 0x00046518
		public PreMenuInputModuleActions()
		{
			this.Submit = base.CreatePlayerAction("Submit");
			this.Cancel = base.CreatePlayerAction("Cancel");
			this.Left = base.CreatePlayerAction("Move Left");
			this.Right = base.CreatePlayerAction("Move Right");
			this.Up = base.CreatePlayerAction("Move Up");
			this.Down = base.CreatePlayerAction("Move Down");
			this.Move = base.CreateTwoAxisPlayerAction(this.Left, this.Right, this.Down, this.Up);
		}

		// Token: 0x04000F3B RID: 3899
		public PlayerAction Submit;

		// Token: 0x04000F3C RID: 3900
		public PlayerAction Cancel;

		// Token: 0x04000F3D RID: 3901
		public PlayerAction Left;

		// Token: 0x04000F3E RID: 3902
		public PlayerAction Right;

		// Token: 0x04000F3F RID: 3903
		public PlayerAction Up;

		// Token: 0x04000F40 RID: 3904
		public PlayerAction Down;

		// Token: 0x04000F41 RID: 3905
		public PlayerTwoAxisAction Move;
	}
}
