using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A66 RID: 2662
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject and fires them off in random directions.")]
	public class SpawnRandomObjects : RigidBody2dActionBase
	{
		// Token: 0x06003977 RID: 14711 RVA: 0x0014ED80 File Offset: 0x0014CF80
		public override void Reset()
		{
			this.gameObject = null;
			this.spawnPoint = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.spawnMin = null;
			this.spawnMax = null;
			this.speedMin = null;
			this.speedMax = null;
			this.angleMin = null;
			this.angleMax = null;
			this.originVariation = null;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0014EDE0 File Offset: 0x0014CFE0
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				Vector3 a = Vector3.zero;
				Vector3 zero = Vector3.zero;
				if (this.spawnPoint.Value != null)
				{
					a = this.spawnPoint.Value.transform.position;
					if (!this.position.IsNone)
					{
						a += this.position.Value;
					}
				}
				else if (!this.position.IsNone)
				{
					a = this.position.Value;
				}
				int num = UnityEngine.Random.Range(this.spawnMin.Value, this.spawnMax.Value + 1);
				for (int i = 1; i <= num; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(value, a, Quaternion.Euler(zero));
					if (this.originVariation != null)
					{
						float x = gameObject.transform.position.x + UnityEngine.Random.Range(-this.originVariation.Value, this.originVariation.Value);
						float y = gameObject.transform.position.y + UnityEngine.Random.Range(-this.originVariation.Value, this.originVariation.Value);
						float z = gameObject.transform.position.z;
						gameObject.transform.position = new Vector3(x, y, z);
					}
					base.CacheRigidBody2d(gameObject);
					float num2 = UnityEngine.Random.Range(this.speedMin.Value, this.speedMax.Value);
					float num3 = UnityEngine.Random.Range(this.angleMin.Value, this.angleMax.Value);
					this.vectorX = num2 * Mathf.Cos(num3 * 0.017453292f);
					this.vectorY = num2 * Mathf.Sin(num3 * 0.017453292f);
					Vector2 velocity;
					velocity.x = this.vectorX;
					velocity.y = this.vectorY;
					this.rb2d.velocity = velocity;
				}
			}
			base.Finish();
		}

		// Token: 0x04003C3D RID: 15421
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C3E RID: 15422
		[Tooltip("GameObject to spawn at (optional).")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C3F RID: 15423
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C40 RID: 15424
		[Tooltip("Minimum amount of clones to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C41 RID: 15425
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C42 RID: 15426
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C43 RID: 15427
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C44 RID: 15428
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C45 RID: 15429
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C46 RID: 15430
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariation;

		// Token: 0x04003C47 RID: 15431
		private float vectorX;

		// Token: 0x04003C48 RID: 15432
		private float vectorY;
	}
}
