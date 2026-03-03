using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A67 RID: 2663
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject over time and fires them off in random directions.")]
	public class SpawnRandomObjectsOverTime : RigidBody2dActionBase
	{
		// Token: 0x0600397A RID: 14714 RVA: 0x0014EFE8 File Offset: 0x0014D1E8
		public override void Reset()
		{
			this.gameObject = null;
			this.spawnPoint = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.spawnMin = null;
			this.frequency = null;
			this.spawnMax = null;
			this.speedMin = null;
			this.speedMax = null;
			this.angleMin = null;
			this.angleMax = null;
			this.originVariation = null;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnEnter()
		{
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0014F04D File Offset: 0x0014D24D
		public override void OnUpdate()
		{
			this.DoSpawn();
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0014F058 File Offset: 0x0014D258
		private void DoSpawn()
		{
			this.timer += Time.deltaTime;
			if (this.timer >= this.frequency.Value)
			{
				this.timer = 0f;
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
			}
		}

		// Token: 0x04003C49 RID: 15433
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C4A RID: 15434
		[Tooltip("GameObject to spawn at (optional).")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C4B RID: 15435
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C4C RID: 15436
		[Tooltip("How often, in seconds, spawn occurs.")]
		public FsmFloat frequency;

		// Token: 0x04003C4D RID: 15437
		[Tooltip("Minimum amount of clones to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C4E RID: 15438
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C4F RID: 15439
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C50 RID: 15440
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C51 RID: 15441
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C52 RID: 15442
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C53 RID: 15443
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariation;

		// Token: 0x04003C54 RID: 15444
		private float vectorX;

		// Token: 0x04003C55 RID: 15445
		private float vectorY;

		// Token: 0x04003C56 RID: 15446
		private float timer;
	}
}
