using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A86 RID: 2694
	[ActionCategory("uGui")]
	[Tooltip("Gets the navigation mode of a Selectable Ugui component.")]
	public class uGuiNavigationGetMode : FsmStateAction
	{
		// Token: 0x06003A0E RID: 14862 RVA: 0x00152C1E File Offset: 0x00150E1E
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00152C28 File Offset: 0x00150E28
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			this.DoGetValue();
			base.Finish();
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00152C68 File Offset: 0x00150E68
		private void DoGetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			this.navigationMode.Value = this._selectable.navigation.mode.ToString();
			if (this._selectable.navigation.mode == Navigation.Mode.None)
			{
				base.Fsm.Event(this.noNavigationEvent);
				return;
			}
			if (this._selectable.navigation.mode == Navigation.Mode.Automatic)
			{
				base.Fsm.Event(this.automaticEvent);
				return;
			}
			if (this._selectable.navigation.mode == Navigation.Mode.Vertical)
			{
				base.Fsm.Event(this.verticalEvent);
				return;
			}
			if (this._selectable.navigation.mode == Navigation.Mode.Horizontal)
			{
				base.Fsm.Event(this.horizontalEvent);
				return;
			}
			if (this._selectable.navigation.mode == Navigation.Mode.Explicit)
			{
				base.Fsm.Event(this.explicitEvent);
			}
		}

		// Token: 0x04003D55 RID: 15701
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D56 RID: 15702
		[Tooltip("The navigation mode value")]
		public FsmString navigationMode;

		// Token: 0x04003D57 RID: 15703
		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent automaticEvent;

		// Token: 0x04003D58 RID: 15704
		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent horizontalEvent;

		// Token: 0x04003D59 RID: 15705
		[Tooltip("Event sent if transition is SpriteSwap")]
		public FsmEvent verticalEvent;

		// Token: 0x04003D5A RID: 15706
		[Tooltip("Event sent if transition is Animation")]
		public FsmEvent explicitEvent;

		// Token: 0x04003D5B RID: 15707
		[Tooltip("Event sent if transition is none")]
		public FsmEvent noNavigationEvent;

		// Token: 0x04003D5C RID: 15708
		private Selectable _selectable;

		// Token: 0x04003D5D RID: 15709
		private Selectable.Transition _originalTransition;
	}
}
