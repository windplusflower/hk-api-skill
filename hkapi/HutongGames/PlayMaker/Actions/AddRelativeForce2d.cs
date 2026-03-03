using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C46 RID: 3142
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Adds a relative 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis.")]
	public class AddRelativeForce2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x060041C5 RID: 16837 RVA: 0x0016DD44 File Offset: 0x0016BF44
		public override void Reset()
		{
			this.gameObject = null;
			this.forceMode = ForceMode2D.Force;
			this.vector = null;
			this.vector3 = new FsmVector3
			{
				UseVariable = true
			};
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x0016DDA3 File Offset: 0x0016BFA3
		public override void OnEnter()
		{
			this.DoAddRelativeForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x0016DDB9 File Offset: 0x0016BFB9
		public override void OnFixedUpdate()
		{
			this.DoAddRelativeForce();
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x0016DDC4 File Offset: 0x0016BFC4
		private void DoAddRelativeForce()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector2 relativeForce = this.vector.IsNone ? new Vector2(this.x.Value, this.y.Value) : this.vector.Value;
			if (!this.vector3.IsNone)
			{
				relativeForce.x = this.vector3.Value.x;
				relativeForce.y = this.vector3.Value.y;
			}
			if (!this.x.IsNone)
			{
				relativeForce.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				relativeForce.y = this.y.Value;
			}
			base.rigidbody2d.AddRelativeForce(relativeForce, this.forceMode);
		}

		// Token: 0x04004627 RID: 17959
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004628 RID: 17960
		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		// Token: 0x04004629 RID: 17961
		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector2 force to add. Optionally override any axis with the X, Y parameters.")]
		public FsmVector2 vector;

		// Token: 0x0400462A RID: 17962
		[Tooltip("Force along the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		// Token: 0x0400462B RID: 17963
		[Tooltip("Force along the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		// Token: 0x0400462C RID: 17964
		[Tooltip("A Vector3 force to add. z is ignored")]
		public FsmVector3 vector3;

		// Token: 0x0400462D RID: 17965
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
