using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x020004D6 RID: 1238
public class DeactivateGameObjectPerBuildType : MonoBehaviour
{
	// Token: 0x06001B64 RID: 7012 RVA: 0x000835D8 File Offset: 0x000817D8
	private void OnEnable()
	{
		foreach (BuildTypes buildTypes in this.buildTypes)
		{
		}
	}

	// Token: 0x04002192 RID: 8594
	[SerializeField]
	private BuildTypes[] buildTypes;
}
