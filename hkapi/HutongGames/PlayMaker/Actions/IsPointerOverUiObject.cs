using System;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A7F RID: 2687
	[ActionCategory("uGui")]
	[Tooltip("Checks if Pointer is over an uGui object and returns an event or bool, optionaly takes a pointer id, else use the current event")]
	public class IsPointerOverUiObject : FsmStateAction
	{
		// Token: 0x060039EC RID: 14828 RVA: 0x00152017 File Offset: 0x00150217
		public override void Reset()
		{
			this.pointerId = new FsmInt
			{
				UseVariable = true
			};
			this.pointerOverUI = null;
			this.pointerNotOverUI = null;
			this.isPointerOverUI = null;
			this.everyFrame = false;
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00152047 File Offset: 0x00150247
		public override void OnEnter()
		{
			this.DoCheckPointer();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0015205D File Offset: 0x0015025D
		public override void OnUpdate()
		{
			this.DoCheckPointer();
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x00152068 File Offset: 0x00150268
		private void DoCheckPointer()
		{
			bool flag = false;
			if (this.pointerId.IsNone)
			{
				flag = EventSystem.current.IsPointerOverGameObject();
			}
			else if (EventSystem.current.currentInputModule is PointerInputModule)
			{
				flag = (EventSystem.current.currentInputModule as PointerInputModule).IsPointerOverGameObject(this.pointerId.Value);
			}
			this.isPointerOverUI.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.pointerOverUI);
				return;
			}
			base.Fsm.Event(this.pointerNotOverUI);
		}

		// Token: 0x04003D19 RID: 15641
		[Tooltip("Optional PointerId. Leave to none to use the current event")]
		public FsmInt pointerId;

		// Token: 0x04003D1A RID: 15642
		[Tooltip("Event to send when the Pointer is over an uGui object.")]
		public FsmEvent pointerOverUI;

		// Token: 0x04003D1B RID: 15643
		[Tooltip("Event to send when the Pointer is NOT over an uGui object.")]
		public FsmEvent pointerNotOverUI;

		// Token: 0x04003D1C RID: 15644
		[UIHint(UIHint.Variable)]
		public FsmBool isPointerOverUI;

		// Token: 0x04003D1D RID: 15645
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
