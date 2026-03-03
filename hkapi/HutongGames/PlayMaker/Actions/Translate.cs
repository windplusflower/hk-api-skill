using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D04 RID: 3332
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Translates a Game Object. Use a Vector3 variable and/or XYZ components. To leave any axis unchanged, set variable to 'None'.")]
	public class Translate : FsmStateAction
	{
		// Token: 0x06004520 RID: 17696 RVA: 0x00178614 File Offset: 0x00176814
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
			this.perSecond = true;
			this.everyFrame = true;
			this.lateUpdate = false;
			this.fixedUpdate = false;
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00178688 File Offset: 0x00176888
		public override void OnPreprocess()
		{
			if (this.fixedUpdate)
			{
				base.Fsm.HandleFixedUpdate = true;
			}
			if (this.lateUpdate)
			{
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x001786B2 File Offset: 0x001768B2
		public override void OnEnter()
		{
			if (!this.everyFrame && !this.lateUpdate && !this.fixedUpdate)
			{
				this.DoTranslate();
				base.Finish();
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001786D8 File Offset: 0x001768D8
		public override void OnUpdate()
		{
			if (!this.lateUpdate && !this.fixedUpdate)
			{
				this.DoTranslate();
			}
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001786F0 File Offset: 0x001768F0
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoTranslate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x0017870E File Offset: 0x0017690E
		public override void OnFixedUpdate()
		{
			if (this.fixedUpdate)
			{
				this.DoTranslate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x0017872C File Offset: 0x0017692C
		private void DoTranslate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vector.IsNone ? new Vector3(this.x.Value, this.y.Value, this.z.Value) : this.vector.Value;
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
			if (!this.perSecond)
			{
				ownerDefaultTarget.transform.Translate(vector, this.space);
				return;
			}
			ownerDefaultTarget.transform.Translate(vector * Time.deltaTime, this.space);
		}

		// Token: 0x0400498C RID: 18828
		[RequiredField]
		[Tooltip("The game object to translate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400498D RID: 18829
		[UIHint(UIHint.Variable)]
		[Tooltip("A translation vector. NOTE: You can override individual axis below.")]
		public FsmVector3 vector;

		// Token: 0x0400498E RID: 18830
		[Tooltip("Translation along x axis.")]
		public FsmFloat x;

		// Token: 0x0400498F RID: 18831
		[Tooltip("Translation along y axis.")]
		public FsmFloat y;

		// Token: 0x04004990 RID: 18832
		[Tooltip("Translation along z axis.")]
		public FsmFloat z;

		// Token: 0x04004991 RID: 18833
		[Tooltip("Translate in local or world space.")]
		public Space space;

		// Token: 0x04004992 RID: 18834
		[Tooltip("Translate over one second")]
		public bool perSecond;

		// Token: 0x04004993 RID: 18835
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004994 RID: 18836
		[Tooltip("Perform the translate in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;

		// Token: 0x04004995 RID: 18837
		[Tooltip("Perform the translate in FixedUpdate. This is useful when working with rigid bodies and physics.")]
		public bool fixedUpdate;
	}
}
