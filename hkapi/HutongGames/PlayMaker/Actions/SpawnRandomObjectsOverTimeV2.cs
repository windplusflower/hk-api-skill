using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A68 RID: 2664
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject over time and fires them off in random directions.")]
	public class SpawnRandomObjectsOverTimeV2 : RigidBody2dActionBase
	{
		// Token: 0x0600397F RID: 14719 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnEnter()
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0014F28C File Offset: 0x0014D48C
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
			this.originVariationX = null;
			this.originVariationY = null;
			this.scaleMin = 1f;
			this.scaleMax = 1f;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0014F318 File Offset: 0x0014D518
		public override void OnUpdate()
		{
			this.DoSpawn();
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0014F320 File Offset: 0x0014D520
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
						if (gameObject.GetComponent<Rigidbody2D>() != null)
						{
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
						if (this.scaleMin != null && this.scaleMax != null)
						{
							float num4 = UnityEngine.Random.Range(this.scaleMin.Value, this.scaleMax.Value);
							if (num4 != 1f)
							{
								gameObject.transform.localScale = new Vector3(num4, num4, num4);
							}
						}
					}
				}
			}
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x0014F5F4 File Offset: 0x0014D7F4
		public SpawnRandomObjectsOverTimeV2()
		{
			this.scaleMin = 1f;
			this.scaleMax = 1f;
			base..ctor();
		}

		// Token: 0x04003C57 RID: 15447
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C58 RID: 15448
		[Tooltip("GameObject to spawn at (optional).")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C59 RID: 15449
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C5A RID: 15450
		[Tooltip("How often, in seconds, spawn occurs.")]
		public FsmFloat frequency;

		// Token: 0x04003C5B RID: 15451
		[Tooltip("Minimum amount of clones to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C5C RID: 15452
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C5D RID: 15453
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C5E RID: 15454
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C5F RID: 15455
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C60 RID: 15456
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C61 RID: 15457
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariationX;

		// Token: 0x04003C62 RID: 15458
		public FsmFloat originVariationY;

		// Token: 0x04003C63 RID: 15459
		[Tooltip("Minimum scale of clone.")]
		public FsmFloat scaleMin;

		// Token: 0x04003C64 RID: 15460
		[Tooltip("Maximum scale of clone.")]
		public FsmFloat scaleMax;

		// Token: 0x04003C65 RID: 15461
		private float vectorX;

		// Token: 0x04003C66 RID: 15462
		private float vectorY;

		// Token: 0x04003C67 RID: 15463
		private float timer;

		// Token: 0x04003C68 RID: 15464
		private bool originAdjusted;
	}
}
