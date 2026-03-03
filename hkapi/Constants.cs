using System;
using System.Reflection;
using GlobalEnums;
using InControl;
using UnityEngine;

// Token: 0x020004D4 RID: 1236
public static class Constants
{
	// Token: 0x06001B60 RID: 7008 RVA: 0x000833EC File Offset: 0x000815EC
	public static T GetConstantValue<T>(string variableName)
	{
		foreach (FieldInfo fieldInfo in typeof(Constants).GetFields(BindingFlags.Static | BindingFlags.Public))
		{
			if (fieldInfo.Name == variableName)
			{
				if (fieldInfo.FieldType == typeof(T))
				{
					return (T)((object)fieldInfo.GetRawConstantValue());
				}
				Debug.LogError(string.Format("Constants value was of type \"{0}\", expected type \"{1}\".", fieldInfo.FieldType.ToString(), typeof(T).ToString()));
			}
		}
		Debug.LogError("Couldn't find constant with name: " + variableName);
		return default(T);
	}

	// Token: 0x040020DA RID: 8410
	public const string GAME_VERSION = "1.5.78.11833";

	// Token: 0x040020DB RID: 8411
	public const float DEFAULT_TIMESCALE = 1f;

	// Token: 0x040020DC RID: 8412
	public const float HALF_TIMESCALE = 0.5f;

	// Token: 0x040020DD RID: 8413
	public const float PAUSED_TIMESCALE = 0f;

	// Token: 0x040020DE RID: 8414
	public const float FRAME_WAIT = 0.165f;

	// Token: 0x040020DF RID: 8415
	public const float TIME_SCALE_CHANGE_RATE = 1E-05f;

	// Token: 0x040020E0 RID: 8416
	public const float SCENE_TRANSITION_WAIT = 0.5f;

	// Token: 0x040020E1 RID: 8417
	public const float HERO_DEFAULT_GRAVITY = 0.79f;

	// Token: 0x040020E2 RID: 8418
	public const float HERO_UNDERWATER_GRAVITY = 0.225f;

	// Token: 0x040020E3 RID: 8419
	public const float RAYCAST_EXTENTS = 0.16f;

	// Token: 0x040020E4 RID: 8420
	public const float MIN_WALL_HEIGHT = 0.2f;

	// Token: 0x040020E5 RID: 8421
	public const float INPUT_LOWER_SNAP_V = 0.5f;

	// Token: 0x040020E6 RID: 8422
	public const float INPUT_LOWER_SNAP_H = 0.3f;

	// Token: 0x040020E7 RID: 8423
	public const float INPUT_UPPER_SNAP = 0.9f;

	// Token: 0x040020E8 RID: 8424
	public const float INPUT_DEADZONE_L = 0.15f;

	// Token: 0x040020E9 RID: 8425
	public const float INPUT_DEADZONE_U = 0.95f;

	// Token: 0x040020EA RID: 8426
	public const float CAM_Z_DEFAULT = -38.1f;

	// Token: 0x040020EB RID: 8427
	public const float CAM_BOUND_X = 14.6f;

	// Token: 0x040020EC RID: 8428
	public const float CAM_BOUND_Y = 8.3f;

	// Token: 0x040020ED RID: 8429
	public const float CAM_HOR_OFFSET_AMOUNT = 1f;

	// Token: 0x040020EE RID: 8430
	public const float CAM_FALL_VELOCITY = -20f;

	// Token: 0x040020EF RID: 8431
	public const float CAM_FALL_OFFSET = -4f;

	// Token: 0x040020F0 RID: 8432
	public const float CAM_LOOK_OFFSET = 6f;

	// Token: 0x040020F1 RID: 8433
	public const float CAM_START_LOCKED_TIMER = 0.5f;

	// Token: 0x040020F2 RID: 8434
	public const float CAM_HAZARD_RESPAWN_FROZEN = 0.5f;

	// Token: 0x040020F3 RID: 8435
	public const float CAM_MENU_X = 14.6f;

	// Token: 0x040020F4 RID: 8436
	public const float CAM_MENU_Y = 8.5f;

	// Token: 0x040020F5 RID: 8437
	public const float CAM_CIN_X = 14.6f;

	// Token: 0x040020F6 RID: 8438
	public const float CAM_CIN_Y = 8.5f;

	// Token: 0x040020F7 RID: 8439
	public const float CAM_CUT_X = 14.6f;

	// Token: 0x040020F8 RID: 8440
	public const float CAM_CUT_Y = 8.5f;

	// Token: 0x040020F9 RID: 8441
	public const float CAM_STAG_PRE_FADEOUT = 0.6f;

	// Token: 0x040020FA RID: 8442
	public const float CAM_FADE_TIME_JUST_FADE = 0.5f;

	// Token: 0x040020FB RID: 8443
	public const float CAM_FADE_TIME_START_FADE = 2.3f;

	// Token: 0x040020FC RID: 8444
	public const float CAM_DEFAULT_BLUR_DEPTH = 6.62f;

	// Token: 0x040020FD RID: 8445
	public const float CAM_DEFAULT_SATURATION = 0.7f;

	// Token: 0x040020FE RID: 8446
	public const float CAM_DEFAULT_INTENSITY = 0.7f;

	// Token: 0x040020FF RID: 8447
	public const float MIN_VIEW_DEPTH = 10f;

	// Token: 0x04002100 RID: 8448
	public const float MAX_VIEW_DEPTH = 1000f;

	// Token: 0x04002101 RID: 8449
	public const float CAM_OVERLAP = 1E-05f;

	// Token: 0x04002102 RID: 8450
	public const float CAM_ORTHOSIZE = 8.710664f;

	// Token: 0x04002103 RID: 8451
	public const float CAM_GAME_ASPECT = 1.7777778f;

	// Token: 0x04002104 RID: 8452
	public const float CAM_CANVAS_MOVE_WAIT = 0.5f;

	// Token: 0x04002105 RID: 8453
	public const string CAM_SHAKE_ENEMYKILL = "EnemyKillShake";

	// Token: 0x04002106 RID: 8454
	public const float SCENE_POSITION_LIMIT = 60f;

	// Token: 0x04002107 RID: 8455
	public const float SCENE_BORDER_THICKNESS = 20f;

	// Token: 0x04002108 RID: 8456
	public const string MENU_SCENE = "Menu_Title";

	// Token: 0x04002109 RID: 8457
	public const string FIRST_LEVEL_NAME = "Tutorial_01";

	// Token: 0x0400210A RID: 8458
	public const string STARTING_SCENE = "Opening_Sequence";

	// Token: 0x0400210B RID: 8459
	public const string INTRO_PROLOGUE = "Intro_Cutscene_Prologue";

	// Token: 0x0400210C RID: 8460
	public const string OPENING_CUTSCENE = "Intro_Cutscene";

	// Token: 0x0400210D RID: 8461
	public const string STAG_CINEMATIC = "Cinematic_Stag_travel";

	// Token: 0x0400210E RID: 8462
	public const string PERMADEATH_LEVEL = "PermaDeath";

	// Token: 0x0400210F RID: 8463
	public const string PERMADEATH_UNLOCK = "PermaDeath_Unlock";

	// Token: 0x04002110 RID: 8464
	public const string MRMUSHROOM_CINEMATIC = "Cinematic_MrMushroom";

	// Token: 0x04002111 RID: 8465
	public const string ENDING_A_CINEMATIC = "Cinematic_Ending_A";

	// Token: 0x04002112 RID: 8466
	public const string ENDING_B_CINEMATIC = "Cinematic_Ending_B";

	// Token: 0x04002113 RID: 8467
	public const string ENDING_C_CINEMATIC = "Cinematic_Ending_C";

	// Token: 0x04002114 RID: 8468
	public const string ENDING_D_CINEMATIC = "Cinematic_Ending_D";

	// Token: 0x04002115 RID: 8469
	public const string ENDING_E_CINEMATIC = "Cinematic_Ending_E";

	// Token: 0x04002116 RID: 8470
	public const string END_CREDITS = "End_Credits";

	// Token: 0x04002117 RID: 8471
	public const string MENU_CREDITS = "Menu_Credits";

	// Token: 0x04002118 RID: 8472
	public const string TITLE_SCREEN_LEVEL = "Title_Screens";

	// Token: 0x04002119 RID: 8473
	public const string TUTORIAL_LEVEL = "Tutorial_01";

	// Token: 0x0400211A RID: 8474
	public const string BOSS_DOOR_CUTSCENE = "Cutscene_Boss_Door";

	// Token: 0x0400211B RID: 8475
	public const string GAME_COMPLETION_SCREEN = "End_Game_Completion";

	// Token: 0x0400211C RID: 8476
	public const string BOSSRUSH_END_SCENE = "GG_End_Sequence";

	// Token: 0x0400211D RID: 8477
	public const string GG_ENTRANCE_SCENE = "GG_Entrance_Cutscene";

	// Token: 0x0400211E RID: 8478
	public const string GG_DOOR_ENTRANCE_SCENE = "GG_Boss_Door_Entrance";

	// Token: 0x0400211F RID: 8479
	public const string GG_RETURN_SCENE = "GG_Waterways";

	// Token: 0x04002120 RID: 8480
	public const string SAVE_ICON_START_EVENT = "GAME SAVING";

	// Token: 0x04002121 RID: 8481
	public const string SAVE_ICON_END_EVENT = "GAME SAVED";

	// Token: 0x04002122 RID: 8482
	public const float HERO_Z = 0.004f;

	// Token: 0x04002123 RID: 8483
	public const float HAZARD_DEATH_WAIT = 0f;

	// Token: 0x04002124 RID: 8484
	public const float RESPAWN_FADEOUT_WAIT = 0.8f;

	// Token: 0x04002125 RID: 8485
	public const float HAZ_RESPAWN_FADEIN_WAIT = 0.1f;

	// Token: 0x04002126 RID: 8486
	public const float SCENE_ENTER_WAIT = 0.33f;

	// Token: 0x04002127 RID: 8487
	public const float HERO_MIN_FALL_VEL = -1E-06f;

	// Token: 0x04002128 RID: 8488
	public const float ASPECT_16_9 = 1.777778f;

	// Token: 0x04002129 RID: 8489
	public const float ASPECT_16_10 = 1.777778f;

	// Token: 0x0400212A RID: 8490
	public const float CUTSCENE_PROMPT_TIMEOUT = 5f;

	// Token: 0x0400212B RID: 8491
	public const float CUTSCENE_PROMPT_SKIP_COOLDOWN = 0.3f;

	// Token: 0x0400212C RID: 8492
	public const float SAVE_FLEUR_PAUSE = 0.2f;

	// Token: 0x0400212D RID: 8493
	public const string RECORD_PERMADEATH_MODE = "RecPermadeathMode";

	// Token: 0x0400212E RID: 8494
	public const string RECORD_BOSSRUSH_MODE = "RecBossRushMode";

	// Token: 0x0400212F RID: 8495
	public const SupportedLanguages DEFAULT_LANGUAGE = SupportedLanguages.EN;

	// Token: 0x04002130 RID: 8496
	public const int DEFAULT_BACKERCREDITS = 0;

	// Token: 0x04002131 RID: 8497
	public const int DEFAULT_NATIVEPOPUPS = 0;

	// Token: 0x04002132 RID: 8498
	public const bool DEFAULT_NATIVEINPUT = true;

	// Token: 0x04002133 RID: 8499
	public const float MM_AUDIO_MASTER_VOL = 10f;

	// Token: 0x04002134 RID: 8500
	public const float MM_AUDIO_MUSIC_VOL = 10f;

	// Token: 0x04002135 RID: 8501
	public const float MM_AUDIO_SOUND_VOL = 10f;

	// Token: 0x04002136 RID: 8502
	public const int MM_VIDEO_RESX = 1920;

	// Token: 0x04002137 RID: 8503
	public const int MM_VIDEO_RESY = 1080;

	// Token: 0x04002138 RID: 8504
	public const int MM_VIDEO_REFRESH = 60;

	// Token: 0x04002139 RID: 8505
	public const int MM_VIDEO_FULLSCREEN = 2;

	// Token: 0x0400213A RID: 8506
	public const int MM_VIDEO_VSYNC = 0;

	// Token: 0x0400213B RID: 8507
	public const int DEFAULT_VIDEO_FRAMECAP = 400;

	// Token: 0x0400213C RID: 8508
	public const bool DEFAULT_VIDEO_FRAMECAP_ON = true;

	// Token: 0x0400213D RID: 8509
	public const int DEFAULT_DISPLAY = 0;

	// Token: 0x0400213E RID: 8510
	public const int DEFAULT_VIDEO_PARTICLES = 1;

	// Token: 0x0400213F RID: 8511
	public const ShaderQualities DEFAULT_VIDEO_SHADER_QUALITY = ShaderQualities.Medium;

	// Token: 0x04002140 RID: 8512
	public const ShaderQualities NEW_PLAYER_DEFAULT_VIDEO_SHADER_QUALITY = ShaderQualities.Medium;

	// Token: 0x04002141 RID: 8513
	public const ShaderQualities EXISTING_PLAYER_VIDEO_SHADER_QUALITY = ShaderQualities.High;

	// Token: 0x04002142 RID: 8514
	public const float MM_OS_MAINCAM = 1f;

	// Token: 0x04002143 RID: 8515
	public const float MM_OS_HUDCAM = 8.710664f;

	// Token: 0x04002144 RID: 8516
	public const float MM_OS_DEFAULT = 0f;

	// Token: 0x04002145 RID: 8517
	public const float DEFAULT_BRIGHTNESS = 20f;

	// Token: 0x04002146 RID: 8518
	public const GamepadType MM_INPUTTYPE = GamepadType.NONE;

	// Token: 0x04002147 RID: 8519
	public const ControllerProfile MM_INPUTPROFILE = ControllerProfile.Default;

	// Token: 0x04002148 RID: 8520
	public const Key DEFAULT_KEY_JUMP = Key.Z;

	// Token: 0x04002149 RID: 8521
	public const Key DEFAULT_KEY_ATTACK = Key.X;

	// Token: 0x0400214A RID: 8522
	public const Key DEFAULT_KEY_DASH = Key.C;

	// Token: 0x0400214B RID: 8523
	public const Key DEFAULT_KEY_CAST = Key.A;

	// Token: 0x0400214C RID: 8524
	public const Key DEFAULT_KEY_SUPERDASH = Key.S;

	// Token: 0x0400214D RID: 8525
	public const Key DEFAULT_KEY_DREAMNAIL = Key.D;

	// Token: 0x0400214E RID: 8526
	public const Key DEFAULT_KEY_QUICKMAP = Key.Tab;

	// Token: 0x0400214F RID: 8527
	public const Key DEFAULT_KEY_QUICKCAST = Key.F;

	// Token: 0x04002150 RID: 8528
	public const Key DEFAULT_KEY_INVENTORY = Key.I;

	// Token: 0x04002151 RID: 8529
	public const Key DEFAULT_KEY_UP = Key.UpArrow;

	// Token: 0x04002152 RID: 8530
	public const Key DEFAULT_KEY_DOWN = Key.DownArrow;

	// Token: 0x04002153 RID: 8531
	public const Key DEFAULT_KEY_LEFT = Key.LeftArrow;

	// Token: 0x04002154 RID: 8532
	public const Key DEFAULT_KEY_RIGHT = Key.RightArrow;

	// Token: 0x04002155 RID: 8533
	public const InputControlType BUTTON_DEFAULT_JUMP = InputControlType.Action1;

	// Token: 0x04002156 RID: 8534
	public const InputControlType BUTTON_DEFAULT_ATTACK = InputControlType.Action3;

	// Token: 0x04002157 RID: 8535
	public const InputControlType BUTTON_DEFAULT_CAST = InputControlType.Action2;

	// Token: 0x04002158 RID: 8536
	public const InputControlType BUTTON_DEFAULT_DASH = InputControlType.RightTrigger;

	// Token: 0x04002159 RID: 8537
	public const InputControlType BUTTON_DEFAULT_SUPERDASH = InputControlType.LeftTrigger;

	// Token: 0x0400215A RID: 8538
	public const InputControlType BUTTON_DEFAULT_DREAMNAIL = InputControlType.Action4;

	// Token: 0x0400215B RID: 8539
	public const InputControlType BUTTON_DEFAULT_QUICKMAP = InputControlType.LeftBumper;

	// Token: 0x0400215C RID: 8540
	public const InputControlType BUTTON_DEFAULT_QUICKCAST = InputControlType.RightBumper;

	// Token: 0x0400215D RID: 8541
	public const InputControlType BUTTON_DEFAULT_INVENTORY = InputControlType.Back;

	// Token: 0x0400215E RID: 8542
	public const InputControlType BUTTON_DEFAULT_PS4_INVENTORY = InputControlType.TouchPadButton;

	// Token: 0x0400215F RID: 8543
	public const InputControlType BUTTON_DEFAULT_PS4_PAUSE = InputControlType.Options;

	// Token: 0x04002160 RID: 8544
	public const InputControlType BUTTON_DEFAULT_XBONE_INVENTORY = InputControlType.View;

	// Token: 0x04002161 RID: 8545
	public const InputControlType BUTTON_DEFAULT_XBONE_PAUSE = InputControlType.Menu;

	// Token: 0x04002162 RID: 8546
	public const InputControlType BUTTON_DEFAULT_PS3_WIN_INVENTORY = InputControlType.Select;

	// Token: 0x04002163 RID: 8547
	public const InputControlType BUTTON_DEFAULT_SWITCH_INVENTORY = InputControlType.Select;

	// Token: 0x04002164 RID: 8548
	public const InputControlType BUTTON_DEFAULT_SWITCH_PAUSE = InputControlType.Start;

	// Token: 0x04002165 RID: 8549
	public const InputControlType BUTTON_DEFAULT_UNKNOWN_INVENTORY = InputControlType.Select;

	// Token: 0x04002166 RID: 8550
	public const string GSKEY_GAME_LANGUAGE = "GameLang";

	// Token: 0x04002167 RID: 8551
	public const string GSKEY_GAME_BACKERS = "GameBackers";

	// Token: 0x04002168 RID: 8552
	public const string GSKEY_GAME_POPUPS = "GameNativePopups";

	// Token: 0x04002169 RID: 8553
	public const string GSKEY_RUMBLE_MUTED = "RumbleMuted";

	// Token: 0x0400216A RID: 8554
	public const string GSKEY_VIDEO_RESX = "VidResX";

	// Token: 0x0400216B RID: 8555
	public const string GSKEY_VIDEO_RESY = "VidResY";

	// Token: 0x0400216C RID: 8556
	public const string GSKEY_VIDEO_REFRESH = "VidResRefresh";

	// Token: 0x0400216D RID: 8557
	public const string GSKEY_VIDEO_FULLSCREEN = "VidFullscreen";

	// Token: 0x0400216E RID: 8558
	public const string GSKEY_VIDEO_VSYNC = "VidVSync";

	// Token: 0x0400216F RID: 8559
	public const string GSKEY_VIDEO_DISPLAY = "VidDisplay";

	// Token: 0x04002170 RID: 8560
	public const string GSKEY_VIDEO_TFR = "VidTFR";

	// Token: 0x04002171 RID: 8561
	public const string GSKEY_VIDEO_FRAMECAP = "VidFC";

	// Token: 0x04002172 RID: 8562
	public const string GSKEY_VIDEO_PARTICLES = "VidParticles";

	// Token: 0x04002173 RID: 8563
	public const string GSKEY_VIDEO_SHADER_QUALITY = "ShaderQuality";

	// Token: 0x04002174 RID: 8564
	public const string GSKEY_OS_VALUE = "VidOSValue";

	// Token: 0x04002175 RID: 8565
	public const string GSKEY_OS_SET = "VidOSSet";

	// Token: 0x04002176 RID: 8566
	public const string GSKEY_BRIGHT_VALUE = "VidBrightValue";

	// Token: 0x04002177 RID: 8567
	public const string GSKEY_BRIGHT_SET = "VidBrightSet";

	// Token: 0x04002178 RID: 8568
	public const string GSKEY_AUDIO_MASTER = "MasterVolume";

	// Token: 0x04002179 RID: 8569
	public const string GSKEY_AUDIO_MUSIC = "MusicVolume";

	// Token: 0x0400217A RID: 8570
	public const string GSKEY_AUDIO_SOUND = "SoundVolume";

	// Token: 0x0400217B RID: 8571
	public const string GSKEY_KEY_JUMP = "KeyJump";

	// Token: 0x0400217C RID: 8572
	public const string GSKEY_KEY_ATTACK = "KeyAttack";

	// Token: 0x0400217D RID: 8573
	public const string GSKEY_KEY_DASH = "KeyDash";

	// Token: 0x0400217E RID: 8574
	public const string GSKEY_KEY_CAST = "KeyCast";

	// Token: 0x0400217F RID: 8575
	public const string GSKEY_KEY_SUPERDASH = "KeySupDash";

	// Token: 0x04002180 RID: 8576
	public const string GSKEY_KEY_DREAMNAIL = "KeyDreamnail";

	// Token: 0x04002181 RID: 8577
	public const string GSKEY_KEY_QUICKMAP = "KeyQuickMap";

	// Token: 0x04002182 RID: 8578
	public const string GSKEY_KEY_QUICKCAST = "KeyQuickCast";

	// Token: 0x04002183 RID: 8579
	public const string GSKEY_KEY_INVENTORY = "KeyInventory";

	// Token: 0x04002184 RID: 8580
	public const string GSKEY_KEY_UP = "KeyUp";

	// Token: 0x04002185 RID: 8581
	public const string GSKEY_KEY_DOWN = "KeyDown";

	// Token: 0x04002186 RID: 8582
	public const string GSKEY_KEY_LEFT = "KeyLeft";

	// Token: 0x04002187 RID: 8583
	public const string GSKEY_KEY_RIGHT = "KeyRight";

	// Token: 0x04002188 RID: 8584
	public const string GSKEY_CONTROLLER_PREFIX = "Controller";

	// Token: 0x04002189 RID: 8585
	public const string GSKEY_LANG_SET = "GameLangSet";

	// Token: 0x0400218A RID: 8586
	public const string GSKEY_NATIVE_INPUT = "NativeInput";

	// Token: 0x0400218B RID: 8587
	public const string COMM_ARG_RESETALL = "-resetall";

	// Token: 0x0400218C RID: 8588
	public const string COMM_ARG_RESETRES = "-resetres";

	// Token: 0x0400218D RID: 8589
	public const string COMM_ARG_ALLOWLANG = "-forcelang";

	// Token: 0x0400218E RID: 8590
	public const string COMM_ARG_DEBUGKEYS = "-allowdebug";

	// Token: 0x0400218F RID: 8591
	public const string COMM_ARG_NATIVEINPUT = "-nativeinput";
}
