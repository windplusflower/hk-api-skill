using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// Cached resources for the menu api to use
	/// </summary>
	// Token: 0x02000DC6 RID: 3526
	public class MenuResources
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x0018C59C File Offset: 0x0018A79C
		// (set) Token: 0x06004916 RID: 18710 RVA: 0x0018C5A3 File Offset: 0x0018A7A3
		public static Font TrajanRegular { get; private set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x0018C5AB File Offset: 0x0018A7AB
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x0018C5B2 File Offset: 0x0018A7B2
		public static Font TrajanBold { get; private set; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x0018C5BA File Offset: 0x0018A7BA
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x0018C5C1 File Offset: 0x0018A7C1
		public static Font Perpetua { get; private set; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x0018C5C9 File Offset: 0x0018A7C9
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x0018C5D0 File Offset: 0x0018A7D0
		public static Font NotoSerifCJKSCRegular { get; private set; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x0018C5D8 File Offset: 0x0018A7D8
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x0018C5DF File Offset: 0x0018A7DF
		public static RuntimeAnimatorController MenuTopFleurAnimator { get; private set; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x0018C5E7 File Offset: 0x0018A7E7
		// (set) Token: 0x06004920 RID: 18720 RVA: 0x0018C5EE File Offset: 0x0018A7EE
		public static RuntimeAnimatorController MenuCursorAnimator { get; private set; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06004921 RID: 18721 RVA: 0x0018C5F6 File Offset: 0x0018A7F6
		// (set) Token: 0x06004922 RID: 18722 RVA: 0x0018C5FD File Offset: 0x0018A7FD
		public static RuntimeAnimatorController MenuButtonFlashAnimator { get; private set; }

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x0018C605 File Offset: 0x0018A805
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x0018C60C File Offset: 0x0018A80C
		public static AnimatorOverrideController TextHideShowAnimator { get; private set; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x0018C614 File Offset: 0x0018A814
		// (set) Token: 0x06004926 RID: 18726 RVA: 0x0018C61B File Offset: 0x0018A81B
		public static Sprite ScrollbarHandleSprite { get; private set; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06004927 RID: 18727 RVA: 0x0018C623 File Offset: 0x0018A823
		// (set) Token: 0x06004928 RID: 18728 RVA: 0x0018C62A File Offset: 0x0018A82A
		public static Sprite ScrollbarBackgroundSprite { get; private set; }

		// Token: 0x06004929 RID: 18729 RVA: 0x0018C632 File Offset: 0x0018A832
		static MenuResources()
		{
			MenuResources.ReloadResources();
		}

		/// <summary>
		/// Reloads all resources, searching to find each one again.
		/// </summary>
		// Token: 0x0600492A RID: 18730 RVA: 0x0018C63C File Offset: 0x0018A83C
		public static void ReloadResources()
		{
			foreach (RuntimeAnimatorController runtimeAnimatorController in Resources.FindObjectsOfTypeAll<RuntimeAnimatorController>())
			{
				if (runtimeAnimatorController != null)
				{
					string name = runtimeAnimatorController.name;
					if (!(name == "Menu Animate In Out"))
					{
						if (!(name == "Menu Fleur"))
						{
							if (name == "Menu Flash Effect")
							{
								MenuResources.MenuButtonFlashAnimator = runtimeAnimatorController;
							}
						}
						else
						{
							MenuResources.MenuCursorAnimator = runtimeAnimatorController;
						}
					}
					else
					{
						MenuResources.MenuTopFleurAnimator = runtimeAnimatorController;
					}
				}
			}
			foreach (AnimatorOverrideController animatorOverrideController in Resources.FindObjectsOfTypeAll<AnimatorOverrideController>())
			{
				if (animatorOverrideController != null && animatorOverrideController.name == "TextHideShow")
				{
					MenuResources.TextHideShowAnimator = animatorOverrideController;
				}
			}
			foreach (Font font in Resources.FindObjectsOfTypeAll<Font>())
			{
				if (font != null)
				{
					string name = font.name;
					if (!(name == "TrajanPro-Regular"))
					{
						if (!(name == "TrajanPro-Bold"))
						{
							if (!(name == "Perpetua"))
							{
								if (name == "NotoSerifCJKsc-Regular")
								{
									MenuResources.NotoSerifCJKSCRegular = font;
								}
							}
							else
							{
								MenuResources.Perpetua = font;
							}
						}
						else
						{
							MenuResources.TrajanBold = font;
						}
					}
					else
					{
						MenuResources.TrajanRegular = font;
					}
				}
			}
			foreach (Sprite sprite in Resources.FindObjectsOfTypeAll<Sprite>())
			{
				if (sprite != null)
				{
					string name = sprite.name;
					if (!(name == "scrollbar_fleur_new"))
					{
						if (name == "scrollbar_single")
						{
							MenuResources.ScrollbarBackgroundSprite = sprite;
						}
					}
					else
					{
						MenuResources.ScrollbarHandleSprite = sprite;
					}
				}
			}
		}
	}
}
