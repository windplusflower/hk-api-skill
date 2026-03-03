using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A69 RID: 2665
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject and fires them off in random directions.")]
	public class SpawnRandomObjectsV2 : RigidBody2dActionBase
	{
		// Token: 0x06003984 RID: 14724 RVA: 0x0014F61C File Offset: 0x0014D81C
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
			this.originVariationX = null;
			this.originVariationY = null;
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x0014F684 File Offset: 0x0014D884
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
					float x = gameObject.transform.position.x;
					float y = gameObject.transform.position.y;
					float z = gameObject.transform.position.z;
					if (this.originVariationX != null)
					{
						x = gameObject.transform.position.x + UnityEngine.Random.Range(-this.originVariationX.Value, this.originVariationX.Value);
						this.originAdjusted = true;
					}
					if (this.originVariationY != null)
					{
						y = gameObject.transform.position.y + UnityEngine.Random.Range(-this.originVariationY.Value, this.originVariationY.Value);
						this.originAdjusted = true;
					}
					if (this.originAdjusted)
					{
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

		// Token: 0x04003C69 RID: 15465
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C6A RID: 15466
		[Tooltip("GameObject to spawn at (optional).")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C6B RID: 15467
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C6C RID: 15468
		[Tooltip("Minimum amount of clones to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C6D RID: 15469
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C6E RID: 15470
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C6F RID: 15471
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C70 RID: 15472
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C71 RID: 15473
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C72 RID: 15474
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariationX;

		// Token: 0x04003C73 RID: 15475
		public FsmFloat originVariationY;

		// Token: 0x04003C74 RID: 15476
		private float vectorX;

		// Token: 0x04003C75 RID: 15477
		private float vectorY;

		// Token: 0x04003C76 RID: 15478
		private bool originAdjusted;
	}
}
