using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6A RID: 2666
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject and fires them off in random directions.")]
	public class SpawnRandomObjectsVelocity : RigidBody2dActionBase
	{
		// Token: 0x06003987 RID: 14727 RVA: 0x0014F8CC File Offset: 0x0014DACC
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
			this.speedMinX = null;
			this.speedMaxX = null;
			this.speedMinY = null;
			this.speedMaxY = null;
			this.originVariationX = null;
			this.originVariationY = null;
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0014F934 File Offset: 0x0014DB34
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
					float x2 = UnityEngine.Random.Range(this.speedMinX.Value, this.speedMaxX.Value);
					float y2 = UnityEngine.Random.Range(this.speedMinY.Value, this.speedMaxY.Value);
					Vector2 velocity = new Vector2(x2, y2);
					this.rb2d.velocity = velocity;
				}
			}
			base.Finish();
		}

		// Token: 0x04003C77 RID: 15479
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C78 RID: 15480
		[Tooltip("GameObject to spawn at (optional).")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C79 RID: 15481
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C7A RID: 15482
		[Tooltip("Minimum amount of clones to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C7B RID: 15483
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C7C RID: 15484
		public FsmFloat speedMinX;

		// Token: 0x04003C7D RID: 15485
		public FsmFloat speedMaxX;

		// Token: 0x04003C7E RID: 15486
		public FsmFloat speedMinY;

		// Token: 0x04003C7F RID: 15487
		public FsmFloat speedMaxY;

		// Token: 0x04003C80 RID: 15488
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariationX;

		// Token: 0x04003C81 RID: 15489
		public FsmFloat originVariationY;

		// Token: 0x04003C82 RID: 15490
		private float vectorX;

		// Token: 0x04003C83 RID: 15491
		private float vectorY;

		// Token: 0x04003C84 RID: 15492
		private bool originAdjusted;
	}
}
