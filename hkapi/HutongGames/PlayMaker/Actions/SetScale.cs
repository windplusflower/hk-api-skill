using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE0 RID: 3296
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Scale of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class SetScale : FsmStateAction
	{
		// Token: 0x06004487 RID: 17543 RVA: 0x00176174 File Offset: 0x00174374
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.z = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
			this.lateUpdate = false;
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x001761D3 File Offset: 0x001743D3
		public override void OnPreprocess()
		{
			if (this.lateUpdate)
			{
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x001761E9 File Offset: 0x001743E9
		public override void OnEnter()
		{
			this.DoSetScale();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x001761FF File Offset: 0x001743FF
		public override void OnUpdate()
		{
			if (!this.lateUpdate)
			{
				this.DoSetScale();
			}
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x0017620F File Offset: 0x0017440F
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoSetScale();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00176230 File Offset: 0x00174430
		private void DoSetScale()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 localScale = this.vector.IsNone ? ownerDefaultTarget.transform.localScale : this.vector.Value;
			if (!this.x.IsNone)
			{
				localScale.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				localScale.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				localScale.z = this.z.Value;
			}
			ownerDefaultTarget.transform.localScale = localScale;
		}

		// Token: 0x040048D0 RID: 18640
		[RequiredField]
		[Tooltip("The GameObject to scale.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048D1 RID: 18641
		[UIHint(UIHint.Variable)]
		[Tooltip("Use stored Vector3 value, and/or set each axis below.")]
		public FsmVector3 vector;

		// Token: 0x040048D2 RID: 18642
		public FsmFloat x;

		// Token: 0x040048D3 RID: 18643
		public FsmFloat y;

		// Token: 0x040048D4 RID: 18644
		public FsmFloat z;

		// Token: 0x040048D5 RID: 18645
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040048D6 RID: 18646
		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;
	}
}
