using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x0200044B RID: 1099
[Serializable]
public class ControllerImage
{
	// Token: 0x060018AF RID: 6319 RVA: 0x00073AFB File Offset: 0x00071CFB
	public ControllerImage()
	{
		this.displayScale = 1f;
		this.canRemap = true;
		base..ctor();
	}

	// Token: 0x04001DA4 RID: 7588
	[SerializeField]
	public string name;

	// Token: 0x04001DA5 RID: 7589
	[SerializeField]
	public GamepadType gamepadType;

	// Token: 0x04001DA6 RID: 7590
	[SerializeField]
	public Sprite sprite;

	// Token: 0x04001DA7 RID: 7591
	[SerializeField]
	public ControllerButtonPositions buttonPositions;

	// Token: 0x04001DA8 RID: 7592
	public float displayScale;

	// Token: 0x04001DA9 RID: 7593
	public float offsetY;

	// Token: 0x04001DAA RID: 7594
	public bool canRemap;
}
