using System;

namespace InControl
{
	// Token: 0x020006DC RID: 1756
	public enum InputControlType
	{
		// Token: 0x04002FF5 RID: 12277
		None,
		// Token: 0x04002FF6 RID: 12278
		LeftStickUp,
		// Token: 0x04002FF7 RID: 12279
		LeftStickDown,
		// Token: 0x04002FF8 RID: 12280
		LeftStickLeft,
		// Token: 0x04002FF9 RID: 12281
		LeftStickRight,
		// Token: 0x04002FFA RID: 12282
		LeftStickButton,
		// Token: 0x04002FFB RID: 12283
		RightStickUp,
		// Token: 0x04002FFC RID: 12284
		RightStickDown,
		// Token: 0x04002FFD RID: 12285
		RightStickLeft,
		// Token: 0x04002FFE RID: 12286
		RightStickRight,
		// Token: 0x04002FFF RID: 12287
		RightStickButton,
		// Token: 0x04003000 RID: 12288
		DPadUp,
		// Token: 0x04003001 RID: 12289
		DPadDown,
		// Token: 0x04003002 RID: 12290
		DPadLeft,
		// Token: 0x04003003 RID: 12291
		DPadRight,
		// Token: 0x04003004 RID: 12292
		LeftTrigger,
		// Token: 0x04003005 RID: 12293
		RightTrigger,
		// Token: 0x04003006 RID: 12294
		LeftBumper,
		// Token: 0x04003007 RID: 12295
		RightBumper,
		// Token: 0x04003008 RID: 12296
		Action1,
		// Token: 0x04003009 RID: 12297
		Action2,
		// Token: 0x0400300A RID: 12298
		Action3,
		// Token: 0x0400300B RID: 12299
		Action4,
		// Token: 0x0400300C RID: 12300
		Action5,
		// Token: 0x0400300D RID: 12301
		Action6,
		// Token: 0x0400300E RID: 12302
		Action7,
		// Token: 0x0400300F RID: 12303
		Action8,
		// Token: 0x04003010 RID: 12304
		Action9,
		// Token: 0x04003011 RID: 12305
		Action10,
		// Token: 0x04003012 RID: 12306
		Action11,
		// Token: 0x04003013 RID: 12307
		Action12,
		// Token: 0x04003014 RID: 12308
		Back = 100,
		// Token: 0x04003015 RID: 12309
		Start,
		// Token: 0x04003016 RID: 12310
		Select,
		// Token: 0x04003017 RID: 12311
		System,
		// Token: 0x04003018 RID: 12312
		Options,
		// Token: 0x04003019 RID: 12313
		Pause,
		// Token: 0x0400301A RID: 12314
		Menu,
		// Token: 0x0400301B RID: 12315
		Share,
		// Token: 0x0400301C RID: 12316
		Home,
		// Token: 0x0400301D RID: 12317
		View,
		// Token: 0x0400301E RID: 12318
		Power,
		// Token: 0x0400301F RID: 12319
		Capture,
		// Token: 0x04003020 RID: 12320
		Assistant,
		// Token: 0x04003021 RID: 12321
		Plus,
		// Token: 0x04003022 RID: 12322
		Minus,
		// Token: 0x04003023 RID: 12323
		Create,
		// Token: 0x04003024 RID: 12324
		Mute,
		// Token: 0x04003025 RID: 12325
		PedalLeft = 150,
		// Token: 0x04003026 RID: 12326
		PedalRight,
		// Token: 0x04003027 RID: 12327
		PedalMiddle,
		// Token: 0x04003028 RID: 12328
		GearUp,
		// Token: 0x04003029 RID: 12329
		GearDown,
		// Token: 0x0400302A RID: 12330
		Pitch = 200,
		// Token: 0x0400302B RID: 12331
		Roll,
		// Token: 0x0400302C RID: 12332
		Yaw,
		// Token: 0x0400302D RID: 12333
		ThrottleUp,
		// Token: 0x0400302E RID: 12334
		ThrottleDown,
		// Token: 0x0400302F RID: 12335
		ThrottleLeft,
		// Token: 0x04003030 RID: 12336
		ThrottleRight,
		// Token: 0x04003031 RID: 12337
		POVUp,
		// Token: 0x04003032 RID: 12338
		POVDown,
		// Token: 0x04003033 RID: 12339
		POVLeft,
		// Token: 0x04003034 RID: 12340
		POVRight,
		// Token: 0x04003035 RID: 12341
		TiltX = 250,
		// Token: 0x04003036 RID: 12342
		TiltY,
		// Token: 0x04003037 RID: 12343
		TiltZ,
		// Token: 0x04003038 RID: 12344
		ScrollWheel,
		// Token: 0x04003039 RID: 12345
		[Obsolete("Use InputControlType.TouchPadButton instead.", true)]
		TouchPadTap,
		// Token: 0x0400303A RID: 12346
		TouchPadButton,
		// Token: 0x0400303B RID: 12347
		TouchPadXAxis,
		// Token: 0x0400303C RID: 12348
		TouchPadYAxis,
		// Token: 0x0400303D RID: 12349
		LeftSL,
		// Token: 0x0400303E RID: 12350
		LeftSR,
		// Token: 0x0400303F RID: 12351
		RightSL,
		// Token: 0x04003040 RID: 12352
		RightSR,
		// Token: 0x04003041 RID: 12353
		Command = 300,
		// Token: 0x04003042 RID: 12354
		LeftStickX,
		// Token: 0x04003043 RID: 12355
		LeftStickY,
		// Token: 0x04003044 RID: 12356
		RightStickX,
		// Token: 0x04003045 RID: 12357
		RightStickY,
		// Token: 0x04003046 RID: 12358
		DPadX,
		// Token: 0x04003047 RID: 12359
		DPadY,
		// Token: 0x04003048 RID: 12360
		LeftCommand,
		// Token: 0x04003049 RID: 12361
		RightCommand,
		// Token: 0x0400304A RID: 12362
		Analog0 = 400,
		// Token: 0x0400304B RID: 12363
		Analog1,
		// Token: 0x0400304C RID: 12364
		Analog2,
		// Token: 0x0400304D RID: 12365
		Analog3,
		// Token: 0x0400304E RID: 12366
		Analog4,
		// Token: 0x0400304F RID: 12367
		Analog5,
		// Token: 0x04003050 RID: 12368
		Analog6,
		// Token: 0x04003051 RID: 12369
		Analog7,
		// Token: 0x04003052 RID: 12370
		Analog8,
		// Token: 0x04003053 RID: 12371
		Analog9,
		// Token: 0x04003054 RID: 12372
		Analog10,
		// Token: 0x04003055 RID: 12373
		Analog11,
		// Token: 0x04003056 RID: 12374
		Analog12,
		// Token: 0x04003057 RID: 12375
		Analog13,
		// Token: 0x04003058 RID: 12376
		Analog14,
		// Token: 0x04003059 RID: 12377
		Analog15,
		// Token: 0x0400305A RID: 12378
		Analog16,
		// Token: 0x0400305B RID: 12379
		Analog17,
		// Token: 0x0400305C RID: 12380
		Analog18,
		// Token: 0x0400305D RID: 12381
		Analog19,
		// Token: 0x0400305E RID: 12382
		Button0 = 500,
		// Token: 0x0400305F RID: 12383
		Button1,
		// Token: 0x04003060 RID: 12384
		Button2,
		// Token: 0x04003061 RID: 12385
		Button3,
		// Token: 0x04003062 RID: 12386
		Button4,
		// Token: 0x04003063 RID: 12387
		Button5,
		// Token: 0x04003064 RID: 12388
		Button6,
		// Token: 0x04003065 RID: 12389
		Button7,
		// Token: 0x04003066 RID: 12390
		Button8,
		// Token: 0x04003067 RID: 12391
		Button9,
		// Token: 0x04003068 RID: 12392
		Button10,
		// Token: 0x04003069 RID: 12393
		Button11,
		// Token: 0x0400306A RID: 12394
		Button12,
		// Token: 0x0400306B RID: 12395
		Button13,
		// Token: 0x0400306C RID: 12396
		Button14,
		// Token: 0x0400306D RID: 12397
		Button15,
		// Token: 0x0400306E RID: 12398
		Button16,
		// Token: 0x0400306F RID: 12399
		Button17,
		// Token: 0x04003070 RID: 12400
		Button18,
		// Token: 0x04003071 RID: 12401
		Button19,
		// Token: 0x04003072 RID: 12402
		Count
	}
}
