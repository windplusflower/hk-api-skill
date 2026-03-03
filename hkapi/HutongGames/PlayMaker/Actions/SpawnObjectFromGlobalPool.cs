using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A63 RID: 2659
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a prefab Game Object from the Global Object Pool on the Game Manager.")]
	public class SpawnObjectFromGlobalPool : FsmStateAction
	{
		// Token: 0x0600396E RID: 14702 RVA: 0x0014E8EF File Offset: 0x0014CAEF
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

		// Token: 0x0600396F RID: 14703 RVA: 0x0014E92C File Offset: 0x0014CB2C
		public override void OnEnter()
		{
			if (this.gameObject.Value != null)
			{
				Vector3 a = Vector3.zero;
				Vector3 euler = Vector3.up;
				if (this.spawnPoint.Value != null)
				{
					a = this.spawnPoint.Value.transform.position;
					if (!this.position.IsNone)
					{
						a += this.position.Value;
					}
					euler = ((!this.rotation.IsNone) ? this.rotation.Value : this.spawnPoint.Value.transform.eulerAngles);
				}
				else
				{
					if (!this.position.IsNone)
					{
						a = this.position.Value;
					}
					if (!this.rotation.IsNone)
					{
						euler = this.rotation.Value;
					}
				}
				if (this.gameObject != null)
				{
					GameObject value = this.gameObject.Value.Spawn(a, Quaternion.Euler(euler));
					this.storeObject.Value = value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003C2A RID: 15402
		[RequiredField]
		[Tooltip("GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C2B RID: 15403
		[Tooltip("Optional Spawn Point.")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C2C RID: 15404
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C2D RID: 15405
		[Tooltip("Rotation. NOTE: Overrides the rotation of the Spawn Point.")]
		public FsmVector3 rotation;

		// Token: 0x04003C2E RID: 15406
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally store the created object.")]
		public FsmGameObject storeObject;
	}
}
