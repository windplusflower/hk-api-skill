using System;
using UnityEngine;

// Token: 0x020001F2 RID: 498
public class BetaGateChanger : MonoBehaviour
{
	// Token: 0x06000AC4 RID: 2756 RVA: 0x00039BE0 File Offset: 0x00037DE0
	public void SwitchToBetaExit()
	{
		for (int i = 0; i < this.gates.Length; i++)
		{
			this.gates[i].targetScene = "BetaEnd";
		}
	}

	// Token: 0x04000BE2 RID: 3042
	public TransitionPoint[] gates;
}
