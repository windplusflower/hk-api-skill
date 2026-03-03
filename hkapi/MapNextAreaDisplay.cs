using System;
using UnityEngine;

// Token: 0x0200047C RID: 1148
public class MapNextAreaDisplay : MonoBehaviour
{
	// Token: 0x060019C0 RID: 6592 RVA: 0x0007BFD4 File Offset: 0x0007A1D4
	private void OnEnable()
	{
		if (this.pd == null)
		{
			this.pd = GameManager.instance.playerData;
		}
		if (this.visitedString == "")
		{
			this.areaVisited = true;
		}
		if (!this.areaVisited)
		{
			this.areaVisited = this.pd.GetBool(this.visitedString);
		}
		if (this.activated)
		{
			if (!this.areaVisited || !this.gameMap.displayNextArea)
			{
				this.DeactivateChildren();
				return;
			}
		}
		else if (this.areaVisited && this.gameMap.displayNextArea)
		{
			this.ActivateChildren();
		}
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x0007C070 File Offset: 0x0007A270
	private void ActivateChildren()
	{
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(true);
			this.activated = true;
		}
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x0007C0D4 File Offset: 0x0007A2D4
	private void DeactivateChildren()
	{
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
			this.activated = false;
		}
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x0007C138 File Offset: 0x0007A338
	public MapNextAreaDisplay()
	{
		this.activated = true;
		base..ctor();
	}

	// Token: 0x04001F1E RID: 7966
	public GameMap gameMap;

	// Token: 0x04001F1F RID: 7967
	public string visitedString;

	// Token: 0x04001F20 RID: 7968
	private PlayerData pd;

	// Token: 0x04001F21 RID: 7969
	private bool activated;

	// Token: 0x04001F22 RID: 7970
	private bool areaVisited;
}
