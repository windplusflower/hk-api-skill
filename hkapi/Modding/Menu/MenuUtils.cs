using System;
using System.Collections.Generic;
using Language;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// Class containing some utilities for creating Menu Screens in the default style.
	/// </summary>
	// Token: 0x02000DC7 RID: 3527
	public static class MenuUtils
	{
		/// <summary>
		/// Create a MenuBuilder with the default size and position data, but no content or controls.
		/// </summary>
		/// <param name="title">The title to give the menu screen.</param>
		/// <returns>The MenuBuilder object.</returns>
		// Token: 0x0600492C RID: 18732 RVA: 0x0018C7D8 File Offset: 0x0018A9D8
		public static MenuBuilder CreateMenuBuilder(string title)
		{
			return new MenuBuilder(title).CreateTitle(title, MenuTitleStyle.vanillaStyle).CreateContentPane(RectTransformData.FromSizeAndPos(new RelVector2(new Vector2(1920f, 903f)), new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -60f)))).CreateControlPane(RectTransformData.FromSizeAndPos(new RelVector2(new Vector2(1920f, 259f)), new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -502f)))).SetDefaultNavGraph(new ChainedNavGraph(ChainedNavGraph.ChainDir.Down));
		}

		/// <summary>
		/// Create a MenuBuilder with the default size and position data and a back button, but no content.
		/// </summary>
		/// <param name="title">The title to give the menu screen.</param>
		/// <param name="returnScreen">The screen to return to when the user hits back.</param>
		/// <param name="backButton">The back button.</param>
		/// <returns>The MenuBuilder object.</returns>
		// Token: 0x0600492D RID: 18733 RVA: 0x0018C8A4 File Offset: 0x0018AAA4
		public static MenuBuilder CreateMenuBuilderWithBackButton(string title, MenuScreen returnScreen, out MenuButton backButton)
		{
			MenuButton _backButton = null;
			Action<MenuSelectable> <>9__1;
			Action<MenuButton> <>9__2;
			MenuBuilder result = MenuUtils.CreateMenuBuilder(title).AddControls(new SingleContentLayout(new AnchoredPosition(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -64f))), delegate(ContentArea c)
			{
				string name = "BackButton";
				MenuButtonConfig config = default(MenuButtonConfig);
				config.Label = Language.Get("NAV_BACK", "MainMenu");
				Action<MenuSelectable> cancelAction;
				if ((cancelAction = <>9__1) == null)
				{
					cancelAction = (<>9__1 = delegate(MenuSelectable _)
					{
						((UIManager)UIManager.instance).UIGoToDynamicMenu(returnScreen);
					});
				}
				config.CancelAction = cancelAction;
				Action<MenuButton> submitAction;
				if ((submitAction = <>9__2) == null)
				{
					submitAction = (<>9__2 = delegate(MenuButton _)
					{
						((UIManager)UIManager.instance).UIGoToDynamicMenu(returnScreen);
					});
				}
				config.SubmitAction = submitAction;
				config.Proceed = true;
				config.Style = new MenuButtonStyle?(MenuButtonStyle.VanillaStyle);
				c.AddMenuButton(name, config, out _backButton);
			});
			backButton = _backButton;
			return result;
		}

		/// <summary>
		/// Add Horizontal Options to the content area.
		/// </summary>
		/// <param name="entries">The menu data.</param>
		/// <param name="c">The content area to add the entries to.</param>
		/// <param name="returnScreen">The screen to return to when the user hits cancel.</param>
		// Token: 0x0600492E RID: 18734 RVA: 0x0018C91C File Offset: 0x0018AB1C
		public static void AddModMenuContent(List<IMenuMod.MenuEntry> entries, ContentArea c, MenuScreen returnScreen)
		{
			using (List<IMenuMod.MenuEntry>.Enumerator enumerator = entries.GetEnumerator())
			{
				Action<MenuSelectable> <>9__2;
				while (enumerator.MoveNext())
				{
					IMenuMod.MenuEntry entry = enumerator.Current;
					string name = entry.Name;
					HorizontalOptionConfig config = default(HorizontalOptionConfig);
					config.ApplySetting = delegate(MenuSetting _, int i)
					{
						entry.Saver(i);
					};
					config.RefreshSetting = delegate(MenuSetting s, bool _)
					{
						s.optionList.SetOptionTo(entry.Loader());
					};
					Action<MenuSelectable> cancelAction;
					if ((cancelAction = <>9__2) == null)
					{
						cancelAction = (<>9__2 = delegate(MenuSelectable _)
						{
							((UIManager)UIManager.instance).UIGoToDynamicMenu(returnScreen);
						});
					}
					config.CancelAction = cancelAction;
					config.Description = (string.IsNullOrEmpty(entry.Description) ? null : new DescriptionInfo?(new DescriptionInfo
					{
						Text = entry.Description
					}));
					config.Label = entry.Name;
					config.Options = entry.Values;
					config.Style = new HorizontalOptionStyle?(HorizontalOptionStyle.VanillaStyle);
					MenuOptionHorizontal menuOptionHorizontal;
					c.AddHorizontalOption(name, config, out menuOptionHorizontal);
					menuOptionHorizontal.menuSetting.RefreshValueFromGameSettings(false);
				}
			}
		}

		/// <summary>
		/// Create a menu screen in the default style.
		/// </summary>
		/// <param name="title">The title to give the menu screen.</param>
		/// <param name="menuData">The data for the horizontal options.</param>
		/// <param name="returnScreen">The screen to return to when the user hits back.</param>
		/// <returns>A built menu screen in the default style.</returns>
		// Token: 0x0600492F RID: 18735 RVA: 0x0018CA80 File Offset: 0x0018AC80
		public static MenuScreen CreateMenuScreen(string title, List<IMenuMod.MenuEntry> menuData, MenuScreen returnScreen)
		{
			MenuButton backButton;
			MenuBuilder menuBuilder = MenuUtils.CreateMenuBuilderWithBackButton(title, returnScreen, out backButton);
			if (menuData.Count > 5)
			{
				Action<MenuPreventDeselect> <>9__3;
				Action<ContentArea> <>9__2;
				menuBuilder.AddContent(default(NullContentLayout), delegate(ContentArea c)
				{
					ScrollbarConfig scrollbarConfig = default(ScrollbarConfig);
					Action<MenuPreventDeselect> cancelAction;
					if ((cancelAction = <>9__3) == null)
					{
						cancelAction = (<>9__3 = delegate(MenuPreventDeselect _)
						{
							((UIManager)UIManager.instance).UIGoToDynamicMenu(returnScreen);
						});
					}
					scrollbarConfig.CancelAction = cancelAction;
					scrollbarConfig.Navigation = new Navigation
					{
						mode = Navigation.Mode.Explicit,
						selectOnUp = backButton,
						selectOnDown = backButton
					};
					scrollbarConfig.Position = new AnchoredPosition
					{
						ChildAnchor = new Vector2(0f, 1f),
						ParentAnchor = new Vector2(1f, 1f),
						Offset = new Vector2(-310f, 0f)
					};
					ScrollbarConfig config = scrollbarConfig;
					RelLength contentHeight = new RelLength((float)menuData.Count * 105f);
					IContentLayout layout = RegularGridLayout.CreateVerticalLayout(105f, default(Vector2));
					Action<ContentArea> action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate(ContentArea c)
						{
							MenuUtils.AddModMenuContent(menuData, c, returnScreen);
						});
					}
					c.AddScrollPaneContent(config, contentHeight, layout, action);
				});
			}
			else
			{
				menuBuilder.AddContent(RegularGridLayout.CreateVerticalLayout(105f, default(Vector2)), delegate(ContentArea c)
				{
					MenuUtils.AddModMenuContent(menuData, c, returnScreen);
				});
			}
			return menuBuilder.Build();
		}
	}
}
