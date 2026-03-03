using System;
using UnityEngine;

// Token: 0x020002C0 RID: 704
public class KeepInScene : MonoBehaviour
{
	// Token: 0x06000EEB RID: 3819 RVA: 0x000499F3 File Offset: 0x00047BF3
	private void Start()
	{
		this.gm = GameManager.instance;
		this.maxX = this.gm.sceneWidth;
		this.maxY = this.gm.sceneHeight;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x000499F3 File Offset: 0x00047BF3
	private void OnEnable()
	{
		this.gm = GameManager.instance;
		this.maxX = this.gm.sceneWidth;
		this.maxY = this.gm.sceneHeight;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00049A24 File Offset: 0x00047C24
	private void Update()
	{
		Vector3 position = base.transform.position;
		bool flag = false;
		if (position.x < this.minX)
		{
			position.x = this.minX;
			flag = true;
		}
		else if (position.x > this.maxX)
		{
			position.x = this.maxX;
			flag = true;
		}
		if (position.y < this.minY)
		{
			position.y = this.minY;
			flag = true;
		}
		else if (position.y > this.maxY)
		{
			position.y = this.maxY;
			flag = true;
		}
		if (flag)
		{
			base.transform.position = position;
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00049AC6 File Offset: 0x00047CC6
	public KeepInScene()
	{
		this.minY = -10f;
		base..ctor();
	}

	// Token: 0x04000FA9 RID: 4009
	private GameManager gm;

	// Token: 0x04000FAA RID: 4010
	private float minX;

	// Token: 0x04000FAB RID: 4011
	private float maxX;

	// Token: 0x04000FAC RID: 4012
	private float minY;

	// Token: 0x04000FAD RID: 4013
	private float maxY;
}
