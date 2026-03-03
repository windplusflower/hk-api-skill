using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A65 RID: 2661
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a prefab Game Object from the Global Object Pool on the Game Manager.")]
	public class SpawnObjectFromGlobalPoolOverTimeV2 : FsmStateAction
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x0014EBA2 File Offset: 0x0014CDA2
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

		// Token: 0x06003975 RID: 14709 RVA: 0x0014EBE0 File Offset: 0x0014CDE0
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
						GameObject gameObject = this.gameObject.Value.Spawn(a, Quaternion.Euler(euler));
						if (this.scaleMin != null && this.scaleMax != null)
						{
							float num = UnityEngine.Random.Range(this.scaleMin.Value, this.scaleMax.Value);
							if (num != 1f)
							{
								gameObject.transform.localScale = new Vector3(num, num, num);
							}
						}
					}
				}
			}
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0014ED55 File Offset: 0x0014CF55
		public SpawnObjectFromGlobalPoolOverTimeV2()
		{
			this.scaleMin = 1f;
			this.scaleMax = 1f;
			base..ctor();
		}

		// Token: 0x04003C35 RID: 15413
		[RequiredField]
		[Tooltip("GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		// Token: 0x04003C36 RID: 15414
		[Tooltip("Optional Spawn Point.")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003C37 RID: 15415
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x04003C38 RID: 15416
		[Tooltip("Rotation. NOTE: Overrides the rotation of the Spawn Point.")]
		public FsmVector3 rotation;

		// Token: 0x04003C39 RID: 15417
		[Tooltip("How often, in seconds, spawn occurs.")]
		public FsmFloat frequency;

		// Token: 0x04003C3A RID: 15418
		[Tooltip("Minimum scale of clone.")]
		public FsmFloat scaleMin;

		// Token: 0x04003C3B RID: 15419
		[Tooltip("Maximum scale of clone.")]
		public FsmFloat scaleMax;

		// Token: 0x04003C3C RID: 15420
		private float timer;
	}
}
