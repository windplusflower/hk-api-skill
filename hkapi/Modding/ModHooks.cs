using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using GlobalEnums;
using HutongGames.PlayMaker;
using JetBrains.Annotations;
using Language;
using Modding.Delegates;
using Modding.Patches;
using Newtonsoft.Json;
using UnityEngine;

namespace Modding
{
	/// <summary>
	///     Class to hook into various events for the game.
	/// </summary>
	// Token: 0x02000D70 RID: 3440
	[PublicAPI]
	public class ModHooks
	{
		/// <summary>
		///     A map of mods to their built menu screens.
		/// </summary>
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x00181626 File Offset: 0x0017F826
		public static ReadOnlyDictionary<IMod, MenuScreen> BuiltModMenuScreens
		{
			get
			{
				return new ReadOnlyDictionary<IMod, MenuScreen>(ModListMenu.ModScreens);
			}
		}

		/// <summary>
		/// The global ModHooks settings.
		/// </summary>
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x00181632 File Offset: 0x0017F832
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x00181639 File Offset: 0x0017F839
		public static ModHooksGlobalSettings GlobalSettings { get; private set; }

		/// <summary>
		///     Current instance of Modhooks.
		/// </summary>
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x00181641 File Offset: 0x0017F841
		[Obsolete("All members of ModHooks are now static, use the type name instead.")]
		public static ModHooks Instance
		{
			get
			{
				if (ModHooks._instance != null)
				{
					return ModHooks._instance;
				}
				ModHooks._instance = new ModHooks();
				return ModHooks._instance;
			}
		}

		/// <summary>
		///     Called whenever localization specific strings are requested
		/// </summary>
		/// <see cref="T:Modding.Delegates.LanguageGetProxy" />
		/// <remarks>N/A</remarks>
		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060046F9 RID: 18169 RVA: 0x00181660 File Offset: 0x0017F860
		// (remove) Token: 0x060046FA RID: 18170 RVA: 0x00181694 File Offset: 0x0017F894
		public static event LanguageGetProxy LanguageGetHook;

		/// <summary>
		///     Called whenever game tries to show cursor
		/// </summary>
		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060046FB RID: 18171 RVA: 0x001816C8 File Offset: 0x0017F8C8
		// (remove) Token: 0x060046FC RID: 18172 RVA: 0x001816FC File Offset: 0x0017F8FC
		public static event Action CursorHook;

		/// <summary>
		///     Called whenever a new gameobject is created with a collider and playmaker2d
		/// </summary>
		/// <remarks>PlayMakerUnity2DProxy.Start</remarks>
		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060046FD RID: 18173 RVA: 0x00181730 File Offset: 0x0017F930
		// (remove) Token: 0x060046FE RID: 18174 RVA: 0x00181764 File Offset: 0x0017F964
		public static event Action<GameObject> ColliderCreateHook;

		/// <summary>
		///     Called whenever game tries to create a new gameobject.  This happens often, care should be taken.
		/// </summary>
		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060046FF RID: 18175 RVA: 0x00181798 File Offset: 0x0017F998
		// (remove) Token: 0x06004700 RID: 18176 RVA: 0x001817CC File Offset: 0x0017F9CC
		public static event Func<GameObject, GameObject> ObjectPoolSpawnHook;

		/// <summary>
		///     Called when the game is fully closed
		/// </summary>
		/// <remarks>GameManager.OnApplicationQuit</remarks>
		// Token: 0x14000078 RID: 120
		// (add) Token: 0x06004701 RID: 18177 RVA: 0x00181800 File Offset: 0x0017FA00
		// (remove) Token: 0x06004702 RID: 18178 RVA: 0x00181834 File Offset: 0x0017FA34
		public static event Action ApplicationQuitHook;

		/// <summary>
		/// Called whenever a HitInstance is created. Overrides hit.
		/// </summary>
		/// <see cref="T:Modding.Delegates.HitInstanceHandler" />
		// Token: 0x14000079 RID: 121
		// (add) Token: 0x06004703 RID: 18179 RVA: 0x00181868 File Offset: 0x0017FA68
		// (remove) Token: 0x06004704 RID: 18180 RVA: 0x0018189C File Offset: 0x0017FA9C
		public static event HitInstanceHandler HitInstanceHook;

		/// <summary>
		///     Called when a SceneManager calls DrawBlackBorders and creates boarders for a scene. You may use or modify the
		///     bounds of an area of the scene with these.
		/// </summary>
		/// <remarks>SceneManager.DrawBlackBorders</remarks>
		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06004705 RID: 18181 RVA: 0x001818D0 File Offset: 0x0017FAD0
		// (remove) Token: 0x06004706 RID: 18182 RVA: 0x00181904 File Offset: 0x0017FB04
		public static event Action<List<GameObject>> DrawBlackBordersHook;

		/// <summary>
		///     Called when an enemy is enabled. Check this isDead flag to see if they're already dead. If you return true, this
		///     will mark the enemy as already dead on load. Default behavior is to return the value inside "isAlreadyDead".
		/// </summary>
		/// <see cref="T:Modding.Delegates.OnEnableEnemyHandler" />
		/// <remarks>HealthManager.CheckPersistence</remarks>
		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06004707 RID: 18183 RVA: 0x00181938 File Offset: 0x0017FB38
		// (remove) Token: 0x06004708 RID: 18184 RVA: 0x0018196C File Offset: 0x0017FB6C
		public static event OnEnableEnemyHandler OnEnableEnemyHook;

		/// <summary>
		///     Called when an enemy recieves a death event. It looks like this event may be called multiple times on an enemy, so
		///     check "eventAlreadyRecieved" to see if the event has been fired more than once.
		/// </summary>
		/// <see cref="T:Modding.Delegates.OnReceiveDeathEventHandler" />
		/// <remarks>EnemyDeathEffects.RecieveDeathEvent</remarks>
		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06004709 RID: 18185 RVA: 0x001819A0 File Offset: 0x0017FBA0
		// (remove) Token: 0x0600470A RID: 18186 RVA: 0x001819D4 File Offset: 0x0017FBD4
		public static event OnReceiveDeathEventHandler OnReceiveDeathEventHook;

		/// <summary>
		///     Called when an enemy dies and a journal kill is recorded. You may use the "playerDataName" string or one of the
		///     additional pre-formatted player data strings to look up values in playerData.
		/// </summary>
		/// <see cref="T:Modding.Delegates.RecordKillForJournalHandler" />
		/// <remarks>EnemyDeathEffects.OnRecordKillForJournal</remarks>
		// Token: 0x1400007D RID: 125
		// (add) Token: 0x0600470B RID: 18187 RVA: 0x00181A08 File Offset: 0x0017FC08
		// (remove) Token: 0x0600470C RID: 18188 RVA: 0x00181A3C File Offset: 0x0017FC3C
		public static event RecordKillForJournalHandler RecordKillForJournalHook;

		/// <summary>
		///     Called when anything in the game tries to set a bool in player data
		/// </summary>
		/// <example>
		/// <code>
		/// public int KillCount { get; set; }
		///
		/// ModHooks.Instance.SetPlayerBoolHook += SetBool;
		///
		/// /*
		///  * This uses the bool set to trigger a death, killing the player
		///  * as well as preventing them from picking up dash, which could be used
		///  * in something like a dashless mod.
		///  *
		///  * We are also able to use SetBool for counting things, as it is often
		///  * called every time sometthing happens, regardless of the value
		///  * this can be seen in our check for "killedMageLord", which counts the
		///  * number of times the player kills Soul Master with the mod on.
		///  */
		/// bool SetBool(string name, bool orig) {
		///     switch (name) {
		///         case "hasDash":
		///             var hc = HeroController.instance;
		///
		///             // Kill the player
		///             hc.StartCoroutine(hc.Die());
		///
		///             // Prevent dash from being picked up
		///             return false;
		///         case "killedMageLord":
		///             // Just increment the counter.
		///             KillCount++;
		///
		///             // We could also do something like award them geo for each kill
		///             // And despite being a set, this would trigger on *every* kill
		///             HeroController.instance.AddGeo(300);
		///
		///             // Not changing the value.
		///             return orig;
		///         default:
		///             return orig;
		///     }
		/// }
		/// </code>
		/// </example>
		/// <see cref="T:Modding.Delegates.SetBoolProxy" />
		/// <remarks>PlayerData.SetBool</remarks>
		// Token: 0x1400007E RID: 126
		// (add) Token: 0x0600470D RID: 18189 RVA: 0x00181A70 File Offset: 0x0017FC70
		// (remove) Token: 0x0600470E RID: 18190 RVA: 0x00181AA4 File Offset: 0x0017FCA4
		public static event SetBoolProxy SetPlayerBoolHook;

		/// <summary>
		///     Called when anything in the game tries to get a bool from player data
		/// </summary>
		/// <example>
		/// <code>
		/// ModHooks.GetPlayerBoolHook += GetBool;
		///
		/// // In this example, we always give the player dash, and
		/// // leave other bools as-is.
		/// bool? GetBool(string name, bool orig) {
		///     return name == "canDash" ? true : orig;
		/// }
		/// </code>
		/// </example>
		/// <see cref="T:Modding.Delegates.GetBoolProxy" />
		/// <remarks>PlayerData.GetBool</remarks>
		// Token: 0x1400007F RID: 127
		// (add) Token: 0x0600470F RID: 18191 RVA: 0x00181AD8 File Offset: 0x0017FCD8
		// (remove) Token: 0x06004710 RID: 18192 RVA: 0x00181B0C File Offset: 0x0017FD0C
		public static event GetBoolProxy GetPlayerBoolHook;

		/// <summary>
		///     Called when anything in the game tries to set an int in player data
		/// </summary>
		/// <example>
		/// <code>
		/// ModHooks.Instance.SetPlayerIntHook += SetInt;
		///
		/// int? SetInt(string name, int orig) {
		///      // We could do something every time the player 
		///      // receives or loses geo.
		///     if (name == "geo") {
		///         // Let's give the player soul if they *gain* geo
		///         if (PlayerData.instance.geo &lt; orig) {
		///             PlayerData.instance.AddMPChargeSpa(10);
		///         }
		///     }
		///
		///     // In this case, we aren't changing the value being set
		///     // at all, so we just leave the value as the original for everything.
		///     return orig;
		/// }
		/// </code>
		/// </example>
		/// <see cref="T:Modding.Delegates.SetIntProxy" />
		/// <remarks>PlayerData.SetInt</remarks>
		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06004711 RID: 18193 RVA: 0x00181B40 File Offset: 0x0017FD40
		// (remove) Token: 0x06004712 RID: 18194 RVA: 0x00181B74 File Offset: 0x0017FD74
		public static event SetIntProxy SetPlayerIntHook;

		/// <summary>
		///     Called when anything in the game tries to get an int from player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.GetIntProxy" />
		/// <example>
		/// <code>
		/// ModHooks.GetPlayerIntHook += GetInt;
		///
		/// // This overrides the number of charm slots we have to 999,
		/// // effectively giving us infinite charm notches.
		/// // We ignore any other GetInt calls.
		/// int? GetInt(string name, int orig) {
		///     return name == "charmSlots" ? 999 : orig;
		/// }
		/// </code>
		/// </example>
		/// <see cref="T:Modding.Delegates.GetIntProxy" />
		/// <remarks>PlayerData.GetInt</remarks>
		// Token: 0x14000081 RID: 129
		// (add) Token: 0x06004713 RID: 18195 RVA: 0x00181BA8 File Offset: 0x0017FDA8
		// (remove) Token: 0x06004714 RID: 18196 RVA: 0x00181BDC File Offset: 0x0017FDDC
		public static event GetIntProxy GetPlayerIntHook;

		/// <summary>
		///     Called when anything in the game tries to set a float in player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.SetFloatProxy" />
		/// <remarks>PlayerData.SetFloat</remarks>
		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06004715 RID: 18197 RVA: 0x00181C10 File Offset: 0x0017FE10
		// (remove) Token: 0x06004716 RID: 18198 RVA: 0x00181C44 File Offset: 0x0017FE44
		public static event SetFloatProxy SetPlayerFloatHook;

		/// <summary>
		///     Called when anything in the game tries to get a float from player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.GetFloatProxy" />
		/// <remarks>PlayerData.GetFloat</remarks>
		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06004717 RID: 18199 RVA: 0x00181C78 File Offset: 0x0017FE78
		// (remove) Token: 0x06004718 RID: 18200 RVA: 0x00181CAC File Offset: 0x0017FEAC
		public static event GetFloatProxy GetPlayerFloatHook;

		/// <summary>
		///     Called when anything in the game tries to set a string in player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.SetStringProxy" />
		/// <remarks>PlayerData.SetString</remarks>
		// Token: 0x14000084 RID: 132
		// (add) Token: 0x06004719 RID: 18201 RVA: 0x00181CE0 File Offset: 0x0017FEE0
		// (remove) Token: 0x0600471A RID: 18202 RVA: 0x00181D14 File Offset: 0x0017FF14
		public static event SetStringProxy SetPlayerStringHook;

		/// <summary>
		///     Called when anything in the game tries to get a string from player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.GetStringProxy" />
		/// <remarks>PlayerData.GetString</remarks>
		// Token: 0x14000085 RID: 133
		// (add) Token: 0x0600471B RID: 18203 RVA: 0x00181D48 File Offset: 0x0017FF48
		// (remove) Token: 0x0600471C RID: 18204 RVA: 0x00181D7C File Offset: 0x0017FF7C
		public static event GetStringProxy GetPlayerStringHook;

		/// <summary>
		///     Called when anything in the game tries to set a Vector3 in player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.SetVector3Proxy" />
		/// <remarks>PlayerData.SetVector3</remarks>
		// Token: 0x14000086 RID: 134
		// (add) Token: 0x0600471D RID: 18205 RVA: 0x00181DB0 File Offset: 0x0017FFB0
		// (remove) Token: 0x0600471E RID: 18206 RVA: 0x00181DE4 File Offset: 0x0017FFE4
		public static event SetVector3Proxy SetPlayerVector3Hook;

		/// <summary>
		///     Called when anything in the game tries to get a Vector3 from player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.GetVector3Proxy" />
		/// <remarks>PlayerData.GetVector3</remarks>
		// Token: 0x14000087 RID: 135
		// (add) Token: 0x0600471F RID: 18207 RVA: 0x00181E18 File Offset: 0x00180018
		// (remove) Token: 0x06004720 RID: 18208 RVA: 0x00181E4C File Offset: 0x0018004C
		public static event GetVector3Proxy GetPlayerVector3Hook;

		/// <summary>
		///     Called when anything in the game tries to set a generic variable in player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.SetVariableProxy" />
		/// <remarks>PlayerData.SetVariable</remarks>
		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06004721 RID: 18209 RVA: 0x00181E80 File Offset: 0x00180080
		// (remove) Token: 0x06004722 RID: 18210 RVA: 0x00181EB4 File Offset: 0x001800B4
		public static event SetVariableProxy SetPlayerVariableHook;

		/// <summary>
		///     Called when anything in the game tries to get a generic variable from player data
		/// </summary>
		/// <see cref="T:Modding.Delegates.GetVariableProxy" />
		/// <remarks>PlayerData.GetVariable</remarks>
		// Token: 0x14000089 RID: 137
		// (add) Token: 0x06004723 RID: 18211 RVA: 0x00181EE8 File Offset: 0x001800E8
		// (remove) Token: 0x06004724 RID: 18212 RVA: 0x00181F1C File Offset: 0x0018011C
		[PublicAPI]
		public static event GetVariableProxy GetPlayerVariableHook;

		/// <summary>
		///     Called whenever blue health is updated
		/// </summary>
		// Token: 0x1400008A RID: 138
		// (add) Token: 0x06004725 RID: 18213 RVA: 0x00181F50 File Offset: 0x00180150
		// (remove) Token: 0x06004726 RID: 18214 RVA: 0x00181F84 File Offset: 0x00180184
		public static event Func<int> BlueHealthHook;

		/// <summary>
		///     Called when health is taken from the player
		/// </summary>
		/// <remarks>HeroController.TakeHealth</remarks>
		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06004727 RID: 18215 RVA: 0x00181FB8 File Offset: 0x001801B8
		// (remove) Token: 0x06004728 RID: 18216 RVA: 0x00181FEC File Offset: 0x001801EC
		public static event TakeHealthProxy TakeHealthHook;

		/// <summary>
		///     Called when damage is dealt to the player, at the start of the take damage function.
		/// </summary>
		/// <see cref="T:Modding.Delegates.TakeDamageProxy" />
		/// <remarks>HeroController.TakeDamage</remarks>
		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06004729 RID: 18217 RVA: 0x00182020 File Offset: 0x00180220
		// (remove) Token: 0x0600472A RID: 18218 RVA: 0x00182054 File Offset: 0x00180254
		public static event TakeDamageProxy TakeDamageHook;

		/// <summary>
		///     Called in the take damage function, immediately before applying damage (just before checking overcharm)
		/// </summary>
		/// <see cref="T:Modding.Delegates.AfterTakeDamageHandler" />
		// Token: 0x1400008D RID: 141
		// (add) Token: 0x0600472B RID: 18219 RVA: 0x00182088 File Offset: 0x00180288
		// (remove) Token: 0x0600472C RID: 18220 RVA: 0x001820BC File Offset: 0x001802BC
		public static event AfterTakeDamageHandler AfterTakeDamageHook;

		/// <summary>
		///     Called when the player dies
		/// </summary>
		/// <remarks>GameManager.PlayerDead</remarks>
		// Token: 0x1400008E RID: 142
		// (add) Token: 0x0600472D RID: 18221 RVA: 0x001820F0 File Offset: 0x001802F0
		// (remove) Token: 0x0600472E RID: 18222 RVA: 0x00182124 File Offset: 0x00180324
		public static event Action BeforePlayerDeadHook;

		/// <summary>
		///     Called after the player dies
		/// </summary>
		/// <remarks>GameManager.PlayerDead</remarks>
		// Token: 0x1400008F RID: 143
		// (add) Token: 0x0600472F RID: 18223 RVA: 0x00182158 File Offset: 0x00180358
		// (remove) Token: 0x06004730 RID: 18224 RVA: 0x0018218C File Offset: 0x0018038C
		public static event Action AfterPlayerDeadHook;

		/// <summary>
		///     Called whenever the player attacks
		/// </summary>
		/// <remarks>HeroController.Attack</remarks>
		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06004731 RID: 18225 RVA: 0x001821C0 File Offset: 0x001803C0
		// (remove) Token: 0x06004732 RID: 18226 RVA: 0x001821F4 File Offset: 0x001803F4
		public static event Action<AttackDirection> AttackHook;

		/// <summary>
		///     Called at the start of the DoAttack function
		/// </summary>
		// Token: 0x14000091 RID: 145
		// (add) Token: 0x06004733 RID: 18227 RVA: 0x00182228 File Offset: 0x00180428
		// (remove) Token: 0x06004734 RID: 18228 RVA: 0x0018225C File Offset: 0x0018045C
		public static event Action DoAttackHook;

		/// <summary>
		///     Called at the end of the attack function
		/// </summary>
		/// <remarks>HeroController.Attack</remarks>
		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06004735 RID: 18229 RVA: 0x00182290 File Offset: 0x00180490
		// (remove) Token: 0x06004736 RID: 18230 RVA: 0x001822C4 File Offset: 0x001804C4
		public static event Action<AttackDirection> AfterAttackHook;

		/// <summary>
		///     Called whenever nail strikes something
		/// </summary>
		/// <see cref="T:Modding.Delegates.SlashHitHandler" />
		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06004737 RID: 18231 RVA: 0x001822F8 File Offset: 0x001804F8
		// (remove) Token: 0x06004738 RID: 18232 RVA: 0x0018232C File Offset: 0x0018052C
		public static event SlashHitHandler SlashHitHook;

		/// <summary>
		///     Called after player values for charms have been set
		/// </summary>
		/// <see cref="T:Modding.Delegates.CharmUpdateHandler" />
		/// <remarks>HeroController.CharmUpdate</remarks>
		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06004739 RID: 18233 RVA: 0x00182360 File Offset: 0x00180560
		// (remove) Token: 0x0600473A RID: 18234 RVA: 0x00182394 File Offset: 0x00180594
		public static event CharmUpdateHandler CharmUpdateHook;

		/// <summary>
		///     Called whenever the hero updates
		/// </summary>
		/// <remarks>HeroController.Update</remarks>
		// Token: 0x14000095 RID: 149
		// (add) Token: 0x0600473B RID: 18235 RVA: 0x001823C8 File Offset: 0x001805C8
		// (remove) Token: 0x0600473C RID: 18236 RVA: 0x001823FC File Offset: 0x001805FC
		public static event Action HeroUpdateHook;

		/// <summary>
		///     Called whenever the player heals, overrides health added.
		/// </summary>
		/// <remarks>PlayerData.health</remarks>
		// Token: 0x14000096 RID: 150
		// (add) Token: 0x0600473D RID: 18237 RVA: 0x00182430 File Offset: 0x00180630
		// (remove) Token: 0x0600473E RID: 18238 RVA: 0x00182464 File Offset: 0x00180664
		public static event Func<int, int> BeforeAddHealthHook;

		/// <summary>
		///     Called whenever focus cost is calculated, allows a focus cost multiplier.
		/// </summary>
		// Token: 0x14000097 RID: 151
		// (add) Token: 0x0600473F RID: 18239 RVA: 0x00182498 File Offset: 0x00180698
		// (remove) Token: 0x06004740 RID: 18240 RVA: 0x001824CC File Offset: 0x001806CC
		public static event Func<float> FocusCostHook;

		/// <summary>
		///     Called when Hero recovers Soul from hitting enemies
		/// </summary>
		/// <returns>The amount of soul to recover</returns>
		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06004741 RID: 18241 RVA: 0x00182500 File Offset: 0x00180700
		// (remove) Token: 0x06004742 RID: 18242 RVA: 0x00182534 File Offset: 0x00180734
		public static event Func<int, int> SoulGainHook;

		/// <summary>
		///     Called during dash function to change velocity
		/// </summary>
		/// <returns>A changed vector.</returns>
		/// <remarks>HeroController.Dash</remarks>
		// Token: 0x14000099 RID: 153
		// (add) Token: 0x06004743 RID: 18243 RVA: 0x00182568 File Offset: 0x00180768
		// (remove) Token: 0x06004744 RID: 18244 RVA: 0x0018259C File Offset: 0x0018079C
		public static event Func<Vector2, Vector2> DashVectorHook;

		/// <summary>
		///     Called whenever the dash key is pressed.
		///     Returns whether or not to override normal dash functionality - if true, preventing a normal dash
		/// </summary>
		/// <remarks>HeroController.LookForQueueInput</remarks>
		// Token: 0x1400009A RID: 154
		// (add) Token: 0x06004745 RID: 18245 RVA: 0x001825D0 File Offset: 0x001807D0
		// (remove) Token: 0x06004746 RID: 18246 RVA: 0x00182604 File Offset: 0x00180804
		public static event Func<bool> DashPressedHook;

		/// <summary>
		///     Called directly after a save has been loaded
		/// </summary>
		/// <remarks>GameManager.LoadGame</remarks>
		// Token: 0x1400009B RID: 155
		// (add) Token: 0x06004747 RID: 18247 RVA: 0x00182638 File Offset: 0x00180838
		// (remove) Token: 0x06004748 RID: 18248 RVA: 0x0018266C File Offset: 0x0018086C
		public static event Action<int> SavegameLoadHook;

		/// <summary>
		///     Called directly after a save has been saved
		/// </summary>
		/// <remarks>GameManager.SaveGame</remarks>
		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06004749 RID: 18249 RVA: 0x001826A0 File Offset: 0x001808A0
		// (remove) Token: 0x0600474A RID: 18250 RVA: 0x001826D4 File Offset: 0x001808D4
		public static event Action<int> SavegameSaveHook;

		/// <summary>
		///     Called whenever a new game is started
		/// </summary>
		/// <remarks>GameManager.LoadFirstScene</remarks>
		// Token: 0x1400009D RID: 157
		// (add) Token: 0x0600474B RID: 18251 RVA: 0x00182708 File Offset: 0x00180908
		// (remove) Token: 0x0600474C RID: 18252 RVA: 0x0018273C File Offset: 0x0018093C
		public static event Action NewGameHook;

		/// <summary>
		///     Called before a save file is deleted
		/// </summary>
		/// <remarks>GameManager.ClearSaveFile</remarks>
		// Token: 0x1400009E RID: 158
		// (add) Token: 0x0600474D RID: 18253 RVA: 0x00182770 File Offset: 0x00180970
		// (remove) Token: 0x0600474E RID: 18254 RVA: 0x001827A4 File Offset: 0x001809A4
		public static event Action<int> SavegameClearHook;

		/// <summary>
		///     Called directly after a save has been loaded.  Allows for accessing SaveGame instance.
		/// </summary>
		/// <remarks>GameManager.LoadGame</remarks>
		// Token: 0x1400009F RID: 159
		// (add) Token: 0x0600474F RID: 18255 RVA: 0x001827D8 File Offset: 0x001809D8
		// (remove) Token: 0x06004750 RID: 18256 RVA: 0x0018280C File Offset: 0x00180A0C
		public static event Action<SaveGameData> AfterSavegameLoadHook;

		/// <summary>
		///     Called directly before save has been saved to allow for changes to the data before persisted.
		/// </summary>
		/// <remarks>GameManager.SaveGame</remarks>
		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x06004751 RID: 18257 RVA: 0x00182840 File Offset: 0x00180A40
		// (remove) Token: 0x06004752 RID: 18258 RVA: 0x00182874 File Offset: 0x00180A74
		public static event Action<SaveGameData> BeforeSavegameSaveHook;

		/// <summary>
		///     Overrides the filename to load for a given slot.  Return null to use vanilla names.
		/// </summary>
		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x06004753 RID: 18259 RVA: 0x001828A8 File Offset: 0x00180AA8
		// (remove) Token: 0x06004754 RID: 18260 RVA: 0x001828DC File Offset: 0x00180ADC
		public static event Func<int, string> GetSaveFileNameHook;

		/// <summary>
		///     Called after a game has been cleared from a slot.
		/// </summary>
		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06004755 RID: 18261 RVA: 0x00182910 File Offset: 0x00180B10
		// (remove) Token: 0x06004756 RID: 18262 RVA: 0x00182944 File Offset: 0x00180B44
		public static event Action<int> AfterSaveGameClearHook;

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06004757 RID: 18263 RVA: 0x00182978 File Offset: 0x00180B78
		// (remove) Token: 0x06004758 RID: 18264 RVA: 0x001829AC File Offset: 0x00180BAC
		internal static event Action<ModSavegameData> SaveLocalSettings;

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06004759 RID: 18265 RVA: 0x001829E0 File Offset: 0x00180BE0
		// (remove) Token: 0x0600475A RID: 18266 RVA: 0x00182A14 File Offset: 0x00180C14
		internal static event Action<ModSavegameData> LoadLocalSettings;

		/// <summary>
		///     Called after a new Scene has been loaded
		/// </summary>
		/// <remarks>N/A</remarks>
		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x0600475B RID: 18267 RVA: 0x00182A48 File Offset: 0x00180C48
		// (remove) Token: 0x0600475C RID: 18268 RVA: 0x00182A7C File Offset: 0x00180C7C
		public static event Action<string> SceneChanged;

		/// <summary>
		///     Called right before a scene gets loaded, can change which scene gets loaded
		/// </summary>
		/// <remarks>N/A</remarks>
		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x0600475D RID: 18269 RVA: 0x00182AB0 File Offset: 0x00180CB0
		// (remove) Token: 0x0600475E RID: 18270 RVA: 0x00182AE4 File Offset: 0x00180CE4
		public static event Func<string, string> BeforeSceneLoadHook;

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x0600475F RID: 18271 RVA: 0x00182B18 File Offset: 0x00180D18
		// (remove) Token: 0x06004760 RID: 18272 RVA: 0x00182B4C File Offset: 0x00180D4C
		private static event Action _finishedLoadingModsHook;

		/// <summary>
		/// Event invoked when mods have finished loading. If modloading has already finished, subscribers will be invoked immediately.
		/// </summary>
		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x06004761 RID: 18273 RVA: 0x00182B80 File Offset: 0x00180D80
		// (remove) Token: 0x06004762 RID: 18274 RVA: 0x00182BD4 File Offset: 0x00180DD4
		public static event Action FinishedLoadingModsHook
		{
			add
			{
				ModHooks._finishedLoadingModsHook += value;
				if (!ModLoader.LoadState.HasFlag(ModLoader.ModLoadState.Loaded))
				{
					return;
				}
				try
				{
					value();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			remove
			{
				ModHooks._finishedLoadingModsHook -= value;
			}
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x00182BDC File Offset: 0x00180DDC
		static ModHooks()
		{
			ModHooks.SettingsPath = Path.Combine(Application.persistentDataPath, "ModdingApi.GlobalSettings.json");
			ModHooks.LoadedModsWithVersions = new Dictionary<string, string>();
			ModHooks.GlobalSettings = new ModHooksGlobalSettings();
			GameVersion gameVersion;
			try
			{
				string[] array = "1.5.78.11833".Split(new char[]
				{
					'.'
				});
				gameVersion.major = Convert.ToInt32(array[0]);
				gameVersion.minor = Convert.ToInt32(array[1]);
				gameVersion.revision = Convert.ToInt32(array[2]);
				gameVersion.package = Convert.ToInt32(array[3]);
			}
			catch (Exception ex)
			{
				gameVersion.major = 0;
				gameVersion.minor = 0;
				gameVersion.revision = 0;
				gameVersion.package = 0;
				Loggable apilogger = Logger.APILogger;
				string str = "Failed obtaining game version:\n";
				Exception ex2 = ex;
				apilogger.LogError(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			ModHooks.version = new GameVersionData
			{
				gameVersion = gameVersion
			};
			ModHooks.ModVersion = ModHooks.version.GetGameVersionString() + "-" + 77.ToString();
			ModHooks.FinishedLoadingModsHook += delegate()
			{
				ModHooks.ApplicationQuitHook += ModHooks.SaveGlobalSettings;
			};
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00182D04 File Offset: 0x00180F04
		internal static void LoadGlobalSettings()
		{
			try
			{
				if (File.Exists(ModHooks.SettingsPath))
				{
					Logger.APILogger.Log("Loading Global Settings");
					using (FileStream fileStream = File.OpenRead(ModHooks.SettingsPath))
					{
						using (StreamReader streamReader = new StreamReader(fileStream))
						{
							ModHooksGlobalSettings modHooksGlobalSettings = JsonConvert.DeserializeObject<ModHooksGlobalSettings>(streamReader.ReadToEnd(), new JsonSerializerSettings
							{
								ContractResolver = ShouldSerializeContractResolver.Instance,
								TypeNameHandling = TypeNameHandling.Auto,
								ObjectCreationHandling = ObjectCreationHandling.Replace,
								Converters = JsonConverterTypes.ConverterTypes
							});
							if (modHooksGlobalSettings != null)
							{
								ModHooks.GlobalSettings = modHooksGlobalSettings;
								Logger.SetLogLevel(ModHooks.GlobalSettings.LoggingLevel);
								Logger.SetUseShortLogLevel(ModHooks.GlobalSettings.ShortLoggingLevel);
								Logger.SetIncludeTimestampt(ModHooks.GlobalSettings.IncludeTimestamps);
							}
						}
					}
				}
			}
			catch (Exception message)
			{
				Logger.APILogger.LogError(message);
			}
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x00182E00 File Offset: 0x00181000
		internal static void SaveGlobalSettings()
		{
			try
			{
				Logger.APILogger.Log("Saving Global Settings");
				ModHooksGlobalSettings globalSettings = ModHooks.GlobalSettings;
				if (globalSettings != null)
				{
					globalSettings.ModEnabledSettings = new Dictionary<string, bool>();
					foreach (ModLoader.ModInstance modInstance in ModLoader.ModInstances)
					{
						if (modInstance.Mod is ITogglableMod)
						{
							ModLoader.ModErrorState? error = modInstance.Error;
							if (error == null)
							{
								globalSettings.ModEnabledSettings.Add(modInstance.Name, modInstance.Enabled);
							}
						}
					}
					if (File.Exists(ModHooks.SettingsPath + ".bak"))
					{
						File.Delete(ModHooks.SettingsPath + ".bak");
					}
					if (File.Exists(ModHooks.SettingsPath))
					{
						File.Move(ModHooks.SettingsPath, ModHooks.SettingsPath + ".bak");
					}
					using (FileStream fileStream = File.Create(ModHooks.SettingsPath))
					{
						using (StreamWriter streamWriter = new StreamWriter(fileStream))
						{
							streamWriter.Write(JsonConvert.SerializeObject(globalSettings, Formatting.Indented, new JsonSerializerSettings
							{
								ContractResolver = ShouldSerializeContractResolver.Instance,
								TypeNameHandling = TypeNameHandling.Auto,
								Converters = JsonConverterTypes.ConverterTypes
							}));
						}
					}
				}
			}
			catch (Exception message)
			{
				Logger.APILogger.LogError(message);
			}
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x00182FBC File Offset: 0x001811BC
		internal static void LogConsole(string message, LogLevel level)
		{
			try
			{
				if (ModHooks.GlobalSettings.ShowDebugLogInGame)
				{
					if (ModHooks._console == null)
					{
						GameObject gameObject = new GameObject();
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						ModHooks._console = gameObject.AddComponent<Console>();
					}
					ModHooks._console.AddText(message, level);
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}

		/// <summary>
		///     Called whenever localization specific strings are requested
		/// </summary>
		/// <remarks>N/A</remarks>
		// Token: 0x06004767 RID: 18279 RVA: 0x00183020 File Offset: 0x00181220
		internal static string LanguageGet(string key, string sheet)
		{
			string text = Language.GetInternal(key, sheet);
			if (ModHooks.LanguageGetHook == null)
			{
				return text;
			}
			foreach (LanguageGetProxy languageGetProxy in ModHooks.LanguageGetHook.GetInvocationList())
			{
				try
				{
					text = languageGetProxy(key, sheet, text);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return text;
		}

		/// <summary>
		///     Called whenever game tries to show cursor
		/// </summary>
		// Token: 0x06004768 RID: 18280 RVA: 0x00183090 File Offset: 0x00181290
		internal static void OnCursor(GameManager gm)
		{
			Cursor.lockState = CursorLockMode.None;
			if (ModHooks.CursorHook != null)
			{
				ModHooks.CursorHook();
				return;
			}
			if (gm.isPaused)
			{
				Cursor.visible = true;
				return;
			}
			Cursor.visible = false;
		}

		/// <summary>
		///     Called whenever a new gameobject is created with a collider and playmaker2d
		/// </summary>
		/// <remarks>PlayMakerUnity2DProxy.Start</remarks>
		// Token: 0x06004769 RID: 18281 RVA: 0x001830C0 File Offset: 0x001812C0
		internal static void OnColliderCreate(GameObject go)
		{
			Logger.APILogger.LogFine("OnColliderCreate Invoked");
			if (ModHooks.ColliderCreateHook == null)
			{
				return;
			}
			foreach (Action<GameObject> action in ModHooks.ColliderCreateHook.GetInvocationList())
			{
				try
				{
					action(go);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever game tries to show cursor
		/// </summary>
		// Token: 0x0600476A RID: 18282 RVA: 0x00183130 File Offset: 0x00181330
		internal static GameObject OnObjectPoolSpawn(GameObject go)
		{
			if (ModHooks.ObjectPoolSpawnHook == null)
			{
				return go;
			}
			foreach (Func<GameObject, GameObject> func in ModHooks.ObjectPoolSpawnHook.GetInvocationList())
			{
				try
				{
					go = func(go);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return go;
		}

		/// <summary>
		///     Called when the game is fully closed
		/// </summary>
		/// <remarks>GameManager.OnApplicationQuit</remarks>
		// Token: 0x0600476B RID: 18283 RVA: 0x00183194 File Offset: 0x00181394
		internal static void OnApplicationQuit()
		{
			Logger.APILogger.LogFine("OnApplicationQuit Invoked");
			if (ModHooks.ApplicationQuitHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.ApplicationQuitHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever a HitInstance is created. Overrides normal functionality
		/// </summary>
		/// <remarks>HutongGames.PlayMaker.Actions.TakeDamage</remarks>
		// Token: 0x0600476C RID: 18284 RVA: 0x00183200 File Offset: 0x00181400
		internal static HitInstance OnHitInstanceBeforeHit(Fsm owner, HitInstance hit)
		{
			Logger.APILogger.LogFine("OnHitInstance Invoked");
			if (ModHooks.HitInstanceHook == null)
			{
				return hit;
			}
			foreach (HitInstanceHandler hitInstanceHandler in ModHooks.HitInstanceHook.GetInvocationList())
			{
				try
				{
					hit = hitInstanceHandler(owner, hit);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return hit;
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x00183274 File Offset: 0x00181474
		internal static void OnDrawBlackBorders(List<GameObject> borders)
		{
			Logger.APILogger.LogFine("OnDrawBlackBorders Invoked");
			if (ModHooks.DrawBlackBordersHook == null)
			{
				return;
			}
			foreach (Action<List<GameObject>> action in ModHooks.DrawBlackBordersHook.GetInvocationList())
			{
				try
				{
					action(borders);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x001832E4 File Offset: 0x001814E4
		internal static bool OnEnableEnemy(GameObject enemy, bool isAlreadyDead)
		{
			Logger.APILogger.LogFine("OnEnableEnemy Invoked");
			if (ModHooks.OnEnableEnemyHook == null)
			{
				return isAlreadyDead;
			}
			foreach (OnEnableEnemyHandler onEnableEnemyHandler in ModHooks.OnEnableEnemyHook.GetInvocationList())
			{
				try
				{
					isAlreadyDead = onEnableEnemyHandler(enemy, isAlreadyDead);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return isAlreadyDead;
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x00183358 File Offset: 0x00181558
		internal static void OnRecieveDeathEvent(EnemyDeathEffects enemyDeathEffects, bool eventAlreadyRecieved, ref float? attackDirection, ref bool resetDeathEvent, ref bool spellBurn, ref bool isWatery)
		{
			Logger.APILogger.LogFine("OnRecieveDeathEvent Invoked");
			if (ModHooks.OnReceiveDeathEventHook == null)
			{
				return;
			}
			foreach (OnReceiveDeathEventHandler onReceiveDeathEventHandler in ModHooks.OnReceiveDeathEventHook.GetInvocationList())
			{
				try
				{
					onReceiveDeathEventHandler(enemyDeathEffects, eventAlreadyRecieved, ref attackDirection, ref resetDeathEvent, ref spellBurn, ref isWatery);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x001833CC File Offset: 0x001815CC
		internal static void OnRecordKillForJournal(EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey)
		{
			Logger.APILogger.LogFine("RecordKillForJournal Invoked");
			if (ModHooks.RecordKillForJournalHook == null)
			{
				return;
			}
			foreach (RecordKillForJournalHandler recordKillForJournalHandler in ModHooks.RecordKillForJournalHook.GetInvocationList())
			{
				try
				{
					recordKillForJournalHandler(enemyDeathEffects, playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey, newDataBoolPlayerDataLookupKey);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x00183440 File Offset: 0x00181640
		internal static void SetPlayerBool(string target, bool orig, PlayerData pd)
		{
			bool flag = orig;
			if (ModHooks.SetPlayerBoolHook != null)
			{
				foreach (SetBoolProxy setBoolProxy in ModHooks.SetPlayerBoolHook.GetInvocationList())
				{
					try
					{
						flag = setBoolProxy(target, flag);
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetBoolInternal(target, flag);
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x001834AC File Offset: 0x001816AC
		internal static bool GetPlayerBool(string target, PlayerData pd)
		{
			bool flag = pd.GetBoolInternal(target);
			if (ModHooks.GetPlayerBoolHook == null)
			{
				return flag;
			}
			foreach (GetBoolProxy getBoolProxy in ModHooks.GetPlayerBoolHook.GetInvocationList())
			{
				try
				{
					flag = getBoolProxy(target, flag);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return flag;
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x00183518 File Offset: 0x00181718
		internal static void SetPlayerInt(string target, int orig, PlayerData pd)
		{
			int num = orig;
			if (ModHooks.SetPlayerIntHook != null)
			{
				foreach (SetIntProxy setIntProxy in ModHooks.SetPlayerIntHook.GetInvocationList())
				{
					try
					{
						num = setIntProxy(target, num);
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetIntInternal(target, num);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x00183584 File Offset: 0x00181784
		internal static int GetPlayerInt(string target, PlayerData pd)
		{
			int num = pd.GetIntInternal(target);
			if (ModHooks.GetPlayerIntHook == null)
			{
				return num;
			}
			foreach (GetIntProxy getIntProxy in ModHooks.GetPlayerIntHook.GetInvocationList())
			{
				try
				{
					num = getIntProxy(target, num);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return num;
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x001835F0 File Offset: 0x001817F0
		internal static void SetPlayerFloat(string target, float orig, PlayerData pd)
		{
			float num = orig;
			if (ModHooks.SetPlayerFloatHook != null)
			{
				foreach (SetFloatProxy setFloatProxy in ModHooks.SetPlayerFloatHook.GetInvocationList())
				{
					try
					{
						num = setFloatProxy(target, num);
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetFloatInternal(target, num);
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x0018365C File Offset: 0x0018185C
		internal static float GetPlayerFloat(string target, PlayerData pd)
		{
			float num = pd.GetFloatInternal(target);
			if (ModHooks.GetPlayerFloatHook == null)
			{
				return num;
			}
			foreach (GetFloatProxy getFloatProxy in ModHooks.GetPlayerFloatHook.GetInvocationList())
			{
				try
				{
					num = getFloatProxy(target, num);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return num;
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x001836C8 File Offset: 0x001818C8
		internal static void SetPlayerString(string target, string orig, PlayerData pd)
		{
			string text = orig;
			if (ModHooks.SetPlayerStringHook != null)
			{
				foreach (SetStringProxy setStringProxy in ModHooks.SetPlayerStringHook.GetInvocationList())
				{
					try
					{
						text = setStringProxy(target, text);
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetStringInternal(target, text);
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x00183734 File Offset: 0x00181934
		internal static string GetPlayerString(string target, PlayerData pd)
		{
			string text = pd.GetStringInternal(target);
			if (ModHooks.GetPlayerStringHook == null)
			{
				return text;
			}
			foreach (GetStringProxy getStringProxy in ModHooks.GetPlayerStringHook.GetInvocationList())
			{
				try
				{
					text = getStringProxy(target, text);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return text;
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x001837A0 File Offset: 0x001819A0
		internal static void SetPlayerVector3(string target, Vector3 orig, PlayerData pd)
		{
			Vector3 vector = orig;
			if (ModHooks.SetPlayerVector3Hook != null)
			{
				foreach (SetVector3Proxy setVector3Proxy in ModHooks.SetPlayerVector3Hook.GetInvocationList())
				{
					try
					{
						vector = setVector3Proxy(target, vector);
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetVector3Internal(target, vector);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0018380C File Offset: 0x00181A0C
		internal static Vector3 GetPlayerVector3(string target, PlayerData pd)
		{
			Vector3 vector = pd.GetVector3Internal(target);
			if (ModHooks.GetPlayerVector3Hook == null)
			{
				return vector;
			}
			foreach (GetVector3Proxy getVector3Proxy in ModHooks.GetPlayerVector3Hook.GetInvocationList())
			{
				try
				{
					vector = getVector3Proxy(target, vector);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return vector;
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x00183878 File Offset: 0x00181A78
		internal static void SetPlayerVariable<T>(string target, T orig, PlayerData pd)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle == typeof(bool))
			{
				ModHooks.SetPlayerBool(target, (bool)((object)orig), pd);
				return;
			}
			if (typeFromHandle == typeof(int))
			{
				ModHooks.SetPlayerInt(target, (int)((object)orig), pd);
				return;
			}
			if (typeFromHandle == typeof(float))
			{
				ModHooks.SetPlayerFloat(target, (float)((object)orig), pd);
				return;
			}
			if (typeFromHandle == typeof(string))
			{
				ModHooks.SetPlayerString(target, (string)((object)orig), pd);
				return;
			}
			if (typeFromHandle == typeof(Vector3))
			{
				ModHooks.SetPlayerVector3(target, (Vector3)((object)orig), pd);
				return;
			}
			T t = orig;
			if (ModHooks.SetPlayerVariableHook != null)
			{
				foreach (SetVariableProxy setVariableProxy in ModHooks.SetPlayerVariableHook.GetInvocationList())
				{
					try
					{
						t = (T)((object)setVariableProxy(typeFromHandle, target, t));
					}
					catch (Exception message)
					{
						Logger.APILogger.LogError(message);
					}
				}
			}
			pd.SetVariableInternal<T>(target, t);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001839B4 File Offset: 0x00181BB4
		internal static T GetPlayerVariable<T>(string target, PlayerData pd)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle == typeof(bool))
			{
				return (T)((object)ModHooks.GetPlayerBool(target, pd));
			}
			if (typeFromHandle == typeof(int))
			{
				return (T)((object)ModHooks.GetPlayerInt(target, pd));
			}
			if (typeFromHandle == typeof(float))
			{
				return (T)((object)ModHooks.GetPlayerFloat(target, pd));
			}
			if (typeFromHandle == typeof(string))
			{
				return (T)((object)ModHooks.GetPlayerString(target, pd));
			}
			if (typeFromHandle == typeof(Vector3))
			{
				return (T)((object)ModHooks.GetPlayerVector3(target, pd));
			}
			T t = pd.GetVariableInternal<T>(target);
			if (ModHooks.GetPlayerVariableHook == null)
			{
				return t;
			}
			foreach (GetVariableProxy getVariableProxy in ModHooks.GetPlayerVariableHook.GetInvocationList())
			{
				try
				{
					t = (T)((object)getVariableProxy(typeFromHandle, target, t));
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return t;
		}

		/// <summary>
		///     Called whenever blue health is updated
		/// </summary>
		// Token: 0x0600477D RID: 18301 RVA: 0x00183AE8 File Offset: 0x00181CE8
		internal static int OnBlueHealth()
		{
			Logger.APILogger.LogFine("OnBlueHealth Invoked");
			int result = 0;
			if (ModHooks.BlueHealthHook == null)
			{
				return result;
			}
			foreach (Func<int> func in ModHooks.BlueHealthHook.GetInvocationList())
			{
				try
				{
					result = func();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return result;
		}

		/// <summary>
		///     Called when health is taken from the player
		/// </summary>
		/// <remarks>HeroController.TakeHealth</remarks>
		// Token: 0x0600477E RID: 18302 RVA: 0x00183B5C File Offset: 0x00181D5C
		internal static int OnTakeHealth(int damage)
		{
			Logger.APILogger.LogFine("OnTakeHealth Invoked");
			if (ModHooks.TakeHealthHook == null)
			{
				return damage;
			}
			foreach (TakeHealthProxy takeHealthProxy in ModHooks.TakeHealthHook.GetInvocationList())
			{
				try
				{
					damage = takeHealthProxy(damage);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return damage;
		}

		/// <summary>
		///     Called when damage is dealt to the player, at the start of the take damage function.
		/// </summary>
		/// <remarks>HeroController.TakeDamage</remarks>
		// Token: 0x0600477F RID: 18303 RVA: 0x00183BD0 File Offset: 0x00181DD0
		internal static int OnTakeDamage(ref int hazardType, int damage)
		{
			Logger.APILogger.LogFine("OnTakeDamage Invoked");
			if (ModHooks.TakeDamageHook == null)
			{
				return damage;
			}
			foreach (TakeDamageProxy takeDamageProxy in ModHooks.TakeDamageHook.GetInvocationList())
			{
				try
				{
					damage = takeDamageProxy(ref hazardType, damage);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return damage;
		}

		/// <summary>
		///     Called in the take damage function, immediately before applying damage (just before checking overcharm)
		/// </summary>
		// Token: 0x06004780 RID: 18304 RVA: 0x00183C44 File Offset: 0x00181E44
		internal static int AfterTakeDamage(int hazardType, int damageAmount)
		{
			Logger.APILogger.LogFine("AfterTakeDamage Invoked");
			if (ModHooks.AfterTakeDamageHook == null)
			{
				return damageAmount;
			}
			foreach (AfterTakeDamageHandler afterTakeDamageHandler in ModHooks.AfterTakeDamageHook.GetInvocationList())
			{
				try
				{
					damageAmount = afterTakeDamageHandler(hazardType, damageAmount);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return damageAmount;
		}

		/// <summary>
		///     Called when the player dies (at the beginning of the method)
		/// </summary>
		/// <remarks>GameManager.PlayerDead</remarks>
		// Token: 0x06004781 RID: 18305 RVA: 0x00183CB8 File Offset: 0x00181EB8
		internal static void OnBeforePlayerDead()
		{
			Logger.APILogger.LogFine("OnBeforePlayerDead Invoked");
			if (ModHooks.BeforePlayerDeadHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.BeforePlayerDeadHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called after the player dies (at the end of the method)
		/// </summary>
		/// <remarks>GameManager.PlayerDead</remarks>
		// Token: 0x06004782 RID: 18306 RVA: 0x00183D24 File Offset: 0x00181F24
		internal static void OnAfterPlayerDead()
		{
			Logger.APILogger.LogFine("OnAfterPlayerDead Invoked");
			if (ModHooks.AfterPlayerDeadHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.AfterPlayerDeadHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever the player attacks
		/// </summary>
		/// <remarks>HeroController.Attack</remarks>
		// Token: 0x06004783 RID: 18307 RVA: 0x00183D90 File Offset: 0x00181F90
		internal static void OnAttack(AttackDirection dir)
		{
			Logger.APILogger.LogFine("OnAttack Invoked");
			if (ModHooks.AttackHook == null)
			{
				return;
			}
			foreach (Action<AttackDirection> action in ModHooks.AttackHook.GetInvocationList())
			{
				try
				{
					action(dir);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called at the start of the DoAttack function
		/// </summary>
		// Token: 0x06004784 RID: 18308 RVA: 0x00183E00 File Offset: 0x00182000
		internal static void OnDoAttack()
		{
			Logger.APILogger.LogFine("OnDoAttack Invoked");
			if (ModHooks.DoAttackHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.DoAttackHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called at the end of the attack function
		/// </summary>
		/// <remarks>HeroController.Attack</remarks>
		// Token: 0x06004785 RID: 18309 RVA: 0x00183E6C File Offset: 0x0018206C
		internal static void AfterAttack(AttackDirection dir)
		{
			Logger.APILogger.LogFine("AfterAttack Invoked");
			if (ModHooks.AfterAttackHook == null)
			{
				return;
			}
			foreach (Action<AttackDirection> action in ModHooks.AfterAttackHook.GetInvocationList())
			{
				try
				{
					action(dir);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever nail strikes something
		/// </summary>
		// Token: 0x06004786 RID: 18310 RVA: 0x00183EDC File Offset: 0x001820DC
		internal static void OnSlashHit(Collider2D otherCollider, GameObject gameObject)
		{
			Logger.APILogger.LogFine("OnSlashHit Invoked");
			if (otherCollider == null)
			{
				return;
			}
			if (ModHooks.SlashHitHook == null)
			{
				return;
			}
			foreach (SlashHitHandler slashHitHandler in ModHooks.SlashHitHook.GetInvocationList())
			{
				try
				{
					slashHitHandler(otherCollider, gameObject);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00183F54 File Offset: 0x00182154
		internal static void OnCharmUpdate(PlayerData pd, HeroController hc)
		{
			Logger.APILogger.LogFine("OnCharmUpdate Invoked");
			if (ModHooks.CharmUpdateHook == null)
			{
				return;
			}
			foreach (CharmUpdateHandler charmUpdateHandler in ModHooks.CharmUpdateHook.GetInvocationList())
			{
				try
				{
					charmUpdateHandler(pd, hc);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever the hero updates
		/// </summary>
		/// <remarks>HeroController.Update</remarks>
		// Token: 0x06004788 RID: 18312 RVA: 0x00183FC4 File Offset: 0x001821C4
		internal static void OnHeroUpdate()
		{
			if (ModHooks.HeroUpdateHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.HeroUpdateHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever the player heals
		/// </summary>
		/// <remarks>PlayerData.health</remarks>
		// Token: 0x06004789 RID: 18313 RVA: 0x00184024 File Offset: 0x00182224
		internal static int BeforeAddHealth(int amount)
		{
			Logger.APILogger.LogFine("BeforeAddHealth Invoked");
			if (ModHooks.BeforeAddHealthHook == null)
			{
				return amount;
			}
			foreach (Func<int, int> func in ModHooks.BeforeAddHealthHook.GetInvocationList())
			{
				try
				{
					amount = func(amount);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return amount;
		}

		/// <summary>
		///     Called whenever focus cost is calculated
		/// </summary>
		// Token: 0x0600478A RID: 18314 RVA: 0x00184098 File Offset: 0x00182298
		internal static float OnFocusCost()
		{
			Logger.APILogger.LogFine("OnFocusCost Invoked");
			float result = 1f;
			if (ModHooks.FocusCostHook == null)
			{
				return result;
			}
			foreach (Func<float> func in ModHooks.FocusCostHook.GetInvocationList())
			{
				try
				{
					result = func();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return result;
		}

		/// <summary>
		///     Called when Hero recovers Soul from hitting enemies
		/// </summary>
		// Token: 0x0600478B RID: 18315 RVA: 0x00184110 File Offset: 0x00182310
		internal static int OnSoulGain(int num)
		{
			Logger.APILogger.LogFine("OnSoulGain Invoked");
			if (ModHooks.SoulGainHook == null)
			{
				return num;
			}
			foreach (Func<int, int> func in ModHooks.SoulGainHook.GetInvocationList())
			{
				try
				{
					num = func(num);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return num;
		}

		/// <summary>
		///     Called during dash function to change velocity
		/// </summary>
		/// <remarks>HeroController.Dash</remarks>
		// Token: 0x0600478C RID: 18316 RVA: 0x00184184 File Offset: 0x00182384
		internal static Vector2 DashVelocityChange(Vector2 change)
		{
			Logger.APILogger.LogFine("DashVelocityChange Invoked");
			if (ModHooks.DashVectorHook == null)
			{
				return change;
			}
			foreach (Func<Vector2, Vector2> func in ModHooks.DashVectorHook.GetInvocationList())
			{
				try
				{
					change = func(change);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return change;
		}

		/// <summary>
		///     Called whenever the dash key is pressed. Returns whether or not to override normal dash functionality
		/// </summary>
		/// <remarks>HeroController.LookForQueueInput</remarks>
		// Token: 0x0600478D RID: 18317 RVA: 0x001841F8 File Offset: 0x001823F8
		internal static bool OnDashPressed()
		{
			Logger.APILogger.LogFine("OnDashPressed Invoked");
			if (ModHooks.DashPressedHook == null)
			{
				return false;
			}
			bool flag = false;
			foreach (Func<bool> func in ModHooks.DashPressedHook.GetInvocationList())
			{
				try
				{
					flag |= func();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return flag;
		}

		/// <summary>
		///     Called directly after a save has been loaded
		/// </summary>
		/// <remarks>GameManager.LoadGame</remarks>
		// Token: 0x0600478E RID: 18318 RVA: 0x00184270 File Offset: 0x00182470
		internal static void OnSavegameLoad(int id)
		{
			Logger.APILogger.LogFine("OnSavegameLoad Invoked");
			if (ModHooks.SavegameLoadHook == null)
			{
				return;
			}
			foreach (Action<int> action in ModHooks.SavegameLoadHook.GetInvocationList())
			{
				try
				{
					action(id);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called directly after a save has been saved
		/// </summary>
		/// <remarks>GameManager.SaveGame</remarks>
		// Token: 0x0600478F RID: 18319 RVA: 0x001842E0 File Offset: 0x001824E0
		internal static void OnSavegameSave(int id)
		{
			Logger.APILogger.LogFine("OnSavegameSave Invoked");
			if (ModHooks.SavegameSaveHook == null)
			{
				return;
			}
			foreach (Action<int> action in ModHooks.SavegameSaveHook.GetInvocationList())
			{
				try
				{
					action(id);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called whenever a new game is started
		/// </summary>
		/// <remarks>GameManager.LoadFirstScene</remarks>
		// Token: 0x06004790 RID: 18320 RVA: 0x00184350 File Offset: 0x00182550
		internal static void OnNewGame()
		{
			Logger.APILogger.LogFine("OnNewGame Invoked");
			if (ModHooks.NewGameHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks.NewGameHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called before a save file is deleted
		/// </summary>
		/// <remarks>GameManager.ClearSaveFile</remarks>
		// Token: 0x06004791 RID: 18321 RVA: 0x001843BC File Offset: 0x001825BC
		internal static void OnSavegameClear(int id)
		{
			Logger.APILogger.LogFine("OnSavegameClear Invoked");
			if (ModHooks.SavegameClearHook == null)
			{
				return;
			}
			foreach (Action<int> action in ModHooks.SavegameClearHook.GetInvocationList())
			{
				try
				{
					action(id);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called directly after a save has been loaded.  Allows for accessing SaveGame instance.
		/// </summary>
		/// <remarks>GameManager.LoadGame</remarks>
		// Token: 0x06004792 RID: 18322 RVA: 0x0018442C File Offset: 0x0018262C
		internal static void OnAfterSaveGameLoad(SaveGameData data)
		{
			Logger.APILogger.LogFine("OnAfterSaveGameLoad Invoked");
			if (ModHooks.AfterSavegameLoadHook == null)
			{
				return;
			}
			foreach (Action<SaveGameData> action in ModHooks.AfterSavegameLoadHook.GetInvocationList())
			{
				try
				{
					action(data);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called directly before save has been saved to allow for changes to the data before persisted.
		/// </summary>
		/// <remarks>GameManager.SaveGame</remarks>
		// Token: 0x06004793 RID: 18323 RVA: 0x0018449C File Offset: 0x0018269C
		internal static void OnBeforeSaveGameSave(SaveGameData data)
		{
			Logger.APILogger.LogFine("OnBeforeSaveGameSave Invoked");
			if (ModHooks.BeforeSavegameSaveHook == null)
			{
				return;
			}
			foreach (Action<SaveGameData> action in ModHooks.BeforeSavegameSaveHook.GetInvocationList())
			{
				try
				{
					action(data);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Overrides the filename to load for a given slot.  Return null to use vanilla names.
		/// </summary>
		// Token: 0x06004794 RID: 18324 RVA: 0x0018450C File Offset: 0x0018270C
		internal static string GetSaveFileName(int saveSlot)
		{
			Logger.APILogger.LogFine("GetSaveFileName Invoked");
			if (ModHooks.GetSaveFileNameHook == null)
			{
				return null;
			}
			string result = null;
			foreach (Func<int, string> func in ModHooks.GetSaveFileNameHook.GetInvocationList())
			{
				try
				{
					result = func(saveSlot);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return result;
		}

		/// <summary>
		///     Called after a game has been cleared from a slot.
		/// </summary>
		// Token: 0x06004795 RID: 18325 RVA: 0x00184580 File Offset: 0x00182780
		internal static void OnAfterSaveGameClear(int saveSlot)
		{
			Logger.APILogger.LogFine("OnAfterSaveGameClear Invoked");
			if (ModHooks.AfterSaveGameClearHook == null)
			{
				return;
			}
			foreach (Action<int> action in ModHooks.AfterSaveGameClearHook.GetInvocationList())
			{
				try
				{
					action(saveSlot);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x001845F0 File Offset: 0x001827F0
		internal static void OnSaveLocalSettings(ModSavegameData data)
		{
			data.loadedMods = ModHooks.LoadedModsWithVersions;
			Action<ModSavegameData> saveLocalSettings = ModHooks.SaveLocalSettings;
			if (saveLocalSettings == null)
			{
				return;
			}
			saveLocalSettings(data);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x0018460D File Offset: 0x0018280D
		internal static void OnLoadLocalSettings(ModSavegameData data)
		{
			Action<ModSavegameData> loadLocalSettings = ModHooks.LoadLocalSettings;
			if (loadLocalSettings == null)
			{
				return;
			}
			loadLocalSettings(data);
		}

		/// <summary>
		///     Called after a new Scene has been loaded
		/// </summary>
		/// <remarks>N/A</remarks>
		// Token: 0x06004798 RID: 18328 RVA: 0x00184620 File Offset: 0x00182820
		internal static void OnSceneChanged(string targetScene)
		{
			Logger.APILogger.LogFine("OnSceneChanged Invoked");
			if (ModHooks.SceneChanged == null)
			{
				return;
			}
			foreach (Action<string> action in ModHooks.SceneChanged.GetInvocationList())
			{
				try
				{
					action(targetScene);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		/// <summary>
		///     Called right before a scene gets loaded, can change which scene gets loaded
		/// </summary>
		/// <remarks>N/A</remarks>
		// Token: 0x06004799 RID: 18329 RVA: 0x00184690 File Offset: 0x00182890
		internal static string BeforeSceneLoad(string sceneName)
		{
			Logger.APILogger.LogFine("BeforeSceneLoad Invoked");
			if (ModHooks.BeforeSceneLoadHook == null)
			{
				return sceneName;
			}
			foreach (Func<string, string> func in ModHooks.BeforeSceneLoadHook.GetInvocationList())
			{
				try
				{
					sceneName = func(sceneName);
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
			return sceneName;
		}

		/// <summary>
		/// Gets a mod instance by name.
		/// </summary>
		/// <param name="name">The name of the mod.</param>
		/// <param name="onlyEnabled">Should the method only return the mod if it is enabled.</param>
		/// <param name="allowLoadError">Should the method return the mod even if it had load errors.</param>
		/// <returns></returns>
		// Token: 0x0600479A RID: 18330 RVA: 0x00184704 File Offset: 0x00182904
		public static IMod GetMod(string name, bool onlyEnabled = false, bool allowLoadError = false)
		{
			ModLoader.ModInstance modInstance;
			if (ModLoader.ModInstanceNameMap.TryGetValue(name, out modInstance) && (!onlyEnabled || modInstance.Enabled))
			{
				if (!allowLoadError)
				{
					ModLoader.ModErrorState? error = modInstance.Error;
					if (error != null)
					{
						goto IL_2D;
					}
				}
				return modInstance.Mod;
			}
			IL_2D:
			return null;
		}

		/// <summary>
		/// Gets a mod instance by type.
		/// </summary>
		/// <param name="type">The type of the mod.</param>
		/// <param name="onlyEnabled">Should the method only return the mod if it is enabled.</param>
		/// <param name="allowLoadError">Should the method return the mod even if it had load errors.</param>
		/// <returns></returns>
		// Token: 0x0600479B RID: 18331 RVA: 0x00184748 File Offset: 0x00182948
		public static IMod GetMod(Type type, bool onlyEnabled = false, bool allowLoadError = false)
		{
			ModLoader.ModInstance modInstance;
			if (ModLoader.ModInstanceTypeMap.TryGetValue(type, out modInstance) && (!onlyEnabled || modInstance.Enabled))
			{
				if (!allowLoadError)
				{
					ModLoader.ModErrorState? error = modInstance.Error;
					if (error != null)
					{
						goto IL_2D;
					}
				}
				return modInstance.Mod;
			}
			IL_2D:
			return null;
		}

		/// <summary>
		/// Gets if the mod is currently enabled.
		/// </summary>
		/// <param name="mod">The togglable mod to check.</param>
		/// <returns></returns>
		// Token: 0x0600479C RID: 18332 RVA: 0x0018478A File Offset: 0x0018298A
		public static bool ModEnabled(ITogglableMod mod)
		{
			return ModHooks.ModEnabled(mod.GetType());
		}

		/// <summary>
		/// Gets if a mod is currently enabled.
		/// </summary>
		/// <param name="name">The name of the mod to check.</param>
		/// <returns></returns>
		// Token: 0x0600479D RID: 18333 RVA: 0x00184798 File Offset: 0x00182998
		public static bool ModEnabled(string name)
		{
			ModLoader.ModInstance modInstance;
			return !ModLoader.ModInstanceNameMap.TryGetValue(name, out modInstance) || modInstance.Enabled;
		}

		/// <summary>
		/// Gets if a mod is currently enabled.
		/// </summary>
		/// <param name="type">The type of the mod to check.</param>
		/// <returns></returns>
		// Token: 0x0600479E RID: 18334 RVA: 0x001847BC File Offset: 0x001829BC
		public static bool ModEnabled(Type type)
		{
			ModLoader.ModInstance modInstance;
			return !ModLoader.ModInstanceTypeMap.TryGetValue(type, out modInstance) || modInstance.Enabled;
		}

		/// <summary>
		/// Returns an iterator over all mods.
		/// </summary>
		/// <param name="onlyEnabled">Should the iterator only contain enabled mods.</param>
		/// <param name="allowLoadError">Should the iterator contain mods which have load errors.</param>
		/// <returns></returns>
		// Token: 0x0600479F RID: 18335 RVA: 0x001847E0 File Offset: 0x001829E0
		public static IEnumerable<IMod> GetAllMods(bool onlyEnabled = false, bool allowLoadError = false)
		{
			return from x in ModLoader.ModInstances.Where(delegate(ModLoader.ModInstance x)
			{
				if (onlyEnabled && !x.Enabled)
				{
					return false;
				}
				if (!allowLoadError)
				{
					ModLoader.ModErrorState? error = x.Error;
					return error == null;
				}
				return true;
			})
			select x.Mod;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0018483C File Offset: 0x00182A3C
		internal static void OnFinishedLoadingMods()
		{
			if (ModHooks._finishedLoadingModsHook == null)
			{
				return;
			}
			foreach (Action action in ModHooks._finishedLoadingModsHook.GetInvocationList())
			{
				try
				{
					action();
				}
				catch (Exception message)
				{
					Logger.APILogger.LogError(message);
				}
			}
		}

		// Token: 0x04004B99 RID: 19353
		private const int _modVersion = 77;

		// Token: 0x04004B9A RID: 19354
		private static readonly string SettingsPath;

		// Token: 0x04004B9B RID: 19355
		private static ModHooks _instance;

		/// <summary>
		///     Dictionary of mods and their version #s
		/// </summary>
		// Token: 0x04004B9C RID: 19356
		public static readonly Dictionary<string, string> LoadedModsWithVersions;

		// Token: 0x04004B9D RID: 19357
		private static Console _console;

		/// <summary>
		///     The Version of the Modding API
		/// </summary>
		// Token: 0x04004B9E RID: 19358
		public static string ModVersion;

		/// <summary>
		///     Version of the Game
		/// </summary>
		// Token: 0x04004B9F RID: 19359
		public static GameVersionData version;
	}
}
