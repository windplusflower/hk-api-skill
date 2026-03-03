using System;
using System.Collections.Generic;
using GlobalEnums;
using Language;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding
{
	// Token: 0x02000D75 RID: 3445
	internal class ModListMenu
	{
		// Token: 0x060047A9 RID: 18345 RVA: 0x00184938 File Offset: 0x00182B38
		internal void InitMenuCreation()
		{
			UIManager.BeforeHideDynamicMenu += this.ToggleMods;
			UIManager.EditMenus += delegate()
			{
				ModListMenu.ModScreens = new Dictionary<IMod, MenuScreen>();
				MenuBuilder menuBuilder = new MenuBuilder("ModListMenu");
				this.screen = menuBuilder.Screen;
				menuBuilder.CreateTitle("Mods", MenuTitleStyle.vanillaStyle).SetDefaultNavGraph(new ChainedNavGraph(ChainedNavGraph.ChainDir.Down)).CreateContentPane(RectTransformData.FromSizeAndPos(new RelVector2(new Vector2(1920f, 903f)), new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -60f)))).CreateControlPane(RectTransformData.FromSizeAndPos(new RelVector2(new Vector2(1920f, 259f)), new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -502f)))).AddContent(default(NullContentLayout), delegate(ContentArea c)
				{
					ScrollbarConfig config = default(ScrollbarConfig);
					config.CancelAction = delegate(MenuPreventDeselect _)
					{
						this.ApplyChanges();
					};
					config.Navigation = new Navigation
					{
						mode = Navigation.Mode.Explicit
					};
					config.Position = new AnchoredPosition
					{
						ChildAnchor = new Vector2(0f, 1f),
						ParentAnchor = new Vector2(1f, 1f),
						Offset = new Vector2(-310f, 0f)
					};
					config.SelectionPadding = ((RectTransform _) => new ValueTuple<float, float>(-120f, 120f));
					c.AddScrollPaneContent(config, new RelLength(0f), RegularGridLayout.CreateVerticalLayout(105f, default(Vector2)), delegate(ContentArea c)
					{
						using (HashSet<ModLoader.ModInstance>.Enumerator enumerator = ModLoader.ModInstances.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ModLoader.ModInstance modInst = enumerator.Current;
								if (modInst.Error == null)
								{
									ModToggleDelegates? toggleDelegates = null;
									if (modInst.Mod is ITogglableMod)
									{
										try
										{
											IMod mod = modInst.Mod;
											IMenuMod menuMod = mod as IMenuMod;
											bool flag;
											if (menuMod == null || !menuMod.ToggleButtonInsideMenu)
											{
												ICustomMenuMod customMenuMod = mod as ICustomMenuMod;
												if (customMenuMod == null || !customMenuMod.ToggleButtonInsideMenu)
												{
													flag = false;
													goto IL_9A;
												}
											}
											flag = true;
											IL_9A:
											if (!flag)
											{
												RectTransform component = c.ContentObject.GetComponent<RectTransform>();
												component.sizeDelta = new Vector2(0f, component.sizeDelta.y + 105f);
												MenuOptionHorizontal menuOptionHorizontal;
												c.AddHorizontalOption(modInst.Name, new HorizontalOptionConfig
												{
													ApplySetting = delegate(MenuSetting self, int ind)
													{
														this.changedMods[modInst] = (ind == 1);
													},
													CancelAction = delegate(MenuSelectable _)
													{
														this.ApplyChanges();
													},
													Label = modInst.Name,
													Options = new string[]
													{
														Language.Get("MOH_OFF", "MainMenu"),
														Language.Get("MOH_ON", "MainMenu")
													},
													RefreshSetting = delegate(MenuSetting self, bool apply)
													{
														self.optionList.SetOptionTo((modInst.Enabled > false) ? 1 : 0);
													},
													Style = new HorizontalOptionStyle?(HorizontalOptionStyle.VanillaStyle),
													Description = new DescriptionInfo?(new DescriptionInfo
													{
														Text = "v" + modInst.Mod.GetVersionSafe("???")
													})
												}, out menuOptionHorizontal);
												menuOptionHorizontal.menuSetting.RefreshValueFromGameSettings(false);
											}
											else
											{
												ModToggleDelegates value = default(ModToggleDelegates);
												value.SetModEnabled = delegate(bool enabled)
												{
													this.changedMods[modInst] = enabled;
												};
												value.GetModEnabled = (() => modInst.Enabled);
												value.ApplyChange = delegate()
												{
												};
												toggleDelegates = new ModToggleDelegates?(value);
											}
										}
										catch (Exception message)
										{
											Logger.APILogger.LogError(message);
										}
									}
									if (modInst.Mod is IMenuMod)
									{
										try
										{
											MenuScreen menu = this.CreateModMenu(modInst, toggleDelegates);
											RectTransform component2 = c.ContentObject.GetComponent<RectTransform>();
											component2.sizeDelta = new Vector2(0f, component2.sizeDelta.y + 105f);
											c.AddMenuButton(modInst.Name + "_Settings", new MenuButtonConfig
											{
												Style = new MenuButtonStyle?(MenuButtonStyle.VanillaStyle),
												CancelAction = delegate(MenuSelectable _)
												{
													this.ApplyChanges();
												},
												Label = modInst.Mod.GetMenuButtonText(),
												SubmitAction = delegate(MenuButton _)
												{
													((UIManager)UIManager.instance).UIGoToDynamicMenu(menu);
												},
												Proceed = true,
												Description = new DescriptionInfo?(new DescriptionInfo
												{
													Text = "v" + modInst.Mod.GetVersionSafe("???")
												})
											});
											ModListMenu.ModScreens[modInst.Mod] = menu;
											continue;
										}
										catch (Exception ex)
										{
											Loggable apilogger = Logger.APILogger;
											string str = "Error creating menu for IMenuMod ";
											string name = modInst.Name;
											string str2 = "\n";
											Exception ex2 = ex;
											apilogger.LogError(str + name + str2 + ((ex2 != null) ? ex2.ToString() : null));
											continue;
										}
									}
									ICustomMenuMod customMenuMod2 = modInst.Mod as ICustomMenuMod;
									if (customMenuMod2 != null)
									{
										try
										{
											MenuScreen menu = customMenuMod2.GetMenuScreen(this.screen, toggleDelegates);
											RectTransform component3 = c.ContentObject.GetComponent<RectTransform>();
											component3.sizeDelta = new Vector2(0f, component3.sizeDelta.y + 105f);
											c.AddMenuButton(modInst.Name + "_Settings", new MenuButtonConfig
											{
												Style = new MenuButtonStyle?(MenuButtonStyle.VanillaStyle),
												CancelAction = delegate(MenuSelectable _)
												{
													this.ApplyChanges();
												},
												Label = modInst.Mod.GetMenuButtonText(),
												SubmitAction = delegate(MenuButton _)
												{
													((UIManager)UIManager.instance).UIGoToDynamicMenu(menu);
												},
												Proceed = true,
												Description = new DescriptionInfo?(new DescriptionInfo
												{
													Text = "v" + modInst.Mod.GetVersionSafe("???")
												})
											});
											ModListMenu.ModScreens[modInst.Mod] = menu;
										}
										catch (Exception ex3)
										{
											Loggable apilogger2 = Logger.APILogger;
											string str3 = "Error creating menu for ICustomMenuMod ";
											string name2 = modInst.Name;
											string str4 = "\n";
											Exception ex4 = ex3;
											apilogger2.LogError(str3 + name2 + str4 + ((ex4 != null) ? ex4.ToString() : null));
										}
									}
								}
							}
						}
					});
				}).AddControls(new SingleContentLayout(new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -64f))), delegate(ContentArea c)
				{
					c.AddMenuButton("BackButton", new MenuButtonConfig
					{
						Label = Language.Get("NAV_BACK", "MainMenu"),
						CancelAction = delegate(MenuSelectable _)
						{
							this.ApplyChanges();
						},
						SubmitAction = delegate(MenuButton _)
						{
							this.ApplyChanges();
						},
						Proceed = true,
						Style = new MenuButtonStyle?(MenuButtonStyle.VanillaStyle)
					});
				}).Build();
				MenuScreen optionsMenuScreen = UIManager.instance.optionsMenuScreen;
				MenuButtonList mbl = (MenuButtonList)optionsMenuScreen.gameObject.GetComponent<MenuButtonList>();
				new ContentArea(optionsMenuScreen.content.gameObject, new SingleContentLayout(new Vector2(0.5f, 0.5f))).AddWrappedItem("ModMenuButtonWrapper", delegate(ContentArea c)
				{
					string name = "ModMenuButton";
					MenuButtonConfig config = default(MenuButtonConfig);
					config.CancelAction = delegate(MenuSelectable self)
					{
						UIManager.instance.UILeaveOptionsMenu();
					};
					config.Label = "Mods";
					config.SubmitAction = new Action<MenuButton>(this.GoToModListMenu);
					config.Proceed = true;
					config.Style = new MenuButtonStyle?(MenuButtonStyle.VanillaStyle);
					MenuButton sel;
					c.AddMenuButton(name, config, out sel);
					mbl.AddSelectableEnd(sel, 1);
				});
				mbl.RecalculateNavigation();
			};
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0018495C File Offset: 0x00182B5C
		private void ToggleMods()
		{
			foreach (KeyValuePair<ModLoader.ModInstance, bool> self in this.changedMods)
			{
				ModLoader.ModInstance modInstance;
				bool flag;
				self.Deconstruct(out modInstance, out flag);
				ModLoader.ModInstance modInstance2 = modInstance;
				bool flag2 = flag;
				string name = modInstance2.Name;
				if (flag2)
				{
					ModLoader.LoadMod(modInstance2, true, null);
				}
				else
				{
					ModLoader.UnloadMod(modInstance2, true);
				}
			}
			this.changedMods.Clear();
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x001849DC File Offset: 0x00182BDC
		private void ApplyChanges()
		{
			this.ToggleMods();
			((UIManager)UIManager.instance).UILeaveDynamicMenu(UIManager.instance.optionsMenuScreen, MainMenuState.OPTIONS_MENU);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00184A00 File Offset: 0x00182C00
		private MenuScreen CreateModMenu(ModLoader.ModInstance modInst, ModToggleDelegates? toggleDelegates)
		{
			IMenuMod menuMod = modInst.Mod as IMenuMod;
			IMenuMod.MenuEntry? menuEntry;
			if (toggleDelegates != null)
			{
				ModToggleDelegates dels = toggleDelegates.GetValueOrDefault();
				menuEntry = new IMenuMod.MenuEntry?(new IMenuMod.MenuEntry
				{
					Name = modInst.Name,
					Values = new string[]
					{
						Language.Get("MOH_OFF", "MainMenu"),
						Language.Get("MOH_ON", "MainMenu")
					},
					Saver = delegate(int v)
					{
						dels.SetModEnabled(v == 1);
					},
					Loader = (() => (dels.GetModEnabled() > false) ? 1 : 0)
				});
			}
			else
			{
				menuEntry = null;
			}
			IMenuMod.MenuEntry? toggleButtonEntry = menuEntry;
			string name = modInst.Name;
			List<IMenuMod.MenuEntry> menuData = menuMod.GetMenuData(toggleButtonEntry);
			return MenuUtils.CreateMenuScreen(name, menuData, this.screen);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x00184AD1 File Offset: 0x00182CD1
		private void GoToModListMenu(object _)
		{
			this.GoToModListMenu();
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x00184AD9 File Offset: 0x00182CD9
		private void GoToModListMenu()
		{
			((UIManager)UIManager.instance).UIGoToDynamicMenu(this.screen);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00184AF0 File Offset: 0x00182CF0
		public ModListMenu()
		{
			this.changedMods = new Dictionary<ModLoader.ModInstance, bool>();
			base..ctor();
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00184B03 File Offset: 0x00182D03
		// Note: this type is marked as 'beforefieldinit'.
		static ModListMenu()
		{
			ModListMenu.ModScreens = new Dictionary<IMod, MenuScreen>();
		}

		// Token: 0x04004BE6 RID: 19430
		private MenuScreen screen;

		// Token: 0x04004BE7 RID: 19431
		private Dictionary<ModLoader.ModInstance, bool> changedMods;

		// Token: 0x04004BE8 RID: 19432
		public static Dictionary<IMod, MenuScreen> ModScreens;
	}
}
