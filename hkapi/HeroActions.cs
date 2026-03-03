using System;
using InControl;

// Token: 0x020000F5 RID: 245
public class HeroActions : PlayerActionSet
{
	// Token: 0x06000522 RID: 1314 RVA: 0x0001B1F4 File Offset: 0x000193F4
	public HeroActions()
	{
		this.menuSubmit = base.CreatePlayerAction("Submit");
		this.menuCancel = base.CreatePlayerAction("Cancel");
		this.left = base.CreatePlayerAction("Left");
		this.left.StateThreshold = 0.3f;
		this.right = base.CreatePlayerAction("Right");
		this.right.StateThreshold = 0.3f;
		this.up = base.CreatePlayerAction("Up");
		this.up.StateThreshold = 0.5f;
		this.down = base.CreatePlayerAction("Down");
		this.down.StateThreshold = 0.5f;
		this.moveVector = base.CreateTwoAxisPlayerAction(this.left, this.right, this.down, this.up);
		this.moveVector.LowerDeadZone = 0.15f;
		this.moveVector.UpperDeadZone = 0.95f;
		this.rs_up = base.CreatePlayerAction("RS_Up");
		this.rs_up.StateThreshold = 0.5f;
		this.rs_down = base.CreatePlayerAction("RS_Down");
		this.rs_down.StateThreshold = 0.5f;
		this.rs_left = base.CreatePlayerAction("RS_Left");
		this.rs_left.StateThreshold = 0.3f;
		this.rs_right = base.CreatePlayerAction("RS_Right");
		this.rs_right.StateThreshold = 0.3f;
		this.rightStick = base.CreateTwoAxisPlayerAction(this.rs_left, this.rs_right, this.rs_down, this.rs_up);
		this.rightStick.LowerDeadZone = 0.15f;
		this.rightStick.UpperDeadZone = 0.95f;
		this.jump = base.CreatePlayerAction("Jump");
		this.attack = base.CreatePlayerAction("Attack");
		this.evade = base.CreatePlayerAction("Evade");
		this.dash = base.CreatePlayerAction("Dash");
		this.superDash = base.CreatePlayerAction("Super Dash");
		this.dreamNail = base.CreatePlayerAction("Dream Nail");
		this.cast = base.CreatePlayerAction("Cast");
		this.focus = base.CreatePlayerAction("Focus");
		this.quickMap = base.CreatePlayerAction("Quick Map");
		this.quickCast = base.CreatePlayerAction("Quick Cast");
		this.textSpeedup = base.CreatePlayerAction("TextSpeedup");
		this.skipCutscene = base.CreatePlayerAction("SkipCutscene");
		this.openInventory = base.CreatePlayerAction("openInventory");
		this.paneRight = base.CreatePlayerAction("Pane Right");
		this.paneLeft = base.CreatePlayerAction("Pane Left");
		this.pause = base.CreatePlayerAction("Pause");
	}

	// Token: 0x040004F6 RID: 1270
	public PlayerAction left;

	// Token: 0x040004F7 RID: 1271
	public PlayerAction right;

	// Token: 0x040004F8 RID: 1272
	public PlayerAction up;

	// Token: 0x040004F9 RID: 1273
	public PlayerAction down;

	// Token: 0x040004FA RID: 1274
	public PlayerAction menuSubmit;

	// Token: 0x040004FB RID: 1275
	public PlayerAction menuCancel;

	// Token: 0x040004FC RID: 1276
	public PlayerTwoAxisAction moveVector;

	// Token: 0x040004FD RID: 1277
	public PlayerAction rs_up;

	// Token: 0x040004FE RID: 1278
	public PlayerAction rs_down;

	// Token: 0x040004FF RID: 1279
	public PlayerAction rs_left;

	// Token: 0x04000500 RID: 1280
	public PlayerAction rs_right;

	// Token: 0x04000501 RID: 1281
	public PlayerTwoAxisAction rightStick;

	// Token: 0x04000502 RID: 1282
	public PlayerAction jump;

	// Token: 0x04000503 RID: 1283
	public PlayerAction evade;

	// Token: 0x04000504 RID: 1284
	public PlayerAction dash;

	// Token: 0x04000505 RID: 1285
	public PlayerAction superDash;

	// Token: 0x04000506 RID: 1286
	public PlayerAction dreamNail;

	// Token: 0x04000507 RID: 1287
	public PlayerAction attack;

	// Token: 0x04000508 RID: 1288
	public PlayerAction cast;

	// Token: 0x04000509 RID: 1289
	public PlayerAction focus;

	// Token: 0x0400050A RID: 1290
	public PlayerAction quickMap;

	// Token: 0x0400050B RID: 1291
	public PlayerAction quickCast;

	// Token: 0x0400050C RID: 1292
	public PlayerAction textSpeedup;

	// Token: 0x0400050D RID: 1293
	public PlayerAction skipCutscene;

	// Token: 0x0400050E RID: 1294
	public PlayerAction openInventory;

	// Token: 0x0400050F RID: 1295
	public PlayerAction paneRight;

	// Token: 0x04000510 RID: 1296
	public PlayerAction paneLeft;

	// Token: 0x04000511 RID: 1297
	public PlayerAction pause;
}
