using System;
using InControl;
using UnityEngine;

// Token: 0x020002AB RID: 683
[RequireComponent(typeof(HollowKnightInputModule))]
public class InputModuleActionAdaptor : MonoBehaviour
{
	// Token: 0x06000E78 RID: 3704 RVA: 0x00047B6C File Offset: 0x00045D6C
	private void Start()
	{
		this.inputHandler = GameManager.instance.inputHandler;
		this.inputModule = base.GetComponent<HollowKnightInputModule>();
		if (this.inputHandler != null && this.inputModule != null)
		{
			this.inputModule.MoveAction = this.inputHandler.inputActions.moveVector;
			this.inputModule.SubmitAction = this.inputHandler.inputActions.menuSubmit;
			this.inputModule.CancelAction = this.inputHandler.inputActions.menuCancel;
			this.inputModule.JumpAction = this.inputHandler.inputActions.jump;
			this.inputModule.AttackAction = this.inputHandler.inputActions.attack;
			this.inputModule.CastAction = this.inputHandler.inputActions.cast;
			this.inputModule.MoveAction = this.inputHandler.inputActions.moveVector;
			return;
		}
		Debug.LogError("Unable to bind player action set to Input Module.");
	}

	// Token: 0x04000F2D RID: 3885
	private InputHandler inputHandler;

	// Token: 0x04000F2E RID: 3886
	private HollowKnightInputModule inputModule;
}
