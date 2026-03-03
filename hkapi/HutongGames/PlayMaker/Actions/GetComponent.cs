using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD6 RID: 3030
	[ActionCategory(ActionCategory.UnityObject)]
	[Tooltip("Gets a Component attached to a GameObject and stores it in an Object variable. NOTE: Set the Object variable's Object Type to get a component of that type. E.g., set Object Type to UnityEngine.AudioListener to get the AudioListener component on the camera.")]
	public class GetComponent : FsmStateAction
	{
		// Token: 0x06003FD2 RID: 16338 RVA: 0x00168763 File Offset: 0x00166963
		public override void Reset()
		{
			this.gameObject = null;
			this.storeComponent = null;
			this.everyFrame = false;
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0016877A File Offset: 0x0016697A
		public override void OnEnter()
		{
			this.DoGetComponent();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00168790 File Offset: 0x00166990
		public override void OnUpdate()
		{
			this.DoGetComponent();
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00168798 File Offset: 0x00166998
		private void DoGetComponent()
		{
			if (this.storeComponent == null)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.storeComponent.IsNone)
			{
				return;
			}
			this.storeComponent.Value = ownerDefaultTarget.GetComponent(this.storeComponent.ObjectType);
		}

		// Token: 0x04004402 RID: 17410
		[Tooltip("The GameObject that owns the component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004403 RID: 17411
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("Store the component in an Object variable.\nNOTE: Set theObject variable's Object Type to get a component of that type. E.g., set Object Type to UnityEngine.AudioListener to get the AudioListener component on the camera.")]
		public FsmObject storeComponent;

		// Token: 0x04004404 RID: 17412
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
