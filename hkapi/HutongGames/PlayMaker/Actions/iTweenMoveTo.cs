using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D2E RID: 3374
	[ActionCategory("iTween")]
	[Tooltip("Changes a GameObject's position over time to a supplied destination.")]
	public class iTweenMoveTo : iTweenFsmAction
	{
		// Token: 0x060045DA RID: 17882 RVA: 0x0017B61C File Offset: 0x0017981C
		public override void OnDrawActionGizmos()
		{
			if (this.transforms.Length >= 2)
			{
				this.tempVct3 = new Vector3[this.transforms.Length];
				for (int i = 0; i < this.transforms.Length; i++)
				{
					if (this.transforms[i].IsNone)
					{
						this.tempVct3[i] = (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
					}
					else if (this.transforms[i].Value == null)
					{
						this.tempVct3[i] = (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
					}
					else
					{
						this.tempVct3[i] = this.transforms[i].Value.transform.position + (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
					}
				}
				iTween.DrawPathGizmos(this.tempVct3, Color.yellow);
			}
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x0017B748 File Offset: 0x00179948
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.transformPosition = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.delay = 0f;
			this.loopType = iTween.LoopType.none;
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.World;
			this.orientToPath = new FsmBool
			{
				Value = true
			};
			this.lookAtObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.lookAtVector = new FsmVector3
			{
				UseVariable = true
			};
			this.lookTime = new FsmFloat
			{
				UseVariable = true
			};
			this.moveToPath = true;
			this.lookAhead = new FsmFloat
			{
				UseVariable = true
			};
			this.transforms = new FsmGameObject[0];
			this.vectors = new FsmVector3[0];
			this.tempVct3 = new Vector3[0];
			this.axis = iTweenFsmAction.AxisRestriction.none;
			this.reverse = false;
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x0017B86E File Offset: 0x00179A6E
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x0017B891 File Offset: 0x00179A91
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x0017B8A0 File Offset: 0x00179AA0
		private void DoiTween()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vectorPosition.IsNone ? Vector3.zero : this.vectorPosition.Value;
			if (!this.transformPosition.IsNone && this.transformPosition.Value)
			{
				vector = ((this.space == Space.World || ownerDefaultTarget.transform.parent == null) ? (this.transformPosition.Value.transform.position + vector) : (ownerDefaultTarget.transform.parent.InverseTransformPoint(this.transformPosition.Value.transform.position) + vector));
			}
			Hashtable hashtable = new Hashtable();
			hashtable.Add("position", vector);
			hashtable.Add(this.speed.IsNone ? "time" : "speed", this.speed.IsNone ? (this.time.IsNone ? 1f : this.time.Value) : this.speed.Value);
			hashtable.Add("delay", this.delay.IsNone ? 0f : this.delay.Value);
			hashtable.Add("easetype", this.easeType);
			hashtable.Add("looptype", this.loopType);
			hashtable.Add("oncomplete", "iTweenOnComplete");
			hashtable.Add("oncompleteparams", this.itweenID);
			hashtable.Add("onstart", "iTweenOnStart");
			hashtable.Add("onstartparams", this.itweenID);
			hashtable.Add("ignoretimescale", !this.realTime.IsNone && this.realTime.Value);
			hashtable.Add("name", this.id.IsNone ? "" : this.id.Value);
			hashtable.Add("islocal", this.space == Space.Self);
			hashtable.Add("axis", (this.axis == iTweenFsmAction.AxisRestriction.none) ? "" : Enum.GetName(typeof(iTweenFsmAction.AxisRestriction), this.axis));
			if (!this.orientToPath.IsNone)
			{
				hashtable.Add("orienttopath", this.orientToPath.Value);
			}
			if (!this.lookAtObject.IsNone)
			{
				hashtable.Add("looktarget", this.lookAtVector.IsNone ? this.lookAtObject.Value.transform.position : (this.lookAtObject.Value.transform.position + this.lookAtVector.Value));
			}
			else if (!this.lookAtVector.IsNone)
			{
				hashtable.Add("looktarget", this.lookAtVector.Value);
			}
			if (!this.lookAtObject.IsNone || !this.lookAtVector.IsNone)
			{
				hashtable.Add("looktime", this.lookTime.IsNone ? 0f : this.lookTime.Value);
			}
			if (this.transforms.Length >= 2)
			{
				this.tempVct3 = new Vector3[this.transforms.Length];
				if (!this.reverse.IsNone && this.reverse.Value)
				{
					for (int i = 0; i < this.transforms.Length; i++)
					{
						if (this.transforms[i].IsNone)
						{
							this.tempVct3[this.tempVct3.Length - 1 - i] = (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
						}
						else if (this.transforms[i].Value == null)
						{
							this.tempVct3[this.tempVct3.Length - 1 - i] = (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
						}
						else
						{
							this.tempVct3[this.tempVct3.Length - 1 - i] = ((this.space == Space.World) ? this.transforms[i].Value.transform.position : this.transforms[i].Value.transform.localPosition) + (this.vectors[i].IsNone ? Vector3.zero : this.vectors[i].Value);
						}
					}
				}
				else
				{
					for (int j = 0; j < this.transforms.Length; j++)
					{
						if (this.transforms[j].IsNone)
						{
							this.tempVct3[j] = (this.vectors[j].IsNone ? Vector3.zero : this.vectors[j].Value);
						}
						else if (this.transforms[j].Value == null)
						{
							this.tempVct3[j] = (this.vectors[j].IsNone ? Vector3.zero : this.vectors[j].Value);
						}
						else
						{
							this.tempVct3[j] = ((this.space == Space.World) ? this.transforms[j].Value.transform.position : ownerDefaultTarget.transform.parent.InverseTransformPoint(this.transforms[j].Value.transform.position)) + (this.vectors[j].IsNone ? Vector3.zero : this.vectors[j].Value);
						}
					}
				}
				hashtable.Add("path", this.tempVct3);
				hashtable.Add("movetopath", this.moveToPath.IsNone || this.moveToPath.Value);
				hashtable.Add("lookahead", this.lookAhead.IsNone ? 1f : this.lookAhead.Value);
			}
			this.itweenType = "move";
			iTween.MoveTo(ownerDefaultTarget, hashtable);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x0017BF54 File Offset: 0x0017A154
		public iTweenMoveTo()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004A76 RID: 19062
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004A77 RID: 19063
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004A78 RID: 19064
		[Tooltip("Move To a transform position.")]
		public FsmGameObject transformPosition;

		// Token: 0x04004A79 RID: 19065
		[Tooltip("Position the GameObject will animate to. If Transform Position is defined this is used as a local offset.")]
		public FsmVector3 vectorPosition;

		// Token: 0x04004A7A RID: 19066
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004A7B RID: 19067
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004A7C RID: 19068
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004A7D RID: 19069
		[Tooltip("Whether to animate in local or world space.")]
		public Space space;

		// Token: 0x04004A7E RID: 19070
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004A7F RID: 19071
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004A80 RID: 19072
		[ActionSection("LookAt")]
		[Tooltip("Whether or not the GameObject will orient to its direction of travel. False by default.")]
		public FsmBool orientToPath;

		// Token: 0x04004A81 RID: 19073
		[Tooltip("A target object the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		// Token: 0x04004A82 RID: 19074
		[Tooltip("A target position the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		// Token: 0x04004A83 RID: 19075
		[Tooltip("The time in seconds the object will take to look at either the Look Target or Orient To Path. 0 by default")]
		public FsmFloat lookTime;

		// Token: 0x04004A84 RID: 19076
		[Tooltip("Restricts rotation to the supplied axis only.")]
		public iTweenFsmAction.AxisRestriction axis;

		// Token: 0x04004A85 RID: 19077
		[ActionSection("Path")]
		[Tooltip("Whether to automatically generate a curve from the GameObject's current position to the beginning of the path. True by default.")]
		public FsmBool moveToPath;

		// Token: 0x04004A86 RID: 19078
		[Tooltip("How much of a percentage (from 0 to 1) to look ahead on a path to influence how strict Orient To Path is and how much the object will anticipate each curve.")]
		public FsmFloat lookAhead;

		// Token: 0x04004A87 RID: 19079
		[CompoundArray("Path Nodes", "Transform", "Vector")]
		[Tooltip("A list of objects to draw a Catmull-Rom spline through for a curved animation path.")]
		public FsmGameObject[] transforms;

		// Token: 0x04004A88 RID: 19080
		[Tooltip("A list of positions to draw a Catmull-Rom through for a curved animation path. If Transform is defined, this value is added as a local offset.")]
		public FsmVector3[] vectors;

		// Token: 0x04004A89 RID: 19081
		[Tooltip("Reverse the path so object moves from End to Start node.")]
		public FsmBool reverse;

		// Token: 0x04004A8A RID: 19082
		private Vector3[] tempVct3;
	}
}
