using System;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class Turret : MonoBehaviour
{
	// Token: 0x06000070 RID: 112 RVA: 0x00003603 File Offset: 0x00001803
	private void Awake()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003D80 File Offset: 0x00001F80
	private void Update()
	{
		Plane plane = new Plane(Vector3.up, base.transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distance;
		if (plane.Raycast(ray, out distance))
		{
			Quaternion to = Quaternion.LookRotation(Vector3.Normalize(ray.GetPoint(distance) - base.transform.position));
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, to, 360f * Time.deltaTime);
			if (Input.GetMouseButtonDown(0))
			{
				this.bulletPrefab.Spawn(this.gun.position, this.gun.rotation);
			}
			if (Input.GetMouseButtonDown(1))
			{
				this.testPrefab.Spawn(this.gun.position, this.gun.rotation);
			}
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.bulletPrefab.DestroyPooled<Bullet>();
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			this.bulletPrefab.DestroyAll<Bullet>();
		}
	}

	// Token: 0x0400005D RID: 93
	public Bullet bulletPrefab;

	// Token: 0x0400005E RID: 94
	public Transform gun;

	// Token: 0x0400005F RID: 95
	public GameObject testPrefab;
}
