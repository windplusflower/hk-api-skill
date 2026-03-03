using System;
using GlobalEnums;
using InControl;

// Token: 0x020002A4 RID: 676
[Serializable]
public class ControllerMapping
{
	// Token: 0x06000E22 RID: 3618 RVA: 0x0004553C File Offset: 0x0004373C
	public ControllerMapping()
	{
		this.jump = InputControlType.Action1;
		this.attack = InputControlType.Action3;
		this.dash = InputControlType.RightTrigger;
		this.cast = InputControlType.Action2;
		this.superDash = InputControlType.LeftTrigger;
		this.dreamNail = InputControlType.Action4;
		this.quickMap = InputControlType.LeftBumper;
		this.quickCast = InputControlType.RightBumper;
		base..ctor();
	}

	// Token: 0x04000EF5 RID: 3829
	public GamepadType gamepadType;

	// Token: 0x04000EF6 RID: 3830
	public InputControlType jump;

	// Token: 0x04000EF7 RID: 3831
	public InputControlType attack;

	// Token: 0x04000EF8 RID: 3832
	public InputControlType dash;

	// Token: 0x04000EF9 RID: 3833
	public InputControlType cast;

	// Token: 0x04000EFA RID: 3834
	public InputControlType superDash;

	// Token: 0x04000EFB RID: 3835
	public InputControlType dreamNail;

	// Token: 0x04000EFC RID: 3836
	public InputControlType quickMap;

	// Token: 0x04000EFD RID: 3837
	public InputControlType quickCast;
}
