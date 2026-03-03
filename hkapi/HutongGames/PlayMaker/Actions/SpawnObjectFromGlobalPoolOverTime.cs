using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A64 RID: 2660
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a prefab Game Object from the Global Object Pool on the Game Manager.")]
	public class SpawnObjectFromGlobalPoolOverTime : FsmStateAction
	{
		// Token: 0x06003971 RID: 14705 RVA: 0x0014EA39 File Offset: 0x0014CC39
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
			this.frequency = null;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0014EA74 File Offset: 0x0014CC74
		public override void OnUpdate()
		{
			this.timer += Time.deltaTime;
			if (this.timer >= this.frequency.Value)
			{
				this.timer = 0f;
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
						this.gameObject.Value.Spawn(a, Quaternion.Euler(euler));
					}
				}
			}
		}

		// Token: 0x04003C2F RID: 15407
		[RequiredField]
		[Tooltip("GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C30 RID: 15408
		[Tooltip("Optional Spawn Point.")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C31 RID: 15409
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C32 RID: 15410
		[Tooltip("Rotation. NOTE: Overrides the rotation of the Spawn Point.")]
		public FsmVector3 rotation;

		// Token: 0x04003C33 RID: 15411
		[Tooltip("How often, in seconds, spawn occurs.")]
		public FsmFloat frequency;

		// Token: 0x04003C34 RID: 15412
		private float timer;
	}
}
