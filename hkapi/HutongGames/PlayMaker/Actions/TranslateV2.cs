using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A74 RID: 2676
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Translates a Game Object. Use a Vector3 variable and/or XYZ components. To leave any axis unchanged, set variable to 'None'.")]
	public class TranslateV2 : FsmStateAction
	{
		// Token: 0x060039AD RID: 14765 RVA: 0x00150C54 File Offset: 0x0014EE54
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
			this.alwaysOnStart = false;
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00150CCF File Offset: 0x0014EECF
		public override void Awake()
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

		// Token: 0x060039AF RID: 14767 RVA: 0x00150CCF File Offset: 0x0014EECF
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

		// Token: 0x060039B0 RID: 14768 RVA: 0x00150CF9 File Offset: 0x0014EEF9
		public override void OnEnter()
		{
			if (!this.everyFrame && !this.lateUpdate && !this.fixedUpdate)
			{
				this.DoTranslate();
				base.Finish();
			}
			if (this.alwaysOnStart)
			{
				this.DoTranslate();
			}
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00150D2D File Offset: 0x0014EF2D
		public override void OnUpdate()
		{
			if (!this.lateUpdate && !this.fixedUpdate)
			{
				this.DoTranslate();
			}
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00150D45 File Offset: 0x0014EF45
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

		// Token: 0x060039B3 RID: 14771 RVA: 0x00150D63 File Offset: 0x0014EF63
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

		// Token: 0x060039B4 RID: 14772 RVA: 0x00150D84 File Offset: 0x0014EF84
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
			}
			else
			{
				ownerDefaultTarget.transform.Translate(vector * Time.deltaTime, this.space);
			}
			if (!this.yMin.IsNone && ownerDefaultTarget.transform.position.y < this.yMin.Value)
			{
				ownerDefaultTarget.transform.position = new Vector3(ownerDefaultTarget.transform.position.x, this.yMin.Value, ownerDefaultTarget.transform.position.z);
			}
			if (!this.yMax.IsNone && ownerDefaultTarget.transform.position.y > this.yMax.Value)
			{
				ownerDefaultTarget.transform.position = new Vector3(ownerDefaultTarget.transform.position.x, this.yMax.Value, ownerDefaultTarget.transform.position.z);
			}
		}

		// Token: 0x04003CB6 RID: 15542
		[RequiredField]
		[Tooltip("The game object to translate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003CB7 RID: 15543
		[UIHint(UIHint.Variable)]
		[Tooltip("A translation vector. NOTE: You can override individual axis below.")]
		public FsmVector3 vector;

		// Token: 0x04003CB8 RID: 15544
		[Tooltip("Translation along x axis.")]
		public FsmFloat x;

		// Token: 0x04003CB9 RID: 15545
		[Tooltip("Translation along y axis.")]
		public FsmFloat y;

		// Token: 0x04003CBA RID: 15546
		[Tooltip("Translation along z axis.")]
		public FsmFloat z;

		// Token: 0x04003CBB RID: 15547
		[Tooltip("Translate in local or world space.")]
		public Space space;

		// Token: 0x04003CBC RID: 15548
		[Tooltip("Translate over one second")]
		public bool perSecond;

		// Token: 0x04003CBD RID: 15549
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04003CBE RID: 15550
		[Tooltip("Perform the translate in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;

		// Token: 0x04003CBF RID: 15551
		[Tooltip("Perform the translate in FixedUpdate. This is useful when working with rigid bodies and physics.")]
		public bool fixedUpdate;

		// Token: 0x04003CC0 RID: 15552
		public bool alwaysOnStart;

		// Token: 0x04003CC1 RID: 15553
		public FsmFloat yMin;

		// Token: 0x04003CC2 RID: 15554
		public FsmFloat yMax;
	}
}
