using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B5B RID: 2907
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Creates a Game Object at a spawn point.\nUse a Game Object and/or Position/Rotation for the Spawn Point. If you specify a Game Object, Position is used as a local offset, and Rotation will override the object's rotation.")]
	public class CreateEmptyObject : FsmStateAction
	{
		// Token: 0x06003E0D RID: 15885 RVA: 0x0016320D File Offset: 0x0016140D
		public override void Reset()
		{
			this.gameObject = null;
			this.spawnPoint = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.rotation = new FsmVector3
			{
				UseVariable = true
			};
			this.storeObject = null;
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00163248 File Offset: 0x00161448
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			Vector3 a = Vector3.zero;
			Vector3 eulerAngles = Vector3.zero;
			if (this.spawnPoint.Value != null)
			{
				a = this.spawnPoint.Value.transform.position;
				if (!this.position.IsNone)
				{
					a += this.position.Value;
				}
				if (!this.rotation.IsNone)
				{
					eulerAngles = this.rotation.Value;
				}
				else
				{
					eulerAngles = this.spawnPoint.Value.transform.eulerAngles;
				}
			}
			else
			{
				if (!this.position.IsNone)
				{
					a = this.position.Value;
				}
				if (!this.rotation.IsNone)
				{
					eulerAngles = this.rotation.Value;
				}
			}
			GameObject gameObject = this.storeObject.Value;
			if (value != null)
			{
				gameObject = UnityEngine.Object.Instantiate<GameObject>(value);
				this.storeObject.Value = gameObject;
			}
			else
			{
				gameObject = new GameObject("EmptyObjectFromNull");
				this.storeObject.Value = gameObject;
			}
			if (gameObject != null)
			{
				gameObject.transform.position = a;
				gameObject.transform.eulerAngles = eulerAngles;
			}
			base.Finish();
		}

		// Token: 0x04004225 RID: 16933
		[Tooltip("Optional GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		// Token: 0x04004226 RID: 16934
		[Tooltip("Optional Spawn Point.")]
		public FsmGameObject spawnPoint;

		// Token: 0x04004227 RID: 16935
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04004228 RID: 16936
		[Tooltip("Rotation. NOTE: Overrides the rotation of the Spawn Point.")]
		public FsmVector3 rotation;

		// Token: 0x04004229 RID: 16937
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally store the created object.")]
		public FsmGameObject storeObject;
	}
}
