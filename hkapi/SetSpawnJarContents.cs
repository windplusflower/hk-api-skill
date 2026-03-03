using System;
using HutongGames.PlayMaker;

// Token: 0x020002BD RID: 701
[ActionCategory("Hollow Knight")]
public class SetSpawnJarContents : FsmStateAction
{
	// Token: 0x06000EE0 RID: 3808 RVA: 0x000498A2 File Offset: 0x00047AA2
	public override void Reset()
	{
		this.storedObject = null;
		this.enemyPrefab = null;
		this.enemyHealth = null;
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x000498BC File Offset: 0x00047ABC
	public override void OnEnter()
	{
		if (this.storedObject.Value)
		{
			SpawnJarControl component = this.storedObject.Value.GetComponent<SpawnJarControl>();
			if (component)
			{
				component.SetEnemySpawn(this.enemyPrefab.Value, this.enemyHealth.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000FA3 RID: 4003
	[RequiredField]
	[UIHint(UIHint.Variable)]
	public FsmGameObject storedObject;

	// Token: 0x04000FA4 RID: 4004
	public FsmGameObject enemyPrefab;

	// Token: 0x04000FA5 RID: 4005
	public FsmInt enemyHealth;
}
