using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD8 RID: 3288
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Position of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class SetPosition : FsmStateAction
	{
		// Token: 0x06004460 RID: 17504 RVA: 0x001758F0 File Offset: 0x00173AF0
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
			this.space = Space.Self;
			this.everyFrame = false;
			this.lateUpdate = false;
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00175956 File Offset: 0x00173B56
		public override void OnPreprocess()
		{
			if (this.lateUpdate)
			{
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x0017596C File Offset: 0x00173B6C
		public override void OnEnter()
		{
			if (!this.everyFrame && !this.lateUpdate)
			{
				this.DoSetPosition();
				base.Finish();
			}
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x0017598A File Offset: 0x00173B8A
		public override void OnUpdate()
		{
			if (!this.lateUpdate)
			{
				this.DoSetPosition();
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x0017599A File Offset: 0x00173B9A
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoSetPosition();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x001759B8 File Offset: 0x00173BB8
		private void DoSetPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector;
			if (this.vector.IsNone)
			{
				vector = ((this.space == Space.World) ? ownerDefaultTarget.transform.position : ownerDefaultTarget.transform.localPosition);
			}
			else
			{
				vector = this.vector.Value;
			}
			if (!this.x.IsNone)
			{
				vector.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				vector.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				vector.z = this.z.Value;
			}
			if (this.space == Space.World)
			{
				ownerDefaultTarget.transform.position = vector;
				return;
			}
			ownerDefaultTarget.transform.localPosition = vector;
		}

		// Token: 0x040048A8 RID: 18600
		[RequiredField]
		[Tooltip("The GameObject to position.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048A9 RID: 18601
		[UIHint(UIHint.Variable)]
		[Tooltip("Use a stored Vector3 position, and/or set individual axis below.")]
		public FsmVector3 vector;

		// Token: 0x040048AA RID: 18602
		public FsmFloat x;

		// Token: 0x040048AB RID: 18603
		public FsmFloat y;

		// Token: 0x040048AC RID: 18604
		public FsmFloat z;

		// Token: 0x040048AD RID: 18605
		[Tooltip("Use local or world space.")]
		public Space space;

		// Token: 0x040048AE RID: 18606
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040048AF RID: 18607
		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;
	}
}
