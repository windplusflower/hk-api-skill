using System;
using System.Collections;
using GlobalEnums;
using InControl;
using UnityEngine;

// Token: 0x020000EA RID: 234
public class CheatManager : MonoBehaviour
{
	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00019462 File Offset: 0x00017662
	public static bool IsCheatsEnabled
	{
		get
		{
			return (Application.platform == RuntimePlatform.Switch || Application.platform == RuntimePlatform.PS4 || Application.platform == RuntimePlatform.XboxOne || Application.platform == RuntimePlatform.WindowsEditor) && (Debug.isDebugBuild || CommandLineArguments.EnableDeveloperCheats);
		}
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00019497 File Offset: 0x00017697
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		if (!CheatManager.IsCheatsEnabled)
		{
			return;
		}
		UnityEngine.Object.DontDestroyOnLoad(new GameObject("CheatManager", new Type[]
		{
			typeof(CheatManager)
		}));
		PerformanceHUD.Init();
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000194C8 File Offset: 0x000176C8
	public static bool IsInstaKillEnabled
	{
		get
		{
			return CheatManager.instance && CheatManager.instance.isInstaKillEnabled;
		}
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x000194E2 File Offset: 0x000176E2
	protected IEnumerator Start()
	{
		CheatManager.instance = this;
		for (;;)
		{
			yield return new WaitForSeconds(4f);
			if (this.isRegenerating)
			{
				GameManager unsafeInstance = GameManager.UnsafeInstance;
				if (unsafeInstance != null)
				{
					HeroController hero_ctrl = unsafeInstance.hero_ctrl;
					if (hero_ctrl != null)
					{
						hero_ctrl.AddHealth(Mathf.Clamp(unsafeInstance.playerData.GetInt("maxHealth") - unsafeInstance.playerData.GetInt("health"), 0, 1));
						hero_ctrl.AddMPCharge(Mathf.Clamp(unsafeInstance.playerData.GetInt("maxMP") - unsafeInstance.playerData.GetInt("MPCharge"), 0, 20));
					}
				}
			}
		}
		yield break;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x000194F1 File Offset: 0x000176F1
	private void OnDestroy()
	{
		if (CheatManager.instance == this)
		{
			CheatManager.instance = null;
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00019508 File Offset: 0x00017708
	protected void Update()
	{
		if (InputManager.ActiveDevice.LeftStickButton.IsPressed || Input.GetKey(KeyCode.Home))
		{
			this.slowOpenLeftStickTimer += Time.unscaledDeltaTime;
		}
		else
		{
			this.slowOpenLeftStickTimer = 0f;
		}
		if (InputManager.ActiveDevice.RightStickButton.IsPressed || Input.GetKey(KeyCode.End))
		{
			this.slowOpenRightStickTimer += Time.unscaledDeltaTime;
		}
		else
		{
			this.slowOpenRightStickTimer = 0f;
		}
		bool flag = this.slowOpenLeftStickTimer > 5f && this.slowOpenRightStickTimer > 5f;
		bool flag2 = InputManager.ActiveDevice.LeftStickButton.WasPressed || Input.GetKeyDown(KeyCode.Home);
		if ((this.wasEverOpened && flag2) || (!this.wasEverOpened && flag))
		{
			this.ToggleCheatMenu();
			if (PerformanceHUD.Shared != null)
			{
				PerformanceHUD.Shared.enabled = true;
			}
		}
		if (this.isQuickHealEnabled && (InputManager.ActiveDevice.RightStickButton.WasPressed || Input.GetKeyDown(KeyCode.End)))
		{
			this.Restore();
		}
		if (this.isInstaDeathEnabled && InputManager.ActiveDevice.RightStickButton.WasPressed)
		{
			this.Kill();
		}
		this.selectCooldown -= Time.unscaledDeltaTime;
		if (!string.IsNullOrEmpty(this.transitionRobotStartScene))
		{
			HeroController heroController = HeroController.instance;
			GameManager unsafeInstance = GameManager.UnsafeInstance;
			if (heroController != null && unsafeInstance != null && heroController.transitionState == HeroTransitionState.WAITING_TO_TRANSITION && Time.timeScale > Mathf.Epsilon)
			{
				if (unsafeInstance.sceneName == this.transitionRobotStartScene)
				{
					if (!heroController.cState.recoilingLeft)
					{
						heroController.RecoilLeft();
						return;
					}
				}
				else if (!heroController.cState.recoilingRight)
				{
					heroController.RecoilRight();
				}
			}
		}
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x000196D7 File Offset: 0x000178D7
	private void ToggleCheatMenu()
	{
		this.isOpen = !this.isOpen;
		this.safetyCounter = 0;
		if (this.isOpen)
		{
			this.wasEverOpened = true;
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00019700 File Offset: 0x00017900
	protected void OnGUI()
	{
		if (!this.isOpen)
		{
			return;
		}
		int num = 0;
		if (this.CheatButton(ref num, "Resume"))
		{
			this.isOpen = false;
		}
		if (this.CheatButton(ref num, "Restore HP/MP"))
		{
			this.Restore();
			this.isOpen = false;
		}
		if (this.CheatButton(ref num, (this.isRegenerating ? "Disable" : "Enable") + " Regen"))
		{
			this.isRegenerating = !this.isRegenerating;
			this.isOpen = false;
		}
		if (this.CheatButton(ref num, "Get Geo"))
		{
			this.GetGeo(100);
		}
		if (PerformanceHUD.Shared != null && this.CheatButton(ref num, "Hide Performance HUD"))
		{
			PerformanceHUD.Shared.enabled = false;
			this.isOpen = false;
		}
		if (this.SafetyCheatButton(ref num, "All Stags"))
		{
			CheatManager.OpenStagStations();
		}
		if (this.CheatButton(ref num, (CheatManager.IsInstaKillEnabled ? "Disable" : "Enable") + " Insta Kill"))
		{
			this.isInstaKillEnabled = !this.isInstaKillEnabled;
		}
		PlayerData playerData = PlayerData.instance;
		if (playerData != null)
		{
			if (this.CheatButton(ref num, (playerData.GetBool("isInvincible") ? "Disable" : "Enable") + " Invincibility"))
			{
				playerData.SetBoolSwappedArgs(!playerData.GetBool("isInvincible"), "isInvincible");
			}
			if (this.CheatButton(ref num, (playerData.GetBool("invinciTest") ? "Disable" : "Enable") + " Test Invincibility"))
			{
				playerData.SetBoolSwappedArgs(!playerData.GetBool("invinciTest"), "invinciTest");
			}
			if (this.SafetyCheatButton(ref num, "Fireball"))
			{
				if (!playerData.GetBool("hasSpell"))
				{
					playerData.SetBoolSwappedArgs(true, "hasSpell");
				}
				playerData.SetIntSwappedArgs(Mathf.Min(playerData.GetInt("fireballLevel") + 1, 2), "fireballLevel");
			}
			if (this.SafetyCheatButton(ref num, "Quake"))
			{
				if (!playerData.GetBool("hasSpell"))
				{
					playerData.SetBoolSwappedArgs(true, "hasSpell");
				}
				playerData.SetIntSwappedArgs(Mathf.Min(playerData.GetInt("quakeLevel") + 1, 2), "quakeLevel");
			}
			if (this.SafetyCheatButton(ref num, "Scream"))
			{
				if (!playerData.GetBool("hasSpell"))
				{
					playerData.SetBoolSwappedArgs(true, "hasSpell");
				}
				playerData.SetIntSwappedArgs(Mathf.Min(playerData.GetInt("screamLevel") + 1, 2), "screamLevel");
			}
			if (this.SafetyCheatButton(ref num, "Double Jump"))
			{
				playerData.SetBoolSwappedArgs(true, "hasDoubleJump");
			}
			if (this.SafetyCheatButton(ref num, "All Charms"))
			{
				playerData.SetBoolSwappedArgs(true, "hasCharm");
				playerData.SetBoolSwappedArgs(true, "gotCharm_1");
				playerData.SetBoolSwappedArgs(true, "gotCharm_2");
				playerData.SetBoolSwappedArgs(true, "gotCharm_3");
				playerData.SetBoolSwappedArgs(true, "gotCharm_4");
				playerData.SetBoolSwappedArgs(true, "gotCharm_5");
				playerData.SetBoolSwappedArgs(true, "gotCharm_6");
				playerData.SetBoolSwappedArgs(true, "gotCharm_7");
				playerData.SetBoolSwappedArgs(true, "gotCharm_8");
				playerData.SetBoolSwappedArgs(true, "gotCharm_9");
				playerData.SetBoolSwappedArgs(true, "gotCharm_10");
				playerData.SetBoolSwappedArgs(true, "gotCharm_11");
				playerData.SetBoolSwappedArgs(true, "gotCharm_12");
				playerData.SetBoolSwappedArgs(true, "gotCharm_13");
				playerData.SetBoolSwappedArgs(true, "gotCharm_14");
				playerData.SetBoolSwappedArgs(true, "gotCharm_15");
				playerData.SetBoolSwappedArgs(true, "gotCharm_16");
				playerData.SetBoolSwappedArgs(true, "gotCharm_17");
				playerData.SetBoolSwappedArgs(true, "gotCharm_18");
				playerData.SetBoolSwappedArgs(true, "gotCharm_19");
				playerData.SetBoolSwappedArgs(true, "gotCharm_20");
				playerData.SetBoolSwappedArgs(true, "gotCharm_21");
				playerData.SetBoolSwappedArgs(true, "gotCharm_22");
				playerData.SetBoolSwappedArgs(true, "gotCharm_23");
				playerData.SetBoolSwappedArgs(true, "gotCharm_24");
				playerData.SetBoolSwappedArgs(true, "gotCharm_25");
				playerData.SetBoolSwappedArgs(true, "gotCharm_26");
				playerData.SetBoolSwappedArgs(true, "gotCharm_27");
				playerData.SetBoolSwappedArgs(true, "gotCharm_28");
				playerData.SetBoolSwappedArgs(true, "gotCharm_29");
				playerData.SetBoolSwappedArgs(true, "gotCharm_30");
				playerData.SetBoolSwappedArgs(true, "gotCharm_31");
				playerData.SetBoolSwappedArgs(true, "gotCharm_32");
				playerData.SetBoolSwappedArgs(true, "gotCharm_33");
				playerData.SetBoolSwappedArgs(true, "gotCharm_34");
				playerData.SetBoolSwappedArgs(true, "gotCharm_35");
				playerData.SetBoolSwappedArgs(true, "gotCharm_36");
				playerData.SetBoolSwappedArgs(true, "gotCharm_37");
				playerData.SetBoolSwappedArgs(true, "gotCharm_38");
				playerData.SetBoolSwappedArgs(true, "gotCharm_39");
				playerData.SetBoolSwappedArgs(true, "gotCharm_40");
				playerData.SetIntSwappedArgs(3, "royalCharmState");
				playerData.SetIntSwappedArgs(10, "charmSlots");
			}
			if (this.SafetyCheatButton(ref num, "Dream Orbs"))
			{
				PlayerData playerData2 = playerData;
				playerData2.SetIntSwappedArgs(playerData2.GetInt("dreamOrbs") + 1000, "dreamOrbs");
			}
			if (this.SafetyCheatButton(ref num, "Dreamnail"))
			{
				if (!playerData.GetBool("hasDreamNail"))
				{
					playerData.SetBoolSwappedArgs(true, "hasDreamNail");
				}
				else
				{
					playerData.SetBoolSwappedArgs(true, "dreamNailUpgraded");
				}
			}
			if (this.SafetyCheatButton(ref num, "All Map"))
			{
				playerData.SetBoolSwappedArgs(true, "hasMap");
				playerData.SetBoolSwappedArgs(true, "mapDirtmouth");
				playerData.SetBoolSwappedArgs(true, "mapCrossroads");
				playerData.SetBoolSwappedArgs(true, "mapGreenpath");
				playerData.SetBoolSwappedArgs(false, "mapFogCanyon");
				playerData.SetBoolSwappedArgs(true, "mapRoyalGardens");
				playerData.SetBoolSwappedArgs(false, "mapFungalWastes");
				playerData.SetBoolSwappedArgs(true, "mapCity");
				playerData.SetBoolSwappedArgs(false, "mapWaterways");
				playerData.SetBoolSwappedArgs(true, "mapMines");
				playerData.SetBoolSwappedArgs(true, "mapDeepnest");
				playerData.SetBoolSwappedArgs(true, "mapCliffs");
				playerData.SetBoolSwappedArgs(true, "mapOutskirts");
				playerData.SetBoolSwappedArgs(true, "mapRestingGrounds");
				playerData.SetBoolSwappedArgs(true, "mapAbyss");
				playerData.SetBoolSwappedArgs(true, "openedMapperShop");
			}
			if (this.SafetyCheatButton(ref num, "All Key Items"))
			{
				if (playerData.GetBool("hasDash"))
				{
					playerData.SetBoolSwappedArgs(true, "hasShadowDash");
					playerData.SetBoolSwappedArgs(true, "canShadowDash");
				}
				playerData.SetBoolSwappedArgs(true, "hasDash");
				playerData.SetBoolSwappedArgs(true, "canDash");
				playerData.SetBoolSwappedArgs(true, "hasWalljump");
				playerData.SetBoolSwappedArgs(true, "canWallJump");
				playerData.SetBoolSwappedArgs(true, "hasSuperDash");
				playerData.SetBoolSwappedArgs(true, "hasDreamNail");
				playerData.SetBoolSwappedArgs(true, "dreamNailUpgraded");
				playerData.SetBoolSwappedArgs(true, "hasLantern");
				playerData.SetBoolSwappedArgs(true, "hasAcidArmour");
				playerData.SetBoolSwappedArgs(true, "hasTramPass");
				playerData.SetBoolSwappedArgs(true, "hasLoveKey");
				playerData.SetBoolSwappedArgs(true, "hasWhiteKey");
				playerData.SetBoolSwappedArgs(true, "hasSlykey");
				playerData.SetBoolSwappedArgs(true, "hasKingsBrand");
				playerData.SetIntSwappedArgs(5, "simpleKeys");
			}
			if (this.SafetyCheatButton(ref num, "All Nail Arts"))
			{
				playerData.SetBoolSwappedArgs(true, "hasNailArt");
				playerData.SetBoolSwappedArgs(true, "hasDashSlash");
				playerData.SetBoolSwappedArgs(true, "hasCyclone");
				playerData.SetBoolSwappedArgs(true, "hasUpwardSlash");
				playerData.SetBoolSwappedArgs(true, "hasAllNailArts");
			}
			if (this.SafetyCheatButton(ref num, "Get Pale Ores"))
			{
				PlayerData playerData3 = playerData;
				playerData3.SetIntSwappedArgs(playerData3.GetInt("ore") + 1, "ore");
			}
			if (this.SafetyCheatButton(ref num, "Unlock Colosseums"))
			{
				playerData.SetBoolSwappedArgs(true, "colosseumBronzeOpened");
				playerData.SetBoolSwappedArgs(true, "colosseumSilverOpened");
				playerData.SetBoolSwappedArgs(true, "colosseumGoldOpened");
			}
			if (this.SafetyCheatButton(ref num, "Unlock Steel Soul"))
			{
				Platform.Current.EncryptedSharedData.SetInt("PermaDeath_Unlock", 1);
				Platform.Current.EncryptedSharedData.Save();
			}
			if (this.SafetyCheatButton(ref num, (playerData.GetInt("permadeathMode") == 0) ? "Enable Steel Soul" : "Disable Steel Soul"))
			{
				playerData.SetIntSwappedArgs((playerData.GetInt("permadeathMode") == 0) ? 1 : 0, "permadeathMode");
			}
		}
		if (this.CheatButton(ref num, (PerformanceHUD.ShowVibrations ? "Hide" : "Show") + " Vibrations"))
		{
			PerformanceHUD.ShowVibrations = !PerformanceHUD.ShowVibrations;
		}
		if (this.CheatButton(ref num, "Revert Global Pool"))
		{
			ObjectPool.instance.RevertToStartState();
		}
		if (this.CheatButton(ref num, (this.isQuickHealEnabled ? "Disable" : "Enable") + " Quick Heal"))
		{
			this.isQuickHealEnabled = !this.isQuickHealEnabled;
		}
		if (this.CheatButton(ref num, (this.isInstaDeathEnabled ? "Disable" : "Enable") + " Death Button"))
		{
			this.isInstaDeathEnabled = !this.isInstaDeathEnabled;
		}
		int num2 = 0;
		if (InputManager.ActiveDevice.DPadUp || Input.GetKeyDown(KeyCode.UpArrow))
		{
			num2--;
		}
		if (InputManager.ActiveDevice.DPadDown || Input.GetKeyDown(KeyCode.DownArrow))
		{
			num2++;
		}
		if (num2 != 0 && (num2 != this.lastSelectDelta || this.selectCooldown < Mathf.Epsilon))
		{
			this.selectedButtonIndex = Mathf.Clamp((this.selectedButtonIndex + num2 + num) % num, 0, num - 1);
			this.selectCooldown = 0.2f;
			this.lastSelectDelta = num2;
			this.safetyCounter = 0;
		}
		if (Event.current.type == EventType.Repaint && (InputManager.ActiveDevice.Action2.WasPressed || InputManager.ActiveDevice.Action3.WasPressed || InputManager.ActiveDevice.Action4.WasPressed || (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Z)))
		{
			this.isOpen = false;
			this.safetyCounter = 0;
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0001A0A0 File Offset: 0x000182A0
	private static void OpenStagStations()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			PlayerData playerData = unsafeInstance.playerData;
			playerData.SetBoolSwappedArgs(true, "openedTown");
			playerData.SetBoolSwappedArgs(true, "openedTownBuilding");
			playerData.SetBoolSwappedArgs(true, "openedCrossroads");
			playerData.SetBoolSwappedArgs(true, "openedGreenpath");
			playerData.SetBoolSwappedArgs(true, "openedRuins1");
			playerData.SetBoolSwappedArgs(true, "openedRuins2");
			playerData.SetBoolSwappedArgs(true, "openedFungalWastes");
			playerData.SetBoolSwappedArgs(true, "openedRoyalGardens");
			playerData.SetBoolSwappedArgs(true, "openedRestingGrounds");
			playerData.SetBoolSwappedArgs(true, "openedDeepnest");
			playerData.SetBoolSwappedArgs(true, "openedStagNest");
			playerData.SetBoolSwappedArgs(true, "openedHiddenStation");
			playerData.SetBoolSwappedArgs(true, "gladeDoorOpened");
			playerData.SetBoolSwappedArgs(true, "troupeInTown");
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0001A16C File Offset: 0x0001836C
	protected bool CheatButton(ref int buttonIndex, string content)
	{
		bool flag = this.selectedButtonIndex == buttonIndex;
		Rect position = new Rect(25f, (float)(25 + 22 * buttonIndex), 200f, 20f);
		GUI.color = new Color(0f, 0f, 0f, 0.5f);
		GUI.DrawTexture(position, Texture2D.whiteTexture);
		GUI.color = (flag ? Color.white : Color.grey);
		GUI.Label(position, (flag ? "> " : "") + content);
		buttonIndex++;
		return flag && ((Event.current.type == EventType.Repaint && InputManager.ActiveDevice.Action1.WasPressed) || (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Z));
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0001A240 File Offset: 0x00018440
	protected bool SafetyCheatButton(ref int buttonIndex, string content)
	{
		if (this.CheatButton(ref buttonIndex, string.Concat(new string[]
		{
			content,
			" [",
			((this.selectedButtonIndex == buttonIndex) ? this.safetyCounter : 0).ToString(),
			"/",
			10.ToString(),
			"]"
		})))
		{
			if (this.safetyCounter < 10)
			{
				this.safetyCounter++;
			}
			return this.safetyCounter >= 10;
		}
		return false;
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001A2D4 File Offset: 0x000184D4
	private void Restore()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			HeroController hero_ctrl = unsafeInstance.hero_ctrl;
			if (hero_ctrl != null)
			{
				hero_ctrl.AddHealth(unsafeInstance.playerData.GetInt("maxHealth") - unsafeInstance.playerData.GetInt("health"));
				hero_ctrl.AddMPCharge(unsafeInstance.playerData.GetInt("maxMP") - unsafeInstance.playerData.GetInt("MPCharge"));
			}
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001A350 File Offset: 0x00018550
	private void Kill()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			HeroController hero_ctrl = unsafeInstance.hero_ctrl;
			if (hero_ctrl != null)
			{
				PlayerData.instance.SetBoolSwappedArgs(false, "isInvincible");
				hero_ctrl.TakeDamage(null, CollisionSide.other, 9999, 0);
			}
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001A39C File Offset: 0x0001859C
	private void GetGeo(int amount)
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			unsafeInstance.playerData.AddGeo(amount);
		}
	}

	// Token: 0x040004B7 RID: 1207
	private static CheatManager instance;

	// Token: 0x040004B8 RID: 1208
	private bool wasEverOpened;

	// Token: 0x040004B9 RID: 1209
	private bool isOpen;

	// Token: 0x040004BA RID: 1210
	private int selectedButtonIndex;

	// Token: 0x040004BB RID: 1211
	private int lastSelectDelta;

	// Token: 0x040004BC RID: 1212
	private float selectCooldown;

	// Token: 0x040004BD RID: 1213
	private const float KeyRepeatInterval = 0.2f;

	// Token: 0x040004BE RID: 1214
	private bool isQuickHealEnabled;

	// Token: 0x040004BF RID: 1215
	private bool isRegenerating;

	// Token: 0x040004C0 RID: 1216
	private bool isInstaDeathEnabled;

	// Token: 0x040004C1 RID: 1217
	private bool isInstaKillEnabled;

	// Token: 0x040004C2 RID: 1218
	private int safetyCounter;

	// Token: 0x040004C3 RID: 1219
	private const int SafetyAmount = 10;

	// Token: 0x040004C4 RID: 1220
	private string transitionRobotStartScene;

	// Token: 0x040004C5 RID: 1221
	private float slowOpenLeftStickTimer;

	// Token: 0x040004C6 RID: 1222
	private float slowOpenRightStickTimer;
}
