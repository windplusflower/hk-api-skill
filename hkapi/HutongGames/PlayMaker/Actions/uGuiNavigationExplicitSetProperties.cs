using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A83 RID: 2691
	[ActionCategory("uGui")]
	[Tooltip("Sets the explicit navigation properties of a Selectable Ugui component. Note that it will have no effect until Navigation mode is set to 'Explicit'.")]
	public class uGuiNavigationExplicitSetProperties : FsmStateAction
	{
		// Token: 0x060039FF RID: 14847 RVA: 0x00152744 File Offset: 0x00150944
		public override void Reset()
		{
			this.gameObject = null;
			this.selectOnDown = new FsmGameObject
			{
				UseVariable = true
			};
			this.selectOnUp = new FsmGameObject
			{
				UseVariable = true
			};
			this.selectOnLeft = new FsmGameObject
			{
				UseVariable = true
			};
			this.selectOnRight = new FsmGameObject
			{
				UseVariable = true
			};
			this.resetOnExit = false;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x001527AC File Offset: 0x001509AC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalState = this._selectable.navigation;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00152818 File Offset: 0x00150A18
		private void DoSetValue()
		{
			if (this._selectable != null)
			{
				this._navigation = this._selectable.navigation;
				if (!this.selectOnDown.IsNone)
				{
					this._navigation.selectOnDown = this.GetComponentFromFsmGameObject<Selectable>(this.selectOnDown);
				}
				if (!this.selectOnUp.IsNone)
				{
					this._navigation.selectOnUp = this.GetComponentFromFsmGameObject<Selectable>(this.selectOnUp);
				}
				if (!this.selectOnLeft.IsNone)
				{
					this._navigation.selectOnLeft = this.GetComponentFromFsmGameObject<Selectable>(this.selectOnLeft);
				}
				if (!this.selectOnRight.IsNone)
				{
					this._navigation.selectOnRight = this.GetComponentFromFsmGameObject<Selectable>(this.selectOnRight);
				}
				this._selectable.navigation = this._navigation;
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x001528E8 File Offset: 0x00150AE8
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._navigation = this._selectable.navigation;
				this._navigation.selectOnDown = this._originalState.selectOnDown;
				this._navigation.selectOnLeft = this._originalState.selectOnLeft;
				this._navigation.selectOnRight = this._originalState.selectOnRight;
				this._navigation.selectOnUp = this._originalState.selectOnUp;
				this._selectable.navigation = this._navigation;
			}
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0015298C File Offset: 0x00150B8C
		private T GetComponentFromFsmGameObject<T>(FsmGameObject variable) where T : Component
		{
			if (variable.Value != null)
			{
				return variable.Value.GetComponent<T>();
			}
			return default(T);
		}

		// Token: 0x04003D3D RID: 15677
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D3E RID: 15678
		[Tooltip("The down Selectable. Leave to none for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnDown;

		// Token: 0x04003D3F RID: 15679
		[Tooltip("The up Selectable.  Leave to none for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnUp;

		// Token: 0x04003D40 RID: 15680
		[Tooltip("The left Selectable.  Leave to none for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnLeft;

		// Token: 0x04003D41 RID: 15681
		[Tooltip("The right Selectable.  Leave to none for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnRight;

		// Token: 0x04003D42 RID: 15682
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D43 RID: 15683
		private Selectable _selectable;

		// Token: 0x04003D44 RID: 15684
		private Navigation _navigation;

		// Token: 0x04003D45 RID: 15685
		private Navigation _originalState;
	}
}
